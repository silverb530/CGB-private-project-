namespace CGB
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnl_card      = new Panel();
            pictureBox1   = new PictureBox();
            lb_login_title= new Label();
            lb_id_label   = new Label();
            lb_pw_label   = new Label();
            tb_id         = new TextBox();
            tb_password   = new TextBox();
            btn_login     = new Button();
            label2        = new Label();
            label3        = new Label();
            lb_join       = new Label();

            pnl_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // ── pnl_card ────────────────────────────────────────────────
            pnl_card.BackColor  = Theme.CardBG;
            pnl_card.Location   = new System.Drawing.Point(430, 90);
            pnl_card.Size       = new System.Drawing.Size(420, 470);
            pnl_card.Controls.AddRange(new Control[] {
                pictureBox1, lb_login_title, lb_id_label, tb_id,
                lb_pw_label, tb_password, btn_login, label2, label3, lb_join
            });

            // pictureBox1 (logo)
            pictureBox1.Image    = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(160, 22);
            pictureBox1.Size     = new System.Drawing.Size(100, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // lb_login_title
            lb_login_title.Text      = "로그인";
            lb_login_title.Font      = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_login_title.ForeColor = Theme.TextPrimary;
            lb_login_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_login_title.Location  = new System.Drawing.Point(110, 118);
            lb_login_title.Size      = new System.Drawing.Size(200, 38);

            // lb_id_label
            lb_id_label.Text      = "아이디";
            lb_id_label.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_id_label.ForeColor = Theme.TextSub;
            lb_id_label.Location  = new System.Drawing.Point(30, 170);
            lb_id_label.AutoSize  = true;

            // tb_id
            tb_id.BackColor        = Theme.InputBG;
            tb_id.ForeColor        = Theme.TextPrimary;
            tb_id.BorderStyle      = BorderStyle.None;
            tb_id.Font             = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            tb_id.Location         = new System.Drawing.Point(30, 196);
            tb_id.Size             = new System.Drawing.Size(360, 24);
            tb_id.PlaceholderText  = "아이디를 입력하세요";
            tb_id.Text             = "";

            // lb_pw_label
            lb_pw_label.Text      = "비밀번호";
            lb_pw_label.Font      = new System.Drawing.Font("맑은 고딕", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_pw_label.ForeColor = Theme.TextSub;
            lb_pw_label.Location  = new System.Drawing.Point(30, 240);
            lb_pw_label.AutoSize  = true;

            // tb_password
            tb_password.BackColor       = Theme.InputBG;
            tb_password.ForeColor       = Theme.TextPrimary;
            tb_password.BorderStyle     = BorderStyle.None;
            tb_password.Font            = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.GraphicsUnit.Point);
            tb_password.Location        = new System.Drawing.Point(30, 266);
            tb_password.Size            = new System.Drawing.Size(360, 24);
            tb_password.PasswordChar    = '●';
            tb_password.PlaceholderText = "비밀번호를 입력하세요";
            tb_password.Text            = "";

            // btn_login
            btn_login.Text                      = "로그인";
            btn_login.Font                      = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_login.ForeColor                 = System.Drawing.Color.White;
            btn_login.BackColor                 = Theme.Accent;
            btn_login.FlatStyle                 = FlatStyle.Flat;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.Location                  = new System.Drawing.Point(30, 318);
            btn_login.Size                      = new System.Drawing.Size(360, 48);
            btn_login.Cursor                    = Cursors.Hand;
            btn_login.Click                    += btn_login_Click;

            // label2 (아이디 찾기)
            label2.Text      = "아이디 찾기";
            label2.Font      = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = Theme.TextMuted;
            label2.Location  = new System.Drawing.Point(30, 388);
            label2.AutoSize  = true;
            label2.Cursor    = Cursors.Hand;
            label2.Click    += label2_Click;

            // label3 (비밀번호 찾기)
            label3.Text      = "비밀번호 찾기";
            label3.Font      = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = Theme.TextMuted;
            label3.Location  = new System.Drawing.Point(155, 388);
            label3.AutoSize  = true;
            label3.Cursor    = Cursors.Hand;
            label3.Click    += label3_Click;

            // lb_join (회원가입)
            lb_join.Text      = "회원가입";
            lb_join.Font      = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_join.ForeColor = Theme.Accent;
            lb_join.Location  = new System.Drawing.Point(306, 388);
            lb_join.AutoSize  = true;
            lb_join.Cursor    = Cursors.Hand;
            lb_join.Click    += lb_join_Click;

            // ── UserControl ─────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Theme.BG;
            Controls.Add(pnl_card);
            Name = "Login";
            Size = new System.Drawing.Size(1280, 690);

            pnl_card.ResumeLayout(false);
            pnl_card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Panel     pnl_card;
        private PictureBox pictureBox1;
        private Label     lb_login_title;
        private Label     lb_id_label;
        private Label     lb_pw_label;
        private TextBox   tb_id;
        private TextBox   tb_password;
        private Button    btn_login;
        private Label     label2;
        private Label     label3;
        private Label     lb_join;
    }
}
