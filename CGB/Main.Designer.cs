namespace CGB
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btn_logout = new Button();
            lb_menu_1 = new Label();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            panel_main = new Panel();
            lb_resCnfm = new Label();
            lb_menu_book = new Label();
            btn_join = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logout.Location = new Point(1151, 8);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(82, 29);
            btn_logout.TabIndex = 8;
            btn_logout.Text = "로그아웃";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // lb_menu_1
            // 
            lb_menu_1.AutoSize = true;
            lb_menu_1.Cursor = Cursors.Hand;
            lb_menu_1.Font = new Font("Microsoft Sans Serif", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lb_menu_1.Location = new Point(22, 115);
            lb_menu_1.Name = "lb_menu_1";
            lb_menu_1.Size = new Size(60, 18);
            lb_menu_1.TabIndex = 11;
            lb_menu_1.Text = "무비차트";
            lb_menu_1.Click += menu_Click;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(1061, 8);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(82, 29);
            btn_login.TabIndex = 9;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            panel_main.Dock = DockStyle.Bottom;
            panel_main.Location = new Point(0, 136);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1268, 685);
            panel_main.TabIndex = 14;
            // 
            // lb_resCnfm
            // 
            lb_resCnfm.AutoSize = true;
            lb_resCnfm.Cursor = Cursors.Hand;
            lb_resCnfm.Font = new Font("Microsoft Sans Serif", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lb_resCnfm.Location = new Point(180, 115);
            lb_resCnfm.Name = "lb_resCnfm";
            lb_resCnfm.Size = new Size(60, 18);
            lb_resCnfm.TabIndex = 12;
            lb_resCnfm.Text = "예약확인";
            lb_resCnfm.Click += menu_Click;
            // 
            // lb_menu_book
            // 
            lb_menu_book.AutoSize = true;
            lb_menu_book.Cursor = Cursors.Hand;
            lb_menu_book.Font = new Font("Microsoft Sans Serif", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lb_menu_book.Location = new Point(101, 115);
            lb_menu_book.Name = "lb_menu_book";
            lb_menu_book.Size = new Size(60, 18);
            lb_menu_book.TabIndex = 13;
            lb_menu_book.Text = "예매하기";
            lb_menu_book.Click += menu_Click;
            // 
            // btn_join
            // 
            btn_join.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_join.Location = new Point(1151, 8);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(82, 29);
            btn_join.TabIndex = 15;
            btn_join.Text = "회원가입";
            btn_join.UseVisualStyleBackColor = true;
            btn_join.Click += btn_join_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1268, 821);
            Controls.Add(btn_join);
            Controls.Add(btn_logout);
            Controls.Add(lb_menu_1);
            Controls.Add(btn_login);
            Controls.Add(pictureBox1);
            Controls.Add(panel_main);
            Controls.Add(lb_resCnfm);
            Controls.Add(lb_menu_book);
            Name = "Main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_logout;
        private Label lb_menu_1;
        private Button btn_login;
        private PictureBox pictureBox1;
        private Panel panel_main;
        private Label lb_resCnfm;
        private Label lb_menu_book;
        private Button btn_join;
    }
}
