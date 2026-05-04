namespace CGB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ShowMenuScreen(new Main_main());
        }

        public void ShowMenuScreen(UserControl screen)
        {
            bool loggedIn = DataTemp.currentUser != null;
            btn_login.Visible  = !loggedIn;
            btn_join.Visible   = !loggedIn;
            btn_logout.Visible = loggedIn;
            lb_resCnfm.Visible = loggedIn;

            panel_main.Controls.Clear();
            var next = screen ?? new Main_main();
            next.Dock = DockStyle.Fill;
            panel_main.Controls.Add(next);
        }

        private void pictureBox1_Click(object sender, EventArgs e) => ShowMenuScreen(new Main_main());

        private void btn_login_Click(object sender, EventArgs e)    => ShowMenuScreen(new Login());
        private void btn_join_Click(object sender, EventArgs e)     => ShowMenuScreen(new Join());
        private void btn_logout_Click(object sender, EventArgs e)
        {
            DataTemp.currentUser = null;
            ShowMenuScreen(new Main_main());
        }

        private void menu_Click(object sender, EventArgs e)
        {
            string name = (sender as Label)?.Name;
            if (name == "lb_menu_1")
                ShowMenuScreen(new MovieChart());
            else if (name == "lb_menu_book")
            {
                if (DataTemp.currentUser == null) { MessageBox.Show("로그인 후 이용하실 수 있습니다.", "알림"); ShowMenuScreen(new Login()); }
                else ShowMenuScreen(new Schedule());
            }
            else if (name == "lb_resCnfm")
                ShowMenuScreen(new BookingCheck());
        }
    }
}
