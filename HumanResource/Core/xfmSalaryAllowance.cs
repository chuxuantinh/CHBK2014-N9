using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmSalaryAllowance : Form
    {
        public xfmSalaryAllowance()
        {
            InitializeComponent();
        }

        public void SetMonthYear(int Month, int Year)
        {
        }

        private void xucSalaryAllowance_SalaryPayChanged(object sender)
        {
            this.RaiseSalaryPayChangedHander();
        }

        private void xucSalaryPay_Closed(object sender)
        {
            base.Close();
        }

        public event xfmSalaryAllowance.SalaryPayChangedHander SalaryPayChanged;

        public delegate void SalaryPayChangedHander(object sender);

        private void RaiseSalaryPayChangedHander()
        {
            if (this.SalaryPayChanged != null)
            {
                this.SalaryPayChanged(this);
            }
        }

        private void xfmSalaryAllowance_Load(object sender, EventArgs e)
        {
            this.xucSalaryAllowance = new xucSalaryAllowance();
            this.xucSalaryAllowance.Closed += new xucOrganizationBase.ClosedHander(this.xucSalaryPay_Closed);
            this.xucSalaryAllowance.SalaryPayChanged += new xucSalaryBase.SalaryPayChangedHander(this.xucSalaryAllowance_SalaryPayChanged);
            this.xucSalaryAllowance.Dock = DockStyle.Fill;
            base.Controls.Add(this.xucSalaryAllowance);
        }
    }
}
