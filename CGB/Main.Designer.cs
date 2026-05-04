namespace CGB
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel_header = new Panel();
            pictureBox1 = new PictureBox();
            lb_menu_1 = new Label();
            lb_menu_book = new Label();
            lb_resCnfm = new Label();
            btn_login = new Button();
            btn_join = new Button();
            btn_logout = new Button();
            panel_main = new Panel();
            panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.FromArgb(10, 10, 20);
            panel_header.Controls.Add(pictureBox1);
            panel_header.Controls.Add(lb_menu_1);
            panel_header.Controls.Add(lb_menu_book);
            panel_header.Controls.Add(lb_resCnfm);
            panel_header.Controls.Add(btn_login);
            panel_header.Controls.Add(btn_join);
            panel_header.Controls.Add(btn_logout);
            panel_header.Dock = DockStyle.Top;
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1280, 130);
            panel_header.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lb_menu_1
            // 
            lb_menu_1.AutoSize = true;
            lb_menu_1.BackColor = Color.Transparent;
            lb_menu_1.Cursor = Cursors.Hand;
            lb_menu_1.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lb_menu_1.ForeColor = Color.FromArgb(180, 180, 205);
            lb_menu_1.Location = new Point(136, 95);
            lb_menu_1.Name = "lb_menu_1";
            lb_menu_1.Size = new Size(69, 20);
            lb_menu_1.TabIndex = 2;
            lb_menu_1.Text = "영화 소개";
            lb_menu_1.Click += menu_Click;
            // 
            // lb_menu_book
            // 
            lb_menu_book.AutoSize = true;
            lb_menu_book.BackColor = Color.Transparent;
            lb_menu_book.Cursor = Cursors.Hand;
            lb_menu_book.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lb_menu_book.ForeColor = Color.FromArgb(180, 180, 205);
            lb_menu_book.Location = new Point(256, 95);
            lb_menu_book.Name = "lb_menu_book";
            lb_menu_book.Size = new Size(69, 20);
            lb_menu_book.TabIndex = 3;
            lb_menu_book.Text = "예매하기";
            lb_menu_book.Click += menu_Click;
            // 
            // lb_resCnfm
            // 
            lb_resCnfm.AutoSize = true;
            lb_resCnfm.BackColor = Color.Transparent;
            lb_resCnfm.Cursor = Cursors.Hand;
            lb_resCnfm.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lb_resCnfm.ForeColor = Color.FromArgb(180, 180, 205);
            lb_resCnfm.Location = new Point(376, 95);
            lb_resCnfm.Name = "lb_resCnfm";
            lb_resCnfm.Size = new Size(69, 20);
            lb_resCnfm.TabIndex = 4;
            lb_resCnfm.Text = "예약확인";
            lb_resCnfm.Click += menu_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(220, 20, 40);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("맑은 고딕", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(1100, 45);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(78, 36);
            btn_login.TabIndex = 5;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_join
            // 
            btn_join.BackColor = Color.FromArgb(32, 32, 50);
            btn_join.Cursor = Cursors.Hand;
            btn_join.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 78);
            btn_join.FlatStyle = FlatStyle.Flat;
            btn_join.Font = new Font("맑은 고딕", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btn_join.ForeColor = Color.FromArgb(180, 180, 205);
            btn_join.Location = new Point(1188, 45);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(78, 36);
            btn_join.TabIndex = 6;
            btn_join.Text = "회원가입";
            btn_join.UseVisualStyleBackColor = false;
            btn_join.Click += btn_join_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(32, 32, 50);
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 78);
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("맑은 고딕", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.ForeColor = Color.FromArgb(180, 180, 205);
            btn_logout.Location = new Point(1188, 45);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(88, 36);
            btn_logout.TabIndex = 7;
            btn_logout.Text = "로그아웃";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // panel_main
            // 
            panel_main.BackColor = Color.FromArgb(18, 18, 28);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(0, 130);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1280, 690);
            panel_main.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 20);
            ClientSize = new Size(1280, 820);
            Controls.Add(panel_main);
            Controls.Add(panel_header);
            Name = "Main";
            Text = "CGB 영화 예매";
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Panel    panel_header;
        private Panel    panel_main;
        private PictureBox pictureBox1;
        private Label    lb_menu_1;
        private Label    lb_menu_book;
        private Label    lb_resCnfm;
        private Button   btn_login;
        private Button   btn_join;
        private Button   btn_logout;
    }
}
