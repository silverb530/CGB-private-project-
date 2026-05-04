namespace CGB
{
    partial class PaymentForm
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
            lb_title   = new Label();
            pnl_info   = new Panel();
            lb_movie   = new Label();
            lb_detail  = new Label();
            lb_seats   = new Label();
            sep        = new Label();
            lb_amount_hint = new Label();
            lb_amount  = new Label();
            pnl_btns   = new Panel();
            btn_card   = new Button();
            btn_cash   = new Button();
            btn_cancel = new Button();

            pnl_top.SuspendLayout();
            pnl_info.SuspendLayout();
            pnl_btns.SuspendLayout();
            SuspendLayout();

            // ── pnl_top ───────────────────────────────────────────────────
            pnl_top.BackColor = Theme.Accent;
            pnl_top.Location  = new System.Drawing.Point(0, 0);
            pnl_top.Size      = new System.Drawing.Size(500, 56);
            pnl_top.Controls.Add(lb_title);

            lb_title.Text      = "결제 수단 선택";
            lb_title.Font      = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_title.ForeColor = System.Drawing.Color.White;
            lb_title.BackColor = System.Drawing.Color.Transparent;
            lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lb_title.Location  = new System.Drawing.Point(22, 0);
            lb_title.Size      = new System.Drawing.Size(456, 56);

            // ── pnl_info (예매 요약) ──────────────────────────────────────
            pnl_info.BackColor = Theme.CardBG;
            pnl_info.Location  = new System.Drawing.Point(0, 56);
            pnl_info.Size      = new System.Drawing.Size(500, 210);
            pnl_info.Controls.AddRange(new System.Windows.Forms.Control[] {
                lb_movie, lb_detail, lb_seats, sep, lb_amount_hint, lb_amount });

            lb_movie.Font      = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_movie.ForeColor = Theme.TextPrimary;
            lb_movie.Location  = new System.Drawing.Point(22, 18);
            lb_movie.Size      = new System.Drawing.Size(456, 30);
            lb_movie.AutoSize  = false;

            lb_detail.Font      = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.GraphicsUnit.Point);
            lb_detail.ForeColor = Theme.TextSub;
            lb_detail.Location  = new System.Drawing.Point(22, 54);
            lb_detail.Size      = new System.Drawing.Size(456, 22);
            lb_detail.AutoSize  = false;

            lb_seats.Font      = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.GraphicsUnit.Point);
            lb_seats.ForeColor = Theme.TextSub;
            lb_seats.Location  = new System.Drawing.Point(22, 80);
            lb_seats.Size      = new System.Drawing.Size(456, 22);
            lb_seats.AutoSize  = false;

            sep.BackColor = Theme.Border;
            sep.Location  = new System.Drawing.Point(22, 114);
            sep.Size      = new System.Drawing.Size(456, 1);

            lb_amount_hint.Text      = "결제 금액";
            lb_amount_hint.Font      = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.GraphicsUnit.Point);
            lb_amount_hint.ForeColor = Theme.TextMuted;
            lb_amount_hint.Location  = new System.Drawing.Point(22, 128);
            lb_amount_hint.AutoSize  = true;

            lb_amount.Font      = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_amount.ForeColor = Theme.Accent;
            lb_amount.Location  = new System.Drawing.Point(22, 152);
            lb_amount.Size      = new System.Drawing.Size(456, 46);
            lb_amount.AutoSize  = false;

            // ── pnl_btns (카드 / 현금) ────────────────────────────────────
            pnl_btns.BackColor = Theme.BG;
            pnl_btns.Location  = new System.Drawing.Point(0, 266);
            pnl_btns.Size      = new System.Drawing.Size(500, 100);
            pnl_btns.Controls.AddRange(new System.Windows.Forms.Control[] { btn_card, btn_cash });

            btn_card.Text      = "카드 결제";
            btn_card.Font      = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_card.ForeColor = System.Drawing.Color.White;
            btn_card.BackColor = Theme.Accent;
            btn_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_card.FlatAppearance.BorderSize  = 0;
            btn_card.Location  = new System.Drawing.Point(20, 20);
            btn_card.Size      = new System.Drawing.Size(210, 62);
            btn_card.Cursor    = System.Windows.Forms.Cursors.Hand;
            btn_card.Click    += btn_card_Click;

            btn_cash.Text      = "현금 결제";
            btn_cash.Font      = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_cash.ForeColor = System.Drawing.Color.White;
            btn_cash.BackColor = Theme.SeatAvail;
            btn_cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_cash.FlatAppearance.BorderSize  = 0;
            btn_cash.Location  = new System.Drawing.Point(248, 20);
            btn_cash.Size      = new System.Drawing.Size(210, 62);
            btn_cash.Cursor    = System.Windows.Forms.Cursors.Hand;
            btn_cash.Click    += btn_cash_Click;

            // ── btn_cancel ────────────────────────────────────────────────
            btn_cancel.Text      = "취소";
            btn_cancel.Font      = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.GraphicsUnit.Point);
            btn_cancel.ForeColor = Theme.TextMuted;
            btn_cancel.BackColor = Theme.BG;
            btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_cancel.FlatAppearance.BorderColor = Theme.Border;
            btn_cancel.FlatAppearance.BorderSize  = 1;
            btn_cancel.Location  = new System.Drawing.Point(390, 370);
            btn_cancel.Size      = new System.Drawing.Size(84, 28);
            btn_cancel.Cursor    = System.Windows.Forms.Cursors.Hand;
            btn_cancel.Click    += btn_cancel_Click;

            // ── Form ──────────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            BackColor           = Theme.BG;
            ClientSize          = new System.Drawing.Size(500, 408);
            FormBorderStyle     = System.Windows.Forms.FormBorderStyle.None;
            StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent;
            Controls.AddRange(new System.Windows.Forms.Control[] {
                pnl_top, pnl_info, pnl_btns, btn_cancel });
            Name = "PaymentForm";
            Text = "결제 수단 선택";

            pnl_top.ResumeLayout(false);
            pnl_info.ResumeLayout(false);
            pnl_info.PerformLayout();
            pnl_btns.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel  pnl_top;
        private Label  lb_title;
        private Panel  pnl_info;
        private Label  lb_movie;
        private Label  lb_detail;
        private Label  lb_seats;
        private Label  sep;
        private Label  lb_amount_hint;
        private Label  lb_amount;
        private Panel  pnl_btns;
        private Button btn_card;
        private Button btn_cash;
        private Button btn_cancel;
    }
}
