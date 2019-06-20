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
    public partial  class xucLanguageAdd : xucBaseAdd

    {
        
     
        private LabelControl lcDescription;
       

        public xucLanguageAdd()
        {
            InitializeComponent();
        }


      
       
        protected override void Add()
        {
            base.Add();
            DIC_LANGUAGE dICLANGUAGE = new DIC_LANGUAGE();
            txtID.Text = dICLANGUAGE.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtDescription.Text = "";
        }

        private void RaiseSuccessEventHander(DIC_LANGUAGE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_LANGUAGE item)
        {
            this.txtID.Text = item.LanguageCode;
         //   SYS_LOG.Insert("Danh Mục Ngoại Ngữ", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.LanguageName;
            this.txtDescription.Text = item.Description;
            this.chxUse.Checked = item.Active;
        }

        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            DIC_LANGUAGE dICLANGUAGE = new DIC_LANGUAGE()
            {
                LanguageCode = this.txtID.Text
            };
            string str = dICLANGUAGE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICLANGUAGE);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiLanguage") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
               // SYS_LOG.Insert("Danh Mục Ngoại Ngữ", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                if (txtID.Text == null)
                {
                    MessageBox.Show("Kiểm tra lại dữ liệu");
                    

                }
                
                DIC_LANGUAGE dICLANGUAGE = new DIC_LANGUAGE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICLANGUAGE.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICLANGUAGE);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiLanguage") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
            //    SYS_LOG.Insert("Danh Mục Ngoại Ngữ", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_LANGUAGE dICLANGUAGE = new DIC_LANGUAGE(this.txtID.Text, this.txtNAME.Text, this.txtDescription.Text, this.chxUse.Checked);
                string str1 = dICLANGUAGE.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICLANGUAGE);
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


     
      

        public event xucLanguageAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_LANGUAGE item);

        private void xucLanguageAdd_Success(object sender, object Item)
        {

        }

        //private void xucLanguageAdd_Success(object sender, object Item)
        //{

        //}
    }
}
