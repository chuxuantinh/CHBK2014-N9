using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Common
{
    public partial class xucBaseAdd :xucBase
    {

       
        public xucBaseAdd()
        {
            InitializeComponent();

                   
            this.Init();
        }
        protected virtual void txtID_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.RaiseCancelClickEventHander();
        }

        private void btnCancel_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnCancel_Click(this.btnCancel, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.m_CloseOrNew = CloseOrNew.Close;
            this.Save();
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnSave_Click(this.btnSave, e);
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            this.m_CloseOrNew = CloseOrNew.New;
            this.txtID.Properties.ReadOnly = false;
            this.Save();
            this.m_Status = Actions.Add;
            this.txtID.Focus();
            this.Add();
        }

        protected virtual void Add()
        {
        }

        public virtual void Change()
        {
        }


        protected virtual void Init()
        {
            this.ReLoad();
        }


        protected virtual bool Check()
        {
            return true;
        }

        public virtual new void Delete()
        {
            this.uc_Delete();
        }

        protected virtual void MakerInterface()
        {
        }

        public bool Number(KeyPressEventArgs e)
        {
            bool flag;
            if (!(e.KeyChar == '\b' | e.KeyChar == '.' | e.KeyChar == '-'))
            {
                flag = (char.IsNumber(e.KeyChar) ? false : true);
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        public void RaiseCancelClickEventHander()
        {
            if (this.CancelClick != null)
            {
                this.CancelClick(this);
            }
        }

        public void RaiseSaveClickEventHander()
        {
            if (this.SaveClick != null)
            {
                this.SaveClick(this);
            }
        }

        public virtual void ReLoad()
        {
        }



    

        public virtual void Save()
        {
            if ((this.txtID.ErrorText != string.Empty) | (this.txtID.Text == string.Empty))
            {
                XtraMessageBox.Show((this.txtID.ErrorText.Length == 0 ? "Dữ liệu của ô này không được bỏ trống." : this.txtID.ErrorText), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtID.Focus();
            }
            else if ((this.txtNAME.ErrorText != string.Empty) | (this.txtNAME.Text == string.Empty))
            {
                XtraMessageBox.Show((this.txtNAME.ErrorText.Length == 0 ? "Dữ liệu của ô này không được bỏ trống." : this.txtNAME.ErrorText), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNAME.Focus();
            }
            else if (this.Check())
            {
                if (this.m_Status == Actions.Add)
                {
                    this.uc_Save();
                }
                else if (this.m_Status == Actions.Update)
                {
                    this.uc_Update();
                }
                else if (this.m_Status == Actions.Change)
                {
                    this.uc_Change();
                }
            }
        }

        public void SetData(string id)
        {
            this.txtID.Text = id;
            this.txtNAME.Focus();
            this.Add();
        }

        protected virtual void SetInterface()
        {
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (this.m_Status != Actions.None)
            {
                if (textEdit.Text == string.Empty)
                {
                    this.Err.SetError(textEdit, string.Concat("Vui lòng nhập thông tin.", this.Text));
                }
            }
        }

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (this.m_Status != Actions.None)
            {
                if (textEdit.ErrorText != string.Empty)
                {
                    this.Err.SetError(textEdit, string.Empty);
                }
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (this.m_Status != Actions.None)
            {
                if (textEdit.Text == string.Empty)
                {
                    this.Err.SetError(textEdit, string.Concat("Vui lòng nhập thông tin.", this.Text));
                }
                if (string.IsNullOrEmpty(this.txtID.Text))
                {
                    if (!string.IsNullOrEmpty(this.txtNAME.Text))
                    {
                        this.txtID.Text = base.GenerateCode(this.txtNAME.Text);
                    }
                }
            }
        }


        protected virtual string uc_Change()
        {
            return string.Empty;
        }

        protected virtual string uc_Delete()
        {
            return string.Empty;
        }

        protected virtual string uc_Save()
        {
            return string.Empty;
        }

        protected virtual string uc_Update()
        {
            return string.Empty;
        }

        public event ButtonClickEventHander CancelClick;

        public event ButtonClickEventHander SaveClick;

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
