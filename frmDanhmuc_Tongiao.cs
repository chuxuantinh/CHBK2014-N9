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
    public partial class frmDanhmuc_Tongiao : Form
    {
        public frmDanhmuc_Tongiao()
        {
            InitializeComponent();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Thêm Tôn giáo", "TG", null, "frmDanhMucTonGiao");
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void frmDanhmuc_Tongiao_Load(object sender, EventArgs e)
        {
            Loadtongiao();
        }


        public void Loadtongiao()
        {

            Class.DanhMuc_TonGiao dmtg = new Class.DanhMuc_TonGiao();
            gridItem.DataSource = dmtg.GetAllList_RELIGION();


        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!btnEdit.Enabled)
                return;
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["ReligionCode"].ToString();

                frmDanhmuc_Update frm = new frmDanhmuc_Update(false, "Sửa Tôn giáo", "TG", _value, "frmDanhMucTonGia");
                frm.Owner = this;
                frm.ShowDialog();
            }

            Loadtongiao();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["ReligionCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.DanhMuc_TonGiao dm = new Class.DanhMuc_TonGiao();
                dm.ReligionCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    Loadtongiao();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }
    }
}
