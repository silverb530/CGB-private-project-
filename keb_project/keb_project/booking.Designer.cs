namespace keb_project
{
    partial class booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking));
            btn_add = new PictureBox();
            arrow_l = new PictureBox();
            arrow_r = new PictureBox();
            pb_poster = new PictureBox();
            grp_seat = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            button21 = new Button();
            button27 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            label1 = new Label();
            label5 = new Label();
            lb_loc = new Label();
            btn_today = new Button();
            btn_date_1 = new Button();
            btn_date_2 = new Button();
            btn_date_3 = new Button();
            btn_next = new Button();
            lb_time = new Label();
            lb_title = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrow_l).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrow_r).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_poster).BeginInit();
            grp_seat.SuspendLayout();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Image = Properties.Resources.추가;
            btn_add.Location = new Point(731, 28);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(30, 29);
            btn_add.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_add.TabIndex = 14;
            btn_add.TabStop = false;
            btn_add.Click += btn_add_Click;
            // 
            // arrow_l
            // 
            arrow_l.Image = (Image)resources.GetObject("arrow_l.Image");
            arrow_l.Location = new Point(32, 163);
            arrow_l.Name = "arrow_l";
            arrow_l.Size = new Size(43, 40);
            arrow_l.SizeMode = PictureBoxSizeMode.StretchImage;
            arrow_l.TabIndex = 10;
            arrow_l.TabStop = false;
            arrow_l.Click += arrow_l_Click;
            // 
            // arrow_r
            // 
            arrow_r.Image = (Image)resources.GetObject("arrow_r.Image");
            arrow_r.Location = new Point(355, 163);
            arrow_r.Name = "arrow_r";
            arrow_r.Size = new Size(43, 40);
            arrow_r.SizeMode = PictureBoxSizeMode.StretchImage;
            arrow_r.TabIndex = 11;
            arrow_r.TabStop = false;
            arrow_r.Click += arrow_r_Click;
            // 
            // pb_poster
            // 
            pb_poster.Location = new Point(110, 60);
            pb_poster.Name = "pb_poster";
            pb_poster.Size = new Size(215, 256);
            pb_poster.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_poster.TabIndex = 12;
            pb_poster.TabStop = false;
            // 
            // grp_seat
            // 
            grp_seat.Controls.Add(button2);
            grp_seat.Controls.Add(button3);
            grp_seat.Controls.Add(button7);
            grp_seat.Controls.Add(button8);
            grp_seat.Controls.Add(button21);
            grp_seat.Controls.Add(button27);
            grp_seat.Controls.Add(button22);
            grp_seat.Controls.Add(button23);
            grp_seat.Controls.Add(button24);
            grp_seat.Controls.Add(button25);
            grp_seat.Controls.Add(button26);
            grp_seat.Controls.Add(label1);
            grp_seat.Controls.Add(label5);
            grp_seat.Location = new Point(32, 348);
            grp_seat.Name = "grp_seat";
            grp_seat.Size = new Size(747, 406);
            grp_seat.TabIndex = 18;
            grp_seat.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(14, 266);
            button2.Name = "button2";
            button2.Size = new Size(121, 77);
            button2.TabIndex = 0;
            button2.Tag = "21:00 - 13:37 3관(리클라이너)";
            button2.Text = "21:00 - 13:37\r\n34/84\r\n3관(리클라이너)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_time_Click;
            // 
            // button3
            // 
            button3.Location = new Point(304, 183);
            button3.Name = "button3";
            button3.Size = new Size(121, 77);
            button3.TabIndex = 0;
            button3.Tag = "14:00 - 16:37 6관";
            button3.Text = "14:00 - 16:37\r\n66/180\r\n6관";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_time_Click;
            // 
            // button7
            // 
            button7.Location = new Point(304, 55);
            button7.Name = "button7";
            button7.Size = new Size(121, 77);
            button7.TabIndex = 0;
            button7.Tag = "10:00 - 12:37 3관(리클라이너)";
            button7.Text = "10:00 - 12:37\r\n66/84\r\n3관(리클라이너)";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn_time_Click;
            // 
            // button8
            // 
            button8.Location = new Point(593, 183);
            button8.Name = "button8";
            button8.Size = new Size(121, 77);
            button8.TabIndex = 0;
            button8.Tag = "16:30 - 18:07 2관";
            button8.Text = "16:30 - 18:07\r\n100/180\r\n2관";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn_time_Click;
            // 
            // button21
            // 
            button21.Location = new Point(161, 183);
            button21.Name = "button21";
            button21.Size = new Size(121, 77);
            button21.TabIndex = 0;
            button21.Tag = "13:30 - 16:07 4관";
            button21.Text = "13:30 - 16:07\r\n80/180\r\n4관";
            button21.UseVisualStyleBackColor = true;
            button21.Click += btn_time_Click;
            // 
            // button27
            // 
            button27.Location = new Point(593, 55);
            button27.Name = "button27";
            button27.Size = new Size(121, 77);
            button27.TabIndex = 0;
            button27.Tag = "11:00 - 13:37 4관(리클라이너)";
            button27.Text = "11:00 - 13:37\r\n31/70\r\n4관(리클라이너)";
            button27.UseVisualStyleBackColor = true;
            button27.Click += btn_time_Click;
            // 
            // button22
            // 
            button22.Enabled = false;
            button22.Location = new Point(446, 55);
            button22.Name = "button22";
            button22.Size = new Size(121, 77);
            button22.TabIndex = 0;
            button22.Tag = "10:30 - 13:07 5관(리클라이너)";
            button22.Text = "10:30 - 13:07\r\n70/70\r\n5관(리클라이너)";
            button22.UseVisualStyleBackColor = true;
            button22.Click += btn_time_Click;
            // 
            // button23
            // 
            button23.Location = new Point(446, 183);
            button23.Name = "button23";
            button23.Size = new Size(121, 77);
            button23.TabIndex = 0;
            button23.Tag = "15:30 - 18:07 1관(리클라이너)";
            button23.Text = "15:30 - 18:07\r\n51/70\r\n1관(리클라이너)";
            button23.UseVisualStyleBackColor = true;
            button23.Click += btn_time_Click;
            // 
            // button24
            // 
            button24.Location = new Point(14, 183);
            button24.Name = "button24";
            button24.Size = new Size(121, 77);
            button24.TabIndex = 0;
            button24.Tag = "13:00 - 15:37 2관";
            button24.Text = "13:00 - 15:37\r\n60/70\r\n2관";
            button24.UseVisualStyleBackColor = true;
            button24.Click += btn_time_Click;
            // 
            // button25
            // 
            button25.Location = new Point(161, 55);
            button25.Name = "button25";
            button25.Size = new Size(121, 77);
            button25.TabIndex = 0;
            button25.Tag = "09:30 - 12:07 2관";
            button25.Text = "09:30 - 12:07\r\n100/180\r\n2관";
            button25.UseVisualStyleBackColor = true;
            button25.Click += btn_time_Click;
            // 
            // button26
            // 
            button26.Location = new Point(14, 55);
            button26.Name = "button26";
            button26.Size = new Size(121, 77);
            button26.TabIndex = 0;
            button26.Tag = "09:00 - 11:37 1관(리클라이너)";
            button26.Text = "09:00 - 11:37\r\n44/70\r\n1관(리클라이너)";
            button26.UseVisualStyleBackColor = true;
            button26.Click += btn_time_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 148);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 13;
            label1.Text = "오후";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 28);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 13;
            label5.Text = "오전";
            // 
            // lb_loc
            // 
            lb_loc.AutoSize = true;
            lb_loc.Location = new Point(511, 42);
            lb_loc.Name = "lb_loc";
            lb_loc.Size = new Size(58, 15);
            lb_loc.TabIndex = 13;
            lb_loc.Text = "아산 CGB";
            // 
            // btn_today
            // 
            btn_today.BackColor = Color.White;
            btn_today.Location = new Point(511, 89);
            btn_today.Name = "btn_today";
            btn_today.Size = new Size(58, 38);
            btn_today.TabIndex = 0;
            btn_today.Tag = "2026-03-04 수요일";
            btn_today.Text = "오늘\r\n4일";
            btn_today.UseVisualStyleBackColor = false;
            btn_today.Click += btn_today_Click;
            // 
            // btn_date_1
            // 
            btn_date_1.Location = new Point(575, 89);
            btn_date_1.Name = "btn_date_1";
            btn_date_1.Size = new Size(58, 38);
            btn_date_1.TabIndex = 0;
            btn_date_1.Tag = "2026-03-05 목요일";
            btn_date_1.Text = "목\r\n5일";
            btn_date_1.UseVisualStyleBackColor = true;
            btn_date_1.Click += btn_today_Click;
            // 
            // btn_date_2
            // 
            btn_date_2.Location = new Point(639, 89);
            btn_date_2.Name = "btn_date_2";
            btn_date_2.Size = new Size(58, 38);
            btn_date_2.TabIndex = 0;
            btn_date_2.Tag = "2026-03-06 금요일";
            btn_date_2.Text = "금\r\n6일";
            btn_date_2.UseVisualStyleBackColor = true;
            btn_date_2.Click += btn_today_Click;
            // 
            // btn_date_3
            // 
            btn_date_3.Location = new Point(703, 89);
            btn_date_3.Name = "btn_date_3";
            btn_date_3.Size = new Size(58, 38);
            btn_date_3.TabIndex = 0;
            btn_date_3.Tag = "2026-03-07 토요일";
            btn_date_3.Text = "토\r\n7일";
            btn_date_3.UseVisualStyleBackColor = true;
            btn_date_3.Click += btn_today_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(511, 304);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(250, 38);
            btn_next.TabIndex = 0;
            btn_next.Tag = "1";
            btn_next.Text = "다음";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.Location = new Point(511, 199);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(12, 15);
            lb_time.TabIndex = 26;
            lb_time.Text = "-";
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Location = new Point(511, 153);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(12, 15);
            lb_title.TabIndex = 27;
            lb_title.Text = "-";
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(lb_title);
            Controls.Add(lb_time);
            Controls.Add(grp_seat);
            Controls.Add(btn_add);
            Controls.Add(btn_date_3);
            Controls.Add(btn_date_2);
            Controls.Add(btn_date_1);
            Controls.Add(btn_next);
            Controls.Add(btn_today);
            Controls.Add(lb_loc);
            Controls.Add(arrow_l);
            Controls.Add(arrow_r);
            Controls.Add(pb_poster);
            Name = "booking";
            Size = new Size(806, 630);
            ((System.ComponentModel.ISupportInitialize)btn_add).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrow_l).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrow_r).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_poster).EndInit();
            grp_seat.ResumeLayout(false);
            grp_seat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_add;
        private PictureBox arrow_l;
        private PictureBox arrow_r;
        private PictureBox pb_poster;
        private Label lb_loc;
        private Button btn_today;
        private Button btn_date_1;
        private Button btn_date_2;
        private Button btn_date_3;
        private GroupBox grp_seat;
        private Button button2;
        private Button button3;
        private Button button7;
        private Button button8;
        private Button button21;
        private Button button27;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Label label1;
        private Label label5;
        private Button btn_next;
        private Label lb_time;
        private Label lb_title;
    }
}
