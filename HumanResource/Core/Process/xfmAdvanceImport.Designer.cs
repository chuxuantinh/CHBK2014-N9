namespace CHBK2014_N9.HumanResource.Core.Process
{
    partial class xfmAdvanceImport
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

           
            this.wcImport.SuspendLayout();
            this.wpSelectFile.SuspendLayout();
            this.wpProcessPage.SuspendLayout();
            this.wpFinish.SuspendLayout();
          
            base.SuspendLayout();
            this.wcImport.Controls.SetChildIndex(this.wpSelectField, 0);
            this.wcImport.Controls.SetChildIndex(this.wpFinish, 0);
            this.wcImport.Controls.SetChildIndex(this.wpProcessPage, 0);
            this.wcImport.Controls.SetChildIndex(this.wpSelectFile, 0);
            this.lbLinkFileDecription.Appearance.Options.UseTextOptions = true;
       
          
            base.Name = "xfmSalaryAdvanceImport";
            this.Text = "Nhập Tạm Ứng Lương Từ Tập Tin Excel";
           
            this.wcImport.ResumeLayout(false);
            this.wpSelectFile.ResumeLayout(false);
            this.wpSelectFile.PerformLayout();
            this.wpProcessPage.ResumeLayout(false);
            this.wpFinish.ResumeLayout(false);
            this.wpFinish.PerformLayout();
           
            base.ResumeLayout(false);


            this.SuspendLayout();
            // 
            // xfmAdvanceImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 484);
            this.Name = "xfmAdvanceImport";
            this.Text = "xfmAdvanceImport";
            this.Load += new System.EventHandler(this.xfmAdvanceImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}