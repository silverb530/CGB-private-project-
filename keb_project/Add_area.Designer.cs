namespace keb_project
{
    partial class Add_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grp_loc = new GroupBox();
            loc4 = new RadioButton();
            loc3 = new RadioButton();
            loc2 = new RadioButton();
            loc1 = new RadioButton();
            btn_select = new Button();
            grp_loc.SuspendLayout();
            SuspendLayout();
            // 
            // grp_loc
            // 
            grp_loc.Controls.Add(loc4);
            grp_loc.Controls.Add(loc3);
            grp_loc.Controls.Add(loc2);
            grp_loc.Controls.Add(loc1);
            grp_loc.Location = new Point(40, 31);
            grp_loc.Name = "grp_loc";
            grp_loc.Size = new Size(533, 239);
            grp_loc.TabIndex = 1;
            grp_loc.TabStop = false;
            // 
            // loc4
            // 
            loc4.AutoSize = true;
            loc4.Location = new Point(199, 169);
            loc4.Name = "loc4";
            loc4.Size = new Size(124, 19);
            loc4.TabIndex = 1;
            loc4.TabStop = true;
            loc4.Text = "천안펜타포트 CGB";
            loc4.UseVisualStyleBackColor = true;
            loc4.CheckedChanged += loc1_CheckedChanged;
            // 
            // loc3
            // 
            loc3.AutoSize = true;
            loc3.Location = new Point(199, 123);
            loc3.Name = "loc3";
            loc3.Size = new Size(88, 19);
            loc3.TabIndex = 1;
            loc3.TabStop = true;
            loc3.Text = "신부동 CGB";
            loc3.UseVisualStyleBackColor = true;
            loc3.CheckedChanged += loc1_CheckedChanged;
            // 
            // loc2
            // 
            loc2.AutoSize = true;
            loc2.Location = new Point(199, 82);
            loc2.Name = "loc2";
            loc2.Size = new Size(88, 19);
            loc2.TabIndex = 1;
            loc2.TabStop = true;
            loc2.Text = "천안역 CGB";
            loc2.UseVisualStyleBackColor = true;
            loc2.CheckedChanged += loc1_CheckedChanged;
            // 
            // loc1
            // 
            loc1.AutoSize = true;
            loc1.Location = new Point(199, 40);
            loc1.Name = "loc1";
            loc1.Size = new Size(76, 19);
            loc1.TabIndex = 1;
            loc1.TabStop = true;
            loc1.Text = "아산 CGB";
            loc1.UseVisualStyleBackColor = true;
            loc1.CheckedChanged += loc1_CheckedChanged;
            // 
            // btn_select
            // 
            btn_select.Location = new Point(239, 286);
            btn_select.Name = "btn_select";
            btn_select.Size = new Size(120, 33);
            btn_select.TabIndex = 2;
            btn_select.Text = "선택";
            btn_select.UseVisualStyleBackColor = true;
            btn_select.Click += btn_select_Click;
            // 
            // Add_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 341);
            Controls.Add(btn_select);
            Controls.Add(grp_loc);
            Name = "Add_";
            Text = "Add_area";
            grp_loc.ResumeLayout(false);
            grp_loc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_loc;
        private RadioButton loc4;
        private RadioButton loc3;
        private RadioButton loc2;
        private RadioButton loc1;
        private Button btn_select;
    }
}