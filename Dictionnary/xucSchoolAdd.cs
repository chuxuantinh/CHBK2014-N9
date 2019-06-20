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
    public partial class xucSchoolAdd : xucBaseAdd
    {
       


        public xucSchoolAdd()
        {
            this.InitializeComponent();
        }

        protected override void Add()
        {
            base.Add();
            DIC_SCHOOL dICSCHOOL = new DIC_SCHOOL();
            this.txtID.Text = dICSCHOOL.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtDescription.Text = "";
        }
        protected override void Init()
        {
        }

        private void RaiseSuccessEventHander(DIC_SCHOOL item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_SCHOOL item)
        {
            this.txtID.Text = item.SchoolCode;
          //  SYS_LOG.Insert("Danh Mục Trường Học", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.SchoolName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

       

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_SCHOOL dICSCHOOL = new DIC_SCHOOL();
                if (this.m_Status == Actions.Add)
                {
                    if (dICSCHOOL.Exist(textEdit.Text))
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
            DIC_SCHOOL dICSCHOOL = new DIC_SCHOOL()
            {
                SchoolCode = this.txtID.Text
            };
            string str = dICSCHOOL.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICSCHOOL);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiSchool") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
               // SYS_LOG.Insert("Danh Mục Trường Học", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_SCHOOL dICSCHOOL = new DIC_SCHOOL(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICSCHOOL.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICSCHOOL);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiSchool") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
               // SYS_LOG.Insert("Danh Mục Trường Học", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_SCHOOL dICSCHOOL = new DIC_SCHOOL(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICSCHOOL.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICSCHOOL);
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

        public event xucSchoolAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_SCHOOL item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_SCHOOL()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
