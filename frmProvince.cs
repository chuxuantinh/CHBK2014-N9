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
    public partial class frmProvince : DevExpress.XtraEditors.XtraForm
    {
        public frmProvince()
        {
            InitializeComponent();
        }

        private void frmProvince_Load(object sender, EventArgs e)
        {
            GetAllList_Province();
        }

        public void GetAllList_Province()
        {

            Class.CT_Provice dm = new Class.CT_Provice();
            gridControl1.DataSource = dm.Get_All_CT_Province();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Thêm Tỉnh", "TT", null, "frmDanhMucTinh");
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void bntEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (!bntEdit.Enabled)
                return;
            int SelectedRow = gridView1.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridView1.GetDataRow(SelectedRow);
                string _value = drow["ProvinceCode"].ToString();

                frmDanhmuc_Update frm = new frmDanhmuc_Update(false, "Sửa Tỉnh", "TT", _value, "frmDanhMucTinh");
                frm.Owner = this;
                frm.ShowDialog();
                GetAllList_Province();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int SelectedRow = gridView1.FocusedRowHandle;
            if (SelectedRow>0)
            {

                DataRow dr = gridView1.GetDataRow(SelectedRow);
                string _value = dr["ProvinceCode"].ToString();
                if (Class.App.ConfirmDeletion()== DialogResult.No)
                                   return;

                Class.CT_Provice dm = new Class.CT_Provice();
                dm.ProvinceCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    GetAllList_Province();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }


            }
        }

        
    }
}
