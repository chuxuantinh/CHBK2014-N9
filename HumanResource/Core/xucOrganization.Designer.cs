namespace CHBK2014_N9.HumanResource.Core
{
    partial class xucOrganization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucOrganization));
            this.imgTree = new DevExpress.Utils.ImageCollection(this.components);
            this.ppCompany = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.bbiBranchAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBranchEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ppBranch = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ppGroup = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ppEmployee = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ppSubsidiary = new DevExpress.XtraBars.PopupMenu(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colTitle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppSubsidiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.Images.SetKeyName(0, "imageres_dll_205_16.png");
            this.imgTree.Images.SetKeyName(1, "networkexplorer_dll_21_10.png");
            this.imgTree.Images.SetKeyName(2, "NAPSTAT_EXE_01_10.png");
            this.imgTree.Images.SetKeyName(3, "DDORes_dll_13_10.png");
            // 
            // ppCompany
            // 
            this.ppCompany.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9)});
            this.ppCompany.Manager = this.barManager1;
            this.ppCompany.Name = "ppCompany";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thêm công ty con";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thêm chi nhánh";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thêm phòng ban";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thêm tổ nhóm";
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "In ";
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Xuất";
            this.barButtonItem8.Id = 10;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Nạp lại";
            this.barButtonItem9.Id = 11;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiBranchAdd,
            this.bbiBranchEdit,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10});
            this.barManager1.MaxItemId = 13;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(282, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 512);
            this.barDockControl2.Size = new System.Drawing.Size(282, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Size = new System.Drawing.Size(0, 512);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(282, 0);
            this.barDockControl4.Size = new System.Drawing.Size(0, 512);
            // 
            // bbiBranchAdd
            // 
            this.bbiBranchAdd.Caption = "Thêm Chi nhánh";
            this.bbiBranchAdd.Id = 3;
            this.bbiBranchAdd.ImageIndex = 69;
            this.bbiBranchAdd.Name = "bbiBranchAdd";
            // 
            // bbiBranchEdit
            // 
            this.bbiBranchEdit.Caption = "Sửa chi nhánh";
            this.bbiBranchEdit.Id = 4;
            this.bbiBranchEdit.ImageIndex = 14;
            this.bbiBranchEdit.Name = "bbiBranchEdit";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 12;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // ppBranch
            // 
            this.ppBranch.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiBranchAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiBranchEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10)});
            this.ppBranch.Manager = this.barManager1;
            this.ppBranch.Name = "ppBranch";
            // 
            // ppGroup
            // 
            this.ppGroup.Manager = this.barManager1;
            this.ppGroup.Name = "ppGroup";
            // 
            // ppEmployee
            // 
            this.ppEmployee.Manager = this.barManager1;
            this.ppEmployee.Name = "ppEmployee";
            // 
            // ppSubsidiary
            // 
            this.ppSubsidiary.Manager = this.barManager1;
            this.ppSubsidiary.Name = "ppSubsidiary";
            // 
            // treeList1
            // 
            this.treeList1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Orange;
            this.treeList1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.White;
            this.treeList1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTitle});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "AA"}, -1);
            this.treeList1.AppendNode(new object[] {
            null}, 0, 1, 1, -1);
            this.treeList1.AppendNode(new object[] {
            null}, 1, 2, 2, -1);
            this.treeList1.AppendNode(new object[] {
            null}, 2, 3, 3, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.SelectImageList = this.imgTree;
            this.treeList1.Size = new System.Drawing.Size(282, 512);
            this.treeList1.TabIndex = 1;
            this.treeList1.GetSelectImage += new DevExpress.XtraTreeList.GetSelectImageEventHandler(this.treeList1_GetSelectImage_1);
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged_1);
            this.treeList1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.treeList1_HelpRequested);
            this.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Cơ cấu tổ chức";
            this.colTitle.FieldName = "Name";
            this.colTitle.MinWidth = 105;
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            this.colTitle.Width = 110;
            // 
            // xucOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "xucOrganization";
            this.Size = new System.Drawing.Size(282, 512);
            this.Load += new System.EventHandler(this.xucOrganization_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.imgTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppSubsidiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection imgTree;
        private DevExpress.XtraBars.PopupMenu ppCompany;
        private DevExpress.XtraBars.PopupMenu ppBranch;
        private DevExpress.XtraBars.PopupMenu ppGroup;
        private DevExpress.XtraBars.PopupMenu ppEmployee;
        private DevExpress.XtraBars.PopupMenu ppSubsidiary;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTitle;
        private DevExpress.XtraBars.BarButtonItem bbiBranchAdd;
        private DevExpress.XtraBars.BarButtonItem bbiBranchEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
    }
}
