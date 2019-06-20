using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace CHBK2014_N9.Common
{
    public partial class xfmBaseWizard : Form
    {
        public xfmBaseWizard()
        {
            InitializeComponent();
        }

        protected virtual void Back()
        {
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Back();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Cancel();
            base.Close();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            base.Hide();
            this.Next();
            base.Close();
        }

        protected virtual void Next()
        {
        }


        protected virtual void Cancel()
        {
        }
    }
}
