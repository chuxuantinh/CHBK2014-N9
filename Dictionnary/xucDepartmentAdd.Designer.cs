namespace CHBK2014_N9.Dictionnary
{
    partial class xucDepartmentAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucDepartmentAdd));
            this.txtQuantity = new DevExpress.XtraEditors.CalcEdit();
            this.txtFactQuantity = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.glkSubsidiary = new DevExpress.XtraEditors.GridLookUpEdit();
            this.Gridview1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glkBranch = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubsidiaryName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkSubsidiary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(72, 56);
            this.txtNAME.Size = new System.Drawing.Size(309, 20);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(72, 23);
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 364);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(196, 364);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 364);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(15, 59);
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.labelControl3);
            this.gcInfo.Controls.Add(this.labelControl2);
            this.gcInfo.Controls.Add(this.glkBranch);
            this.gcInfo.Controls.Add(this.glkSubsidiary);
            this.gcInfo.Controls.Add(this.txtDescription);
            this.gcInfo.Controls.Add(this.txtPhone);
            this.gcInfo.Controls.Add(this.labelControl1);
            this.gcInfo.Controls.Add(this.txtFactQuantity);
            this.gcInfo.Controls.Add(this.txtQuantity);
            this.gcInfo.Size = new System.Drawing.Size(458, 298);
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtQuantity, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtFactQuantity, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl1, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtPhone, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.glkSubsidiary, 0);
            this.gcInfo.Controls.SetChildIndex(this.glkBranch, 0);
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
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(286, 22);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantity.Size = new System.Drawing.Size(36, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtFactQuantity
            // 
            this.txtFactQuantity.Location = new System.Drawing.Point(341, 22);
            this.txtFactQuantity.Name = "txtFactQuantity";
            this.txtFactQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFactQuantity.Size = new System.Drawing.Size(40, 20);
            this.txtFactQuantity.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(171, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Số lượng";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(72, 142);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(309, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(72, 179);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(309, 96);
            this.txtDescription.TabIndex = 8;
            // 
            // glkSubsidiary
            // 
            this.glkSubsidiary.Location = new System.Drawing.Point(72, 83);
            this.glkSubsidiary.Name = "glkSubsidiary";
            this.glkSubsidiary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.glkSubsidiary.Properties.View = this.Gridview1;
            this.glkSubsidiary.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.glk_ButtonClick);
            this.glkSubsidiary.Size = new System.Drawing.Size(309, 20);
            this.glkSubsidiary.TabIndex = 9;
            // 
            // Gridview1
            // 
            this.Gridview1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.Gridview1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.Gridview1.Name = "Gridview1";
            this.Gridview1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.Gridview1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã";
            this.gridColumn5.FieldName = "SubsidiaryCode";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên";
            this.gridColumn6.FieldName = "SubsidiaryName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // glkBranch
            // 
            this.glkBranch.Location = new System.Drawing.Point(72, 115);
            this.glkBranch.Name = "glkBranch";
            this.glkBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.glkBranch.Properties.View = this.gridLookUpEdit1View;
            this.glkBranch.Size = new System.Drawing.Size(309, 20);
            this.glkBranch.TabIndex = 10;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.colSubsidiaryName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Công ty";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Chi nhánh";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã chi nhánh";
            this.gridColumn3.FieldName = "BranchCode";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 60;
            this.gridColumn4.Caption = "Tên chi nhánh";
            this.gridColumn4.FieldName = "BranchName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 160;
            this.colSubsidiaryName.Caption = "Công ty con";
            this.colSubsidiaryName.FieldName = "SubsidiaryName";
            this.colSubsidiaryName.Name = "colSubsidiaryName";
            this.colSubsidiaryName.Visible = true;
            this.colSubsidiaryName.VisibleIndex = 2;
            this.colSubsidiaryName.Width = 161;
            // 
            // xucDepartmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucDepartmentAdd";
            this.Size = new System.Drawing.Size(476, 443);
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkSubsidiary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit txtFactQuantity;
        private DevExpress.XtraEditors.CalcEdit txtQuantity;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.GridLookUpEdit glkBranch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit glkSubsidiary;
        private DevExpress.XtraGrid.Views.Grid.GridView Gridview1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colSubsidiaryName;
    }
}
