namespace CHBK2014_N9.ATT.UI.BaoBieu
{
    partial class frmChonlanxuat
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
            this.radioButton_Xuat2l = new System.Windows.Forms.RadioButton();
            this.radioButton_Xuat4l = new System.Windows.Forms.RadioButton();
            this.radioButton_Xuat6l = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_Xuat2l
            // 
            this.radioButton_Xuat2l.AutoSize = true;
            this.radioButton_Xuat2l.Location = new System.Drawing.Point(53, 55);
            this.radioButton_Xuat2l.Name = "radioButton_Xuat2l";
            this.radioButton_Xuat2l.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Xuat2l.TabIndex = 0;
            this.radioButton_Xuat2l.TabStop = true;
            this.radioButton_Xuat2l.Text = "Xuất 2 lần";
            this.radioButton_Xuat2l.UseVisualStyleBackColor = true;
            // 
            // radioButton_Xuat4l
            // 
            this.radioButton_Xuat4l.AutoSize = true;
            this.radioButton_Xuat4l.Location = new System.Drawing.Point(53, 89);
            this.radioButton_Xuat4l.Name = "radioButton_Xuat4l";
            this.radioButton_Xuat4l.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Xuat4l.TabIndex = 1;
            this.radioButton_Xuat4l.TabStop = true;
            this.radioButton_Xuat4l.Text = "Xuất 4 lần";
            this.radioButton_Xuat4l.UseVisualStyleBackColor = true;
            // 
            // radioButton_Xuat6l
            // 
            this.radioButton_Xuat6l.AutoSize = true;
            this.radioButton_Xuat6l.Location = new System.Drawing.Point(53, 121);
            this.radioButton_Xuat6l.Name = "radioButton_Xuat6l";
            this.radioButton_Xuat6l.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Xuat6l.TabIndex = 2;
            this.radioButton_Xuat6l.TabStop = true;
            this.radioButton_Xuat6l.Text = "Xuất 6 lần";
            this.radioButton_Xuat6l.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChonlanxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_Xuat6l);
            this.Controls.Add(this.radioButton_Xuat4l);
            this.Controls.Add(this.radioButton_Xuat2l);
            this.Name = "frmChonlanxuat";
            this.Text = "Chọn lần xuất";
            this.Load += new System.EventHandler(this.frmChonlanxuat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Xuat2l;
        private System.Windows.Forms.RadioButton radioButton_Xuat4l;
        private System.Windows.Forms.RadioButton radioButton_Xuat6l;
        private System.Windows.Forms.Button button1;
    }
}