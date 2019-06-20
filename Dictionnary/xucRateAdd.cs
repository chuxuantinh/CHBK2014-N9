using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class xucRateAdd : xucBaseAdd
    {
        public xucRateAdd()
        {
            this.InitializeComponent();
            this.InitData();
        }

        protected override void Add()
        {
            base.Add();
            DIC_RATE dICRATE = new DIC_RATE();
            this.txtID.Text = dICRATE.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtDescription.Text = "";
        }

        private void glkGroupRate_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            {
                if (e.Button.Kind == ButtonPredefines.Plus)
                {
                    string name = (sender as GridLookUpEdit).Name;
                    if (name != null)
                    {
                        if (name != "glkGroupRate")
                        {
                            goto Label0;
                        }
                        xfmGroupRateAdd _xfmGroupRateAdd = new xfmGroupRateAdd(Actions.Add);
                        _xfmGroupRateAdd.Added += new xfmGroupRateAdd.AddedEventHander((object s, DIC_GROUP_RATE i) => (new DIC_GROUP_RATE()).AddGridLookupEdit(this.glkGroupRate));
                        _xfmGroupRateAdd.ShowDialog();
                    }
                Label0:;
                }
            }
        }

        protected override void Init()
        {
        }

        private void InitData()
        {
            (new DIC_GROUP_RATE()).AddGridLookupEdit(this.glkGroupRate);
            this.calCoefficient.EditValue = 1;
        }

        private void RaiseSuccessEventHander(DIC_RATE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_RATE item)
        {
            this.txtID.Text = item.RateCode;
          //  SYS_LOG.Insert("Tiêu Chí Đánh Giá", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.RateName;
            this.calCoefficient.EditValue = item.Coefficient;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
            (new DIC_GROUP_RATE()).AddGridLookupEdit(this.glkGroupRate);
            this.glkGroupRate.EditValue = item.GroupRateCode;
        }

       

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_RATE dICRATE = new DIC_RATE();
                if (this.m_Status == Actions.Add)
                {
                    if (dICRATE.Exist(textEdit.Text))
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
            DIC_RATE dICRATE = new DIC_RATE()
            {
                RateCode = this.txtID.Text
            };
            string str = dICRATE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICRATE);
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
            else if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                str = "";
            }
            else if (this.glkGroupRate.EditValue != null)
            {
              //  SYS_LOG.Insert("Tiêu Chí Đánh Giá", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_RATE dICRATE = new DIC_RATE(this.txtID.Text, this.glkGroupRate.EditValue.ToString(), this.txtNAME.Text, double.Parse(this.calCoefficient.EditValue.ToString()), this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICRATE.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICRATE);
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
                XtraMessageBox.Show("Vui lòng chọn 1 nhóm tiêu chí!", "Cảnh Báo");
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
            else if (!MyRule.AllowEdit)
            {
                MyRule.Notify();
                str = "";
            }
            else if (this.glkGroupRate.EditValue != null)
            {
              //  SYS_LOG.Insert("Tiêu Chí Đánh Giá", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_RATE dICRATE = new DIC_RATE(this.txtID.Text, this.glkGroupRate.EditValue.ToString(), this.txtNAME.Text, double.Parse(this.calCoefficient.EditValue.ToString()), this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICRATE.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICRATE);
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
                XtraMessageBox.Show("Vui lòng chọn 1 nhóm tiêu chí!", "Cảnh Báo");
                str = "";
            }
            return str;
        }

        public event xucRateAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_RATE item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_RATE()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }
    }
}
