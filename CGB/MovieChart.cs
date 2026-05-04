namespace CGB
{
    public partial class MovieChart : UserControl
    {
        public MovieChart()
        {
            InitializeComponent();
            movieInfo_read("p1");
        }

        private void poster_click(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            if (ctrl?.Tag != null)
                movieInfo_read(ctrl.Tag.ToString());
        }

        private void movieInfo_read(string tag)
        {
            // 포스터 테두리 초기화
            img_poster1.BackColor = Theme.BG;
            img_poster2.BackColor = Theme.BG;
            img_poster3.BackColor = Theme.BG;
            img_poster4.BackColor = Theme.BG;

            DataClass.MovieInfo info;
            switch (tag)
            {
                case "p2": info = DataTemp.movieList[1]; img_poster2.BackColor = Theme.Accent; break;
                case "p3": info = DataTemp.movieList[2]; img_poster3.BackColor = Theme.Accent; break;
                case "p4": info = DataTemp.movieList[3]; img_poster4.BackColor = Theme.Accent; break;
                default:   info = DataTemp.movieList[0]; img_poster1.BackColor = Theme.Accent; break;
            }

            lb_title.Text    = info.mName;
            lb_opendate.Text = $"개봉일: {info.openDate}";
            lb_rating.Text   = $"등급: {info.rating}";
            lb_runtime.Text  = $"러닝타임: {info.runningTime}";
            lb_dist.Text     = $"배급: {info.rationing}";
            txt_info.Text    = info.intro;
        }
    }
}
