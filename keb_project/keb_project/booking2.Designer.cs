namespace keb_project
{
    partial class booking2
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
            grp_seat = new GroupBox();
            A1 = new Button();
            E6 = new Button();
            label2 = new Label();
            C6 = new Button();
            label3 = new Label();
            D6 = new Button();
            label8 = new Label();
            B6 = new Button();
            label20 = new Label();
            E5 = new Button();
            label14 = new Label();
            A6 = new Button();
            D5 = new Button();
            label21 = new Label();
            C5 = new Button();
            B5 = new Button();
            E4 = new Button();
            A5 = new Button();
            D4 = new Button();
            C4 = new Button();
            B1 = new Button();
            B4 = new Button();
            label31 = new Label();
            A4 = new Button();
            D1 = new Button();
            label30 = new Label();
            C1 = new Button();
            label19 = new Label();
            label13 = new Label();
            E3 = new Button();
            E1 = new Button();
            label7 = new Label();
            D3 = new Button();
            C3 = new Button();
            label26 = new Label();
            B3 = new Button();
            A2 = new Button();
            label29 = new Label();
            label27 = new Label();
            A3 = new Button();
            B2 = new Button();
            label28 = new Label();
            button8 = new Button();
            label18 = new Label();
            D2 = new Button();
            label12 = new Label();
            label6 = new Label();
            E2 = new Button();
            lb_time = new Label();
            lb = new Label();
            label4 = new Label();
            nud_1 = new NumericUpDown();
            nud_2 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            btn_date_4 = new Button();
            btn_date_3 = new Button();
            btn_date_2 = new Button();
            btn_date_1 = new Button();
            lb_loc = new Label();
            btn_pay = new Button();
            lb_totPrice = new Label();
            label = new Label();
            lb_totcnt = new Label();
            lb_price1 = new Label();
            lb_price2 = new Label();
            naverPay = new PictureBox();
            kakaoPay = new PictureBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            lb_title = new Label();
            button1 = new Button();
            btn_stnd_pay = new Button();
            btn_smpl_pay = new Button();
            grp_seat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)naverPay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kakaoPay).BeginInit();
            SuspendLayout();
            // 
            // grp_seat
            // 
            grp_seat.Controls.Add(A1);
            grp_seat.Controls.Add(E6);
            grp_seat.Controls.Add(label2);
            grp_seat.Controls.Add(C6);
            grp_seat.Controls.Add(label3);
            grp_seat.Controls.Add(D6);
            grp_seat.Controls.Add(label8);
            grp_seat.Controls.Add(B6);
            grp_seat.Controls.Add(label20);
            grp_seat.Controls.Add(E5);
            grp_seat.Controls.Add(label14);
            grp_seat.Controls.Add(A6);
            grp_seat.Controls.Add(D5);
            grp_seat.Controls.Add(label21);
            grp_seat.Controls.Add(C5);
            grp_seat.Controls.Add(B5);
            grp_seat.Controls.Add(E4);
            grp_seat.Controls.Add(A5);
            grp_seat.Controls.Add(D4);
            grp_seat.Controls.Add(C4);
            grp_seat.Controls.Add(B1);
            grp_seat.Controls.Add(B4);
            grp_seat.Controls.Add(label31);
            grp_seat.Controls.Add(A4);
            grp_seat.Controls.Add(D1);
            grp_seat.Controls.Add(label30);
            grp_seat.Controls.Add(C1);
            grp_seat.Controls.Add(label19);
            grp_seat.Controls.Add(label13);
            grp_seat.Controls.Add(E3);
            grp_seat.Controls.Add(E1);
            grp_seat.Controls.Add(label7);
            grp_seat.Controls.Add(D3);
            grp_seat.Controls.Add(C3);
            grp_seat.Controls.Add(label26);
            grp_seat.Controls.Add(B3);
            grp_seat.Controls.Add(A2);
            grp_seat.Controls.Add(label29);
            grp_seat.Controls.Add(label27);
            grp_seat.Controls.Add(A3);
            grp_seat.Controls.Add(B2);
            grp_seat.Controls.Add(label28);
            grp_seat.Controls.Add(button8);
            grp_seat.Controls.Add(label18);
            grp_seat.Controls.Add(D2);
            grp_seat.Controls.Add(label12);
            grp_seat.Controls.Add(label6);
            grp_seat.Controls.Add(E2);
            grp_seat.Location = new Point(55, 192);
            grp_seat.Name = "grp_seat";
            grp_seat.Size = new Size(380, 282);
            grp_seat.TabIndex = 17;
            grp_seat.TabStop = false;
            // 
            // A1
            // 
            A1.Location = new Point(27, 22);
            A1.Name = "A1";
            A1.Size = new Size(43, 44);
            A1.TabIndex = 15;
            A1.Tag = "A";
            A1.Text = "1";
            A1.UseVisualStyleBackColor = true;
            A1.Click += seat_select_Click;
            // 
            // E6
            // 
            E6.Location = new Point(322, 222);
            E6.Name = "E6";
            E6.Size = new Size(43, 44);
            E6.TabIndex = 15;
            E6.Tag = "E";
            E6.Text = "6";
            E6.UseVisualStyleBackColor = true;
            E6.Click += seat_select_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 13;
            label2.Text = "A";
            // 
            // C6
            // 
            C6.Location = new Point(322, 122);
            C6.Name = "C6";
            C6.Size = new Size(43, 44);
            C6.TabIndex = 15;
            C6.Tag = "C";
            C6.Text = "6";
            C6.UseVisualStyleBackColor = true;
            C6.Click += seat_select_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 37);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 13;
            label3.Text = "A";
            label3.Click += seat_select_Click;
            // 
            // D6
            // 
            D6.Location = new Point(322, 172);
            D6.Name = "D6";
            D6.Size = new Size(43, 44);
            D6.TabIndex = 15;
            D6.Tag = "D";
            D6.Text = "6";
            D6.UseVisualStyleBackColor = true;
            D6.Click += seat_select_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 87);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 13;
            label8.Text = "B";
            // 
            // B6
            // 
            B6.Location = new Point(322, 72);
            B6.Name = "B6";
            B6.Size = new Size(43, 44);
            B6.TabIndex = 15;
            B6.Tag = "B";
            B6.Text = "6";
            B6.UseVisualStyleBackColor = true;
            B6.Click += seat_select_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 187);
            label20.Name = "label20";
            label20.Size = new Size(16, 15);
            label20.TabIndex = 13;
            label20.Text = "D";
            // 
            // E5
            // 
            E5.Location = new Point(264, 222);
            E5.Name = "E5";
            E5.Size = new Size(43, 44);
            E5.TabIndex = 15;
            E5.Tag = "E";
            E5.Text = "5";
            E5.UseVisualStyleBackColor = true;
            E5.Click += seat_select_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 137);
            label14.Name = "label14";
            label14.Size = new Size(15, 15);
            label14.TabIndex = 13;
            label14.Text = "C";
            // 
            // A6
            // 
            A6.Location = new Point(322, 22);
            A6.Name = "A6";
            A6.Size = new Size(43, 44);
            A6.TabIndex = 15;
            A6.Tag = "A";
            A6.Text = "6";
            A6.UseVisualStyleBackColor = true;
            A6.Click += seat_select_Click;
            // 
            // D5
            // 
            D5.Location = new Point(264, 172);
            D5.Name = "D5";
            D5.Size = new Size(43, 44);
            D5.TabIndex = 15;
            D5.Tag = "D";
            D5.Text = "5";
            D5.UseVisualStyleBackColor = true;
            D5.Click += seat_select_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 237);
            label21.Name = "label21";
            label21.Size = new Size(13, 15);
            label21.TabIndex = 13;
            label21.Text = "E";
            // 
            // C5
            // 
            C5.Location = new Point(264, 122);
            C5.Name = "C5";
            C5.Size = new Size(43, 44);
            C5.TabIndex = 15;
            C5.Tag = "C";
            C5.Text = "5";
            C5.UseVisualStyleBackColor = true;
            C5.Click += seat_select_Click;
            // 
            // B5
            // 
            B5.Location = new Point(264, 72);
            B5.Name = "B5";
            B5.Size = new Size(43, 44);
            B5.TabIndex = 15;
            B5.Tag = "B";
            B5.Text = "5";
            B5.UseVisualStyleBackColor = true;
            B5.Click += seat_select_Click;
            // 
            // E4
            // 
            E4.Location = new Point(201, 222);
            E4.Name = "E4";
            E4.Size = new Size(43, 44);
            E4.TabIndex = 15;
            E4.Tag = "E";
            E4.Text = "4";
            E4.UseVisualStyleBackColor = true;
            E4.Click += seat_select_Click;
            // 
            // A5
            // 
            A5.Location = new Point(264, 22);
            A5.Name = "A5";
            A5.Size = new Size(43, 44);
            A5.TabIndex = 15;
            A5.Tag = "A";
            A5.Text = "5";
            A5.UseVisualStyleBackColor = true;
            A5.Click += seat_select_Click;
            // 
            // D4
            // 
            D4.Location = new Point(201, 172);
            D4.Name = "D4";
            D4.Size = new Size(43, 44);
            D4.TabIndex = 15;
            D4.Tag = "D";
            D4.Text = "4";
            D4.UseVisualStyleBackColor = true;
            D4.Click += seat_select_Click;
            // 
            // C4
            // 
            C4.Location = new Point(201, 122);
            C4.Name = "C4";
            C4.Size = new Size(43, 44);
            C4.TabIndex = 15;
            C4.Tag = "C";
            C4.Text = "4";
            C4.UseVisualStyleBackColor = true;
            C4.Click += seat_select_Click;
            // 
            // B1
            // 
            B1.Location = new Point(27, 72);
            B1.Name = "B1";
            B1.Size = new Size(43, 44);
            B1.TabIndex = 15;
            B1.Tag = "B";
            B1.Text = "1";
            B1.UseVisualStyleBackColor = true;
            B1.Click += seat_select_Click;
            // 
            // B4
            // 
            B4.Location = new Point(201, 72);
            B4.Name = "B4";
            B4.Size = new Size(43, 44);
            B4.TabIndex = 15;
            B4.Tag = "B";
            B4.Text = "4";
            B4.UseVisualStyleBackColor = true;
            B4.Click += seat_select_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(279, 237);
            label31.Name = "label31";
            label31.Size = new Size(15, 15);
            label31.TabIndex = 13;
            label31.Text = "A";
            label31.Click += seat_select_Click;
            // 
            // A4
            // 
            A4.Location = new Point(201, 22);
            A4.Name = "A4";
            A4.Size = new Size(43, 44);
            A4.TabIndex = 15;
            A4.Tag = "A";
            A4.Text = "4";
            A4.UseVisualStyleBackColor = true;
            A4.Click += seat_select_Click;
            // 
            // D1
            // 
            D1.Location = new Point(27, 172);
            D1.Name = "D1";
            D1.Size = new Size(43, 44);
            D1.TabIndex = 15;
            D1.Tag = "D";
            D1.Text = "1";
            D1.UseVisualStyleBackColor = true;
            D1.Click += seat_select_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(279, 187);
            label30.Name = "label30";
            label30.Size = new Size(15, 15);
            label30.TabIndex = 13;
            label30.Text = "A";
            label30.Click += seat_select_Click;
            // 
            // C1
            // 
            C1.Location = new Point(27, 122);
            C1.Name = "C1";
            C1.Size = new Size(43, 44);
            C1.TabIndex = 15;
            C1.Tag = "C";
            C1.Text = "1";
            C1.UseVisualStyleBackColor = true;
            C1.Click += seat_select_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(279, 137);
            label19.Name = "label19";
            label19.Size = new Size(15, 15);
            label19.TabIndex = 13;
            label19.Text = "A";
            label19.Click += seat_select_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(279, 87);
            label13.Name = "label13";
            label13.Size = new Size(15, 15);
            label13.TabIndex = 13;
            label13.Text = "A";
            label13.Click += seat_select_Click;
            // 
            // E3
            // 
            E3.Location = new Point(143, 222);
            E3.Name = "E3";
            E3.Size = new Size(43, 44);
            E3.TabIndex = 15;
            E3.Tag = "E";
            E3.Text = "3";
            E3.UseVisualStyleBackColor = true;
            E3.Click += seat_select_Click;
            // 
            // E1
            // 
            E1.Location = new Point(27, 222);
            E1.Name = "E1";
            E1.Size = new Size(43, 44);
            E1.TabIndex = 15;
            E1.Tag = "E";
            E1.Text = "1";
            E1.UseVisualStyleBackColor = true;
            E1.Click += seat_select_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 37);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 13;
            label7.Text = "A";
            label7.Click += seat_select_Click;
            // 
            // D3
            // 
            D3.Location = new Point(143, 172);
            D3.Name = "D3";
            D3.Size = new Size(43, 44);
            D3.TabIndex = 15;
            D3.Tag = "D";
            D3.Text = "3";
            D3.UseVisualStyleBackColor = true;
            D3.Click += seat_select_Click;
            // 
            // C3
            // 
            C3.Location = new Point(143, 122);
            C3.Name = "C3";
            C3.Size = new Size(43, 44);
            C3.TabIndex = 15;
            C3.Tag = "C";
            C3.Text = "3";
            C3.UseVisualStyleBackColor = true;
            C3.Click += seat_select_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(158, 187);
            label26.Name = "label26";
            label26.Size = new Size(15, 15);
            label26.TabIndex = 13;
            label26.Text = "A";
            label26.Click += seat_select_Click;
            // 
            // B3
            // 
            B3.Location = new Point(143, 72);
            B3.Name = "B3";
            B3.Size = new Size(43, 44);
            B3.TabIndex = 15;
            B3.Tag = "B";
            B3.Text = "3";
            B3.UseVisualStyleBackColor = true;
            B3.Click += seat_select_Click;
            // 
            // A2
            // 
            A2.Location = new Point(85, 22);
            A2.Name = "A2";
            A2.Size = new Size(43, 44);
            A2.TabIndex = 15;
            A2.Tag = "A";
            A2.Text = "2";
            A2.UseVisualStyleBackColor = true;
            A2.Click += seat_select_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(221, 237);
            label29.Name = "label29";
            label29.Size = new Size(15, 15);
            label29.TabIndex = 13;
            label29.Text = "A";
            label29.Click += seat_select_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(158, 237);
            label27.Name = "label27";
            label27.Size = new Size(15, 15);
            label27.TabIndex = 13;
            label27.Text = "A";
            label27.Click += seat_select_Click;
            // 
            // A3
            // 
            A3.Location = new Point(143, 22);
            A3.Name = "A3";
            A3.Size = new Size(43, 44);
            A3.TabIndex = 15;
            A3.Tag = "A";
            A3.Text = "3";
            A3.UseVisualStyleBackColor = true;
            A3.Click += seat_select_Click;
            // 
            // B2
            // 
            B2.Location = new Point(85, 72);
            B2.Name = "B2";
            B2.Size = new Size(43, 44);
            B2.TabIndex = 15;
            B2.Tag = "B";
            B2.Text = "2";
            B2.UseVisualStyleBackColor = true;
            B2.Click += seat_select_Click;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(221, 187);
            label28.Name = "label28";
            label28.Size = new Size(15, 15);
            label28.TabIndex = 13;
            label28.Text = "A";
            label28.Click += seat_select_Click;
            // 
            // button8
            // 
            button8.AccessibleDescription = "C2";
            button8.Location = new Point(85, 122);
            button8.Name = "button8";
            button8.Size = new Size(43, 44);
            button8.TabIndex = 15;
            button8.Tag = "C";
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += seat_select_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(221, 137);
            label18.Name = "label18";
            label18.Size = new Size(15, 15);
            label18.TabIndex = 13;
            label18.Text = "A";
            label18.Click += seat_select_Click;
            // 
            // D2
            // 
            D2.Location = new Point(85, 172);
            D2.Name = "D2";
            D2.Size = new Size(43, 44);
            D2.TabIndex = 15;
            D2.Tag = "D";
            D2.Text = "2";
            D2.UseVisualStyleBackColor = true;
            D2.Click += seat_select_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(221, 87);
            label12.Name = "label12";
            label12.Size = new Size(15, 15);
            label12.TabIndex = 13;
            label12.Text = "A";
            label12.Click += seat_select_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 37);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 13;
            label6.Text = "A";
            label6.Click += seat_select_Click;
            // 
            // E2
            // 
            E2.Location = new Point(85, 222);
            E2.Name = "E2";
            E2.Size = new Size(43, 44);
            E2.TabIndex = 15;
            E2.Tag = "E";
            E2.Text = "2";
            E2.UseVisualStyleBackColor = true;
            E2.Click += seat_select_Click;
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.Location = new Point(548, 167);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(12, 15);
            lb_time.TabIndex = 25;
            lb_time.Text = "-";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(548, 203);
            lb.Name = "lb";
            lb.Size = new Size(31, 15);
            lb.TabIndex = 23;
            lb.Text = "일반";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(536, 229);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 23;
            label4.Text = "청소년";
            // 
            // nud_1
            // 
            nud_1.Location = new Point(597, 201);
            nud_1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nud_1.Name = "nud_1";
            nud_1.Size = new Size(120, 23);
            nud_1.TabIndex = 26;
            nud_1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // nud_2
            // 
            nud_2.Location = new Point(597, 227);
            nud_2.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nud_2.Name = "nud_2";
            nud_2.Size = new Size(120, 23);
            nud_2.TabIndex = 26;
            nud_2.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.추가;
            pictureBox1.Location = new Point(752, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // btn_date_4
            // 
            btn_date_4.Enabled = false;
            btn_date_4.Location = new Point(724, 80);
            btn_date_4.Name = "btn_date_4";
            btn_date_4.Size = new Size(58, 38);
            btn_date_4.TabIndex = 27;
            btn_date_4.Tag = "2026-03-07 토요일";
            btn_date_4.Text = "토\r\n7일";
            btn_date_4.UseVisualStyleBackColor = true;
            // 
            // btn_date_3
            // 
            btn_date_3.Enabled = false;
            btn_date_3.Location = new Point(660, 80);
            btn_date_3.Name = "btn_date_3";
            btn_date_3.Size = new Size(58, 38);
            btn_date_3.TabIndex = 28;
            btn_date_3.Tag = "2026-03-06 금요일";
            btn_date_3.Text = "금\r\n6일";
            btn_date_3.UseVisualStyleBackColor = true;
            // 
            // btn_date_2
            // 
            btn_date_2.Enabled = false;
            btn_date_2.Location = new Point(596, 80);
            btn_date_2.Name = "btn_date_2";
            btn_date_2.Size = new Size(58, 38);
            btn_date_2.TabIndex = 29;
            btn_date_2.Tag = "2026-03-05 목요일";
            btn_date_2.Text = "목\r\n5일";
            btn_date_2.UseVisualStyleBackColor = true;
            // 
            // btn_date_1
            // 
            btn_date_1.BackColor = Color.White;
            btn_date_1.Enabled = false;
            btn_date_1.Location = new Point(532, 80);
            btn_date_1.Name = "btn_date_1";
            btn_date_1.Size = new Size(58, 38);
            btn_date_1.TabIndex = 31;
            btn_date_1.Tag = "2026-03-04 수요일";
            btn_date_1.Text = "오늘\r\n4일";
            btn_date_1.UseVisualStyleBackColor = false;
            // 
            // lb_loc
            // 
            lb_loc.AutoSize = true;
            lb_loc.Location = new Point(532, 33);
            lb_loc.Name = "lb_loc";
            lb_loc.Size = new Size(58, 15);
            lb_loc.TabIndex = 32;
            lb_loc.Text = "아산 CGB";
            // 
            // btn_pay
            // 
            btn_pay.Location = new Point(536, 554);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(250, 38);
            btn_pay.TabIndex = 21;
            btn_pay.Tag = "1";
            btn_pay.Text = "완료";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += btn_pay_Click;
            // 
            // lb_totPrice
            // 
            lb_totPrice.AutoSize = true;
            lb_totPrice.Font = new Font("페이퍼로지 7 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_totPrice.Location = new Point(536, 516);
            lb_totPrice.Name = "lb_totPrice";
            lb_totPrice.Size = new Size(80, 19);
            lb_totPrice.TabIndex = 34;
            lb_totPrice.Text = "총금액 - 원";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(544, 279);
            label.Name = "label";
            label.Size = new Size(35, 15);
            label.TabIndex = 23;
            label.Text = "인원 ";
            // 
            // lb_totcnt
            // 
            lb_totcnt.AutoSize = true;
            lb_totcnt.Location = new Point(597, 279);
            lb_totcnt.Name = "lb_totcnt";
            lb_totcnt.Size = new Size(12, 15);
            lb_totcnt.TabIndex = 23;
            lb_totcnt.Text = "-";
            // 
            // lb_price1
            // 
            lb_price1.AutoSize = true;
            lb_price1.Location = new Point(740, 203);
            lb_price1.Name = "lb_price1";
            lb_price1.Size = new Size(42, 15);
            lb_price1.TabIndex = 23;
            lb_price1.Text = "15000";
            // 
            // lb_price2
            // 
            lb_price2.AutoSize = true;
            lb_price2.Location = new Point(740, 235);
            lb_price2.Name = "lb_price2";
            lb_price2.Size = new Size(42, 15);
            lb_price2.TabIndex = 23;
            lb_price2.Text = "11000";
            // 
            // naverPay
            // 
            naverPay.Image = Properties.Resources.네이버1;
            naverPay.Location = new Point(669, 294);
            naverPay.Name = "naverPay";
            naverPay.Size = new Size(100, 89);
            naverPay.SizeMode = PictureBoxSizeMode.StretchImage;
            naverPay.TabIndex = 35;
            naverPay.TabStop = false;
            // 
            // kakaoPay
            // 
            kakaoPay.Image = Properties.Resources.카카오페이_CI_combination_with_BG1;
            kakaoPay.Location = new Point(553, 294);
            kakaoPay.Name = "kakaoPay";
            kakaoPay.Size = new Size(100, 89);
            kakaoPay.SizeMode = PictureBoxSizeMode.StretchImage;
            kakaoPay.TabIndex = 35;
            kakaoPay.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "신용카드", "체크카드" });
            comboBox1.Location = new Point(113, 534);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 23);
            comboBox1.TabIndex = 36;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(228, 534);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 37;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "일시불", "3개월(무이자)", "4개월(무이자)", "5개월", "6개월" });
            comboBox3.Location = new Point(114, 563);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(235, 23);
            comboBox3.TabIndex = 37;
            comboBox3.Visible = false;
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Location = new Point(548, 133);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(12, 15);
            lb_title.TabIndex = 38;
            lb_title.Text = "-";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(55, 98);
            button1.Name = "button1";
            button1.Size = new Size(380, 29);
            button1.TabIndex = 21;
            button1.Tag = "1";
            button1.Text = "스크린";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_stnd_pay
            // 
            btn_stnd_pay.Location = new Point(553, 389);
            btn_stnd_pay.Name = "btn_stnd_pay";
            btn_stnd_pay.Size = new Size(101, 95);
            btn_stnd_pay.TabIndex = 21;
            btn_stnd_pay.Tag = "1";
            btn_stnd_pay.Text = "일반결제";
            btn_stnd_pay.UseVisualStyleBackColor = true;
            btn_stnd_pay.Click += btn_pay_Click;
            // 
            // btn_smpl_pay
            // 
            btn_smpl_pay.Location = new Point(669, 389);
            btn_smpl_pay.Name = "btn_smpl_pay";
            btn_smpl_pay.Size = new Size(101, 95);
            btn_smpl_pay.TabIndex = 21;
            btn_smpl_pay.Tag = "1";
            btn_smpl_pay.Text = "간편결제";
            btn_smpl_pay.UseVisualStyleBackColor = true;
            btn_smpl_pay.Click += btn_pay_Click;
            // 
            // booking2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lb_title);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(kakaoPay);
            Controls.Add(lb_totPrice);
            Controls.Add(naverPay);
            Controls.Add(pictureBox1);
            Controls.Add(btn_date_4);
            Controls.Add(btn_date_3);
            Controls.Add(btn_date_2);
            Controls.Add(btn_date_1);
            Controls.Add(lb_loc);
            Controls.Add(nud_2);
            Controls.Add(nud_1);
            Controls.Add(lb_time);
            Controls.Add(button1);
            Controls.Add(btn_smpl_pay);
            Controls.Add(btn_stnd_pay);
            Controls.Add(btn_pay);
            Controls.Add(label4);
            Controls.Add(lb_totcnt);
            Controls.Add(label);
            Controls.Add(lb_price2);
            Controls.Add(lb_price1);
            Controls.Add(lb);
            Controls.Add(grp_seat);
            Name = "booking2";
            Size = new Size(823, 630);
            grp_seat.ResumeLayout(false);
            grp_seat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)naverPay).EndInit();
            ((System.ComponentModel.ISupportInitialize)kakaoPay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grp_seat;
        private Button A1;
        private Button E6;
        private Label label2;
        private Button C6;
        private Label label3;
        private Button D6;
        private Label label8;
        private Button B6;
        private Label label20;
        private Button E5;
        private Label label14;
        private Button A6;
        private Button D5;
        private Label label21;
        private Button C5;
        private Button B5;
        private Button E4;
        private Button A5;
        private Button D4;
        private Button C4;
        private Button B1;
        private Button B4;
        private Label label31;
        private Button A4;
        private Button D1;
        private Label label30;
        private Button C1;
        private Label label19;
        private Label label13;
        private Button E3;
        private Button E1;
        private Label label7;
        private Button D3;
        private Button C3;
        private Label label26;
        private Button B3;
        private Button A2;
        private Label label29;
        private Label label27;
        private Button A3;
        private Button B2;
        private Label label28;
        private Button button8;
        private Label label18;
        private Button D2;
        private Label label12;
        private Label label6;
        private Button E2;
        private Label lb_time;
        private Label lb;
        private Label label4;
        private NumericUpDown nud_1;
        private NumericUpDown nud_2;
        private PictureBox pictureBox1;
        private Button btn_date_4;
        private Button btn_date_3;
        private Button btn_date_2;
        private Button btn_date_1;
        private Label lb_loc;
        private Button btn_pay;
        private Label lb_totPrice;
        private Label label;
        private Label lb_totcnt;
        private Label lb_price1;
        private Label lb_price2;
        private PictureBox naverPay;
        private PictureBox kakaoPay;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label lb_title;
        private Button button1;
        private Button btn_stnd_pay;
        private Button btn_smpl_pay;
    }
}
