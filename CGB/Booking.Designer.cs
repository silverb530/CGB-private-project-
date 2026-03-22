namespace CGB
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            img_poster1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img_poster1).BeginInit();
            SuspendLayout();
            // 
            // img_poster1
            // 
            img_poster1.Cursor = Cursors.Hand;
            img_poster1.Image = (Image)resources.GetObject("img_poster1.Image");
            img_poster1.Location = new Point(569, 46);
            img_poster1.Name = "img_poster1";
            img_poster1.Size = new Size(277, 388);
            img_poster1.SizeMode = PictureBoxSizeMode.StretchImage;
            img_poster1.TabIndex = 1;
            img_poster1.TabStop = false;
            img_poster1.Tag = "";
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(img_poster1);
            Name = "Booking";
            Size = new Size(1426, 752);
            ((System.ComponentModel.ISupportInitialize)img_poster1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox img_poster1;
    }
}
