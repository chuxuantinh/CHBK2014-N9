namespace CHBK2014_N9.HumanResource.Core
{
    partial class xucOrganizationEdit
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
            this.ppContainerEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.ppContainer = new DevExpress.XtraEditors.PopupContainerControl();
            this.xucOrganization1 = new CHBK2014_N9.HumanResource.Core.xucOrganization();
            ((System.ComponentModel.ISupportInitialize)(this.ppContainerEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppContainer)).BeginInit();
            this.ppContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ppContainerEdit
            // 
            this.ppContainerEdit.Location = new System.Drawing.Point(3, 3);
            this.ppContainerEdit.Name = "ppContainerEdit";
            this.ppContainerEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ppContainerEdit.Properties.PopupControl = this.ppContainer;
            this.ppContainerEdit.Size = new System.Drawing.Size(282, 20);
            this.ppContainerEdit.TabIndex = 0;
            this.ppContainerEdit.Popup += new System.EventHandler(this.ppContainerEdit_Popup);
            this.ppContainerEdit.EditValueChanged += new System.EventHandler(this.ppContainerEdit_EditValueChanged);
            // 
            // ppContainer
            // 
            this.ppContainer.AutoSize = true;
            this.ppContainer.Controls.Add(this.xucOrganization1);
            this.ppContainer.Location = new System.Drawing.Point(3, 24);
            this.ppContainer.Name = "ppContainer";
            this.ppContainer.Size = new System.Drawing.Size(282, 547);
            this.ppContainer.TabIndex = 0;
            // 
            // xucOrganization1
            // 
            this.xucOrganization1.Location = new System.Drawing.Point(-3, 2);
            this.xucOrganization1.Name = "xucOrganization1";
            this.xucOrganization1.Size = new System.Drawing.Size(282, 513);
            this.xucOrganization1.TabIndex = 0;
            this.xucOrganization1.Selected += new CHBK2014_N9.HumanResource.Core.xucOrganization.SelectedEventHander(this.xucOrganization1_Selected);
            // 
            // xucOrganizationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ppContainerEdit);
            this.Controls.Add(this.ppContainer);
            this.Name = "xucOrganizationEdit";
            this.Size = new System.Drawing.Size(289, 336);
            this.Load += new System.EventHandler(this.xucOrganizationEdit_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ppContainerEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppContainer)).EndInit();
            this.ppContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraEditors.PopupContainerEdit ppContainerEdit;
        private DevExpress.XtraEditors.PopupContainerControl ppContainer;
        private xucOrganization xucOrganization1;
    }
}
