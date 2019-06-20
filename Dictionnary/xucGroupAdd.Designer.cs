namespace CHBK2014_N9.Dictionnary
{
    partial class xucGroupAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucGroupAdd));
            this.txtQuantity = new DevExpress.XtraEditors.CalcEdit();
            this.txtFactQuantity = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.glkBranch = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glkSubsidiary = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glkDepartment = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkSubsidiary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(14, 30);
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(109, 50);
            this.txtNAME.Size = new System.Drawing.Size(265, 20);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 23);
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 410);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(210, 410);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 410);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(14, 56);
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.labelControl5);
            this.gcInfo.Controls.Add(this.txtDescription);
            this.gcInfo.Controls.Add(this.labelControl4);
            this.gcInfo.Controls.Add(this.labelControl3);
            this.gcInfo.Controls.Add(this.glkDepartment);
            this.gcInfo.Controls.Add(this.glkSubsidiary);
            this.gcInfo.Controls.Add(this.glkBranch);
            this.gcInfo.Controls.Add(this.labelControl2);
            this.gcInfo.Controls.Add(this.labelControl1);
            this.gcInfo.Controls.Add(this.txtFactQuantity);
            this.gcInfo.Controls.Add(this.txtQuantity);
            this.gcInfo.Size = new System.Drawing.Size(383, 374);
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtQuantity, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtFactQuantity, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl1, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl2, 0);
            this.gcInfo.Controls.SetChildIndex(this.glkBranch, 0);
            this.gcInfo.Controls.SetChildIndex(this.glkSubsidiary, 0);
            this.gcInfo.Controls.SetChildIndex(this.glkDepartment, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl3, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl4, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl5, 0);
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
            this.txtQuantity.Location = new System.Drawing.Point(275, 24);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantity.Size = new System.Drawing.Size(45, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtFactQuantity
            // 
            this.txtFactQuantity.Location = new System.Drawing.Point(326, 24);
            this.txtFactQuantity.Name = "txtFactQuantity";
            this.txtFactQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFactQuantity.Size = new System.Drawing.Size(50, 20);
            this.txtFactQuantity.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(211, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Số lượng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Thuộc chi nhánh";
            // 
            // glkBranch
            // 
            this.glkBranch.Location = new System.Drawing.Point(109, 81);
            this.glkBranch.Name = "glkBranch";
            this.glkBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.glkBranch.Properties.View = this.gridLookUpEdit1View;
            this.glkBranch.Size = new System.Drawing.Size(265, 20);
            this.glkBranch.TabIndex = 8;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // glkSubsidiary
            // 
            this.glkSubsidiary.Location = new System.Drawing.Point(109, 106);
            this.glkSubsidiary.Name = "glkSubsidiary";
            this.glkSubsidiary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.glkSubsidiary.Properties.View = this.gridView1;
            this.glkSubsidiary.Size = new System.Drawing.Size(265, 20);
            this.glkSubsidiary.TabIndex = 9;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // glkDepartment
            // 
            this.glkDepartment.Location = new System.Drawing.Point(109, 129);
            this.glkDepartment.Name = "glkDepartment";
            this.glkDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.glkDepartment.Properties.View = this.gridView2;
            this.glkDepartment.Size = new System.Drawing.Size(265, 20);
            this.glkDepartment.TabIndex = 10;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Thuộc phòng ban";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Thuộc chi nhánh";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 155);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(263, 96);
            this.txtDescription.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 203);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Ghi chú";
            // 
            // xucGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucGroupAdd";
            this.Size = new System.Drawing.Size(413, 448);
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkSubsidiary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit txtFactQuantity;
        private DevExpress.XtraEditors.CalcEdit txtQuantity;
        private DevExpress.XtraEditors.GridLookUpEdit glkBranch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit glkDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit glkSubsidiary;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}
