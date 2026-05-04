namespace CGB
{
    partial class MovieChart
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieChart));
            img_poster1   = new PictureBox();
            img_poster2   = new PictureBox();
            img_poster3   = new PictureBox();
            img_poster4   = new PictureBox();
            pnl_info      = new Panel();
            lb_title      = new Label();
            lb_opendate   = new Label();
            lb_rating     = new Label();
            lb_runtime    = new Label();
            lb_dist       = new Label();
            txt_info      = new TextBox();

            ((System.ComponentModel.ISupportInitialize)img_poster1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_poster2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_poster3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_poster4).BeginInit();
            pnl_info.SuspendLayout();
            SuspendLayout();

            // ── Poster 1 ─────────────────────────────────────────────────
            img_poster1.Image    = (System.Drawing.Image)resources.GetObject("img_poster1.Image");
            img_poster1.Location = new System.Drawing.Point(25, 10);
            img_poster1.Size     = new System.Drawing.Size(284, 300);
            img_poster1.SizeMode = PictureBoxSizeMode.StretchImage;
            img_poster1.Cursor   = Cursors.Hand;
            img_poster1.Tag      = "p1";
            img_poster1.Click   += poster_click;

            // ── Poster 2 ─────────────────────────────────────────────────
            img_poster2.Image    = (System.Drawing.Image)resources.GetObject("img_poster2.Image");
            img_poster2.Location = new System.Drawing.Point(339, 10);
            img_poster2.Size     = new System.Drawing.Size(284, 300);
            img_poster2.SizeMode = PictureBoxSizeMode.StretchImage;
            img_poster2.Cursor   = Cursors.Hand;
            img_poster2.Tag      = "p2";
            img_poster2.Click   += poster_click;

            // ── Poster 3 ─────────────────────────────────────────────────
            img_poster3.Image    = (System.Drawing.Image)resources.GetObject("img_poster3.Image");
            img_poster3.Location = new System.Drawing.Point(653, 10);
            img_poster3.Size     = new System.Drawing.Size(284, 300);
            img_poster3.SizeMode = PictureBoxSizeMode.StretchImage;
            img_poster3.Cursor   = Cursors.Hand;
            img_poster3.Tag      = "p3";
            img_poster3.Click   += poster_click;

            // ── Poster 4 ─────────────────────────────────────────────────
            img_poster4.Image    = (System.Drawing.Image)resources.GetObject("img_poster4.Image");
            img_poster4.Location = new System.Drawing.Point(967, 10);
            img_poster4.Size     = new System.Drawing.Size(284, 300);
            img_poster4.SizeMode = PictureBoxSizeMode.StretchImage;
            img_poster4.Cursor   = Cursors.Hand;
            img_poster4.Tag      = "p4";
            img_poster4.Click   += poster_click;

            // ── pnl_info (movie detail section) ─────────────────────────
            pnl_info.BackColor = Theme.CardBG;
            pnl_info.Location  = new System.Drawing.Point(0, 318);
            pnl_info.Size      = new System.Drawing.Size(1280, 372);
            pnl_info.Controls.AddRange(new Control[] {
                lb_title, lb_opendate, lb_rating, lb_runtime, lb_dist, txt_info
            });

            // lb_title
            lb_title.Text      = "왕과 사는 남자";
            lb_title.Font      = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_title.ForeColor = Theme.TextPrimary;
            lb_title.Location  = new System.Drawing.Point(20, 14);
            lb_title.AutoSize  = true;

            // lb_opendate
            lb_opendate.Text      = "개봉일: ";
            lb_opendate.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.GraphicsUnit.Point);
            lb_opendate.ForeColor = Theme.TextSub;
            lb_opendate.Location  = new System.Drawing.Point(20, 58);
            lb_opendate.AutoSize  = true;

            // lb_rating
            lb_rating.Text      = "등급: ";
            lb_rating.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.GraphicsUnit.Point);
            lb_rating.ForeColor = Theme.TextSub;
            lb_rating.Location  = new System.Drawing.Point(185, 58);
            lb_rating.AutoSize  = true;

            // lb_runtime
            lb_runtime.Text      = "러닝타임: ";
            lb_runtime.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.GraphicsUnit.Point);
            lb_runtime.ForeColor = Theme.TextSub;
            lb_runtime.Location  = new System.Drawing.Point(355, 58);
            lb_runtime.AutoSize  = true;

            // lb_dist
            lb_dist.Text      = "배급: ";
            lb_dist.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.GraphicsUnit.Point);
            lb_dist.ForeColor = Theme.TextSub;
            lb_dist.Location  = new System.Drawing.Point(500, 58);
            lb_dist.AutoSize  = true;

            // txt_info
            txt_info.BackColor    = Theme.CardBG;
            txt_info.ForeColor    = Theme.TextSub;
            txt_info.BorderStyle  = BorderStyle.None;
            txt_info.Font         = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.GraphicsUnit.Point);
            txt_info.Location     = new System.Drawing.Point(20, 90);
            txt_info.Multiline    = true;
            txt_info.ReadOnly     = true;
            txt_info.ScrollBars   = ScrollBars.Vertical;
            txt_info.Size         = new System.Drawing.Size(1240, 272);

            // ── UserControl ──────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Theme.BG;
            Controls.Add(img_poster1);
            Controls.Add(img_poster2);
            Controls.Add(img_poster3);
            Controls.Add(img_poster4);
            Controls.Add(pnl_info);
            Name = "MovieChart";
            Size = new System.Drawing.Size(1280, 690);

            ((System.ComponentModel.ISupportInitialize)img_poster1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_poster2).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_poster3).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_poster4).EndInit();
            pnl_info.ResumeLayout(false);
            pnl_info.PerformLayout();
            ResumeLayout(false);
        }

        private PictureBox img_poster1;
        private PictureBox img_poster2;
        private PictureBox img_poster3;
        private PictureBox img_poster4;
        private Panel      pnl_info;
        private Label      lb_title;
        private Label      lb_opendate;
        private Label      lb_rating;
        private Label      lb_runtime;
        private Label      lb_dist;
        private TextBox    txt_info;
    }
}
