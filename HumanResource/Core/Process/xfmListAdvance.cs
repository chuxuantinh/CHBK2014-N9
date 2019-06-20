using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Process
{
    public partial class xfmListAdvance : Form
    {
        public xfmListAdvance()
        {
            InitializeComponent();
        }

        private void xfmListAdvance_Load(object sender, EventArgs e)
        {
            xucListAdvance _xucListAdvance = new xucListAdvance();
            _xucListAdvance.Closed += new xucProcessBase.ClosedHander(this.xucListAdvance_Closed);
            base.Controls.Add(_xucListAdvance);
            _xucListAdvance.Dock = DockStyle.Fill;
            _xucListAdvance.Show();
        }

        private void xucListAdvance_Closed(object sender)
        {
            base.Close();
        }
    }
}
