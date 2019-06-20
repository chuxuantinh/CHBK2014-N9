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
    public partial class frmDanhMuc_TinHoc : Form
    {
        public frmDanhMuc_TinHoc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_TinHoc_Load(object sender, EventArgs e)
        {
            GetAllList_INFORMATIC();
          
            //#region Khoa Phan quyen
            //// thuc hien khoa phan quyen phan quyen
            //for (int i = 0; i < barManager1.Items.Count; i++)
            //{
            //    if (barManager1.Items[i].Tag != null)
            //    {
            //        string txt = barManager1.Items[i].Tag.ToString();
            //        if (txt.Length > 0)
            //        {
            //            barManager1.Items[i].Enabled = false;
            //        }
            //    }

            //}
            //#endregion
        }

        public void GetAllList_INFORMATIC()
        {
            Class.DanhMuc_TinHoc dm = new Class.DanhMuc_TinHoc();
            gridItem.DataSource = dm.GetAllList_INFORMATIC();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Thêm mới", "TH", null, "frmDanhMuc_TinHoc");
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
                string _value = drow["InformaticCode"].ToString();

                frmDanhmuc_Update frm = new frmDanhmuc_Update(false, "Sửa Bằng tin học", "TH", _value, "frmDanhMucTinHoc");
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
                string _value = drow["InformaticCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.DanhMuc_TinHoc dm = new Class.DanhMuc_TinHoc();
                dm.InformaticCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    GetAllList_INFORMATIC();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }
    }
}
