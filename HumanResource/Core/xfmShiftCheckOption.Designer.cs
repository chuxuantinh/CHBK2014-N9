namespace CHBK2014_N9.HumanResource.Core
{
    partial class xfmShiftCheckOption
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lcDescription = new DevExpress.XtraEditors.LabelControl();
            this.rdOption = new DevExpress.XtraEditors.RadioGroup();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btCreate = new DevExpress.XtraEditors.SimpleButton();
            this.cheIsNotHoliday = new DevExpress.XtraEditors.CheckEdit();
            this.cheIsNotSunday = new DevExpress.XtraEditors.CheckEdit();
            this.cheIsNotSaturday = new DevExpress.XtraEditors.CheckEdit();
            this.cheIsFilterByShift = new DevExpress.XtraEditors.CheckEdit();
            this.clbShift = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.calToRow = new DevExpress.XtraEditors.CalcEdit();
            this.calFromRow = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teToDate = new DevExpress.XtraEditors.TimeEdit();
            this.teFromDate = new DevExpress.XtraEditors.TimeEdit();
            this.cheAll = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdOption.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsNotHoliday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsNotSunday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsNotSaturday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsFilterByShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calToRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFromRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAll.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lcDescription);
            this.groupBox1.Controls.Add(this.rdOption);
            this.groupBox1.Location = new System.Drawing.Point(2, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn nâng cao";
            // 
            // lcDescription
            // 
            this.lcDescription.LineVisible = true;
            this.lcDescription.Location = new System.Drawing.Point(7, 20);
            this.lcDescription.Name = "lcDescription";
            this.lcDescription.Size = new System.Drawing.Size(481, 26);
            this.lcDescription.TabIndex = 1;
            this.lcDescription.Text = "Chọn là [Chọn] hoặc [Bỏ chọn] từ ô phía bên dưới, sau đó chọn phát sinh từ ngày n" +
    "ào đến ngày nào\r\n và từ dòng nào đến dòng nào trong lưới danh sách.";
            // 
            // rdOption
            // 
            this.rdOption.Location = new System.Drawing.Point(7, 61);
            this.rdOption.Name = "rdOption";
            this.rdOption.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chọn"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Bỏ chọn")});
            this.rdOption.Size = new System.Drawing.Size(584, 33);
            this.rdOption.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cheAll);
            this.groupBox2.Controls.Add(this.btCancel);
            this.groupBox2.Controls.Add(this.btCreate);
            this.groupBox2.Controls.Add(this.cheIsNotHoliday);
            this.groupBox2.Controls.Add(this.cheIsNotSunday);
            this.groupBox2.Controls.Add(this.cheIsNotSaturday);
            this.groupBox2.Controls.Add(this.cheIsFilterByShift);
            this.groupBox2.Controls.Add(this.clbShift);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.calToRow);
            this.groupBox2.Controls.Add(this.calFromRow);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.teToDate);
            this.groupBox2.Controls.Add(this.teFromDate);
            this.groupBox2.Location = new System.Drawing.Point(2, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(280, 222);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 18;
            this.btCancel.Text = "Thoát";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(159, 222);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 17;
            this.btCreate.Text = "Chọn";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // cheIsNotHoliday
            // 
            this.cheIsNotHoliday.Location = new System.Drawing.Point(15, 169);
            this.cheIsNotHoliday.Name = "cheIsNotHoliday";
            this.cheIsNotHoliday.Properties.Caption = "Bỏ qua ngày nghỉ lễ";
            this.cheIsNotHoliday.Size = new System.Drawing.Size(197, 19);
            this.cheIsNotHoliday.TabIndex = 16;
            // 
            // cheIsNotSunday
            // 
            this.cheIsNotSunday.Location = new System.Drawing.Point(15, 143);
            this.cheIsNotSunday.Name = "cheIsNotSunday";
            this.cheIsNotSunday.Properties.Caption = "Bỏ qua ngày chủ nhật";
            this.cheIsNotSunday.Size = new System.Drawing.Size(137, 19);
            this.cheIsNotSunday.TabIndex = 15;
            // 
            // cheIsNotSaturday
            // 
            this.cheIsNotSaturday.Location = new System.Drawing.Point(15, 117);
            this.cheIsNotSaturday.Name = "cheIsNotSaturday";
            this.cheIsNotSaturday.Properties.Caption = "Bỏ qua ngày thứ 7";
            this.cheIsNotSaturday.Size = new System.Drawing.Size(150, 19);
            this.cheIsNotSaturday.TabIndex = 14;
            // 
            // cheIsFilterByShift
            // 
            this.cheIsFilterByShift.Location = new System.Drawing.Point(332, 92);
            this.cheIsFilterByShift.Name = "cheIsFilterByShift";
            this.cheIsFilterByShift.Properties.Caption = "Lọc theo ca";
            this.cheIsFilterByShift.Size = new System.Drawing.Size(75, 19);
            this.cheIsFilterByShift.TabIndex = 13;
            this.cheIsFilterByShift.CheckedChanged += new System.EventHandler(this.cheIsFilterByShift_CheckedChanged);
            // 
            // clbShift
            // 
            this.clbShift.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "HC->HC (08:17 -PM)")});
            this.clbShift.Location = new System.Drawing.Point(329, 117);
            this.clbShift.Name = "clbShift";
            this.clbShift.Size = new System.Drawing.Size(262, 57);
            this.clbShift.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(193, 51);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(13, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Từ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(358, 54);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(20, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Đến";
            // 
            // calToRow
            // 
            this.calToRow.Location = new System.Drawing.Point(427, 46);
            this.calToRow.Name = "calToRow";
            this.calToRow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calToRow.Size = new System.Drawing.Size(100, 20);
            this.calToRow.TabIndex = 9;
            // 
            // calFromRow
            // 
            this.calFromRow.Location = new System.Drawing.Point(222, 47);
            this.calFromRow.Name = "calFromRow";
            this.calFromRow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFromRow.Size = new System.Drawing.Size(100, 20);
            this.calFromRow.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Chọn dòng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Chọn ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(358, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Đến";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(193, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Từ";
            // 
            // teToDate
            // 
            this.teToDate.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.teToDate.Location = new System.Drawing.Point(427, 20);
            this.teToDate.Name = "teToDate";
            this.teToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teToDate.Properties.Mask.EditMask = "dd";
            this.teToDate.Size = new System.Drawing.Size(100, 20);
            this.teToDate.TabIndex = 1;
            // 
            // teFromDate
            // 
            this.teFromDate.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.teFromDate.Location = new System.Drawing.Point(222, 20);
            this.teFromDate.Name = "teFromDate";
            this.teFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teFromDate.Properties.Mask.EditMask = "dd";
            this.teFromDate.Size = new System.Drawing.Size(100, 20);
            this.teFromDate.TabIndex = 0;
            // 
            // cheAll
            // 
            this.cheAll.Location = new System.Drawing.Point(86, 47);
            this.cheAll.Name = "cheAll";
            this.cheAll.Properties.Caption = "Tất cả các dòng";
            this.cheAll.Size = new System.Drawing.Size(101, 19);
            this.cheAll.TabIndex = 19;
            this.cheAll.CheckedChanged += new System.EventHandler(this.cheAll_CheckedChanged);
            // 
            // xfmShiftCheckOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "xfmShiftCheckOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn nhanh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdOption.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsNotHoliday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsNotSunday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsNotSaturday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsFilterByShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calToRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFromRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAll.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl lcDescription;
        private DevExpress.XtraEditors.RadioGroup rdOption;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeEdit teToDate;
        private DevExpress.XtraEditors.TimeEdit teFromDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CalcEdit calToRow;
        private DevExpress.XtraEditors.CalcEdit calFromRow;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckedListBoxControl clbShift;
        private DevExpress.XtraEditors.CheckEdit cheIsFilterByShift;
        private DevExpress.XtraEditors.CheckEdit cheIsNotHoliday;
        private DevExpress.XtraEditors.CheckEdit cheIsNotSunday;
        private DevExpress.XtraEditors.CheckEdit cheIsNotSaturday;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btCreate;
        private DevExpress.XtraEditors.CheckEdit cheAll;
    }
}