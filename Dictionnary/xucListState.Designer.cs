namespace CHBK2014_N9.Dictionnary
{
    partial class xucListState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucListState));
            this.imgList = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btSearch = new DevExpress.XtraEditors.ButtonEdit();
            this.imgListState = new DevExpress.XtraEditors.ImageListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListState)).BeginInit();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgList.ImageStream")));
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.imgListState);
            this.panelControl1.Controls.Add(this.btSearch);
            this.panelControl1.Location = new System.Drawing.Point(0, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(663, 280);
            this.panelControl1.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(279, 25);
            this.btSearch.Name = "btSearch";
            this.btSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btSearch.Size = new System.Drawing.Size(100, 20);
            this.btSearch.TabIndex = 0;
            this.btSearch.EditValueChanged += new System.EventHandler(this.btSearch_EditValueChanged);
            // 
            // imgListState
            // 
            this.imgListState.Location = new System.Drawing.Point(279, 62);
            this.imgListState.Name = "imgListState";
            this.imgListState.Size = new System.Drawing.Size(120, 95);
            this.imgListState.TabIndex = 1;
            // 
            // xucListState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "xucListState";
            this.Size = new System.Drawing.Size(666, 287);
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgListState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imgList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ButtonEdit btSearch;
        private DevExpress.XtraEditors.ImageListBoxControl imgListState;
    }
}
