

namespace CGB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DataTemp.initMovieData();

            Main_main main = new Main_main();
            ShowMenuScreen(main);

        }


        // 화면 이동
        public void ShowMenuScreen(UserControl nextForm)
        {
            if (DataTemp.currentUser != null)
            {
                btn_login.Visible = false;
                btn_join.Visible = false;
                btn_logout.Visible = true;
                lb_resCnfm.Visible = true;
            }
            else
            {
                btn_login.Visible = true;
                btn_join.Visible = true;
                btn_logout.Visible = false;
                lb_resCnfm.Visible = false;
            }

            panel_main.Controls.Clear();
            if (nextForm == null)
            {
                nextForm = new Main_main();
            }
            panel_main.Controls.Add(nextForm);

        }

        // 로그인버튼
        private void btn_login_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Login login = new Login();
            panel_main.Controls.Add(login);

        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            DataTemp.currentUser = null;
            ShowMenuScreen(new Main_main());
        }


        // 회원가입버튼
        private void btn_join_Click(object sender, EventArgs e)
        {
            Join join = new Join();

            panel_main.Controls.Clear();
            panel_main.Controls.Add(join);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowMenuScreen(new Main_main());
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Label menu = sender as Label;
            string menuNm = menu.Name;

            panel_main.Controls.Clear();

            if (menuNm == "lb_menu_1")
            {
                ShowMenuScreen(new MovieChart());

            }
            else if (menuNm == "lb_menu_book")
            {
                if (DataTemp.currentUser == null)
                {
                    MessageBox.Show("로그인 후 예매가 가능합니다");
                    ShowMenuScreen(new Login());
                }
                else
                {
                    //ShowMenuScreen(new booking());
                }
            }
            else if (menuNm == "lb_resCnfm")
            {
                //ShowMenuScreen(new booking_Check());
            }
        }
    }
}
