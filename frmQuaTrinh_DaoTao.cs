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
    public partial class frmQuaTrinh_DaoTao : DevExpress.XtraEditors.XtraForm
    {
        public frmQuaTrinh_DaoTao()
        {
            InitializeComponent();
            Loadquatrinhdaotaocuatungnhanvien();
        }

        public void Loadquatrinhdaotaocuatungnhanvien()
        {
            Class.QuaTrinh_DaoTao qtdt = new Class.QuaTrinh_DaoTao();
            gridItem.DataSource = qtdt.CT_PROCESS_TRAINING_GetListByEmployee();
            gridItemDetail.OptionsView.ColumnAutoWidth = false;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Class.App._manv == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTrainingName.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            Update_DaoTao();
            this.Close();
        }

        private void Update_DaoTao()
        {
            Class.QuaTrinh_DaoTao dtao = new Class.QuaTrinh_DaoTao();
            dtao.TrainingID = txtTrainingID.Text;
            dtao.EmployeeCode = Class.App._manv;
            dtao.TrainingName = txtTrainingName.Text;
            dtao.Reason = txtReason.Text;
            dtao.Form = txtForm.Text;
            dtao.Time = txtTime.Text;
            dtao.BeginDate = dateBeginDate.DateTime;
            dtao.DecideNumber = txtDecideNumber.Text;
            dtao.Date = dateDate.DateTime;
            dtao.Person = txtPerson.Text;

            if (txtTrainingID.Enabled == true)
            {

                if (dtao.Insert())
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
                if (dtao.Update())
                {
                    Class.App.SaveSuccessfully();
                }
                else
                {
                    Class.App.SaveNotSuccessfully();
                }
            }
            Loadquatrinhdaotaocuatungnhanvien();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTrainingName.Text.Length < 1)
            {
                Class.App.InputNotAccess();
                return;
            }
            Update_DaoTao();
            this.Close();

        }
            private string call_Code_New()
        {           
            this.Text = "Thêm Thông tin đào tạo - " + Class.App._hotennv;
            txtTrainingName.Text = "";
            txtReason.Text = "";
            txtForm.Text = "";
            dateBeginDate.DateTime = DateTime.Now;
            dateDate.DateTime=  DateTime.Now;
            return Guid.NewGuid().ToString();
        }

            private void frmQuaTrinh_DaoTao_Load(object sender, EventArgs e)
            {
                txtTrainingID.Text = call_Code_New();
            }
    }
}
