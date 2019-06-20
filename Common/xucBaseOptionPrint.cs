using DevExpress.Utils;
using DevExpress.XtraEditors;
using CHBK2014_N9.Common.Class;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Common
{
    public partial class xucBaseOptionPrint : xucBase
    {
        public xucBaseOptionPrint()
        {
            InitializeComponent();
            this.Init();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Print();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            this.PrintPreview();
        }

        protected virtual void Init()
        {
        }


        protected virtual void MakerInterface()
        {
        }

        public bool Number(KeyPressEventArgs e)
        {
            bool flag;
            if (!(e.KeyChar == '\b' | e.KeyChar == '.' | e.KeyChar == '-'))
            {
                flag = (char.IsNumber(e.KeyChar) ? false : true);
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        protected virtual void Print()
        {
        }

        protected virtual void PrintPreview()
        {
        }
        protected virtual void Cancel()
        {
        }
        public void RaiseCancelClickEventHander()
        {
            if (this.CancelClick != null)
            {
                this.CancelClick(this);
            }
        }

        public void RaiseSaveClickEventHander()
        {
            if (this.SaveClick != null)
            {
                this.SaveClick(this);
            }
        }

        protected virtual void SetInterface()
        {
        }

        public event ButtonClickEventHander CancelClick;

        public event ButtonClickEventHander SaveClick;
    }
}
