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
    public partial class frmDanhMuc_PhongBan_Update : Form
    {
        public string _reCallFunction;
        public frmDanhMuc_PhongBan_Update()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text.Length < 1 || txtBranchName.EditValue == null)
            {
                Class.App.InputNotAccess();
                return;
            }
            Class.DanhMuc_PhongBan dm = new Class.DanhMuc_PhongBan();
            dm.DepartmentCode = txtDepartmentCode.Text;
            dm.DepartmentName = txtDepartmentName.Text;
            dm.BranchCode = txtBranchName.EditValue.ToString();
            dm.Phone = txtPhone.Text;
            dm.Quantity = int.Parse(txtQuantity.Text);
            dm.FactQuantity = int.Parse(txtFactQuantity.Text);
            dm.Description = txtDescription.Text;

            if (txtDepartmentCode.Enabled == true)
            {
                if (dm.Insert())
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
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }

            //if (_reCallFunction == "frmDanhMuc_PhongBan")
            //{
            //    (this.Owner as frmDanhMuc_PhongBan).GetAllList_DEPARTMENT();
            //}
           
            this.Close();
        }

        private void frmDanhMuc_PhongBan_Update_Load(object sender, EventArgs e)
        {
           GetList_Branch();
           // Call_code_new();
        }

        public frmDanhMuc_PhongBan_Update(bool Add_new, string Caption_name, string Form_name, string Code,string reCallFunction)
        {
            InitializeComponent();
            this.Text = Caption_name;
         // call danh sach chi nhanh
            if (Add_new)
            {
             
                txtDepartmentCode.Text = Call_code_new();
            }
            else
            {
               call_info(Form_name, Code);
                txtDepartmentCode.Enabled = false;
            }
            _reCallFunction = reCallFunction;


        }

        private string Call_code_new()

        {
            txtDepartmentName.Text = "";
            txtPhone.Text = "";
            txtFactQuantity.Text = "0";
            txtQuantity.Text = "0";
            txtDescription.Text = "";
            this.Text = "Thêm Phòng ban";
        Class.DanhMuc_PhongBan dm = new Class.DanhMuc_PhongBan();
        return dm.GetNewCode();
      
        }

        private void Loadchinhanh()
        {

            Class.DanhMuc_PhongBan cn = new Class.DanhMuc_PhongBan();
            DataTable dt = cn.LoadDanhSachChiNhanh();
            if (dt.Rows.Count >0)
            {
                txtBranchName.Properties.DataSource = dt;
                txtBranchName.Properties.DisplayMember = "BrandName";
                txtBranchName.Properties.ValueMember = "BranchCode";    

            }

        }
        private void call_info(string Form_name, string code)
        {
           Class.DanhMuc_PhongBan dm = new Class.DanhMuc_PhongBan();
            DataTable dt = dm.GetDepartmentByCode(code);
            txtDepartmentCode.Text = dt.Rows[0]["DepartmentCode"].ToString();
            txtDepartmentName.Text = dt.Rows[0]["DepartmentName"].ToString();
       //     txtBranchName.EditValue = dt.Rows[0]["BranchCode"].ToString();
            txtBranchName.Text = dt.Rows[0]["BranchCode"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtQuantity.Text = dt.Rows[0]["Quantity"].ToString();
            txtFactQuantity.Text = dt.Rows[0]["FactQuantity"].ToString();
            txtDescription.Text = dt.Rows[0]["Description"].ToString();

        }

        private void txtBranchName_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void txtBranchName_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtBranchName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmDanhMuc_ChiNhanh frm = new frmDanhMuc_ChiNhanh();
            frm.ShowDialog();
        }

        private void btnUpdateNew_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        public void GetList_Branch()
        {
            Class.DanhMuc_ChiNhanh dm = new Class.DanhMuc_ChiNhanh();
            DataTable dt = dm.Danhsachchinhanh();
            txtBranchName.Properties.DataSource = dt;
            txtBranchName.Properties.DisplayMember = "BranchName";
            txtBranchName.Properties.ValueMember = "BranchCode";
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text.Length < 1 || txtBranchName.EditValue == null)
            {
                Class.App.InputNotAccess();
                return;
            }
            Class.DanhMuc_PhongBan dm = new Class.DanhMuc_PhongBan();
            dm.DepartmentCode = txtDepartmentCode.Text;
            dm.DepartmentName = txtDepartmentName.Text;
            dm.BranchCode = txtBranchName.EditValue.ToString();
            dm.Phone = txtPhone.Text;
            dm.Quantity = int.Parse(txtQuantity.Text);
            dm.FactQuantity = int.Parse(txtFactQuantity.Text);
            dm.Description = txtDescription.Text;

            if (txtDepartmentCode.Enabled == true)
            {
                if (dm.Insert())
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
                if (dm.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }

            //if (_reCallFunction == "frmDanhMuc_PhongBan")
            //{
            //    (this.Owner as frmDanhMuc_PhongBan).GetAllList_DEPARTMENT();
            //}

            this.Close();
        }

        
       

       

       

       
    }


}
