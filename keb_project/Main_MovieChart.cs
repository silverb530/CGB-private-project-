using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keb_project
{
    public partial class Main_MovieChart : UserControl
    {
        string movieTag;

        public Main_MovieChart()
        {
            InitializeComponent();
        }

        private void btn_booking_1_Click(object sender, EventArgs e)
        {
            Button bookBtn = (Button)sender;
            movieTag = bookBtn.Tag.ToString();

            var main = this.FindForm() as mainForm;

            if(main != null)
            {
                main.ShowMenuScreen(new booking());
            }
        }

        private void img_poster1_Click(object sender, EventArgs e)
        {
            Movie_info mInfoModal = new Movie_info();
            mInfoModal.ShowDialog();

            mInfoModal.Dispose();
        }
    }
}
