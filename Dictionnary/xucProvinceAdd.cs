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
    public partial class xucProvinceAdd : xucBaseAdd
    {
        public xucProvinceAdd()
        {
            InitializeComponent();
        }

        protected override void Add()
        {
            base.Add();
            DIC_PROVINCE dICPROVINCE = new DIC_PROVINCE();
            this.txtID.Text = dICPROVINCE.NewID();
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

        private void RaiseSuccessEventHander(DIC_PROVINCE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_PROVINCE item)
        {
            this.txtID.Text = item.ProvinceCode;
       //     SYS_LOG.Insert("Danh Mục Tỉnh", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.ProvinceName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

      

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_PROVINCE dICPROVINCE = new DIC_PROVINCE();
                if (this.m_Status == Actions.Add)
                {
                    if (dICPROVINCE.Exist(textEdit.Text))
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
            DIC_PROVINCE dICPROVINCE = new DIC_PROVINCE()
            {
                ProvinceCode = this.txtID.Text
            };
            string str = dICPROVINCE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICPROVINCE);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiProvince") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
              //  SYS_LOG.Insert("Danh Mục Tỉnh", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_PROVINCE dICPROVINCE = new DIC_PROVINCE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICPROVINCE.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICPROVINCE);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiProvince") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
             //   SYS_LOG.Insert("Danh Mục Tỉnh", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_PROVINCE dICPROVINCE = new DIC_PROVINCE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICPROVINCE.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICPROVINCE);
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

        public event xucProvinceAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_PROVINCE item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_PROVINCE()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
