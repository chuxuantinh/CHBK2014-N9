namespace CHBK2014_N9.Dictionnary
{
    partial class xucRate
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
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRateCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupRateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoefficient = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            this.SuspendLayout();
            // 
            // dm
            // 
            this.dm.Form = this;
            this.dm.TopZIndexControls.AddRange(new string[] {
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
            // gcList
            // 
            this.gcList.Location = new System.Drawing.Point(0, 31);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(748, 265);
            this.gcList.TabIndex = 1;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // gbList
            // 
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRateCode,
            this.colRateName,
            this.colActive,
            this.colGroupRateName,
            this.colDescription,
            this.colCoefficient});
            this.gbList.GridControl = this.gcList;
            this.gbList.Name = "gbList";
            // 
            // colRateCode
            // 
            this.colRateCode.Caption = "Mã tiêu chí";
            this.colRateCode.FieldName = "RateCode";
            this.colRateCode.Name = "colRateCode";
            this.colRateCode.Visible = true;
            this.colRateCode.VisibleIndex = 0;
            // 
            // colRateName
            // 
            this.colRateName.Caption = "Tên tiêu chí";
            this.colRateName.FieldName = "RateName";
            this.colRateName.Name = "colRateName";
            this.colRateName.Visible = true;
            this.colRateName.VisibleIndex = 1;
            // 
            // colActive
            // 
            this.colActive.Caption = "Trạng thái";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            // 
            // colGroupRateName
            // 
            this.colGroupRateName.Caption = "colGroupRateName";
            this.colGroupRateName.FieldName = "GroupRateName";
            this.colGroupRateName.Name = "colGroupRateName";
            this.colGroupRateName.Visible = true;
            this.colGroupRateName.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Ghi chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // colCoefficient
            // 
            this.colCoefficient.Caption = "colCoefficient";
            this.colCoefficient.FieldName = "Coefficient";
            this.colCoefficient.Name = "colCoefficient";
            this.colCoefficient.Visible = true;
            this.colCoefficient.VisibleIndex = 5;
            // 
            // xucRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcList);
            this.Name = "xucRate";
            this.Controls.SetChildIndex(this.ucToolBar, 0);
            this.Controls.SetChildIndex(this.gcList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraGrid.Columns.GridColumn colRateCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRateName;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupRateName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCoefficient;
    }
}
