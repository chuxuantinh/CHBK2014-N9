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
    public partial class frmDanhMuc_KyNang : DevExpress.XtraEditors.XtraForm
    {
        string _FormName = "";
        public string _reCallFunction;
        public frmDanhMuc_KyNang()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_KyNang_Load(object sender, EventArgs e)
        {
            Loadlistskill();
        }

        private void Loadlistskill()
        {

            Class.DanhMuc_KyNang dmkn = new Class.DanhMuc_KyNang();
            gridItem.DataSource = dmkn.GetAllList_SKILL();

        }

        private void groupItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridItem_Click(object sender, EventArgs e)
        {

        }



     

        private void groupItem_DoubleClick(object sender, EventArgs e)
        {
         int SelectedRow = gridItemDetail.FocusedRowHandle;
         if (SelectedRow >= 0)
         {
             DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
             string _value = drow["SkillCode"].ToString();

             txtCode.Text = _value;
         }
        }

        private void gridItem_MouseClick(object sender, MouseEventArgs e)
        {
            int SelectedRow = gridItemDetail.FocusedRowHandle;
            if (SelectedRow >= 0)
            {
                DataRow drow = gridItemDetail.GetDataRow(SelectedRow);
                string _value = drow["SkillCode"].ToString();

                txtCode.Text = _value;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = Class.DbConnection._cnn;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "CT_SKILL_Insert";
            cmd.Parameters.Add("@SkillCode", SqlDbType.VarChar, 20).Value = txtCode.Text.ToString();
            cmd.Parameters.Add("@SkillName", SqlDbType.NVarChar, 100).Value = txtName.Text.ToString();
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 255).Value = txtDescription.Text.ToString();
            cmd.Parameters.Add("@Active", SqlDbType.Bit,1).Value= checkActive.Checked;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

      
    }
}
