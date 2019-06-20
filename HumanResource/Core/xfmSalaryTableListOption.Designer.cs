namespace CHBK2014_N9.HumanResource.Core
{
    partial class xfmSalaryTableListOption
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmSalaryTableListOption));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.dtYear = new DevExpress.XtraEditors.TimeEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btFinish = new DevExpress.XtraEditors.SimpleButton();
            this.btLock = new DevExpress.XtraEditors.SimpleButton();
            this.btOpen = new DevExpress.XtraEditors.SimpleButton();
            this.lbSalaryTableList = new DevExpress.XtraEditors.ImageListBoxControl();
            this.lbNoSalaryTableList = new DevExpress.XtraEditors.ImageListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbSalaryTableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNoSalaryTableList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSubTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblSubTitle.Location = new System.Drawing.Point(9, 31);
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(8, 6);
            this.lblTitle.Size = new System.Drawing.Size(260, 23);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(219, 15);
            this.btBack.Visible = false;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(413, 15);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(302, 15);
            this.btNext.Size = new System.Drawing.Size(105, 23);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // dtYear
            // 
            this.dtYear.EditValue = new System.DateTime(2018, 7, 9, 0, 0, 0, 0);
            this.dtYear.Location = new System.Drawing.Point(395, 3);
            this.dtYear.Name = "dtYear";
            this.dtYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtYear.Size = new System.Drawing.Size(100, 20);
            this.dtYear.TabIndex = 0;
            this.dtYear.EditValueChanged += new System.EventHandler(this.dtYear_EditValueChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point (12, 88);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new  System.Drawing.Size (476, 212);
            this.xtraTabControl1.TabIndex = 10;
                   
          
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(294, 272);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(294, 272);
            this.xtraTabPage2.Text = "Tháng Đã Phát Sinh Lương";
            // 
            // btFinish
            // 
            this.btFinish.Enabled = false;
            this.btFinish.Location = new System.Drawing.Point(363, 65);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(113, 23);
            this.btFinish.TabIndex = 9;
            this.btFinish.Text = "Hoàn Thành";
            this.btFinish.Visible = false;
            // 
            // btLock
            // 
            this.btLock.Enabled = false;
            this.btLock.Location = new System.Drawing.Point(363, 7);
            this.btLock.Name = "btLock";
            this.btLock.Size = new System.Drawing.Size(113, 23);
            this.btLock.TabIndex = 9;
            this.btLock.Text = "Khóa Sổ";
            this.btLock.Visible = false;
            // 
            // btOpen
            // 
            this.btOpen.Enabled = false;
            this.btOpen.Location = new System.Drawing.Point(363, 36);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(113, 23);
            this.btOpen.TabIndex = 9;
            this.btOpen.Text = "Mở Sổ";
            this.btOpen.Visible = false;
            // 
            // lbSalaryTableList
            // 
            this.lbSalaryTableList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbSalaryTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSalaryTableList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbSalaryTableList.ImageList = this.imageCollection1;
            this.lbSalaryTableList.Location = new System.Drawing.Point(0, 0);
            this.lbSalaryTableList.Name = "lbSalaryTableList";
            this.lbSalaryTableList.Size = new System.Drawing.Size(497, 421);
            this.lbSalaryTableList.TabIndex = 8;
            // 
            // lbNoSalaryTableList
            // 
            this.lbNoSalaryTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNoSalaryTableList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbNoSalaryTableList.ImageList = this.imageCollection1;
            this.lbNoSalaryTableList.Location = new System.Drawing.Point(0, 0);
            this.lbNoSalaryTableList.Name = "lbNoSalaryTableList";
            this.lbNoSalaryTableList.Size = new System.Drawing.Size(497, 421);
            this.lbNoSalaryTableList.TabIndex = 9;
            // 
            // xfmSalaryTableListOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 421);
            this.Controls.Add(this.btLock);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.dtYear);
            this.Controls.Add(this.lbSalaryTableList);
            this.Controls.Add(this.lbNoSalaryTableList);
            this.Name = "xfmSalaryTableListOption";
            this.Text = "xfmSalaryTableListOption";
            this.Controls.SetChildIndex(this.lbNoSalaryTableList, 0);
            this.Controls.SetChildIndex(this.lbSalaryTableList, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblSubTitle, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btBack, 0);
            this.Controls.SetChildIndex(this.btClose, 0);
            this.Controls.SetChildIndex(this.btNext, 0);
            this.Controls.SetChildIndex(this.dtYear, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.btFinish, 0);
            this.Controls.SetChildIndex(this.btOpen, 0);
            this.Controls.SetChildIndex(this.btLock, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbSalaryTableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNoSalaryTableList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();



        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.TimeEdit dtYear;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.ImageListBoxControl lbNoSalaryTableList;
        private DevExpress.XtraEditors.ImageListBoxControl lbSalaryTableList;
        private DevExpress.XtraEditors.SimpleButton btFinish;
        private DevExpress.XtraEditors.SimpleButton btOpen;
        private DevExpress.XtraEditors.SimpleButton btLock;
    }
}