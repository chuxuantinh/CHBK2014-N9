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
    public partial class frmDanhMuc_GiaDinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMuc_GiaDinh()
        {
            InitializeComponent();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Thêm Quan hệ gia đình", "QHGD", null, "frmDanhMuc_GiaDinh");
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!btnEdit.Enabled)
                return;
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["RelativeCode"].ToString();

                frmDanhmuc_Update frm = new frmDanhmuc_Update(false, "Sửa Quan hệ gia đình", "QHGD", _value, "frmDanhMuc_GiaDinh");
                frm.Owner = this;
                frm.ShowDialog();
            }
        }


        public void GetAllList_RELATIVE()
        {
            Class.DanhMuc_GiaDinh dm = new Class.DanhMuc_GiaDinh();
            gridItem.DataSource = dm.GetAllList_RELATIVE();
        }
        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["RelativeCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.DanhMuc_GiaDinh dm = new Class.DanhMuc_GiaDinh();
                dm.RelativeCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    GetAllList_RELATIVE();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }

        private void gridItemDetail_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_ItemClick(null, null);
        }

        private void frmDanhMuc_GiaDinh_Load(object sender, EventArgs e)
        {
            GetAllList_RELATIVE();
        }
    }
}
