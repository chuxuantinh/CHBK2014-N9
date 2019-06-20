using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using Microsoft.VisualBasic;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class ;
using CHBK2014_N9.Common.Enviroment;
using CHBK2014_N9.Common.Report;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core.Class;
using CHBK2014_N9.HumanResource.Core.Process;
using CHBK2014_N9.HumanResource.Report;
using CHBK2014_N9.Net.Info;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucSalaryCard : xucBase
    {

        private HRM_EMPLOYEE l_Employee = new HRM_EMPLOYEE();
        private Guid m_SalaryTableListID = Guid.Empty;

        private string m_EmployeeCode;

        private int m_Month;

        private int m_Year;
        public xucSalaryCard()
        {
            InitializeComponent();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xfmReport _xfmReport = new xfmReport();
            //clsOptionPrintSalary _clsOptionPrintSalary = new clsOptionPrintSalary();
            //if (_clsOptionPrintSalary.Theme == 0)
            //{
            //    rptSalary _rptSalary = new rptSalary(this.m_Month, this.m_Year, this.m_EmployeeCode);
            //    _xfmReport.SetTitle(string.Concat("Phiếu Lương Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //    _xfmReport.ShowPrintPreview(_rptSalary);
            //}
            //else if (_clsOptionPrintSalary.Theme == 1)
            //{
            //    rptSalary2 _rptSalary2 = new rptSalary2(this.m_Month, this.m_Year, this.m_EmployeeCode);
            //    _xfmReport.SetTitle(string.Concat("Phiếu Lương Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //    _xfmReport.ShowPrintPreview(_rptSalary2);
            //}
            //else if (_clsOptionPrintSalary.Theme != 2)
            //{
            //    rptSalary4 _rptSalary4 = new rptSalary4(this.m_Month, this.m_Year, this.m_EmployeeCode);
            //    _xfmReport.SetTitle(string.Concat("Phiếu Lương Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //    _xfmReport.ShowPrintPreview(_rptSalary4);
            //}
            //else
            //{
            //    rptSalary3 _rptSalary3 = new rptSalary3(this.m_Month, this.m_Year, this.m_EmployeeCode);
            //    _xfmReport.SetTitle(string.Concat("Phiếu Lương Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //    _xfmReport.ShowPrintPreview(_rptSalary3);
            //}
        }

        private void bbiPrintAllowance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xfmReport _xfmReport = new xfmReport();
            //rptSalaryAllowanceByEmployee _rptSalaryAllowanceByEmployee = new rptSalaryAllowanceByEmployee(this.m_Month, this.m_Year, this.m_EmployeeCode);
            //_xfmReport.SetTitle(string.Concat("Bảng Lương Phụ Cấp Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //_xfmReport.ShowPrintPreview(_rptSalaryAllowanceByEmployee);

           

        }

        private void bbiPrintSalaryPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xfmReport _xfmReport = new xfmReport();
            //rptSalaryPayByEmployee _rptSalaryPayByEmployee = new rptSalaryPayByEmployee(this.m_SalaryTableListID, this.m_EmployeeCode);
            //_xfmReport.SetTitle(string.Concat("Phiếu Thanh Toán Lương Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //_xfmReport.ShowPrintPreview(_rptSalaryPayByEmployee);


           

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xfmReport _xfmReport = new xfmReport();
            //rptListAdvanceByEmployee _rptListAdvanceByEmployee = new rptListAdvanceByEmployee(this.m_EmployeeCode, new DateTime(this.m_Year, this.m_Month, 1), DateAndTime.DateAdd(DateInterval.Day, -1, new DateTime(this.m_Year, this.m_Month + 1, 1)));
            //_xfmReport.SetTitle(string.Concat("Bảng Tạm Ứng Lương Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //_xfmReport.ShowPrintPreview(_rptListAdvanceByEmployee);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xfmReport _xfmReport = new xfmReport();
            //rptListAssignmentByEmployee _rptListAssignmentByEmployee = new rptListAssignmentByEmployee(this.m_EmployeeCode, new DateTime(this.m_Year, this.m_Month, 1), DateAndTime.DateAdd(DateInterval.Day, -1, new DateTime(this.m_Year, this.m_Month + 1, 1)));
            //_xfmReport.SetTitle(string.Concat("Bảng Công Tác Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //_xfmReport.ShowPrintPreview(_rptListAssignmentByEmployee);

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xfmReport _xfmReport = new xfmReport();
            //rptSalaryDebitByEmployee _rptSalaryDebitByEmployee = new rptSalaryDebitByEmployee(this.m_SalaryTableListID, this.m_EmployeeCode);
            //_xfmReport.SetTitle(string.Concat("Phiếu Ghi Nợ Lương Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //_xfmReport.ShowPrintPreview(_rptSalaryDebitByEmployee);

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xfmReport _xfmReport = new xfmReport();
            //rptSalaryMinusByEmployee _rptSalaryMinusByEmployee = new rptSalaryMinusByEmployee(this.m_Month, this.m_Year, this.m_EmployeeCode);
            //_xfmReport.SetTitle(string.Concat("Bảng Khấu Trừ Khác Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //_xfmReport.ShowPrintPreview(_rptSalaryMinusByEmployee);

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xfmReport _xfmReport = new xfmReport();
            //rptSalaryPlusByEmployee _rptSalaryPlusByEmployee = new rptSalaryPlusByEmployee(this.m_Month, this.m_Year, this.m_EmployeeCode);
            //_xfmReport.SetTitle(string.Concat("Bảng Thu Nhập Khác Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
            //_xfmReport.ShowPrintPreview(_rptSalaryPlusByEmployee);
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.SetWaitDialogCaption("Đang lưu dữ liệu...");
            if (this.xucSalaryAllowanceByEmployee != null)
            {
                this.xucSalaryAllowanceByEmployee.Save();
            }
            if (this.xucAdvance != null)
            {
                this.xucAdvance.Save();
            }
            if (this.xucSalaryPayByEmployee != null)
            {
                this.xucSalaryPayByEmployee.Save();
            }
            if (this.xucSalaryDebitByEmployee != null)
            {
                this.xucSalaryDebitByEmployee.Save();
            }
            if (this.xucAssignment != null)
            {
                this.xucAssignment.Save();
            }
            if (this.xucSalaryPlus != null)
            {
                this.xucSalaryPlus.Save();
            }
            if (this.xucSalaryMinus != null)
            {
                this.xucSalaryMinus.Save();
            }
            this.SetData(this.m_SalaryTableListID, this.m_EmployeeCode, this.m_Month, this.m_Year);
            this.RaiseUpdatedHander();
            this.DoHide();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (!WinInet.IsConnectedToInternet())
            //{
            //    XtraMessageBox.Show("Vui lòng kiểm tra lại kết nối với mạng internet!");
            //}
            //else
            //{
            //    SendReportMail sendReportMail = new SendReportMail();
            //    if (!sendReportMail.IsLoginMail())
            //    {
            //        sendReportMail.LoginSuccessed += new SendReportMail.LoginSuccessHander((object s) => this.SendMail("", true));
            //        sendReportMail.Sended += new SendReportMail.SendHander((object s, string content, bool attach) => this.SendMail(content, attach));
            //        sendReportMail.LoginMail(2);
            //        return;
            //    }
            //    if ((new clsAllOption()).ShowSendMail)
            //    {
            //        xfmMailContent _xfmMailContent = new xfmMailContent(2);
            //        _xfmMailContent.Sended += new xfmMailContent.SendHander((object s, string content, bool attach) => {
            //            _xfmMailContent.Close();
            //            this.SendMail(content, attach);
            //        });
            //        _xfmMailContent.ShowDialog();
            //    }
            //    else
            //    {
            //        this.SendMail("", true);
            //    }
            //}
        }


        public new void Clear()
        {
            this.txtID.Text = null;
            this.txtName.Text = null;
            this.imgPhoto.Image = null;
            this.calCoefficientSalary.Text = "";
            this.calBasicSalary.Text = "";
            this.txtWorkHour.Text = "";
            this.calMinusMoney.Text = "";
            this.calAllowance.Text = "";
            this.calWorkSalary.Text = "";
            this.calSocialInsurance.Text = null;
            this.calHealthInsurance.Text = null;
            this.calUnemploymentInsurance.Text = null;
            this.calAdvance.Text = "";
            this.calIncomeTaxMoney.Text = "";
            this.calSalary.Text = "";
            if (this.xucSalaryAllowanceByEmployee != null)
            {
                this.xucSalaryAllowanceByEmployee.ClearData();
            }
            if (this.xucAdvance != null)
            {
                this.xucAdvance.ClearData();
            }
            if (this.xucSalaryPayByEmployee != null)
            {
                this.xucSalaryPayByEmployee.ClearData();
            }
            if (this.xucSalaryDebitByEmployee != null)
            {
                this.xucSalaryDebitByEmployee.ClearData();
            }
            if (this.xucAssignment != null)
            {
                this.xucAssignment.ClearData();
            }
            if (this.xucSalaryPlus != null)
            {
                this.xucSalaryPlus.ClearData();
            }
            if (this.xucSalaryMinus != null)
            {
                this.xucSalaryMinus.ClearData();
            }
        }


        //private string LoadMailContent()
        //{
        //    string str;
        //    try
        //    {
        //        DataSet dataSet = new DataSet();
        //        dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\sendMailSalary.xml"));
        //        str = dataSet.Tables[0].Rows[0][0].ToString();
        //    }
        //    catch
        //    {
        //        str = "Chào [Giới tính] [Họ lót] [Tên] thân mến![Xuống dòng]Hiện tại phiếu tính lương tháng [Tháng]/[Năm] đã có. Anh có thể download file kèm theo dưới đây để tham khảo. Nếu có gì thắc mắc cần được giải đáp, Anh có thể phản hồi trở lại bằng địa chỉ email này.[Xuống dòng]Thân chào! Chúc vui vẻ!";
        //    }
        //    return str;
        //}

        public void Lock(bool IsLock)
        {
            if (!IsLock)
            {
                this.bbiSave.Enabled = true;
            }
            else
            {
                this.bbiSave.Enabled = false;
            }
        }

        private void RaiseUpdatedHander()
        {
            if (this.Updated != null)
            {
                this.Updated(this);
            }
        }

        //private void SendMail(string Content, bool Attach)
        //{
        //    if (Content == "")
        //    {
        //        Content = this.LoadMailContent();
        //    }
        //    if (!(this.l_Employee.Email == ""))
        //    {
        //        clsOptionPrintSalary _clsOptionPrintSalary = new clsOptionPrintSalary();
        //        XtraReport xtraReport = new XtraReport();
        //        if (_clsOptionPrintSalary.Theme == 0)
        //        {
        //            xtraReport = new rptSalary(this.m_Month, this.m_Year, this.m_EmployeeCode);
        //        }
        //        else if (_clsOptionPrintSalary.Theme != 1)
        //        {
        //            xtraReport = new rptSalary3(this.m_Month, this.m_Year, this.m_EmployeeCode);
        //        }
        //        else
        //        {
        //            xtraReport = new rptSalary2(this.m_Month, this.m_Year, this.m_EmployeeCode);
        //        }
        //        SendReportMail sendReportMail = new SendReportMail();
        //        string str = "";
        //        str = (!this.l_Employee.Sex ? "Chị" : "Anh");
        //        string str1 = Content.Replace("[Mã nhân viên]", this.m_EmployeeCode);
        //        str1 = str1.Replace("[Họ lót]", this.l_Employee.FirstName);
        //        str1 = str1.Replace("[Tên]", this.l_Employee.LastName);
        //        string[] strArrays = new string[5];
        //        int birthdayDay = this.l_Employee.BirthdayDay;
        //        strArrays[0] = birthdayDay.ToString();
        //        strArrays[1] = "/";
        //        birthdayDay = this.l_Employee.BirthdayMonth;
        //        strArrays[2] = birthdayDay.ToString();
        //        strArrays[3] = "/";
        //        birthdayDay = this.l_Employee.BirthdayYear;
        //        strArrays[4] = birthdayDay.ToString();
        //        str1 = str1.Replace("[Ngày sinh]", string.Concat(strArrays));
        //        str1 = str1.Replace("[Giới tính]", str);
        //        str1 = str1.Replace("[Nơi sinh]", this.l_Employee.BirthPlace);
        //        str1 = str1.Replace("[Địa chỉ]", this.l_Employee.MainAddress);
        //        str1 = str1.Replace("[Tạm trú]", this.l_Employee.ContactAddress);
        //        str1 = str1.Replace("[CMND]", this.l_Employee.IDCard);
        //        str1 = str1.Replace("[Email]", this.l_Employee.Email);
        //        str1 = str1.Replace("[Điện thoại]", this.l_Employee.CellPhone);
        //        str1 = str1.Replace("[Chức vụ]", this.l_Employee.Position);
        //        str1 = str1.Replace("[Chi nhánh]", this.l_Employee.BranchName);
        //        str1 = str1.Replace("[Phòng ban]", this.l_Employee.DepartmentName);
        //        str1 = str1.Replace("[Tổ nhóm]", this.l_Employee.GroupName);
        //        decimal basicSalary = this.l_Employee.BasicSalary;
        //        str1 = str1.Replace("[Lương căn bản]", basicSalary.ToString("#,0"));
        //        str1 = str1.Replace("[Tháng]", this.m_Month.ToString());
        //        str1 = str1.Replace("[Năm]", this.m_Year.ToString());
        //        str1 = str1.Replace("[Xuống dòng]", "<br/>");
        //        sendReportMail.Send(this.l_Employee.Email, string.Concat(MyLogin.Account, " - ", MyInfo.Company), string.Concat("Phiếu Lương Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()), str1, xtraReport, string.Concat(this.l_Employee.EmployeeCode, "_", this.m_Month.ToString(), this.m_Year.ToString()), Attach);
        //    }
        //    else
        //    {
        //        XtraMessageBox.Show("Chưa thiết lập địa chỉ email cho nhân viên này!");
        //    }
        //}

        public void SetData(Guid SalaryTableListID, string EmployeeCode, int Month, int Year)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_Month = Month;
            this.m_Year = Year;
            this.l_Employee.Get(this.m_EmployeeCode);
            TextEdit textEdit = this.txtID;
            string employeeCode = this.l_Employee.EmployeeCode;
            string str = employeeCode;
            this.m_EmployeeCode = employeeCode;
            textEdit.Text = str;
            this.txtName.Text = string.Concat(this.l_Employee.FirstName.ToString(), " ", this.l_Employee.LastName.ToString());
            this.imgPhoto.Image = this.l_Employee.Photo;
            HRM_SALARY hRMSALARY = new HRM_SALARY();
            hRMSALARY.Get(SalaryTableListID, EmployeeCode);
            this.calCoefficientSalary.EditValue = hRMSALARY.CoefficientSalary;
            this.calBasicSalary.EditValue = hRMSALARY.BasicSalary;
            this.txtWorkHour.Text = hRMSALARY.WorkHour.ToString();
            this.calMinusMoney.EditValue = hRMSALARY.MinusLateEarly + hRMSALARY.MinusMoney;
            this.calAllowance.EditValue = hRMSALARY.Allowance;
            this.calWorkSalary.EditValue = hRMSALARY.WorkSalary;
            this.calSocialInsurance.EditValue = hRMSALARY.SocialInsurance;
            this.calHealthInsurance.EditValue = hRMSALARY.HealthInsurance;
            this.calUnemploymentInsurance.EditValue = hRMSALARY.UnemploymentInsurance;
            this.calAdvance.EditValue = hRMSALARY.Advance;
            this.calIncomeTaxMoney.EditValue = hRMSALARY.IncomeTaxMoney;
            this.calSalary.EditValue = hRMSALARY.Salary;
            this.calSalaryPay.EditValue = hRMSALARY.SalaryPay;
            this.calSalaryDebt.EditValue = hRMSALARY.SalaryDebt;
            if (this.xucSalaryAllowanceByEmployee != null)
            {
                this.xucSalaryAllowanceByEmployee.Init(this.m_SalaryTableListID, this.m_EmployeeCode);
            }
            if (this.xucAdvance != null)
            {
                this.xucAdvance.Init(this.m_EmployeeCode, this.m_Month, this.m_Year);
            }
            if (this.xucSalaryPayByEmployee != null)
            {
                this.xucSalaryPayByEmployee.Init(this.m_SalaryTableListID, this.m_EmployeeCode);
            }
            if (this.xucSalaryDebitByEmployee != null)
            {
                this.xucSalaryDebitByEmployee.Init(this.m_SalaryTableListID, this.m_EmployeeCode);
            }
            if (this.xucAssignment != null)
            {
                this.xucAssignment.Init(this.m_EmployeeCode, this.m_Month, this.m_Year);
            }
            if (this.xucSalaryMinus != null)
            {
                this.xucSalaryMinus.Init(this.m_SalaryTableListID, this.m_EmployeeCode);
            }
            if (this.xucSalaryPlus != null)
            {
                this.xucSalaryPlus.Init(this.m_SalaryTableListID, this.m_EmployeeCode);
            }
        }

        private void xtraTabControl1_Selected(object sender, TabPageEventArgs e)
        {
            if (e.Page == this.tabAllowance)
            {
                if (this.xucSalaryAllowanceByEmployee == null)
                {
                    this.xucSalaryAllowanceByEmployee = new xucSalaryAllowanceByEmployee(this.m_SalaryTableListID, this.m_EmployeeCode)
                    {
                        Dock = DockStyle.Fill
                    };
                    this.tabAllowance.Controls.Add(this.xucSalaryAllowanceByEmployee);
                }
            }
            else if (e.Page == this.tabAdvance)
            {
                if (this.xucAdvance == null)
                {
                    this.xucAdvance = new xucAdvance1(this.m_EmployeeCode, this.m_Month, this.m_Year)
                    {
                        Dock = DockStyle.Fill
                    };
                    this.tabAdvance.Controls.Add(this.xucAdvance);
                }
            }
            else if (e.Page == this.tabSalaryPay)
            {
                if (this.xucSalaryPayByEmployee == null)
                {
                    this.xucSalaryPayByEmployee = new xucSalaryPayByEmployee(this.m_SalaryTableListID, this.m_EmployeeCode)
                    {
                        Dock = DockStyle.Fill
                    };
                    this.tabSalaryPay.Controls.Add(this.xucSalaryPayByEmployee);
                }
            }
            else if (e.Page == this.tabSalaryDebit)
            {
                if (this.xucSalaryDebitByEmployee == null)
                {
                    this.xucSalaryDebitByEmployee = new xucSalaryDebitByEmployee(this.m_SalaryTableListID, this.m_EmployeeCode)
                    {
                        Dock = DockStyle.Fill
                    };
                    this.tabSalaryDebit.Controls.Add(this.xucSalaryDebitByEmployee);
                }
            }
            else if (e.Page == this.tabAssignment)
            {
                if (this.xucAssignment == null)
                {
                    this.xucAssignment = new xucAssignment1(this.m_EmployeeCode, this.m_Month, this.m_Year)
                    {
                        Dock = DockStyle.Fill
                    };
                    this.tabAssignment.Controls.Add(this.xucAssignment);
                }
            }
            else if (e.Page == this.tabSalaryPlus)
            {
                if (this.xucSalaryPlus == null)
                {
                    this.xucSalaryPlus = new xucSalaryPlusByEmployee(this.m_SalaryTableListID, this.m_EmployeeCode)
                    {
                        Dock = DockStyle.Fill
                    };
                    this.tabSalaryPlus.Controls.Add(this.xucSalaryPlus);
                }
            }
            else if (e.Page == this.tabSalaryMinus)
            {
                if (this.xucSalaryMinus == null)
                {
                    this.xucSalaryMinus = new xucSalaryMinusByEmployee(this.m_SalaryTableListID, this.m_EmployeeCode)
                    {
                        Dock = DockStyle.Fill
                    };
                    this.tabSalaryMinus.Controls.Add(this.xucSalaryMinus);
                }
            }
        }

        public event xucSalaryCard.UpdatedHandler Updated;

        public delegate void UpdatedHandler(object sender);
    }
}
