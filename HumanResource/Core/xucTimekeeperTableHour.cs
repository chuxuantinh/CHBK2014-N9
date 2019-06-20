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
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core.Class;
using CHBK2014_N9.HumanResource.Report;
using Perfect.Utils;
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
    public partial class xucTimekeeperTableHour : xucBase
    {

        private Guid m_TimeKeeperTableListID = Guid.Empty;

        private string m_CompanyName = "";

        private bool m_IsLock = false;

        private bool m_IsFinish = false;

        private int m_Month = 0;

        private int m_Year = 0;

        private string m_EmployeeCode = "";

        private string m_ShiftCode = "";

        private DateTime m_Date;

        private DateTime m_TimeIn;

        private DateTime m_TimeOut;

        private string m_Symbol = "";

        private double m_Hour = 0;

        private double m_OldHour = 0;

        private double m_DayHour = 0;

        private double m_NightHour = 0;

        private int m_LateMinute = 0;

        private int m_EarlyMinute = 0;

        private bool m_IsOvertime = false;

        private bool m_IsWork = true;

        private int m_Level = MyLogin.Level;

        private string m_Code = MyLogin.Code;

        private clsAllOption clsAllOption = new clsAllOption();

        private bool m_IsEditValueChanged = true;

        private bool m_IsSetRowCellValue = true;

        public DataTable dt_Timekeeper = new DataTable();

        private xucTimekeepingAdd xucTimekeepingAdd = new xucTimekeepingAdd();

      //  private PopupContainerControl ppContainerControl = new PopupContainerControl();

        private double x_TotalHour = 0;

        private string x_OEmployeeCode;
        public xucTimekeeperTableHour()
        {
            InitializeComponent();
            base.RestoreLayout(this.gbList, this);
            this.Init();
        }

        private void bbeTimeKeeperTableListName_EditValueChanged(object sender, EventArgs e)
        {
            HRM_TIMEKEEPER_TABLELIST hRMTIMEKEEPERTABLELIST = new HRM_TIMEKEEPER_TABLELIST();
            HRM_TIMEKEEPER_TABLEHOUR hRMTIMEKEEPERTABLEHOUR = new HRM_TIMEKEEPER_TABLEHOUR();
            Guid mTimeKeeperTableListID = this.m_TimeKeeperTableListID;
            this.gcList.DataSource = hRMTIMEKEEPERTABLEHOUR.GetList(this.m_Level, this.m_Code, mTimeKeeperTableListID);
            hRMTIMEKEEPERTABLELIST.GetByID(mTimeKeeperTableListID);
            this.m_Month = hRMTIMEKEEPERTABLELIST.Month;
            this.m_Year = hRMTIMEKEEPERTABLELIST.Year;
            LabelControl labelControl = this.lbTimeKeeperOverTimeName;
            string[] str = new string[] { "Bảng Chấm Công Tháng ", this.m_Month.ToString(), " - ", this.m_Year.ToString(), " (Theo Giờ Công)" };
            labelControl.Text = string.Concat(str);
            this.m_IsLock = hRMTIMEKEEPERTABLELIST.IsLock;
            this.m_IsFinish = hRMTIMEKEEPERTABLELIST.IsFinish;
            this.InitInterface();
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
          //  SYS_LOG.Insert("Bảng Chấm Công Tháng Theo Giờ", "Xuất");
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
         //   xfmOptionPrintTimekeeperTable _xfmOptionPrintTimekeeperTable = new xfmOptionPrintTimekeeperTable(this.m_Level, this.m_Code, this.m_Month, this.m_Year, 2);
           // _xfmOptionPrintTimekeeperTable.ShowDialog();
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

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new clsTimeKeeperOption()
            {
                TimeKeeperTableDefault = 3
            }).SaveOption();
            this.RaiseTimekeeperTableSelectedHandler(this.m_Code, this.m_TimeKeeperTableListID, this.m_Year, 2);

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new clsTimeKeeperOption()
            {
                TimeKeeperTableDefault = 0
            }).SaveOption();
            this.RaiseTimekeeperTableSelectedHandler(this.m_Code, this.m_TimeKeeperTableListID, this.m_Year, 0);

        }

        private void btSymbolEdit_ItemClick(object sender, ItemClickEventArgs e)
        {



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

        private void gbList_CellMerge(object sender, CellMergeEventArgs e)
        {
            if (e.Column == this.gbList.Columns["TotalHour"])
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
            if (e.Column != this.colTotalHour)
            {
                this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
                this.m_ShiftCode = this.gbList.GetFocusedRowCellValue(this.colShiftCode).ToString();
                if (this.m_IsEditValueChanged)
                {
                    try
                    {
                        this.m_Hour = Convert.ToDouble(e.Value.ToString());
                    }
                    catch
                    {
                        this.m_Hour = 0;
                        this.gbList.SetFocusedValue(0);
                    }
                    if (this.m_Hour > 24)
                    {
                        XtraMessageBox.Show("Dữ liệu bạn nhập vào quá lớn!");
                        this.m_Hour = 0;
                        this.gbList.SetFocusedValue(0);
                    }
                    if (this.m_Hour < 0)
                    {
                        this.m_Hour = 0;
                        this.gbList.SetFocusedValue(0);
                    }
                    this.m_Symbol = "+";
                    this.m_IsWork = HRM_TIMEKEEPER_SHIFT.IsWork(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date.Day);
                    double mHour = this.m_Hour * 60;
                    int num = int.Parse(mHour.ToString());
                    DIC_SHIFT dICSHIFT = new DIC_SHIFT();
                    dICSHIFT.Get(this.m_ShiftCode);
                    int year = this.m_Date.Year;
                    int month = this.m_Date.Month;
                    int day = this.m_Date.Day;
                    int hour = dICSHIFT.BeginTime.Hour;
                    int minute = dICSHIFT.BeginTime.Minute;
                    DateTime beginTime = dICSHIFT.BeginTime;
                    DateTime dateTime = new DateTime(year, month, day, hour, minute, beginTime.Second);
                    int year1 = this.m_Date.Year;
                    int month1 = this.m_Date.Month;
                    int day1 = this.m_Date.Day;
                    int hour1 = dICSHIFT.EndTime.Hour;
                    int minute1 = dICSHIFT.EndTime.Minute;
                    beginTime = dICSHIFT.EndTime;
                    DateTime dateTime1 = new DateTime(year1, month1, day1, hour1, minute1, beginTime.Second);
                    this.m_TimeIn = dateTime;
                    HRM_TIMEKEEPER_BREAK hRMTIMEKEEPERBREAK = new HRM_TIMEKEEPER_BREAK();
                    double num1 = hRMTIMEKEEPERBREAK.TotalBreakHour(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
                    mHour = num1 * 60;
                    this.m_TimeOut = MyDateTime.AddMinute(this.m_TimeIn, num + int.Parse(mHour.ToString()));
                    HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
                    hRMTIMEKEEPER.Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Symbol, this.m_Date, this.m_TimeIn, this.m_TimeOut);
                    this.m_TimeIn = hRMTIMEKEEPER.TimeIn;
                    this.m_TimeOut = hRMTIMEKEEPER.TimeOut;
                    this.m_Hour = hRMTIMEKEEPER.Hour;
                    this.m_DayHour = hRMTIMEKEEPER.DayHour;
                    this.m_NightHour = hRMTIMEKEEPER.NightHour;
                    this.m_LateMinute = hRMTIMEKEEPER.LateMinute;
                    this.m_EarlyMinute = hRMTIMEKEEPER.EarlyMinute;
                    DataRowCollection rows = this.dt_Timekeeper.Rows;
                    object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_Symbol, this.m_TimeIn, this.m_TimeOut, this.m_Hour, this.m_DayHour, this.m_NightHour, 0, this.m_LateMinute, this.m_EarlyMinute, this.m_IsOvertime, this.m_IsWork, 0, "" };
                    rows.Add(mTimeKeeperTableListID);
                    this.SaveData();
                    if (this.m_IsSetRowCellValue)
                    {
                        this.SetRowCellValue(e.RowHandle, this.m_EmployeeCode);
                    }
                    else
                    {
                        this.m_IsSetRowCellValue = true;
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
                this.x_TotalHour = 0;
            }
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                string str = this.gbList.GetRowCellValue(e.RowHandle, "EmployeeCode").ToString();
                if (str != this.x_OEmployeeCode)
                {
                    if (num == 0)
                    {
                        this.x_TotalHour += Convert.ToDouble(e.FieldValue);
                    }
                }
                this.x_OEmployeeCode = str;
            }
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                if (num == 0)
                {
                    e.TotalValue = this.x_TotalHour;
                }
            }
        }

        private void gbList_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            try
            {
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
                this.m_OldHour = double.Parse(this.gbList.GetFocusedValue().ToString());
            }
            catch
            {
            }
        }

        private void gbList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.m_OldHour = double.Parse(this.gbList.GetFocusedValue().ToString());
            }
            catch
            {
            }
        }

        private void gbList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                base.DoShowMenu(this.gbList.CalcHitInfo(new Point(e.X, e.Y)), this.gbList, this);
            }
        }


        private void GridViewLock()
        {
            int num = DateTime.DaysInMonth(this.m_Year, this.m_Month);
            this.ShowHideColumn(num);
            for (int i = 1; i <= num; i++)
            {
                this.gbList.Columns[i + 4].OptionsColumn.ReadOnly = true;
                this.gbList.Columns[i + 8].OptionsColumn.AllowEdit = false;
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

        private void GridViewOpen()
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

        private void Init()
        {
            HRM_ORGANIZATION.SetToTwoLabel(MyLogin.Level, MyLogin.Code, this.lbMainName, this.lbSubName);
            this.bbeYear.EditValue = this.clsAllOption.MonthDefault;
            this.m_Year = this.clsAllOption.MonthDefault.Year;
            this.xucOrganization1.LoadData();
            this.xucOrganization1.Selected += new xucOrganization.SelectedEventHander((object s, Organization o) => {
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
            this.xucTimekeepingAdd.Success += new xucTimekeepingAdd.SuccessEventHander((object s, HRM_TIMEKEEPER i) => {
                this.m_IsEditValueChanged = false;
                this.gbList.SetFocusedValue(i.Hour);
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
                this.lbMessage.Text = "Đã hoàn thành bảng chấm công của tháng này - Không được phép chỉnh sửa";
                this.GridViewLock();
            }
        }

        public void LoadGrid(int Level, string Code)
        {
            try
            {
                Guid mTimeKeeperTableListID = this.m_TimeKeeperTableListID;
                HRM_TIMEKEEPER_TABLEHOUR hRMTIMEKEEPERTABLEHOUR = new HRM_TIMEKEEPER_TABLEHOUR();
                this.gcList.DataSource = hRMTIMEKEEPERTABLEHOUR.GetList(Level, Code, mTimeKeeperTableListID);
            }
            catch
            {
            }
        }

        public void LoadTimeKeeperTableList()
        {
            (new HRM_TIMEKEEPER_TABLELIST()).AddRepositoryGridLookupEditByYear(this.repTimeKeeperList, this.m_Year);
            this.LoadGrid(this.m_Level, this.m_Code);
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
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

        private void RaiseTimekeeperTableInsertedHander()
        {
            if (this.TimekeeperTableInserted != null)
            {
                this.TimekeeperTableInserted(this);
            }
        }

        private void RaiseTimekeeperTableSelectedHandler(string Code, Guid TimeKeeperTableListID, int Year, int MenuSelected)
        {
            if (this.TimekeeperTableSelected != null)
            {
                this.TimekeeperTableSelected(this, Code, TimeKeeperTableListID, Year, MenuSelected);
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

        private void SetRowCellValue(int RowHandle, string EmployeeCode)
        {
            HRM_TIMEKEEPER_TOTAL hRMTIMEKEEPERTOTAL = new HRM_TIMEKEEPER_TOTAL();
            hRMTIMEKEEPERTOTAL.Get(this.m_TimeKeeperTableListID, EmployeeCode);
            string employeeCode = EmployeeCode;
            int rowHandle = RowHandle;
            while (EmployeeCode == employeeCode)
            {
                this.gbList.SetRowCellValue(rowHandle, this.colTotalHour, hRMTIMEKEEPERTOTAL.TotalHour);
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
                this.gbList.SetRowCellValue(rowHandle, this.colTotalHour, hRMTIMEKEEPERTOTAL.TotalHour);
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

        public event xucTimekeeperTableHour.ClosedHandler Closed;

        public event xucTimekeeperTableHour.TimekeeperTableDeletedHandler TimekeeperTableDeleted;

        public event xucTimekeeperTableHour.TimekeeperTableInsertedHandler TimekeeperTableInserted;

        public event xucTimekeeperTableHour.TimekeeperTableSelectedHandler TimekeeperTableSelected;

        public event xucTimekeeperTableHour.UnShiftDataHandler UnShiftData;

        public delegate void ClosedHandler(object sender);

        public delegate void TimekeeperTableDeletedHandler(object sender);

        public delegate void TimekeeperTableInsertedHandler(object sender);

        public delegate void TimekeeperTableSelectedHandler(object sender, string Code, Guid TimeKeeperTableListID, int Year, int MenuSelected);

        public delegate void UnShiftDataHandler(object sender, int Month, int Year);
    }
}
