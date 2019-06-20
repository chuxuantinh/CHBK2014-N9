namespace CHBK2014_N9.HumanResource.Report
{
    partial class xfmOptionPrintContract
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colValue = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colValue});
            this.treeList1.Location = new System.Drawing.Point(1, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "Hợp đồng lao động",
            "0"}, -1);
            this.treeList1.AppendNode(new object[] {
            "In hợp đồng lao động cho nhân viên được chọn",
            "5"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Danh sách tất cả hợp đồng lao động của nhân viên",
            "1"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Danh sách hợp đồng lao động sắp hết hạn",
            "2"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Danh sách hợp đồng lao động đang quản lý",
            "6"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Danh sách hợp đồng lao động đã hết hạn",
            "3"}, 0);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(317, 306);
            this.treeList1.Dock = System.Windows.Forms.DockStyle .Fill;
            this.treeList1.TabIndex = 0;
            this.treeList1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Orange;
            this.treeList1.Appearance.FocusedCell.BackColor2 =   System.Drawing.Color .White;
            this.treeList1.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode .BackwardDiagonal;
            this.treeList1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;

            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // colName
            // 
            this.colName.Caption = "Tên báo cáo";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 55;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colValue
            // 
            this.colValue.Caption = "Giá trị";
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(58, 327);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Xem trước";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // xfmOptionPrintContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 362);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.treeList1);
            this.Name = "xfmOptionPrintContract";
            this.Text = "Tùy chọn in";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colValue;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
    }
}