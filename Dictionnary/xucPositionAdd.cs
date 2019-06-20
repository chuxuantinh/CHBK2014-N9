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
    public partial class xucPositionAdd : xucBaseAdd
    {
        public xucPositionAdd()
        {
            InitializeComponent();
        }


        protected override void Add()
        {
            base.Add();
            DIC_POSITION dICPOSITION = new DIC_POSITION();
            this.txtID.Text = dICPOSITION.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtDescription.Text = "";
        }


        private void RaiseSuccessEventHander(DIC_POSITION item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_POSITION item)
        {
            this.txtID.Text = item.PositionCode;
         //   SYS_LOG.Insert("Danh Mục Chức Vụ", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.PositionName;
            this.chxManager.Checked = item.IsManager;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_POSITION()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_POSITION dICPOSITION = new DIC_POSITION();
                if (this.m_Status == Actions.Add)
                {
                    if (dICPOSITION.Exist(textEdit.Text))
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
            DIC_POSITION dICPOSITION = new DIC_POSITION()
            {
                PositionCode = this.txtID.Text
            };
            string str = dICPOSITION.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICPOSITION);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiPosition") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
            //    SYS_LOG.Insert("Danh Mục Chức Vụ", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_POSITION dICPOSITION = new DIC_POSITION(this.txtID.Text, this.txtNAME.Text, this.chxManager.Checked, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICPOSITION.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICPOSITION);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiPosition") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
             //  SYS_LOG.Insert("Danh Mục Chức Vụ", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_POSITION dICPOSITION = new DIC_POSITION(this.txtID.Text, this.txtNAME.Text, this.chxManager.Checked, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICPOSITION.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICPOSITION);
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

        public event xucPositionAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_POSITION item);
    }
}
