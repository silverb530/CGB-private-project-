namespace CGB
{
    partial class Main_main
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_main));
            pictureBox1 = new PictureBox();
            lb_tagline  = new Label();
            lb_sub      = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // pictureBox1 (center banner)
            pictureBox1.Image    = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(428, 110);
            pictureBox1.Size     = new System.Drawing.Size(424, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // lb_sub (top)
            lb_sub.Text      = "영화는 우리와 함께";
            lb_sub.Font      = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_sub.ForeColor = Theme.TextPrimary;
            lb_sub.BackColor = System.Drawing.Color.Transparent;
            lb_sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_sub.Location  = new System.Drawing.Point(390, 55);
            lb_sub.Size      = new System.Drawing.Size(500, 40);

            // lb_tagline (bottom)
            lb_tagline.Text      = "CGB에 깊이 빠져 들다";
            lb_tagline.Font      = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_tagline.ForeColor = Theme.TextPrimary;
            lb_tagline.BackColor = System.Drawing.Color.Transparent;
            lb_tagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_tagline.Location  = new System.Drawing.Point(350, 530);
            lb_tagline.Size      = new System.Drawing.Size(580, 50);

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Theme.BG;
            Controls.Add(lb_tagline);
            Controls.Add(lb_sub);
            Controls.Add(pictureBox1);
            Name = "Main_main";
            Size = new System.Drawing.Size(1280, 690);

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
        private Label      lb_tagline;
        private Label      lb_sub;
    }
}
