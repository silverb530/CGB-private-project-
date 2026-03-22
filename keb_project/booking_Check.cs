using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keb_project
{
    public partial class booking_Check : UserControl
    {
        public booking_Check()
        {
            InitializeComponent();
        }

        private void booking_Check_Load(object sender, EventArgs e)
        {

            lb_seat.Text = "";
            foreach (DataClass.bookingInfo bk in DataTemp.bookingList){
                lb_title.Text = bk.title;
                lb_date.Text = bk.date;
                lb_room.Text = bk.room;
                lb_time.Text = bk.time;
                for(int i = 0; i<bk.seat.Count; i++)
                {
                    lb_seat.Text += bk.seat[i] + " ";
                }
            }
        }
    }
}
