using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class xucMachineAdd : xucBaseAdd
    {
        public xucMachineAdd()
        {
            InitializeComponent();
        }

       

        protected override void Add()
        {
            base.Add();
            DIC_MACHINE dICMACHINE = new DIC_MACHINE();
            this.txtID.Text = dICMACHINE.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtPortID.Text = "";
            this.txtIP.Text = "";
            this.txtPassword.Text = "";
        }

        protected override void Init()
        {
        }


        private void RaiseSuccessEventHander(DIC_MACHINE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_MACHINE item)
        {
            this.txtID.Text = item.MachineCode;
          //  SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.MachineName;
            this.cboPortType.Text = item.PortType;
            this.txtPortID.Text = item.PortID;
            this.txtIP.Text = item.IP;
            this.txtPassword.Text = item.Password;
            this.cboCom.Text = item.Com;
        }

      

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_MACHINE dICMACHINE = new DIC_MACHINE();
                if (this.m_Status == Actions.Add)
                {
                    if (dICMACHINE.Exist(textEdit.Text))
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
            DIC_MACHINE dICMACHINE = new DIC_MACHINE()
            {
                MachineCode = this.txtID.Text
            };
            string str = dICMACHINE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICMACHINE);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiMachine") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
              //  SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_MACHINE dICMACHINE = new DIC_MACHINE(this.txtID.Text, this.txtNAME.Text, this.cboPortType.Text, this.txtPortID.Text, this.txtIP.Text, this.txtPassword.Text, this.cboCom.Text);
                string str1 = dICMACHINE.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICMACHINE);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiMachine") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
              //  SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_MACHINE dICMACHINE = new DIC_MACHINE(this.txtID.Text, this.txtNAME.Text, this.cboPortType.Text, this.txtPortID.Text, this.txtIP.Text, this.txtPassword.Text, this.cboCom.Text);
                string str1 = dICMACHINE.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICMACHINE);
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

        public event xucMachineAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_MACHINE item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_MACHINE()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
