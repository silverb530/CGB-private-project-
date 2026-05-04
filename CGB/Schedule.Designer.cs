namespace CGB
{
    partial class Schedule
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnl_top    = new Panel();
            lb_header  = new Label();
            pnl_dates  = new Panel();
            lb_step    = new Label();
            fp_dates   = new FlowLayoutPanel();
            pnl_scroll = new Panel();
            pnl_movies = new Panel();

            pnl_top.SuspendLayout();
            pnl_dates.SuspendLayout();
            pnl_scroll.SuspendLayout();
            SuspendLayout();

            // pnl_top
            pnl_top.BackColor = Theme.Accent;
            pnl_top.Location  = new System.Drawing.Point(0, 0);
            pnl_top.Size      = new System.Drawing.Size(1280, 58);
            pnl_top.Controls.Add(lb_header);

            lb_header.Text      = "상영 시간표";
            lb_header.Font      = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_header.ForeColor = System.Drawing.Color.White;
            lb_header.BackColor = System.Drawing.Color.Transparent;
            lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lb_header.Location  = new System.Drawing.Point(30, 0);
            lb_header.Size      = new System.Drawing.Size(600, 58);

            // pnl_dates
            pnl_dates.BackColor = Theme.CardBG;
            pnl_dates.Location  = new System.Drawing.Point(0, 58);
            pnl_dates.Size      = new System.Drawing.Size(1280, 82);
            pnl_dates.Controls.Add(lb_step);
            pnl_dates.Controls.Add(fp_dates);

            lb_step.Text      = "날짜 선택";
            lb_step.Font      = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_step.ForeColor = Theme.TextSub;
            lb_step.Location  = new System.Drawing.Point(20, 8);
            lb_step.AutoSize  = true;

            fp_dates.Location      = new System.Drawing.Point(20, 30);
            fp_dates.Size          = new System.Drawing.Size(1240, 48);
            fp_dates.FlowDirection = FlowDirection.LeftToRight;
            fp_dates.WrapContents  = false;
            fp_dates.BackColor     = System.Drawing.Color.Transparent;
            fp_dates.Margin        = new Padding(0);

            // pnl_scroll
            pnl_scroll.BackColor  = Theme.BG;
            pnl_scroll.Location   = new System.Drawing.Point(0, 140);
            pnl_scroll.Size       = new System.Drawing.Size(1280, 550);
            pnl_scroll.AutoScroll = true;
            pnl_scroll.Controls.Add(pnl_movies);

            // pnl_movies (동적으로 채워짐)
            pnl_movies.BackColor = System.Drawing.Color.Transparent;
            pnl_movies.Location  = new System.Drawing.Point(0, 0);
            pnl_movies.Size      = new System.Drawing.Size(1260, 432);

            // UserControl
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Theme.BG;
            Controls.Add(pnl_top);
            Controls.Add(pnl_dates);
            Controls.Add(pnl_scroll);
            Name = "Schedule";
            Size = new System.Drawing.Size(1280, 690);

            pnl_top.ResumeLayout(false);
            pnl_dates.ResumeLayout(false);
            pnl_dates.PerformLayout();
            pnl_scroll.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel            pnl_top;
        private Label            lb_header;
        private Panel            pnl_dates;
        private Label            lb_step;
        private FlowLayoutPanel  fp_dates;
        private Panel            pnl_scroll;
        private Panel            pnl_movies;
    }
}
