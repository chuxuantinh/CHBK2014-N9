namespace CHBK2014_N9.HumanResource.Core.Process
{
    partial class xucAdvanceAdd
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
            this.grInformation = new DevExpress.XtraEditors.GroupControl();
            this.glkEmployeeCode = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEmployeeName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtReason = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboPerson = new DevExpress.XtraEditors.TextEdit();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.calMoney = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grInformation)).BeginInit();
            this.grInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glkEmployeeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calMoney.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 294);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(171, 294);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 294);
            // 
            // grInformation
            // 
            this.grInformation.Controls.Add(this.labelControl6);
            this.grInformation.Controls.Add(this.labelControl5);
            this.grInformation.Controls.Add(this.labelControl4);
            this.grInformation.Controls.Add(this.calMoney);
            this.grInformation.Controls.Add(this.dtDate);
            this.grInformation.Controls.Add(this.cboPerson);
            this.grInformation.Controls.Add(this.labelControl3);
            this.grInformation.Controls.Add(this.txtReason);
            this.grInformation.Controls.Add(this.labelControl2);
            this.grInformation.Controls.Add(this.txtEmployeeName);
            this.grInformation.Controls.Add(this.labelControl1);
            this.grInformation.Controls.Add(this.glkEmployeeCode);
            this.grInformation.Location = new System.Drawing.Point(3, 4);
            this.grInformation.Name = "grInformation";
            this.grInformation.Size = new System.Drawing.Size(449, 266);
            this.grInformation.TabIndex = 38;
            this.grInformation.Text = "Thông tin tạm ứng";
            // 
            // glkEmployeeCode
            // 
            this.glkEmployeeCode.Location = new System.Drawing.Point(173, 45);
            this.glkEmployeeCode.Name = "glkEmployeeCode";
            this.glkEmployeeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glkEmployeeCode.Properties.View = this.gridLookUpEdit1View;
            this.glkEmployeeCode.Size = new System.Drawing.Size(228, 20);
            this.glkEmployeeCode.TabIndex = 0;
            this.glkEmployeeCode.EditValueChanged += new System.EventHandler(this.glkEmployeeCode_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeCode,
            this.colFirstName,
            this.colLastName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn Nhân viên";
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.Caption = "Mã nhân viên";
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Họ";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Tên";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(173, 72);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(228, 20);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Họ tên nhân viên";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(173, 114);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(228, 20);
            this.txtReason.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Lý do tạm ứng";
            // 
            // cboPerson
            // 
            this.cboPerson.Location = new System.Drawing.Point(173, 197);
            this.cboPerson.Name = "cboPerson";
            this.cboPerson.Size = new System.Drawing.Size(228, 20);
            this.cboPerson.TabIndex = 6;
            // 
            // dtDate
            // 
            this.dtDate.EditValue = null;
            this.dtDate.Location = new System.Drawing.Point(173, 141);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Size = new System.Drawing.Size(228, 20);
            this.dtDate.TabIndex = 7;
            // 
            // calMoney
            // 
            this.calMoney.Location = new System.Drawing.Point(173, 168);
            this.calMoney.Name = "calMoney";
            this.calMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calMoney.Size = new System.Drawing.Size(228, 20);
            this.calMoney.TabIndex = 8;

            this.calMoney.Properties.DisplayFormat.FormatString = "\"{0:##,##0}\"";
            this.calMoney.Properties.EditFormat.FormatString = "\"{0:##,##0}\"";
            this.calMoney.Properties.Mask.UseMaskAsDisplayFormat = true;
          
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 175);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Số tiền";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 144);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Ngày tạm ứng";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 204);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Người cho tạm ứng";
            // 
            // xucAdvanceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grInformation);
            this.Name = "xucAdvanceAdd";
            this.Size = new System.Drawing.Size(466, 338);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnSaveNew, 0);
            this.Controls.SetChildIndex(this.grInformation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grInformation)).EndInit();
            this.grInformation.ResumeLayout(false);
            this.grInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glkEmployeeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calMoney.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grInformation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glkEmployeeCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEmployeeName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtReason;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CalcEdit calMoney;
        private DevExpress.XtraEditors.DateEdit dtDate;
        private DevExpress.XtraEditors.TextEdit cboPerson;
    }
}
