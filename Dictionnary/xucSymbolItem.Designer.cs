namespace CHBK2014_N9.Dictionnary
{
    partial class xucSymbolItem
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
            this.lbSymbolCode = new DevExpress.XtraEditors.LabelControl();
            this.lbSymbolName = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbSymbolCode
            // 
            this.lbSymbolCode.Location = new System.Drawing.Point(34, 14);
            this.lbSymbolCode.Name = "lbSymbolCode";
            this.lbSymbolCode.Size = new System.Drawing.Size(63, 13);
            this.lbSymbolCode.TabIndex = 0;
            this.lbSymbolCode.Text = "labelControl1";
            // 
            // lbSymbolName
            // 
            this.lbSymbolName.Location = new System.Drawing.Point(34, 34);
            this.lbSymbolName.Name = "lbSymbolName";
            this.lbSymbolName.Size = new System.Drawing.Size(63, 13);
            this.lbSymbolName.TabIndex = 1;
            this.lbSymbolName.Text = "labelControl2";
            // 
            // xucSymbolItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSymbolName);
            this.Controls.Add(this.lbSymbolCode);
            this.Name = "xucSymbolItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lbSymbolCode;
        public DevExpress.XtraEditors.LabelControl lbSymbolName;
    }
}
