using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using Microsoft.VisualBasic;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core.Class;
using CHBK2014_N9.Net.Info;
using CHBK2014_N9.Utils;
//using CHBK2014_N9.Utils.Security2;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucContractAdd : xucBaseAddH
    {

        private string m_ContractCode = "";
        public xucContractAdd()
        {
            InitializeComponent();
            this.InitData();
        }


      
        protected override void Add()
        {
            base.Add();
            HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
            this.txtContractCode.Text = hRMCONTRACT.NewID();
        }


        public void SetDefaultAdd(string EmployeeCode)
        {
            this.glkEmployeeCode.EditValue = EmployeeCode;
            this.glkEmployeeCode.Properties.ReadOnly = true;
        }

        private void cboContractTime_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cboContractTime.SelectedIndex == 0)
            {
                this.dtToDate.DateTime = DateAndTime.DateAdd(DateInterval.Month, 2, this.dtFromDate.DateTime);
            }
            else if (this.cboContractTime.SelectedIndex == 1)
            {
                this.dtToDate.DateTime = DateAndTime.DateAdd(DateInterval.Month, 3, this.dtFromDate.DateTime);
            }
            else if (this.cboContractTime.SelectedIndex == 2)
            {
                this.dtToDate.DateTime = DateAndTime.DateAdd(DateInterval.Month, 6, this.dtFromDate.DateTime);
            }
            else if (this.cboContractTime.SelectedIndex == 3)
            {
                this.dtToDate.DateTime = DateAndTime.DateAdd(DateInterval.Month, 9, this.dtFromDate.DateTime);
            }
            else if (this.cboContractTime.SelectedIndex == 4)
            {
                this.dtToDate.DateTime = DateAndTime.DateAdd(DateInterval.Year, 1, this.dtFromDate.DateTime);
            }
            else if (this.cboContractTime.SelectedIndex == 5)
            {
                this.dtToDate.DateTime = DateAndTime.DateAdd(DateInterval.Year, 2, this.dtFromDate.DateTime);
            }
            else if (this.cboContractTime.SelectedIndex == 6)
            {
                this.dtToDate.DateTime = DateAndTime.DateAdd(DateInterval.Year, 3, this.dtFromDate.DateTime);
            }

            
        }

        private void cboContractTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboContractType.SelectedIndex != 1)
            {
                this.lcContractTime.Visible = true;
                this.cboContractTime.Visible = true;
                this.lcToDate.Visible = true;
                this.dtToDate.Visible = true;
            }
            else
            {
                this.lcContractTime.Visible = false;
                this.cboContractTime.Visible = false;
                this.lcToDate.Visible = false;
                this.dtToDate.Visible = false;
            }
        }

        public new void Clear()
        {
            this.txtDescription.Text = "[Ghi chú]";
            this.xtraTabControl1.SelectedTabPage = this.tabSides;
        }

        
        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT()
            {
                ContractCode = this.txtContractCode.Text
            };
            string str = hRMCONTRACT.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(hRMCONTRACT);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiContract") != "OK")
            {
                str = "";
            }
            else if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                str = "";
            }
            else if ((this.txtContractCode.ErrorText != string.Empty ? false : !(this.glkEmployeeCode.ErrorText != string.Empty)))
            {
               // SYS_LOG.Insert("Hợp Đồng Lao Động", "Thêm", this.txtContractCode.Text);
              
                Cursor.Current = Cursors.WaitCursor;
                HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
                HRM_CONTRACT hRMCONTRACT1 = this.InitClass();
                hRMCONTRACT = hRMCONTRACT1;
                if (hRMCONTRACT1 != null)
                {
                    base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                    string str1 = hRMCONTRACT.Insert();
                    if (str1 == "OK")
                    {
                        this.RaiseSuccessEventHander(hRMCONTRACT);
                    }
                    Cursor.Current = Cursors.Default;
                    if (!(str1 != "OK"))
                    {
                        HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
                        hRMEMPLOYEE.Get(this.glkEmployeeCode.EditValue.ToString());
                        HRM_PROCESS_SALARY hRMPROCESSSALARY = new HRM_PROCESS_SALARY()
                        {
                            SalaryID = Guid.NewGuid(),
                            EmployeeCode = hRMEMPLOYEE.EmployeeCode,
                            OldPayForm = hRMEMPLOYEE.PayForm,
                            OldPayMoney = hRMEMPLOYEE.PayMoney,
                            OldRankSalary = hRMEMPLOYEE.RankSalary,
                            OldStepSalary = hRMEMPLOYEE.StepSalary,
                            OldCoefficientSalary = hRMEMPLOYEE.CoefficientSalary,
                            OldMinimumSalary = hRMEMPLOYEE.MinimumSalary,
                            OldBasicSalary = hRMEMPLOYEE.BasicSalary,
                            OldInsuranceSalary = hRMEMPLOYEE.InsuranceSalary,
                            NewPayForm = 1,
                            NewPayMoney = decimal.Parse(this.calBasicSalary.EditValue.ToString()),
                            NewRankSalary = hRMEMPLOYEE.RankSalary,
                            NewStepSalary = hRMEMPLOYEE.StepSalary,
                            NewCoefficientSalary = hRMEMPLOYEE.CoefficientSalary,
                            NewMinimumSalary = hRMEMPLOYEE.MinimumSalary,
                            NewBasicSalary = decimal.Parse(this.calBasicSalary.EditValue.ToString()),
                            NewInsuranceSalary = decimal.Parse(this.calBasicSalary.EditValue.ToString()),
                            Date = this.dtSignDate.DateTime,
                            Reason = "Ký mới hợp đồng lao động",
                            Person = this.txtSigner.Text
                        };
                        hRMPROCESSSALARY.Insert();
                        hRMEMPLOYEE.ContractCode = this.txtContractCode.Text;
                        hRMEMPLOYEE.ContractType = this.cboContractType.Text;
                        hRMEMPLOYEE.ContractSignDate = this.dtFromDate.DateTime;
                        hRMEMPLOYEE.ContractFromDate = this.dtFromDate.DateTime;
                        if (this.cboContractType.SelectedIndex != 1)
                        {
                            hRMEMPLOYEE.ContractToDate = this.dtToDate.DateTime;
                        }
                        else
                        {
                            SqlDateTime maxValue = SqlDateTime.MaxValue;
                            hRMEMPLOYEE.ContractToDate = Convert.ToDateTime(maxValue.ToString());
                        }
                        if (hRMEMPLOYEE.PayForm == 1)
                        {
                            hRMEMPLOYEE.PayMoney = decimal.Parse(this.calBasicSalary.EditValue.ToString());
                            hRMEMPLOYEE.BasicSalary = hRMEMPLOYEE.PayMoney;
                            hRMEMPLOYEE.InsuranceSalary = hRMEMPLOYEE.PayMoney;
                            hRMEMPLOYEE.DateSalary = this.dtSignDate.DateTime;
                        }
                        hRMEMPLOYEE.Update();
                    }
                    else
                    {
                        XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.DoHide();
                    str = str1;
                }
                else
                {
                    str = "FALSE";
                }
            }
            else
            {
                MessageBox.Show("Mã hợp đồng hoặc mã nhân viên không được trùng!", "Cảnh Báo");
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiContract") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
             //   SYS_LOG.Insert("Hợp Đồng Lao Động", "Cập Nhật", this.txtContractCode.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
                hRMCONTRACT = this.InitClass();
                string str1 = hRMCONTRACT.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMCONTRACT);
                }
                if (!(str1 != "OK"))
                {
                    HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
                    hRMEMPLOYEE.Get(this.glkEmployeeCode.EditValue.ToString());
                    if (hRMEMPLOYEE.ContractCode == this.txtContractCode.Text)
                    {
                        hRMEMPLOYEE.ContractCode = this.txtContractCode.Text;
                        hRMEMPLOYEE.ContractType = this.cboContractType.Text;
                        hRMEMPLOYEE.ContractSignDate = this.dtFromDate.DateTime;
                        hRMEMPLOYEE.ContractFromDate = this.dtFromDate.DateTime;
                        if (this.cboContractType.SelectedIndex != 1)
                        {
                            hRMEMPLOYEE.ContractToDate = this.dtToDate.DateTime;
                        }
                        else
                        {
                            SqlDateTime maxValue = SqlDateTime.MaxValue;
                            hRMEMPLOYEE.ContractToDate = Convert.ToDateTime(maxValue.ToString());
                        }
                        if (hRMEMPLOYEE.PayForm == 1)
                        {
                            hRMEMPLOYEE.PayMoney = decimal.Parse(this.calBasicSalary.EditValue.ToString());
                            hRMEMPLOYEE.BasicSalary = hRMEMPLOYEE.PayMoney;
                            hRMEMPLOYEE.InsuranceSalary = hRMEMPLOYEE.PayMoney;
                            hRMEMPLOYEE.DateSalary = this.dtSignDate.DateTime;
                        }
                        hRMEMPLOYEE.Update();
                    }
                }
                else
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

        public event xucContractAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, HRM_CONTRACT item);

        private void glkEmployeeCode_EditValueChanged(object sender, EventArgs e)
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(this.glkEmployeeCode.EditValue.ToString());
            this.txtEmployeeName.Text = string.Concat(hRMEMPLOYEE.FirstName, " ", hRMEMPLOYEE.LastName);
            this.xdeBirthday.Day = hRMEMPLOYEE.BirthdayDay;
            this.xdeBirthday.Month = hRMEMPLOYEE.BirthdayMonth;
            this.xdeBirthday.Year = hRMEMPLOYEE.BirthdayYear;
            this.txtPosition.Text = hRMEMPLOYEE.Position;
            this.txtNationality1.Text = hRMEMPLOYEE.Nationality;
            this.txtIDCard.Text = hRMEMPLOYEE.IDCard;
            this.dtIDCardDate.DateTime = hRMEMPLOYEE.IDCardDate;
            this.txtIDCardPlace.Text = hRMEMPLOYEE.IDCardPlace;
            HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
            hRMBRANCH.Get(hRMEMPLOYEE.BranchCode);
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
            hRMDEPARTMENT.Get(hRMEMPLOYEE.DepartmentCode);
            this.txtDepartment.Text = string.Concat(hRMBRANCH.BranchName, " - ", hRMDEPARTMENT.DepartmentName);
            this.calBasicSalary.EditValue = hRMEMPLOYEE.BasicSalary;
            foreach (DataRow row in (new HRM_EMPLOYEE_ALLOWANCE()).GetList(hRMEMPLOYEE.EmployeeCode).Rows)
            {
                this.txtAllowance.Text = string.Concat(this.txtAllowance.Text, row["AllowanceName"].ToString(), "; ");
            }
            if (this.glkEmployeeCode.ErrorText != string.Empty)
            {
                this.Err.SetError(this.glkEmployeeCode, string.Empty);
            }
        }

        private void glkSignerCode_EditValueChanged(object sender, EventArgs e)
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(this.glkSignerCode.EditValue.ToString());
            this.txtSigner.Text = string.Concat(hRMEMPLOYEE.FirstName, " ", hRMEMPLOYEE.LastName);
            this.txtSignerPosition.Text = hRMEMPLOYEE.Position;
            this.txtSignerNationality.Text = hRMEMPLOYEE.Nationality;
        }


        private void gbList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle == -2147483648)
            {
                e.Handled = true;
                e.Painter.DrawObject(e.Info);
                Rectangle bounds = e.Bounds;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(63, 165, 165, 0)), bounds);
                bounds.Height = bounds.Height - 1;
                bounds.Width = bounds.Width - 1;
                e.Graphics.DrawRectangle(Pens.Blue, bounds);
            }
            int rowHandle = e.RowHandle;
            if (rowHandle >= 0)
            {
                rowHandle++;
                e.Info.DisplayText = rowHandle.ToString();
            }
        }

        protected override void Init()
        {
            base.Init();
        }

        private HRM_CONTRACT InitClass()
        {
            HRM_CONTRACT hRMCONTRACT;
            HRM_CONTRACT str = new HRM_CONTRACT()
            {
                ContractCode = this.txtContractCode.Text
            };
            if (this.glkEmployeeCode.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên cần tạo hợp đồng!");
                hRMCONTRACT = null;
            }
            else
            {
                str.EmployeeCode = this.glkEmployeeCode.EditValue.ToString();
                if (!(this.txtContractCode.Text == ""))
                {
                    str.ContractType = this.cboContractType.SelectedIndex;
                    str.ContractTime = this.cboContractTime.Text;
                    str.SignDate = this.dtSignDate.DateTime;
                    str.FromDate = this.dtFromDate.DateTime;
                    if (this.cboContractType.SelectedIndex != 1)
                    {
                        str.ToDate = this.dtToDate.DateTime;
                    }
                    else
                    {
                        SqlDateTime maxValue = SqlDateTime.MaxValue;
                        str.ToDate = Convert.ToDateTime(maxValue.ToString());
                    }
                    str.BasicSalary = decimal.Parse(this.calBasicSalary.EditValue.ToString());
                    str.PayForm = this.cboPayForm.Text;
                    str.PayDate = this.txtPayDate.Text;
                    str.Allowance = this.txtAllowance.Text;
                    str.Insurance = this.txtInsurance.Text;
                    str.WorkTime = this.txtWorkTime.Text;
                    str.Compensation = decimal.Parse(this.calCompensation.EditValue.ToString());
                    str.Signer = this.txtSigner.Text;
                    str.SignerPosition = this.txtSignerPosition.Text;
                    str.SignerNationality = this.txtSignerNationality.Text;
                    str.Company = this.txtCompany.Text;
                    str.Address = this.txtAddress.Text;
                    str.Tel = this.txtTel.Text;
                    str.CreatePlace = this.txtCreatePlace.Text;
                    str.Subject = this.txtSubject.Text;
                    str.Description = this.txtDescription.Text;
                    if (!this.chxIsCurrent.Checked)
                    {
                        str.IsCurrent = false;
                    }
                    else
                    {
                        str.IsCurrent = true;
                    }
                    hRMCONTRACT = str;
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng nhập mã hợp đồng!");
                    hRMCONTRACT = null;
                }
            }
            return hRMCONTRACT;
        }

        private void InitData()
        {
            string[] text;
            this.dtSignDate.DateTime = DateTime.Now;
            this.dtFromDate.DateTime = DateTime.Now;
            this.dtToDate.DateTime = DateTime.Now;
            this.dtSignDate.DateTime = DateTime.Now;
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.AddGridLookupEdit(this.glkEmployeeCode);
            hRMEMPLOYEE.AddGridLookupEdit(this.glkSignerCode);
            clsContractOption _clsContractOption = new clsContractOption();
            this.txtSigner.Text = _clsContractOption.Signer;
            this.txtSignerNationality.Text = _clsContractOption.SignerNationality;
            this.txtSignerPosition.Text = _clsContractOption.SignerPosition;
           

            this.txtCompany.Text = "SAIGONACT";
            this.txtAddress.Text = "Phan Văn Hớn";
            this.txtTel.Text = "09099999999";
            this.txtContractName.Text = "Hợp đồng lao động";
            this.txtCreatePlace.Text = "";
         
            foreach (DataRow row in (new DIC_SHIFT()).GetList().Rows)
            {
                TextEdit textEdit = this.txtWorkTime;
                text = new string[] { this.txtWorkTime.Text, row["ShiftName"].ToString(), " - ", row["ShiftCode"].ToString(), " (", null, null, null, null };
                DateTime dateTime = DateTime.Parse(row["BeginTime"].ToString());
                text[5] = dateTime.ToShortTimeString();
                text[6] = "->";
                dateTime = DateTime.Parse(row["EndTime"].ToString());
                text[7] = dateTime.ToShortTimeString();
                text[8] = "); ";
                textEdit.Text = string.Concat(text);
            }
            DIC_SALARY_FORMULA dICSALARYFORMULA = new DIC_SALARY_FORMULA();
            dICSALARYFORMULA.Get();
            TextEdit textEdit1 = this.txtInsurance;
            text = new string[6];
            double socialInsurance1 = dICSALARYFORMULA.SocialInsurance1;
            text[0] = socialInsurance1.ToString();
            text[1] = " % BHXH, ";
            socialInsurance1 = dICSALARYFORMULA.HealthInsurance1;
            text[2] = socialInsurance1.ToString();
            text[3] = " % BHYT, ";
            socialInsurance1 = dICSALARYFORMULA.UnemploymentInsurance1;
            text[4] = socialInsurance1.ToString();
            text[5] = " % BHTN";
            textEdit1.Text = string.Concat(text);
        }



        private void RaiseSuccessEventHander(HRM_CONTRACT item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }



     

        public void SetData(HRM_CONTRACT item)
        {
            TextEdit textEdit = this.txtContractCode;
            string contractCode = item.ContractCode;
            string str = contractCode;
            this.m_ContractCode = contractCode;
            textEdit.Text = str;
          //  SYS_LOG.Insert("Hợp Đồng Lao Động", "Xem", this.txtContractCode.Text);
            if (this.m_Status == Actions.Update)
            {
                this.glkEmployeeCode.Properties.ReadOnly = true;
            }
            this.glkEmployeeCode.EditValue = item.EmployeeCode;
            this.cboContractType.SelectedIndex = item.ContractType;
            this.cboContractTime.Text = item.ContractTime;
            this.dtSignDate.DateTime = item.SignDate;
            this.dtFromDate.DateTime = item.FromDate;
            this.dtToDate.DateTime = item.ToDate;
            this.calBasicSalary.EditValue = item.BasicSalary;
            this.cboPayForm.Text = item.PayForm;
            this.txtPayDate.Text = item.PayDate.ToString();
            this.txtAllowance.Text = item.Allowance;
            this.txtInsurance.Text = item.Insurance;
            this.txtWorkTime.Text = item.WorkTime;
            this.calCompensation.EditValue = item.Compensation;
            this.txtSigner.Text = item.Signer;
            this.txtSignerPosition.Text = item.SignerPosition;
            this.txtSignerNationality.Text = item.SignerNationality;
            this.txtCompany.Text = item.Company;
            this.txtAddress.Text = item.Address;
            this.txtTel.Text = item.Tel;
            this.txtCreatePlace.Text = item.CreatePlace;
            this.txtSubject.Text = item.Subject;
            this.txtDescription.Text = item.Description;
            this.chxIsCurrent.Checked = true;
           
        }

       

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.txtContractCode.Text != this.m_ContractCode)
            {
                if ((new HRM_CONTRACT()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
                if (this.m_Status == Actions.Add)
                {
                    if (hRMCONTRACT.Exist(textEdit.Text))
                    {
                        this.Err.SetError(textEdit, "Mã đã tồn tại.");
                        textEdit.Focus();
                    }
                }
            }
        }

        private void xucContractAdd_Load(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void cboContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboContractType.SelectedIndex != 1)
            {
                this.lcContractTime.Visible = true;
                this.cboContractTime.Visible = true;
                this.lcToDate.Visible = true;
                this.dtToDate.Visible = true;
            }
            else
            {
                this.lcContractTime.Visible = false;
                this.cboContractTime.Visible = false;
                this.lcToDate.Visible = false;
                this.dtToDate.Visible = false;
            }
        }

     
    }
}
