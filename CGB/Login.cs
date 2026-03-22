using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGB
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            DataTemp.initData();
        }

        private void lb_join_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowMenuScreen(new Join());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string pw = tb_password.Text;

            if ((id != null && id != "") || (pw != null && pw != ""))
            {
                foreach (DataClass.UserInfo info in DataTemp.usersList)
                {
                    if (info.id == id && info.password == pw)
                    {

                        MessageBox.Show("환영합니다! \n" + info.name + "님");
                        DataTemp.currentUser = info;

                        var main = this.FindForm() as Main;

                        if (main != null)
                        {
                            main.ShowMenuScreen(new Main_main());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("아이디나 비밀번호가 입력되지 않았습니다.");
            }
        }
    }
}
