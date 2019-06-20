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
    public partial class xucInformaticAdd : xucBaseAdd
    {
        public xucInformaticAdd()
        {
            InitializeComponent();
        }


        

        protected override void Add()
        {
            base.Add();
            DIC_INFORMATIC dICINFORMATIC = new DIC_INFORMATIC();
            this.txtID.Text = dICINFORMATIC.NewID();
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



        private void RaiseSuccessEventHander(DIC_INFORMATIC item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_INFORMATIC item)
        {
            this.txtID.Text = item.InformaticCode;
          //  SYS_LOG.Insert("Danh Mục Tin Học", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.InformaticName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

    

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_INFORMATIC dICINFORMATIC = new DIC_INFORMATIC();
                if (this.m_Status == Actions.Add)
                {
                    if (dICINFORMATIC.Exist(textEdit.Text))
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
            DIC_INFORMATIC dICINFORMATIC = new DIC_INFORMATIC()
            {
                InformaticCode = this.txtID.Text
            };
            string str = dICINFORMATIC.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICINFORMATIC);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiInformatic") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
               // SYS_LOG.Insert("Danh Mục Tin Học", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_INFORMATIC dICINFORMATIC = new DIC_INFORMATIC(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICINFORMATIC.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICINFORMATIC);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiInformatic") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
               // SYS_LOG.Insert("Danh Mục Tin Học", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_INFORMATIC dICINFORMATIC = new DIC_INFORMATIC(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICINFORMATIC.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICINFORMATIC);
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



        public event xucInformaticAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_INFORMATIC item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_INFORMATIC()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
