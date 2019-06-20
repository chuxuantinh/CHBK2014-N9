namespace CHBK2014_N9.HumanResource.Core
{
    partial class xfmInsertSymbol
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
            this.glkSymbol = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btCreate = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.calToRow = new DevExpress.XtraEditors.CalcEdit();
            this.calFromRow = new DevExpress.XtraEditors.CalcEdit();
            this.cheAll = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teToDate = new DevExpress.XtraEditors.TimeEdit();
            this.teFromDate = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colSymbolCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSymbolName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.glkSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calToRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFromRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAll.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // glkSymbol
            // 
            this.glkSymbol.EditValue = "[Chọn ký hiệu chấm công]";
            this.glkSymbol.Location = new System.Drawing.Point(331, 68);
            this.glkSymbol.Name = "glkSymbol";
            this.glkSymbol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glkSymbol.Properties.View = this.gridLookUpEdit1View;
            this.glkSymbol.Size = new System.Drawing.Size(205, 20);
            this.glkSymbol.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSymbolCode,
            this.colSymbolName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btCreate);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.glkSymbol);
            this.groupBox1.Location = new System.Drawing.Point(0, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chèn nhanh ký hiệu chấm công";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(295, 291);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "&Thoát";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(178, 291);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 5;
            this.btCreate.Text = "Đồng ý";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelControl6);
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.calToRow);
            this.groupBox3.Controls.Add(this.calFromRow);
            this.groupBox3.Controls.Add(this.cheAll);
            this.groupBox3.Location = new System.Drawing.Point(295, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 151);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn dòng";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 89);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Đến dòng";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Từ dòng";
            // 
            // calToRow
            // 
            this.calToRow.Location = new System.Drawing.Point(132, 86);
            this.calToRow.Name = "calToRow";
            this.calToRow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calToRow.Size = new System.Drawing.Size(100, 20);
            this.calToRow.TabIndex = 2;
            // 
            // calFromRow
            // 
            this.calFromRow.Location = new System.Drawing.Point(132, 48);
            this.calFromRow.Name = "calFromRow";
            this.calFromRow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFromRow.Size = new System.Drawing.Size(100, 20);
            this.calFromRow.TabIndex = 1;
            // 
            // cheAll
            // 
            this.cheAll.Location = new System.Drawing.Point(10, 24);
            this.cheAll.Name = "cheAll";
            this.cheAll.Properties.Caption = "Tất cả các dòng";
            this.cheAll.Size = new System.Drawing.Size(108, 19);
            this.cheAll.TabIndex = 0;
            this.cheAll.CheckedChanged += new System.EventHandler(this.cheAll_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.teToDate);
            this.groupBox2.Controls.Add(this.teFromDate);
            this.groupBox2.Location = new System.Drawing.Point(22, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn ngày";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Đến ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Từ ngày";
            // 
            // teToDate
            // 
            this.teToDate.EditValue = new System.DateTime(2018, 8, 30, 0, 0, 0, 0);
            this.teToDate.Location = new System.Drawing.Point(80, 83);
            this.teToDate.Name = "teToDate";
            this.teToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teToDate.Properties.Mask.EditMask = "dd";
            this.teToDate.Size = new System.Drawing.Size(100, 20);
            this.teToDate.TabIndex = 1;
            // 
            // teFromDate
            // 
            this.teFromDate.EditValue = new System.DateTime(2018, 8, 30, 0, 0, 0, 0);
            this.teFromDate.Location = new System.Drawing.Point(80, 45);
            this.teFromDate.Name = "teFromDate";
            this.teFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teFromDate.Properties.Mask.EditMask = "dd";
            this.teFromDate.Size = new System.Drawing.Size(100, 20);
            this.teFromDate.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(381, 26);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Chọn ký hiệu chấm công từ ô phía bên dưới, sau đó chọn phát sinh từ ngày nào\r\n đế" +
    "n ngày nào và từ dòng nào đến dòng nào trong lưới danh sách.";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(149, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn ký hiệu chấm công";
            // 
            // colSymbolCode
            // 
            this.colSymbolCode.Caption = "Mã ký hiệu";
            this.colSymbolCode.FieldName = "SymbolCode";
            this.colSymbolCode.Name = "colSymbolCode";
            this.colSymbolCode.Visible = true;
            this.colSymbolCode.VisibleIndex = 1;
            // 
            // colSymbolName
            // 
            this.colSymbolName.Caption = "Tên ký hiệu chấm công";
            this.colSymbolName.FieldName = "SymbolName";
            this.colSymbolName.Name = "colSymbolName";
            this.colSymbolName.Visible = true;
            this.colSymbolName.VisibleIndex = 0;
            // 
            // xfmInsertSymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 399);
            this.Controls.Add(this.groupBox1);
            this.Name = "xfmInsertSymbol";
            this.Text = "Chèn nhanh ký hiệu chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.glkSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calToRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFromRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAll.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFromDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit glkSymbol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btCreate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TimeEdit teToDate;
        private DevExpress.XtraEditors.TimeEdit teFromDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CalcEdit calToRow;
        private DevExpress.XtraEditors.CalcEdit calFromRow;
        private DevExpress.XtraEditors.CheckEdit cheAll;
        private DevExpress.XtraGrid.Columns.GridColumn colSymbolCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSymbolName;
    }
}