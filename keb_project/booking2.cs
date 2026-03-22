using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keb_project
{
    public partial class booking2 : UserControl
    {
        int cnt = 0;
        int oldvalue = 0;

        public booking2()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            string date = booking.date;
            string time = booking.time;
            string title = booking.title;

            foreach (Control c in this.Controls)
            {
                if (c is Button && (c.Tag.ToString() == date))
                {
                    c.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
            lb_time.Text = time;
            lb_title.Text = title;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int totcnt = (int)nud_1.Value + (int)nud_2.Value;
            cnt = totcnt;
            lb_totcnt.Text = cnt.ToString();

            int totPrice = (int)nud_1.Value * 15000 + (int)nud_2.Value * 11000;

            lb_totPrice.Text = "총 금액 " + totPrice.ToString() + "원";

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //NumericUpDown nud = (NumericUpDown)sender;
            //int val = (int)nud.Value;
            //if (oldvalue < val)
            //{
            //    cnt += val;
            //}
            //else if (oldvalue > val)
            //{
            //    cnt -= val;
            //}
            //lb_totcnt.Text = cnt.ToString();

        }

        private void count_memberCnt(int val)
        {

        }

        List<Button> selectedSeat = new List<Button>();
        private void seat_select_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (btn == null)
            {
                return;
            }

            if (selectedSeat.Contains(btn))
            {
                btn.BackColor = Color.White;
                selectedSeat.Remove(btn);
            }

            else
            {
                if (selectedSeat.Count >= cnt)
                {
                    MessageBox.Show($"최대 {cnt}명 까지만 선택 할 수 있습니다");
                    return;
                }

                btn.BackColor = Color.Orange;
                selectedSeat.Add(btn);

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("삼성카드");
                comboBox2.Items.Add("하나카드");
                comboBox2.Items.Add("신한카드");
                comboBox2.Items.Add("토스페이카드");
                comboBox2.Items.Add("KB카드");

                comboBox3.Visible = true;
            }


            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("KB국민은행");
                comboBox2.Items.Add("농협은행");
                comboBox2.Items.Add("하나은행");
                comboBox2.Items.Add("신한은행");
                comboBox3.Visible = false;
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            List<string> seat = new List<string>();
            foreach ( Button b in selectedSeat)
            {
                string name = b.Name;
                seat.Add(name);
            }

            DataClass dc = new DataClass();
            string id = DataTemp.currentUser.id;
            DataClass.bookingInfo bk = new DataClass.bookingInfo(booking.title, id, seat, booking.date, booking.time, "2관");

            DataTemp.bookingList.Add(bk);

            MessageBox.Show("결제가 완료 되었습니다");

            var main = this.FindForm() as mainForm;

            if (main != null)
            {
                main.ShowMenuScreen(new Main_main());
            }
        }
    }
}
