using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraWizard;
using CHBK2014_N9.Common;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Process
{
    public partial class xfmAdvanceImport : xfmBaseImport
    {
        private Guid m_SalaryTableListID = Guid.Empty;
        public xfmAdvanceImport()
        {
            InitializeComponent();
        }

        public xfmAdvanceImport(Guid SalaryTableListID)
        {
            this.InitializeComponent();
            this.m_SalaryTableListID = SalaryTableListID;
        }
        protected override void FillField()
        {
            List<string> strs = new List<string>()
            {
                "Mã nhân viên",
                "Họ lót",
                "Tên",
                "Lý do tạm ứng",
                "Số tiền",
                "Ngày tạm ứng",
                "Người cho ứng"
            };
            base.FillField(strs);
        }

        protected override void Import(DataTable ExcelContentTable)
        {
            object[] employeeCode;
            int num = 0;
            foreach (DataRow row in ExcelContentTable.Rows)
            {
                if (num != 0)
                {
                    HRM_PROCESS_ADVANCE hRMPROCESSADVANCE = new HRM_PROCESS_ADVANCE();
                    try
                    {
                        hRMPROCESSADVANCE.AdvanceID = Guid.NewGuid();
                        hRMPROCESSADVANCE.EmployeeCode = row[this.ParamNameIndex[0]].ToString();
                        hRMPROCESSADVANCE.Reason = row[this.ParamNameIndex[3]].ToString();
                        try
                        {
                            hRMPROCESSADVANCE.Money = decimal.Parse(row[this.ParamNameIndex[4]].ToString());
                        }
                        catch
                        {
                            hRMPROCESSADVANCE.Money = new decimal(0);
                        }
                        try
                        {
                           Perfect.Utils.  MyDateTime.GetValueFromString(row[this.ParamNameIndex[5]].ToString());
                            hRMPROCESSADVANCE.Date = new DateTime(Perfect.Utils.MyDateTime.Year, Perfect.Utils.MyDateTime .Month, Perfect.Utils.MyDateTime.Day);
                        }
                        catch
                        {
                            hRMPROCESSADVANCE.Date = DateTime.Now;
                        }
                        hRMPROCESSADVANCE.Person = row[this.ParamNameIndex[6]].ToString();
                        if (!(hRMPROCESSADVANCE.Insert() == "OK"))
                        {
                            employeeCode = new object[] { "Dòng thứ ", num, " => ", hRMPROCESSADVANCE.EmployeeCode, ": Trùng mã nhân viên" };
                            base.ErrorRow(string.Concat(employeeCode));
                        }
                        else
                        {
                            base.SuccessRow();
                        }
                    }
                    catch (Exception exception1)
                    {
                        Exception exception = exception1;
                        employeeCode = new object[] { "Dòng thứ ", num, " => ", hRMPROCESSADVANCE.EmployeeCode, exception.ToString() };
                        base.ErrorRow(string.Concat(employeeCode));
                    }
                    base.ProgressRow(string.Concat("Đang nạp dữ liệu... ", hRMPROCESSADVANCE.EmployeeCode, "..."));
                    num++;
                }
                else
                {
                    num++;
                }
            }
        }

        private void xfmAdvanceImport_Load(object sender, EventArgs e)
        {
            this.wcImport.Text = this.wcImport.Text.Replace("*", "Tạm ứng lương");
            this.lbFilePathDescription.Text = this.lbFilePathDescription.Text.Replace("*", "Tạm ứng lương");
            this.lbLinkFileDecription.Text = this.lbLinkFileDecription.Text.Replace("*", "ProcessAdvance");
            this.lbLinkFile.Text = this.lbLinkFile.Text.Replace("*", "ProcessAdvance");
            this.lbProgressDescription.Text = "";
            this.wpFinish.Text = "Hoàn thành";
            this.lbFinishDescription.Text = this.lbFinishDescription.Text.Replace("*", "Tạm ứng lương");
        }
    }
}
