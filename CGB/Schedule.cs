using System.Drawing;
using System.Windows.Forms;

namespace CGB
{
    public partial class Schedule : UserControl
    {
        private string selectedDate = DateTime.Today.ToString("yyyy-MM-dd");

        public Schedule()
        {
            InitializeComponent();
            BuildDateButtons();
            BuildMovieRows();
        }

        private void BuildDateButtons()
        {
            fp_dates.Controls.Clear();
            string[] days = { "일", "월", "화", "수", "목", "금", "토" };

            for (int i = 0; i < 7; i++)
            {
                DateTime d = DateTime.Today.AddDays(i);
                string key = d.ToString("yyyy-MM-dd");
                bool sel = key == selectedDate;

                var btn = new Button
                {
                    Text = i == 0 ? $"오늘\n{d:MM/dd}" : $"{days[(int)d.DayOfWeek]}\n{d:MM/dd}",
                    Tag = key,
                    Size = new Size(88, 52),
                    Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = sel ? Color.White : Theme.TextSub,
                    BackColor = sel ? Theme.Accent : Theme.BG,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(0, 0, 6, 0),
                    Cursor = Cursors.Hand
                };
                btn.FlatAppearance.BorderColor = sel ? Theme.Accent : Theme.Border;
                btn.FlatAppearance.BorderSize = 1;
                btn.Click += DateBtn_Click;
                fp_dates.Controls.Add(btn);
            }
        }

        private void DateBtn_Click(object sender, EventArgs e)
        {
            selectedDate = ((Button)sender).Tag.ToString();

            foreach (Button b in fp_dates.Controls.OfType<Button>())
            {
                bool sel = b.Tag.ToString() == selectedDate;
                b.BackColor = sel ? Theme.Accent : Theme.BG;
                b.ForeColor = sel ? Color.White : Theme.TextSub;
                b.FlatAppearance.BorderColor = sel ? Theme.Accent : Theme.Border;
            }
            BuildMovieRows();
        }

        private void BuildMovieRows()
        {
            pnl_movies.Controls.Clear();
            var res = new System.ComponentModel.ComponentResourceManager(typeof(MovieChart));
            int y = 0;

            foreach (var movie in DataTemp.movieList)
            {
                var schedules = DataTemp.GetSchedules(movie.mName, selectedDate);
                string movieName = movie.mName;
                int idx = DataTemp.movieList.IndexOf(movie);

                var pnl = new Panel
                {
                    Location = new Point(0, y),
                    Size = new Size(1260, 108),
                    BackColor = Color.Transparent
                };

                // 포스터 썸네일
                var poster = new PictureBox
                {
                    Image    = (System.Drawing.Image)res.GetObject($"img_poster{idx + 1}.Image"),
                    Location = new Point(12, 10),
                    Size     = new Size(58, 84),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pnl.Controls.Add(poster);

                pnl.Controls.Add(new Label
                {
                    Text = movie.mName,
                    Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Theme.TextPrimary,
                    Location = new Point(80, 16),
                    Size = new Size(168, 26),
                    AutoSize = false
                });
                pnl.Controls.Add(new Label
                {
                    Text = movie.rating,
                    Font = new Font("맑은 고딕", 9F, GraphicsUnit.Point),
                    ForeColor = Theme.TextMuted,
                    Location = new Point(80, 48),
                    AutoSize = true
                });
                pnl.Controls.Add(new Label
                {
                    Text = movie.runningTime,
                    Font = new Font("맑은 고딕", 9F, GraphicsUnit.Point),
                    ForeColor = Theme.TextMuted,
                    Location = new Point(80, 68),
                    AutoSize = true
                });

                // 세로 구분선
                pnl.Controls.Add(new Label
                {
                    BackColor = Theme.Border,
                    Location = new Point(256, 12),
                    Size = new Size(1, 84)
                });

                var fp = new FlowLayoutPanel
                {
                    Location = new Point(268, 18),
                    Size = new Size(972, 72),
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = false,
                    BackColor = Color.Transparent,
                    Margin = new Padding(0)
                };

                if (schedules.Count == 0)
                {
                    fp.Controls.Add(new Label
                    {
                        Text = "상영 없음",
                        ForeColor = Theme.TextMuted,
                        Font = new Font("맑은 고딕", 10F, GraphicsUnit.Point),
                        AutoSize = true,
                        Margin = new Padding(0, 22, 0, 0)
                    });
                }
                else
                {
                    foreach (var sch in schedules)
                    {
                        int avail = sch.AvailableSeats;
                        bool full = avail <= 0;
                        var btn = new Button
                        {
                            Text = $"{sch.start_time}\n{sch.room}  {(full ? "매진" : avail + "석")}",
                            Size = new Size(105, 58),
                            Font = new Font("맑은 고딕", 8.5F, FontStyle.Bold, GraphicsUnit.Point),
                            ForeColor = full ? Theme.TextMuted : Theme.TextSub,
                            BackColor = Theme.BG,
                            FlatStyle = FlatStyle.Flat,
                            Margin = new Padding(0, 0, 6, 0),
                            Enabled = !full,
                            Cursor = full ? Cursors.Default : Cursors.Hand
                        };
                        btn.FlatAppearance.BorderColor = full ? Theme.SeatTaken : Theme.Border;
                        btn.FlatAppearance.BorderSize = 1;
                        btn.Click += (s, ev) => GoToBooking(movieName);
                        fp.Controls.Add(btn);
                    }
                }

                pnl.Controls.Add(fp);

                // 하단 구분선
                pnl.Controls.Add(new Label
                {
                    BackColor = Theme.Border,
                    Location = new Point(0, 107),
                    Size = new Size(1260, 1)
                });

                pnl_movies.Controls.Add(pnl);
                y += 108;
            }

            pnl_movies.Height = y;
        }

        private void GoToBooking(string movieTitle)
        {
            var main = this.FindForm() as Main;
            if (DataTemp.currentUser == null)
            {
                MessageBox.Show("로그인 후 이용하실 수 있습니다.", "알림");
                main?.ShowMenuScreen(new Login());
            }
            else
            {
                main?.ShowMenuScreen(new Booking(movieTitle, selectedDate));
            }
        }
    }
}
