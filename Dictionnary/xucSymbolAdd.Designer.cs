namespace CHBK2014_N9.Dictionnary
{
    partial class xucSymbolAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucSymbolAdd));
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.calPercentSalary = new DevExpress.XtraEditors.CalcEdit();
            this.cheIsEdit = new DevExpress.XtraEditors.CheckEdit();
            this.cheIsShow = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calPercentSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsShow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(84, 49);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 27);
            this.txtID.Size = new System.Drawing.Size(223, 20);
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 362);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(210, 362);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 362);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(15, 56);
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.labelControl3);
            this.gcInfo.Controls.Add(this.labelControl2);
            this.gcInfo.Controls.Add(this.labelControl1);
            this.gcInfo.Controls.Add(this.cheIsShow);
            this.gcInfo.Controls.Add(this.cheIsEdit);
            this.gcInfo.Controls.Add(this.calPercentSalary);
            this.gcInfo.Controls.Add(this.txtDescription);
            this.gcInfo.Size = new System.Drawing.Size(407, 340);
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.calPercentSalary, 0);
            this.gcInfo.Controls.SetChildIndex(this.cheIsEdit, 0);
            this.gcInfo.Controls.SetChildIndex(this.cheIsShow, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl1, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl2, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl3, 0);
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
            this.txtDescription.Location = new System.Drawing.Point(84, 122);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(223, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // calPercentSalary
            // 
            this.calPercentSalary.Location = new System.Drawing.Point(84, 96);
            this.calPercentSalary.Name = "calPercentSalary";
            this.calPercentSalary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calPercentSalary.Size = new System.Drawing.Size(223, 20);
            this.calPercentSalary.TabIndex = 5;
            // 
            // cheIsEdit
            // 
            this.cheIsEdit.Location = new System.Drawing.Point(84, 149);
            this.cheIsEdit.Name = "cheIsEdit";
            this.cheIsEdit.Properties.Caption = "Được phép chỉnh sửa";
            this.cheIsEdit.Size = new System.Drawing.Size(75, 19);
            this.cheIsEdit.TabIndex = 6;
            // 
            // cheIsShow
            // 
            this.cheIsShow.Location = new System.Drawing.Point(84, 174);
            this.cheIsShow.Name = "cheIsShow";
            this.cheIsShow.Properties.Caption = "Hiển thị kiểu chấm công này";
            this.cheIsShow.Size = new System.Drawing.Size(189, 19);
            this.cheIsShow.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(314, 99);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "% Lương cơ bản";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Trừ lương";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Ghi chú";
            // 
            // xucSymbolAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucSymbolAdd";
            this.Size = new System.Drawing.Size(413, 400);
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calPercentSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsShow.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cheIsEdit;
        private DevExpress.XtraEditors.CalcEdit calPercentSalary;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.CheckEdit cheIsShow;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
