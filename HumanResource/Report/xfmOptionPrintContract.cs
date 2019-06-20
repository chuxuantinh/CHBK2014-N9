using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using CHBK2014_N9.Common.Report;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core.Class;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Report
{
    public partial class xfmOptionPrintContract : Form
    {

        private string m_EmployeeCode = "";

        private string m_ContractCode = "";

        private int m_Value = 0;

        private int m_Level = MyLogin.Level;

        private string m_Code = MyLogin.Code;


        public xfmOptionPrintContract()
        {
            InitializeComponent();
        }

        public xfmOptionPrintContract(int Level, string Code)
        {
            this.InitializeComponent();
            this.m_Level = Level;
            this.m_Code = Code;
            this.Init();
        }

        public xfmOptionPrintContract(string ContractCode, string EmployeeCode)
        {
            this.InitializeComponent();
            this.m_ContractCode = ContractCode;
            this.m_EmployeeCode = EmployeeCode;
            this.Init();
        }


        public xfmOptionPrintContract(int Level, string Code, string ContractCode, string EmployeeCode)
        {
            this.InitializeComponent();
            this.m_Level = Level;
            this.m_Code = Code;
            this.m_ContractCode = ContractCode;
            this.m_EmployeeCode = EmployeeCode;
            this.Init();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptListContract _rptListContract;
            rptContract _rptContract;
            xfmReport _xfmReport = new xfmReport("Hợp Đồng Lao Động");
            if (this.m_Value == 1)
            {
                _rptListContract = new rptListContract(this.m_Level, this.m_Code, "0");
                _xfmReport.SetTitle("Danh Sách Tất Cả HĐLĐ Của Nhân Viên");
                _xfmReport.ShowPrintPreview(_rptListContract);
            }
            else if (this.m_Value == 2)
            {
                _rptListContract = new rptListContract(this.m_Level, this.m_Code, "1");
                _xfmReport.SetTitle("Danh Sách Nhân Viên Sắp Hết Hạn HĐLĐ");
                _xfmReport.ShowPrintPreview(_rptListContract);
            }
            else if (this.m_Value == 3)
            {
                _rptListContract = new rptListContract(this.m_Level, this.m_Code, "2");
                _xfmReport.SetTitle("Danh Sách Nhân Viên Đã Hết Hạn HĐLĐ");
                _xfmReport.ShowPrintPreview(_rptListContract);
            }
            else if (!(this.m_Value == 5 ? false : this.m_Value != 0))
            {
                _xfmReport.SetTitle("Hợp Đồng Lao Động");
                HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
                hRMCONTRACT.Get(this.m_ContractCode);
                clsContractOption _clsContractOption = new clsContractOption();

                // HD Xác định thoi hạn

                if (hRMCONTRACT.ContractType == 0)
                {
                    if (!(_clsContractOption.FilePath0 == ""))
                    {
                        _rptContract = new rptContract(this.m_ContractCode, this.m_EmployeeCode, _clsContractOption.FilePath0);
                        _xfmReport.ShowPrintPreview(_rptContract);
                    }
                    else
                    {
                        _xfmReport.ShowPrintPreview(new rptContract0(this.m_ContractCode, this.m_EmployeeCode));
                    }
                }

                // khong xác dinh thoi han
                else if (hRMCONTRACT.ContractType == 1)
                {
                    if (!(_clsContractOption.FilePath1 == ""))
                    {
                        _rptContract = new rptContract(this.m_ContractCode, this.m_EmployeeCode, _clsContractOption.FilePath1);
                        _xfmReport.ShowPrintPreview(_rptContract);
                    }
                    else
                    {
                       _xfmReport.ShowPrintPreview(new rptContract1(this.m_ContractCode, this.m_EmployeeCode));
                    }
                }
                else if (hRMCONTRACT.ContractType == 2)
                {
                    if (!(_clsContractOption.FilePath2 == ""))
                    {
                        _rptContract = new rptContract(this.m_ContractCode, this.m_EmployeeCode, _clsContractOption.FilePath2);
                        _xfmReport.ShowPrintPreview(_rptContract);
                    }
                    else
                    {
                      _xfmReport.ShowPrintPreview(new rptContract2(this.m_ContractCode, this.m_EmployeeCode));
                    }
                }
                else if (hRMCONTRACT.ContractType == 3)
                {
                    if (!(_clsContractOption.FilePath3 == ""))
                    {
                        _rptContract = new rptContract(this.m_ContractCode, this.m_EmployeeCode, _clsContractOption.FilePath3);
                        _xfmReport.ShowPrintPreview(_rptContract);
                    }
                    else
                    {
                       _xfmReport.ShowPrintPreview(new rptContract3(this.m_ContractCode, this.m_EmployeeCode));
                    }
                }
            }
            else if (this.m_Value == 6)
            {
                _rptListContract = new rptListContract(this.m_Level, this.m_Code, "6");
                _xfmReport.SetTitle("Danh Sách HĐLĐ Đang Quản Lý");
                _xfmReport.ShowPrintPreview(_rptListContract);
            }
        }

        private void Init()
        {
            this.colValue.Visible = false;
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.treeList1.ExpandAll();
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            this.m_Value = Convert.ToInt32(e.Node.GetValue(this.colValue).ToString());
        }
    }
}
