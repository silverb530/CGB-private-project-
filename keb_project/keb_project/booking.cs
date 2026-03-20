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
    public partial class booking : UserControl
    {
        int index = 0;
        public static string title;
        public static string date;
        public static string time;

        public booking()
        {
            InitializeComponent();
            DataTemp.initPosterData();
            posterChange();

            UserControl parent = new Main_MovieChart();

            //grp_seat_1.Visible = false;
            //grp_seat_2.Visible = false;
            //grp_seat.Visible = false;
            //grp_seat_4.Visible = false;


        }

        private void arrow_r_Click(object sender, EventArgs e)
        {
            index++;
            if (index > DataTemp.movieList.Count)
            {
                index = DataTemp.movieList.Count;
            }
            posterChange();
        }

        private void arrow_l_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = 0;
            }
            posterChange();
        }

        private void posterChange()
        {
            DataClass.MovieInfo mi = DataTemp.movieList[index];
            string pPath = @DataTemp.posterList[index];
            pb_poster.Image = Image.FromFile(pPath);

            lb_title.Text = DataTemp.titleList[index];
            title = lb_title.Text;
        }

        Button beforeDate;
        private void btn_today_Click(object sender, EventArgs e)
        {
            Button curbtn = (Button)sender;
            if(beforeDate != null)
            {
                beforeDate.BackColor = Color.White;
            }
            curbtn.BackColor = Color.FromArgb(255, 192, 192);
           
            beforeDate = curbtn;

            date = curbtn.Tag.ToString();

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            var main = this.FindForm() as mainForm;

            if (main != null)
            {
                main.ShowMenuScreen(new booking2());
            }
        }
        Button beforeTime;
        private void btn_time_Click(object sender, EventArgs e)
        {
            Button curbtn = (Button)sender;

            if (beforeTime != null)
            {
                beforeTime.BackColor = Color.White;
            }
            curbtn.BackColor = Color.FromArgb(255, 192, 192);

            beforeTime = curbtn;

            lb_time.Text = curbtn.Tag.ToString();
            time = curbtn.Tag.ToString();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_ addModal = new Add_();
            addModal.Show();
            lb_loc.Text = addModal.cgbLoc;
            //addModal.Dispose();
        }
    }
}
