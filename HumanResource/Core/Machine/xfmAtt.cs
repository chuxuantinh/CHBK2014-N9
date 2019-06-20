using DevExpress.XtraEditors;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace CHBK2014_N9.HumanResource.Core.Machine
{
    public partial class xfmAtt : XtraForm
    {
        public xfmAtt()
        {
            //this.InitializeComponent();

            xucAtt _xucAtt = new xucAtt();
            _xucAtt.Call += new xucAtt.CallEventHandler(this.xucAtt_Call);
            _xucAtt.Dock = DockStyle.Fill;
            base.Controls.Add(_xucAtt);
        }

        private void xfmAtt_Load(object sender, EventArgs e)
        {

        }


        private void xucAtt_Call()
        {
            base.Show();
            base.WindowState = FormWindowState.Normal;
        }



        private void xfmAtt_FormClosing(object sender, FormClosingEventArgs e)
        {

            //}
        }
    }
}
