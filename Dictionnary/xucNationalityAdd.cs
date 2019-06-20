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
    public partial class xucNationalityAdd : xucBaseAdd
    {
        public xucNationalityAdd()
        {
            InitializeComponent();
        }


      

        protected override void Add()
        {
            base.Add();
            DIC_NATIONALITY dICNATIONALITY = new DIC_NATIONALITY();
            this.txtID.Text = dICNATIONALITY.NewID();
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


        private void RaiseSuccessEventHander(DIC_NATIONALITY item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_NATIONALITY item)
        {
            this.txtID.Text = item.NationalityCode;
         //   SYS_LOG.Insert("Danh Mục Quốc Tịch", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.NationalityName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

    

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_NATIONALITY dICNATIONALITY = new DIC_NATIONALITY();
                if (this.m_Status == Actions.Add)
                {
                    if (dICNATIONALITY.Exist(textEdit.Text))
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
            DIC_NATIONALITY dICNATIONALITY = new DIC_NATIONALITY()
            {
                NationalityCode = this.txtID.Text
            };
            string str = dICNATIONALITY.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICNATIONALITY);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiNationality") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
              //  SYS_LOG.Insert("Danh Mục Quốc Tịch", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_NATIONALITY dICNATIONALITY = new DIC_NATIONALITY(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICNATIONALITY.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICNATIONALITY);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiNationality") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
             //   SYS_LOG.Insert("Danh Mục Quốc Tịch", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_NATIONALITY dICNATIONALITY = new DIC_NATIONALITY(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICNATIONALITY.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICNATIONALITY);
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

        public event xucNationalityAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_NATIONALITY item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_NATIONALITY()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
