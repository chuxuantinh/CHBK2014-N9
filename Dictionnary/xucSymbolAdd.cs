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
    public partial class xucSymbolAdd : xucBaseAdd
    {
        protected override void Add()
        {
            base.Add();
            DIC_SYMBOL dICSYMBOL = new DIC_SYMBOL();
            this.txtID.Text = dICSYMBOL.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtNAME.Properties.ReadOnly = false;
            this.txtDescription.Text = "";
        }

        public xucSymbolAdd()
        {
            this.InitializeComponent();
        }

        protected override void Init()
        {
        }

        private void RaiseSuccessEventHander(DIC_SYMBOL item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_SYMBOL item)
        {
            this.txtID.Text = item.SymbolCode;
          //  SYS_LOG.Insert("Danh Mục Ký Hiệu Chấm Công", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            if (!item.IsEdit)
            {
                this.txtNAME.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.SymbolName;
            this.calPercentSalary.Text = item.PercentSalary.ToString();
            this.cheIsEdit.Checked = item.IsEdit;
            this.cheIsShow.Checked = item.IsShow;
            this.txtDescription.Text = item.Description;
        }

      

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_SYMBOL dICSYMBOL = new DIC_SYMBOL();
                if (this.m_Status == Actions.Add)
                {
                    if (dICSYMBOL.Exist(textEdit.Text))
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
            DIC_SYMBOL dICSYMBOL = new DIC_SYMBOL()
            {
                SymbolCode = this.txtID.Text
            };
            string str = dICSYMBOL.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICSYMBOL);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiSymbol") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
               // SYS_LOG.Insert("Danh Mục Ký Hiệu Chấm Công", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_SYMBOL dICSYMBOL = new DIC_SYMBOL(this.txtID.Text, this.txtNAME.Text, double.Parse(this.calPercentSalary.Text), this.cheIsEdit.Checked, this.cheIsShow.Checked, this.txtDescription.Text);
                string str1 = dICSYMBOL.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICSYMBOL);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiSymbol") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
              //  SYS_LOG.Insert("Danh Mục Ký Hiệu Chấm Công", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_SYMBOL dICSYMBOL = new DIC_SYMBOL(this.txtID.Text, this.txtNAME.Text, double.Parse(this.calPercentSalary.Text), this.cheIsEdit.Checked, this.cheIsShow.Checked, this.txtDescription.Text);
                string str1 = dICSYMBOL.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICSYMBOL);
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

        private void xucSymbolAdd_Load(object sender, EventArgs e)
        {
        }

        public event xucSymbolAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_SYMBOL item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_SYMBOL()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
