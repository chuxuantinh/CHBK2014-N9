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
    public partial class frmQuaTrinh_ChucVu_New : Form
    {
        public frmQuaTrinh_ChucVu_New()
        {
            InitializeComponent();
        }
         object[] _emCode;
         public frmQuaTrinh_ChucVu_New(string Acction, object[] em, DataTable dt, string name)
        {
            InitializeComponent();
            dateDate.DateTime = DateTime.Now;
            _Action = Acction;
            _emCode = em;
            groupBox1.Enabled = true;
            Call_info_toCBO();
            if (em.Length == 1)
            {
                this.Text = "Cập nhật thông tin chức vụ: " +name;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < em.Length; j++)
                    {
                        if (em[j].ToString() == dt.Rows[i]["EmployeeCode"].ToString())
                        {
                            cboOldBranch.EditValue = dt.Rows[i]["BranchCode"].ToString();
                            cboOldDepartment.EditValue = dt.Rows[i]["DepartmentCode"].ToString();
                            cboOldGroup.EditValue = dt.Rows[i]["GroupCode"].ToString();
                            txtOldPosition.Text = dt.Rows[i]["Position"].ToString();
                            break;
                            // tb += dt.Rows[i]["EmployeeCode"].ToString() + ":" + dt.Rows[i]["FirstName"].ToString() + " " + dt.Rows[i]["LastName"].ToString() + "\r\n";
                        }
                    }
                }
                Class.App._manv = em[0].ToString();
                txtPositionID.Text = Guid.NewGuid().ToString();
                txtPositionID.Enabled = true;
            }
            else
            {
                Acction = "DanhSach";
                this.Text = "Cập nhật thông tin chức vụ theo danh sách";
                string tb = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < em.Length; j++)
                    {
                        if (em[j].ToString() == dt.Rows[i]["EmployeeCode"].ToString())
                        {
                            tb +=dt.Rows[i]["EmployeeCode"].ToString()+":"+ dt.Rows[i]["FirstName"].ToString() + " " + dt.Rows[i]["LastName"].ToString() + "\r\n";
                        }
                    }
                }
                alertControl.Show(this, "Danh sách Nhân viên đang chọn thay đổi:", tb);
            }
        }

        private void frmQuaTrinh_ChucVu_New_Load(object sender, EventArgs e)
        {

        }
        public string _reCallFunction;
        public string _Action = "";
        public frmQuaTrinh_ChucVu_New(bool Add_new, string Caption_name, string Form_name, string Code, string Name, string reCallFunction)
        {
            InitializeComponent();
            this.Text = Caption_name + " - " + Name;
            Call_info_toCBO();
            if (Add_new)
            {
                txtPositionID.Text = call_Code_New();
            }
            else
            {
                call_info(Form_name, Code);
                txtPositionID.Enabled = false;
            }
            _reCallFunction = reCallFunction;
        }

        private void call_info(string Form_name, string code)
        {
            Class.NhanVien nv = new Class.NhanVien();
            // DataTable dt = nv.GetEmployeeByCode(Class.App._manv);


            Class.QuaTrinh_ChucVu qtlv = new Class.QuaTrinh_ChucVu();
            qtlv.PositionID = code;
            DataTable dtcv = qtlv.CT_PROCESS_POSITION_Get();

            cboOldBranch.EditValue = dtcv.Rows[0]["OldBranch"].ToString();
            cboOldDepartment.EditValue = dtcv.Rows[0]["OldDepartment"].ToString();
            cboOldGroup.EditValue = dtcv.Rows[0]["OldGroup"].ToString();
            txtOldPosition.Text = dtcv.Rows[0]["OldPosition"].ToString();

            cboNewBranch.EditValue = dtcv.Rows[0]["NewBranch"].ToString();
            cboNewDepartment.EditValue = dtcv.Rows[0]["NewDepartment"].ToString();
            cboNewGroup.EditValue = dtcv.Rows[0]["NewGroup"].ToString();
            txtNewPosition.Text = dtcv.Rows[0]["NewPosition"].ToString();
            txtReason.Text = dtcv.Rows[0]["Reason"].ToString();
            txtDecideNumber.Text = dtcv.Rows[0]["DecideNumber"].ToString();
            dateDate.DateTime = (DateTime)dtcv.Rows[0]["Date"];
            txtPerson.Text = dtcv.Rows[0]["Person"].ToString();
            txtPositionID.Text = code;
        }
        private string call_Code_New()
        {
            this.Text = "Thay đổi Thông tin Chức vụ - " + Class.App._hotennv;
            dateDate.DateTime = DateTime.Now;
            Class.NhanVien nv = new Class.NhanVien();
            DataTable dt = nv.GetEmployeeByCode(Class.App._manv);
            cboOldBranch.EditValue = dt.Rows[0]["BranchCode"].ToString();
            cboOldDepartment.EditValue = dt.Rows[0]["DepartmentCode"].ToString();
            cboOldGroup.EditValue = dt.Rows[0]["GroupCode"].ToString();
            txtOldPosition.Text = dt.Rows[0]["Position"].ToString();
            return Guid.NewGuid().ToString();
        }

        private void Call_info_toCBO()
        {
            Class.DanhMuc_ChiNhanh cn = new Class.DanhMuc_ChiNhanh();
            DataTable dtcn = cn.Danhsachchinhanh();
            cboOldBranch.Properties.DataSource = dtcn;
            cboOldBranch.Properties.ValueMember = "BranchCode";
            cboOldBranch.Properties.DisplayMember = "BranchName";
            cboNewBranch.Properties.DataSource = dtcn;
            cboNewBranch.Properties.ValueMember = "BranchCode";
            cboNewBranch.Properties.DisplayMember = "BranchName";

            Class.DanhMuc_PhongBan pb = new Class.DanhMuc_PhongBan();
            DataTable dtpb = pb.GetAllList_DEPARTMENT();
            cboOldDepartment.Properties.DataSource = dtpb;
            cboOldDepartment.Properties.ValueMember = "DepartmentCode";
            cboOldDepartment.Properties.DisplayMember = "DepartmentName";
            //  cboNewDepartment.Properties.DataSource = dtpb;
            //  cboNewDepartment.Properties.ValueMember = "DepartmentCode";
            // cboNewDepartment.Properties.DisplayMember = "DepartmentName";


            Class.Danhmuc_Chucvu cv = new Class.Danhmuc_Chucvu();
            DataTable dtcv = cv.GetAlllist_Position(); ;
            txtNewPosition.Properties.Items.Clear();
            txtOldPosition.Properties.Items.Clear();
            for (int i = 0; i < dtcv.Rows.Count; i++)
            {
                txtNewPosition.Properties.Items.Add(dtcv.Rows[i]["PositionName"].ToString());
                txtOldPosition.Properties.Items.Add(dtcv.Rows[i]["PositionName"].ToString());
            }


        }

        private void cboNewBranch_EditValueChanged(object sender, EventArgs e)
        {
            Class.DanhMuc_PhongBan pb = new Class.DanhMuc_PhongBan();
            pb.BranchCode = cboNewBranch.EditValue.ToString();
            DataTable dtpb = pb.LoadDanhSachPhongBanThuocChiNhanh();
            cboNewDepartment.Properties.DataSource = dtpb;
            cboNewDepartment.Properties.ValueMember = "DepartmentCode";
            cboNewDepartment.Properties.DisplayMember = "DepartmentName";
        }

        private void cboOldBranch_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_Action != "DanhSach")
            {
                if (cboNewBranch.EditValue == null || cboNewDepartment.EditValue == null || txtNewPosition.EditValue == null)
                {
                    Class.App.InputNotAccess();
                    return;
                }
                Update_ChucVu();
                this.Close();
            }
        }
        private void Update_ChucVu()
        {
            Class.QuaTrinh_ChucVu cv = new Class.QuaTrinh_ChucVu();
            cv.PositionID = txtPositionID.Text;
            cv.EmployeeCode = Class.App._manv;
            cv.OldBranch = cboOldBranch.EditValue.ToString();
            cv.OldDepartment = cboOldDepartment.EditValue.ToString();
            cv.OldGroup = cboOldGroup.EditValue.ToString();
            cv.OldPosition = txtOldPosition.Text;
            cv.NewBranch = cboNewBranch.EditValue.ToString();
            cv.NewDepartment = cboNewDepartment.EditValue.ToString();
            cv.NewGroup = cboNewGroup.EditValue.ToString();
            cv.NewPosition = txtNewPosition.Text;
            cv.Reason = txtReason.Text;
            cv.DecideNumber = txtDecideNumber.Text;
            cv.Date = dateDate.DateTime;
            cv.Person = txtPerson.Text;
            if (txtPositionID.Enabled == true)
            {

                if (cv.Insert())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }

            }
            else
            {
                if (cv.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            if (_Action != "Fast")

              (this.Owner as frmQuaTrinh_ChucVu).Loadthongtincacdotthaydoichucvu();
        }

        
    }
}
