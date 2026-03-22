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
    public partial class Join : UserControl
    {
        public Join()
        {
            InitializeComponent();
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string pw = txt_pw.Text;
            string name = txt_name.Text;

            DataClass.UserInfo ui = new DataClass.UserInfo(name, id, pw);

            DataTemp.usersList.Add(ui);

            MessageBox.Show("환영합니다 " + ui.name + "님! 로그인 후 이용 해 주세요");

            var main = this.FindForm() as Main;

            if (main != null)
            {
                main.ShowMenuScreen(new Main_main());
            }
        }
    }
}
