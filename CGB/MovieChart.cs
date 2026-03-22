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
    public partial class MovieChart : UserControl
    {
        public MovieChart()
        {
            InitializeComponent();
        }



        private void btn_booking_1_Click(object sender, EventArgs e)
        {

        }

        private void poster_click(object sender, EventArgs e)
        {
            string tagVal = sender.GetType().GetProperty("Tag").ToString();
                if (tagVal == "p1")
                {
                    Movie_info movieInfo = new Movie_info();
                    movieInfo.ShowDialog();
                }
                else if (tagVal == "p2")
                {
    
                }
                else if (tagVal == "p3")
                {
    
                }
                else if (tagVal == "p4")
                {

            }
        }
    }
}
