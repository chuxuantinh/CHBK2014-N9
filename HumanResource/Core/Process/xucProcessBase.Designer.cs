namespace CHBK2014_N9.HumanResource.Core.Process
{
    partial class xucProcessBase
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
            ((System.ComponentModel.ISupportInitialize)(this.repName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTableListSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dManager)).BeginInit();
            this.SuspendLayout();
            // 
            // repName
            // 
            this.repName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repName.Appearance.Options.UseFont = true;
            // 
            // repDateTimeSelect
            // 
            this.repDateTimeSelect.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repDateTimeSelect.Appearance.Options.UseFont = true;
            this.repDateTimeSelect.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.repDateTimeSelect.AppearanceDropDown.Options.UseFont = true;
            // 
            // repMonth
            // 
            this.repMonth.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repMonth.Appearance.Options.UseFont = true;
            this.repMonth.Mask.EditMask = "MM";
            this.repMonth.Mask.UseMaskAsDisplayFormat = true;
            // 
            // repYear
            // 
            this.repYear.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repYear.Appearance.Options.UseFont = true;
            this.repYear.Mask.EditMask = "yyyy";
            this.repYear.Mask.UseMaskAsDisplayFormat = true;
            // 
            // repTableListSelect
            // 
            this.repTableListSelect.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repTableListSelect.Appearance.Options.UseFont = true;
            // 
            // dManager
            // 
            this.dManager.Form = this;
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
            // xucProcessBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucProcessBase";
            this.Size = new System.Drawing.Size(1380, 482);
            ((System.ComponentModel.ISupportInitialize)(this.repName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTimeSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTableListSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dManager;
    }
}
