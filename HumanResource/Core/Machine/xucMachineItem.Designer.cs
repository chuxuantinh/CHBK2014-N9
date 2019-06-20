namespace CHBK2014_N9.HumanResource.Core.Machine
{
    partial class xucMachineItem
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
            this.ppMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiConnect = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDisConnect = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeleteAllData = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSignUp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProperty = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ptIcon = new DevExpress.XtraEditors.PictureEdit();
            this.lbMachineName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptIcon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ppMenu
            // 
            this.ppMenu.Manager = this.barManager1;
            this.ppMenu.Name = "ppMenu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiConnect,
            this.bbiDisConnect,
            this.bbiDeleteAllData,
            this.bbiSignUp,
            this.bbiProperty});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiConnect),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDisConnect),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDeleteAllData),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSignUp),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiProperty)});
            this.bar1.Text = "Tools";
            // 
            // bbiConnect
            // 
            this.bbiConnect.Caption = "Kết nối";
            this.bbiConnect.Id = 0;
            this.bbiConnect.Name = "bbiConnect";
            this.bbiConnect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConnect_ItemClick);
            // 
            // bbiDisConnect
            // 
            this.bbiDisConnect.Caption = "Ngắt kết nối";
            this.bbiDisConnect.Id = 1;
            this.bbiDisConnect.Name = "bbiDisConnect";
            this.bbiDisConnect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDisConnect_ItemClick);
            // 
            // bbiDeleteAllData
            // 
            this.bbiDeleteAllData.Caption = "Xóa tất cả ";
            this.bbiDeleteAllData.Id = 2;
            this.bbiDeleteAllData.Name = "bbiDeleteAllData";
            this.bbiDeleteAllData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeleteAllData_ItemClick);
            // 
            // bbiSignUp
            // 
            this.bbiSignUp.Caption = "Đăng ký";
            this.bbiSignUp.Id = 3;
            this.bbiSignUp.Name = "bbiSignUp";
            this.bbiSignUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSignUp_ItemClick);
            // 
            // bbiProperty
            // 
            this.bbiProperty.Caption = "Thông tin";
            this.bbiProperty.Id = 4;
            this.bbiProperty.Name = "bbiProperty";
            this.bbiProperty.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiProperty_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(274, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 74);
            this.barDockControlBottom.Size = new System.Drawing.Size(274, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 45);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(274, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 45);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ptIcon);
            this.panelControl1.Controls.Add(this.lbMachineName);
            this.panelControl1.Location = new System.Drawing.Point(3, 35);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(260, 36);
            this.panelControl1.TabIndex = 0;
            // 
            // ptIcon
            // 
            this.ptIcon.EditValue = global::CHBK2014_N9.Properties.Resources.Time_32x32;
            this.ptIcon.Location = new System.Drawing.Point(14, 4);
            this.ptIcon.MenuManager = this.barManager1;
            this.ptIcon.Name = "ptIcon";
            this.ptIcon.Properties.ErrorImage = global::CHBK2014_N9.Properties.Resources.IpsOptInSrv_exe_01_07;
            this.ptIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptIcon.Size = new System.Drawing.Size(25, 24);
            this.ptIcon.TabIndex = 1;
            // 
            // lbMachineName
            // 
            this.lbMachineName.Location = new System.Drawing.Point(51, 9);
            this.lbMachineName.Name = "lbMachineName";
            this.lbMachineName.Size = new System.Drawing.Size(63, 13);
            this.lbMachineName.TabIndex = 0;
            this.lbMachineName.Text = "labelControl1";
            // 
            // xucMachineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "xucMachineItem";
            this.Size = new System.Drawing.Size(274, 74);
            ((System.ComponentModel.ISupportInitialize)(this.ppMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptIcon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu ppMenu;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.BarButtonItem bbiConnect;
        private DevExpress.XtraBars.BarButtonItem bbiDisConnect;
        private DevExpress.XtraBars.BarButtonItem bbiDeleteAllData;
        private DevExpress.XtraBars.BarButtonItem bbiSignUp;
        private DevExpress.XtraBars.BarButtonItem bbiProperty;
        private DevExpress.XtraEditors.LabelControl lbMachineName;
        private DevExpress.XtraEditors.PictureEdit ptIcon;
    }
}
