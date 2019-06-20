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
    public partial class frmDanhmuc_Bangcap : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhmuc_Bangcap()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmDanhmuc_Bangcap_Load(object sender, EventArgs e)
        {
            Loadbangcap();
        }

        public void Loadbangcap()
        {
            Class.DanhMuc_BangCap dmbc = new Class.DanhMuc_BangCap();
            gridItem.DataSource = dmbc.Loadbangcap();



        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Thêm mới băng cấp","BC", null, "frmDanhmuc_Bangcap");
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!btnEdit.Enabled)
                return;
            int selectedrow = gridItemDetail.FocusedRowHandle;
            if (selectedrow>=0)
            {
                DataRow dr = gridItemDetail.GetDataRow(selectedrow);
                string _value = dr["DegreeCode"].ToString();
                frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Sửa bằng cấp", "BC", _value, "frmDanhmuc_Bangcap");
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
                string _value = drow["DegreeCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.DanhMuc_BangCap dmbc = new Class.DanhMuc_BangCap();
                dmbc.DegreeCode = _value;
                if (dmbc.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    Loadbangcap();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }

        private void gridItem_Click(object sender, EventArgs e)
        {

        }

        private void gridItem_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_ItemClick(null, null);  //call edit row
        }
    }
}
