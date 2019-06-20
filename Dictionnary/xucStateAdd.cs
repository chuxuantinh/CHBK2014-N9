using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace CHBK2014_N9.Dictionnary
{
    public partial class xucStateAdd : xucBaseAdd
    {
     

        public xucStateAdd()
        {
            this.InitializeComponent();
            this.InitData();
        }

        protected override void Add()
        {
            base.Add();
            DIC_STATE dICSTATE = new DIC_STATE();
            this.txtID.Text = dICSTATE.NewID();
            this.txtNAME.Focus();
        }

        private void AddComboboxEdit(ComboBoxEdit combo, string str)
        {
            combo.Properties.Items.Add(str);
            combo.SelectedIndex = combo.Properties.Items.Count - 1;
        }

        private void cbo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                string name = (sender as ComboBoxEdit).Name;
                if (name != null)
                {
                    if (name != "cboUnit")
                    {
                        goto Label0;
                    }
                    xfmUnitAdd _xfmUnitAdd = new xfmUnitAdd(Actions.Add);
                    _xfmUnitAdd.Added += new xfmUnitAdd.AddedEventHander((object s, DIC_UNIT i) => this.AddComboboxEdit(this.cboUnit, i.UnitName));
                    _xfmUnitAdd.ShowDialog();
                }
                Label0:;
            }
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

        private DIC_STATE InitClass()
        {
            DIC_STATE dICSTATE = new DIC_STATE()
            {
                StateCode = this.txtID.Text,
                StateName = this.txtNAME.Text,
                Price = decimal.Parse(this.calPrice.EditValue.ToString()),
                Unit = this.cboUnit.Text,
                Description = this.txtDescription.Text
            };
            return dICSTATE;
        }

        private void InitData()
        {
            (new DIC_UNIT()).AddComboEdit(this.cboUnit);
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void RaiseSuccessEventHander(DIC_STATE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_STATE item)
        {
            this.txtID.Text = item.StateCode;
           // SYS_LOG.Insert("Danh Mục Công Đoạn", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.StateName;
            this.calPrice.EditValue = item.Price;
            this.cboUnit.Text = item.Unit;
            this.txtDescription.Text = item.Description;
        }

       

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_STATE dICSTATE = new DIC_STATE();
                if (this.m_Status == Actions.Add)
                {
                    if (dICSTATE.Exist(textEdit.Text))
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
            DIC_STATE dICSTATE = new DIC_STATE()
            {
                StateCode = this.txtID.Text
            };
            string str = dICSTATE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICSTATE);
            }
            return str;
        }

        protected override string uc_Save()
        {
         //   SYS_LOG.Insert("Danh Mục Công Đoạn", "Thêm", this.txtID.Text);
            base.SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            DIC_STATE dICSTATE = this.InitClass();
            string str = dICSTATE.Insert();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICSTATE);
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
          //  SYS_LOG.Insert("Danh Mục Công Đoạn", "Cập Nhật", this.txtID.Text);
            base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
            DIC_STATE dICSTATE = this.InitClass();
            string str = dICSTATE.Update();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICSTATE);
            }
            if (str != "OK")
            {
                XtraMessageBox.Show(str, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.DoHide();
            return str;
        }

        private void xucStateAdd_Load(object sender, EventArgs e)
        {
        }

        public event xucStateAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_STATE item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_STATE()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
