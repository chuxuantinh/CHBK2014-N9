using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucDegreeAdd : xucBaseAdd
    {
        public xucDegreeAdd()
        {
            InitializeComponent();
        }


      

        protected override void Add()
        {
            base.Add();
            DIC_DEGREE dICDEGREE = new DIC_DEGREE();
            this.txtID.Text = dICDEGREE.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtDescription.Text = "";
        }

        private void RaiseSuccessEventHander(DIC_DEGREE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_DEGREE item)
        {
            this.txtID.Text = item.DegreeCode;
           // SYS_LOG.Insert("Danh Mục Bằng Cấp", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.DegreeName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

      

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_DEGREE dICDEGREE = new DIC_DEGREE();
                if (this.m_Status == Actions.Add)
                {
                    if (dICDEGREE.Exist(textEdit.Text))
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
            DIC_DEGREE dICDEGREE = new DIC_DEGREE()
            {
                DegreeCode = this.txtID.Text
            };
            string str = dICDEGREE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICDEGREE);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiDegree") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
               // SYS_LOG.Insert("Danh Mục Bằng Cấp", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_DEGREE dICDEGREE = new DIC_DEGREE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICDEGREE.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICDEGREE);
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
                MyRule.Notify();
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiDegree") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
               // SYS_LOG.Insert("Danh Mục Bằng Cấp", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_DEGREE dICDEGREE = new DIC_DEGREE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICDEGREE.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICDEGREE);
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

        public event xucDegreeAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_DEGREE item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {

            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_DEGREE()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }

        }
    }
}
