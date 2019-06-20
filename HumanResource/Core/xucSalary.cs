using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Common.Enviroment;
using CHBK2014_N9.ERP;
using System.Drawing;
using CHBK2014_N9.HumanResource.Core.Class;
using CHBK2014_N9.HumanResource.Report;
using CHBK2014_N9.Net.Info;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucSalary : xucSalaryBase
    {
    

        private string m_EmployeeCode = "";
    
        public xucSalary()
        {
            InitializeComponent();
            this._exportView = this.gbList;
            this._exportControl = this.gcList;
            this.InitOtherComponent();
            this.InitSalaryOvertimeColumn();
            this.InitAllowanceColumn();
            this.InitTimeKeeperColumn();
            base.Load += new EventHandler(this.xucSalary_Load);
        }

        protected override void Customize()
        {
            base.Customize();
            if (this.xucSalaryCard1 != null)
            {
                if (!this.m_IsLock)
                {
                  this.xucSalaryCard1.Lock(false);
                }
                else
                {
                  this.xucSalaryCard1.Lock(true);
                }
                if (this.m_IsFinish)
                {
                   this.xucSalaryCard1.Lock(true);
                }
            }
        }


        private void dpFooter_VisibilityChanged(object sender, VisibilityChangedEventArgs e)
        {
            if ((this.dpFooter.Visibility == DockVisibility.AutoHide ? false : this.dpFooter.Visibility != DockVisibility.Hidden))
            {
                xucSalary.SaveStyle(true);
            }
            else
            {
                xucSalary.SaveStyle(false);
            }
        }

        private void gbList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            this.LoadSalaryCard();
        }

        protected override void Import()
        {
            base.Import();
            xfmSalaryTableListImport _xfmSalaryTableListImport = new xfmSalaryTableListImport(0, this.m_SalaryTableListID);
            _xfmSalaryTableListImport.Success += new xfmSalaryTableListImport.SuccessEventHander((object s) => this.xucSalaryCard1.SetData(this.m_SalaryTableListID, this.m_EmployeeCode, this.m_Month, this.m_Year));
            _xfmSalaryTableListImport.ShowDialog();
        }

        private void InitAllowanceColumn()
        {
        //   BandedGridColumn column = null;
            List<BandedGridColumn> bandedGridColumns = new List<BandedGridColumn>();
            foreach (BandedGridColumn column in this.bandAllowance.Columns)
            {
                if ((column == this.colAllowance ? false : column != this.colTotalSalary))
                {
                    bandedGridColumns.Add(column);
                }
            }
            foreach (BandedGridColumn bandedGridColumn in bandedGridColumns)
            {
                this.gbList.Columns.Remove(bandedGridColumn);
            }
            List<BandedGridColumn> bandedGridColumns1 = new List<BandedGridColumn>();
            foreach (BandedGridColumn column1 in this.bandTaxAllowance.Columns)
            {
                if ((column1 == this.colNumberDepend || column1 == this.colDependMoney || column1 == this.colTaxYourSelfMoney || column1 == this.colTaxOvertime150Money || column1 == this.colTaxOvertime200Money || column1 == this.colTaxOvertime300Money || column1 == this.colTaxOvertime195Money || column1 == this.colTaxOvertime260Money ? false : column1 != this.colTaxOvertime390Money))
                {
                    bandedGridColumns1.Add(column1);
                }
            }
            foreach (BandedGridColumn bandedGridColumn1 in bandedGridColumns1)
            {
                this.gbList.Columns.Remove(bandedGridColumn1);
            }
            foreach (DataRow row in (new DIC_ALLOWANCE()).GetList().Rows)
            {
                BandedGridColumn brown = new BandedGridColumn()
                {
                    FieldName = row["AllowanceCode"].ToString(),
                    Caption = string.Concat(row["AllowanceName"].ToString().Remove(1).ToUpper(), row["AllowanceName"].ToString().Remove(0, 1).ToLower()),
                 ColumnEdit = this.repCalculator,
                    Name = string.Concat("colAllowance", row["AllowanceCode"].ToString())
                };
                brown.AppearanceHeader.Options.UseForeColor = true;
                brown.AppearanceHeader.ForeColor = Color.Brown;
                brown.AppearanceCell.Options.UseBackColor = true;
                brown.AppearanceCell.BackColor = Color.Ivory;
                brown.OptionsColumn.ReadOnly = true;
                brown.SummaryItem.DisplayFormat = "{0:##,##0}";
                brown.SummaryItem.SummaryType = SummaryItemType.Sum;
                brown.Visible = true;
                brown.Width = 76;
                this.bandAllowance.Columns.Add(brown);
                GridSummaryItem gridGroupSummaryItem = new GridGroupSummaryItem(SummaryItemType.Sum, brown.FieldName, brown, "{0:##,##0}");
                this.gbList.GroupSummary.Add(gridGroupSummaryItem);
                brown.Width = 76;
                if (bool.Parse(row["IsShowInSalaryTableList"].ToString()))
                {
                    BandedGridColumn red = new BandedGridColumn()
                    {
                        FieldName = string.Concat("Tax", row["AllowanceCode"].ToString()),
                        Caption = string.Concat(row["AllowanceName"].ToString().Remove(1).ToUpper(), row["AllowanceName"].ToString().Remove(0, 1).ToLower()),
                      ColumnEdit = this.repCalculator,
                        Name = string.Concat("colTaxAllowance", row["AllowanceCode"].ToString())
                    };
                    red.AppearanceHeader.Options.UseForeColor = true;
                    red.AppearanceHeader.ForeColor = Color.Red;
                    red.AppearanceCell.Options.UseBackColor = true;
                    red.AppearanceCell.BackColor = Color.Ivory;
                    red.OptionsColumn.ReadOnly = true;
                    red.SummaryItem.DisplayFormat = "{0:##,##0}";
                    red.SummaryItem.SummaryType = SummaryItemType.Sum;
                    red.Visible = true;
                    red.Width = 76;
                    this.bandTaxAllowance.Columns.Add(red);
                    GridSummaryItem gridSummaryItem = new GridGroupSummaryItem(SummaryItemType.Sum, red.FieldName, red, "{0:##,##0}");
                    this.gbList.GroupSummary.Add(gridSummaryItem);
                    red.Width = 76;
                }
            }
            this.colEmployeeCode.Width = 65;
            this.colFirstName.Width = 121;
            this.colLastName.Width = 56;
            this.colCoefficientSalary.Width = 54;
            this.colBasicSalary.Width = 76;
            this.colInsuranceSalary.Width = 76;
            this.colAllowanceInsurance.Width = 76;
            this.colAllowance.Width = 64;
            this.colTotalSalary.Width = 76;
            this.colTaxYourSelfMoney.Width = 75;
            this.colNumberDepend.Width = 66;
            this.colDependMoney.Width = 77;
            this.colTaxOvertime150Money.Width = 75;
            this.colTaxOvertime200Money.Width = 75;
            this.colTaxOvertime300Money.Width = 75;
            this.colTaxOvertime195Money.Width = 75;
            this.colTaxOvertime260Money.Width = 75;
            this.colTaxOvertime390Money.Width = 75;
        }


        private void InitOtherComponent()
        {
            this.dpFooter = new DockPanel();
            ControlContainer controlContainer = new ControlContainer();
            this.xucSalaryCard1 = new xucSalaryCard();
            {
                Dock = DockStyle.Fill;
            }
          controlContainer.Controls.Add(this.xucSalaryCard1);
            this.dpFooter.Controls.Add(controlContainer);
            this.dpFooter.Dock = DockingStyle.Bottom;
            this.dManager.RootPanels.AddRange(new DockPanel[] { this.dpFooter });
            this.dpFooter.VisibilityChanged += new VisibilityChangedEventHandler(this.dpFooter_VisibilityChanged);
         this.xucSalaryCard1.Updated += new xucSalaryCard.UpdatedHandler(this.xucSalaryCard1_Updated);
        }

        private void InitSalaryOvertimeColumn()
        {
            DIC_SALARY_FORMULA dICSALARYFORMULA = new DIC_SALARY_FORMULA();
            dICSALARYFORMULA.Get();
            if (!dICSALARYFORMULA.IsGroupSalaryOvertime)
            {
                this.bandSalaryOvertime.Visible = false;
            }
            else
            {
                this.bandSalaryOvertime.Visible = true;
            }
        }

        private void InitSalaryPlusMinus()
        {
            //BandedGridColumn column = null;
          //  DataRow row = null;
            BandedGridColumn bandedGridColumn;
            GridSummaryItem gridGroupSummaryItem;
            BandedGridColumn blue;
            GridSummaryItem gridSummaryItem;
            List<BandedGridColumn> bandedGridColumns = new List<BandedGridColumn>();
            foreach (BandedGridColumn column in this.bandPlusMinusBefore.Columns)
            {
                bandedGridColumns.Add(column);
            }
            foreach (BandedGridColumn bandedGridColumn1 in bandedGridColumns)
            {
                this.gbList.Columns.Remove(bandedGridColumn1);
            }
            List<BandedGridColumn> bandedGridColumns1 = new List<BandedGridColumn>();
            foreach (BandedGridColumn column1 in this.bandPlusMinusAfter.Columns)
            {
                bandedGridColumns1.Add(column1);
            }
            foreach (BandedGridColumn bandedGridColumn2 in bandedGridColumns1)
            {
                this.gbList.Columns.Remove(bandedGridColumn2);
            }
            if (!(this.m_SalaryTableListID == Guid.Empty))
            {
                HRM_SALARY_DEDUCTION hRMSALARYDEDUCTION = new HRM_SALARY_DEDUCTION();
                DataTable list = hRMSALARYDEDUCTION.GetList(this.m_SalaryTableListID, true);
                foreach (DataRow row in list.Rows)
                {
                    bandedGridColumn = new BandedGridColumn()
                    {
                        FieldName = string.Concat("Deduction", row["DeductionCode"].ToString()),
                        Caption = string.Concat(row["DeductionName"].ToString().Remove(1).ToUpper(), row["DeductionName"].ToString().Remove(0, 1).ToLower()),
                        ColumnEdit = this.repCalculator,
                        Name = string.Concat("colDeductionCode", row["DeductionCode"].ToString())
                    };
                    bandedGridColumn.AppearanceHeader.Options.UseForeColor = true;
                    bandedGridColumn.AppearanceHeader.ForeColor = Color.Blue;
                    bandedGridColumn.AppearanceCell.Options.UseBackColor = true;
                    bandedGridColumn.AppearanceCell.BackColor = Color.Azure;
                    bandedGridColumn.OptionsColumn.ReadOnly = true;
                    bandedGridColumn.SummaryItem.DisplayFormat = "{0:##,##0}";
                    bandedGridColumn.SummaryItem.SummaryType = SummaryItemType.Sum;
                    bandedGridColumn.Visible = true;
                    bandedGridColumn.Width = 76;
                    this.bandPlusMinusBefore.Columns.Add(bandedGridColumn);
                    gridGroupSummaryItem = new GridGroupSummaryItem(SummaryItemType.Sum, bandedGridColumn.FieldName, bandedGridColumn, "{0:##,##0}");
                    this.gbList.GroupSummary.Add(gridGroupSummaryItem);
                    bandedGridColumn.Width = 76;
                }
                HRM_SALARY_INCOME hRMSALARYINCOME = new HRM_SALARY_INCOME();
                DataTable dataTable = hRMSALARYINCOME.GetList(this.m_SalaryTableListID, true);
                if (dataTable.Rows.Count + list.Rows.Count <= 0)
                {
                    this.bandPlusMinusBefore.Visible = false;
                }
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    blue = new BandedGridColumn()
                    {
                        FieldName = string.Concat("Income", dataRow["IncomeCode"].ToString()),
                        Caption = string.Concat(dataRow["IncomeName"].ToString().Remove(1).ToUpper(), dataRow["IncomeName"].ToString().Remove(0, 1).ToLower()),
                       ColumnEdit = this.repCalculator,
                        Name = string.Concat("colIncomeCode", dataRow["IncomeCode"].ToString())
                    };
                    blue.AppearanceHeader.Options.UseForeColor = true;
                    blue.AppearanceHeader.ForeColor = Color.Blue;
                    blue.AppearanceCell.Options.UseBackColor = true;
                    blue.AppearanceCell.BackColor = Color.Azure;
                    blue.OptionsColumn.ReadOnly = true;
                    blue.SummaryItem.DisplayFormat = "{0:##,##0}";
                    blue.SummaryItem.SummaryType = SummaryItemType.Sum;
                    blue.Visible = true;
                    blue.Width = 76;
                    this.bandPlusMinusBefore.Columns.Add(blue);
                    gridSummaryItem = new GridGroupSummaryItem(SummaryItemType.Sum, blue.FieldName, blue, "{0:##,##0}");
                    this.gbList.GroupSummary.Add(gridSummaryItem);
                    blue.Width = 76;
                }
                list = hRMSALARYDEDUCTION.GetList(this.m_SalaryTableListID, false);
                foreach (DataRow row1 in list.Rows)
                {
                    bandedGridColumn = new BandedGridColumn()
                    {
                        FieldName = string.Concat("Deduction", row1["DeductionCode"].ToString()),
                        Caption = string.Concat(row1["DeductionName"].ToString().Remove(1).ToUpper(), row1["DeductionName"].ToString().Remove(0, 1).ToLower()),
                        ColumnEdit = this.repCalculator,
                        Name = string.Concat("colDeductionCode", row1["DeductionCode"].ToString())
                    };
                    bandedGridColumn.AppearanceHeader.Options.UseForeColor = true;
                    bandedGridColumn.AppearanceHeader.ForeColor = Color.Blue;
                    bandedGridColumn.AppearanceCell.Options.UseBackColor = true;
                    bandedGridColumn.AppearanceCell.BackColor = Color.Azure;
                    bandedGridColumn.OptionsColumn.ReadOnly = true;
                    bandedGridColumn.SummaryItem.DisplayFormat = "{0:##,##0}";
                    bandedGridColumn.SummaryItem.SummaryType = SummaryItemType.Sum;
                    bandedGridColumn.Visible = true;
                    bandedGridColumn.Width = 76;
                    this.bandPlusMinusAfter.Columns.Add(bandedGridColumn);
                    gridGroupSummaryItem = new GridGroupSummaryItem(SummaryItemType.Sum, bandedGridColumn.FieldName, bandedGridColumn, "{0:##,##0}");
                    this.gbList.GroupSummary.Add(gridGroupSummaryItem);
                    bandedGridColumn.Width = 76;
                }
                dataTable = hRMSALARYINCOME.GetList(this.m_SalaryTableListID, false);
                if (dataTable.Rows.Count + list.Rows.Count <= 0)
                {
                    this.bandPlusMinusAfter.Visible = false;
                }
                foreach (DataRow dataRow1 in dataTable.Rows)
                {
                    blue = new BandedGridColumn()
                    {
                        FieldName = string.Concat("Income", dataRow1["IncomeCode"].ToString()),
                        Caption = string.Concat(dataRow1["IncomeName"].ToString().Remove(1).ToUpper(), dataRow1["IncomeName"].ToString().Remove(0, 1).ToLower()),
                       ColumnEdit = this.repCalculator,
                        Name = string.Concat("colIncomeCode", dataRow1["IncomeCode"].ToString())
                    };
                    blue.AppearanceHeader.Options.UseForeColor = true;
                    blue.AppearanceHeader.ForeColor = Color.Blue;
                    blue.AppearanceCell.Options.UseBackColor = true;
                    blue.AppearanceCell.BackColor = Color.Azure;
                    blue.OptionsColumn.ReadOnly = true;
                    blue.SummaryItem.DisplayFormat = "{0:##,##0}";
                    blue.SummaryItem.SummaryType = SummaryItemType.Sum;
                    blue.Visible = true;
                    blue.Width = 76;
                    this.bandPlusMinusAfter.Columns.Add(blue);
                    gridSummaryItem = new GridGroupSummaryItem(SummaryItemType.Sum, blue.FieldName, blue, "{0:##,##0}");
                    this.gbList.GroupSummary.Add(gridSummaryItem);
                    blue.Width = 76;
                }
                this.colEmployeeCode.Width = 65;
                this.colFirstName.Width = 121;
                this.colLastName.Width = 56;
                this.colCoefficientSalary.Width = 54;
                this.colBasicSalary.Width = 76;
                this.colInsuranceSalary.Width = 76;
                this.colAllowanceInsurance.Width = 76;
                this.colAllowance.Width = 64;
                this.colTotalSalary.Width = 76;
                this.colTaxYourSelfMoney.Width = 75;
                this.colNumberDepend.Width = 66;
                this.colDependMoney.Width = 77;
                this.colTaxOvertime150Money.Width = 75;
                this.colTaxOvertime200Money.Width = 75;
                this.colTaxOvertime300Money.Width = 75;
                this.colTaxOvertime195Money.Width = 75;
                this.colTaxOvertime260Money.Width = 75;
                this.colTaxOvertime390Money.Width = 75;
            }
        }

        private void InitTimeKeeperColumn()
        {
            HRM_SALARY_TABLELIST hRMSALARYTABLELIST = new HRM_SALARY_TABLELIST();
            if (!hRMSALARYTABLELIST.Exist(this.m_Month, this.m_Year))
            {
                DIC_SALARY_FORMULA dICSALARYFORMULA = new DIC_SALARY_FORMULA();
                dICSALARYFORMULA.Get();
                if (dICSALARYFORMULA.OvertimeSaturdayType != 0)
                {
                    this.colOvertime200.Caption = "TC. T7 & Chủ nhật (h)";
                    this.colOvertime260.Caption = "TCĐ. T7 & Chủ nhật (h)";
                }
                else
                {
                    this.colOvertime200.Caption = "TC. Chủ nhật (h)";
                    this.colOvertime260.Caption = "TCĐ. Chủ nhật (h)";
                }
            }
            else
            {
                hRMSALARYTABLELIST.Get(this.m_Month, this.m_Year);
                if (hRMSALARYTABLELIST.OvertimeSaturdayType != 0)
                {
                    this.colOvertime200.Caption = "TC. T7 & Chủ nhật (h)";
                    this.colOvertime260.Caption = "TCĐ. T7 & Chủ nhật (h)";
                }
                else
                {
                    this.colOvertime200.Caption = "TC. Chủ nhật (h)";
                    this.colOvertime260.Caption = "TCĐ. Chủ nhật (h)";
                }
            }
        }

        protected override void LoadGrid()
        {
            try
            {
                base.LoadGrid();
                this.bbeName.EditValue = string.Concat("Tháng ", this.m_Month.ToString(), " - ", this.m_Year.ToString());
                this.lbSalaryName.Text = string.Concat("Bảng Tính Lương Tháng ", this.m_Month.ToString(), " - ", this.m_Year.ToString());
                HRM_SALARY hRMSALARY = new HRM_SALARY();
                this.gcList.DataSource = hRMSALARY.GetList(this.m_Level, this.m_Code, this.m_SalaryTableListID);
                HRM_SALARY_TABLELIST hRMSALARYTABLELIST = new HRM_SALARY_TABLELIST();
                hRMSALARYTABLELIST.Get(this.m_Month, this.m_Year);
                BandedGridColumn bandedGridColumn = this.colSocialInsurance;
                double socialInsurance = hRMSALARYTABLELIST.SocialInsurance;
                bandedGridColumn.Caption = string.Concat("BHXH (", socialInsurance.ToString(), "%)");
                BandedGridColumn bandedGridColumn1 = this.colHealthInsurance;
                socialInsurance = hRMSALARYTABLELIST.HealthInsurance;
                bandedGridColumn1.Caption = string.Concat("BHYT (", socialInsurance.ToString(), "%)");
                BandedGridColumn bandedGridColumn2 = this.colUnemploymentInsurance;
                socialInsurance = hRMSALARYTABLELIST.UnemploymentInsurance;
                bandedGridColumn2.Caption = string.Concat("BHTN (", socialInsurance.ToString(), "%)");
                BandedGridColumn bandedGridColumn3 = this.colInsurance;
                socialInsurance = hRMSALARYTABLELIST.SocialInsurance + hRMSALARYTABLELIST.HealthInsurance + hRMSALARYTABLELIST.UnemploymentInsurance;
                bandedGridColumn3.Caption = string.Concat("BHXH, BHYT, BHTN (", socialInsurance.ToString(), "%)");
                BandedGridColumn bandedGridColumn4 = this.colSocialInsurance1;
                socialInsurance = hRMSALARYTABLELIST.SocialInsurance1;
                bandedGridColumn4.Caption = string.Concat("BHXH (", socialInsurance.ToString(), "%)");
                BandedGridColumn bandedGridColumn5 = this.colHealthInsurance1;
                socialInsurance = hRMSALARYTABLELIST.HealthInsurance1;
                bandedGridColumn5.Caption = string.Concat("BHYT (", socialInsurance.ToString(), "%)");
                BandedGridColumn bandedGridColumn6 = this.colUnemploymentInsurance1;
                socialInsurance = hRMSALARYTABLELIST.UnemploymentInsurance1;
                bandedGridColumn6.Caption = string.Concat("BHTN (", socialInsurance.ToString(), "%)");
                BandedGridColumn bandedGridColumn7 = this.colInsurance1;
                socialInsurance = hRMSALARYTABLELIST.SocialInsurance1 + hRMSALARYTABLELIST.HealthInsurance1 + hRMSALARYTABLELIST.UnemploymentInsurance1;
                bandedGridColumn7.Caption = string.Concat("BHXH, BHYT, BHTN (", socialInsurance.ToString(), "%)");
            }
            catch
            {
            }
            this.InitTimeKeeperColumn();
            this.InitSalaryPlusMinus();
        }

        private void LoadInterface()
        {
            if (!xucSalary.LoadStyle())
            {
                this.dpFooter.Visibility = DockVisibility.AutoHide;
            }
            else
            {
                this.dpFooter.Visibility = DockVisibility.Visible;
            }
        }

        private string LoadMailContent()
        {
            string str;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\sendMailSalary.xml"));
                str = dataSet.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                str = "Chào [Giới tính] [Họ lót] [Tên] thân mến![Xuống dòng]Hiện tại phiếu tính lương tháng [Tháng]/[Năm] đã có. [Giới tính] có thể download file kèm theo dưới đây để tham khảo. Nếu có gì thắc mắc cần được giải đáp, [Giới tính] có thể phản hồi trở lại bằng địa chỉ email này.[Xuống dòng]Thân chào! Chúc vui vẻ!";
            }
            return str;
        }

        private void LoadSalaryCard()
        {
            try
            {
                DockPanel dockPanel = this.dpFooter;
                string[] upper = new string[] { "PHIẾU LƯƠNG NHÂN VIÊN (", this.bbeName.EditValue.ToString().ToUpper(), ") - ", this.gbList.GetFocusedRowCellValue(this.colFirstName).ToString().ToUpper(), " ", this.gbList.GetFocusedRowCellValue(this.colLastName).ToString().ToUpper(), " (", this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString().ToUpper(), ")" };
                dockPanel.Text = string.Concat(upper);
            }
            catch
            {
                this.dpFooter.Text = "PHIẾU LƯƠNG NHÂN VIÊN";
            }
            try
            {
                this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
               this.xucSalaryCard1.SetData(this.m_SalaryTableListID, this.m_EmployeeCode, this.m_Month, this.m_Year);
            }
            catch
            {
            }
        }

        private static bool LoadStyle()
        {
            bool flag;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucSalary.xml"));
                flag = bool.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            }
            catch
            {
                flag = true;
            }
            return flag;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.bbiAdd.Visibility = BarItemVisibility.Never;
            this.bbiEdit.Visibility = BarItemVisibility.Never;
            this.bbiDelete.Visibility = BarItemVisibility.Never;
            this.bbiQuickAdd.Visibility = BarItemVisibility.Never;
            this.bbiReCreate.Visibility = BarItemVisibility.Always;
            this.bbiSendMail.Visibility = BarItemVisibility.Always;
        }

        protected override void Print()
        {
            //xfmOptionPrintSalary _xfmOptionPrintSalary;
            //base.Print();
            //try
            //{
            //    _xfmOptionPrintSalary = new xfmOptionPrintSalary(this.m_Level, this.m_Code, this.m_Month, this.m_Year, this.m_EmployeeCode);
            //    _xfmOptionPrintSalary.ShowDialog();
            //}
            //catch
            //{
            //    _xfmOptionPrintSalary = new xfmOptionPrintSalary(this.m_Level, this.m_Code, this.m_Month, this.m_Year, "");
            //    _xfmOptionPrintSalary.ShowDialog();
            //}
        }

        private void RaisePayEventHander(int Month, int Year)
        {
            if (this.PayEvented != null)
            {
                this.PayEvented(this, Month, Year);
            }
        }

        protected override void ReCreate()
        {
            base.ReCreate();
            Options.SetWaitDialogCaption("Đang tính lại lương...");
            HRM_SALARY_TABLELIST hRMSALARYTABLELIST = new HRM_SALARY_TABLELIST();
            DIC_SALARY_FORMULA dICSALARYFORMULA = new DIC_SALARY_FORMULA();
            dICSALARYFORMULA.Get();
            hRMSALARYTABLELIST.Update(this.m_SalaryTableListID.ToString(), this.bbeName.EditValue.ToString(), this.m_Month, this.m_Year, dICSALARYFORMULA.SocialInsurance, dICSALARYFORMULA.HealthInsurance, dICSALARYFORMULA.UnemploymentInsurance, dICSALARYFORMULA.SocialInsurance1, dICSALARYFORMULA.HealthInsurance1, dICSALARYFORMULA.UnemploymentInsurance1, dICSALARYFORMULA.OvertimeSaturdayType, false, false);
            clsSalaryOption _clsSalaryOption = new clsSalaryOption();
            HRM_SALARY_ALLOWANCE.Create(this.m_SalaryTableListID.ToString(), _clsSalaryOption.IsAllowanceReCreate);
            HRM_SALARY_INCOME.Create(this.m_SalaryTableListID.ToString());
            HRM_SALARY.Create(this.m_Level, this.m_Code, this.m_SalaryTableListID.ToString(), this.bbeName.EditValue.ToString(), this.m_Month, this.m_Year);
            this.LoadGrid();
            Options.HideDialog();
        }

        protected override void Reload()
        {
            base.Reload();
            this.InitAllowanceColumn();
            this.InitTimeKeeperColumn();
        }

        private static void SaveStyle(bool ShowFooter)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("ShowFooter", typeof(string));
                object[] str = new object[] { ShowFooter.ToString() };
                dataTable.Rows.Add(new object[0]);
                dataTable.Rows[0][0] = str[0];
                dataSet.Tables.Add(dataTable);
            }
            finally
            {
                if (dataTable != null)
                {
                    ((IDisposable)dataTable).Dispose();
                }
            }
            try
            {
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucSalary.xml"));
            }
            catch
            {
            }
        }

        //protected override void SendMail()
        //{
        //    if (!WinInet.IsConnectedToInternet())
        //    {
        //        XtraMessageBox.Show("Vui lòng kiểm tra lại kết nối với mạng internet!");
        //    }
        //    else
        //    {
        //        SendReportMail sendReportMail = new SendReportMail();
        //        if (!sendReportMail.IsLoginMail())
        //        {
        //            sendReportMail.LoginSuccessed += new SendReportMail.LoginSuccessHander((object s) => this.SendMail("", true));
        //            sendReportMail.Sended += new SendReportMail.SendHander((object s, string content, bool attach) => this.SendMail(content, attach));
        //            sendReportMail.LoginMail(2);
        //            return;
        //        }
        //        if ((new clsAllOption()).ShowSendMail)
        //        {
        //            xfmMailContent _xfmMailContent = new xfmMailContent(2);
        //            _xfmMailContent.Sended += new xfmMailContent.SendHander((object s, string content, bool attach) => {
        //                _xfmMailContent.Close();
        //                this.SendMail(content, attach);
        //            });
        //            _xfmMailContent.ShowDialog();
        //        }
        //        else
        //        {
        //            this.SendMail("", true);
        //        }
        //    }
        //}

        //private void SendMail(string Content, bool Attach)
        //{
        //    if (Content == "")
        //    {
        //        Content = this.LoadMailContent();
        //    }
        //    HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
        //    int[] selectedRows = this.gbList.GetSelectedRows();
        //    int length = (int)selectedRows.Length;
        //    while (length > 0)
        //    {
        //        string str = this.gbList.GetRowCellValue(selectedRows[length - 1], "EmployeeCode").ToString();
        //        hRMEMPLOYEE.Get(str);
        //        if (!(hRMEMPLOYEE.Email == ""))
        //        {
        //            clsOptionPrintSalary _clsOptionPrintSalary = new clsOptionPrintSalary();
        //            XtraReport xtraReport = new XtraReport();
        //            if (_clsOptionPrintSalary.Theme == 0)
        //            {
        //                xtraReport = new rptSalary(this.m_Month, this.m_Year, str);
        //            }
        //            else if (_clsOptionPrintSalary.Theme != 1)
        //            {
        //                xtraReport = new rptSalary3(this.m_Month, this.m_Year, str);
        //            }
        //            else
        //            {
        //                xtraReport = new rptSalary2(this.m_Month, this.m_Year, str);
        //            }
        //            SendReportMail sendReportMail = new SendReportMail();
        //            string str1 = "";
        //            str1 = (!hRMEMPLOYEE.Sex ? "Chị" : "Anh");
        //            string str2 = Content.Replace("[Mã nhân viên]", str);
        //            str2 = str2.Replace("[Họ lót]", hRMEMPLOYEE.FirstName);
        //            str2 = str2.Replace("[Tên]", hRMEMPLOYEE.LastName);
        //            string[] strArrays = new string[5];
        //            int birthdayDay = hRMEMPLOYEE.BirthdayDay;
        //            strArrays[0] = birthdayDay.ToString();
        //            strArrays[1] = "/";
        //            birthdayDay = hRMEMPLOYEE.BirthdayMonth;
        //            strArrays[2] = birthdayDay.ToString();
        //            strArrays[3] = "/";
        //            birthdayDay = hRMEMPLOYEE.BirthdayYear;
        //            strArrays[4] = birthdayDay.ToString();
        //            str2 = str2.Replace("[Ngày sinh]", string.Concat(strArrays));
        //            str2 = str2.Replace("[Giới tính]", str1);
        //            str2 = str2.Replace("[Nơi sinh]", hRMEMPLOYEE.BirthPlace);
        //            str2 = str2.Replace("[Địa chỉ]", hRMEMPLOYEE.MainAddress);
        //            str2 = str2.Replace("[Tạm trú]", hRMEMPLOYEE.ContactAddress);
        //            str2 = str2.Replace("[CMND]", hRMEMPLOYEE.IDCard);
        //            str2 = str2.Replace("[Email]", hRMEMPLOYEE.Email);
        //            str2 = str2.Replace("[Điện thoại]", hRMEMPLOYEE.CellPhone);
        //            str2 = str2.Replace("[Chức vụ]", hRMEMPLOYEE.Position);
        //            str2 = str2.Replace("[Chi nhánh]", hRMEMPLOYEE.BranchName);
        //            str2 = str2.Replace("[Phòng ban]", hRMEMPLOYEE.DepartmentName);
        //            str2 = str2.Replace("[Tổ nhóm]", hRMEMPLOYEE.GroupName);
        //            decimal basicSalary = hRMEMPLOYEE.BasicSalary;
        //            str2 = str2.Replace("[Lương căn bản]", basicSalary.ToString("#,0"));
        //            str2 = str2.Replace("[Tháng]", this.m_Month.ToString());
        //            str2 = str2.Replace("[Năm]", this.m_Year.ToString());
        //            str2 = str2.Replace("[Xuống dòng]", "<br/>");
        //            sendReportMail.Send(hRMEMPLOYEE.Email, string.Concat(MyLogin.Account, " - ", MyInfo.Company), string.Concat("Phiếu Lương Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()), str2, xtraReport, string.Concat(hRMEMPLOYEE.EmployeeCode, "_", this.m_Month.ToString(), this.m_Year.ToString()), Attach);
        //            length--;
        //        }
        //        else
        //        {
        //            XtraMessageBox.Show("Chưa thiết lập địa chỉ email cho nhân viên này!");
        //            break;
        //        }
        //    }
        //}

        private void UpdateAllowanceRow()
        {
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            HRM_SALARY hRMSALARY = new HRM_SALARY();
            foreach (DataRow row in dICALLOWANCE.GetList().Rows)
            {
                try
                {
                    this.gbList.SetFocusedRowCellValue(row["AllowanceCode"].ToString(), hRMSALARY.GetTotalAllowance(this.m_SalaryTableListID, this.m_EmployeeCode, row["AllowanceCode"].ToString(), false));
                    this.gbList.SetFocusedRowCellValue(string.Concat("Tax", row["AllowanceCode"].ToString()), hRMSALARY.GetTotalAllowance(this.m_SalaryTableListID, this.m_EmployeeCode, row["AllowanceCode"].ToString(), true));
                }
                catch
                {
                }
            }
        }

        private void UpdateIncomeRow()
        {
            HRM_SALARY_INCOME hRMSALARYINCOME = new HRM_SALARY_INCOME();
            HRM_SALARY hRMSALARY = new HRM_SALARY();
            foreach (DataRow row in hRMSALARYINCOME.GetList().Rows)
            {
                try
                {
                    this.gbList.SetFocusedRowCellValue(string.Concat("Income", row["IncomeCode"].ToString()), hRMSALARY.GetTotalIncome(this.m_SalaryTableListID, this.m_EmployeeCode, row["IncomeCode"].ToString()));
                }
                catch
                {
                }
            }
        }

        private void UpdateRow(HRM_SALARY Item)
        {
            this.gbList.SetFocusedRowCellValue(this.colCoefficientSalary, Item.CoefficientSalary);
            this.gbList.SetFocusedRowCellValue(this.colBasicSalary, Item.BasicSalary);
            this.gbList.SetFocusedRowCellValue(this.colInsuranceSalary, Item.InsuranceSalary);
            this.gbList.SetFocusedRowCellValue(this.colAllowanceInsurance, Item.AllowanceInsurance);
            this.gbList.SetFocusedRowCellValue(this.colAllowance, Item.Allowance);
            this.gbList.SetFocusedRowCellValue(this.colTotalSalary, Item.TotalSalary);
            this.gbList.SetFocusedRowCellValue(this.colAssignment, Item.Assignment);
            this.gbList.SetFocusedRowCellValue(this.colAssignmentPay, Item.AssignmentPay);
            this.gbList.SetFocusedRowCellValue(this.colAssignmentDebt, Item.AssignmentDebt);
            this.gbList.SetFocusedRowCellValue(this.colStipulatedTime, Item.StipulatedTime);
            this.gbList.SetFocusedRowCellValue(this.colWorkHour, Item.WorkHour);
            this.gbList.SetFocusedRowCellValue(this.colLateEarlyHour, Item.LateEarlyHour);
            this.gbList.SetFocusedRowCellValue(this.colMinusLateEarly, Item.MinusLateEarly);
            this.gbList.SetFocusedRowCellValue(this.colMinusMoney, Item.MinusMoney);
            this.gbList.SetFocusedRowCellValue(this.colWorkSalary, Item.WorkSalary);
            this.gbList.SetFocusedRowCellValue(this.colSocialInsurance, Item.SocialInsurance);
            this.gbList.SetFocusedRowCellValue(this.colHealthInsurance, Item.HealthInsurance);
            this.gbList.SetFocusedRowCellValue(this.colUnemploymentInsurance, Item.UnemploymentInsurance);
            this.gbList.SetFocusedRowCellValue(this.colInsurance, Item.Insurance);
            this.gbList.SetFocusedRowCellValue(this.colSalaryPlusBefore, Item.SalaryPlusBefore);
            this.gbList.SetFocusedRowCellValue(this.colSalaryMinusBefore, Item.SalaryMinusBefore);
            this.gbList.SetFocusedRowCellValue(this.colWorkSalary1, Item.WorkSalary1);
            this.gbList.SetFocusedRowCellValue(this.colIncomeTax, Item.IncomeTax);
            this.gbList.SetFocusedRowCellValue(this.colNumberDepend, Item.NumberDepend);
            this.gbList.SetFocusedRowCellValue(this.colDependMoney, Item.DependMoney);
            this.gbList.SetFocusedRowCellValue(this.colIncomeTaxRemain, Item.IncomeTaxRemain);
            this.gbList.SetFocusedRowCellValue(this.colIncomeTaxMoney, Item.IncomeTaxMoney);
            this.gbList.SetFocusedRowCellValue(this.colRemainSalary, Item.RemainSalary);
            this.gbList.SetFocusedRowCellValue(this.colAdvance, Item.Advance);
            this.gbList.SetFocusedRowCellValue(this.colUnion, Item.Union);
            this.gbList.SetFocusedRowCellValue(this.colUnion1, Item.Union1);
            this.gbList.SetFocusedRowCellValue(this.colSalaryPlus, Item.SalaryPlus);
            this.gbList.SetFocusedRowCellValue(this.colSalaryPlusPay, Item.SalaryPlusPay);
            this.gbList.SetFocusedRowCellValue(this.colSalaryMinus, Item.SalaryMinus);
            this.gbList.SetFocusedRowCellValue(this.colSalary, Item.Salary);
            this.gbList.SetFocusedRowCellValue(this.colSalaryPay, Item.SalaryPay);
            this.gbList.SetFocusedRowCellValue(this.colSalaryDebt, Item.SalaryDebt);
            this.UpdateAllowanceRow();
            this.UpdateIncomeRow();
        }

        private void xucSalary_Load(object sender, EventArgs e)
        {
            this.LoadInterface();
        }

        private void xucSalaryCard1_Updated(object sender)
        {
            HRM_SALARY hRMSALARY = new HRM_SALARY();
            hRMSALARY.Get(this.m_SalaryTableListID, this.m_EmployeeCode);
            this.UpdateRow(hRMSALARY);
        }



        public event xucSalary.PayEventHander PayEvented;

        public delegate void PayEventHander(object sender, int Month, int Year);

        private void dpFooter_VisibilityChanged_1(object sender, VisibilityChangedEventArgs e)
        {
            if ((this.dpFooter.Visibility == DockVisibility.AutoHide ? false : this.dpFooter.Visibility != DockVisibility.Hidden))
            {
                xucSalary.SaveStyle(true);
            }
            else
            {
                xucSalary.SaveStyle(false);
            }
        }

        private void gbList_FocusedRowChanged_1(object sender, FocusedRowChangedEventArgs e)
        {
            this.LoadSalaryCard();
        }

        private void xucSalaryCard1_Updated_1(object sender)
        {
            HRM_SALARY hRMSALARY = new HRM_SALARY();
            hRMSALARY.Get(this.m_SalaryTableListID, this.m_EmployeeCode);
            this.UpdateRow(hRMSALARY);
        }

        private void xucSalary_Load_1(object sender, EventArgs e)
        {

        }

        private void gcList_Click(object sender, EventArgs e)
        {

        }
    }
}
