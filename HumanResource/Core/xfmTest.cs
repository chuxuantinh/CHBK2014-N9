using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmTest : Form
    {
        public xfmTest()
        {
            InitializeComponent();
        }

        private void xfmTest_Load(object sender, EventArgs e)
        {
           CHBK2014_N9.Dictionnary.xucBranch _xucEmployee = new CHBK2014_N9.Dictionnary.xucBranch();
          
            base.Controls.Add(_xucEmployee);
         //   _xucEmployee.Dock = DockStyle.Fill;
            _xucEmployee.Show();
        }
    }
}
