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
    public partial class xucGroupRateAdd : xucBaseAdd
    {
        public xucGroupRateAdd()
        {
            InitializeComponent();
        }

       

        protected override void Add()
        {
            base.Add();
            DIC_GROUP_RATE dICGROUPRATE = new DIC_GROUP_RATE();
            this.txtID.Text = dICGROUPRATE.NewID();
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

        private void RaiseSuccessEventHander(DIC_GROUP_RATE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_GROUP_RATE item)
        {
            this.txtID.Text = item.GroupRateCode;
          //  SYS_LOG.Insert("Nhóm Tiêu Chí", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.GroupRateName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

       

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_GROUP_RATE dICGROUPRATE = new DIC_GROUP_RATE();
                if (this.m_Status == Actions.Add)
                {
                    if (dICGROUPRATE.Exist(textEdit.Text))
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
            DIC_GROUP_RATE dICGROUPRATE = new DIC_GROUP_RATE()
            {
                GroupRateCode = this.txtID.Text
            };
            string str = dICGROUPRATE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICGROUPRATE);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiJob") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
              //  SYS_LOG.Insert("Nhóm Tiêu Chí", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_GROUP_RATE dICGROUPRATE = new DIC_GROUP_RATE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICGROUPRATE.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICGROUPRATE);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiJob") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
              //  SYS_LOG.Insert("Nhóm Tiêu Chí", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_GROUP_RATE dICGROUPRATE = new DIC_GROUP_RATE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICGROUPRATE.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICGROUPRATE);
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

        public event xucGroupRateAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_GROUP_RATE item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_GROUP_RATE()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
