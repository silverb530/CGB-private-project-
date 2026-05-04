using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static CGB.DataClass;

namespace CGB
{
    public partial class BookingCheck : UserControl
    {
        public BookingCheck()
        {
            InitializeComponent();
            if (DataTemp.currentUser != null)
                lb_username.Text = $"( {DataTemp.currentUser.name}님 )";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadBookings();
        }

        private void LoadBookings()
        {
            pnl_scroll.Controls.Clear();

            var myBookings = DataTemp.bookingList
                .Where(b => b.id == DataTemp.currentUser?.id)
                .ToList();

            if (myBookings.Count == 0)
            {
                lb_no_booking.Visible = true;
                return;
            }
            lb_no_booking.Visible = false;

            int y = 0;
            foreach (var b in myBookings)
            {
                var card = BuildCard(b);
                card.Location = new Point(0, y);
                pnl_scroll.Controls.Add(card);
                y += card.Height + 14;
            }
        }

        private Panel BuildCard(bookingInfo b)
        {
            int cardW = Math.Max(600, pnl_scroll.ClientSize.Width - 20);

            var card = new Panel
            {
                Size = new Size(cardW, 138),
                BackColor = Theme.CardBG
            };

            // 영화 제목
            var lb_movie = new Label
            {
                Text = b.title,
                Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Theme.Accent,
                Location = new Point(18, 14),
                AutoSize = true
            };

            // 날짜 / 시간 / 상영관
            var lb_info = new Label
            {
                Text = $"{b.date}  |  {b.time}  |  {b.room}",
                Font = new Font("맑은 고딕", 10F, GraphicsUnit.Point),
                ForeColor = Theme.TextSub,
                Location = new Point(18, 50),
                AutoSize = true
            };

            // 좌석
            var lb_seat = new Label
            {
                Text = $"좌석: {string.Join(", ", b.seat)}  ({b.seat.Count}석)",
                Font = new Font("맑은 고딕", 10F, GraphicsUnit.Point),
                ForeColor = Theme.TextPrimary,
                Location = new Point(18, 76),
                AutoSize = true
            };

            // 결제금액
            var lb_price = new Label
            {
                Text = $"결제금액: {b.seat.Count * 15_000:N0}원",
                Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Theme.TextSub,
                Location = new Point(18, 102),
                AutoSize = true
            };

            // 취소 버튼
            var btn_cancel = new Button
            {
                Text = "예매 취소",
                Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(100, 30, 30),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(90, 36),
                Location = new Point(cardW - 112, 50),
                Cursor = Cursors.Hand,
                Tag = b
            };
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.Click += CancelBooking_Click;

            card.Controls.AddRange(new Control[] { lb_movie, lb_info, lb_seat, lb_price, btn_cancel });
            return card;
        }

        private void CancelBooking_Click(object sender, EventArgs e)
        {
            var b = (sender as Button)?.Tag as bookingInfo;
            if (b == null) return;

            if (MessageBox.Show($"'{b.title}' 예매를 취소하시겠습니까?",
                "예매 취소", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            DataTemp.bookingList.Remove(b);

            // 스케줄 좌석 복원
            var schedules = DataTemp.GetSchedules(b.title, b.date);
            var sch = schedules.FirstOrDefault(s => s.start_time == b.time && s.room == b.room);
            if (sch != null)
            {
                foreach (var seat in b.seat)
                    sch.bookedSeats.Remove(seat);
                sch.currentBooking = Math.Max(0, sch.currentBooking - b.seat.Count);
            }

            LoadBookings();
        }
    }
}
