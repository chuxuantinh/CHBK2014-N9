namespace CHBK2014_N9
{
    partial class frmChamCong_XepCa_ThemMoi
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
            this.gridItem = new DevExpress.XtraGrid.GridControl();
            this.gridItemDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTimeKeeperTableListName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeKeeperTableListID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.radioBXC = new DevExpress.XtraEditors.RadioGroup();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioBXC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridItem
            // 
            this.gridItem.Location = new System.Drawing.Point(98, 69);
            this.gridItem.MainView = this.gridItemDetail;
            this.gridItem.Name = "gridItem";
            this.gridItem.Size = new System.Drawing.Size(257, 195);
            this.gridItem.TabIndex = 4;
            this.gridItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridItemDetail});
            // 
            // gridItemDetail
            // 
            this.gridItemDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTimeKeeperTableListName,
            this.colTimeKeeperTableListID});
            this.gridItemDetail.GridControl = this.gridItem;
            this.gridItemDetail.IndicatorWidth = 20;
            this.gridItemDetail.Name = "gridItemDetail";
            this.gridItemDetail.OptionsBehavior.Editable = false;
            this.gridItemDetail.OptionsSelection.InvertSelection = true;
            this.gridItemDetail.OptionsView.ShowGroupPanel = false;
            this.gridItemDetail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridItemDetail_CustomDrawRowIndicator);
            // 
            // colTimeKeeperTableListName
            // 
            this.colTimeKeeperTableListName.Caption = "Danh sách Xếp ca";
            this.colTimeKeeperTableListName.FieldName = "TimeKeeperTableListName";
            this.colTimeKeeperTableListName.Name = "colTimeKeeperTableListName";
            this.colTimeKeeperTableListName.Visible = true;
            this.colTimeKeeperTableListName.VisibleIndex = 0;
            // 
            // colTimeKeeperTableListID
            // 
            this.colTimeKeeperTableListID.Caption = "TimeKeeperTableListID";
            this.colTimeKeeperTableListID.FieldName = "TimeKeeperTableListID";
            this.colTimeKeeperTableListID.Name = "colTimeKeeperTableListID";
            // 
            // radioBXC
            // 
            this.radioBXC.Location = new System.Drawing.Point(98, 7);
            this.radioBXC.Name = "radioBXC";
            this.radioBXC.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioBXC.Properties.Appearance.Options.UseBackColor = true;
            this.radioBXC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioBXC.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tạo mới"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tạo từ danh sách đã có")});
            this.radioBXC.Size = new System.Drawing.Size(223, 62);
            this.radioBXC.TabIndex = 3;
            this.radioBXC.SelectedIndexChanged += new System.EventHandler(this.radioBXC_SelectedIndexChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(173, 270);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(106, 36);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // frmChamCong_XepCa_ThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 313);
            this.Controls.Add(this.gridItem);
            this.Controls.Add(this.radioBXC);
            this.Controls.Add(this.btnThucHien);
            this.Name = "frmChamCong_XepCa_ThemMoi";
            this.Text = "Thêm mới bảng xếp ca tháng";
            this.Load += new System.EventHandler(this.frmChamCong_XepCa_ThemMoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioBXC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridItemDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeKeeperTableListName;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeKeeperTableListID;
        private DevExpress.XtraEditors.RadioGroup radioBXC;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
    }
}