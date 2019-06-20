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
    public partial class xucUnitAdd : xucBaseAdd
    {
        public xucUnitAdd()
        {
            InitializeComponent();
        }

        protected override void Add()
        {
            base.Add();
            DIC_UNIT dICUNIT = new DIC_UNIT();
            this.txtID.Text = dICUNIT.NewID();
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

        private void RaiseSuccessEventHander(DIC_UNIT item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_UNIT item)
        {
            this.txtID.Text = item.UnitCode;
          //  SYS_LOG.Insert("Danh Mục Đơn Vị Tính", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.UnitName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

     

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_UNIT dICUNIT = new DIC_UNIT();
                if (this.m_Status == Actions.Add)
                {
                    if (dICUNIT.Exist(textEdit.Text))
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
            DIC_UNIT dICUNIT = new DIC_UNIT()
            {
                UnitCode = this.txtID.Text
            };
            string str = dICUNIT.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICUNIT);
            }
            return str;
        }

        protected override string uc_Save()
        {
       //     SYS_LOG.Insert("Danh Mục Đơn Vị Tính", "Thêm", this.txtID.Text);
            base.SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            DIC_UNIT dICUNIT = new DIC_UNIT(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
            string str = dICUNIT.Insert();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICUNIT);
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
          //  SYS_LOG.Insert("Danh Mục Đơn Vị Tính", "Cập Nhật", this.txtID.Text);
            base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            DIC_UNIT dICUNIT = new DIC_UNIT(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
            string str = dICUNIT.Update();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICUNIT);
            }
            if (str != "OK")
            {
                XtraMessageBox.Show(str, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.DoHide();
            return str;
        }

        public event xucUnitAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_UNIT item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_UNIT()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
