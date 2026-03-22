namespace keb_project
{
    partial class Movie_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie_info));
            wmp_video = new AxWMPLib.AxWindowsMediaPlayer();
            lb_title = new Label();
            lb_openDate = new Label();
            lb_runtime = new Label();
            lb_rating = new Label();
            lb_rationing = new Label();
            txt_intro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)wmp_video).BeginInit();
            SuspendLayout();
            // 
            // wmp_video
            // 
            wmp_video.Dock = DockStyle.Top;
            wmp_video.Enabled = true;
            wmp_video.Location = new Point(0, 0);
            wmp_video.Name = "wmp_video";
            wmp_video.OcxState = (AxHost.State)resources.GetObject("wmp_video.OcxState");
            wmp_video.Size = new Size(667, 450);
            wmp_video.TabIndex = 0;
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Font = new Font("맑은 고딕", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lb_title.Location = new Point(12, 465);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(66, 37);
            lb_title.TabIndex = 1;
            lb_title.Text = "title";
            // 
            // lb_openDate
            // 
            lb_openDate.AutoSize = true;
            lb_openDate.Location = new Point(22, 512);
            lb_openDate.Name = "lb_openDate";
            lb_openDate.Size = new Size(43, 15);
            lb_openDate.TabIndex = 2;
            lb_openDate.Text = "개봉일";
            // 
            // lb_runtime
            // 
            lb_runtime.AutoSize = true;
            lb_runtime.Location = new Point(22, 537);
            lb_runtime.Name = "lb_runtime";
            lb_runtime.Size = new Size(43, 15);
            lb_runtime.TabIndex = 2;
            lb_runtime.Text = "런타임";
            // 
            // lb_rating
            // 
            lb_rating.AutoSize = true;
            lb_rating.Location = new Point(22, 564);
            lb_rating.Name = "lb_rating";
            lb_rating.Size = new Size(55, 15);
            lb_rating.TabIndex = 2;
            lb_rating.Text = "나이제한";
            // 
            // lb_rationing
            // 
            lb_rationing.AutoSize = true;
            lb_rationing.Location = new Point(22, 593);
            lb_rationing.Name = "lb_rationing";
            lb_rationing.Size = new Size(31, 15);
            lb_rationing.TabIndex = 2;
            lb_rationing.Text = "배급";
            // 
            // txt_intro
            // 
            txt_intro.Location = new Point(22, 626);
            txt_intro.Multiline = true;
            txt_intro.Name = "txt_intro";
            txt_intro.Size = new Size(623, 269);
            txt_intro.TabIndex = 4;
            // 
            // Movie_info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 907);
            Controls.Add(txt_intro);
            Controls.Add(lb_rationing);
            Controls.Add(lb_rating);
            Controls.Add(lb_runtime);
            Controls.Add(lb_openDate);
            Controls.Add(lb_title);
            Controls.Add(wmp_video);
            Name = "Movie_info";
            Text = "Movie_info";
            ((System.ComponentModel.ISupportInitialize)wmp_video).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp_video;
        private Label lb_title;
        private Label lb_openDate;
        private Label lb_runtime;
        private Label lb_rating;
        private Label lb_rationing;
        private TextBox txt_intro;
    }
}