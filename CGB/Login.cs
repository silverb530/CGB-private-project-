namespace CGB
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lb_join_Click(object sender, EventArgs e)
        {
            (this.FindForm() as Main)?.ShowMenuScreen(new Join());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            (this.FindForm() as Main)?.ShowMenuScreen(new FindId());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            (this.FindForm() as Main)?.ShowMenuScreen(new FindPw());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text.Trim();
            string pw = tb_password.Text;

            if (id == "" || pw == "")
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해 주세요.", "알림");
                return;
            }

            foreach (DataClass.UserInfo info in DataTemp.usersList)
            {
                if (info.id == id && info.password == pw)
                {
                    MessageBox.Show($"환영합니다!\n{info.name}님", "로그인 성공");
                    DataTemp.currentUser = info;
                    (this.FindForm() as Main)?.ShowMenuScreen(new Main_main());
                    return;
                }
            }

            MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.", "로그인 실패");
        }
    }
}
