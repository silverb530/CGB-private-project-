namespace CGB
{
    partial class FindPw
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnl_card     = new Panel();
            lb_title     = new Label();
            lb_id_lbl    = new Label();
            txt_id       = new TextBox();
            lb_name_lbl  = new Label();
            txt_name     = new TextBox();
            lb_phone_lbl = new Label();
            txt_phone    = new TextBox();
            btn_find     = new Button();
            lb_result    = new Label();
            lb_back      = new Label();

            pnl_card.SuspendLayout();
            SuspendLayout();

            // pnl_card
            pnl_card.BackColor = Theme.CardBG;
            pnl_card.Location  = new System.Drawing.Point(430, 80);
            pnl_card.Size      = new System.Drawing.Size(420, 500);
            pnl_card.Controls.AddRange(new Control[] {
                lb_title, lb_id_lbl, txt_id, lb_name_lbl, txt_name,
                lb_phone_lbl, txt_phone, btn_find, lb_result, lb_back
            });

            // lb_title
            lb_title.Text      = "비밀번호 찾기";
            lb_title.Font      = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_title.ForeColor = Theme.TextPrimary;
            lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_title.Location  = new System.Drawing.Point(60, 28);
            lb_title.Size      = new System.Drawing.Size(300, 40);

            // lb_id_lbl
            lb_id_lbl.Text      = "아이디";
            lb_id_lbl.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_id_lbl.ForeColor = Theme.TextSub;
            lb_id_lbl.Location  = new System.Drawing.Point(30, 88);
            lb_id_lbl.AutoSize  = true;

            // txt_id
            txt_id.BackColor       = Theme.InputBG;
            txt_id.ForeColor       = Theme.TextPrimary;
            txt_id.BorderStyle     = BorderStyle.None;
            txt_id.Font            = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            txt_id.Location        = new System.Drawing.Point(30, 114);
            txt_id.Size            = new System.Drawing.Size(360, 24);
            txt_id.PlaceholderText = "아이디를 입력하세요";

            // lb_name_lbl
            lb_name_lbl.Text      = "이름";
            lb_name_lbl.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_name_lbl.ForeColor = Theme.TextSub;
            lb_name_lbl.Location  = new System.Drawing.Point(30, 158);
            lb_name_lbl.AutoSize  = true;

            // txt_name
            txt_name.BackColor       = Theme.InputBG;
            txt_name.ForeColor       = Theme.TextPrimary;
            txt_name.BorderStyle     = BorderStyle.None;
            txt_name.Font            = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            txt_name.Location        = new System.Drawing.Point(30, 184);
            txt_name.Size            = new System.Drawing.Size(360, 24);
            txt_name.PlaceholderText = "이름을 입력하세요";

            // lb_phone_lbl
            lb_phone_lbl.Text      = "전화번호";
            lb_phone_lbl.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_phone_lbl.ForeColor = Theme.TextSub;
            lb_phone_lbl.Location  = new System.Drawing.Point(30, 228);
            lb_phone_lbl.AutoSize  = true;

            // txt_phone
            txt_phone.BackColor       = Theme.InputBG;
            txt_phone.ForeColor       = Theme.TextPrimary;
            txt_phone.BorderStyle     = BorderStyle.None;
            txt_phone.Font            = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            txt_phone.Location        = new System.Drawing.Point(30, 254);
            txt_phone.Size            = new System.Drawing.Size(360, 24);
            txt_phone.PlaceholderText = "전화번호를 입력하세요 (숫자만)";

            // btn_find
            btn_find.Text                      = "확인";
            btn_find.Font                      = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_find.ForeColor                 = System.Drawing.Color.White;
            btn_find.BackColor                 = Theme.Accent;
            btn_find.FlatStyle                 = FlatStyle.Flat;
            btn_find.FlatAppearance.BorderSize = 0;
            btn_find.Location                  = new System.Drawing.Point(30, 306);
            btn_find.Size                      = new System.Drawing.Size(360, 48);
            btn_find.Cursor                    = Cursors.Hand;
            btn_find.Click                    += btn_find_Click;

            // lb_result
            lb_result.Text      = "";
            lb_result.Font      = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_result.ForeColor = Theme.Accent;
            lb_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_result.Location  = new System.Drawing.Point(30, 372);
            lb_result.Size      = new System.Drawing.Size(360, 30);

            // lb_back
            lb_back.Text      = "← 로그인으로 돌아가기";
            lb_back.Font      = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.GraphicsUnit.Point);
            lb_back.ForeColor = Theme.TextMuted;
            lb_back.Location  = new System.Drawing.Point(30, 452);
            lb_back.AutoSize  = true;
            lb_back.Cursor    = Cursors.Hand;
            lb_back.Click    += lb_back_Click;

            // UserControl
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Theme.BG;
            Controls.Add(pnl_card);
            Name = "FindPw";
            Size = new System.Drawing.Size(1280, 690);

            pnl_card.ResumeLayout(false);
            pnl_card.PerformLayout();
            ResumeLayout(false);
        }

        private Panel   pnl_card;
        private Label   lb_title;
        private Label   lb_id_lbl;
        private TextBox txt_id;
        private Label   lb_name_lbl;
        private TextBox txt_name;
        private Label   lb_phone_lbl;
        private TextBox txt_phone;
        private Button  btn_find;
        private Label   lb_result;
        private Label   lb_back;
    }
}
