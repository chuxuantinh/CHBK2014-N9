namespace CHBK2014_N9.HumanResource.Core
{
    partial class xucOrganizationBase
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
            this.dManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dLeft = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.xucOrganization1 = new CHBK2014_N9.HumanResource.Core.xucOrganization();
            ((System.ComponentModel.ISupportInitialize)(this.dManager)).BeginInit();
            this.dLeft.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // dManager
            // 
            this.dManager.Form = this;
            this.dManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dLeft});
            this.dManager.TopZIndexControls.AddRange(new string[] {
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
            // dLeft
            // 
            this.dLeft.Controls.Add(this.dockPanel1_Container);
            this.dLeft.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dLeft.ID = new System.Guid("13489ac0-5b8e-42ce-b8c7-3876db6945ee");
            this.dLeft.Location = new System.Drawing.Point(0, 29);
            this.dLeft.Name = "dLeft";
            this.dLeft.OriginalSize = new System.Drawing.Size(270, 200);
            this.dLeft.Size = new System.Drawing.Size(270, 512);
            this.dLeft.Text = "dockPanel1";
            // 
            // controlContainer1
            // 
            this.dockPanel1_Container.Controls.Add(this.xucOrganization1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "controlContainer1";
            this.dockPanel1_Container.Size = new System.Drawing.Size(262, 485);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // xucOrganization1
            // 
            this.xucOrganization1.Location = new System.Drawing.Point(4, 4);
            this.xucOrganization1.Name = "xucOrganization1";
            this.xucOrganization1.Size = new System.Drawing.Size(255, 512);
            this.xucOrganization1.TabIndex = 0;
            // 
            // xucOrganizationBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dLeft);
            this.Name = "xucOrganizationBase";
            this.Size = new System.Drawing.Size(1280, 566);
            this.Controls.SetChildIndex(this.dLeft, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dManager)).EndInit();
            this.dLeft.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dManager;
        private DevExpress.XtraBars.Docking.DockPanel dLeft;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private xucOrganization xucOrganization1;
    }
}
