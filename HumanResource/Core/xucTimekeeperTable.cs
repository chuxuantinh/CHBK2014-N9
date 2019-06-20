using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Dictionnary;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core.Class;
//using CHBK2014_N9.HumanResource.Core.Process;
using CHBK2014_N9.HumanResource.Report;
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucTimekeeperTable : xucBase
    {
     
        private Guid m_TimeKeeperTableListID = Guid.Empty;

        private int m_Month = 0;

        private int m_Year = 0;

        private string m_CompanyName = "";

        private bool m_IsLock = false;

        private bool m_IsFinish = false;

        private string m_EmployeeCode = "";

        private string m_ShiftCode = "";

        private DateTime m_Date;

        private DateTime m_TimeIn;

        private DateTime m_TimeOut;

        private string m_Symbol = "";

        private string m_NewSymbol = "";

        private double m_Hour = 0;

        private double m_OldHour = 0;

        private double m_DayHour = 0;

        private double m_NightHour = 0;

        private double m_PrivateHour = 0;

        private int m_LateMinute = 0;

        private int m_OldLateMinute = 0;

        private int m_EarlyMinute = 0;

        private int m_OldEarlyMinute = 0;

        private bool m_IsOvertime = false;

        private bool m_IsWork = true;

        private int m_Level = MyLogin.Level;

        private string m_Code = MyLogin.Code;

        private int m_Sorted = 0;

        private string m_Description = "";

        private clsAllOption clsAllOption = new clsAllOption();

        public DataTable dt_Timekeeper = new DataTable();

        private bool m_IsEditValueChanged = true;

        private bool m_IsSetRowCellValue = true;

        private double x_WorkTotal = 0;

        private double x_RealDay = 0;

        private double x_RegulationDay = 0;

        private double x_FurloughDay = 0;

        private double x_CompensationDay = 0;

        private double x_AbsentWOL = 0;

        private double x_AbsentL = 0;

        private double x_ClockingError = 0;

        private double x_ClockingErrorBegin = 0;

        private double x_ClockingErrorEnd = 0;

        private double x_TotalHour = 0;

        private int x_LateMinute = 0;

        private int x_EarlyMinute = 0;

        private int x_NightDutyDay = 0;

        private double x_ExtraHour = 0;

        private double x_PrivateHour = 0;

        private string x_OEmployeeCode;

       private xucTimekeepingAdd xucTimekeepingAdd = new xucTimekeepingAdd();

     
        public xucTimekeeperTable()
        {
            this.InitializeComponent();
            base.RestoreLayout(this.gbList, this);
             this.Init();
            this.InitSymbol();
           base.Load += new EventHandler(this.xucTimekeeperTable_Load);
        }

     

       

        private void bbeYear_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = Convert.ToDateTime(this.bbeYear.EditValue.ToString());
                this.m_Year = dateTime.Year;
                this.LoadTimeKeeperTableList();
            }
            catch
            {
            }
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseClosedHandler();
        }

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            this._exportView = this.gbList;
          //  SYS_LOG.Insert("Bảng Chấm Công Tháng", "Xuất");
            base.Export();
        }

        private void bbiFinish_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ClsOption.System2.IsQuestion)
            {
                if (XtraMessageBox.Show(string.Concat("Bạn có chắc là muốn thực hiện tác vụ này không?", Environment.NewLine, " Tác vụ này được hiểu là bạn đã hoàn thành bảng chấm công của tháng này!"), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            if (!((new HRM_TIMEKEEPER_TABLELIST()).Finish(this.m_TimeKeeperTableListID).ToString() == "OK"))
            {
                MessageBox.Show("Fail!");
            }
            else
            {
                this.m_IsLock = true;
                this.m_IsFinish = true;
                this.InitInterface();
            }
        }

        private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((this.m_Month == 0 ? true : this.m_Year == 0))
            {
                XtraMessageBox.Show("Vui lòng chọn tháng chấm công tương ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                xfmInsertSymbol _xfmInsertSymbol = new xfmInsertSymbol(this.m_Month, this.m_Year);
                _xfmInsertSymbol.UnShiftData += new xfmInsertSymbol.UnShiftDataHandler(this.xfmInsertSymbol_UnShiftData);
                _xfmInsertSymbol.ShowDialog();
            }
        }

        private void bbiLock_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!((new HRM_TIMEKEEPER_TABLELIST()).Lock(this.m_TimeKeeperTableListID).ToString() == "OK"))
            {
                MessageBox.Show("Fail!");
            }
            else
            {
                this.m_IsLock = true;
                this.InitInterface();
            }
        }

        private void bbiOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!((new HRM_TIMEKEEPER_TABLELIST()).Open(this.m_TimeKeeperTableListID).ToString() == "OK"))
            {
                MessageBox.Show("Fail!");
            }
            else
            {
                this.m_IsLock = false;
                this.InitInterface();
            }
        }

        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            //xfmOptionPrintTimekeeperTable _xfmOptionPrintTimekeeperTable = new xfmOptionPrintTimekeeperTable(this.m_Level, this.m_Code, this.m_Month, this.m_Year, 0);
            //_xfmOptionPrintTimekeeperTable.ShowDialog();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.LoadGrid(this.m_Level, this.m_Code);
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!this.SaveData())
            {
                XtraMessageBox.Show("Lưu thất bại!");
            }
            else
            {
                XtraMessageBox.Show("Quá trình lưu đã hoàn tất!");
            }
        }

        private void bbiTimekeeperExtraPrivate_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new clsTimeKeeperOption()
            {
                TimeKeeperTableDefault = 3
            }).SaveOption();
            this.RaiseTimekeeperTableHourSelectedHandler(this.m_Code, this.m_TimeKeeperTableListID, this.m_Year, 2);

        }

        private void bbiTimekeeperTable1_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new clsTimeKeeperOption()
            {
                TimeKeeperTableDefault = 1
            }).SaveOption();
            this.RaiseTimekeeperTableHourSelectedHandler(this.m_Code, this.m_TimeKeeperTableListID, this.m_Year, 0);

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new clsTimeKeeperOption()
            {
                TimeKeeperTableDefault = 2
            }).SaveOption();
            this.RaiseTimekeeperTableHourSelectedHandler(this.m_Code, this.m_TimeKeeperTableListID, this.m_Year, 1);

        }

        private void btSymbolEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new clsTimeKeeperOption()
            {
                TimeKeeperTableDefault = 3
            }).SaveOption();
            this.RaiseTimekeeperTableHourSelectedHandler(this.m_Code, this.m_TimeKeeperTableListID, this.m_Year, 2);
        }


        private string DayName(int Year, int Month, int Day)
        {
            string str;
            try
            {
                DateTime dateTime = new DateTime(Year, Month, Day);
                str = string.Concat(Day.ToString(), " ", dateTime.DayOfWeek.ToString().Substring(0, 3));
            }
            catch
            {
                str = Day.ToString();
            }
            return str;
        }

        public bool DeleteData()
        {
            bool flag;
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            flag = (!(hRMTIMEKEEPER.DeleteByEmployeeShift(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date) != "OK") ? true : false);
            return flag;
        }

        private void dpFooter_SizeChanged(object sender, EventArgs e)
        {
            if ((this.dpFooter.Visibility == DockVisibility.AutoHide ? false : this.dpFooter.Visibility != DockVisibility.Hidden))
            {
                this.SaveStyle(true, this.dpFooter.Height);
            }
            else
            {
                this.SaveStyle(false, this.dpFooter.Height);
            }
        }

        private void dpFooter_VisibilityChanged(object sender, VisibilityChangedEventArgs e)
        {
            if ((this.dpFooter.Visibility == DockVisibility.AutoHide ? false : this.dpFooter.Visibility != DockVisibility.Hidden))
            {
                this.SaveStyle(true, this.dpFooter.Height);
            }
            else
            {
                this.SaveStyle(false, this.dpFooter.Height);
            }
        }

        private void gbList_CellMerge(object sender, CellMergeEventArgs e)
        {
            if ((e.Column == this.gbList.Columns["WorkTotal"] || e.Column == this.gbList.Columns["RealDay"] || e.Column == this.gbList.Columns["RegulationDay"] || e.Column == this.gbList.Columns["FurloughDay"] || e.Column == this.gbList.Columns["CompensationDay"] || e.Column == this.gbList.Columns["AbsentWOL"] || e.Column == this.gbList.Columns["AbsentL"] || e.Column == this.gbList.Columns["ClockingError"] || e.Column == this.gbList.Columns["ClockingErrorBegin"] || e.Column == this.gbList.Columns["ClockingErrorEnd"] || e.Column == this.gbList.Columns["TotalHour"] || e.Column == this.gbList.Columns["LateMinute"] || e.Column == this.gbList.Columns["EarlyMinute"] || e.Column == this.gbList.Columns["NightDutyDay"] || e.Column == this.gbList.Columns["ExtraHour"] ? true : e.Column == this.gbList.Columns["PrivateHour"]))
            {
                string str = Convert.ToString(this.gbList.GetRowCellValue(e.RowHandle1, this.gbList.Columns["EmployeeCode"]));
                string str1 = Convert.ToString(this.gbList.GetRowCellValue(e.RowHandle2, this.gbList.Columns["EmployeeCode"]));
                e.Handled = true;
                if (str == str1)
                {
                    e.Merge = true;
                    e.Handled = false;
                }
            }
        }

        private void gbList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if ((e.Column == this.colRealDay || e.Column == this.colWorkTotal || e.Column == this.colCompensationDay || e.Column == this.colRegulationDay || e.Column == this.colFurloughDay || e.Column == this.colAbsentWOL || e.Column == this.colAbsentL || e.Column == this.colClockingError || e.Column == this.colClockingErrorBegin || e.Column == this.colClockingErrorEnd || e.Column == this.colTotalHour || e.Column == this.colLateMinute || e.Column == this.colEarlyMinute || e.Column == this.colNightDutyDay || e.Column == this.colExtraHour ? false : e.Column != this.colPrivateHour))
            {
                if (this.m_IsEditValueChanged)
                {
                    this.m_NewSymbol = e.Value.ToString();
                    this.m_IsWork = HRM_TIMEKEEPER_SHIFT.IsWork(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date.Day);
                    if (this.MultiSymbolIsExist())
                    {
                        string[] strArrays = this.m_NewSymbol.Split(new char[] { ';' });
                        for (int i = 0; i < (int)strArrays.Length; i++)
                        {
                            this.m_NewSymbol = strArrays[i];
                            this.TotalCalculate(i, (int)strArrays.Length);
                            DataRowCollection rows = this.dt_Timekeeper.Rows;
                            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_NewSymbol, this.m_TimeIn, this.m_TimeOut, this.m_Hour, this.m_DayHour, this.m_NightHour, this.m_PrivateHour, this.m_LateMinute, this.m_EarlyMinute, this.m_IsOvertime, this.m_IsWork, i, this.m_Description };
                            rows.Add(mTimeKeeperTableListID);
                        }
                        this.DeleteData();
                        if (this.SaveData())
                        {
                            if (this.m_IsSetRowCellValue)
                            {
                                this.SetRowCellValue(e.RowHandle, this.m_EmployeeCode);
                            }
                            else
                            {
                                this.m_IsSetRowCellValue = true;
                            }
                        }
                        this.SaveProcess();
                    }
                    else
                    {
                        this.gbList.SetFocusedValue(this.m_Symbol);
                        MessageBox.Show("Ký hiệu chấm công không tồn tại!");
                    }
                }
                else
                {
                    this.m_IsEditValueChanged = true;
                    this.SetRowCellValue(e.RowHandle, this.m_EmployeeCode);
                }
            }
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

        private void gbList_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            int num = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                this.x_OEmployeeCode = "";
                this.x_WorkTotal = 0;
                this.x_RealDay = 0;
                this.x_RegulationDay = 0;
                this.x_FurloughDay = 0;
                this.x_CompensationDay = 0;
                this.x_AbsentWOL = 0;
                this.x_AbsentL = 0;
                this.x_ClockingError = 0;
                this.x_ClockingErrorBegin = 0;
                this.x_ClockingErrorEnd = 0;
                this.x_TotalHour = 0;
                this.x_LateMinute = 0;
                this.x_EarlyMinute = 0;
                this.x_NightDutyDay = 0;
                this.x_ExtraHour = 0;
                this.x_PrivateHour = 0;
            }
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                string str = this.gbList.GetRowCellValue(e.RowHandle, "EmployeeCode").ToString();
                if (str != this.x_OEmployeeCode)
                {
                    switch (num)
                    {
                        case 0:
                            {
                                this.x_WorkTotal += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 1:
                            {
                                this.x_RealDay += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 2:
                            {
                                this.x_RegulationDay += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 3:
                            {
                                this.x_FurloughDay += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 4:
                            {
                                this.x_CompensationDay += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 5:
                            {
                                this.x_AbsentWOL += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 6:
                            {
                                this.x_AbsentL += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 7:
                            {
                                this.x_ClockingError += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 8:
                            {
                                this.x_ClockingErrorBegin += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 9:
                            {
                                this.x_ClockingErrorEnd += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 10:
                            {
                                this.x_TotalHour += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 11:
                            {
                                this.x_LateMinute += Convert.ToInt32(e.FieldValue);
                                break;
                            }
                        case 12:
                            {
                                this.x_EarlyMinute += Convert.ToInt32(e.FieldValue);
                                break;
                            }
                        case 13:
                            {
                                this.x_NightDutyDay += Convert.ToInt32(e.FieldValue);
                                break;
                            }
                        case 14:
                            {
                                this.x_ExtraHour += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                        case 15:
                            {
                                this.x_PrivateHour += Convert.ToDouble(e.FieldValue);
                                break;
                            }
                    }
                }
                this.x_OEmployeeCode = str;
            }
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (num)
                {
                    case 0:
                        {
                            e.TotalValue = this.x_WorkTotal;
                            break;
                        }
                    case 1:
                        {
                            e.TotalValue = this.x_RealDay;
                            break;
                        }
                    case 2:
                        {
                            e.TotalValue = this.x_RegulationDay;
                            break;
                        }
                    case 3:
                        {
                            e.TotalValue = this.x_FurloughDay;
                            break;
                        }
                    case 4:
                        {
                            e.TotalValue = this.x_CompensationDay;
                            break;
                        }
                    case 5:
                        {
                            e.TotalValue = this.x_AbsentWOL;
                            break;
                        }
                    case 6:
                        {
                            e.TotalValue = this.x_AbsentL;
                            break;
                        }
                    case 7:
                        {
                            e.TotalValue = this.x_ClockingError;
                            break;
                        }
                    case 8:
                        {
                            e.TotalValue = this.x_ClockingErrorBegin;
                            break;
                        }
                    case 9:
                        {
                            e.TotalValue = this.x_ClockingErrorEnd;
                            break;
                        }
                    case 10:
                        {
                            e.TotalValue = this.x_TotalHour;
                            break;
                        }
                    case 11:
                        {
                            e.TotalValue = this.x_LateMinute;
                            break;
                        }
                    case 12:
                        {
                            e.TotalValue = this.x_EarlyMinute;
                            break;
                        }
                    case 13:
                        {
                            e.TotalValue = this.x_NightDutyDay;
                            break;
                        }
                    case 14:
                        {
                            e.TotalValue = this.x_ExtraHour;
                            break;
                        }
                    case 15:
                        {
                            e.TotalValue = this.x_PrivateHour;
                            break;
                        }
                }
            }
        }

        private void gbList_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            try
            {
                this.m_Symbol = this.gbList.GetFocusedValue().ToString();
                this.m_ShiftCode = this.gbList.GetFocusedRowCellValue(this.colShiftCode).ToString();
                this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
                this.GetOldValue(this.m_Symbol);
                int num = 0;
                string name = e.FocusedColumn.Name;
                if (name != null)
                {
                    switch (name)
                    {
                        case "colDay1":
                            {
                                num = 1;
                                break;
                            }
                        case "colDay2":
                            {
                                num = 2;
                                break;
                            }
                        case "colDay3":
                            {
                                num = 3;
                                break;
                            }
                        case "colDay4":
                            {
                                num = 4;
                                break;
                            }
                        case "colDay5":
                            {
                                num = 5;
                                break;
                            }
                        case "colDay6":
                            {
                                num = 6;
                                break;
                            }
                        case "colDay7":
                            {
                                num = 7;
                                break;
                            }
                        case "colDay8":
                            {
                                num = 8;
                                break;
                            }
                        case "colDay9":
                            {
                                num = 9;
                                break;
                            }
                        case "colDay10":
                            {
                                num = 10;
                                break;
                            }
                        case "colDay11":
                            {
                                num = 11;
                                break;
                            }
                        case "colDay12":
                            {
                                num = 12;
                                break;
                            }
                        case "colDay13":
                            {
                                num = 13;
                                break;
                            }
                        case "colDay14":
                            {
                                num = 14;
                                break;
                            }
                        case "colDay15":
                            {
                                num = 15;
                                break;
                            }
                        case "colDay16":
                            {
                                num = 16;
                                break;
                            }
                        case "colDay17":
                            {
                                num = 17;
                                break;
                            }
                        case "colDay18":
                            {
                                num = 18;
                                break;
                            }
                        case "colDay19":
                            {
                                num = 19;
                                break;
                            }
                        case "colDay20":
                            {
                                num = 20;
                                break;
                            }
                        case "colDay21":
                            {
                                num = 21;
                                break;
                            }
                        case "colDay22":
                            {
                                num = 22;
                                break;
                            }
                        case "colDay23":
                            {
                                num = 23;
                                break;
                            }
                        case "colDay24":
                            {
                                num = 24;
                                break;
                            }
                        case "colDay25":
                            {
                                num = 25;
                                break;
                            }
                        case "colDay26":
                            {
                                num = 26;
                                break;
                            }
                        case "colDay27":
                            {
                                num = 27;
                                break;
                            }
                        case "colDay28":
                            {
                                num = 28;
                                break;
                            }
                        case "colDay29":
                            {
                                num = 29;
                                break;
                            }
                        case "colDay30":
                            {
                                num = 30;
                                break;
                            }
                        case "colDay31":
                            {
                                num = 31;
                                break;
                            }
                        default:
                            {
                                goto Label1;
                            }
                    }
                }
                else
                {
                }
                Label1:
                this.m_Date = new DateTime(this.m_Year, this.m_Month, num);
                HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
                hRMTIMEKEEPER.Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_Symbol);
                this.m_Description = hRMTIMEKEEPER.Description;
            }
            catch
            {
            }
        }

        private void gbList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.m_Symbol = this.gbList.GetFocusedValue().ToString();
                this.m_ShiftCode = this.gbList.GetFocusedRowCellValue(this.colShiftCode).ToString();
                this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
                this.GetOldValue(this.m_Symbol);
                HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
                hRMTIMEKEEPER.Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_Symbol);
                this.m_Description = hRMTIMEKEEPER.Description;
            }
            catch
            {
            }
        }

        private void gbList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms. MouseButtons.Left)
            {
                base.DoShowMenu(this.gbList.CalcHitInfo(new Point(e.X, e.Y)), this.gbList, this);
            }
        }



        private void GetOldValue(string Symbol)
        {
            (new DIC_SHIFT()).Get(this.m_ShiftCode);
            if (!Information.IsNumeric(Symbol))
            {
                string[] strArrays = Symbol.Split(new char[] { ':' });
                if ((!Information.IsNumeric(strArrays[0]) ? true : Convert.ToInt32(strArrays[0]) <= 0))
                {
                    this.m_OldLateMinute = 0;
                    this.m_OldEarlyMinute = 0;
                }
                else if ((!Information.IsNumeric(strArrays[1]) ? false : Convert.ToInt32(strArrays[1]) < 0))
                {
                    this.m_OldLateMinute = Convert.ToInt32(strArrays[0]);
                    this.m_OldEarlyMinute = -Convert.ToInt32(strArrays[1]);
                }
            }
            else if (Convert.ToInt32(Symbol) <= 0)
            {
                this.m_OldLateMinute = 0;
                this.m_OldEarlyMinute = -Convert.ToInt32(Symbol);
            }
            else
            {
                this.m_OldLateMinute = Convert.ToInt32(Symbol);
                this.m_OldEarlyMinute = 0;
            }
        }

        private void GridViewLock()
        {
            if ((this.m_Month == 0 ? false : this.m_Year != 0))
            {
                int num = DateTime.DaysInMonth(this.m_Year, this.m_Month);
                this.ShowHideColumn(num);
                for (int i = 1; i <= num; i++)
                {
                    this.gbList.Columns[i + 4].OptionsColumn.ReadOnly = true;
                    this.gbList.Columns[i + 4].OptionsColumn.AllowEdit = false;
                    DateTime dateTime = new DateTime(this.m_Year, this.m_Month, i);
                    clsTimeKeeperOption _clsTimeKeeperOption = new clsTimeKeeperOption();
                    if (dateTime.DayOfWeek.ToString() == "Monday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.MondayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Tuesday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.TuesdayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Wednesday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.WednesdayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Thursday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.ThursdayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Friday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.FridayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Saturday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.SaturdayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Sunday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.SundayColor;
                    }
                    if ((new DIC_HOLIDAY()).Exist(dateTime))
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.HolidayColor;
                    }
                    this.gbList.Columns[i + 4].Caption = this.DayName(this.m_Year, this.m_Month, i);
                }
            }
        }

        private void GridViewOpen()
        {
            if ((this.m_Month == 0 ? false : this.m_Year != 0))
            {
                int num = DateTime.DaysInMonth(this.m_Year, this.m_Month);
                this.ShowHideColumn(num);
                for (int i = 1; i <= num; i++)
                {
                    this.gbList.Columns[i + 4].OptionsColumn.ReadOnly = false;
                    this.gbList.Columns[i + 4].OptionsColumn.AllowEdit = true;
                    DateTime dateTime = new DateTime(this.m_Year, this.m_Month, i);
                    clsTimeKeeperOption _clsTimeKeeperOption = new clsTimeKeeperOption();
                    if (dateTime.DayOfWeek.ToString() == "Monday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.MondayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Tuesday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.TuesdayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Wednesday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.WednesdayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Thursday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.ThursdayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Friday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.FridayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Saturday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.SaturdayColor;
                    }
                    else if (dateTime.DayOfWeek.ToString() == "Sunday")
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.SundayColor;
                    }
                    if ((new DIC_HOLIDAY()).Exist(dateTime))
                    {
                        this.gbList.Columns[i + 4].AppearanceCell.BackColor = _clsTimeKeeperOption.HolidayColor;
                    }
                    this.gbList.Columns[i + 4].Caption = this.DayName(this.m_Year, this.m_Month, i);
                }
            }
        }

        public void Init()
        {
            HRM_ORGANIZATION.SetToTwoLabel(MyLogin.Level, MyLogin.Code, this.lbMainName, this.lbSubName);
            this.bbeYear.EditValue = this.clsAllOption.MonthDefault;
            this.m_Year = this.clsAllOption.MonthDefault.Year;
            this.xucOrganization1.LoadData();
            this.xucOrganization1.Selected += new xucOrganization.SelectedEventHander((object s, Organization o) =>
            {
                this.m_Level = o.Level;
                this.m_Code = o.Code;
                HRM_ORGANIZATION.SetToTwoLabel(this.m_Level, this.m_Code, this.lbMainName, this.lbSubName);
                this.LoadGrid(this.m_Level, this.m_Code);
            });
            this.xucOrganization1.Updated += new xucOrganization.UpdatedEventHander((object o) => this.xucOrganization1.LoadData());
            this.dt_Timekeeper = (new HRM_TIMEKEEPER()).CreateNullDataTable();
            (new HRM_TIMEKEEPER_TABLELIST()).AddRepositoryGridLookupEditByYear(this.repTimeKeeperList, this.m_Year);
            this.repTimeKeeperList.ButtonClick += new ButtonPressedEventHandler(this.repTimeKeeperList_ButtonClick);

                       

            this.repPopup.PopupControl = this.ppContainerControl;
            this.ppContainerControl.Width = this.xucTimekeepingAdd.Width;
            this.ppContainerControl.Height = this.xucTimekeepingAdd.Height;
            this.ppContainerControl.Controls.Add(this.xucTimekeepingAdd);
            this.xucTimekeepingAdd.Status = Actions.Update;

            this.xucTimekeepingAdd.CancelClick += new ButtonClickEventHander((object s) => this.ppContainerControl.OwnerEdit.ClosePopup());
            this.xucTimekeepingAdd.Success += new xucTimekeepingAdd.SuccessEventHander((object s, HRM_TIMEKEEPER i) =>
            {
                this.m_IsEditValueChanged = false;
                DataTable listByShift = (new HRM_TIMEKEEPER()).GetListByShift(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
                string str = "";
                for (int num = listByShift.Rows.Count; num > 0; num--)
                {
                    DataRow item = listByShift.Rows[num - 1];
                    if (num < listByShift.Rows.Count)
                    {
                        str = string.Concat(str, ";");
                    }
                    str = (!(item["Symbol"].ToString() == "+") ? string.Concat(str, item["Symbol"].ToString()) : ((Convert.ToInt32(item["LateMinute"].ToString()) <= 0 ? true : Convert.ToInt32(item["EarlyMinute"].ToString()) != 0) ? ((Convert.ToInt32(item["LateMinute"].ToString()) != 0 ? true : Convert.ToInt32(item["EarlyMinute"].ToString()) <= 0) ? ((Convert.ToInt32(item["LateMinute"].ToString()) <= 0 ? true : Convert.ToInt32(item["EarlyMinute"].ToString()) <= 0) ? string.Concat(str, "+") : string.Concat(str, item["LateMinute"].ToString(), ":-", item["EarlyMinute"].ToString())) : string.Concat(str, "-", item["EarlyMinute"].ToString())) : string.Concat(str, item["LateMinute"].ToString())));
                }
                if (!(this.m_Symbol != str))
                {
                    this.SetRowCellValue(this.gbList.FocusedRowHandle, this.m_EmployeeCode);
                }
                else
                {
                    this.m_Symbol = str;
                    this.gbList.SetFocusedValue(str);
                }
                try
                {
                    this.ppContainerControl.OwnerEdit.ClosePopup();
                }
                catch
                {
                }
            });
        }



        private void InitInterface()
        {
            if (!(this.m_IsLock ? true : this.m_IsFinish))
            {
                this.bbiLock.Enabled = true;
                this.ptLock.Visible = false;
                this.bbiOpen.Enabled = true;
                this.bbiFinish.Enabled = true;
                this.ptFinish.Visible = false;
                this.bbiInsertSymbol.Enabled = true;
                this.lbMessage.Text = "Đã mở sổ - Bảng chấm công được phép chỉnh sửa";
                this.GridViewOpen();
            }
            else if (!(!this.m_IsLock ? true : this.m_IsFinish))
            {
                this.bbiLock.Enabled = false;
                this.ptLock.Visible = true;
                this.bbiOpen.Enabled = true;
                this.bbiFinish.Enabled = true;
                this.ptFinish.Visible = false;
                this.bbiInsertSymbol.Enabled = false;
                this.lbMessage.Text = "Đã khoá sổ - Không được phép chỉnh sửa";
                this.GridViewLock();
            }
            else if (!(this.m_IsLock ? true : !this.m_IsFinish))
            {
                this.bbiLock.Enabled = true;
                this.ptLock.Visible = false;
                this.bbiOpen.Enabled = false;
                this.bbiFinish.Enabled = false;
                this.ptFinish.Visible = true;
                this.bbiInsertSymbol.Enabled = true;
                this.lbMessage.Text = "Đã hoàn thành bảng chấm công của tháng này - Không được phép chỉnh sửa";
               this.GridViewLock();
            }
            else if ((!this.m_IsLock ? false : this.m_IsFinish))
            {
                this.bbiLock.Enabled = false;
                this.ptLock.Visible = true;
                this.bbiOpen.Enabled = false;
                this.bbiFinish.Enabled = false;
                this.ptFinish.Visible = true;
                this.bbiInsertSymbol.Enabled = false;


               this.GridViewLock();
            }
        }


        private void InitSymbol()
        {
            (new DIC_SYMBOL()).GetList();
        }

        public void LoadGrid(int Level, string Code)
        {
            try
            {
                Guid mTimeKeeperTableListID = this.m_TimeKeeperTableListID;
                HRM_TIMEKEEPER_TABLE hRMTIMEKEEPERTABLE = new HRM_TIMEKEEPER_TABLE();
                this.gcList.DataSource = hRMTIMEKEEPERTABLE.GetList(Level, Code, this.m_TimeKeeperTableListID);
                this.gbList.BestFitColumns();
            }
            catch
            {
            }
            this.InitInterface();
        }

        private void LoadInterface()
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucTimekeeperTable.xml"));
                bool flag = bool.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                int num = int.Parse(dataSet.Tables[0].Rows[0][1].ToString());
                if (!flag)
                {
                    this.dpFooter.Visibility = DockVisibility.AutoHide;
                }
                else
                {
                    this.dpFooter.Visibility = DockVisibility.Visible;
                }
                this.dpFooter.Height = num;
            }
            catch
            {
                this.dpFooter.Visibility = DockVisibility.Visible;
                this.dpFooter.Height = 110;
            }
        }

        private void LoadSymbol()
        {
            xucSymbolList _xucSymbolList = new xucSymbolList();
            _xucSymbolList.Init(true, false);
            _xucSymbolList.Dock = DockStyle.Fill;
            this.dpFooter.Controls.Add(_xucSymbolList);
            _xucSymbolList.BringToFront();
        }

        public void LoadTimeKeeperTableList()
        {
            (new HRM_TIMEKEEPER_TABLELIST()).AddRepositoryGridLookupEditByYear(this.repTimeKeeperList, this.m_Year);
            if (this.m_TimeKeeperTableListID != Guid.Empty)
            {
                this.LoadGrid(this.m_Level, this.m_Code);
            }
        }

        private bool MultiSymbolIsExist()
        {
            bool flag;
            string[] strArrays = this.m_NewSymbol.Split(new char[] { ';' });
            int num = 0;
            int num1 = 0;
            if ((int)strArrays.Length <= 2)
            {
                while (num < (int)strArrays.Length)
                {
                    if (this.SymbolIsExist(strArrays[num]))
                    {
                        num1++;
                    }
                    num++;
                }
                flag = (num1 != (int)strArrays.Length ? false : true);
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        private void RaiseClosedHandler()
        {
            if (this.Closed != null)
            {
                this.Closed(this);
            }
        }

        private void RaiseTimekeeperTableDeletedHander()
        {
            if (this.TimekeeperTableDeleted != null)
            {
                this.TimekeeperTableDeleted(this);
            }
        }

        private void RaiseTimekeeperTableHourSelectedHandler(string Code, Guid TimeKeeperTableListID, int Year, int MenuSelected)
        {
            if (this.TimekeeperTableHourSelected != null)
            {
                this.TimekeeperTableHourSelected(this, Code, TimeKeeperTableListID, Year, MenuSelected);
            }
        }

        private void RaiseTimekeeperTableInsertedHander()
        {
            if (this.TimekeeperTableInserted != null)
            {
                this.TimekeeperTableInserted(this);
            }
        }

        private void RaiseUnShiftDataHandler(int Month, int Year)
        {
            if (this.UnShiftData != null)
            {
                this.UnShiftData(this, Month, Year);
            }
        }

        private void repPopup_Popup(object sender, EventArgs e)
        {
            this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
            this.m_ShiftCode = this.gbList.GetFocusedRowCellValue(this.colShiftCode).ToString();
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            DataTable listByShift = hRMTIMEKEEPER.GetListByShift(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
            this.xucTimekeepingAdd.SetData(listByShift);
            this.xucTimekeepingAdd.Status = Actions.Update;
        }

        private void repTimeKeeperList_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                xfmShiftAdd _xfmShiftAdd = new xfmShiftAdd();
                _xfmShiftAdd.UnShiftData += new xfmShiftAdd.UnShiftDataHandler((object s, int m, int y) => this.RaiseUnShiftDataHandler(m, y));
                _xfmShiftAdd.TimekeeperTableDeleted += new xfmShiftAdd.TimekeeperTableDeletedHandler((object s) => this.RaiseTimekeeperTableDeletedHander());
                _xfmShiftAdd.ShowDialog();
            }
        }

        private void repTimeKeeperList_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void repTimeKeeperList_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.m_TimeKeeperTableListID = new Guid(e.NewValue.ToString());
        }

        private void Save()
        {
            if (!this.SaveData())
            {
                XtraMessageBox.Show("Lưu thất bại!");
            }
            else
            {
                this.LoadGrid(this.m_Level, this.m_Code);
            }
        }

        public bool SaveData()
        {
            bool flag;
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            foreach (DataRow row in this.dt_Timekeeper.Rows)
            {
                if (hRMTIMEKEEPER.Update(this.m_TimeKeeperTableListID, row["EmployeeCode"].ToString(), row["ShiftCode"].ToString(), Convert.ToDateTime(row["Date"].ToString()), row["Symbol"].ToString(), Convert.ToDateTime(row["TimeIn"].ToString()), Convert.ToDateTime(row["TimeOut"].ToString()), Convert.ToDouble(row["Hour"].ToString()), Convert.ToDouble(row["DayHour"].ToString()), Convert.ToDouble(row["NightHour"].ToString()), Convert.ToDouble(row["PrivateHour"].ToString()), Convert.ToInt32(row["LateMinute"].ToString()), Convert.ToInt32(row["EarlyMinute"].ToString()), Convert.ToBoolean(row["IsOvertime"].ToString()), Convert.ToBoolean(row["IsWork"].ToString()), Convert.ToInt32(row["Sorted"].ToString()), row["Description"].ToString()) != "OK")
                {
                    flag = false;
                    return flag;
                }
            }
            this.dt_Timekeeper.Clear();
            flag = true;
            return flag;
        }

        private void SaveProcess()
        {
            clsTimeKeeperOption _clsTimeKeeperOption = new clsTimeKeeperOption();
            if (!(!(this.m_NewSymbol == "CT") || !_clsTimeKeeperOption.ShowAssignmentDialog ? true : !(this.m_NewSymbol != this.m_Symbol)))
            {
                //xfmAssignmentAdd _xfmAssignmentAdd = new xfmAssignmentAdd(Actions.Add, this.m_EmployeeCode, this.m_Date, this.m_Date);
                //_xfmAssignmentAdd.Added += new xfmAssignmentAdd.AddedEventHander((object s, HRM_PROCESS_ASSIGNMENT e) => this.LoadGrid(this.m_Level, this.m_Code));
                //_xfmAssignmentAdd.ShowDialog();
            }
            else if (((this.m_NewSymbol == "F" || this.m_NewSymbol == "P") && _clsTimeKeeperOption.ShowPetitionDialog ? this.m_NewSymbol != this.m_Symbol : false))
            {
                //xfmPetitionAdd _xfmPetitionAdd = new xfmPetitionAdd(Actions.Add, this.m_EmployeeCode, this.m_Date, this.m_Date, this.m_NewSymbol);
                //_xfmPetitionAdd.Added += new xfmPetitionAdd.AddedEventHander((object s, HRM_PROCESS_PETITION e) => this.LoadGrid(this.m_Level, this.m_Code));
                //_xfmPetitionAdd.ShowDialog();
            }
        }

        private void SaveStyle(bool ShowFooter, int HeightFooter)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("ShowFooter", typeof(string));
                dataTable.Columns.Add("HeightFooter", typeof(string));
                object[] str = new object[] { ShowFooter.ToString(), HeightFooter.ToString() };
                object[] objArray = str;
                dataTable.Rows.Add(new object[0]);
                dataTable.Rows[0][0] = objArray[0];
                dataTable.Rows[0][1] = objArray[1];
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucTimekeeperTable.xml"));
            }
            catch
            {
            }
        }

        private void SetRowCellValue(int RowHandle, string EmployeeCode)
        {
            HRM_TIMEKEEPER_TOTAL hRMTIMEKEEPERTOTAL = new HRM_TIMEKEEPER_TOTAL();
            hRMTIMEKEEPERTOTAL.Get(this.m_TimeKeeperTableListID, EmployeeCode);
            string employeeCode = EmployeeCode;
            int rowHandle = RowHandle;
            while (EmployeeCode == employeeCode)
            {
                this.gbList.SetRowCellValue(rowHandle, this.colWorkTotal, hRMTIMEKEEPERTOTAL.WorkTotal);
                this.gbList.SetRowCellValue(rowHandle, this.colRealDay, hRMTIMEKEEPERTOTAL.RealDay);
                this.gbList.SetRowCellValue(rowHandle, this.colRegulationDay, hRMTIMEKEEPERTOTAL.RegulationDay);
                this.gbList.SetRowCellValue(rowHandle, this.colFurloughDay, hRMTIMEKEEPERTOTAL.FurloughDay);
                this.gbList.SetRowCellValue(rowHandle, this.colCompensationDay, hRMTIMEKEEPERTOTAL.CompensationDay);
                this.gbList.SetRowCellValue(rowHandle, this.colAbsentWOL, hRMTIMEKEEPERTOTAL.AbsentWOL);
                this.gbList.SetRowCellValue(rowHandle, this.colAbsentL, hRMTIMEKEEPERTOTAL.AbsentL);
                this.gbList.SetRowCellValue(rowHandle, this.colClockingError, hRMTIMEKEEPERTOTAL.ClockingError);
                this.gbList.SetRowCellValue(rowHandle, this.colClockingErrorBegin, hRMTIMEKEEPERTOTAL.ClockingErrorBegin);
                this.gbList.SetRowCellValue(rowHandle, this.colClockingErrorEnd, hRMTIMEKEEPERTOTAL.ClockingErrorEnd);
                this.gbList.SetRowCellValue(rowHandle, this.colTotalHour, hRMTIMEKEEPERTOTAL.TotalHour);
                this.gbList.SetRowCellValue(rowHandle, this.colLateMinute, hRMTIMEKEEPERTOTAL.LateMinute);
                this.gbList.SetRowCellValue(rowHandle, this.colEarlyMinute, hRMTIMEKEEPERTOTAL.EarlyMinute);
                this.gbList.SetRowCellValue(rowHandle, this.colNightDutyDay, hRMTIMEKEEPERTOTAL.NightDutyDay);
                this.gbList.SetRowCellValue(rowHandle, this.colExtraHour, hRMTIMEKEEPERTOTAL.ExtraHour);
                this.gbList.SetRowCellValue(rowHandle, this.colPrivateHour, hRMTIMEKEEPERTOTAL.PrivateHour);
                rowHandle++;
                try
                {
                    employeeCode = this.gbList.GetRowCellValue(rowHandle, this.colEmployeeCode).ToString();
                }
                catch
                {
                    employeeCode = "";
                }
            }
            rowHandle = RowHandle - 1;
            try
            {
                employeeCode = this.gbList.GetRowCellValue(rowHandle, this.colEmployeeCode).ToString();
            }
            catch
            {
                return;
            }
            while (EmployeeCode == employeeCode)
            {
                this.gbList.SetRowCellValue(rowHandle, this.colWorkTotal, hRMTIMEKEEPERTOTAL.WorkTotal);
                this.gbList.SetRowCellValue(rowHandle, this.colRealDay, hRMTIMEKEEPERTOTAL.RealDay);
                this.gbList.SetRowCellValue(rowHandle, this.colRegulationDay, hRMTIMEKEEPERTOTAL.RegulationDay);
                this.gbList.SetRowCellValue(rowHandle, this.colFurloughDay, hRMTIMEKEEPERTOTAL.FurloughDay);
                this.gbList.SetRowCellValue(rowHandle, this.colCompensationDay, hRMTIMEKEEPERTOTAL.CompensationDay);
                this.gbList.SetRowCellValue(rowHandle, this.colAbsentWOL, hRMTIMEKEEPERTOTAL.AbsentWOL);
                this.gbList.SetRowCellValue(rowHandle, this.colAbsentL, hRMTIMEKEEPERTOTAL.AbsentL);
                this.gbList.SetRowCellValue(rowHandle, this.colClockingError, hRMTIMEKEEPERTOTAL.ClockingError);
                this.gbList.SetRowCellValue(rowHandle, this.colClockingErrorBegin, hRMTIMEKEEPERTOTAL.ClockingErrorBegin);
                this.gbList.SetRowCellValue(rowHandle, this.colClockingErrorEnd, hRMTIMEKEEPERTOTAL.ClockingErrorEnd);
                this.gbList.SetRowCellValue(rowHandle, this.colTotalHour, hRMTIMEKEEPERTOTAL.TotalHour);
                this.gbList.SetRowCellValue(rowHandle, this.colLateMinute, hRMTIMEKEEPERTOTAL.LateMinute);
                this.gbList.SetRowCellValue(rowHandle, this.colEarlyMinute, hRMTIMEKEEPERTOTAL.EarlyMinute);
                this.gbList.SetRowCellValue(rowHandle, this.colNightDutyDay, hRMTIMEKEEPERTOTAL.NightDutyDay);
                this.gbList.SetRowCellValue(rowHandle, this.colExtraHour, hRMTIMEKEEPERTOTAL.ExtraHour);
                this.gbList.SetRowCellValue(rowHandle, this.colPrivateHour, hRMTIMEKEEPERTOTAL.PrivateHour);
                rowHandle--;
                try
                {
                    employeeCode = this.gbList.GetRowCellValue(rowHandle, this.colEmployeeCode).ToString();
                }
                catch
                {
                    employeeCode = "";
                }
            }
        }

        public void SetTimeKeeperTableList(Guid TimeKeeperTableListID, int Year)
        {
            this.m_Year = Year;
            this.bbeYear.EditValue = this.m_Year;
            if (TimeKeeperTableListID != Guid.Empty)
            {
                this.m_TimeKeeperTableListID = TimeKeeperTableListID;
                (new HRM_TIMEKEEPER_TABLELIST()).AddRepositoryGridLookupEditByYear(this.repTimeKeeperList, this.m_Year);
                this.bbeTimeKeeperTableListName.EditValue = TimeKeeperTableListID;
            }
        }

        private void ShowHideColumn(int NumberDay)
        {
            switch (NumberDay)
            {
                case 28:
                    {
                        this.colDay28.Visible = true;
                        this.colDay29.Visible = false;
                        this.colDay30.Visible = false;
                        this.colDay31.Visible = false;
                        break;
                    }
                case 29:
                    {
                        this.colDay28.Visible = true;
                        this.colDay29.Visible = true;
                        this.colDay30.Visible = false;
                        this.colDay31.Visible = false;
                        break;
                    }
                case 30:
                    {
                        this.colDay28.Visible = true;
                        this.colDay29.Visible = true;
                        this.colDay30.Visible = true;
                        this.colDay31.Visible = false;
                        break;
                    }
                case 31:
                    {
                        this.colDay28.Visible = true;
                        this.colDay29.Visible = true;
                        this.colDay30.Visible = true;
                        this.colDay31.Visible = true;
                        break;
                    }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.popupMenu1.ShowPopup(Control.MousePosition);
        }

        //private bool SymbolIsExist()
        //{
        //    bool flag;
        //    if (!Information.IsNumeric(this.m_NewSymbol))
        //    {
        //        string[] strArrays = this.m_NewSymbol.Split(new char[] { ':' });
        //        if ((int)strArrays.Length == 2)
        //        {
        //            if ((!Information.IsNumeric(strArrays[0]) ? false : Convert.ToInt32(strArrays[0]) > 0))
        //            {
        //                if ((!Information.IsNumeric(strArrays[1]) ? true : Convert.ToInt32(strArrays[1]) >= 0))
        //                {
        //                //  goto Label1;
        //                }
        //                flag = true;
        //                return flag;
        //            }
        //        }
        //        foreach (DataRow row in (new DIC_SYMBOL()).GetList().Rows)
        //        {
        //            if (this.m_NewSymbol == row["SymbolCode"].ToString())
        //            {
        //                flag = true;
        //                return flag;
        //            }
        //        }
        //        flag = false;
        //    }
        //    else
        //    {
        //        flag = true;
        //    }
        //    return flag;
        //}

        private bool SymbolIsExist()
        {
            if (Information.IsNumeric(this.m_NewSymbol))
            {
                return true;
            }
            string[] strArray = this.m_NewSymbol.Split(new char[] { ':' });
            if (((strArray.Length == 2) && (Information.IsNumeric(strArray[0]) && (Convert.ToInt32(strArray[0]) > 0))) && (Information.IsNumeric(strArray[1]) && (Convert.ToInt32(strArray[1]) < 0)))
            {
                return true;
            }
            DataTable list = new DIC_SYMBOL().GetList();
            foreach (DataRow row in list.Rows)
            {
                if (this.m_NewSymbol == row["SymbolCode"].ToString())
                {
                    return true;
                }
            }
            return false;
        }


        //private bool SymbolIsExist(string Symbol)
        //{
        //    bool flag;
        //    if (!Information.IsNumeric(Symbol))
        //    {
        //        string[] strArrays = Symbol.Split(new char[] { ':' });
        //        if ((int)strArrays.Length == 2)
        //        {
        //            if ((!Information.IsNumeric(strArrays[0]) ? false : Convert.ToInt32(strArrays[0]) > 0))
        //            {
        //                if ((!Information.IsNumeric(strArrays[1]) ? true : Convert.ToInt32(strArrays[1]) >= 0))
        //                {
        //                   // goto Label1;
        //                }
        //                flag = true;
        //                return flag;
        //            }
        //        }
        //        foreach (DataRow row in (new DIC_SYMBOL()).GetList().Rows)
        //        {
        //            if (Symbol == row["SymbolCode"].ToString())
        //            {
        //                flag = true;
        //                return flag;
        //            }
        //        }
        //        flag = false;
        //    }
        //    else
        //    {
        //        flag = true;
        //    }
        //    return flag;
        //}

        private bool SymbolIsExist(string Symbol)
        {
            if (Information.IsNumeric(Symbol))
            {
                return true;
            }
            string[] strArray = Symbol.Split(new char[] { ':' });
            if (((strArray.Length == 2) && (Information.IsNumeric(strArray[0]) && (Convert.ToInt32(strArray[0]) > 0))) && (Information.IsNumeric(strArray[1]) && (Convert.ToInt32(strArray[1]) < 0)))
            {
                return true;
            }
            DataTable list = new DIC_SYMBOL().GetList();
            foreach (DataRow row in list.Rows)
            {
                if (Symbol == row["SymbolCode"].ToString())
                {
                    return true;
                }
            }
            return false;
        }


        private void TotalCalculate(int i, int Length)
        {
            DateTime dateTime;
            DateTime dateTime1;
            DateTime dateTime2;
            DateTime dateTime3;
            DateTime beginTime;
            DIC_SHIFT dICSHIFT = new DIC_SHIFT();
            dICSHIFT.Get(this.m_ShiftCode);
            DateTime dateTime4 = DateAndTime.DateAdd(DateInterval.Day, 1, this.m_Date);
            if (!dICSHIFT.IsOvernight)
            {
                int year = this.m_Date.Year;
                int month = this.m_Date.Month;
                int day = this.m_Date.Day;
                int hour = dICSHIFT.BeginTime.Hour;
                beginTime = dICSHIFT.BeginTime;
                dateTime = new DateTime(year, month, day, hour, beginTime.Minute, 0);
                int num = this.m_Date.Year;
                int month1 = this.m_Date.Month;
                int day1 = this.m_Date.Day;
                int hour1 = dICSHIFT.EndTime.Hour;
                beginTime = dICSHIFT.EndTime;
                dateTime1 = new DateTime(num, month1, day1, hour1, beginTime.Minute, 0);
            }
            else
            {
                int year1 = this.m_Date.Year;
                int num1 = this.m_Date.Month;
                int day2 = this.m_Date.Day;
                int hour2 = dICSHIFT.BeginTime.Hour;
                beginTime = dICSHIFT.BeginTime;
                dateTime = new DateTime(year1, num1, day2, hour2, beginTime.Minute, 0);
                int year2 = dateTime4.Year;
                int month2 = dateTime4.Month;
                int num2 = dateTime4.Day;
                int hour3 = dICSHIFT.EndTime.Hour;
                beginTime = dICSHIFT.EndTime;
                dateTime1 = new DateTime(year2, month2, num2, hour3, beginTime.Minute, 0);
            }
            if (!dICSHIFT.IsBreakOvernight)
            {
                int year3 = this.m_Date.Year;
                int month3 = this.m_Date.Month;
                int day3 = this.m_Date.Day;
                int num3 = dICSHIFT.BreakBeginTime.Hour;
                beginTime = dICSHIFT.BreakBeginTime;
                dateTime2 = new DateTime(year3, month3, day3, num3, beginTime.Minute, 0);
                int year4 = this.m_Date.Year;
                int month4 = this.m_Date.Month;
                int day4 = this.m_Date.Day;
                int hour4 = dICSHIFT.BreakEndTime.Hour;
                beginTime = dICSHIFT.BreakEndTime;
                dateTime3 = new DateTime(year4, month4, day4, hour4, beginTime.Minute, 0);
            }
            else
            {
                int num4 = this.m_Date.Year;
                int month5 = this.m_Date.Month;
                int day5 = this.m_Date.Day;
                int hour5 = dICSHIFT.BreakBeginTime.Hour;
                beginTime = dICSHIFT.BreakBeginTime;
                dateTime2 = new DateTime(num4, month5, day5, hour5, beginTime.Minute, 0);
                int year5 = dateTime4.Year;
                int num5 = dateTime4.Month;
                int day6 = dateTime4.Day;
                int hour6 = dICSHIFT.BreakEndTime.Hour;
                beginTime = dICSHIFT.BreakEndTime;
                dateTime3 = new DateTime(year5, num5, day6, hour6, beginTime.Minute, 0);
            }
            HRM_TIMEKEEPER_BREAK hRMTIMEKEEPERBREAK = new HRM_TIMEKEEPER_BREAK();
            if (!(i != 0 || Length != 2 ? true : !dICSHIFT.IsBreak))
            {
                this.m_TimeIn = dateTime;
                this.m_TimeOut = dateTime2;
                hRMTIMEKEEPERBREAK.Delete(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
            }
            else if ((i != 1 || Length != 2 ? true : !dICSHIFT.IsBreak))
            {
                this.m_TimeIn = dateTime;
                this.m_TimeOut = dateTime1;
                if (dICSHIFT.IsBreak)
                {
                    hRMTIMEKEEPERBREAK.Delete(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
                    hRMTIMEKEEPERBREAK.Insert(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, Guid.NewGuid(), dateTime2, dateTime3,Perfect.Utils. MyDateTime.NumberHour(dateTime2, dateTime3),Perfect.Utils. MyDateTime.NumberMinute(dateTime2, dateTime3), true);
                }
            }
            else
            {
                this.m_TimeIn = dateTime3;
                this.m_TimeOut = dateTime1;
                hRMTIMEKEEPERBREAK.Delete(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
            }
            if (!Information.IsNumeric(this.m_NewSymbol))
            {
                string[] strArrays = this.m_NewSymbol.Split(new char[] { ':' });
                if ((!Information.IsNumeric(strArrays[0]) ? true : Convert.ToInt32(strArrays[0]) <= 0))
                {
                    foreach (DataRow row in (new DIC_SYMBOL()).GetList().Rows)
                    {
                        if (this.m_NewSymbol == row["SymbolCode"].ToString())
                        {
                        }
                    }
                }
                else if ((!Information.IsNumeric(strArrays[1]) ? false : Convert.ToInt32(strArrays[1]) < 0))
                {
                    this.m_TimeIn =Perfect.Utils. MyDateTime.AddMinute(this.m_TimeIn, Convert.ToInt32(strArrays[0]));
                    this.m_TimeOut =Perfect.Utils. MyDateTime.MinusMinute(this.m_TimeOut, -Convert.ToInt32(strArrays[1]));
                    this.m_NewSymbol = "+";
                }
            }
            else
            {
                if (Convert.ToInt32(this.m_NewSymbol) <= 0)
                {
                    this.m_TimeOut =Perfect.Utils. MyDateTime.MinusMinute(this.m_TimeOut, -Convert.ToInt32(this.m_NewSymbol));
                }
                else
                {
                    this.m_TimeIn =Perfect.Utils. MyDateTime.AddMinute(this.m_TimeIn, Convert.ToInt32(this.m_NewSymbol));
                }
                this.m_NewSymbol = "+";
            }
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            hRMTIMEKEEPER.Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_NewSymbol, this.m_Date, this.m_TimeIn, this.m_TimeOut, i, Length);
            this.m_TimeIn = hRMTIMEKEEPER.TimeIn;
            this.m_TimeOut = hRMTIMEKEEPER.TimeOut;
            this.m_Hour = hRMTIMEKEEPER.Hour;
            this.m_DayHour = hRMTIMEKEEPER.DayHour;
            this.m_NightHour = hRMTIMEKEEPER.NightHour;
            this.m_LateMinute = hRMTIMEKEEPER.LateMinute;
            this.m_EarlyMinute = hRMTIMEKEEPER.EarlyMinute;
        }

        private void xfmInsertSymbol_UnShiftData(object sender, string Symbol, int FromDate, int ToDate, int FromRow, int ToRow, bool IsCheckAll)
        {
            int i;
            int j;
            object[] mTimeKeeperTableListID;
            try
            {
                if (!IsCheckAll)
                {
                    for (i = FromDate; i <= ToDate; i++)
                    {
                        for (j = FromRow - 1; j <= ToRow - 1; j++)
                        {
                            if (j % 30 == 0)
                            {
                                base.SetWaitDialogCaption(string.Concat("Đang cập nhật ngày ", i.ToString(), " dòng..", j.ToString()));
                            }
                            try
                            {
                                this.m_NewSymbol = Symbol;
                                this.m_Date = new DateTime(this.m_Year, this.m_Month, i);
                                this.m_EmployeeCode = this.gbList.GetRowCellValue(j, this.colEmployeeCode).ToString();
                                this.m_ShiftCode = this.gbList.GetRowCellValue(j, this.colShiftCode).ToString();
                                this.m_PrivateHour = 0;
                                this.m_IsWork = HRM_TIMEKEEPER_SHIFT.IsWork(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date.Day);
                                this.TotalCalculate(0, 1);
                                DataRowCollection rows = this.dt_Timekeeper.Rows;
                                mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_NewSymbol, this.m_TimeIn, this.m_TimeOut, this.m_Hour, this.m_DayHour, this.m_NightHour, this.m_PrivateHour, this.m_LateMinute, this.m_EarlyMinute, this.m_IsOvertime, this.m_IsWork, 0, "" };
                                rows.Add(mTimeKeeperTableListID);
                                this.DeleteData();
                                this.SaveData();
                                if (i == ToDate)
                                {
                                    (new HRM_TIMEKEEPER_TOTAL()).Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode);
                                }
                            }
                            catch
                            {
                                goto Label0;
                            }
                            Label0:;
                        }
                        this.DoHide();
                    }
                }
                else
                {
                    for (i = FromDate; i <= ToDate; i++)
                    {
                        for (j = 0; j < this.gbList.RowCount; j++)
                        {
                            if (j % 30 == 0)
                            {
                                base.SetWaitDialogCaption(string.Concat("Đang cập nhật ngày ", i.ToString(), " dòng..", j.ToString()));
                            }
                            try
                            {
                                this.m_NewSymbol = Symbol;
                                this.m_Date = new DateTime(this.m_Year, this.m_Month, i);
                                this.m_EmployeeCode = this.gbList.GetRowCellValue(j, this.colEmployeeCode).ToString();
                                this.m_ShiftCode = this.gbList.GetRowCellValue(j, this.colShiftCode).ToString();
                                this.m_PrivateHour = 0;
                                this.m_IsWork = HRM_TIMEKEEPER_SHIFT.IsWork(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date.Day);
                                this.TotalCalculate(0, 1);
                                DataRowCollection dataRowCollection = this.dt_Timekeeper.Rows;
                                mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_NewSymbol, this.m_TimeIn, this.m_TimeOut, this.m_Hour, this.m_DayHour, this.m_NightHour, this.m_PrivateHour, this.m_LateMinute, this.m_EarlyMinute, this.m_IsOvertime, this.m_IsWork, 0, "" };
                                dataRowCollection.Add(mTimeKeeperTableListID);
                                this.DeleteData();
                                this.SaveData();
                                if (i == ToDate)
                                {
                                    (new HRM_TIMEKEEPER_TOTAL()).Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode);
                                }
                            }
                            catch
                            {
                                goto Label1;
                            }
                            Label1:;
                        }
                        this.DoHide();
                    }
                }
                this.LoadGrid(this.m_Level, this.m_Code);
            }
            catch
            {
            }
        }

        private void xucExpandCollapseButton1_ExpandCollapsed(object sender, bool IsExpand)
        {
            if (!IsExpand)
            {
                this.gbList.OptionsView.ShowGroupPanel = false;
            }
            else
            {
                this.gbList.OptionsView.ShowGroupPanel = true;
            }
        }

        private void xucTimekeeperTable_Load(object sender, EventArgs e)
        {
            this.LoadInterface();
            this.LoadSymbol();
          


        }

        public event xucTimekeeperTable.ClosedHandler Closed;

        public event xucTimekeeperTable.TimekeeperTableDeletedHandler TimekeeperTableDeleted;

        public event xucTimekeeperTable.TimekeeperTableHourSelectedHandler TimekeeperTableHourSelected;

        public event xucTimekeeperTable.TimekeeperTableInsertedHandler TimekeeperTableInserted;

        public event xucTimekeeperTable.UnShiftDataHandler UnShiftData;

        public delegate void ClosedHandler(object sender);

        public delegate void TimekeeperTableDeletedHandler(object sender);

        public delegate void TimekeeperTableHourSelectedHandler(object sender, string Code, Guid TimeKeeperTableListID, int Year, int MenuSelected);

        public delegate void TimekeeperTableInsertedHandler(object sender);

        public delegate void UnShiftDataHandler(object sender, int Month, int Year);

        private void bbiInsertSymbol_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((this.m_Month == 0 ? true : this.m_Year == 0))
            {
                XtraMessageBox.Show("Vui lòng chọn tháng chấm công tương ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                xfmInsertSymbol _xfmInsertSymbol = new xfmInsertSymbol(this.m_Month, this.m_Year);
                _xfmInsertSymbol.UnShiftData += new xfmInsertSymbol.UnShiftDataHandler(this.xfmInsertSymbol_UnShiftData);
                _xfmInsertSymbol.ShowDialog();
            }
        }

        private void bbiTimekeeperExtraPrivate_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiTimekeeperTable1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            (new clsTimeKeeperOption()
            {
                TimeKeeperTableDefault = 1
            }).SaveOption();
            this.RaiseTimekeeperTableHourSelectedHandler(this.m_Code, this.m_TimeKeeperTableListID, this.m_Year, 0);

        }

     

        private void bbeTimeKeeperTableListName_EditValueChanged(object sender, EventArgs e)
        {
            base.SetWaitDialogCaption("Đang khởi tạo dữ liệu...");
            HRM_TIMEKEEPER_TABLE hRMTIMEKEEPERTABLE = new HRM_TIMEKEEPER_TABLE();
            Guid mTimeKeeperTableListID = this.m_TimeKeeperTableListID;
            this.gcList.DataSource = hRMTIMEKEEPERTABLE.GetList(this.m_Level, this.m_Code, mTimeKeeperTableListID);
            this.gbList.BestFitColumns();
            HRM_TIMEKEEPER_TABLELIST hRMTIMEKEEPERTABLELIST = new HRM_TIMEKEEPER_TABLELIST();
            hRMTIMEKEEPERTABLELIST.GetByID(mTimeKeeperTableListID);
            this.m_Month = hRMTIMEKEEPERTABLELIST.Month;
            this.m_Year = hRMTIMEKEEPERTABLELIST.Year;
            LabelControl labelControl = this.lbTimeKeeperName;
            string[] str = new string[] { "Bảng Chấm Công Tháng ", this.m_Month.ToString(), " - ", this.m_Year.ToString(), " (Theo Ký Hiệu - Dạng 1)" };
            labelControl.Text = string.Concat(str);
            this.m_IsLock = hRMTIMEKEEPERTABLELIST.IsLock;
            this.m_IsFinish = hRMTIMEKEEPERTABLELIST.IsFinish;
            this.InitInterface();
           this.DoHide();
        }

   

        private void repTimeKeeperList_EditValueChanging_1(object sender, ChangingEventArgs e)
        {
            this.m_TimeKeeperTableListID = new Guid(e.NewValue.ToString());
        }

        private void repPopup_Popup_1(object sender, EventArgs e)
        {
            this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
            this.m_ShiftCode = this.gbList.GetFocusedRowCellValue(this.colShiftCode).ToString();
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            DataTable listByShift = hRMTIMEKEEPER.GetListByShift(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
            this.xucTimekeepingAdd.SetData(listByShift);
            this.xucTimekeepingAdd.Status = Actions.Update;
        }

        private void gcList_Click(object sender, EventArgs e)
        {

        }

        private void repTimeKeeperList_ButtonClick_1(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                xfmShiftAdd _xfmShiftAdd = new xfmShiftAdd();
                _xfmShiftAdd.UnShiftData += new xfmShiftAdd.UnShiftDataHandler((object s, int m, int y) => this.RaiseUnShiftDataHandler(m, y));
                _xfmShiftAdd.TimekeeperTableDeleted += new xfmShiftAdd.TimekeeperTableDeletedHandler((object s) => this.RaiseTimekeeperTableDeletedHander());
                _xfmShiftAdd.ShowDialog();
            }
        }

        private void bbiKyhieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            xfmSymbol xfm = new xfmSymbol();
            xfm.ShowDialog();
        }

        private void repTimeKeeperList_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void rePopup_Popup(object sender, EventArgs e)
        {
              this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
            this.m_ShiftCode = this.gbList.GetFocusedRowCellValue(this.colShiftCode).ToString();
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            DataTable listByShift = hRMTIMEKEEPER.GetListByShift(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
            this.xucTimekeepingAdd.SetData(listByShift);
            this.xucTimekeepingAdd.Status = Actions.Update;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new clsTimeKeeperOption()
            {
                TimeKeeperTableDefault = 0
            }).SaveOption();
            this.RaiseTimekeeperTableHourSelectedHandler(this.m_Code, this.m_TimeKeeperTableListID, this.m_Year, 0);

        }
    }
}
