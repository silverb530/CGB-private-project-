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
    public partial class Movie_info : Form
    {
        public Movie_info()
        {
            InitializeComponent();

            wmp_video.uiMode = "none";

            string youtubeUrl = "C:\\Users\\모블\\Desktop\\강은비\\왕과 사는 남자.mp4";
            wmp_video.URL = youtubeUrl;
            wmp_video.Ctlcontrols.play();

            lb_title.Text = DataTemp.movie1.mName;
            lb_openDate.Text = DataTemp.movie1.openDate;
            lb_rating.Text = DataTemp.movie1.rating;
            lb_rationing.Text = DataTemp.movie1.rationing;
            lb_runtime.Text = DataTemp.movie1.runningTime;
            txt_intro.Text = DataTemp.movie1.intro;
        }
    }
}
