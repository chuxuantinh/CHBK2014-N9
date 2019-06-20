using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucStepAdd : xucBaseAdd
    {
        public xucStepAdd()
        {
            this.InitializeComponent();
            this.InitData();
            this.calCoefficient.EditValue = 0;
        }

        protected override void Add()
        {
            base.Add();
            try
            {
                DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP();
                this.SetID(dICSALARYSTEP.NewID(this.glkRank.EditValue.ToString()));
            }
            catch
            {
            }
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.calCoefficient.EditValue = 0;
            this.txtDescription.Text = "";
        }

      

        private void glkRank_EditValueChanged(object sender, EventArgs e)
        {
            if (this.txtID.ErrorText != string.Empty)
            {
                this.Err.SetError(this.txtID, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP();
                this.SetID(dICSALARYSTEP.NewID(this.glkRank.EditValue.ToString()));
                if (dICSALARYSTEP.Exist(this.txtID.Text, this.glkRank.EditValue.ToString()))
                {
                    this.Err.SetError(this.txtID, "Mã đã tồn tại.");
                    this.txtID.Focus();
                }
            }
        }

        protected override void Init()
        {
        }

        private void InitData()
        {
            DataTable list = (new DIC_SALARY_RANK()).GetList();
            this.glkRank.Properties.DataSource = list;
        }


        private void RaiseSuccessEventHander(DIC_SALARY_STEP item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_SALARY_STEP item)
        {
            this.txtID.Text = item.StepCode.ToString();
            this.glkRank.EditValue = item.RankCode;
          //  SYS_LOG.Insert("Danh Mục Bậc Lương", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
                this.glkRank.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.StepName;
            this.calCoefficient.Text = item.Coefficient.ToString();
            this.txtDescription.Text = item.Description;
        }

        public void SetID(string id)
        {
            this.txtID.Text = Convert.ToInt32(id).ToString();
            this.txtNAME.Text = string.Concat("Bậc ", Convert.ToInt32(id));
        }

      

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP();
                if (this.m_Status == Actions.Add)
                {
                    if (dICSALARYSTEP.Exist(textEdit.Text, this.glkRank.EditValue.ToString()))
                    {
                        this.Err.SetError(textEdit, "Mã đã tồn tại.");
                        textEdit.Focus();
                    }
                }
            }
        }

        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP()
            {
                StepCode = int.Parse(this.txtID.Text)
            };
            DIC_SALARY_STEP dICSALARYSTEP1 = dICSALARYSTEP;
            string str = dICSALARYSTEP1.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICSALARYSTEP1);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiStep") != "OK")
            {
                str = "";
            }
            else if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                str = "";
            }
            else if (this.glkRank.EditValue != null)
            {
              //  SYS_LOG.Insert("Danh Mục Bậc Lương", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP(int.Parse(this.txtID.Text), this.glkRank.EditValue.ToString(), this.txtNAME.Text, double.Parse(this.calCoefficient.Text), this.txtDescription.Text);
                string str1 = dICSALARYSTEP.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICSALARYSTEP);
                }
                Cursor.Current = Cursors.Default;
                this.DoHide();
                if (str1 != "OK")
                {
                    XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                str = str1;
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn ngạch lương tương ứng!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiStep") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
             //   SYS_LOG.Insert("Danh Mục Bậc Lương", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP(int.Parse(this.txtID.Text), this.glkRank.EditValue.ToString(), this.txtNAME.Text, double.Parse(this.calCoefficient.Text), this.txtDescription.Text);
                string str1 = dICSALARYSTEP.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICSALARYSTEP);
                }
                if (str1 != "OK")
                {
                    XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.DoHide();
                str = str1;
            }
            else
            {
                MyRule.Notify();
                str = "";
            }
            return str;
        }

        public event xucStepAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_SALARY_STEP item);

        private void txtID_EditValueChanged_1(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP();
                if (this.glkRank.EditValue != null)
                {
                    if (dICSALARYSTEP.Exist(textEdit.Text, this.glkRank.EditValue.ToString()))
                    {
                        this.Err.SetError(textEdit, "Mã đã tồn tại.");
                        textEdit.Focus();
                    }
                }
            }
        }
    }
}
