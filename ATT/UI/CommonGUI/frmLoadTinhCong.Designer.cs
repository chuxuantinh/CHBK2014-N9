namespace CHBK2014_N9.ATT.UI.CommonGUI
{
    partial class frmLoadTinhCong
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
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbDangTinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Location = new System.Drawing.Point(128, 62);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(35, 13);
            this.lbTenNhanVien.TabIndex = 0;
            this.lbTenNhanVien.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(398, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // lbDangTinh
            // 
            this.lbDangTinh.AutoSize = true;
            this.lbDangTinh.Location = new System.Drawing.Point(131, 94);
            this.lbDangTinh.Name = "lbDangTinh";
            this.lbDangTinh.Size = new System.Drawing.Size(35, 13);
            this.lbDangTinh.TabIndex = 2;
            this.lbDangTinh.Text = "label1";
            // 
            // frmLoadTinhCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.lbDangTinh);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbTenNhanVien);
            this.Name = "frmLoadTinhCong";
            this.Text = "frmLoadTinhCong";
            this.Load += new System.EventHandler(this.frmLoadTinhCong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbTenNhanVien;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label lbDangTinh;
    }
}