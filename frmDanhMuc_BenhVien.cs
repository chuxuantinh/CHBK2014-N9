using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHBK2014_N9
{
    public partial class frmDanhMuc_BenhVien : Form
    {
        public frmDanhMuc_BenhVien()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_BenhVien_Load(object sender, EventArgs e)
        {

        }

        public void GetAllList_HOSPITAL()
        {
            Class.DanhMuc_BenhVien dm = new Class.DanhMuc_BenhVien();
            gridItem.DataSource = dm.GetAllList_HOSPITAL();
        }
    }
}
