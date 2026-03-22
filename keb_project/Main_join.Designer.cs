namespace keb_project
{
    partial class Main_join
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            txt_name = new TextBox();
            txt_pw = new TextBox();
            txt_id = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_pw);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Location = new Point(175, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 462);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(79, 227);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 7;
            label4.Text = "이름";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 175);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 7;
            label3.Text = "패스워드";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 119);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 7;
            label2.Text = "아이디";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(110, 346);
            button1.Name = "button1";
            button1.Size = new Size(252, 39);
            button1.TabIndex = 5;
            button1.Text = "회원가입";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(155, 227);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(252, 23);
            txt_name.TabIndex = 0;
            // 
            // txt_pw
            // 
            txt_pw.Location = new Point(155, 177);
            txt_pw.Name = "txt_pw";
            txt_pw.PasswordChar = '*';
            txt_pw.Size = new Size(252, 23);
            txt_pw.TabIndex = 0;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(155, 119);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(252, 23);
            txt_id.TabIndex = 0;
            // 
            // Main_join
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Name = "Main_join";
            Size = new Size(823, 630);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox txt_name;
        private TextBox txt_pw;
        private TextBox txt_id;
    }
}
