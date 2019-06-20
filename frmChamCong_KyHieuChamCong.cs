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
    public partial class frmChamCong_KyHieuChamCong : Form
    {
        public frmChamCong_KyHieuChamCong()
        {
            InitializeComponent();
        }

        private void frmChamCong_KyHieuChamCong_Load(object sender, EventArgs e)
        {
            Get_List_KyHieu();
        }

        private void Get_List_KyHieu()
        {
            Class.DanhMuc_KyHieuChamCong dmcc = new Class.DanhMuc_KyHieuChamCong();
            gridItem.DataSource = dmcc.CT_SYMBOL_GetList();

        }

        private void gridItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtName.Text.Length < 1 || txtCode.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            Update_Symbol();
            this.Close();
        }

        private void Update_Symbol()
        {
            Class.DanhMuc_KyHieuChamCong dm = new Class.DanhMuc_KyHieuChamCong();
            dm.SymbolCode = txtCode.Text;
            dm.SymbolName = txtName.Text;
            dm.PercentSalary = 0;
            dm.IsEdit = false;
            dm.Description = txtDescription.Text;
            if (txtCode.Enabled == true)
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

            Get_List_KyHieu();

        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtName.Text.Length < 1 || txtCode.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            Update_Symbol();
            txtCode.Enabled = true;
            txtName.Text = "";
            txtDescription.Text = "";
            this.Text = "Thêm ký hiệu chấm công";
            txtCode.Text = call_Code_New();
        }

        private string call_Code_New()
        {
            Class.DanhMuc_KyHieuChamCong dm = new Class.DanhMuc_KyHieuChamCong();
            return dm.GetNewCode();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Class.DanhMuc_KyHieuChamCong dm = new Class.DanhMuc_KyHieuChamCong();
            gridItem.DataSource = dm.CT_SYMBOL_GetList();
            int selectedrow = gridItemDetail.FocusedRowHandle;
            if (selectedrow>0)
            {
                DataRow dr= gridItemDetail.GetDataRow(selectedrow);
                string _code = dr["SymbolCode"].ToString();
                DataTable dt = dm.GetSymbolByCode(_code);
                txtCode.Text = dt.Rows[0]["SymbolCode"].ToString();
                txtName.Text = dt.Rows[0]["SymbolName"].ToString();
                txtDescription.Text = dt.Rows[0]["Description"].ToString();
            }
            Update_Symbol();
        }
    }
}
