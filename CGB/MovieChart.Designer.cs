namespace CGB
{
    partial class MovieChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieChart));
            txt_info = new TextBox();
            img_poster1 = new PictureBox();
            lb_title = new Label();
            btn_booking_1 = new Button();
            img_poster2 = new PictureBox();
            img_poster3 = new PictureBox();
            img_poster4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img_poster1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_poster2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_poster3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_poster4).BeginInit();
            SuspendLayout();
            // 
            // txt_info
            // 
            txt_info.Location = new Point(15, 457);
            txt_info.Multiline = true;
            txt_info.Name = "txt_info";
            txt_info.Size = new Size(1234, 243);
            txt_info.TabIndex = 14;
            txt_info.Text = resources.GetString("txt_info.Text");
            // 
            // img_poster1
            // 
            img_poster1.Cursor = Cursors.Hand;
            img_poster1.Image = (Image)resources.GetObject("img_poster1.Image");
            img_poster1.Location = new Point(15, 34);
            img_poster1.Name = "img_poster1";
            img_poster1.Size = new Size(286, 363);
            img_poster1.SizeMode = PictureBoxSizeMode.StretchImage;
            img_poster1.TabIndex = 8;
            img_poster1.TabStop = false;
            img_poster1.Tag = "p1";
            img_poster1.Click += poster_click;
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_title.Location = new Point(15, 418);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(126, 25);
            lb_title.TabIndex = 12;
            lb_title.Text = "왕과사는남자";
            // 
            // btn_booking_1
            // 
            btn_booking_1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_booking_1.Location = new Point(598, 725);
            btn_booking_1.Name = "btn_booking_1";
            btn_booking_1.Size = new Size(105, 46);
            btn_booking_1.TabIndex = 13;
            btn_booking_1.Tag = "왕사남";
            btn_booking_1.Text = "예매하기";
            btn_booking_1.UseVisualStyleBackColor = true;
            btn_booking_1.Visible = false;
            btn_booking_1.Click += btn_booking_1_Click;
            // 
            // img_poster2
            // 
            img_poster2.Cursor = Cursors.Hand;
            img_poster2.Image = (Image)resources.GetObject("img_poster2.Image");
            img_poster2.Location = new Point(319, 34);
            img_poster2.Name = "img_poster2";
            img_poster2.Size = new Size(303, 363);
            img_poster2.SizeMode = PictureBoxSizeMode.StretchImage;
            img_poster2.TabIndex = 9;
            img_poster2.TabStop = false;
            img_poster2.Tag = "p2";
            img_poster2.Click += poster_click;
            // 
            // img_poster3
            // 
            img_poster3.Cursor = Cursors.Hand;
            img_poster3.Image = (Image)resources.GetObject("img_poster3.Image");
            img_poster3.Location = new Point(965, 34);
            img_poster3.Name = "img_poster3";
            img_poster3.Size = new Size(298, 363);
            img_poster3.SizeMode = PictureBoxSizeMode.StretchImage;
            img_poster3.TabIndex = 10;
            img_poster3.TabStop = false;
            img_poster3.Tag = "p4";
            img_poster3.Click += poster_click;
            // 
            // img_poster4
            // 
            img_poster4.Cursor = Cursors.Hand;
            img_poster4.Image = (Image)resources.GetObject("img_poster4.Image");
            img_poster4.Location = new Point(646, 34);
            img_poster4.Name = "img_poster4";
            img_poster4.Size = new Size(291, 363);
            img_poster4.SizeMode = PictureBoxSizeMode.StretchImage;
            img_poster4.TabIndex = 11;
            img_poster4.TabStop = false;
            img_poster4.Tag = "p3";
            img_poster4.Click += poster_click;
            // 
            // MovieChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_info);
            Controls.Add(img_poster1);
            Controls.Add(lb_title);
            Controls.Add(btn_booking_1);
            Controls.Add(img_poster2);
            Controls.Add(img_poster3);
            Controls.Add(img_poster4);
            Name = "MovieChart";
            Size = new Size(1279, 798);
            ((System.ComponentModel.ISupportInitialize)img_poster1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_poster2).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_poster3).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_poster4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_info;
        private PictureBox img_poster1;
        private Label lb_title;
        private Button btn_booking_1;
        private PictureBox img_poster2;
        private PictureBox img_poster3;
        private PictureBox img_poster4;
    }
}
