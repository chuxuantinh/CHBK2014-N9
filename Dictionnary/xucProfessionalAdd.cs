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
    public partial class xucProfessionalAdd : xucBaseAdd
    {
        public xucProfessionalAdd()
        {
            InitializeComponent();
        }


        protected override void Add()
        {
            base.Add();
            DIC_PROFESSIONAL dICPROFESSIONAL = new DIC_PROFESSIONAL();
            this.txtID.Text = dICPROFESSIONAL.NewID();
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


        private void RaiseSuccessEventHander(DIC_PROFESSIONAL item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_PROFESSIONAL item)
        {
            this.txtID.Text = item.ProfessionalCode;
        //    SYS_LOG.Insert("Danh Mục Chuyên Môn", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.ProfessionalName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

       

        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            DIC_PROFESSIONAL dICPROFESSIONAL = new DIC_PROFESSIONAL()
            {
                ProfessionalCode = this.txtID.Text
            };
            string str = dICPROFESSIONAL.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICPROFESSIONAL);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiProfessional") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
               // SYS_LOG.Insert("Danh Mục Chuyên Môn", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_PROFESSIONAL dICPROFESSIONAL = new DIC_PROFESSIONAL(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICPROFESSIONAL.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICPROFESSIONAL);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiProfessional") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
             //   SYS_LOG.Insert("Danh Mục Chuyên Môn", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_PROFESSIONAL dICPROFESSIONAL = new DIC_PROFESSIONAL(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICPROFESSIONAL.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICPROFESSIONAL);
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

        public event xucProfessionalAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_PROFESSIONAL item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_PROFESSIONAL()).Exist(textEdit.Text))
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
                DIC_PROFESSIONAL dICPROFESSIONAL = new DIC_PROFESSIONAL();
                if (this.m_Status == Actions.Add)
                {
                    if (dICPROFESSIONAL.Exist(textEdit.Text))
                    {
                        this.Err.SetError(textEdit, "Mã đã tồn tại.");
                        textEdit.Focus();
                    }
                }
            }
        }
    }
}
