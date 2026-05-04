namespace CGB
{
    partial class Booking
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnl_top        = new Panel();
            lb_movie_title = new Label();
            pnl_date       = new Panel();
            lb_step1       = new Label();
            fp_dates       = new FlowLayoutPanel();
            pnl_time       = new Panel();
            lb_step2       = new Label();
            fp_times       = new FlowLayoutPanel();
            lb_time_hint   = new Label();
            pnl_seats      = new Panel();
            lb_step3       = new Label();
            lb_screen      = new Label();
            pnl_seatgrid   = new Panel();
            pnl_legend     = new Panel();
            lb_leg_avail   = new Label();
            lb_leg_sel     = new Label();
            lb_leg_taken   = new Label();
            pnl_bottom     = new Panel();
            lb_selected    = new Label();
            lb_price       = new Label();
            btn_confirm    = new Button();

            pnl_top.SuspendLayout();
            pnl_date.SuspendLayout();
            pnl_time.SuspendLayout();
            pnl_seats.SuspendLayout();
            pnl_legend.SuspendLayout();
            pnl_bottom.SuspendLayout();
            SuspendLayout();

            // ── pnl_top (영화 제목 바) ────────────────────────────────────
            pnl_top.BackColor = Theme.Accent;
            pnl_top.Location  = new System.Drawing.Point(0, 0);
            pnl_top.Size      = new System.Drawing.Size(1280, 58);
            pnl_top.Controls.Add(lb_movie_title);

            lb_movie_title.Font      = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_movie_title.ForeColor = System.Drawing.Color.White;
            lb_movie_title.BackColor = System.Drawing.Color.Transparent;
            lb_movie_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lb_movie_title.Location  = new System.Drawing.Point(30, 0);
            lb_movie_title.Size      = new System.Drawing.Size(900, 58);

            // ── pnl_date (날짜 선택) ──────────────────────────────────────
            pnl_date.BackColor = Theme.CardBG;
            pnl_date.Location  = new System.Drawing.Point(0, 58);
            pnl_date.Size      = new System.Drawing.Size(1280, 92);
            pnl_date.Controls.Add(lb_step1);
            pnl_date.Controls.Add(fp_dates);

            lb_step1.Text      = "1.  날짜 선택";
            lb_step1.Font      = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_step1.ForeColor = Theme.TextSub;
            lb_step1.Location  = new System.Drawing.Point(20, 8);
            lb_step1.AutoSize  = true;

            fp_dates.Location      = new System.Drawing.Point(20, 32);
            fp_dates.Size          = new System.Drawing.Size(1240, 55);
            fp_dates.FlowDirection = FlowDirection.LeftToRight;
            fp_dates.WrapContents  = false;
            fp_dates.BackColor     = System.Drawing.Color.Transparent;
            fp_dates.Margin        = new Padding(0);

            // ── pnl_time (시간 선택) ──────────────────────────────────────
            pnl_time.BackColor = Theme.StepDisabled;
            pnl_time.Location  = new System.Drawing.Point(0, 150);
            pnl_time.Size      = new System.Drawing.Size(1280, 92);
            pnl_time.Controls.Add(lb_step2);
            pnl_time.Controls.Add(fp_times);
            pnl_time.Controls.Add(lb_time_hint);

            lb_step2.Text      = "2.  시간 선택";
            lb_step2.Font      = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_step2.ForeColor = Theme.TextMuted;
            lb_step2.Location  = new System.Drawing.Point(20, 8);
            lb_step2.AutoSize  = true;

            fp_times.Location      = new System.Drawing.Point(20, 32);
            fp_times.Size          = new System.Drawing.Size(1240, 55);
            fp_times.FlowDirection = FlowDirection.LeftToRight;
            fp_times.WrapContents  = false;
            fp_times.BackColor     = System.Drawing.Color.Transparent;
            fp_times.Margin        = new Padding(0);

            lb_time_hint.Text      = "← 날짜를 먼저 선택해 주세요";
            lb_time_hint.Font      = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.GraphicsUnit.Point);
            lb_time_hint.ForeColor = Theme.TextMuted;
            lb_time_hint.Location  = new System.Drawing.Point(20, 42);
            lb_time_hint.AutoSize  = true;

            // ── pnl_seats (좌석 선택) ─────────────────────────────────────
            pnl_seats.BackColor = Theme.StepDisabled;
            pnl_seats.Location  = new System.Drawing.Point(0, 242);
            pnl_seats.Size      = new System.Drawing.Size(1280, 368);
            pnl_seats.Controls.Add(lb_step3);
            pnl_seats.Controls.Add(lb_screen);
            pnl_seats.Controls.Add(pnl_seatgrid);
            pnl_seats.Controls.Add(pnl_legend);

            lb_step3.Text      = "3.  좌석 선택";
            lb_step3.Font      = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_step3.ForeColor = Theme.TextMuted;
            lb_step3.Location  = new System.Drawing.Point(20, 8);
            lb_step3.AutoSize  = true;

            lb_screen.Text      = "S  C  R  E  E  N";
            lb_screen.Font      = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_screen.ForeColor = Theme.TextMuted;
            lb_screen.BackColor = Theme.Border;
            lb_screen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_screen.Location  = new System.Drawing.Point(400, 36);
            lb_screen.Size      = new System.Drawing.Size(480, 26);

            // pnl_seatgrid: 동적으로 좌석 버튼 추가
            pnl_seatgrid.BackColor = System.Drawing.Color.Transparent;
            pnl_seatgrid.Location  = new System.Drawing.Point(400, 70);
            pnl_seatgrid.Size      = new System.Drawing.Size(480, 260);

            // pnl_legend
            pnl_legend.BackColor = System.Drawing.Color.Transparent;
            pnl_legend.Location  = new System.Drawing.Point(400, 338);
            pnl_legend.Size      = new System.Drawing.Size(480, 24);
            pnl_legend.Controls.AddRange(new Control[] { lb_leg_avail, lb_leg_sel, lb_leg_taken });

            lb_leg_avail.Text      = "■ 선택 가능";
            lb_leg_avail.Font      = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.GraphicsUnit.Point);
            lb_leg_avail.ForeColor = Theme.SeatAvail;
            lb_leg_avail.Location  = new System.Drawing.Point(0, 4);
            lb_leg_avail.AutoSize  = true;

            lb_leg_sel.Text      = "■ 선택됨";
            lb_leg_sel.Font      = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.GraphicsUnit.Point);
            lb_leg_sel.ForeColor = Theme.SeatSel;
            lb_leg_sel.Location  = new System.Drawing.Point(110, 4);
            lb_leg_sel.AutoSize  = true;

            lb_leg_taken.Text      = "■ 예매완료";
            lb_leg_taken.Font      = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.GraphicsUnit.Point);
            lb_leg_taken.ForeColor = Theme.SeatTaken;
            lb_leg_taken.Location  = new System.Drawing.Point(210, 4);
            lb_leg_taken.AutoSize  = true;

            // ── pnl_bottom (확인) ─────────────────────────────────────────
            pnl_bottom.BackColor = Theme.CardBG;
            pnl_bottom.Location  = new System.Drawing.Point(0, 610);
            pnl_bottom.Size      = new System.Drawing.Size(1280, 80);
            pnl_bottom.Controls.Add(lb_selected);
            pnl_bottom.Controls.Add(lb_price);
            pnl_bottom.Controls.Add(btn_confirm);

            lb_selected.Text      = "선택 좌석: (없음)";
            lb_selected.Font      = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            lb_selected.ForeColor = Theme.TextPrimary;
            lb_selected.Location  = new System.Drawing.Point(25, 12);
            lb_selected.AutoSize  = true;

            lb_price.Text      = "결제 금액: 0원";
            lb_price.Font      = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_price.ForeColor = Theme.Accent;
            lb_price.Location  = new System.Drawing.Point(25, 42);
            lb_price.AutoSize  = true;

            btn_confirm.Text                      = "예매 완료";
            btn_confirm.Font                      = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_confirm.ForeColor                 = System.Drawing.Color.White;
            btn_confirm.BackColor                 = Theme.Accent;
            btn_confirm.FlatStyle                 = FlatStyle.Flat;
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.Location                  = new System.Drawing.Point(1080, 16);
            btn_confirm.Size                      = new System.Drawing.Size(175, 50);
            btn_confirm.Cursor                    = Cursors.Hand;
            btn_confirm.Enabled                   = false;
            btn_confirm.Click                    += btn_confirm_Click;

            // ── UserControl ───────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Theme.BG;
            Controls.Add(pnl_top);
            Controls.Add(pnl_date);
            Controls.Add(pnl_time);
            Controls.Add(pnl_seats);
            Controls.Add(pnl_bottom);
            Name = "Booking";
            Size = new System.Drawing.Size(1280, 690);

            pnl_top.ResumeLayout(false);
            pnl_date.ResumeLayout(false);
            pnl_time.ResumeLayout(false);
            pnl_seats.ResumeLayout(false);
            pnl_legend.ResumeLayout(false);
            pnl_bottom.ResumeLayout(false);
            pnl_bottom.PerformLayout();
            ResumeLayout(false);
        }

        private Panel          pnl_top;
        private Label          lb_movie_title;
        private Panel          pnl_date;
        private Label          lb_step1;
        private FlowLayoutPanel fp_dates;
        private Panel          pnl_time;
        private Label          lb_step2;
        private FlowLayoutPanel fp_times;
        private Label          lb_time_hint;
        private Panel          pnl_seats;
        private Label          lb_step3;
        private Label          lb_screen;
        private Panel          pnl_seatgrid;
        private Panel          pnl_legend;
        private Label          lb_leg_avail;
        private Label          lb_leg_sel;
        private Label          lb_leg_taken;
        private Panel          pnl_bottom;
        private Label          lb_selected;
        private Label          lb_price;
        private Button         btn_confirm;
    }
}
