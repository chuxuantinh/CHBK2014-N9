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
    public partial class frmDanhMuc_DantToc : Form
    {
        public frmDanhMuc_DantToc()
        {
            InitializeComponent();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Thêm Dân tộc", "DT", null, "frmDanhMuc_DanToc");
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void frmDanhMuc_DantToc_Load(object sender, EventArgs e)
        {
            GetAllList_ETHNIC();
        }

        public void GetAllList_ETHNIC()
        {
            Class.DanhMuc_DanToc dm = new Class.DanhMuc_DanToc();
            gridItem.DataSource = dm.GetAllList_ETHNIC();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!btnEdit.Enabled)
                return;
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["EthnicCode"].ToString();

                frmDanhmuc_Update frm = new frmDanhmuc_Update(false, "Sửa Dân tộc", "DT", _value, "frmDanhMuc_DanToc");
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["EthnicCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.DanhMuc_DanToc dmbc = new Class.DanhMuc_DanToc();
                dmbc.EthnicCode = _value;
                if (dmbc.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    GetAllList_ETHNIC();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }
    }
}
