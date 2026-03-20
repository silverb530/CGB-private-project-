namespace keb_project
{
    partial class booking_Check
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lb_title = new Label();
            lb_seat = new Label();
            lb_date = new Label();
            lb_time = new Label();
            lb_room = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 240);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "제목";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 269);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "좌석";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 304);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "날짜";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 333);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "시간";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 366);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 0;
            label5.Text = "상영관";
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Location = new Point(401, 240);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(31, 15);
            lb_title.TabIndex = 0;
            lb_title.Text = "제목";
            // 
            // lb_seat
            // 
            lb_seat.AutoSize = true;
            lb_seat.Location = new Point(401, 269);
            lb_seat.Name = "lb_seat";
            lb_seat.Size = new Size(31, 15);
            lb_seat.TabIndex = 0;
            lb_seat.Text = "좌석";
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Location = new Point(401, 304);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(31, 15);
            lb_date.TabIndex = 0;
            lb_date.Text = "날짜";
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.Location = new Point(401, 333);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(31, 15);
            lb_time.TabIndex = 0;
            lb_time.Text = "시간";
            // 
            // lb_room
            // 
            lb_room.AutoSize = true;
            lb_room.Location = new Point(401, 366);
            lb_room.Name = "lb_room";
            lb_room.Size = new Size(43, 15);
            lb_room.TabIndex = 0;
            lb_room.Text = "상영관";
            // 
            // booking_Check
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_room);
            Controls.Add(label5);
            Controls.Add(lb_time);
            Controls.Add(label4);
            Controls.Add(lb_date);
            Controls.Add(label3);
            Controls.Add(lb_seat);
            Controls.Add(label2);
            Controls.Add(lb_title);
            Controls.Add(label1);
            Name = "booking_Check";
            Size = new Size(823, 630);
            Load += booking_Check_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lb_title;
        private Label lb_seat;
        private Label lb_date;
        private Label lb_time;
        private Label lb_room;
    }
}
