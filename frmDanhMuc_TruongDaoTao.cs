using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHBK2014_N9
{
    public partial class frmDanhMuc_TruongDaoTao : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMuc_TruongDaoTao()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_TruongDaoTao_Load(object sender, EventArgs e)
        {

            LoadTruongDaoTao();
            txtCode.Text = LayCode();


        }

        private void LoadTruongDaoTao()
        {


            Class.DanhMuc_TruongDaoTao dmtdt = new Class.DanhMuc_TruongDaoTao();
            gridControl1.DataSource = dmtdt.GetAllList_SCHOOL();

        }

        private string LayCode()
        {
           string code = null;
            Class.DanhMuc_TruongDaoTao dm = new Class.DanhMuc_TruongDaoTao();
           code= dm.GetNewCode();

           return code;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Class.DanhMuc_TruongDaoTao dm = new Class.DanhMuc_TruongDaoTao();
            dm.SchoolCode = txtCode.Text;
            dm.SchoolName = txtName.Text;
            dm.Description = txtDescription.Text;
            dm.Active = checkActive.Checked;
            if (txtCode.Enabled==true)
            {
                if (dm.Insert())
                {
                    Class.App.SaveSuccessfully();
                    LoadTruongDaoTao();
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
                    LoadTruongDaoTao();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int selectedrow = gridView1.FocusedRowHandle;
            if (selectedrow > 0)
            {

                DataRow dr = gridView1.GetDataRow(selectedrow);
                txtCode.Text = dr["SchoolCode"].ToString();
                txtName.Text = dr["SchoolName"].ToString();
                txtDescription.Text = dr["Description"].ToString();
            }

        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int selectedrow = gridView1.FocusedRowHandle;
            if (selectedrow >0)
            {

                DataRow dr = gridView1.GetDataRow(selectedrow);
               txtCode.Text = dr["SchoolCode"].ToString();
               txtName.Text = dr["SchoolName"].ToString();
               txtDescription.Text = dr["Description"].ToString();


            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
