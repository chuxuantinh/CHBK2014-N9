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
    public partial class frmDanhmuc_QuocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhmuc_QuocGia()
        {
            InitializeComponent();


        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (!btnEdit.Enabled)
                return;
            int SelectedRow = gridView1.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridView1.GetDataRow(SelectedRow);
                string _value = drow["NationalityCode"].ToString();

                frmDanhmuc_Update frm = new frmDanhmuc_Update(false, "Sửa Quốc tịch", "QG", _value, "frmDanhmuc_QuocGia");
                frm.Owner = this;
                frm.ShowDialog();
            }


        }

        private void groupItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmDanhmuc_QuocGia_Load(object sender, EventArgs e)
        {
            Loadanhsachquocgia();
            Class.DanhMuc_QuocGia dmqg2 = new Class.DanhMuc_QuocGia();
           


        }

        public void Loadanhsachquocgia()
        {

            Class.DanhMuc_QuocGia dmqg = new Class.DanhMuc_QuocGia();
            gridControl1.DataSource = dmqg.Loaddanhsachquocgia();
           
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhmuc_Update frm = new frmDanhmuc_Update(true, "Thêm Quốc tịch", "QG", null, "frmDanhmuc_QuocGia");
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int SelectedRow = gridView1.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridView1.GetDataRow(SelectedRow);
                string _value = drow["NationalityCode"].ToString();
                if (Class.App.ConfirmDeletion() == DialogResult.No)
                    return;

                Class.DanhMuc_QuocGia dm= new Class.DanhMuc_QuocGia();
                dm.NationalityCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    Loadanhsachquocgia();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_ItemClick(null, null);
        }
    }
}
