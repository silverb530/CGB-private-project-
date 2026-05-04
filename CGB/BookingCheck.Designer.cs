namespace CGB
{
    partial class BookingCheck
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnl_header    = new Panel();
            lb_header     = new Label();
            lb_username   = new Label();
            pnl_scroll    = new Panel();
            lb_no_booking = new Label();

            pnl_header.SuspendLayout();
            SuspendLayout();

            // ── pnl_header ────────────────────────────────────────────────
            pnl_header.BackColor = Theme.CardBG;
            pnl_header.Dock      = DockStyle.Top;
            pnl_header.Height    = 65;
            pnl_header.Controls.Add(lb_header);
            pnl_header.Controls.Add(lb_username);

            lb_header.Text      = "내 예매 내역";
            lb_header.Font      = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_header.ForeColor = Theme.TextPrimary;
            lb_header.Location  = new System.Drawing.Point(30, 17);
            lb_header.AutoSize  = true;

            lb_username.Text      = "";
            lb_username.Font      = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.GraphicsUnit.Point);
            lb_username.ForeColor = Theme.TextSub;
            lb_username.Location  = new System.Drawing.Point(220, 24);
            lb_username.AutoSize  = true;

            // ── pnl_scroll ────────────────────────────────────────────────
            pnl_scroll.Dock        = DockStyle.Fill;
            pnl_scroll.BackColor   = Theme.BG;
            pnl_scroll.AutoScroll  = true;
            pnl_scroll.Padding     = new Padding(30, 20, 30, 20);

            // ── lb_no_booking ─────────────────────────────────────────────
            lb_no_booking.Text      = "예매 내역이 없습니다.";
            lb_no_booking.Font      = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.GraphicsUnit.Point);
            lb_no_booking.ForeColor = Theme.TextMuted;
            lb_no_booking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_no_booking.Dock      = DockStyle.Fill;
            lb_no_booking.Visible   = false;

            // ── UserControl ───────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Theme.BG;
            Controls.Add(lb_no_booking);
            Controls.Add(pnl_scroll);
            Controls.Add(pnl_header);
            Name = "BookingCheck";
            Size = new System.Drawing.Size(1280, 690);

            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnl_header;
        private Label lb_header;
        private Label lb_username;
        private Panel pnl_scroll;
        private Label lb_no_booking;
    }
}
