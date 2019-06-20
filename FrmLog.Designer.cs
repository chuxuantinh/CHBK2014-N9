namespace CHBK2014_N9
{
    partial class FrmLog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ngày = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Module = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IPLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(728, 262);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.Ngày,
            this.Module,
            this.IPLAN,
            this.PCName,
            this.gridColumn5,
            this.Active});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Ngày
            // 
            this.Ngày.Caption = "Ngày";
            this.Ngày.FieldName = "Created";
            this.Ngày.Name = "Ngày";
            this.Ngày.Visible = true;
            this.Ngày.VisibleIndex = 0;
            // 
            // Module
            // 
            this.Module.Caption = "Module";
            this.Module.FieldName = "Module";
            this.Module.Name = "Module";
            this.Module.Visible = true;
            this.Module.VisibleIndex = 1;
            // 
            // IPLAN
            // 
            this.IPLAN.Caption = "Địa chỉ máy";
            this.IPLAN.FieldName = "IPLan";
            this.IPLAN.Name = "IPLAN";
            this.IPLAN.Visible = true;
            this.IPLAN.VisibleIndex = 2;
            // 
            // PCName
            // 
            this.PCName.Caption = "Tên máy";
            this.PCName.FieldName = "PCName";
            this.PCName.Name = "PCName";
            this.PCName.Visible = true;
            this.PCName.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mô tả";
            this.gridColumn5.FieldName = "Description";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn5.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // Active
            // 
            this.Active.Caption = "Trạng thái";
            this.Active.FieldName = "Active";
            this.Active.Name = "Active";
            this.Active.Visible = true;
            this.Active.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên nhân viên";
            this.gridColumn1.FieldName = "UserName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 262);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmLog";
            this.Text = "FrmLog";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Ngày;
        private DevExpress.XtraGrid.Columns.GridColumn Module;
        private DevExpress.XtraGrid.Columns.GridColumn IPLAN;
        private DevExpress.XtraGrid.Columns.GridColumn PCName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Active;
    }
}