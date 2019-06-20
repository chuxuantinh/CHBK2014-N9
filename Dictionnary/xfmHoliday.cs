using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xfmHoliday : XtraForm
    {
       
             public xfmHoliday()
        {
            this.InitializeComponent();
           base.Load += new EventHandler(this.xfmHoliday_Load);
        }

        private void xfmHoliday_Load(object sender, EventArgs e)
        {
            xucHoliday _xucHoliday = new xucHoliday()
            {
                Dock = DockStyle.Fill
            };
            base.Controls.Add(_xucHoliday);
        }
    }
}
