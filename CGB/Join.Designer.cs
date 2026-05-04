namespace CGB
{
    partial class Join
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Join));
            pnl_card      = new Panel();
            pictureBox1   = new PictureBox();
            lb_join_title = new Label();
            label2        = new Label();
            label3        = new Label();
            label4        = new Label();
            label5        = new Label();
            txt_id        = new TextBox();
            txt_pw        = new TextBox();
            txt_name      = new TextBox();
            txt_phone     = new TextBox();
            btn_join      = new Button();

            pnl_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // ── pnl_card ────────────────────────────────────────────────
            pnl_card.BackColor = Theme.CardBG;
            pnl_card.Location  = new System.Drawing.Point(430, 50);
            pnl_card.Size      = new System.Drawing.Size(420, 580);
            pnl_card.Controls.AddRange(new Control[] {
                pictureBox1, lb_join_title, label2, txt_id, label3, txt_pw, label4, txt_name, label5, txt_phone, btn_join
            });

            // pictureBox1 (logo)
            pictureBox1.Image    = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(160, 22);
            pictureBox1.Size     = new System.Drawing.Size(100, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // lb_join_title
            lb_join_title.Text      = "회원가입";
            lb_join_title.Font      = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_join_title.ForeColor = Theme.TextPrimary;
            lb_join_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_join_title.Location  = new System.Drawing.Point(100, 118);
            lb_join_title.Size      = new System.Drawing.Size(220, 38);

            // label2 (아이디)
            label2.Text      = "아이디";
            label2.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = Theme.TextSub;
            label2.Location  = new System.Drawing.Point(30, 172);
            label2.AutoSize  = true;

            // txt_id
            txt_id.BackColor   = Theme.InputBG;
            txt_id.ForeColor   = Theme.TextPrimary;
            txt_id.BorderStyle = BorderStyle.None;
            txt_id.Font        = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            txt_id.Location    = new System.Drawing.Point(30, 198);
            txt_id.Size        = new System.Drawing.Size(360, 24);
            txt_id.PlaceholderText = "사용할 아이디를 입력하세요";

            // label3 (비밀번호)
            label3.Text      = "비밀번호";
            label3.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = Theme.TextSub;
            label3.Location  = new System.Drawing.Point(30, 242);
            label3.AutoSize  = true;

            // txt_pw
            txt_pw.BackColor   = Theme.InputBG;
            txt_pw.ForeColor   = Theme.TextPrimary;
            txt_pw.BorderStyle = BorderStyle.None;
            txt_pw.Font        = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            txt_pw.Location    = new System.Drawing.Point(30, 268);
            txt_pw.Size        = new System.Drawing.Size(360, 24);
            txt_pw.PasswordChar = '●';
            txt_pw.PlaceholderText = "비밀번호를 입력하세요";

            // label4 (이름)
            label4.Text      = "이름";
            label4.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = Theme.TextSub;
            label4.Location  = new System.Drawing.Point(30, 312);
            label4.AutoSize  = true;

            // txt_name
            txt_name.BackColor   = Theme.InputBG;
            txt_name.ForeColor   = Theme.TextPrimary;
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font        = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            txt_name.Location    = new System.Drawing.Point(30, 338);
            txt_name.Size        = new System.Drawing.Size(360, 24);
            txt_name.PlaceholderText = "이름을 입력하세요";

            // label5 (전화번호)
            label5.Text      = "전화번호";
            label5.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = Theme.TextSub;
            label5.Location  = new System.Drawing.Point(30, 382);
            label5.AutoSize  = true;

            // txt_phone
            txt_phone.BackColor       = Theme.InputBG;
            txt_phone.ForeColor       = Theme.TextPrimary;
            txt_phone.BorderStyle     = BorderStyle.None;
            txt_phone.Font            = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            txt_phone.Location        = new System.Drawing.Point(30, 408);
            txt_phone.Size            = new System.Drawing.Size(360, 24);
            txt_phone.PlaceholderText = "전화번호를 입력하세요 (숫자만)";

            // btn_join
            btn_join.Text                      = "가입하기";
            btn_join.Font                      = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_join.ForeColor                 = System.Drawing.Color.White;
            btn_join.BackColor                 = Theme.Accent;
            btn_join.FlatStyle                 = FlatStyle.Flat;
            btn_join.FlatAppearance.BorderSize = 0;
            btn_join.Location                  = new System.Drawing.Point(30, 460);
            btn_join.Size                      = new System.Drawing.Size(360, 48);
            btn_join.Cursor                    = Cursors.Hand;
            btn_join.Click                    += btn_join_Click;

            // ── UserControl ─────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Theme.BG;
            Controls.Add(pnl_card);
            Name = "Join";
            Size = new System.Drawing.Size(1280, 690);

            pnl_card.ResumeLayout(false);
            pnl_card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Panel     pnl_card;
        private PictureBox pictureBox1;
        private Label     lb_join_title;
        private Label     label2;
        private Label     label3;
        private Label     label4;
        private Label     label5;
        private TextBox   txt_id;
        private TextBox   txt_pw;
        private TextBox   txt_name;
        private TextBox   txt_phone;
        private Button    btn_join;
    }
}
