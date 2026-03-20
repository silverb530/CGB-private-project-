namespace keb_project
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            btn_login = new Button();
            btn_join = new Button();
            panel_main = new Panel();
            lb_menu_1 = new Label();
            panel_header = new Panel();
            btn_logout = new Button();
            lb_resCnfm = new Label();
            lb_menu_book = new Label();
            pictureBox1 = new PictureBox();
            panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Font = new Font("페이퍼로지 3 Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(639, 12);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(82, 29);
            btn_login.TabIndex = 3;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_join
            // 
            btn_join.Font = new Font("페이퍼로지 3 Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_join.Location = new Point(728, 12);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(82, 29);
            btn_join.TabIndex = 3;
            btn_join.Text = "회원가입";
            btn_join.UseVisualStyleBackColor = true;
            btn_join.Click += btn_join_Click;
            // 
            // panel_main
            // 
            panel_main.Dock = DockStyle.Bottom;
            panel_main.Location = new Point(0, 141);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(823, 630);
            panel_main.TabIndex = 7;
            // 
            // lb_menu_1
            // 
            lb_menu_1.AutoSize = true;
            lb_menu_1.Cursor = Cursors.Hand;
            lb_menu_1.Font = new Font("페이퍼로지 3 Light", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lb_menu_1.Location = new Point(22, 112);
            lb_menu_1.Name = "lb_menu_1";
            lb_menu_1.Size = new Size(60, 18);
            lb_menu_1.TabIndex = 6;
            lb_menu_1.Text = "무비차트";
            lb_menu_1.Click += menu_Click;
            // 
            // panel_header
            // 
            panel_header.Controls.Add(btn_logout);
            panel_header.Controls.Add(lb_resCnfm);
            panel_header.Controls.Add(lb_menu_book);
            panel_header.Controls.Add(lb_menu_1);
            panel_header.Controls.Add(btn_login);
            panel_header.Controls.Add(pictureBox1);
            panel_header.Controls.Add(btn_join);
            panel_header.Dock = DockStyle.Top;
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(823, 143);
            panel_header.TabIndex = 9;
            // 
            // btn_logout
            // 
            btn_logout.Font = new Font("페이퍼로지 3 Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logout.Location = new Point(729, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(82, 29);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "로그아웃";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // lb_resCnfm
            // 
            lb_resCnfm.AutoSize = true;
            lb_resCnfm.Cursor = Cursors.Hand;
            lb_resCnfm.Font = new Font("페이퍼로지 3 Light", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lb_resCnfm.Location = new Point(180, 112);
            lb_resCnfm.Name = "lb_resCnfm";
            lb_resCnfm.Size = new Size(60, 18);
            lb_resCnfm.TabIndex = 6;
            lb_resCnfm.Text = "예약확인";
            lb_resCnfm.Click += menu_Click;
            // 
            // lb_menu_book
            // 
            lb_menu_book.AutoSize = true;
            lb_menu_book.Cursor = Cursors.Hand;
            lb_menu_book.Font = new Font("페이퍼로지 3 Light", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lb_menu_book.Location = new Point(101, 112);
            lb_menu_book.Name = "lb_menu_book";
            lb_menu_book.Size = new Size(60, 18);
            lb_menu_book.TabIndex = 6;
            lb_menu_book.Text = "예매하기";
            lb_menu_book.Click += menu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(823, 771);
            Controls.Add(panel_header);
            Controls.Add(panel_main);
            Name = "mainForm";
            Text = "Form1";
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_login;
        private Button btn_join;
        private Panel panel_main;
        private Panel panel_header;
        private PictureBox pictureBox1;
        private Label lb_menu_1;
        private Button btn_logout;
        private Label lb_menu_book;
        private Label lb_resCnfm;
    }
}
