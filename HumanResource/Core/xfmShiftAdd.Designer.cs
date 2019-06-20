namespace CHBK2014_N9.HumanResource.Core
{
    partial class xfmShiftAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmShiftAdd));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.lbNoTimeKeeperShiftList = new DevExpress.XtraEditors.ImageListBoxControl();
            this.lbTimeKeeperShiftList = new DevExpress.XtraEditors.ImageListBoxControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.dtYear = new DevExpress.XtraEditors.TimeEdit();
            this.btCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbNoTimeKeeperShiftList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTimeKeeperShiftList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 29);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(300, 300);
            this.xtraTabControl1.TabIndex = 0;
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
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // lbNoTimeKeeperShiftList
            // 
            this.lbNoTimeKeeperShiftList.Location = new System.Drawing.Point(427, 85);
            this.lbNoTimeKeeperShiftList.Name = "lbNoTimeKeeperShiftList";
            this.lbNoTimeKeeperShiftList.Size = new System.Drawing.Size(120, 95);
            this.lbNoTimeKeeperShiftList.TabIndex = 1;
            // 
            // lbTimeKeeperShiftList
            // 
            this.lbTimeKeeperShiftList.Location = new System.Drawing.Point(427, 218);
            this.lbTimeKeeperShiftList.Name = "lbTimeKeeperShiftList";
            this.lbTimeKeeperShiftList.Size = new System.Drawing.Size(120, 95);
            this.lbTimeKeeperShiftList.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(318, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 100);
            this.panelControl1.TabIndex = 3;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // dtYear
            // 
            this.dtYear.EditValue = new System.DateTime(2018, 8, 29, 0, 0, 0, 0);
            this.dtYear.Location = new System.Drawing.Point(334, 350);
            this.dtYear.Name = "dtYear";
            this.dtYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtYear.Size = new System.Drawing.Size(100, 20);
            this.dtYear.TabIndex = 4;
            this.dtYear.EditValueChanged += new System.EventHandler(this.dtYear_EditValueChanged);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(124, 336);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 5;
            this.btCreate.Text = "simpleButton1";
            this.btCreate.Click += new System.EventHandler(this.btCreat_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(241, 335);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "simpleButton1";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(193, 359);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // xfmShiftAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 394);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.dtYear);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.lbTimeKeeperShiftList);
            this.Controls.Add(this.lbNoTimeKeeperShiftList);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "xfmShiftAdd";
            this.Text = "xfmShiftAdd";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbNoTimeKeeperShiftList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTimeKeeperShiftList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.ImageListBoxControl lbNoTimeKeeperShiftList;
        private DevExpress.XtraEditors.ImageListBoxControl lbTimeKeeperShiftList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.TimeEdit dtYear;
        private DevExpress.XtraEditors.SimpleButton btCreate;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btDelete;
    }
}