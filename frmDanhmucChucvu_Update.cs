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
    public partial class frmDanhmucChucvu_Update : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhmucChucvu_Update()
        {
            InitializeComponent();

        }

        private void frmDanhmucChucvu_Update_Load(object sender, EventArgs e)
        {

        }
        
        public frmDanhmucChucvu_Update(bool Add_new, string Caption_name, string Form_name, string code)

        {
            InitializeComponent();
            this.Name = Caption_name;
            if (Add_new)
            {

                txtCode.Text = call_Code_New();

            }

            else
            {

                call_info(Form_name, code);
                txtCode.Enabled = false;
            }
        
        }

        private string call_Code_New()
        {
            Class.Danhmuc_Chucvu dmcv = new Class.Danhmuc_Chucvu();
            return dmcv.GetNewCode();
        }

        private void call_info(string Form_name, string code)
        {

            Class.Danhmuc_Chucvu dmcv = new Class.Danhmuc_Chucvu();
            DataTable dt=  dmcv.GetPositionByCode(code);
            txtCode.Text= dt.Rows[0]["PositionCode"].ToString();
            txtName.Text = dt.Rows[0]["PositionName"].ToString();
            checkIsManager.Checked = (bool)dt.Rows[0]["IsManager"];
            txtDescription.Text = dt.Rows[0]["Description"].ToString();
            checkActive.Checked = (bool)dt.Rows[0]["Active"];


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             
            if (txtName.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            Class.Danhmuc_Chucvu dmcv = new Class.Danhmuc_Chucvu();
            dmcv.PositionCode = txtCode.Text;
            dmcv.PositionName = txtName.Text;
            dmcv.IsManager = checkIsManager.Checked;
            dmcv.Description = txtDescription.Text;
            dmcv.Active = checkActive.Checked;
            if (txtCode.Enabled== true)
            {
                if (dmcv.Insert())
                {

                    Class.App.SaveSuccessfully();

                }
                else { Class.App.SaveNotSuccessfully(); }
                if (dmcv.Update())
                {

                    Class.App.SaveSuccessfully();

                }
                else
                { Class.App.SaveNotSuccessfully(); }

                (this.Owner as frmDanhMuc_ChucVu).GetAllList_Position();
                this.Close();
                    

            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateNew_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            Class.Danhmuc_Chucvu dmcv = new Class.Danhmuc_Chucvu();
            dmcv.PositionCode = txtCode.Text;
            dmcv.PositionName = txtName.Text;
            dmcv.IsManager = checkIsManager.Checked;
            dmcv.Description = txtDescription.Text;
            dmcv.Active = checkActive.Checked;
            if (txtCode.Enabled == true)
            {
                if (dmcv.Insert())
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
                if (dmcv.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            // xac dinh du lieu co thay doi de reload form danh muc.
            (this.Owner as frmDanhMuc_ChucVu).GetAllList_Position();
            txtCode.Enabled = true;
            txtName.Text = "";
            txtDescription.Text = "";
            this.Text = "Thêm chức vụ";
            txtCode.Text = call_Code_New();
        }

    }
}
