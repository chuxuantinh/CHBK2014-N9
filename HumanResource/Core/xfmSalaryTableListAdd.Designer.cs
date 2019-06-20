namespace CHBK2014_N9.HumanResource.Core
{
    partial class xfmSalaryTableListAdd
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
            this.bbiSalaryFormula = new DevExpress.XtraEditors.SimpleButton();
            this.btMinimumSalary = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // bbiSalaryFormula
            // 
            this.bbiSalaryFormula.Location = new System.Drawing.Point(143, 286);
            this.bbiSalaryFormula.Name = "bbiSalaryFormula";
            this.bbiSalaryFormula.Size = new System.Drawing.Size(200, 23);
            this.bbiSalaryFormula.TabIndex = 10;
            this.bbiSalaryFormula.Text = "Thiết lập định mức lương";
            this.bbiSalaryFormula.Click += new System.EventHandler(this.bbiSalaryFormula_Click);
            // 
            // btMinimumSalary
            // 
            this.btMinimumSalary.Location = new System.Drawing.Point(143, 316);
            this.btMinimumSalary.Name = "btMinimumSalary";
            this.btMinimumSalary.Size = new System.Drawing.Size(200, 23);
            this.btMinimumSalary.TabIndex = 11;
            this.btMinimumSalary.Text = "Thiết lập mức lương tối thiểu";
            this.btMinimumSalary.Click += new System.EventHandler(this.btMinimumSalary_Click);
            // 
            // xfmSalaryTableListAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 356);
            this.Controls.Add(this.btMinimumSalary);
            this.Controls.Add(this.bbiSalaryFormula);
            this.Name = "xfmSalaryTableListAdd";
            this.Text = "xfmSalaryTableListAdd";
            this.Controls.SetChildIndex(this.bbiSalaryFormula, 0);
            this.Controls.SetChildIndex(this.btMinimumSalary, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bbiSalaryFormula;
        private DevExpress.XtraEditors.SimpleButton btMinimumSalary;
    }
}