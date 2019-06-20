using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CHBK2014_N9
{
    public partial class frmQuaTrinh_LamViec : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinh_LamViec()
        {
            InitializeComponent();
        }
        frmQuaTrinhLamViec_KhenThuong frm = new frmQuaTrinhLamViec_KhenThuong();
       frmQuaTrinhLamViec_KyLuat frmkl = new frmQuaTrinhLamViec_KyLuat();
        frmQuaTrinhLamViec_DaoTao frmdtao = new frmQuaTrinhLamViec_DaoTao();
        frmQuaTrinh_ChucVu frmcv = new frmQuaTrinh_ChucVu();

        private void frmQuaTrinh_LamViec_Load(object sender, EventArgs e)
        {
            Class.App._manv = "";
            Class.App._hotennv = "";


            frm.TopLevel = false;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            TabPage1.Controls.Add(frm);
            frm.Show();

            frmkl.TopLevel = false;
            frmkl.Dock = System.Windows.Forms.DockStyle.Fill;
            TabPage2.Controls.Add(frmkl);
            frmkl.Show();

            frmdtao.TopLevel = false;
            frmdtao.Dock = System.Windows.Forms.DockStyle.Fill;
            frmcv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            TabPage3.Controls.Add(frmdtao);
            frmdtao.Show();

            frmcv.TopLevel = false;
            frmcv.Dock = System.Windows.Forms.DockStyle.Fill;
            frmcv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            TabPage5.Controls.Add(frmcv);
            frmcv.Show();
            
            Loadthongtinmanhanvien();
        }

        private void Loadthongtinmanhanvien()
        {

            Class.NhanVien nv = new Class.NhanVien();
            nv.Status = -1;
            DataTable dt = nv.LoadDanhSachNhanVien_Ex();
            cboEmployeeCode.DataSource = dt;
            cboEmployeeCode.DisplayMember = "EmployeeCode";
            cboEmployeeCode.ValueMember = "EmployeeCode";   
        }

        private void GetEmployeeByCode(string strCode)
        {
            Class.NhanVien nv = new Class.NhanVien();
            nv.EmployeeCode = strCode;
            DataTable dt = nv.GetEmployeeByCode(strCode);
            barFullName.EditValue = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
            txtFullName.Text = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
            txtEmployeeCode.Text = dt.Rows[0]["EmployeeCode"].ToString();
            dateBirthday.DateTime = (DateTime)dt.Rows[0]["Birthday"];
            txtCellPhone.Text = dt.Rows[0]["CellPhone"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtContactAddress.Text = dt.Rows[0]["ContactAddress"].ToString();
            txtPosition.Text = dt.Rows[0]["Position"].ToString();
            txtBranchName.Text = dt.Rows[0]["BranchName"].ToString();
            txtDepartmentName.Text = dt.Rows[0]["DepartmentName"].ToString();
            txtGroupName.Text = dt.Rows[0]["GroupName"].ToString();
            checkSex.Checked = (bool)dt.Rows[0]["Sex"];
            // xu ly photo      
            if (dt.Rows[0]["Photo"] != DBNull.Value)
            {
                Byte[] imgbyte = (byte[])dt.Rows[0]["Photo"];
                if (imgbyte.Length > 10)
                {
                    MemoryStream stmPicData = new MemoryStream(imgbyte);
                    Photo.Image = Image.FromStream(stmPicData);
                }
                else
                {
                    Photo.Image = null;
                }
            }
            else
            {
                Photo.Image = null;
            }
            //
        }



        private void Call_Info_NV()
        {
           // frm.CT_PROCESS_REWARD_GetListByEmployee();
           // frmkl.CT_PROCESS_DISCIPLINE_GetListByEmployee();
            frmdtao.CT_PROCESS_TRAINING_GetListByEmployee();
            frmcv.Loadthongtincacdotthaydoichucvu();
        }

        private void frmQuaTrinh_LamViec_Activated(object sender, EventArgs e)
        {
            if (tCBoEmployeeCode.EditValue != null)
            {
                GetEmployeeByCode(tCBoEmployeeCode.EditValue.ToString());
                Class.App._manv = tCBoEmployeeCode.EditValue.ToString();
                Class.App._hotennv = txtFullName.Text;
                Call_Info_NV();
            }
        }

        private void tCBoEmployeeCode_EditValueChanged(object sender, EventArgs e)
        {
            Waiting.ShowWaitForm();
            if (tCBoEmployeeCode.EditValue != null)
            {
                GetEmployeeByCode(tCBoEmployeeCode.EditValue.ToString());
                Class.App._manv = tCBoEmployeeCode.EditValue.ToString();
                Class.App._hotennv = txtFullName.Text;
                Call_Info_NV();
            }
            Waiting.CloseWaitForm();
        }

    }
}
