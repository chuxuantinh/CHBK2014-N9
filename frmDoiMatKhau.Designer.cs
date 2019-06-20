namespace CHBK2014_N9
{
    partial class frmDoiMatKhau
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
            this.txtnhaplai = new DevExpress.XtraEditors.TextEdit();
            this.txtmkmoi = new DevExpress.XtraEditors.TextEdit();
            this.txtmkcu = new DevExpress.XtraEditors.TextEdit();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtnhaplai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkmoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnhaplai
            // 
            this.txtnhaplai.Location = new System.Drawing.Point(114, 66);
            this.txtnhaplai.Name = "txtnhaplai";
            this.txtnhaplai.Properties.MaxLength = 255;
            this.txtnhaplai.Properties.PasswordChar = '*';
            this.txtnhaplai.Size = new System.Drawing.Size(167, 20);
            this.txtnhaplai.TabIndex = 9;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(114, 42);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Properties.MaxLength = 255;
            this.txtmkmoi.Properties.PasswordChar = '*';
            this.txtmkmoi.Size = new System.Drawing.Size(167, 20);
            this.txtmkmoi.TabIndex = 8;
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(114, 8);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Properties.MaxLength = 255;
            this.txtmkcu.Properties.PasswordChar = '*';
            this.txtmkcu.Size = new System.Drawing.Size(167, 20);
            this.txtmkcu.TabIndex = 4;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(114, 91);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(106, 25);
            this.btnDoiMatKhau.TabIndex = 10;
            this.btnDoiMatKhau.Text = "Thực hiện";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nhập lại";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Mật khẩu mới";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Mật khẩu cũ";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 133);
            this.Controls.Add(this.txtnhaplai);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtnhaplai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkmoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtnhaplai;
        private DevExpress.XtraEditors.TextEdit txtmkmoi;
        private DevExpress.XtraEditors.TextEdit txtmkcu;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}