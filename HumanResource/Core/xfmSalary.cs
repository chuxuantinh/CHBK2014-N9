using DevExpress.XtraEditors;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmSalary : Form
    {
        public xfmSalary()
        {
            InitializeComponent();
        }

        private void xfmSalary_Load(object sender, EventArgs e)
        {
            xucSalary _xucSalary = new xucSalary();
            _xucSalary.Closed += new xucOrganizationBase.ClosedHander((object s) => base.Close());
            _xucSalary.PayEvented += new xucSalary.PayEventHander((object s, int m, int y) => this.RaisePayEventHander(m, y));
            _xucSalary.Dock = DockStyle.Fill;
            base.Controls.Add(_xucSalary);
        }

        private void RaisePayEventHander(int Month, int Year)
        {
            if (this.PayEvented != null)
            {
                this.PayEvented(this, Month, Year);
            }
        }

        public event xfmSalary.PayEventHander PayEvented;

        public delegate void PayEventHander(object sender, int Month, int Year);

        private void xucSalary1_Load(object sender, EventArgs e)
        {

        }
    }
}
