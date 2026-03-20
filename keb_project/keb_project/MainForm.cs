using static keb_project.DataClass;

namespace keb_project
{
    public partial class mainForm : Form
    {

        private int oriX;
        private int oriY;
        private int oriWidth;
        private int oriHeight;
        private int zoom = 30;
        private int zoomLoc = 15;
        Font oriFont_select;
        Font oriFont;

        public mainForm()
        {
            InitializeComponent();
            DataTemp.initMovieData();

            Main_main main = new Main_main();
            ShowMenuScreen(main);

            oriFont_select = lb_menu_1.Font;
            oriFont = lb_menu_book.Font;
        }

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

        //UserInfo us = new UserInfo();

        private void btn_login_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Main_login login = new Main_login();
            panel_main.Controls.Add(login);

        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            Main_join join = new Main_join();

            panel_main.Controls.Clear();
            panel_main.Controls.Add(join);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowMenuScreen(new Main_main());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DataTemp.currentUser = null;
            ShowMenuScreen(new Main_main());
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Label menu = sender as Label;
            string menuNm = menu.Name;

            panel_main.Controls.Clear();

            if (menuNm == "lb_menu_1")
            {
                ShowMenuScreen(new Main_MovieChart());
                //panel_main.Controls.Add(m);

            }
            else if(menuNm == "lb_menu_book")
            {
                if(DataTemp.currentUser == null)
                {
                    MessageBox.Show("로그인 후 예매가 가능합니다");
                    ShowMenuScreen(new Main_login());
                }
                else
                {
                    ShowMenuScreen(new booking());
                }
            }
            else if(menuNm == "lb_resCnfm")
            {
                ShowMenuScreen(new booking_Check());
            }
            //menu.Font = oriFont_select;

            //foreach (Control c in panel_main.Controls)
            //{
            //        c.Text = "해제";

            //    if (c is Label label && label.Name.StartsWith("lb_menu_"))
            //    {
            //        //c.Font = oriFont;
            //    }
            //}
        }
    }
}
