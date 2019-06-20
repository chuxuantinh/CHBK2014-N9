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
    public partial class frmDanhMuc_ChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMuc_ChucVu()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_ChucVu_Load(object sender, EventArgs e)
        {
            GetAllList_Position();

            ////for (int i = 0; i < barManager1.Items.Count; i++)
            ////{
            ////    if (barManager1.Items[i].Tag != null)
            ////    {
            ////        string txt = barManager1.Items[i].Tag.ToString();
            ////        if (txt.Length > 0)
            ////        {
            ////            barManager1.Items[i].Enabled = false;
            ////        }
            ////    }

            ////}

            //////-----------mo phan quyen
           
            ////for (int i = 0; i < barManager1.Items.Count; i++)
            ////{
            ////    if (barManager1.Items[i].Tag != null)
            ////    {
            ////        string txt = barManager1.Items[i].Tag.ToString();
            ////        if (txt.Length > 0)
            ////        {
            ////            for (int l = 0; l < Class.App.dtPermision.Rows.Count; l++)
            ////            {
            ////                string _Object_ID = Class.App.dtPermision.Rows[l]["Object_ID"].ToString();
            ////                if (_Object_ID == txt)
            ////                {
            ////                    barManager1.Items[i].Enabled = true;
            ////                }
            ////            }

            ////        }
            ////    }

            //}
        }

        public void GetAllList_Position()
        {

            Class.Danhmuc_Chucvu dm = new Class.Danhmuc_Chucvu();
            Griditem.DataSource = dm.GetAlllist_Position();



        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhmucChucvu_Update frm = new frmDanhmucChucvu_Update(true, "Thêm chức vụ", null, null);
            frm.Owner= this;
            frm.ShowDialog();

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!btnEdit.Enabled)
                return;
            int SelectedRow = GridItemdetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = GridItemdetail.GetDataRow(SelectedRow);
                string _value = drow["PositionCode"].ToString();

                frmDanhmucChucvu_Update frm = new frmDanhmucChucvu_Update(false, "Sửa Chức vụ", "CV", _value);
                frm.Owner = this;
                frm.ShowDialog(); 
              
            }
            
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int selectrow = GridItemdetail.FocusedRowHandle;
            if (selectrow >0)
            {

                DataRow drow = GridItemdetail.GetDataRow(selectrow);
                string _value = drow["PositionCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.Danhmuc_Chucvu dmcv = new Class.Danhmuc_Chucvu();
                dmcv.PositionCode = _value;
                if (dmcv.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    GetAllList_Position();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }

            }

        }

      


    }
}