namespace CGB
{
    public partial class FindId : UserControl
    {
        public FindId()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string name  = txt_name.Text.Trim();
            string phone = txt_phone.Text.Trim().Replace("-", "");

            if (name == "" || phone == "")
            {
                lb_result.ForeColor = System.Drawing.Color.OrangeRed;
                lb_result.Text = "이름과 전화번호를 모두 입력해 주세요.";
                return;
            }

            foreach (var u in DataTemp.usersList)
            {
                string uPhone = (u.phone ?? "").Replace("-", "");
                if (u.name == name && uPhone == phone)
                {
                    lb_result.ForeColor = Theme.Accent;
                    lb_result.Text = $"회원님의 아이디:  {MaskId(u.id)}";
                    return;
                }
            }

            lb_result.ForeColor = System.Drawing.Color.OrangeRed;
            lb_result.Text = "일치하는 회원 정보가 없습니다.";
        }

        private string MaskId(string id)
        {
            if (id.Length <= 2) return new string('*', id.Length);
            int show = id.Length / 2;
            return id.Substring(0, show) + new string('*', id.Length - show);
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            (this.FindForm() as Main)?.ShowMenuScreen(new Login());
        }
    }
}
