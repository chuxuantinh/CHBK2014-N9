using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Net.Info;
//using CHBK2014_N9.Utils.Security2;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
namespace CHBK2014_N9.HumanResource.Report
{


    public partial class rptContract2 : DevExpress.XtraReports.UI.XtraReport
    {

        private HRM_CONTRACT l_Contract = new HRM_CONTRACT();

        private string m_EmployeeCode = "";

        private string m_ContractCode = "";
        public rptContract2()
        {
            InitializeComponent();
        }

        public rptContract2(string ContractCode, string EmployeeCode)
        {
            this.InitializeComponent();
            this.m_ContractCode = ContractCode;
            this.m_EmployeeCode = EmployeeCode;
            this.LoadData();
        }


        private void LoadData()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            dataTable = this.l_Contract.GetListByContract(this.m_ContractCode, this.m_EmployeeCode);
            dataSet.Tables.Add(dataTable);
            base.DataSource = dataSet;
            base.DataMember = dataTable.TableName;
            base.DataAdapter = dataTable;
        }

        private void rptContract2_BeforePrint(object sender, PrintEventArgs e)
        {
            this.txtCompany.Text = "Công ty ABC";
           
        }

    }
}
