namespace CHBK2014_N9.HumanResource.Core
{
    partial class xfmSalaryTableListImport
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
            this.rgOption = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.rgOption.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSubTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblSubTitle.Location = new System.Drawing.Point(7, 29);
            this.lblSubTitle.Size = new System.Drawing.Size(280, 13);
            this.lblSubTitle.Text = "Chọn 1 trong những loại dữ liệu sau để nạp vào phần mềm";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTitle.Size = new System.Drawing.Size(215, 23);
            this.lblTitle.Text = "Chọn loại dữ liệu cần nạp";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(7, 306);
            this.panel2.Size = new System.Drawing.Size(497, 246);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 358);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(211, 317);
            this.btBack.Visible = false;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(400, 316);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(299, 316);
            // 
            // rgOption
            // 
            this.rgOption.EditValue = 0;
            this.rgOption.Location = new System.Drawing.Point(11, 58);
            this.rgOption.Name = "rgOption";
            this.rgOption.Properties.Appearance.Options.UseTextOptions = true;
            this.rgOption.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.rgOption.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgOption.Properties.Columns = 1;
            this.rgOption.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Thanh Toán Lương"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ghi Nợ Lương"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Phụ Cấp Lương"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tạm Ứng Lương"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Công Tác Phí"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Các Khoản Thu Nhập Khác (Tính Vào Bảng Lương Tháng)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Các Khoản Thu Nhập Khác (Không Tính Vào Bảng Lương Tháng)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Các Khoản Khấu Trừ Khác")});
            this.rgOption.Size = new System.Drawing.Size(478, 246);
            this.rgOption.TabIndex = 0;
            // 
            // xfmSalaryTableListImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 351);
            this.Controls.Add(this.rgOption);
            this.Name = "xfmSalaryTableListImport";
            this.Text = "Nạp lại dữ liệu";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.lblSubTitle, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btBack, 0);
            this.Controls.SetChildIndex(this.btClose, 0);
            this.Controls.SetChildIndex(this.btNext, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.rgOption, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rgOption.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rgOption;
    }
}