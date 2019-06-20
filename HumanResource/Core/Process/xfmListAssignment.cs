using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Process
{
    public partial class xfmListAssignment : Form
    {
        public xfmListAssignment()
        {
            InitializeComponent();
        }

        private void xfmListAssignment_Load(object sender, EventArgs e)
        {
            xucListAssignment _xucListAssignment = new xucListAssignment();
            _xucListAssignment.Closed += new xucProcessBase.ClosedHander(this.xucListAssignment_Closed);
            base.Controls.Add(_xucListAssignment);
            _xucListAssignment.Dock = DockStyle.Fill;
            _xucListAssignment.Show();
        }


        private void xucListAssignment_Closed(object sender)
        {
            base.Close();
        }
    }
}
