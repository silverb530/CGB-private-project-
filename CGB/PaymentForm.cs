using System.Drawing;
using System.Windows.Forms;

namespace CGB
{
    public partial class PaymentForm : Form
    {
        public string SelectedMethod { get; private set; }

        private readonly string _movieTitle;
        private readonly string _date;
        private readonly string _time;
        private readonly string _room;
        private readonly List<string> _seats;
        private readonly int _totalPrice;

        public PaymentForm(string movieTitle, string date, string time, string room,
                           List<string> seats, int totalPrice)
        {
            _movieTitle = movieTitle;
            _date       = date;
            _time       = time;
            _room       = room;
            _seats      = seats;
            _totalPrice = totalPrice;

            InitializeComponent();
            PopulateInfo();
        }

        private void PopulateInfo()
        {
            lb_movie.Text  = _movieTitle;
            lb_detail.Text = $"{_date}  |  {_time}  |  {_room}";
            lb_seats.Text  = $"좌석: {string.Join(", ", _seats)}  ({_seats.Count}석)";
            lb_amount.Text = $"{_totalPrice:N0}원";
        }

        private void btn_card_Click(object sender, EventArgs e)
        {
            SelectedMethod = "카드";
            DialogResult   = DialogResult.OK;
            Close();
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            SelectedMethod = "현금";
            DialogResult   = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using var pen = new Pen(Theme.Accent, 2);
            e.Graphics.DrawRectangle(pen, 1, 1, Width - 3, Height - 3);
        }
    }
}
