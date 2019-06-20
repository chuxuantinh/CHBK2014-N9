using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucDepartmentAdd : xucBaseAdd
    {
        public xucDepartmentAdd()
        {
            InitializeComponent();

            this.InitData();
            this.txtQuantity.Text = "0";
            this.txtFactQuantity.Text = "0";
        }

      

        protected override void Add()
        {
            base.Add();
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
            this.txtID.Text = hRMDEPARTMENT.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtPhone.Text = "";
            this.txtQuantity.Text = "0";
            this.txtFactQuantity.Text = "0";
            this.txtDescription.Text = "";
        }


        private void glk_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            string name;
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                name = (sender as GridLookUpEdit).Name;
                if (name != null)
                {
                    if (name == "glkBranch")
                    {
                        xfmBranchAdd _xfmBranchAdd = new xfmBranchAdd(Actions.Add);
                        _xfmBranchAdd.Added += new xfmBranchAdd.AddedEventHander((object s, HRM_BRANCH i) => {
                            HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                            if ((this.glkSubsidiary.EditValue == null ? false : !(this.glkSubsidiary.Text == "")))
                            {
                                this.glkBranch.Properties.DataSource = hRMBRANCH.GetListBySubsidiary(this.glkSubsidiary.EditValue.ToString());
                            }
                            else
                            {
                                this.glkBranch.Properties.DataSource = hRMBRANCH.GetList();
                            }
                        });
                        _xfmBranchAdd.ShowDialog();
                        goto Label2;
                    }
                    else
                    {
                        if (name != "glkSubsidiary")
                        {
                            goto Label2;
                        }
                        xfmSubsidiaryAdd _xfmSubsidiaryAdd = new xfmSubsidiaryAdd(Actions.Add);
                        _xfmSubsidiaryAdd.Added += new xfmSubsidiaryAdd.AddedEventHander((object s, HRM_SUBSIDIARY i) => (new HRM_SUBSIDIARY()).AddGridLookupEdit(this.glkSubsidiary));
                        _xfmSubsidiaryAdd.ShowDialog();
                        goto Label2;
                    }
                }
            Label2:;
            }
            else if (e.Button.Kind == ButtonPredefines.Delete)
            {
                name = (sender as GridLookUpEdit).Name;
                if (name != null)
                {
                    if (name == "glkBranch")
                    {
                        this.glkBranch.EditValue = null;
                        goto Label0;
                    }
                    else
                    {
                        if (name != "glkSubsidiary")
                        {
                            goto Label0;
                        }
                        this.glkSubsidiary.EditValue = null;
                        goto Label0;
                    }
                }
            Label0:;
            }
        }

        private void glkSubsidiary_EditValueChanged(object sender, EventArgs e)
        {
            HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
            if ((this.glkSubsidiary.EditValue == null ? false : !(this.glkSubsidiary.Text == "")))
            {
                this.glkBranch.Properties.DataSource = hRMBRANCH.GetListBySubsidiary(this.glkSubsidiary.EditValue.ToString());
            }
            else
            {
                this.glkBranch.Properties.DataSource = hRMBRANCH.GetList();
            }
        }

        protected override void Init()
        {
        }

        private HRM_DEPARTMENT InitClass()
        {
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT()
            {
                DepartmentCode = this.txtID.Text,
                SubsidiaryCode = (this.glkSubsidiary.EditValue == null || this.glkSubsidiary.Text == "" ? "" : this.glkSubsidiary.EditValue.ToString()),
                BranchCode = (this.glkBranch.EditValue == null || this.glkBranch.Text == "" ? "" : this.glkBranch.EditValue.ToString()),
                DepartmentName = this.txtNAME.Text,
                Phone = this.txtPhone.Text,
                Quantity = int.Parse(this.txtQuantity.Text),
                FactQuantity = int.Parse(this.txtFactQuantity.Text),
                Description = this.txtDescription.Text
            };
            return hRMDEPARTMENT;
        }

        private void InitData()
        {
            (new HRM_SUBSIDIARY()).AddGridLookupEdit(this.glkSubsidiary);
            (new HRM_BRANCH()).AddGridLookupEdit(this.glkBranch);
        }


        private void RaiseSuccessEventHander(HRM_DEPARTMENT item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetBranchCode(string BranchCode)
        {
            this.glkBranch.EditValue = BranchCode;
        }

        public void SetData(HRM_DEPARTMENT item)
        {
            this.txtID.Text = item.DepartmentCode;
        //    SYS_LOG.Insert("Danh Sách Phòng Ban", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.glkSubsidiary.EditValue = item.SubsidiaryCode;
            this.glkBranch.EditValue = item.BranchCode;
            this.txtNAME.Text = item.DepartmentName;
            this.txtPhone.Text = item.Phone;
            this.txtQuantity.Text = item.Quantity.ToString();
            this.txtFactQuantity.Text = item.FactQuantity.ToString();
            this.txtDescription.Text = item.Description;
        }

      
        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
                HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                HRM_GROUP hRMGROUP = new HRM_GROUP();
                if (this.m_Status == Actions.Add)
                {
                    if ((hRMBRANCH.Exist(textEdit.Text) || hRMSUBSIDIARY.Exist(textEdit.Text) || hRMDEPARTMENT.Exist(textEdit.Text) ? true : hRMGROUP.Exist(textEdit.Text)))
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
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT()
            {
                DepartmentCode = this.txtID.Text
            };
            string str = hRMDEPARTMENT.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(hRMDEPARTMENT);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiDepartment") != "OK")
            {
                str = "";
            }
            else if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                str = "";
            }
            else if (MyLogin.Level <= 2)
            {
               // SYS_LOG.Insert("Danh Sách Phòng Ban", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                HRM_DEPARTMENT hRMDEPARTMENT = this.InitClass();
                string str1 = hRMDEPARTMENT.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMDEPARTMENT);
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
                XtraMessageBox.Show("Cấp độ quản lý của bạn không được phép thêm phòng ban!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiDepartment") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
              //  SYS_LOG.Insert("Danh Sách Phòng Ban", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                HRM_DEPARTMENT hRMDEPARTMENT = this.InitClass();
                string str1 = hRMDEPARTMENT.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMDEPARTMENT);
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

        public event xucDepartmentAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, HRM_DEPARTMENT item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
            HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
            HRM_GROUP hRMGROUP = new HRM_GROUP();
            if (this.m_Status == Actions.Add)
            {
                if ((hRMBRANCH.Exist(textEdit.Text) || hRMSUBSIDIARY.Exist(textEdit.Text) || hRMDEPARTMENT.Exist(textEdit.Text) ? true : hRMGROUP.Exist(textEdit.Text)))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
