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
    public partial class xucGroupAdd : xucBaseAdd
    {
       

        public xucGroupAdd()
        {
            this.InitializeComponent();
          
            this.InitData();
            this.txtQuantity.Text = "0";
            this.txtFactQuantity.Text = "0";
        }

        protected override void Add()
        {
            base.Add();
            HRM_GROUP hRMGROUP = new HRM_GROUP();
            this.txtID.Text = hRMGROUP.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
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
                    if (name == "glkSubsidiary")
                    {
                        xfmSubsidiaryAdd _xfmSubsidiaryAdd = new xfmSubsidiaryAdd(Actions.Add);
                        _xfmSubsidiaryAdd.Added += new xfmSubsidiaryAdd.AddedEventHander((object s, HRM_SUBSIDIARY i) => (new HRM_SUBSIDIARY()).AddGridLookupEdit(this.glkSubsidiary));
                        _xfmSubsidiaryAdd.ShowDialog();
                        goto Label2;
                    }
                    else if (name == "glkBranch")
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
                        if (name != "glkDepartment")
                        {
                            goto Label2;
                        }
                        xfmDepartmentAdd _xfmDepartmentAdd = new xfmDepartmentAdd(Actions.Add);
                        _xfmDepartmentAdd.Added += new xfmDepartmentAdd.AddedEventHander((object s, HRM_DEPARTMENT i) => {
                            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                            if ((this.glkBranch.EditValue == null ? false : !(this.glkBranch.Text == "")))
                            {
                                hRMDEPARTMENT.AddGridLookupEdit(this.glkDepartment, this.glkBranch.EditValue.ToString());
                            }
                            else
                            {
                                this.glkDepartment.Properties.DataSource = hRMDEPARTMENT.GetList();
                            }
                        });
                        _xfmDepartmentAdd.ShowDialog();
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
                    if (name == "glkSubsidiary")
                    {
                        this.glkSubsidiary.EditValue = null;
                        goto Label0;
                    }
                    else if (name == "glkBranch")
                    {
                        this.glkBranch.EditValue = null;
                        goto Label0;
                    }
                    else
                    {
                        if (name != "glkDepartment")
                        {
                            goto Label0;
                        }
                        this.glkDepartment.EditValue = null;
                        goto Label0;
                    }
                }
            Label0:;
            }
        }

        private void glkBranch_EditValueChanged(object sender, EventArgs e)
        {
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
            if ((this.glkBranch.EditValue == null ? false : !(this.glkBranch.Text == "")))
            {
                hRMDEPARTMENT.AddGridLookupEdit(this.glkDepartment, this.glkBranch.EditValue.ToString());
            }
            else
            {
                this.glkDepartment.Properties.DataSource = hRMDEPARTMENT.GetList();
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

        private void InitData()
        {
            (new HRM_SUBSIDIARY()).AddGridLookupEdit(this.glkSubsidiary);
            (new HRM_BRANCH()).AddGridLookupEdit(this.glkBranch);
            (new HRM_DEPARTMENT()).AddAllGridLookupEdit(this.glkDepartment);
        }

        private void RaiseSuccessEventHander(HRM_GROUP item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(HRM_GROUP item)
        {
            this.txtID.Text = item.GroupCode;
          //  SYS_LOG.Insert("Danh Sách Tổ Nhóm", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.GroupName;
            this.txtQuantity.Text = item.Quantity.ToString();
            this.txtFactQuantity.Text = item.FactQuantity.ToString();
            this.txtDescription.Text = item.Description;
            this.glkSubsidiary.EditValue = item.SubsidiaryCode;
            this.glkBranch.EditValue = item.BranchCode;
            this.glkDepartment.EditValue = item.DepartmentCode;
        }

        public void SetData(string BranhCode, string DepartmentCode)
        {
            this.glkBranch.EditValue = BranhCode;
            this.glkDepartment.EditValue = DepartmentCode;
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
            HRM_GROUP hRMGROUP = new HRM_GROUP()
            {
                GroupCode = this.txtID.Text
            };
            string str = hRMGROUP.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(hRMGROUP);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiGroup") != "OK")
            {
                str = "";
            }
            else if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                str = "";
            }
            else if (MyLogin.Level > 3)
            {
                XtraMessageBox.Show("Cấp độ quản lý của bạn không được phép thêm tổ nhóm!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                str = "";
            }
            else if (this.glkDepartment.EditValue != null)
            {
             //   SYS_LOG.Insert("Danh Sách Tổ Nhóm", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                HRM_GROUP hRMGROUP = new HRM_GROUP(this.txtID.Text, this.glkDepartment.EditValue.ToString(), this.txtNAME.Text, int.Parse(this.txtQuantity.Text), int.Parse(this.txtFactQuantity.Text), this.txtDescription.Text);
                string str1 = hRMGROUP.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMGROUP);
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
                XtraMessageBox.Show("Vui lòng chọn 1 phòng ban!", "Cảnh Báo");
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiGroup") != "OK")
            {
                str = "";
            }
            else if (!MyRule.AllowEdit)
            {
                MyRule.Notify();
                str = "";
            }
            else if (this.glkDepartment.EditValue != null)
            {
               // SYS_LOG.Insert("Danh Sách Tổ Nhóm", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                HRM_GROUP hRMGROUP = new HRM_GROUP(this.txtID.Text, this.glkDepartment.EditValue.ToString(), this.txtNAME.Text, int.Parse(this.txtQuantity.Text), int.Parse(this.txtFactQuantity.Text), this.txtDescription.Text);
                string str1 = hRMGROUP.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMGROUP);
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
                XtraMessageBox.Show("Vui lòng chọn 1 phòng ban!", "Cảnh Báo");
                str = "";
            }
            return str;
        }

        public event xucGroupAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, HRM_GROUP item);

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
    }
}
