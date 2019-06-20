using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Common.Base
{
    public partial class xucExpandCollapseButton : UserControl
    {
        public xucExpandCollapseButton()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!(this.label1.Text == "▲"))
            {
                this.label1.Text = "▲";
                this.RaiseExpandCollapsedHander(true);
            }
            else
            {
                this.label1.Text = "▼";
                this.RaiseExpandCollapsedHander(false);
            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            this.panel1.Visible = true;
        }

        private void RaiseExpandCollapsedHander(bool IsExpand)
        {
            if (this.ExpandCollapsed != null)
            {
                this.ExpandCollapsed(this, IsExpand);
            }
        }

        public event xucExpandCollapseButton.ExpandCollapsedHander ExpandCollapsed;

        public delegate void ExpandCollapsedHander(object sender, bool IsExpand);
    }
}
