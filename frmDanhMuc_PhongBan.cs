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
    public partial class frmDanhMuc_PhongBan : Form
    {
        public frmDanhMuc_PhongBan()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_PhongBan_Load(object sender, EventArgs e)
        {
            GetAllList_DEPARTMENT();
        }

        public void GetAllList_DEPARTMENT()
        {
            Class.DanhMuc_PhongBan dm = new Class.DanhMuc_PhongBan();
           
            gridItem.DataSource = dm.GetAllList_DEPARTMENT();
            gridItemDetail.ExpandAllGroups();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhMuc_PhongBan_Update frm = new frmDanhMuc_PhongBan_Update(true, "Thêm Phòng ban", "PB", null, "frmDanhSachPhongBan");
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!btnEdit.Enabled)
                 return;
            int Selectedrow = gridItemDetail.FocusedRowHandle;
            if (Selectedrow >= 0 )
            {

                DataRow dr = gridItemDetail.GetDataRow(Selectedrow);
                string _Value = dr["DepartmentCode"].ToString();
                frmDanhMuc_PhongBan_Update frm = new frmDanhMuc_PhongBan_Update(false, "Sửa tên phòng ban", "PB", _Value, "frmDanhMuc_PhongBan");
                frm.Owner = this;
                frm.ShowDialog();

            }
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmChamCong_BangXepCa.DefaultF
            int SelectedRoww = gridItemDetail.FocusedRowHandle;
            if (SelectedRoww > 0)
            {
                  DataRow drow = gridItemDetail.GetDataRow(SelectedRoww);
                  string _value = drow["DepartmentCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.DanhMuc_PhongBan dm =  new Class.DanhMuc_PhongBan();
                dm.DepartmentCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    GetAllList_DEPARTMENT();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                                    }
              }

        }
    }
}
