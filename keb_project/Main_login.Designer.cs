namespace keb_project
{
    partial class Main_login
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_login));
            lb_join = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_login = new Button();
            tb_password = new TextBox();
            tb_id = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_join
            // 
            lb_join.AutoSize = true;
            lb_join.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_join.Location = new Point(477, 377);
            lb_join.Name = "lb_join";
            lb_join.Size = new Size(55, 15);
            lb_join.TabIndex = 6;
            lb_join.Text = "회원가입";
            lb_join.Click += lb_join_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(368, 377);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "비밀번호 찾기";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(280, 377);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 6;
            label2.Text = "아이디 찾기";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(255, 192, 192);
            btn_login.Cursor = Cursors.Hand;
            btn_login.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(280, 320);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(252, 39);
            btn_login.TabIndex = 5;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(280, 273);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.PlaceholderText = "비밀번호를 입력하세요";
            tb_password.Size = new Size(252, 23);
            tb_password.TabIndex = 0;
            tb_password.Text = "1234";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(280, 220);
            tb_id.Name = "tb_id";
            tb_id.PlaceholderText = "아이디를 입력하세요";
            tb_id.Size = new Size(252, 23);
            tb_id.TabIndex = 0;
            tb_id.Text = "kbee";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Main_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lb_join);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_id);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Name = "Main_login";
            Size = new Size(823, 630);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_join;
        private Label label3;
        private Label label2;
        private Button btn_login;
        private TextBox tb_password;
        private TextBox tb_id;
        private PictureBox pictureBox1;
    }
}
