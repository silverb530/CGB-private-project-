using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static CGB.DataClass;

namespace CGB
{
    public partial class Booking : UserControl
    {
        private string movieTitle;
        private string selectedDate;
        private movieSchedule selectedSchedule;
        private readonly Dictionary<string, Button> seatButtons = new();
        private readonly List<string> selectedSeats = new();

        public Booking() { InitializeComponent(); }

        public Booking(string title)
        {
            InitializeComponent();
            movieTitle = title;
            lb_movie_title.Text = title;
            LoadDateButtons();
            SetTimeStep(false);
            SetSeatStep(false);
        }

        public Booking(string title, string preselectedDate) : this(title)
        {
            foreach (Button b in fp_dates.Controls.OfType<Button>())
            {
                if (b.Tag?.ToString() == preselectedDate)
                {
                    b.PerformClick();
                    break;
                }
            }
        }

        // ── 단계 활성/비활성 ────────────────────────────────────────────
        private void SetTimeStep(bool on)
        {
            pnl_time.BackColor   = on ? Theme.CardBG : Theme.StepDisabled;
            lb_step2.ForeColor   = on ? Theme.TextSub : Theme.TextMuted;
            lb_time_hint.Visible = !on;
        }

        private void SetSeatStep(bool on)
        {
            pnl_seats.BackColor = on ? Theme.CardBG : Theme.StepDisabled;
            lb_step3.ForeColor  = on ? Theme.TextSub : Theme.TextMuted;
            lb_screen.ForeColor = on ? Theme.TextSub : Theme.TextMuted;
            lb_screen.BackColor = on ? Theme.Border : Color.FromArgb(35, 35, 52);
            lb_leg_avail.ForeColor = on ? Theme.SeatAvail : Theme.TextMuted;
            lb_leg_sel.ForeColor   = on ? Theme.SeatSel   : Theme.TextMuted;
            lb_leg_taken.ForeColor = on ? Theme.SeatTaken  : Theme.TextMuted;
        }

        // ── STEP 1: 날짜 버튼 ───────────────────────────────────────────
        private void LoadDateButtons()
        {
            fp_dates.Controls.Clear();
            DateTime today = DateTime.Today;
            string[] days = { "일", "월", "화", "수", "목", "금", "토" };

            for (int i = 0; i < 7; i++)
            {
                DateTime d = today.AddDays(i);
                var btn = new Button();
                btn.Text = i == 0
                    ? $"오늘\n{d:MM/dd}"
                    : $"{days[(int)d.DayOfWeek]}\n{d:MM/dd}";
                btn.Tag = d.ToString("yyyy-MM-dd");
                btn.Size = new Size(88, 52);
                btn.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
                btn.ForeColor = Theme.TextSub;
                btn.BackColor = Theme.BG;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Theme.Border;
                btn.FlatAppearance.BorderSize = 1;
                btn.Margin = new Padding(0, 0, 6, 0);
                btn.Cursor = Cursors.Hand;
                btn.Click += DateBtn_Click;
                fp_dates.Controls.Add(btn);
            }
        }

        private void DateBtn_Click(object sender, EventArgs e)
        {
            foreach (Button b in fp_dates.Controls.OfType<Button>())
            {
                b.BackColor = Theme.BG;
                b.ForeColor = Theme.TextSub;
                b.FlatAppearance.BorderColor = Theme.Border;
            }
            var btn = (Button)sender;
            btn.BackColor = Theme.Accent;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = Theme.Accent;

            selectedDate = btn.Tag.ToString();
            selectedSchedule = null;
            selectedSeats.Clear();
            seatButtons.Clear();
            pnl_seatgrid.Controls.Clear();

            LoadScheduleButtons(selectedDate);
            SetTimeStep(true);
            SetSeatStep(false);
            UpdateConfirmSection();
        }

        // ── STEP 2: 시간/상영관 버튼 ────────────────────────────────────
        private void LoadScheduleButtons(string dateKey)
        {
            fp_times.Controls.Clear();
            var schedules = DataTemp.GetSchedules(movieTitle, dateKey);
            lb_time_hint.Text    = schedules.Count == 0 ? "이 날짜에는 상영 정보가 없습니다" : "";
            lb_time_hint.Visible = schedules.Count == 0;

            foreach (var sch in schedules)
            {
                int avail = sch.AvailableSeats;
                bool full = avail <= 0;
                var btn = new Button();
                btn.Text = $"{sch.start_time}\n{sch.room}  {(full ? "매진" : avail + "석")}";
                btn.Tag = sch;
                btn.Size = new Size(105, 52);
                btn.Font = new Font("맑은 고딕", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
                btn.ForeColor = full ? Theme.TextMuted : Theme.TextSub;
                btn.BackColor = Theme.BG;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = full ? Theme.SeatTaken : Theme.Border;
                btn.FlatAppearance.BorderSize = 1;
                btn.Margin = new Padding(0, 0, 6, 0);
                btn.Enabled = !full;
                btn.Cursor = full ? Cursors.Default : Cursors.Hand;
                btn.Click += ScheduleBtn_Click;
                fp_times.Controls.Add(btn);
            }
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            foreach (Button b in fp_times.Controls.OfType<Button>())
            {
                b.BackColor = Theme.BG;
                b.ForeColor = Theme.TextSub;
                b.FlatAppearance.BorderColor = Theme.Border;
            }
            var btn = (Button)sender;
            btn.BackColor = Theme.Accent;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = Theme.Accent;

            selectedSchedule = (movieSchedule)btn.Tag;
            selectedSeats.Clear();

            SetSeatStep(true);
            BuildSeatGrid(selectedSchedule.bookedSeats);
            UpdateConfirmSection();
        }

        // ── STEP 3: 좌석 그리드 ────────────────────────────────────────
        private void BuildSeatGrid(List<string> bookedSeats)
        {
            pnl_seatgrid.Controls.Clear();
            seatButtons.Clear();

            const int btnW = 64, btnH = 38, gapX = 8, gapY = 8;
            const int startX = 40, startY = 26;

            // 열 번호 헤더
            for (int c = 1; c <= 6; c++)
            {
                var lbl = new Label
                {
                    Text = c.ToString(),
                    ForeColor = Theme.TextMuted,
                    Font = new Font("맑은 고딕", 8.5F, GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(btnW, 20),
                    Location = new Point(startX + (c - 1) * (btnW + gapX), 4)
                };
                pnl_seatgrid.Controls.Add(lbl);
            }

            for (int r = 0; r < 5; r++)
            {
                char rowChar = (char)('A' + r);

                // 행 레이블
                pnl_seatgrid.Controls.Add(new Label
                {
                    Text = rowChar.ToString(),
                    ForeColor = Theme.TextSub,
                    Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(32, btnH),
                    Location = new Point(4, startY + r * (btnH + gapY))
                });

                for (int c = 1; c <= 6; c++)
                {
                    string seatId = $"{rowChar}{c}";
                    bool taken = bookedSeats.Contains(seatId);
                    var btn = new Button
                    {
                        Size = new Size(btnW, btnH),
                        Text = seatId,
                        Font = new Font("맑은 고딕", 8F, GraphicsUnit.Point),
                        FlatStyle = FlatStyle.Flat,
                        Tag = seatId,
                        Location = new Point(startX + (c - 1) * (btnW + gapX), startY + r * (btnH + gapY)),
                        BackColor = taken ? Theme.SeatTaken : Theme.SeatAvail,
                        ForeColor = taken ? Theme.TextMuted : Color.White,
                        Enabled = !taken,
                        Cursor = taken ? Cursors.Default : Cursors.Hand
                    };
                    btn.FlatAppearance.BorderSize = 0;
                    if (!taken) btn.Click += SeatBtn_Click;
                    seatButtons[seatId] = btn;
                    pnl_seatgrid.Controls.Add(btn);
                }
            }
        }

        private void SeatBtn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string seatId = btn.Tag.ToString();

            if (selectedSeats.Contains(seatId))
            {
                selectedSeats.Remove(seatId);
                btn.BackColor = Theme.SeatAvail;
            }
            else
            {
                selectedSeats.Add(seatId);
                selectedSeats.Sort();
                btn.BackColor = Theme.SeatSel;
            }
            UpdateConfirmSection();
        }

        // ── 하단 확인 영역 ──────────────────────────────────────────────
        private void UpdateConfirmSection()
        {
            if (selectedSeats.Count == 0)
            {
                lb_selected.Text = "선택 좌석: (없음)";
                lb_price.Text    = "결제 금액: 0원";
                btn_confirm.Enabled = false;
            }
            else
            {
                lb_selected.Text = $"선택 좌석: {string.Join(", ", selectedSeats)}  ({selectedSeats.Count}석)";
                lb_price.Text    = $"결제 금액: {selectedSeats.Count * 15_000:N0}원";
                btn_confirm.Enabled = true;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (selectedSchedule == null || selectedSeats.Count == 0) return;

            int totalPrice = selectedSeats.Count * 15_000;

            using var payDlg = new PaymentForm(
                movieTitle, selectedDate,
                selectedSchedule.start_time, selectedSchedule.room,
                new List<string>(selectedSeats), totalPrice);

            if (payDlg.ShowDialog(this.FindForm()) != DialogResult.OK) return;

            string method = payDlg.SelectedMethod;

            var booking = new bookingInfo(
                movieTitle, DataTemp.currentUser.id,
                new List<string>(selectedSeats),
                selectedDate, selectedSchedule.start_time, selectedSchedule.room);

            DataTemp.bookingList.Add(booking);
            selectedSchedule.AddBooking(new List<string>(selectedSeats));

            MessageBox.Show(
                $"예매가 완료되었습니다!\n\n" +
                $"▶  영화: {movieTitle}\n" +
                $"▶  날짜: {selectedDate}\n" +
                $"▶  시간: {selectedSchedule.start_time} ~ {selectedSchedule.end_time}\n" +
                $"▶  상영관: {selectedSchedule.room}\n" +
                $"▶  좌석: {string.Join(", ", selectedSeats)}\n" +
                $"▶  결제수단: {method}\n" +
                $"▶  결제금액: {totalPrice:N0}원",
                "예매 완료", MessageBoxButtons.OK);

            (this.FindForm() as Main)?.ShowMenuScreen(new Main_main());
        }
    }
}
