using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmEmployee : Form
    {

        public xfmEmployee()
        {
            this.InitializeComponent();
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(724, 491);
            base.Name = "xfmEmployee";
            this.Text = "Danh Sách Nhân Viên";
            base.ResumeLayout(false);
        }

      //  private void InitializeComponent()
        //{

        //    base.SuspendLayout();
        //    base.AutoScaleDimensions = new SizeF(6f, 13f);
        //    base.AutoScaleMode = AutoScaleMode.Font;
        //    base.ClientSize = new Size(724, 491);
        //    base.Name = "xfmEmployee";
        //    this.Text = "Danh Sách Nhân Viên";
        //    base.ResumeLayout(false);
        //}

        private void xfmEmployee_Load(object sender, EventArgs e)
        {
            xucEmployee _xucEmployee = new xucEmployee();
            _xucEmployee.Closed += new xucEmployee.ClosedHander(this.xucemployee_Closed);
            base.Controls.Add(_xucEmployee);
            _xucEmployee.Dock = DockStyle.Fill;
            _xucEmployee.Show();

        }

        private void xucemployee_Closed(object sender)
        {
            base.Close();
        }


    }
}
