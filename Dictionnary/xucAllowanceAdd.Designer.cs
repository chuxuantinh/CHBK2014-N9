namespace CHBK2014_N9.Dictionnary
{
    partial class xucAllowanceAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucAllowanceAdd));
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.calMaximumSalary = new DevExpress.XtraEditors.CalcEdit();
            this.calIncomeTaxValue = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cheIsByWorkDay = new DevExpress.XtraEditors.CheckEdit();
            this.cheIsShowInSalaryTableList = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calMaximumSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calIncomeTaxValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsByWorkDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsShowInSalaryTableList.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(120, 49);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 23);
            this.txtID.Size = new System.Drawing.Size(222, 20);
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 349);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(148, 349);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 349);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(15, 56);
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.cheIsShowInSalaryTableList);
            this.gcInfo.Controls.Add(this.cheIsByWorkDay);
            this.gcInfo.Controls.Add(this.labelControl3);
            this.gcInfo.Controls.Add(this.labelControl2);
            this.gcInfo.Controls.Add(this.labelControl1);
            this.gcInfo.Controls.Add(this.calIncomeTaxValue);
            this.gcInfo.Controls.Add(this.calMaximumSalary);
            this.gcInfo.Controls.Add(this.txtDescription);
            this.gcInfo.Location = new System.Drawing.Point(3, 3);
            this.gcInfo.Size = new System.Drawing.Size(359, 216);
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.calMaximumSalary, 0);
            this.gcInfo.Controls.SetChildIndex(this.calIncomeTaxValue, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl1, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl2, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl3, 0);
            this.gcInfo.Controls.SetChildIndex(this.cheIsByWorkDay, 0);
            this.gcInfo.Controls.SetChildIndex(this.cheIsShowInSalaryTableList, 0);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Apply_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "Clear_32x32.png");
            this.imageCollection1.Images.SetKeyName(2, "Cancel_32x32.png");
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 128);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(223, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // calMaximumSalary
            // 
            this.calMaximumSalary.Location = new System.Drawing.Point(120, 76);
            this.calMaximumSalary.Name = "calMaximumSalary";
            this.calMaximumSalary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calMaximumSalary.Size = new System.Drawing.Size(222, 20);
            this.calMaximumSalary.TabIndex = 5;
            // 
            // calIncomeTaxValue
            // 
            this.calIncomeTaxValue.Location = new System.Drawing.Point(120, 102);
            this.calIncomeTaxValue.Name = "calIncomeTaxValue";
            this.calIncomeTaxValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calIncomeTaxValue.Size = new System.Drawing.Size(222, 20);
            this.calIncomeTaxValue.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Số tiền chuẩn";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Giảm thuế %";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Ghi chú";
            // 
            // cheIsByWorkDay
            // 
            this.cheIsByWorkDay.Location = new System.Drawing.Point(15, 166);
            this.cheIsByWorkDay.Name = "cheIsByWorkDay";
            this.cheIsByWorkDay.Properties.Caption = "Phụ thuộc ngày công";
            this.cheIsByWorkDay.Size = new System.Drawing.Size(147, 19);
            this.cheIsByWorkDay.TabIndex = 10;
            // 
            // cheIsShowInSalaryTableList
            // 
            this.cheIsShowInSalaryTableList.Location = new System.Drawing.Point(15, 191);
            this.cheIsShowInSalaryTableList.Name = "cheIsShowInSalaryTableList";
            this.cheIsShowInSalaryTableList.Properties.Caption = "Hiển thị giảm trừ thuế cho phụ cấp này trong bảng lương tháng";
            this.cheIsShowInSalaryTableList.Size = new System.Drawing.Size(327, 19);
            this.cheIsShowInSalaryTableList.TabIndex = 11;
            // 
            // xucAllowanceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucAllowanceAdd";
            this.Size = new System.Drawing.Size(400, 390);
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calMaximumSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calIncomeTaxValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsByWorkDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsShowInSalaryTableList.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.CalcEdit calIncomeTaxValue;
        private DevExpress.XtraEditors.CalcEdit calMaximumSalary;
        private DevExpress.XtraEditors.CheckEdit cheIsShowInSalaryTableList;
        private DevExpress.XtraEditors.CheckEdit cheIsByWorkDay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
