namespace CHBK2014_N9.HumanResource.Core
{
    partial class xfmShiftOption
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
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.lcDescription = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btCreate = new DevExpress.XtraEditors.SimpleButton();
            this.lbTimeKeeperShiftList = new DevExpress.XtraEditors.ImageListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTimeKeeperShiftList)).BeginInit();
            this.SuspendLayout();
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(7, 56);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tạo mới bảng xếp ca, bảng chấm công"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Dựa theo các bảng xếp ca, bảng chấm công ở phía dưới")});
            this.radioGroup1.Size = new System.Drawing.Size(525, 76);
            this.radioGroup1.TabIndex = 0;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // lcDescription
            // 
            this.lcDescription.Location = new System.Drawing.Point(7, 13);
            this.lcDescription.Name = "lcDescription";
            this.lcDescription.Size = new System.Drawing.Size(171, 13);
            this.lcDescription.TabIndex = 1;
            this.lcDescription.Text = "Lựa chọn một trong 2 tùy chọn trên";
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(7, 424);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Phát sinh theo ngày trong tháng";
            this.checkEdit1.Size = new System.Drawing.Size(226, 19);
            this.checkEdit1.TabIndex = 2;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(376, 427);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 20;
            this.btCancel.Text = "Thoát";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(255, 427);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 19;
            this.btCreate.Text = "Chọn";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lbTimeKeeperShiftList
            // 
            this.lbTimeKeeperShiftList.Location = new System.Drawing.Point(7, 138);
            this.lbTimeKeeperShiftList.Name = "lbTimeKeeperShiftList";
            this.lbTimeKeeperShiftList.Size = new System.Drawing.Size(525, 195);
            this.lbTimeKeeperShiftList.TabIndex = 21;
            // 
            // xfmShiftOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 474);
            this.Controls.Add(this.lbTimeKeeperShiftList);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.lcDescription);
            this.Controls.Add(this.radioGroup1);
            this.Name = "xfmShiftOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn tạo bảng xếp ca, bảng chấm công cho tháng mới";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfmShiftOption_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTimeKeeperShiftList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl lcDescription;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btCreate;
        private DevExpress.XtraEditors.ImageListBoxControl lbTimeKeeperShiftList;
    }
}