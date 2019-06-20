using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
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
using DevExpress.XtraTab;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Dictionnary;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core.Class;
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
    public partial class xucShiftOrder : xucBase
    {

        private Guid m_TimeKeeperTableListID = Guid.Empty;

        private string m_EmployeeCode = "";

        private string m_FirstName = "";

        private string m_LastName = "";

        private string m_ShiftCode = "";

        private int m_Month = 0;

        private int m_Year = 0;

        private bool m_IsLock = false;

        private bool m_IsFinish = false;

        private int m_Level = MyLogin.Level;

        private string m_Code = MyLogin.Code;

        private bool m_IsSaveAll = false;

        private HRM_TIMEKEEPER_SHIFT l_TimeKeeperShift = new HRM_TIMEKEEPER_SHIFT();

        private HRM_TIMEKEEPER_TABLELIST l_TimeKeeperTableList = new HRM_TIMEKEEPER_TABLELIST();

        private HRM_TIMEKEEPER l_TimeKeeper = new HRM_TIMEKEEPER();

        public DataTable dt_TimekeeperShift = new DataTable();

        public DataTable dt_Employees = new DataTable();

        private clsAllOption clsAllOption = new clsAllOption();



        public xucShiftOrder()
        {
            InitializeComponent();
            DateTime monthDefault = this.clsAllOption.MonthDefault;
            this.m_Month = monthDefault.Month;
            monthDefault = this.clsAllOption.MonthDefault;
            this.m_Year = monthDefault.Year;
            base.Load += new EventHandler(this.xucShiftOrder_Load);
        }

        public xucShiftOrder(int Month, int Year)
        {
            this.InitializeComponent();

            this.m_Month = Month;
            this.m_Year = Year;
            base.Load += new EventHandler(this.xucShiftOrder_Load);
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (base.ParentForm != null)
            {
                base.ParentForm.Close();
            }
        }

        private void bbiCreate_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Create();
            this.LoadGrid(this.m_Level, this.m_Code);
        }

        private void bbiCheck_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((this.m_Month == 0 ? true : this.m_Year == 0))
            {
                XtraMessageBox.Show("Vui lòng chọn tháng chấm công tương ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                xfmShiftCheckOption _xfmShiftCheckOption = new xfmShiftCheckOption(this.m_Month, this.m_Year);
                _xfmShiftCheckOption.UnShiftData += new xfmShiftCheckOption.UnShiftDataHandler(this.xfmShiftCheckOption_UnShiftData);
                _xfmShiftCheckOption.ShowDialog();
            }
        }

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            this._exportView = this.gbList;
            // SYS_LOG.Insert("Bảng Xếp Ca", "Xuất");
            base.Export();
        }

        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            //xfmOptionPrintShiftOrder _xfmOptionPrintShiftOrder = new xfmOptionPrintShiftOrder(this.m_Level, this.m_Code, this.m_Month, this.m_Year);
            //_xfmOptionPrintShiftOrder.ShowDialog();
        }

        private void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Reload();
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Save();
        }

        private void bbiShift_ItemClick(object sender, ItemClickEventArgs e)
        {
            xfmShift _xfmShift = new xfmShift();
            _xfmShift.Added += new xfmShift.AddedEventHander((object o, DIC_SHIFT i) => {
                if (this.m_TimeKeeperTableListID != Guid.Empty)
                {
                    this.Reload();
                }
            });
            _xfmShift.Updated += new xfmShift.UpdatedEventHander((object o, DIC_SHIFT i) => {
                if (this.m_TimeKeeperTableListID != Guid.Empty)
                {
                    this.Reload();
                }
            });
            _xfmShift.Deleted += new DeletedEventHander((object o, CHBK2014_N9.Common.Class.RowClickEventArgs i) => {
                if (this.m_TimeKeeperTableListID != Guid.Empty)
                {
                    this.Reload();
                }
            });
            _xfmShift.ShowDialog();
        }

        private void btAdvanceCheck_Click(object sender, EventArgs e)
        {
            if ((this.m_Month == 0 ? true : this.m_Year == 0))
            {
                XtraMessageBox.Show("Vui lòng chọn tháng chấm công tương ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                xfmShiftCheckOption _xfmShiftCheckOption = new xfmShiftCheckOption(this.m_Month, this.m_Year);
                _xfmShiftCheckOption.UnShiftData += new xfmShiftCheckOption.UnShiftDataHandler(this.xfmShiftCheckOption_UnShiftData);
                _xfmShiftCheckOption.ShowDialog();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool flag = true;
            flag = (this.rdOption.SelectedIndex != 0 ? false : true);
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("ShiftCode");
            dataTable.Columns.Add(dataColumn);
            foreach (CheckedListBoxItem item in this.clbShift.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    DataRowCollection rows = dataTable.Rows;
                    object[] str = new object[] { item.Value.ToString() };
                    rows.Add(str);
                }
            }
            if (dataTable.Rows.Count <= 0)
            {
                XtraMessageBox.Show("Bạn phải chọn ít nhất 1 ca làm việc từ danh sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.xfmShiftCheckOption_UnShiftData(this, flag, 1, 31, 0, this.gbList.RowCount, true, true, dataTable, this.chbSaturday.Checked, this.chbSunday.Checked, this.chbHoliday.Checked);
            }




        }


        private void Create()
        {
            base.SetWaitDialogCaption("Đang khởi tạo dữ liệu...");
            if (this.l_TimeKeeperTableList.Exist(this.m_Month, this.m_Year))
            {
                this.l_TimeKeeperTableList.Get(this.m_Month, this.m_Year);
                this.m_TimeKeeperTableListID = this.l_TimeKeeperTableList.TimeKeeperTableListID;
            }
            else
            {
                this.m_TimeKeeperTableListID = Guid.NewGuid();
                this.l_TimeKeeperTableList.Insert(this.m_TimeKeeperTableListID, string.Concat("Tháng ", this.m_Month.ToString(), "-", this.m_Year.ToString()), this.m_Month, this.m_Year, false, false);
            }
            if (this.l_TimeKeeperShift.Create(this.m_Level, this.m_Code, this.m_TimeKeeperTableListID) != "OK")
            {
                this.DoHide();
            }
            else if (!(this.l_TimeKeeper.Create(this.m_Level, this.m_Code, this.m_TimeKeeperTableListID) != "OK"))
            {
                this.DoHide();
                this.RaiseSaveDataChangedHander();
            }
            else
            {
                this.DoHide();
            }
        }

        private void CreateByShift(int Month, int Year)
        {
            base.SetWaitDialogCaption("Đang khởi tạo dữ liệu...");
            this.m_TimeKeeperTableListID = Guid.NewGuid();
            this.l_TimeKeeperTableList.Insert(this.m_TimeKeeperTableListID, string.Concat("Tháng ", this.m_Month.ToString(), "-", this.m_Year.ToString()), this.m_Month, this.m_Year, false, false);
            if (!(this.l_TimeKeeperShift.CreateByShift(this.m_TimeKeeperTableListID, Month, Year) != "OK"))
            {
                this.l_TimeKeeper.Create(this.m_Level, this.m_Code, this.m_TimeKeeperTableListID);
                this.DoHide();
                this.RaiseSaveDataChangedHander();
            }
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

        private void gbList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            this.ValueChanged(e.RowHandle, this.m_ShiftCode, this.m_EmployeeCode, this.m_FirstName, this.m_LastName);

        }

        private void gbList_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column == this.colAllDay)
            {
                for (int i = 5; i <= this.gbList.Columns.Count - 1; i++)
                {
                    this.gbList.SetRowCellValue(e.RowHandle, this.gbList.Columns[i], e.Value);
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

        private void gbList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
                this.m_FirstName = this.gbList.GetFocusedRowCellValue(this.colFirstName).ToString();
                this.m_LastName = this.gbList.GetFocusedRowCellValue(this.colLastName).ToString();
                this.m_ShiftCode = this.gbList.GetFocusedRowCellValue(this.colShiftCode).ToString();
            }
            catch
            {
            }
        }


        private void GridViewLock()
        {
            int num = DateTime.DaysInMonth(this.m_Year, this.m_Month);
            this.ShowHideColumn(num);
            for (int i = 1; i <= num; i++)
            {
                this.gbList.Columns[i + 5].OptionsColumn.ReadOnly = true;
                this.gbList.Columns[i + 5].OptionsColumn.AllowEdit = false;
                DateTime dateTime = new DateTime(this.m_Year, this.m_Month, i);
                clsTimeKeeperOption _clsTimeKeeperOption = new clsTimeKeeperOption();
                if (dateTime.DayOfWeek.ToString() == "Monday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.MondayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Tuesday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.TuesdayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Wednesday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.WednesdayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Thursday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.ThursdayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Friday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.FridayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Saturday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.SaturdayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Sunday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.SundayColor;
                }
                if ((new DIC_HOLIDAY()).Exist(dateTime))
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.HolidayColor;
                }
                this.gbList.Columns[i + 5].Caption = this.DayName(this.m_Year, this.m_Month, i);
            }
        }

        private void GridViewOpen()
        {
            int num = DateTime.DaysInMonth(this.m_Year, this.m_Month);
            this.ShowHideColumn(num);
            for (int i = 1; i <= num; i++)
            {
                this.gbList.Columns[i + 5].OptionsColumn.ReadOnly = false;
                this.gbList.Columns[i + 5].OptionsColumn.AllowEdit = true;
                DateTime dateTime = new DateTime(this.m_Year, this.m_Month, i);
                clsTimeKeeperOption _clsTimeKeeperOption = new clsTimeKeeperOption();
                if (dateTime.DayOfWeek.ToString() == "Monday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.MondayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Tuesday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.TuesdayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Wednesday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.WednesdayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Thursday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.ThursdayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Friday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.FridayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Saturday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.SaturdayColor;
                }
                else if (dateTime.DayOfWeek.ToString() == "Sunday")
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.SundayColor;
                }
                if ((new DIC_HOLIDAY()).Exist(dateTime))
                {
                    this.gbList.Columns[i + 5].AppearanceCell.BackColor = _clsTimeKeeperOption.HolidayColor;
                }
                this.gbList.Columns[i + 5].Caption = this.DayName(this.m_Year, this.m_Month, i);
            }
        }

        private void Init(int Month, int Year)
        {
            this.m_Month = Month;
            this.m_Year = Year;
            DateTime dateTime = new DateTime(Year, Month, 1);
            this.bbeMonth.EditValue = dateTime;
            this.bbeYear.EditValue = dateTime;
            BarEditItem barEditItem = this.bbeShiftNamefghfghg;
            object[] month = new object[] { "Tháng ", Month, " - ", Year };
            barEditItem.EditValue = string.Concat(month);
            HRM_TIMEKEEPER_SHIFT hRMTIMEKEEPERSHIFT = new HRM_TIMEKEEPER_SHIFT();
            this.dt_TimekeeperShift = hRMTIMEKEEPERSHIFT.CreateNullDataTable();
            this.dt_Employees = hRMTIMEKEEPERSHIFT.CreateNullEmployeesDataTable();
            this.LoadShift();
            this.LoadGrid(this.m_Level, this.m_Code);
        }

        private void InitInterface()
        {
            if (!(this.m_IsLock ? true : this.m_IsFinish))
            {
                this.GridViewOpen();
            }
            else if (!(!this.m_IsLock ? true : this.m_IsFinish))
            {
                this.GridViewLock();
            }
            else if (!(this.m_IsLock ? true : !this.m_IsFinish))
            {
                this.GridViewLock();
            }
            else if ((!this.m_IsLock ? false : this.m_IsFinish))
            {
                this.GridViewLock();
            }
        }

        private bool IsExistEmployeesDataTable(DataTable Employees, string EmployeeCode)
        {
            bool flag = false;
            foreach (DataRow row in Employees.Rows)
            {
                if (row["EmployeeCode"].ToString() == EmployeeCode)
                {
                    flag = true;
                }
            }
            return flag;
        }

        private bool IsValidFilterByShift(bool IsFilterByShift, string ShiftCode, DataTable ShiftTable)
        {
            int num = 0;
            foreach (DataRow row in ShiftTable.Rows)
            {
                if (ShiftCode == row["ShiftCode"].ToString())
                {
                    num++;
                }
            }
            if (num == 0)
            {
                IsFilterByShift = false;
            }
            return IsFilterByShift;
        }

        private void LoadGrid(int Level, string Code)
        {
            if (this.l_TimeKeeperTableList.Exist(this.m_Month, this.m_Year))
            {
                this.bbiCreate.Visibility = BarItemVisibility.Never;
                this.bbiRecal.Visibility = BarItemVisibility.Always;
              //   this.pnInformation.Visible = false;
                this.l_TimeKeeperTableList.Get(this.m_Month, this.m_Year);
                this.m_IsLock = this.l_TimeKeeperTableList.IsLock;
                this.m_IsFinish = this.l_TimeKeeperTableList.IsFinish;
                this.InitInterface();
                this.m_TimeKeeperTableListID = this.l_TimeKeeperTableList.TimeKeeperTableListID;
                this.gcList.DataSource = this.l_TimeKeeperShift.GetList(Level, Code, this.m_TimeKeeperTableListID);
            }
            else
            {
                this.gcList.DataSource = null;
                xfmShiftOption _xfmShiftOption = new xfmShiftOption(this.m_Month, this.m_Year);
                _xfmShiftOption.Closed += new xfmShiftOption.ClosedHandler(this.xfmShiftOption_Closed);
                _xfmShiftOption.CreateNewDataChanged += new xfmShiftOption.CreateNewDataChangedHander(this.xfmShiftOption_CreateNewDataChanged);
                _xfmShiftOption.CreateOldDataChanged += new xfmShiftOption.CreateOldDataChangedHandler(this.xfmShiftOption_CreateOldDataChanged);
                _xfmShiftOption.ShowDialog();
            }
        }

        private void LoadOrganization()
        {
            this.xucOrganization1.LoadData();
            this.xucOrganization1.Selected += new xucOrganization.SelectedEventHander((object s, Organization o) => {
                int num;
                string str;
                HRM_GROUP hRMGROUP = new HRM_GROUP();
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                if (o.Level == 0)
                {
                    int num1 = 0;
                    num = num1;
                    this.m_Level = num1;
                    string str1 = "";
                    str = str1;
                    this.m_Code = str1;
                    this.LoadGrid(num, str);
                }
                else if (o.Level == 1)
                {
                    int num2 = 1;
                    num = num2;
                    this.m_Level = num2;
                    string subsidiaryCode = o.SubsidiaryCode;
                    str = subsidiaryCode;
                    this.m_Code = subsidiaryCode;
                    this.LoadGrid(num, str);
                }
                else if (o.Level == 2)
                {
                    int num3 = 2;
                    num = num3;
                    this.m_Level = num3;
                    string branchCode = o.BranchCode;
                    str = branchCode;
                    this.m_Code = branchCode;
                    this.LoadGrid(num, str);
                }
                else if (o.Level == 3)
                {
                    int num4 = 3;
                    num = num4;
                    this.m_Level = num4;
                    string departmentCode = o.DepartmentCode;
                    str = departmentCode;
                    this.m_Code = departmentCode;
                    this.LoadGrid(num, str);
                }
                else if (o.Level == 4)
                {
                    int num5 = 4;
                    num = num5;
                    this.m_Level = num5;
                    string groupCode = o.GroupCode;
                    str = groupCode;
                    this.m_Code = groupCode;
                    this.LoadGrid(num, str);
                }
            });
            this.xucOrganization1.Updated += new xucOrganization.UpdatedEventHander((object o) => this.xucOrganization1.LoadData());
        }

        private void LoadShift()
        {
            this.clbShift.Items.Clear();
            (new DIC_SHIFT()).AddCheckedListBox(this.clbShift);
        }

        private void RaiseSaveDataChangedHander()
        {
            if (this.SaveDataChanged != null)
            {
                this.SaveDataChanged(this);
            }
        }

        private void rdOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rdOption.SelectedIndex != 0)
            {
                this.btOK.Text = "Bỏ Chọn (<<)";
            }
            else
            {
                this.btOK.Text = "Chọn (>>)";
            }
        }


        private void Reload()
        {
            this.LoadGrid(this.m_Level, this.m_Code);
            this.LoadShift();
            this.m_IsSaveAll = false;
            this.dt_TimekeeperShift.Rows.Clear();
            this.dt_Employees.Rows.Clear();
        }

        private void repMonth_EditValueChanged(object sender, EventArgs e)
        {
            this.Init(this.m_Month, this.m_Year);
        }



        private void repMonth_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(e.NewValue.ToString());
            this.m_Month = dateTime.Month;
        }

        private void repYear_EditValueChanged(object sender, EventArgs e)
        {
            this.Init(this.m_Month, this.m_Year);
        }

        private void repYear_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(e.NewValue.ToString());
            this.m_Year = dateTime.Year;
        }

        private void Save()
        {
            string[] str;
            base.SetWaitDialogCaption("Đang lưu dữ liệu...");
            if (!this.m_IsSaveAll)
            {
                foreach (DataRow row in this.dt_TimekeeperShift.Rows)
                {
                    str = new string[] { "Đang lưu...", row["FirstName"].ToString(), " ", row["LastName"].ToString(), " (", row["EmployeeCode"].ToString(), ")" };
                    base.SetWaitDialogCaption(string.Concat(str));
                    this.l_TimeKeeperShift.Update(this.m_TimeKeeperTableListID, row["EmployeeCode"].ToString(), row["ShiftCode"].ToString(), bool.Parse(row["AllDay"].ToString()), bool.Parse(row["D1"].ToString()), bool.Parse(row["D2"].ToString()), bool.Parse(row["D3"].ToString()), bool.Parse(row["D4"].ToString()), bool.Parse(row["D5"].ToString()), bool.Parse(row["D6"].ToString()), bool.Parse(row["D7"].ToString()), bool.Parse(row["D8"].ToString()), bool.Parse(row["D9"].ToString()), bool.Parse(row["D10"].ToString()), bool.Parse(row["D11"].ToString()), bool.Parse(row["D12"].ToString()), bool.Parse(row["D13"].ToString()), bool.Parse(row["D14"].ToString()), bool.Parse(row["D15"].ToString()), bool.Parse(row["D16"].ToString()), bool.Parse(row["D17"].ToString()), bool.Parse(row["D18"].ToString()), bool.Parse(row["D19"].ToString()), bool.Parse(row["D20"].ToString()), bool.Parse(row["D21"].ToString()), bool.Parse(row["D22"].ToString()), bool.Parse(row["D23"].ToString()), bool.Parse(row["D24"].ToString()), bool.Parse(row["D25"].ToString()), bool.Parse(row["D26"].ToString()), bool.Parse(row["D27"].ToString()), bool.Parse(row["D28"].ToString()), bool.Parse(row["D29"].ToString()), bool.Parse(row["D30"].ToString()), bool.Parse(row["D31"].ToString()));
                }
                this.l_TimeKeeper.Create(this.m_TimeKeeperTableListID, this.dt_Employees);
            }
            else
            {
                for (int i = 0; i < this.gbList.RowCount; i++)
                {
                    str = new string[] { "Đang lưu...", this.gbList.GetRowCellValue(i, this.colFirstName).ToString(), " ", this.gbList.GetRowCellValue(i, this.colLastName).ToString(), " (", this.gbList.GetRowCellValue(i, this.colEmployeeCode).ToString(), ")" };
                    base.SetWaitDialogCaption(string.Concat(str));
                    this.l_TimeKeeperShift.Update(this.m_TimeKeeperTableListID, this.gbList.GetRowCellValue(i, this.colEmployeeCode).ToString(), this.gbList.GetRowCellValue(i, this.colShiftCode).ToString(), bool.Parse(this.gbList.GetRowCellValue(i, this.colAllDay).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay1).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay2).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay3).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay4).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay5).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay6).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay7).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay8).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay9).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay10).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay11).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay12).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay13).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay14).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay15).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay16).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay17).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay18).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay19).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay20).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay21).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay22).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay23).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay24).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay25).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay26).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay27).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay28).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay29).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay30).ToString()), bool.Parse(this.gbList.GetRowCellValue(i, this.colDay31).ToString()));
                    if (!this.IsExistEmployeesDataTable(this.dt_Employees, this.gbList.GetRowCellValue(i, this.colEmployeeCode).ToString()))
                    {
                        DataRowCollection rows = this.dt_Employees.Rows;
                        object[] objArray = new object[] { this.gbList.GetRowCellValue(i, this.colEmployeeCode).ToString(), this.gbList.GetRowCellValue(i, this.colFirstName).ToString(), this.gbList.GetRowCellValue(i, this.colLastName).ToString() };
                        rows.Add(objArray);
                    }
                }
                this.l_TimeKeeper.Create(this.m_TimeKeeperTableListID, this.dt_Employees);
            }
            this.m_IsSaveAll = false;
            this.dt_TimekeeperShift.Rows.Clear();
            this.dt_Employees.Rows.Clear();
            this.DoHide();
            this.RaiseSaveDataChangedHander();
        }

        private GridColumn SetColumnFromDay(int Day)
        {
            GridColumn gridColumn = new GridColumn();
            if (Day == 1)
            {
                gridColumn = this.colDay1;
            }
            else if (Day == 2)
            {
                gridColumn = this.colDay2;
            }
            else if (Day == 3)
            {
                gridColumn = this.colDay3;
            }
            else if (Day == 4)
            {
                gridColumn = this.colDay4;
            }
            else if (Day == 5)
            {
                gridColumn = this.colDay5;
            }
            else if (Day == 6)
            {
                gridColumn = this.colDay6;
            }
            else if (Day == 7)
            {
                gridColumn = this.colDay7;
            }
            else if (Day == 8)
            {
                gridColumn = this.colDay8;
            }
            else if (Day == 9)
            {
                gridColumn = this.colDay9;
            }
            else if (Day == 10)
            {
                gridColumn = this.colDay10;
            }
            else if (Day == 11)
            {
                gridColumn = this.colDay11;
            }
            else if (Day == 12)
            {
                gridColumn = this.colDay12;
            }
            else if (Day == 13)
            {
                gridColumn = this.colDay13;
            }
            else if (Day == 14)
            {
                gridColumn = this.colDay14;
            }
            else if (Day == 15)
            {
                gridColumn = this.colDay15;
            }
            else if (Day == 16)
            {
                gridColumn = this.colDay16;
            }
            else if (Day == 17)
            {
                gridColumn = this.colDay17;
            }
            else if (Day == 18)
            {
                gridColumn = this.colDay18;
            }
            else if (Day == 19)
            {
                gridColumn = this.colDay19;
            }
            else if (Day == 20)
            {
                gridColumn = this.colDay20;
            }
            else if (Day == 21)
            {
                gridColumn = this.colDay21;
            }
            else if (Day == 22)
            {
                gridColumn = this.colDay22;
            }
            else if (Day == 23)
            {
                gridColumn = this.colDay23;
            }
            else if (Day == 24)
            {
                gridColumn = this.colDay24;
            }
            else if (Day == 25)
            {
                gridColumn = this.colDay25;
            }
            else if (Day == 26)
            {
                gridColumn = this.colDay26;
            }
            else if (Day == 27)
            {
                gridColumn = this.colDay27;
            }
            else if (Day == 28)
            {
                gridColumn = this.colDay28;
            }
            else if (Day != 29)
            {
                gridColumn = (Day != 30 ? this.colDay31 : this.colDay30);
            }
            else
            {
                gridColumn = this.colDay29;
            }
            return gridColumn;
        }

        public void SetData(int Month, int Year)
        {
            this.m_Month = Month;
            this.m_Year = Year;
            this.Init(this.m_Month, this.m_Year);
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

        private void ValueChanged(int RowHandle, string ShiftCode, string EmployeeCode, string FirstName, string LastName)
        {
            if (!this.m_IsSaveAll)
            {
                DataRowCollection rows = this.dt_TimekeeperShift.Rows;
                object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, EmployeeCode, FirstName, LastName, ShiftCode, bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colAllDay).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay1).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay2).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay3).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay4).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay5).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay6).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay7).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay8).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay9).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay10).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay11).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay12).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay13).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay14).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay15).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay16).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay17).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay18).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay19).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay20).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay21).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay22).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay23).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay24).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay25).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay26).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay27).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay28).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay29).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay30).ToString()), bool.Parse(this.gbList.GetRowCellValue(RowHandle, this.colDay31).ToString()) };
                rows.Add(mTimeKeeperTableListID);
                if (!this.IsExistEmployeesDataTable(this.dt_Employees, EmployeeCode))
                {
                    DataRowCollection dataRowCollection = this.dt_Employees.Rows;
                    mTimeKeeperTableListID = new object[] { EmployeeCode, FirstName, LastName };
                    dataRowCollection.Add(mTimeKeeperTableListID);
                }
            }
        }

        private void xfmShiftCheckOption_UnShiftData(object sender, bool IsCheck, int FromDate, int ToDate, int FromRow, int ToRow, bool IsCheckAll, bool IsFilterByShift, DataTable ShiftTable, bool IsNotSaturday, bool IsNotSunday, bool IsNotHoliday)
        {
            int i;
            DateTime dateTime;
            GridColumn gridColumn;
            int j;
            try
            {
                if (!IsCheckAll)
                {
                    for (i = FromDate; i <= ToDate; i++)
                    {
                        base.SetWaitDialogCaption(string.Concat("Đang thiết lập ngày...", i.ToString()));
                        try
                        {
                            dateTime = new DateTime(this.m_Year, this.m_Month, i);
                        }
                        catch
                        {
                            goto Label0;
                        }
                        if (IsNotSaturday)
                        {
                            if (dateTime.DayOfWeek.ToString() == "Saturday")
                            {
                                goto Label0;
                            }
                        }
                        if (IsNotSunday)
                        {
                            if (dateTime.DayOfWeek.ToString() == "Sunday")
                            {
                                goto Label0;
                            }
                        }
                        if (IsNotHoliday)
                        {
                            if ((new DIC_HOLIDAY()).Exist(dateTime))
                            {
                                goto Label0;
                            }
                        }
                        gridColumn = this.SetColumnFromDay(i);
                        for (j = FromRow - 1; j <= ToRow - 1; j++)
                        {
                            if (!IsFilterByShift)
                            {
                                this.gbList.SetRowCellValue(j, gridColumn, IsCheck);
                            }
                            else if (this.IsValidFilterByShift(IsFilterByShift, this.gbList.GetRowCellValue(j, this.colShiftCode).ToString(), ShiftTable))
                            {
                                this.gbList.SetRowCellValue(j, gridColumn, IsCheck);
                            }
                            if (i == ToDate)
                            {
                                this.ValueChanged(j, this.gbList.GetRowCellValue(j, this.colShiftCode).ToString(), this.gbList.GetRowCellValue(j, this.colEmployeeCode).ToString(), this.gbList.GetRowCellValue(j, this.colFirstName).ToString(), this.gbList.GetRowCellValue(j, this.colLastName).ToString());
                            }
                        }
                        this.gcList.Refresh();
                        Label0:;
                    }
                }
                else
                {
                    for (i = FromDate; i <= ToDate; i++)
                    {
                        base.SetWaitDialogCaption(string.Concat("Đang thiết lập ngày...", i.ToString()));
                        try
                        {
                            dateTime = new DateTime(this.m_Year, this.m_Month, i);
                        }
                        catch
                        {
                            goto Label4;
                        }
                        if (IsNotSaturday)
                        {
                            if (dateTime.DayOfWeek.ToString() == "Saturday")
                            {
                                goto Label4;
                            }
                        }
                        if (IsNotSunday)
                        {
                            if (dateTime.DayOfWeek.ToString() == "Sunday")
                            {
                                goto Label4;
                            }
                        }
                        if (IsNotHoliday)
                        {
                            if ((new DIC_HOLIDAY()).Exist(dateTime))
                            {
                                goto Label4;
                            }
                        }
                        gridColumn = this.SetColumnFromDay(i);
                        for (j = 0; j < this.gbList.RowCount; j++)
                        {
                            if (!IsFilterByShift)
                            {
                                this.gbList.SetRowCellValue(j, gridColumn, IsCheck);
                            }
                            else if (this.IsValidFilterByShift(IsFilterByShift, this.gbList.GetRowCellValue(j, this.colShiftCode).ToString(), ShiftTable))
                            {
                                this.gbList.SetRowCellValue(j, gridColumn, IsCheck);
                            }
                        }
                        this.gcList.Refresh();
                        Label4:;
                    }
                    this.m_IsSaveAll = true;
                    this.dt_TimekeeperShift.Rows.Clear();
                    this.dt_Employees.Rows.Clear();
                }
                this.DoHide();
            }
            catch
            {
                this.DoHide();
            }
        }

        private void xfmShiftOption_Closed(object sender)
        {
            this.bbiCreate.Visibility = BarItemVisibility.Always;
            this.bbiRecal.Visibility = BarItemVisibility.Never;
            //   this.pnInformation.Visible = true;
        }

        private void xfmShiftOption_CreateNewDataChanged(object sender)
        {
            this.Create();
            this.LoadGrid(this.m_Level, this.m_Code);
        }

        private void xfmShiftOption_CreateOldDataChanged(object sender, int Month, int Year)
        {
            this.CreateByShift(Month, Year);
            this.LoadGrid(this.m_Level, this.m_Code);
        }
      

        public event xucShiftOrder.SaveDataChangedHander SaveDataChanged;

        public delegate void SaveDataChangedHander(object sender);

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void xucOrganization1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xucShiftOrder_Load(object sender, EventArgs e)
        {
            this.repMonth.EditValueChanging += new ChangingEventHandler(this.repMonth_EditValueChanging);
            this.repMonth.EditValueChanged += new EventHandler(this.repMonth_EditValueChanged);
            this.repYear.EditValueChanging += new ChangingEventHandler(this.repYear_EditValueChanging);
            this.repYear.EditValueChanged += new EventHandler(this.repYear_EditValueChanged);
            this.Init(this.m_Month, this.m_Year);
            this.LoadOrganization();
        }

        private void bbiSave_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Save();
        }

        private void bbiPrint_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            //xfmOptionPrintShiftOrder _xfmOptionPrintShiftOrder = new xfmOptionPrintShiftOrder(this.m_Level, this.m_Code, this.m_Month, this.m_Year);
            //_xfmOptionPrintShiftOrder.ShowDialog();
        }

        private void gbList_CustomDrawRowIndicator_1(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gbList_CellValueChanged_1(object sender, CellValueChangedEventArgs e)
        {
            this.ValueChanged(e.RowHandle, this.m_ShiftCode, this.m_EmployeeCode, this.m_FirstName, this.m_LastName);

        }

        private void gbList_CellValueChanging_1(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column == this.colAllDay)
            {
                for (int i = 5; i <= this.gbList.Columns.Count - 1; i++)
                {
                    this.gbList.SetRowCellValue(e.RowHandle, this.gbList.Columns[i], e.Value);
                }
            }
        }

        private void gbList_FocusedRowChanged_1(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
                this.m_FirstName = this.gbList.GetFocusedRowCellValue(this.colFirstName).ToString();
                this.m_LastName = this.gbList.GetFocusedRowCellValue(this.colLastName).ToString();
                this.m_ShiftCode = this.gbList.GetFocusedRowCellValue(this.colShiftCode).ToString();
            }
            catch
            {
            }
        }

        private void gcList_Click(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            bool flag = true;
            flag = (this.rdOption.SelectedIndex != 0 ? false : true);
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("ShiftCode");
            dataTable.Columns.Add(dataColumn);
            foreach (CheckedListBoxItem item in this.clbShift.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    DataRowCollection rows = dataTable.Rows;
                    object[] str = new object[] { item.Value.ToString() };
                    rows.Add(str);
                }
            }
            if (dataTable.Rows.Count <= 0)
            {
                XtraMessageBox.Show("Bạn phải chọn ít nhất 1 ca làm việc từ danh sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.xfmShiftCheckOption_UnShiftData(this, flag, 1, 31, 0, this.gbList.RowCount, true, true, dataTable, this.chbSaturday.Checked, this.chbSunday.Checked, this.chbHoliday.Checked);
            }
        }

        private void btAdvanceCheck_Click_1(object sender, EventArgs e)
        {
            if ((this.m_Month == 0 ? true : this.m_Year == 0))
            {
                XtraMessageBox.Show("Vui lòng chọn tháng chấm công tương ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                xfmShiftCheckOption _xfmShiftCheckOption = new xfmShiftCheckOption(this.m_Month, this.m_Year);
                _xfmShiftCheckOption.UnShiftData += new xfmShiftCheckOption.UnShiftDataHandler(this.xfmShiftCheckOption_UnShiftData);
                _xfmShiftCheckOption.ShowDialog();
            }
        }

        private void rdOption_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.rdOption.SelectedIndex != 0)
            {
                this.btOK.Text = "Bỏ Chọn (<<)";
            }
            else
            {
                this.btOK.Text = "Chọn (>>)";
            }
        }

        private void bbiRecal_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Save();
            this.Create();
            this.LoadGrid(this.m_Level, this.m_Code);
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Reload();
        }

        private void bbiCheck_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if ((this.m_Month == 0 ? true : this.m_Year == 0))
            {
                XtraMessageBox.Show("Vui lòng chọn tháng chấm công tương ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                xfmShiftCheckOption _xfmShiftCheckOption = new xfmShiftCheckOption(this.m_Month, this.m_Year);
                _xfmShiftCheckOption.UnShiftData += new xfmShiftCheckOption.UnShiftDataHandler(this.xfmShiftCheckOption_UnShiftData);
                _xfmShiftCheckOption.ShowDialog();
            }


        }

        private void bbiClose_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (base.ParentForm != null)
            {
                base.ParentForm.Close();
            }
        }

        private void bbiCreat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Create();
            this.LoadGrid(this.m_Level, this.m_Code);
        }

        private void bbiExport_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this._exportView = this.gbList;
           // SYS_LOG.Insert("Bảng Xếp Ca", "Xuất");
            base.Export();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new xfmHoliday()).ShowDialog();
        }

        private void bbiShift_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            xfmShift _xfmShift = new xfmShift();
            _xfmShift.Added += new xfmShift.AddedEventHander((object o, DIC_SHIFT i) => {
                if (this.m_TimeKeeperTableListID != Guid.Empty)
                {
                    this.Reload();
                }
            });
            _xfmShift.Updated += new xfmShift.UpdatedEventHander((object o, DIC_SHIFT i) => {
                if (this.m_TimeKeeperTableListID != Guid.Empty)
                {
                    this.Reload();
                }
            });
            _xfmShift.Deleted += new DeletedEventHander((object o,  CHBK2014_N9.Common.Class. RowClickEventArgs i) => {
                if (this.m_TimeKeeperTableListID != Guid.Empty)
                {
                    this.Reload();
                }
            });
            _xfmShift.ShowDialog();
        }
    }
}
