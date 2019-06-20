using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using zkemkeeper;

namespace CHBK2014_N9.HumanResource.Core.Machine
{
    public partial class xfmReg : XtraForm
    {
        public xfmReg()
        {
            this.InitializeComponent();
            xucReg _xucReg = new xucReg()
            {
                Dock = DockStyle.Fill
            };
            base.Controls.Add(_xucReg);
        }

        public xfmReg(CZKEMClass czkemClass)
        {
            this.InitializeComponent();
            xucReg _xucReg = new xucReg(czkemClass)
            {
                Dock = DockStyle.Fill
            };
            base.Controls.Add(_xucReg);
        }
    }
}
