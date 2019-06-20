using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Net.Info;
//using CHBK2014_N9.Utils.Security2;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace CHBK2014_N9.Common.Report
{
    public partial class rptListContract : XtraReport
    {

        private HRM_CONTRACT l_Contract = new HRM_CONTRACT();

        private string m_Filter = "0";

        private int m_Level = MyLogin.Level;

        private string m_Code = MyLogin.Code;

        private int m_Order = 0;
        public rptListContract()
        {
            InitializeComponent();
        }


        public rptListContract(string Filter)
        {
            this.InitializeComponent();
            this.m_Filter = Filter;
        }

        public rptListContract(int Level, string Code, string Filter)
        {
            this.InitializeComponent();
            this.m_Level = Level;
            this.m_Code = Code;
            this.m_Filter = Filter;
        }


        private void chSex_BeforePrint(object sender, PrintEventArgs e)
        {
        }


        private void dtDate_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {
                XRTableCell shortDateString = this.dtSignDate;
                DateTime dateTime = Convert.ToDateTime(this.dtSignDate.Text);
                shortDateString.Text = dateTime.ToShortDateString();
            }
            catch
            {
            }
        }

        private void dtFromDate_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {
                XRTableCell shortDateString = this.dtFromDate;
                DateTime dateTime = Convert.ToDateTime(this.dtFromDate.Text);
                shortDateString.Text = dateTime.ToShortDateString();
            }
            catch
            {
            }
        }

        private void dtToDate_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {
                XRTableCell shortDateString = this.dtToDate;
                DateTime dateTime = Convert.ToDateTime(this.dtToDate.Text);
                shortDateString.Text = dateTime.ToShortDateString();
                if (!(DateTime.Now >= DateAndTime.DateAdd(DateInterval.Day, -10, Convert.ToDateTime(this.dtToDate.Text))))
                {
                    this.txtStatus.Text = "";
                }
                else
                {
                    this.txtStatus.Text = "Sắp hết hạn (-)";
                }
                if (Convert.ToDateTime(this.dtToDate.Text) < DateTime.Now)
                {
                    this.txtStatus.Text = "Đã hết hạn (x)";
                }
            }
            catch
            {
            }
        }


        private void LoadAllData()
        {
            this.txtCurrentDate.Text = DateTime.Now.ToShortDateString();
            this.LoadDepartment();
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            if (this.m_Filter == "0")
            {
                dataTable = this.l_Contract.GetList(this.m_Level, this.m_Code);
                this.txtTitle.Text = "DANH SÁCH TẤT CẢ HỢP ĐỒNG LAO ĐỘNG";
            }
            else if (this.m_Filter == "1")
            {
                dataTable = this.l_Contract.GetListJustExpiration(this.m_Level, this.m_Code);
                this.txtTitle.Text = "DANH SÁCH SẮP HẾT HẠN HĐLĐ";
            }
            else if (!(this.m_Filter == "2"))
            {
                dataTable = this.l_Contract.GetCurrentList(this.m_Level, this.m_Code);
                this.txtTitle.Text = "DANH SÁCH HỢP ĐỒNG LAO ĐỘNG";
            }
            else
            {
                dataTable = this.l_Contract.GetListExpiration(this.m_Level, this.m_Code);
                this.txtTitle.Text = "DANH SÁCH ĐÃ HẾT HẠN HĐLĐ";
            }
            dataSet.Tables.Add(dataTable);
            base.DataSource = dataSet;
            this.txtContractCode.DataBindings.Add("Text", base.DataSource, "ContractCode");
            this.txtEmployeeCode.DataBindings.Add("Text", base.DataSource, "EmployeeCode");
            this.txtFirstName.DataBindings.Add("Text", base.DataSource, "FirstName");
            this.txtLastName.DataBindings.Add("Text", base.DataSource, "LastName");
            this.txtContractTime.DataBindings.Add("Text", base.DataSource, "ContractTime");
            this.dtFromDate.DataBindings.Add("Text", base.DataSource, "FromDate");
            this.dtToDate.DataBindings.Add("Text", base.DataSource, "ToDate");
            this.txtSigner.DataBindings.Add("Text", base.DataSource, "Signer");
            this.dtSignDate.DataBindings.Add("Text", base.DataSource, "SignDate");
        }

        private void LoadDepartment()
        {
            if (this.m_Level == 0)
            {
                this.txtDepartment.Text = "";
            }
            else if (this.m_Level == 1)
            {
                HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                hRMBRANCH.Get(this.m_Code);
                this.txtDepartment.Text = string.Concat("Đơn vị: ", hRMBRANCH.BranchName);
            }
            else if (this.m_Level == 2)
            {
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                hRMDEPARTMENT.Get(this.m_Code);
                this.txtDepartment.Text = string.Concat("Đơn vị: ", hRMDEPARTMENT.DepartmentName);
            }
            else if (this.m_Level == 3)
            {
                HRM_GROUP hRMGROUP = new HRM_GROUP();
                hRMGROUP.Get(this.m_Code);
                this.txtDepartment.Text = string.Concat("Đơn vị: ", hRMGROUP.GroupName);
            }
        }

        private void rptListContract_BeforePrint(object sender, PrintEventArgs e)
        {
            this.LoadAllData();
           
                //this.txtCompany.Text = MyInfo.Company.ToUpper();
                //this.txtAddress.Text = MyInfo.Address;
                //this.ptPhoto.Image = MyInfo.Photo;
         
        }

        private void txtOrder_BeforePrint(object sender, PrintEventArgs e)
        {
            this.m_Order++;
            this.txtOrder.Text = this.m_Order.ToString();
        }

        private void txtStatus_BeforePrint(object sender, PrintEventArgs e)
        {
        }

    }
}
