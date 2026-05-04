namespace CGB
{
    public partial class Join : UserControl
    {
        public Join()
        {
            InitializeComponent();
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            string id    = txt_id.Text.Trim();
            string pw    = txt_pw.Text;
            string name  = txt_name.Text.Trim();
            string phone = txt_phone.Text.Trim().Replace("-", "");

            if (id == "" || pw == "" || name == "" || phone == "")
            {
                MessageBox.Show("모든 항목을 입력해 주세요.", "알림");
                return;
            }

            foreach (var u in DataTemp.usersList)
            {
                if (u.id == id)
                {
                    MessageBox.Show("이미 사용 중인 아이디입니다.", "알림");
                    return;
                }
            }

            DataTemp.usersList.Add(new DataClass.UserInfo(name, id, pw, phone, ""));
            MessageBox.Show($"환영합니다, {name}님!\n로그인 후 이용해 주세요.", "가입 완료");

            (this.FindForm() as Main)?.ShowMenuScreen(new Login());
        }
    }
}
