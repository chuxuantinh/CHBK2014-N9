using DevExpress.XtraEditors;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmContract : XtraForm
    {
        public xfmContract()
        {
            InitializeComponent();
            base.Load += new EventHandler(this.xfmContract_Load);
        }

        private void xfmContract_Load(object sender, EventArgs e)
        {
            xucContract _xucContract = new xucContract();
            _xucContract.Closed += new xucContract.ClosedHander(this.xucContract_Closed);
            _xucContract.Dock = DockStyle.Fill;
            base.Controls.Add(_xucContract);
        }

        private void xucContract_Closed(object sender)
        {
            base.Close();
        }

        private void xfmContract_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.Close();
        }
    }
}
