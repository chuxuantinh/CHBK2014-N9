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
    public partial class frmQuaTrinh_ChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinh_ChucVu()
        {
            InitializeComponent();
        }

        public void Loadthongtincacdotthaydoichucvu()
        {

            Class.QuaTrinh_ChucVu qtcv = new Class.QuaTrinh_ChucVu();
            gridItem.DataSource = qtcv.CT_PROCESS_POSITION_GetListByEmployee();
            gridItemDetail.OptionsView.ColumnAutoWidth = false;
        }

        private void frmQuaTrinh_ChucVu_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Class.App._manv == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmQuaTrinh_ChucVu_New frm = new frmQuaTrinh_ChucVu_New(true, "Thay đổi Thông tin Chức vụ", "CV", null, Class.App._hotennv, "frmQuaTrinh_ChucVu_New");
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}