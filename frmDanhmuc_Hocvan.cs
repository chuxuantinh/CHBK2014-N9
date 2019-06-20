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
    public partial class frmDanhmuc_Hocvan : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhmuc_Hocvan()
        {
            InitializeComponent();

        }

        public void Laydanhsachhocvan()
        {

            Class.Danhmuc_Hocvan dmhv = new Class.Danhmuc_Hocvan();
            gridItem.DataSource = dmhv.Laydanhsachhocvan();

        }

        private void frmDanhmuc_Hocvan_Load(object sender, EventArgs e)
        {
            Laydanhsachhocvan();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Thêm mới danh mục học vấn", "HV", null, "frmDanhmuc_Hocvan");
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!btnEdit.Enabled)
                return;

            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow>=0)
            {

                DataRow dtr = gridItemDetail.GetDataRow(SelectedRow);
                string _value = dtr["EducationCode"].ToString();
                frmDanhmuc_Update frm = new frmDanhmuc_Update(false, "Thêm mới học vấn", "HV",_value, "frmDanhmuc_Hocvan");
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
                string _value = drow["EducationCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.Danhmuc_Hocvan dm = new Class.Danhmuc_Hocvan();
                dm.EducationCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    Laydanhsachhocvan();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }
    }
}
