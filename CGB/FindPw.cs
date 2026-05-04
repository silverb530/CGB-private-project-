namespace CGB
{
    public partial class FindPw : UserControl
    {
        public FindPw()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string id    = txt_id.Text.Trim();
            string name  = txt_name.Text.Trim();
            string phone = txt_phone.Text.Trim().Replace("-", "");

            if (id == "" || name == "" || phone == "")
            {
                lb_result.ForeColor = System.Drawing.Color.OrangeRed;
                lb_result.Text = "모든 항목을 입력해 주세요.";
                return;
            }

            foreach (var u in DataTemp.usersList)
            {
                string uPhone = (u.phone ?? "").Replace("-", "");
                if (u.id == id && u.name == name && uPhone == phone)
                {
                    lb_result.ForeColor = Theme.Accent;
                    lb_result.Text = $"비밀번호:  {u.password}";
                    return;
                }
            }

            lb_result.ForeColor = System.Drawing.Color.OrangeRed;
            lb_result.Text = "일치하는 회원 정보가 없습니다.";
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            (this.FindForm() as Main)?.ShowMenuScreen(new Login());
        }
    }
}
