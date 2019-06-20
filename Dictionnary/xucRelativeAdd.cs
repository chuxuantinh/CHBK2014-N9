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
    public partial class xucRelativeAdd : xucBaseAdd
    {
        public xucRelativeAdd()
        {
            InitializeComponent();
        }

        protected override void Add()
        {
            base.Add();
            DIC_RELATIVE dICRELATIVE = new DIC_RELATIVE();
            this.txtID.Text = dICRELATIVE.NewID();
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


        private void RaiseSuccessEventHander(DIC_RELATIVE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_RELATIVE item)
        {
            this.txtID.Text = item.RelativeCode;
         //   SYS_LOG.Insert("Danh Mục Mối Quan Hệ Gia Đình", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.RelativeName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

     

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_RELATIVE dICRELATIVE = new DIC_RELATIVE();
                if (this.m_Status == Actions.Add)
                {
                    if (dICRELATIVE.Exist(textEdit.Text))
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
            DIC_RELATIVE dICRELATIVE = new DIC_RELATIVE()
            {
                RelativeCode = this.txtID.Text
            };
            string str = dICRELATIVE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICRELATIVE);
            }
            return str;
        }

        protected override string uc_Save()
        {
          //  SYS_LOG.Insert("Danh Mục Mối Quan Hệ Gia Đình", "Thêm", this.txtID.Text);
            base.SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            DIC_RELATIVE dICRELATIVE = new DIC_RELATIVE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
            string str = dICRELATIVE.Insert();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICRELATIVE);
            }
            Cursor.Current = Cursors.Default;
            this.DoHide();
            if (str != "OK")
            {
                XtraMessageBox.Show(str, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return str;
        }

        protected override string uc_Update()
        {
          //  SYS_LOG.Insert("Danh Mục Mối Quan Hệ Gia Đình", "Cập Nhật", this.txtID.Text);
            base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            DIC_RELATIVE dICRELATIVE = new DIC_RELATIVE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
            string str = dICRELATIVE.Update();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICRELATIVE);
            }
            if (str != "OK")
            {
                XtraMessageBox.Show(str, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.DoHide();
            return str;
        }

        public event xucRelativeAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_RELATIVE item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_RELATIVE()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
