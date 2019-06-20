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
    public partial class frmDanhmuc_Ngoaingu : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhmuc_Ngoaingu()
        {
            InitializeComponent();
        }

        private void frmDanhmuc_Ngoaingu_Load(object sender, EventArgs e)
        {
            Laydanhsachngoaingu();
        }

        public void Laydanhsachngoaingu()
        {

            Class.DanhMuc_NgoaiNgu dmnn = new Class.DanhMuc_NgoaiNgu();
            gridItem.DataSource = dmnn.Laydanhsachngoaingu();

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Thêm Bằng ngoại ngữ", "NN", null, "frmDanhmuc_Ngoaingu");

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
                string _value = drow["LanguageCode"].ToString();

                frmDanhmuc_Update frm = new frmDanhmuc_Update(false, "Sửa Bằng ngoại ngữ", "NN", _value, "frmDanhmuc_Ngoaingu");
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
                string _value = drow["LanguageCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.DanhMuc_NgoaiNgu dm = new Class.DanhMuc_NgoaiNgu();
                dm.LanguageCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    Laydanhsachngoaingu();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }

        }
    }
}
