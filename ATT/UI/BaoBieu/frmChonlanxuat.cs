using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHBK2014_N9.ATT.UI.BaoBieu
{
    public partial class frmChonlanxuat : Form
    {
        public int _iChonLanXuat = 0;
        public frmChonlanxuat()
        {
            InitializeComponent();
        }

        private void frmChonlanxuat_Load(object sender, EventArgs e)
        {
            radioButton_Xuat2l.Checked =true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_Xuat2l.Checked)
            {
                _iChonLanXuat = 2;

            }

            if (radioButton_Xuat4l.Checked)
            {
                _iChonLanXuat = 4;
            }

            if (radioButton_Xuat6l.Checked)
            {

                _iChonLanXuat = 6;
            }
            base.Close();
        }
    }
}
