using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Net.Info;
//using CHBK2014_N9.Utils.Security2;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Windows.Forms;

namespace CHBK2014_N9.Common.Report
{
    public partial class rptContract : DevExpress.XtraReports.UI.XtraReport
    {

        private HRM_CONTRACT l_Contract = new HRM_CONTRACT();

        private string m_EmployeeCode = "";

        private string m_ContractCode = "";

        private string m_FilePath = "";
        public rptContract()
        {
            InitializeComponent();
        }


        public rptContract(string ContractCode, string EmployeeCode, string FilePath)
        {
            this.InitializeComponent();
            this.m_ContractCode = ContractCode;
            this.m_EmployeeCode = EmployeeCode;
            this.m_FilePath = FilePath;
        }

        private void LoadAllData()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            dataTable = this.l_Contract.GetList(MyLogin.Level, MyLogin.Code);
            dataSet.Tables.Add(dataTable);
            base.DataSource = dataSet;
            base.DataMember = dataTable.TableName;
            base.DataAdapter = dataTable;
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

        private void rptContract_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
            try
            {
                this.xrRichText1.LoadFile(this.m_FilePath);
            }
            catch
            {
                XtraMessageBox.Show(string.Concat("Không thể tìm thấy tập tin ", this.m_FilePath), "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            if (!(this.m_EmployeeCode == ""))
            {
                this.LoadData();
            }
            else
            {
                this.LoadAllData();
            }
        }
    }
}
