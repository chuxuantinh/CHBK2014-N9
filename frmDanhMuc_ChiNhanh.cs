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
    public partial class frmDanhMuc_ChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMuc_ChiNhanh()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_ChiNhanh_Load(object sender, EventArgs e)
        {
            Load_ChiNhanh();
           
            txtBranchCode.Text = call_Code_New();
        }

        private void Load_ChiNhanh()
        {
            Class.DanhMuc_ChiNhanh dmcn = new Class.DanhMuc_ChiNhanh();
            gridItem.DataSource = dmcn.Danhsachchinhanh();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBranchCode.Text.Length < 1 || txtBranchName.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            Class.DanhMuc_ChiNhanh dm = new Class.DanhMuc_ChiNhanh();
            dm.BranchCode = txtBranchCode.Text;
            dm.BranchName = txtBranchName.Text;
            dm.Address = txtAddress.Text;
            dm.Phone = txtPhone.Text;
            dm.Fax = txtFax.Text;
            dm.MinimumSalary = txtMinimumSalary.Value;
            dm.PersonName = txtPersonName.Text;
            dm.Quantity = int.Parse(txtQuantity.Text);
            dm.FactQuantity = int.Parse(txtFactQuantity.Text);
            dm.Description = txtDescription.Text;

            if (txtBranchCode.Enabled == true)
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
            Load_ChiNhanh();
            txtBranchCode.Text = call_Code_New();
            txtBranchCode.Enabled = true;
        }

        private void call_info(string Form_name, string code)
        {
            Class.DanhMuc_ChiNhanh dm = new Class.DanhMuc_ChiNhanh();
            DataTable dt = dm.GetBranchByCode(code);
            txtBranchCode.Text = dt.Rows[0]["BranchCode"].ToString();
            txtBranchName.Text = dt.Rows[0]["BranchName"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            txtFax.Text = dt.Rows[0]["Fax"].ToString();
            txtMinimumSalary.Value = (decimal)dt.Rows[0]["MinimumSalary"];
            txtPersonName.Text = dt.Rows[0]["PersonName"].ToString();
            txtQuantity.Text = dt.Rows[0]["Quantity"].ToString();
            txtFactQuantity.Text = dt.Rows[0]["FactQuantity"].ToString();
            txtDescription.Text = dt.Rows[0]["Description"].ToString();

        }
        private string call_Code_New()
        {
            txtBranchCode.Text = "";
            txtBranchName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";
            txtMinimumSalary.Value = 0;
            txtPersonName.Text = "";
            txtFactQuantity.Text = "0";
            txtQuantity.Text = "0";
            txtDescription.Text = "";
            this.Text = "Thêm Chi nhánh";
            Class.DanhMuc_ChiNhanh dm = new Class.DanhMuc_ChiNhanh();
            return dm.GetNewCode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["BranchCode"].ToString();
                if (Class.App.ConfirmDeletion("Bạn chắc muốn xóa thông tin Chi nhánh này không ? \n Lưu ý: Mọi thông tin Phòng ban, Nhóm, Nhân Viên thuộc chi nhánh này sẽ bị xóa hết !") == DialogResult.No)
                    return;

                Class.DanhMuc_ChiNhanh dm = new Class.DanhMuc_ChiNhanh();
                dm.BranchCode = _value;
                if (dm.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    Load_ChiNhanh();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!btnEdit.Enabled)
                return;
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["BranchCode"].ToString();

               
            }
        }

        private void gridItem_DoubleClick(object sender, EventArgs e)
        {
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["BranchCode"].ToString();
                call_info("", _value);
                txtBranchCode.Enabled = false;

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtBranchCode.Text.Length < 1 || txtBranchName.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            Class.DanhMuc_ChiNhanh dm = new Class.DanhMuc_ChiNhanh();
            dm.BranchCode = txtBranchCode.Text;
            dm.BranchName = txtBranchName.Text;
            dm.Address = txtAddress.Text;
            dm.Phone = txtPhone.Text;
            dm.Fax = txtFax.Text;
            dm.MinimumSalary = txtMinimumSalary.Value;
            dm.PersonName = txtPersonName.Text;
            dm.Quantity = int.Parse(txtQuantity.Text);
            dm.FactQuantity = int.Parse(txtFactQuantity.Text);
            dm.Description = txtDescription.Text;

            if (txtBranchCode.Enabled == true)
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
            Load_ChiNhanh();
            txtBranchCode.Text = call_Code_New();
            txtBranchCode.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int selectedrow = gridItemDetail.FocusedRowHandle;
            if (selectedrow >0)
            {

                DataRow dr = gridItemDetail.GetDataRow(selectedrow);
                string _value = dr["BrandCode"].ToString();

                if (Class.App.ConfirmDeletion("Bạn chắc muốn xóa thông tin Chi nhánh này không ? \n Lưu ý: Mọi thông tin Phòng ban, Nhóm, Nhân Viên thuộc chi nhánh này sẽ bị xóa hết !") == DialogResult.No)
                    return;

                Class.DanhMuc_ChiNhanh dmcn = new Class.DanhMuc_ChiNhanh();
                dmcn.BranchCode = _value;
                if (dmcn.Delete())
                {
                    Class.App.DeleteSuccessfully();
                    Load_ChiNhanh();
                }
                else
                {
                    Class.App.DeleteNotSuccessfully();
                }
            }
        }

    }
}
