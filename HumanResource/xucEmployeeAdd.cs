using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraTab;
using Microsoft.VisualBasic;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
//using CHBK2014_N9.Common.Report;
using CHBK2014_N9.Dictionnary;
using CHBK2014_N9.ERP;
using System.Drawing;
using CHBK2014_N9.HumanResource.Core;
using CHBK2014_N9.HumanResource.Core.Class;

//using CHBK2014_N9.HumanResource.Core.Properties;
//using CHBK2014_N9.HumanResource.Report;
using CHBK2014_N9.Security;
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace CHBK2014_N9.HumanResource
{
    public  partial class xucEmployeeAdd : xucBaseAddH
    {


        private CHBK2014_N9.HumanResource.Core. xucAllowance xucAllowance;

        private xucRelative xucRelative;

        //private xucSchedule xucSchedule;

        //private xucActivity xucActivity;

        //  private xucOrganizationEdit xucOrganizationEdit1;

        private string m_OldSubsidiaryCode = "";

        private string m_OldBranchCode = "";

        private string m_OldDepartmentCode = "";

        private string m_OldGroupCode = "";

        private string m_OldPosition = "";

        public xucEmployeeAdd()
        {
            InitializeComponent();
                  
            this.InitInterface();
            this.InitData();
        }

        protected override void Add()
        {
            base.Add();
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            this.txtID.Text = hRMEMPLOYEE.NewID();
            this.txtFirstName.Focus();
            this.imgPhoto.Image = null;
        }

        private void AddCheckedComboboxEdit(CheckedComboBoxEdit checkedCombo, string str, string value)
        {
            CheckedListBoxItem checkedListBoxItem = new CheckedListBoxItem()
            {
                Description = str,
                Value = value
            };
            checkedCombo.Properties.Items.Add(checkedListBoxItem);
        }

        private void AddComboboxEdit(ComboBoxEdit combo, string str)
        {
            combo.Properties.Items.Add(str);
            combo.SelectedIndex = combo.Properties.Items.Count - 1;
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            if (!hRMEMPLOYEE.Exist(this.txtID.Text))
            {
                if (this.uc_Save() != "OK")
                {
                    return;
                }
            }
            hRMEMPLOYEE.Get(this.txtID.Text);
            base.Status = Actions.Update;
            this.SetData(hRMEMPLOYEE);
            //(new xfmUserAdd(this.txtID.Text)).ShowDialog();

        }

        private void calPayMoney_EditValueChanged(object sender, EventArgs e)
        {
            this.calBasicSalary.EditValue = this.calPayMoney.EditValue;
            this.calInsuranceSalary.EditValue = this.calPayMoney.EditValue;
        }


        private void cbo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                string name = (sender as ComboBoxEdit).Name;
                if (name != null)
                {
                    switch (name)
                    {
                        case "cboNationality":
                            {
                                xfmNationalityAdd _xfmNationalityAdd = new xfmNationalityAdd(Actions.Add);
                                _xfmNationalityAdd.Added += new xfmNationalityAdd.AddedEventHander((object s, DIC_NATIONALITY i) => this.AddComboboxEdit(this.cboNationality, i.NationalityName));
                                _xfmNationalityAdd.ShowDialog();
                                break;
                            }
                        case "cboEthnic":
                            {
                                xfmEthnicAdd _xfmEthnicAdd = new xfmEthnicAdd(Actions.Add);
                                _xfmEthnicAdd.Added += new xfmEthnicAdd.AddedEventHander((object s, DIC_ETHNIC i) => this.AddComboboxEdit(this.cboEthnic, i.EthnicName));
                                _xfmEthnicAdd.ShowDialog();
                                break;
                            }
                        case "cboReligion":
                            {
                                xfmReligionAdd _xfmReligionAdd = new xfmReligionAdd(Actions.Add);
                                _xfmReligionAdd.Added += new xfmReligionAdd.AddedEventHander((object s, DIC_RELIGION i) => this.AddComboboxEdit(this.cboReligion, i.ReligionName));
                                _xfmReligionAdd.ShowDialog();
                                break;
                            }
                        case "cboEducation":
                            {
                                xfmEducationAdd _xfmEducationAdd = new xfmEducationAdd(Actions.Add);
                                _xfmEducationAdd.Added += new xfmEducationAdd.AddedEventHander((object s, DIC_EDUCATION i) => this.AddComboboxEdit(this.cboEducation, i.EducationName));
                                _xfmEducationAdd.ShowDialog();
                                break;
                            }
                        case "cboLanguage":
                            {
                                xfmLanguageAdd _xfmLanguageAdd = new xfmLanguageAdd(Actions.Add);
                                _xfmLanguageAdd.Added += new xfmLanguageAdd.AddedEventHander((object s, DIC_LANGUAGE i) => this.AddComboboxEdit(this.cboLanguage, i.LanguageName));
                                _xfmLanguageAdd.ShowDialog();
                                break;
                            }
                        case "cboInformatic":
                            {
                                xfmInformaticAdd _xfmInformaticAdd = new xfmInformaticAdd(Actions.Add);
                                _xfmInformaticAdd.Added += new xfmInformaticAdd.AddedEventHander((object s, DIC_INFORMATIC i) => this.AddComboboxEdit(this.cboInformatic, i.InformaticName));
                                _xfmInformaticAdd.ShowDialog();
                                break;
                            }
                        case "cboProfessional":
                            {
                                xfmProfessionalAdd _xfmProfessionalAdd = new xfmProfessionalAdd(Actions.Add);
                                _xfmProfessionalAdd.Added += new xfmProfessionalAdd.AddedEventHander((object s, DIC_PROFESSIONAL i) => this.AddComboboxEdit(this.cboProfessional, i.ProfessionalName));
                                _xfmProfessionalAdd.ShowDialog();
                                break;
                            }
                        case "cboPosition":
                            {
                                xfmPositionAdd _xfmPositionAdd = new xfmPositionAdd(Actions.Add);
                                _xfmPositionAdd.Added += new xfmPositionAdd.AddedEventHander((object s, DIC_POSITION i) => this.AddComboboxEdit(this.cboPosition, i.PositionName));
                                _xfmPositionAdd.ShowDialog();
                                break;
                            }
                        //case "cboStepSalary":
                        //    {
                        //        xfmStepAdd _xfmStepAdd = new xfmStepAdd(Actions.Add);
                        //        _xfmStepAdd.Added += new xfmStepAdd.AddedEventHander((object s, DIC_SALARY_STEP i) => this.AddComboboxEdit(this.cboStepSalary, i.StepCode.ToString()));
                        //        _xfmStepAdd.ShowDialog();
                        //        break;
                        //    }
                        case "cboSchool":
                            {
                                xfmSchool _xfmSchool = new xfmSchool();
                                _xfmSchool.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs i) => (new DIC_SCHOOL()).AddComboEdit(this.cboSchool));
                                _xfmSchool.ShowDialog();
                                break;
                            }
                        case "cboProvince":
                            {
                                xfmProvince _xfmProvince = new xfmProvince();
                                _xfmProvince.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs i) => (new DIC_PROVINCE()).AddComboEdit(this.cboProvince));
                                _xfmProvince.ShowDialog();
                                break;
                            }
                        //case "cboHospital":
                        //    {
                        //        xfmHospital _xfmHospital = new xfmHospital();
                        //        _xfmHospital.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs i) => (new DIC_HOSPITAL()).AddComboEdit(this.cboHospital));
                        //        _xfmHospital.ShowDialog();
                        //        break;
                        //    }
                        //case "cboContractCode":
                        //    {
                        //        if (this.cboContractCode.Text != "")
                        //        {
                        //            try
                        //            {
                        //                string text = this.cboContractCode.Text;
                        //                string str = this.txtID.Text;
                        //                xfmReport _xfmReport = new xfmReport("Hợp Đồng Lao Động");
                        //                HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
                        //                hRMCONTRACT.Get(text);
                        //                if (hRMCONTRACT.ContractType == 0)
                        //                {
                        //                    _xfmReport.ShowPrintPreview(new rptContract0(text, str));
                        //                }
                        //                else if (hRMCONTRACT.ContractType == 1)
                        //                {
                        //                    _xfmReport.ShowPrintPreview(new rptContract1(text, str));
                        //                }
                        //                else if (hRMCONTRACT.ContractType == 2)
                        //                {
                        //                    _xfmReport.ShowPrintPreview(new rptContract2(text, str));
                        //                }
                        //                else if (hRMCONTRACT.ContractType == 3)
                        //                {
                        //                    _xfmReport.ShowPrintPreview(new rptContract3(text, str));
                        //                }
                        //            }
                        //            catch
                        //            {
                        //            }
                        //        }
                        //        break;
                        //    }
                        default:
                            {
                                return;
                            }
                    }
                }
                else
                {
                    return;
                }
            }
        }







        private void InitData()
        {
             this.xucOrganizationEdit1.LoadData();
            (new DIC_POSITION()).AddComboEdit(this.cboPosition);
            (new DIC_SALARY_RANK()).AddGridLookupEdit(this.glkRankSalary);
            (new DIC_GROUP_RATE()).AddGridLookupEdit(this.glkGroupRateCode);
            DIC_MINIMUMSALARY dICMINIMUMSALARY = new DIC_MINIMUMSALARY();
            dICMINIMUMSALARY.Get();
            this.calMinimumSalary.EditValue = dICMINIMUMSALARY.Money;
            this.cboPayForm.SelectedIndex = 1;
            this.calPayMoney.EditValue = 0;
            this.calPercentSecondIncomeTax.EditValue = 0;
            (new DIC_NATIONALITY()).AddComboEdit(this.cboNationality);
            (new DIC_ETHNIC()).AddComboEdit(this.cboEthnic);
            (new DIC_RELIGION()).AddComboEdit(this.cboReligion);
            (new DIC_EDUCATION()).AddComboEdit(this.cboEducation);
            (new DIC_LANGUAGE()).AddComboEdit(this.cboLanguage);

            (new DIC_INFORMATIC()).AddComboEdit(this.cboInformatic);
            (new DIC_PROFESSIONAL()).AddComboEdit(this.cboProfessional);
            (new DIC_SCHOOL()).AddComboEdit(this.cboSchool);
            (new DIC_PROVINCE()).AddComboEdit(this.cboProvince);
            (new DIC_HOSPITAL()).AddComboEdit(this.cboHospital);
            (new DIC_DEGREE()).AddCheckedComboEdit(this.chcDegree);
        }

        private void InitDegree()
        {
            foreach (CheckedListBoxItem item in this.chcDegree.Properties.Items)
            {
                if ((new HRM_EMPLOYEE_DEGREE()).Exist(this.txtID.Text, item.Value.ToString()))
                {
                    item.CheckState = CheckState.Checked;
                }
            }
        }

        private void cboContractCode_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind == ButtonPredefines.Glyph)
            //{
            //    string caption = e.Button.Caption;
            //    if (caption != null)
            //    {
            //        if (caption == "Print")
            //        {
            //            if (this.cboContractCode.Text != "")
            //            {
            //                try
            //                {
            //                    string text = this.cboContractCode.Text;
            //                    string str = this.txtID.Text;
            //                    xfmReport _xfmReport = new xfmReport("Hợp Đồng Lao Động");
            //                    HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
            //                    hRMCONTRACT.Get(text);
            //                    clsContractOption _clsContractOption = new clsContractOption();
            //                    if (hRMCONTRACT.ContractType == 0)
            //                    {
            //                        if (!(_clsContractOption.FilePath0 == ""))
            //                        {
            //                            _xfmReport.ShowPrintPreview(new rptContract(text, str, _clsContractOption.FilePath0));
            //                        }
            //                        else
            //                        {
            //                            _xfmReport.ShowPrintPreview(new rptContract0(text, str));
            //                        }
            //                    }
            //                    else if (hRMCONTRACT.ContractType == 1)
            //                    {
            //                        if (!(_clsContractOption.FilePath1 == ""))
            //                        {
            //                            _xfmReport.ShowPrintPreview(new rptContract(text, str, _clsContractOption.FilePath1));
            //                        }
            //                        else
            //                        {
            //                            _xfmReport.ShowPrintPreview(new rptContract1(text, str));
            //                        }
            //                    }
            //                    else if (hRMCONTRACT.ContractType == 2)
            //                    {
            //                        if (!(_clsContractOption.FilePath2 == ""))
            //                        {
            //                            _xfmReport.ShowPrintPreview(new rptContract(text, str, _clsContractOption.FilePath2));
            //                        }
            //                        else
            //                        {
            //                            _xfmReport.ShowPrintPreview(new rptContract2(text, str));
            //                        }
            //                    }
            //                    else if (hRMCONTRACT.ContractType == 3)
            //                    {
            //                        if (!(_clsContractOption.FilePath3 == ""))
            //                        {
            //                            _xfmReport.ShowPrintPreview(new rptContract(text, str, _clsContractOption.FilePath3));
            //                        }
            //                        else
            //                        {
            //                            _xfmReport.ShowPrintPreview(new rptContract3(text, str));
            //                        }
            //                    }
            //                }
            //                catch
            //                {
            //                }
            //            }
            //            goto Label1;
            //        }
            //        else if (caption == "Add")
            //        {
            //            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            //            if (!hRMEMPLOYEE.Exist(this.txtID.Text))
            //            {
            //                if (this.uc_Save() != "OK")
            //                {
            //                    return;
            //                }
            //            }
            //            hRMEMPLOYEE.Get(this.txtID.Text);
            //            base.Status = Actions.Update;
            //            this.SetData(hRMEMPLOYEE);
            //            xfmContractAdd _xfmContractAdd = new xfmContractAdd(Actions.Add, this.txtID.Text);
            //            _xfmContractAdd.Added += new xfmContractAdd.AddedEventHander((object s, HRM_CONTRACT i) =>
            //            {
            //                this.AddComboboxEdit(this.cboContractCode, i.ContractCode);
            //                if (this.cboPayForm.SelectedIndex == 1)
            //                {
            //                    this.calPayMoney.EditValue = i.BasicSalary;
            //                    this.calBasicSalary.EditValue = i.BasicSalary;
            //                    this.calInsuranceSalary.EditValue = i.BasicSalary;
            //                    this.dtDateSalary.DateTime = i.SignDate;
            //                }
            //            });
            //            _xfmContractAdd.ShowDialog();
            //            goto Label1;
            //        }
            //        else
            //        {
            //            if (caption != "Edit")
            //            {
            //                goto Label1;
            //            }
            //            if (this.cboContractCode.Text != "")
            //            {
            //                HRM_CONTRACT hRMCONTRACT1 = new HRM_CONTRACT();
            //                if (hRMCONTRACT1.Exist(this.cboContractCode.Text))
            //                {
            //                    hRMCONTRACT1.Get(this.cboContractCode.Text);
            //                    xfmContractAdd _xfmContractAdd1 = new xfmContractAdd(Actions.Update, hRMCONTRACT1);
            //                    _xfmContractAdd1.Updated += new xfmContractAdd.UpdatedEventHander((object s, HRM_CONTRACT i) =>
            //                    {
            //                        hRMCONTRACT1.Get(this.cboContractCode.EditValue.ToString());
            //                        this.cboContractType.SelectedIndex = hRMCONTRACT1.ContractType;
            //                        this.dtContractSignDate.DateTime = hRMCONTRACT1.SignDate;
            //                        this.dtContractFromDate.DateTime = hRMCONTRACT1.FromDate;
            //                        this.dtContractToDate.DateTime = hRMCONTRACT1.ToDate;
            //                    });
            //                    _xfmContractAdd1.ShowDialog();
            //                }
            //            }
            //            goto Label1;
            //        }
            //    }
            //Label1:
            //}
        }

        private void cboContractCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
            hRMCONTRACT.Get(this.cboContractCode.EditValue.ToString());
            this.cboContractType.SelectedIndex = hRMCONTRACT.ContractType;
            this.dtContractSignDate.DateTime = hRMCONTRACT.SignDate;
            this.dtContractFromDate.DateTime = hRMCONTRACT.FromDate;
            this.dtContractToDate.DateTime = hRMCONTRACT.ToDate;
        }

        private void cboPayForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboPayForm.SelectedIndex != 0)
            {
                this.calPayMoney.Enabled = true;
                this.glkRankSalary.Enabled = false;
                this.cboStepSalary.Enabled = false;
                this.calBasicSalary.EditValue = this.calPayMoney.EditValue;
                this.calInsuranceSalary.EditValue = this.calPayMoney.EditValue;
            }
            else
            {
                this.calPayMoney.Enabled = false;
                this.glkRankSalary.Enabled = true;
                this.cboStepSalary.Enabled = true;
                this.calInsuranceSalary.EditValue = this.calBasicSalary.EditValue;
            }
        }

        private void cboResidenceType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cboStepSalary_EditValueChanged(object sender, EventArgs e)
        {
            DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP();
            dICSALARYSTEP.Get(this.cboStepSalary.Text, this.glkRankSalary.EditValue.ToString());
            this.calCoefficient.EditValue = dICSALARYSTEP.Coefficient;
            this.calBasicSalary.EditValue = double.Parse(this.calCoefficient.Text) * double.Parse(this.calMinimumSalary.Text);
            this.calInsuranceSalary.EditValue = this.calBasicSalary.EditValue;
        }


        private void InitInterface()
        {
            MyRule.Get(MyLogin.RoleId, "bbiUsers");
            if (!MyRule.AllowAccess)
            {
                this.tabUser.PageVisible = false;
            }
        }
        private void cboTimeTest_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cboTimeTest.SelectedIndex == 0)
            {
                this.dtTestToDate.DateTime = DateAndTime.DateAdd(DateInterval.Month, 0, this.dtTestFromDate.DateTime);
            }
            else if (this.cboTimeTest.SelectedIndex == 1)
            {
                this.dtTestToDate.DateTime = DateAndTime.DateAdd(DateInterval.Month, 1, this.dtTestFromDate.DateTime);
            }
            else if (this.cboTimeTest.SelectedIndex != 2)
            {
                this.dtTestToDate.DateTime = DateAndTime.DateAdd(DateInterval.Month, 3, this.dtTestFromDate.DateTime);
            }
            else
            {
                this.dtTestToDate.DateTime = DateAndTime.DateAdd(DateInterval.Month, 2, this.dtTestFromDate.DateTime);
            }
            this.dtBeginDate.DateTime = DateAndTime.DateAdd(DateInterval.Day, 1, this.dtTestToDate.DateTime);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cheIsSecondIncomeTax_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.cheIsSecondIncomeTax.Checked)
            {
                this.calPercentSecondIncomeTax.Enabled = false;
            }
            else
            {
                this.calPercentSecondIncomeTax.Enabled = true;
            }
        }


        public new void Clear()
        {
            this.txtFirstName.Focus();
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.cboMariage.Text = "";
            this.txtBirthPlace.Text = "";
            this.txtMainAddress.Text = "";
            this.txtContactAddress.Text = "";
            this.txtCellPhone.Text = "";
            this.txtHomePhone.Text = "";
            this.txtEmail.Text = "";
            this.cboSchool.Text = "";
            this.txtIDCard.Text = "";
            this.dtIDCardDate.DateTime = DateTime.Now;
            this.txtIDCardPlace.Text = "";
            this.txtHealth.Text = "";
            this.calHeight.Text = "0";
            this.calWeight.Text = "0";
            this.txtIncomeTaxCode.Text = "";
            this.cboResidenceType.SelectedIndex = 0;
            this.dtInsuranceDate.DateTime = DateTime.Now;
            this.dtInsuranceDate.DateTime = DateTime.Now;
            this.dtHealthInsuranceFromDate.DateTime = DateTime.Now;
            this.dtHealthInsuranceToDate.DateTime = DateTime.Now;
            this.dtContractSignDate.DateTime = DateTime.Now;
            this.dtContractFromDate.DateTime = DateTime.Now;
            this.dtContractToDate.DateTime = DateTime.Now;
            this.dtTestFromDate.DateTime = DateTime.Now;
            this.dtTestToDate.DateTime = DateTime.Now;
            this.calTestSalary.Text = "0";
            this.calAllowance1.Text = "0";
            this.calAllowance2.Text = "0";
            this.calAllowance3.Text = "0";
            this.calAllowance4.Text = "0";
            this.dtBeginDate.DateTime = DateTime.Now;
            this.dtEndDate.DateTime = DateTime.Now;
            this.dtBankDate.DateTime = DateTime.Now;
            this.dtMilitaryFromDate.DateTime = DateTime.Now;
            this.dtMilitaryToDate.DateTime = DateTime.Now;
            this.dtPassportFromDate.DateTime = DateTime.Now;
            this.dtPassportToDate.DateTime = DateTime.Now;
            this.dtUnionDate.DateTime = DateTime.Now;
            this.dtPartyDate.DateTime = DateTime.Now;
            this.dtDateSalary.DateTime = DateTime.Now;
        }

        private void glkRankSalary_EditValueChanged(object sender, EventArgs e)
        {
            DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP();
            dICSALARYSTEP.AddComboEditByRank(this.cboStepSalary, this.glkRankSalary.EditValue.ToString());
            dICSALARYSTEP.Get(this.cboStepSalary.Text, this.glkRankSalary.EditValue.ToString());
            this.calCoefficient.EditValue = dICSALARYSTEP.Coefficient;
            this.calBasicSalary.EditValue = double.Parse(this.calCoefficient.Text) * double.Parse(this.calMinimumSalary.Text);
            this.calInsuranceSalary.EditValue = this.calBasicSalary.EditValue;
        }


        protected override void Init()
        {
            base.Init();
        }

        private HRM_EMPLOYEE InitClass()
        {
            HRM_EMPLOYEE hRMEMPLOYEE;
            SqlDateTime maxValue;
            DateTime dateTime;
            DateTime dateTime1;
            DateTime dateTime2;
            DateTime dateTime3;
            DateTime dateTime4;
            DateTime dateTime5;
            DateTime dateTime6;
            DateTime dateTime7;
            DateTime dateTime8;
            DateTime dateTime9;
            DateTime dateTime10;
            DateTime dateTime11;
            DateTime dateTime12;
            DateTime dateTime13;
            DateTime dateTime14;
            DateTime dateTime15;
            DateTime dateTime16;
            DateTime dateTime17;
            HRM_EMPLOYEE str = new HRM_EMPLOYEE()
            {
                EmployeeCode = this.txtID.Text.Trim(),
                FirstName = this.txtFirstName.Text.Trim(),
                LastName = this.txtLastName.Text.Trim(),
                Alias = this.txtAlias.Text,
                Sex = this.cheSex.Checked,
                BirthdayDay = this.xdeBirthday.Day,
                BirthdayMonth = this.xdeBirthday.Month,
                BirthdayYear = this.xdeBirthday.Year,
                Marriage = this.cboMariage.Text,
                BirthPlace = this.txtBirthPlace.Text,
                MainAddress = this.txtMainAddress.Text,
                ContactAddress = this.txtContactAddress.Text,
                CellPhone = this.txtCellPhone.Text,
                HomePhone = this.txtHomePhone.Text,
                Email = this.txtEmail.Text,
                Skype = this.txtSkype.Text,
                Yahoo = this.txtYahoo.Text,
                Facebook = this.txtFacebook.Text,
                Nationality = this.cboNationality.Text,
                Ethnic = this.cboEthnic.Text,
                Religion = this.cboReligion.Text,
                Education = this.cboEducation.Text,
                Language = this.cboLanguage.Text,
                Informatic = this.cboInformatic.Text,
                Professional = this.cboProfessional.Text
            };
            if (this.glkGroupRateCode.EditValue != null)
            {
                str.GroupRateCode = this.glkGroupRateCode.EditValue.ToString();
            }
            else
            {
                str.GroupRateCode = "";
            }
            str.School = this.cboSchool.Text;
            str.IDCard = this.txtIDCard.Text;
            str.IDCardDate = this.dtIDCardDate.DateTime;
            str.IDCardPlace = this.txtIDCardPlace.Text;
            str.Health = this.txtHealth.Text;
            str.Height = double.Parse(this.calHeight.Text);
            str.Weight = double.Parse(this.calWeight.Text);
            str.PayForm = this.cboPayForm.SelectedIndex;
            str.PayMoney = decimal.Parse(this.calPayMoney.EditValue.ToString());
            str.EnrollNumber = this.txtEnrollNumber.Text.Trim();
            str.IncomeTaxCode = this.txtIncomeTaxCode.Text;
            str.IsMandateTax = this.cheIsMandateTax.Checked;
            str.ResidenceType = this.cboResidenceType.SelectedIndex;
            if (this.cboStatus.SelectedIndex >= 2)
            {
                str.Status = 3;
            }
            else
            {
                str.Status = this.cboStatus.SelectedIndex;
            }
            str.ReasonLeave = this.cboReasonLeave.Text;
            str.Description = this.txtDescription.Text;
            str.SubsidiaryCode = this.xucOrganizationEdit1.SubsidiaryCode;
            str.BranchCode = this.xucOrganizationEdit1.BranchCode;
            str.DepartmentCode = this.xucOrganizationEdit1.DepartmentCode;
            str.GroupCode = this.xucOrganizationEdit1.GroupCode;
            if ((!(str.SubsidiaryCode == "") || !(str.BranchCode == "") ? true : !(str.DepartmentCode == "")))
            {
                str.Position = this.cboPosition.Text;
                if (this.glkRankSalary.EditValue == null)
                {
                    str.RankSalary = "";
                }
                else
                {
                    str.RankSalary = this.glkRankSalary.EditValue.ToString();
                }
                if (this.cboStepSalary.EditValue == null)
                {
                    str.StepSalary = 0;
                }
                else
                {
                    str.StepSalary = int.Parse(this.cboStepSalary.EditValue.ToString());
                }
                str.MinimumSalary = decimal.Parse(this.calMinimumSalary.EditValue.ToString());
                str.CoefficientSalary = double.Parse(this.calCoefficient.EditValue.ToString());

                HRM_EMPLOYEE hRMEMPLOYEE1 = str;
                if (this.dtDateSalary.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime = this.dtDateSalary.DateTime;
                }
                hRMEMPLOYEE1.DateSalary = dateTime;
                str.BasicSalary = decimal.Parse(this.calBasicSalary.EditValue.ToString());
                str.SalaryPeriod1 = decimal.Parse(this.calSalaryPeriod1.EditValue.ToString());
                str.InsuranceSalary = decimal.Parse(this.calInsuranceSalary.EditValue.ToString());
                str.IsFixedSalary = this.cheIsFixedSalary.Checked;
                str.Allowance1 = decimal.Parse(this.calAllowance1.EditValue.ToString());
                str.Allowance2 = decimal.Parse(this.calAllowance2.EditValue.ToString());
                str.Allowance3 = decimal.Parse(this.calAllowance3.EditValue.ToString());
                str.Allowance4 = decimal.Parse(this.calAllowance4.EditValue.ToString());
                str.IsYourSelfTax = this.cheIsYourSelfTax.Checked;
                str.IsSecondIncomeTax = this.cheIsSecondIncomeTax.Checked;
                str.PercentSecondIncomeTax = double.Parse(this.calPercentSecondIncomeTax.EditValue.ToString());
                str.IsSocialInsurance = this.cheSocialInsurance.Checked;
                str.IsHealthInsurance = this.cheHealthInsurance.Checked;
                str.IsUnemploymentInsurance = this.cheUnemploymentInsurance.Checked;
                str.IsUnionMoney = this.cheUnionMoney.Checked;
                str.IsTest = this.cheIsTest.Checked;
                str.TestTime = this.cboTimeTest.Text;
                HRM_EMPLOYEE hRMEMPLOYEE2 = str;
                if (this.dtTestFromDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime1 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime1 = this.dtTestFromDate.DateTime;
                }
                hRMEMPLOYEE2.TestFromDate = dateTime1;
                HRM_EMPLOYEE hRMEMPLOYEE3 = str;
                if (this.dtTestToDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime2 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime2 = this.dtTestToDate.DateTime;
                }
                hRMEMPLOYEE3.TestToDate = dateTime2;
                str.TestSalary = decimal.Parse(this.calTestSalary.EditValue.ToString());
                str.LaborCode = this.txtLaborCode.Text;
                HRM_EMPLOYEE hRMEMPLOYEE4 = str;
                if (this.dtInsuranceDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime3 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime3 = this.dtInsuranceDate.DateTime;
                }
                hRMEMPLOYEE4.LaborDate = dateTime3;
                str.LaborPlace = this.txtLaborPlace.Text;
                str.InsuranceCode = this.txtInsuranceCode.Text;
                HRM_EMPLOYEE hRMEMPLOYEE5 = str;
                if (this.dtInsuranceDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime4 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime4 = this.dtInsuranceDate.DateTime;
                }
                hRMEMPLOYEE5.InsuranceDate = dateTime4;
                str.InsurancePlace = this.txtInsurancePlace.Text;
                str.HealthInsuranceCode = this.txtHealthInsuranceCode.Text;
                HRM_EMPLOYEE hRMEMPLOYEE6 = str;
                if (this.dtHealthInsuranceFromDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime5 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime5 = this.dtHealthInsuranceFromDate.DateTime;
                }
                hRMEMPLOYEE6.HealthInsuranceFromDate = dateTime5;
                HRM_EMPLOYEE hRMEMPLOYEE7 = str;
                if (this.dtHealthInsuranceToDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime6 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime6 = this.dtHealthInsuranceToDate.DateTime;
                }
                hRMEMPLOYEE7.HealthInsuranceToDate = dateTime6;
                str.ContractCode = this.cboContractCode.Text;
                str.ContractType = this.cboContractType.Text;
                HRM_EMPLOYEE hRMEMPLOYEE8 = str;
                if (this.dtContractSignDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime7 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime7 = this.dtContractSignDate.DateTime;
                }
                hRMEMPLOYEE8.ContractSignDate = dateTime7;
                HRM_EMPLOYEE hRMEMPLOYEE9 = str;
                if (this.dtContractFromDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime8 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime8 = this.dtContractFromDate.DateTime;
                }
                hRMEMPLOYEE9.ContractFromDate = dateTime8;
                HRM_EMPLOYEE hRMEMPLOYEE10 = str;
                if (this.dtContractToDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime9 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime9 = this.dtContractToDate.DateTime;
                }
                hRMEMPLOYEE10.ContractToDate = dateTime9;
                str.Province = this.cboProvince.Text;
                str.Hospital = this.cboHospital.Text;
                str.BeginDate = this.dtBeginDate.DateTime;
                str.IsOffWork = this.cheIsOffWork.Checked;
                HRM_EMPLOYEE hRMEMPLOYEE11 = str;
                if (this.dtEndDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime10 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime10 = this.dtEndDate.DateTime;
                }
                hRMEMPLOYEE11.EndDate = dateTime10;
                str.BankCode = this.txtBankCode.Text;
                HRM_EMPLOYEE hRMEMPLOYEE12 = str;
                if (this.dtBankDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime11 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime11 = this.dtBankDate.DateTime;
                }
                hRMEMPLOYEE12.BankDate = dateTime11;
                str.BankName = this.txtBankName.Text;
                str.BankBranch = this.txtBankBranch.Text;
                str.BankCity = this.txtBankCity.Text;
                str.BankAddress = this.txtBankCity.Text;
                str.MilitaryCode = this.txtMilitaryCode.Text;
                HRM_EMPLOYEE hRMEMPLOYEE13 = str;
                if (this.dtMilitaryFromDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime12 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime12 = this.dtMilitaryFromDate.DateTime;
                }
                hRMEMPLOYEE13.MilitaryFromDate = dateTime12;
                HRM_EMPLOYEE hRMEMPLOYEE14 = str;
                if (this.dtMilitaryToDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime13 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime13 = this.dtMilitaryToDate.DateTime;
                }
                hRMEMPLOYEE14.MilitaryToDate = dateTime13;
                str.MilitaryPosition = this.txtMilitaryPosition.Text;
                str.PassportCode = this.txtPassportCode.Text;
                HRM_EMPLOYEE hRMEMPLOYEE15 = str;
                if (this.dtPassportFromDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime14 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime14 = this.dtPassportFromDate.DateTime;
                }
                hRMEMPLOYEE15.PassportFromDate = dateTime14;
                HRM_EMPLOYEE hRMEMPLOYEE16 = str;
                if (this.dtPassportToDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime15 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime15 = this.dtPassportToDate.DateTime;
                }
                hRMEMPLOYEE16.PassportToDate = dateTime15;
                str.IsParty = this.cheIsParty.Checked;
                str.PartyCode = this.txtPartyCode.Text;
                HRM_EMPLOYEE hRMEMPLOYEE17 = str;
                if (this.dtPartyDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime16 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime16 = this.dtPartyDate.DateTime;
                }
                hRMEMPLOYEE17.PartyDate = dateTime16;
                str.PartyPlace = this.txtPartyPlace.Text;
                str.IsUnion = this.cheIsUnion.Checked;
                str.UnionCode = this.txtUnionCode.Text;
                HRM_EMPLOYEE hRMEMPLOYEE18 = str;
                if (this.dtUnionDate.Text == "")
                {
                    maxValue = SqlDateTime.MaxValue;
                    dateTime17 = Convert.ToDateTime(maxValue.ToString());
                }
                else
                {
                    dateTime17 = this.dtUnionDate.DateTime;
                }
                hRMEMPLOYEE18.UnionDate = dateTime17;
                str.UnionPlace = this.txtUnionPlace.Text;
                hRMEMPLOYEE = str;
            }
            else
            {
                XtraMessageBox.Show("Bạn phải chọn đơn vị làm việc cho nhân viên là Công ty con, chi nhánh, phòng ban, tổ nhóm!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.xucOrganizationEdit1.Focus();
                this.DoHide();
                hRMEMPLOYEE = null;
            }
            return hRMEMPLOYEE;
        }


        private void InitContract()
        {
            this.cboContractCode.Properties.Items.Clear();
            (new HRM_CONTRACT()).AddComboEdit(this.cboContractCode, this.txtID.Text);
        }

       
       
     



        private void RaiseInputEmployeeNameHandler(string EmployeeName)
        {
            if (this.InputEmployeeName != null)
            {
                this.InputEmployeeName(this, EmployeeName);
            }
        }

        private void RaiseSuccessEventHander(HRM_EMPLOYEE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        private void SaveContract()
        {
        }


      

        private void SaveDegree()
        {
            foreach (CheckedListBoxItem item in this.chcDegree.Properties.Items)
            {
                HRM_EMPLOYEE_DEGREE hRMEMPLOYEEDEGREE = new HRM_EMPLOYEE_DEGREE();
                if (item.CheckState == CheckState.Unchecked)
                {
                    if (hRMEMPLOYEEDEGREE.Exist(this.txtID.Text, item.Value.ToString()))
                    {
                        hRMEMPLOYEEDEGREE.Delete(this.txtID.Text, item.Value.ToString());
                    }
                }
                else if (item.CheckState == CheckState.Checked)
                {
                    if (!hRMEMPLOYEEDEGREE.Exist(this.txtID.Text, item.Value.ToString()))
                    {
                        hRMEMPLOYEEDEGREE.Insert(this.txtID.Text, item.Value.ToString());
                    }
                }
            }
        }

        private void SaveProcessPosition()
        {
            if ((this.m_OldSubsidiaryCode != this.xucOrganizationEdit1.SubsidiaryCode || this.m_OldBranchCode != this.xucOrganizationEdit1.BranchCode || this.m_OldDepartmentCode != this.xucOrganizationEdit1.DepartmentCode || this.m_OldGroupCode != this.xucOrganizationEdit1.GroupCode ? true : this.m_OldPosition != this.cboPosition.Text))
            {
                if (XtraMessageBox.Show("Bạn đã thay đổi đơn vị làm việc hoặc chức vụ của nhân viên này!\r\nBạn có muốn lưu vào quá trình làm việc của nhân viên này hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    HRM_PROCESS_POSITION hRMPROCESSPOSITION = new HRM_PROCESS_POSITION()
                    {
                        PositionID = Guid.NewGuid(),
                        EmployeeCode = this.txtID.Text,
                        OldSubsidiaryCode = this.m_OldSubsidiaryCode,
                        OldBranchCode = this.m_OldBranchCode,
                        OldDepartmentCode = this.m_OldDepartmentCode,
                        OldGroupCode = this.m_OldGroupCode,
                        OldOrganization = HRM_ORGANIZATION.GetOrganizationOnFull(this.m_OldSubsidiaryCode, this.m_OldBranchCode, this.m_OldDepartmentCode, this.m_OldGroupCode),
                        OldPosition = this.m_OldPosition,
                        NewSubsidiaryCode = this.xucOrganizationEdit1.SubsidiaryCode,
                        NewBranchCode = this.xucOrganizationEdit1.BranchCode,
                        NewDepartmentCode = this.xucOrganizationEdit1.DepartmentCode,
                        NewGroupCode = this.xucOrganizationEdit1.GroupCode,
                        NewOrganization = this.xucOrganizationEdit1.ppContainerEdit.Text,
                        NewPosition = this.cboPosition.Text,
                        Date = DateTime.Now,
                        Reason = "",
                        DecideNumber = "",
                        Person = ""
                    };
                    hRMPROCESSPOSITION.Insert();
                }
            }
        }

        public void SetData(HRM_EMPLOYEE item)
        {
            this.txtID.Text = item.EmployeeCode;
         //   SYS_LOG.Insert("Danh Sách Nhân Viên", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtFirstName.Text = item.FirstName;
            this.txtLastName.Text = item.LastName;
            this.txtAlias.Text = item.Alias;
            this.cheSex.Checked = item.Sex;
            this.xdeBirthday.Day = item.BirthdayDay;
            this.xdeBirthday.Month = item.BirthdayMonth;
            this.xdeBirthday.Year = item.BirthdayYear;
            this.cboMariage.Text = item.Marriage;
            this.txtBirthPlace.Text = item.BirthPlace;
            this.txtMainAddress.Text = item.MainAddress;
            this.txtContactAddress.Text = item.ContactAddress;
            this.txtCellPhone.Text = item.CellPhone;
            this.txtHomePhone.Text = item.HomePhone;
            this.txtEmail.Text = item.Email;
            this.txtSkype.Text = item.Skype;
            this.txtYahoo.Text = item.Yahoo;
            this.txtFacebook.Text = item.Facebook;
            this.imgPhoto.Image = item.Photo;
            this.cboNationality.Text = item.Nationality;
            this.cboEthnic.Text = item.Ethnic;
            this.cboReligion.Text = item.Religion;
            this.cboEducation.Text = item.Education;
            this.cboLanguage.Text = item.Language;
            this.cboInformatic.Text = item.Informatic;
            this.cboProfessional.Text = item.Professional;
            this.glkGroupRateCode.EditValue = item.GroupRateCode;
            this.cboSchool.Text = item.School;
            this.txtIDCard.Text = item.IDCard;
            this.dtIDCardDate.DateTime = item.IDCardDate;
            this.txtIDCardPlace.Text = item.IDCardPlace;
            this.txtHealth.Text = item.Health;
            this.calHeight.Text = item.Height.ToString();
            this.calWeight.Text = item.Weight.ToString();
            this.cboPayForm.SelectedIndex = item.PayForm;
            this.calPayMoney.EditValue = item.PayMoney;
            this.txtEnrollNumber.Text = item.EnrollNumber;
            this.txtIncomeTaxCode.Text = item.IncomeTaxCode;
            this.cheIsMandateTax.Checked = item.IsMandateTax;
            this.cboResidenceType.SelectedIndex = item.ResidenceType;
            this.cboReasonLeave.Text = item.ReasonLeave;
            this.txtDescription.Text = item.Description;
            if (item.Status >= 2)
            {
                this.cboStatus.SelectedIndex = 2;
            }
            else
            {
                this.cboStatus.SelectedIndex = item.Status;
            }
            this.xucOrganizationEdit1.SelectOrganization(item.SubsidiaryCode, item.BranchCode, item.DepartmentCode, item.GroupCode);
            this.m_OldSubsidiaryCode = item.SubsidiaryCode;
            this.m_OldBranchCode = item.BranchCode;
            this.m_OldDepartmentCode = item.DepartmentCode;
            this.m_OldGroupCode = item.GroupCode;
            this.m_OldPosition = item.Position;
            this.cboPosition.Text = item.Position;
            this.glkRankSalary.EditValue = item.RankSalary;
            this.cboStepSalary.EditValue = item.StepSalary;
            if (!(item.DateSalary == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtDateSalary.DateTime = item.DateSalary;
            }
            else
            {
                this.dtDateSalary.Text = "";
            }
            this.calBasicSalary.EditValue = item.BasicSalary;
            this.calSalaryPeriod1.EditValue = item.SalaryPeriod1;
            this.calInsuranceSalary.EditValue = item.InsuranceSalary;
            this.cheIsFixedSalary.Checked = item.IsFixedSalary;
            this.calAllowance1.EditValue = item.Allowance1;
            this.calAllowance2.EditValue = item.Allowance2;
            this.calAllowance3.EditValue = item.Allowance3;
            this.calAllowance4.EditValue = item.Allowance4;
            this.calMinimumSalary.EditValue = item.MinimumSalary;
            this.cheIsYourSelfTax.Checked = item.IsYourSelfTax;
            this.cheIsSecondIncomeTax.Checked = item.IsSecondIncomeTax;
            this.calPercentSecondIncomeTax.EditValue = item.PercentSecondIncomeTax;
            this.cheSocialInsurance.Checked = item.IsSocialInsurance;
            this.cheHealthInsurance.Checked = item.IsHealthInsurance;
            this.cheUnemploymentInsurance.Checked = item.IsUnemploymentInsurance;
            this.cheUnionMoney.Checked = item.IsUnionMoney;
            this.cheIsTest.Checked = item.IsTest;
            this.cboTimeTest.Text = item.TestTime;
            if (!(item.TestFromDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtTestFromDate.DateTime = item.TestFromDate;
            }
            else
            {
                this.dtTestFromDate.Text = "";
            }
            if (!(item.TestToDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtTestToDate.DateTime = item.TestToDate;
            }
            else
            {
                this.dtTestToDate.Text = "";
            }
            this.calTestSalary.EditValue = item.TestSalary;
            this.txtLaborCode.Text = item.LaborCode;
            if (!(item.LaborDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtInsuranceDate.DateTime = item.LaborDate;
            }
            else
            {
                this.dtInsuranceDate.Text = "";
            }
            this.txtLaborPlace.Text = item.LaborPlace;
            this.txtInsuranceCode.Text = item.InsuranceCode;
            if (!(item.InsuranceDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtInsuranceDate.DateTime = item.InsuranceDate;
            }
            else
            {
                this.dtInsuranceDate.Text = "";
            }
            this.txtInsurancePlace.Text = item.InsurancePlace;
            this.txtHealthInsuranceCode.Text = item.HealthInsuranceCode;
            if (!(item.HealthInsuranceFromDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtHealthInsuranceFromDate.DateTime = item.HealthInsuranceFromDate;
            }
            else
            {
                this.dtHealthInsuranceFromDate.Text = "";
            }
            if (!(item.HealthInsuranceToDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtHealthInsuranceToDate.DateTime = item.HealthInsuranceToDate;
            }
            else
            {
                this.dtHealthInsuranceToDate.Text = "";
            }
            this.cboContractCode.Text = item.ContractCode;
            this.cboContractType.Text = item.ContractType;
            if (!(item.ContractSignDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtContractSignDate.DateTime = item.ContractSignDate;
            }
            else
            {
                this.dtContractSignDate.Text = "";
            }
            if (!(item.ContractFromDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtContractFromDate.DateTime = item.ContractFromDate;
            }
            else
            {
                this.dtContractFromDate.Text = "";
            }
            if (!(item.ContractToDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtContractToDate.DateTime = item.ContractToDate;
            }
            else
            {
                this.dtContractToDate.Text = "";
            }
            this.cboProvince.Text = item.Province;
            this.cboHospital.Text = item.Hospital;
            this.dtBeginDate.DateTime = item.BeginDate;
            this.cheIsOffWork.Checked = item.IsOffWork;
            if (!(item.EndDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtEndDate.DateTime = item.EndDate;
            }
            else
            {
                this.dtEndDate.Text = "";
            }
            this.txtBankCode.Text = item.BankCode;
            if (!(item.BankDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtBankDate.DateTime = item.BankDate;
            }
            else
            {
                this.dtBankDate.Text = "";
            }
            this.txtBankName.Text = item.BankName;
            this.txtBankBranch.Text = item.BankBranch;
            this.txtBankCity.Text = item.BankCity;
            this.txtBankCity.Text = item.BankAddress;
            this.txtMilitaryCode.Text = item.MilitaryCode;
            if (!(item.MilitaryFromDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtMilitaryFromDate.DateTime = item.MilitaryFromDate;
            }
            else
            {
                this.dtMilitaryFromDate.Text = "";
            }
            if (!(item.MilitaryToDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtMilitaryToDate.DateTime = item.MilitaryToDate;
            }
            else
            {
                this.dtMilitaryToDate.Text = "";
            }
            this.txtMilitaryPosition.Text = item.MilitaryPosition;
            this.txtPassportCode.Text = item.PassportCode;
            if (!(item.PassportFromDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtPassportFromDate.DateTime = item.PassportFromDate;
            }
            else
            {
                this.dtPassportFromDate.Text = "";
            }
            if (!(item.PassportToDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtPassportToDate.DateTime = item.PassportToDate;
            }
            else
            {
                this.dtPassportToDate.Text = "";
            }
            this.cheIsParty.Checked = item.IsParty;
            this.txtPartyCode.Text = item.PartyCode;
            if (!(item.PartyDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtPartyDate.DateTime = item.PartyDate;
            }
            else
            {
                this.dtPartyDate.Text = "";
            }
            this.txtPartyPlace.Text = item.PartyPlace;
            this.cheIsUnion.Checked = item.IsUnion;
            this.txtUnionCode.Text = item.UnionCode;
            if (!(item.UnionDate == Convert.ToDateTime(SqlDateTime.MaxValue.ToString())))
            {
                this.dtUnionDate.DateTime = item.UnionDate;
            }
            else
            {
                this.dtUnionDate.Text = "";
            }
            this.txtUnionPlace.Text = item.UnionPlace;
            this.InitDegree();
            this.InitContract();
        }

        private void txtFirstName_EditValueChanged(object sender, EventArgs e)
        {
            string[] text = new string[] { this.txtFirstName.Text, " ", this.txtLastName.Text, " (", this.txtID.Text, ")" };
            this.RaiseInputEmployeeNameHandler(string.Concat(text));
        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new HRM_EMPLOYEE()).Exist(textEdit.Text))
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
                HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
                if (this.m_Status == Actions.Add)
                {
                    if (hRMEMPLOYEE.Exist(textEdit.Text))
                    {
                        this.Err.SetError(textEdit, "Mã đã tồn tại.");
                        textEdit.Focus();
                    }
                }
            }
        }

        private void txtLastName_EditValueChanged(object sender, EventArgs e)
        {
            string[] text = new string[] { this.txtFirstName.Text, " ", this.txtLastName.Text, " (", this.txtID.Text, ")" };
            this.RaiseInputEmployeeNameHandler(string.Concat(text));
        }


        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE()
            {
                EmployeeCode = this.txtID.Text
            };
            string str = hRMEMPLOYEE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(hRMEMPLOYEE);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiEmployee") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
               // SYS_LOG.Insert("Danh Sách Nhân Viên", "Thêm", this.txtID.Text);
                Cursor.Current = Cursors.WaitCursor;
                HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
                HRM_EMPLOYEE hRMEMPLOYEE1 = this.InitClass();
                hRMEMPLOYEE = hRMEMPLOYEE1;
                if (hRMEMPLOYEE1 != null)
                {
                    base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                    string str1 = hRMEMPLOYEE.Insert();
                    if (str1 == "OK")
                    {
                        this.RaiseSuccessEventHander(hRMEMPLOYEE);
                    }
                    Cursor.Current = Cursors.Default;
                    if (str1 != "OK")
                    {
                        XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    str1 = hRMEMPLOYEE.Update(this.txtID.Text, this.imgPhoto.Image);
                    if (str1 != "OK")
                    {
                        this.DoHide();
                    }
                    if (this.xucAllowance != null)
                    {
                        this.xucAllowance.Save();
                    }
                    //if (this.xucRelative != null)
                    //{
                    //    this.xucRelative.Save();
                    //}
                    //if (this.xucSchedule != null)
                    //{
                    //    this.xucSchedule.Save();
                    //}
                    //if (this.xucActivity != null)
                    //{
                    //    this.xucActivity.Save();
                    //    //}
                    this.SaveDegree();
                    this.SaveContract();
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
                MyRule.Notify();
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiEmployee") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
              //  SYS_LOG.Insert("Danh Sách Nhân Viên", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
                HRM_EMPLOYEE hRMEMPLOYEE1 = this.InitClass();
                hRMEMPLOYEE = hRMEMPLOYEE1;
                if (hRMEMPLOYEE1 != null)
                {
                    string str1 = hRMEMPLOYEE.Update();
                    if (str1 == "OK")
                    {
                        this.RaiseSuccessEventHander(hRMEMPLOYEE);
                    }
                    if (str1 != "OK")
                    {
                        XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    str1 = hRMEMPLOYEE.Update(this.txtID.Text, this.imgPhoto.Image);
                    if (!(str1 != "OK"))
                    {
                        if (this.xucAllowance != null)
                        {
                            this.xucAllowance.Save();
                        }
                        //if (this.xucRelative != null)
                        //{
                        //    this.xucRelative.Save();
                        //}
                        //if (this.xucSchedule != null)
                        //{
                        //    this.xucSchedule.Save();
                        //}
                        //if (this.xucActivity != null)
                        //{
                        //    this.xucActivity.Save();
                        //}
                        this.DoHide();
                        this.SaveDegree();
                        this.SaveProcessPosition();
                        str = str1;
                    }
                    else
                    {
                        XtraMessageBox.Show(str1, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        str = str1;
                    }
                }
                else
                {
                    str = "FALSE";
                }
            }
            else
            {
                MyRule.Notify();
                str = "";
            }
            return str;
        }

        private void TabControl_Selected(object sender, TabPageEventArgs e)
        {
            if (e.Page == this.tabAllowance)
            {
                if (this.xucAllowance == null)
                {
                    //this.xucAllowance = new xucAllowance(this.txtID.Text)
                    //{
                    //    Dock = DockStyle.Fill
                    //};
                    //this.gbAllowance.Controls.Add(this.xucAllowance);
                    this.xucAllowance.Init();
                }
            }
            //else if (e.Page == this.tabPersonContact)
            //{
            //    if (this.xucRelative == null)
            //    {
            //        this.xucRelative = new xucRelative(this.txtID.Text)
            //        {
            //            Dock = DockStyle.Fill
            //        };
            //        this.tabPersonContact.Controls.Add(this.xucRelative);
            //        this.xucRelative.Init();
            //    }
            //}
            //else if (e.Page == this.tabSchedule)
            //{
            //    if (this.xucSchedule == null)
            //    {
            //        this.xucSchedule = new xucSchedule(this.txtID.Text)
            //        {
            //            Dock = DockStyle.Fill
            //        };
            //        this.tabSchedule.Controls.Add(this.xucSchedule);
            //        this.xucSchedule.BringToFront();
            //    }
            //}
            //else if (e.Page == this.tabActivity)
            //{
            //    if (this.xucActivity == null)
            //    {
            //        this.xucActivity = new xucActivity(this.txtID.Text)
            //        {
            //            Dock = DockStyle.Fill
            //        };
            //        this.tabActivity.Controls.Add(this.xucActivity);
            //        this.xucActivity.Init();
            //    }
            //}
        }


        public event xucEmployeeAdd.InputEmployeeNameHandler InputEmployeeName;

        public event xucEmployeeAdd.SuccessEventHander Success;

        public delegate void InputEmployeeNameHandler(object sender, string EmployeeName);

        public delegate void SuccessEventHander(object sender, HRM_EMPLOYEE item);

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBankCity_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tabBasicInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabWorkInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboStatus.SelectedIndex != 2)
            {
                this.lcReasonLeave3.Visibility = LayoutVisibility.Never;
            }
            else
            {
                this.lcReasonLeave3.Visibility = LayoutVisibility.Always;
            }
        }



        private void glk_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                string name = (sender as GridLookUpEdit).Name;
                if (name != null)
                {
                    if (name == "glkRankSalary")
                    {
                        xfmRankAdd _xfmRankAdd = new xfmRankAdd(Actions.Add);
                        _xfmRankAdd.Added += new xfmRankAdd.AddedEventHander((object s, DIC_SALARY_RANK i) => (new DIC_SALARY_STEP()).AddComboEditByRank(this.cboStepSalary, this.glkRankSalary.EditValue.ToString()));
                        _xfmRankAdd.ShowDialog();
                        goto Label0;
                    }
                    else
                    {
                        if (name != "glkGroupRateCode")
                        {
                            goto Label0;
                        }
                        xfmGroupRateAdd _xfmGroupRateAdd = new xfmGroupRateAdd(Actions.Add);
                        _xfmGroupRateAdd.Added += new xfmGroupRateAdd.AddedEventHander((object s, DIC_GROUP_RATE i) => (new DIC_GROUP_RATE()).AddGridLookupEdit(this.glkGroupRateCode));
                        _xfmGroupRateAdd.ShowDialog();
                        goto Label0;
                    }
                }
                Label0:;
            }
        }




        private void chc_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                string name = (sender as CheckedComboBoxEdit).Name;
                if (name != null)
                {
                    if (name != "chcDegree")
                    {
                        goto Label0;
                    }
                    xfmDegreeAdd _xfmDegreeAdd = new xfmDegreeAdd(Actions.Add);
                    _xfmDegreeAdd.Added += new xfmDegreeAdd.AddedEventHander((object s, DIC_DEGREE i) => this.AddCheckedComboboxEdit(this.chcDegree, i.DegreeName, i.DegreeCode));
                    _xfmDegreeAdd.ShowDialog();
                }
                Label0:;
            }
        }

        private void cheIsReside_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void glkRankSalary_EditValueChanged_1(object sender, EventArgs e)
        {
            DIC_SALARY_STEP dICSALARYSTEP = new DIC_SALARY_STEP();
            dICSALARYSTEP.AddComboEditByRank(this.cboStepSalary, this.glkRankSalary.EditValue.ToString());
            dICSALARYSTEP.Get(this.cboStepSalary.Text, this.glkRankSalary.EditValue.ToString());
            this.calCoefficient.EditValue = dICSALARYSTEP.Coefficient;
            this.calBasicSalary.EditValue = double.Parse(this.calCoefficient.Text) * double.Parse(this.calMinimumSalary.Text);
            this.calInsuranceSalary.EditValue = this.calBasicSalary.EditValue;
        }

        private void glkRankSalary_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

        }

        private void cboPayForm_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cboPayForm.SelectedIndex != 0)
            {
                this.calPayMoney.Enabled = true;
                this.glkRankSalary.Enabled = false;
                this.cboStepSalary.Enabled = false;
                this.calBasicSalary.EditValue = this.calPayMoney.EditValue;
                this.calInsuranceSalary.EditValue = this.calPayMoney.EditValue;
            }
            else
            {
                this.calPayMoney.Enabled = false;
                this.glkRankSalary.Enabled = true;
                this.cboStepSalary.Enabled = true;
                this.calInsuranceSalary.EditValue = this.calBasicSalary.EditValue;
            }
        }

        private void calPayMoney_EditValueChanged_1(object sender, EventArgs e)
        {
            this.calBasicSalary.EditValue = this.calPayMoney.EditValue;
            this.calInsuranceSalary.EditValue = this.calPayMoney.EditValue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void xucEmployeeAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
