using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using Microsoft.VisualBasic;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
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
    public partial class xucTimekeepingAdd : xucBaseAddH
    {

        private Guid m_TimeKeeperTableListID;

        private string m_EmployeeCode;

        private string m_ShiftCode;

        private DateTime m_Date;

        private string m_Symbol;

        private bool m_IsOverTime;

        private bool m_IsWork;

        private int m_Sorted;

        private int m_Length;

        private bool m_IsFirstLoad = true;

        private DataTable dt_Shift = new DataTable();

        private int m_ShiftIndex = 0;

        private int m_ShiftTotal = 0;
        public xucTimekeepingAdd()
        {
            InitializeComponent();
        }


        protected override void Add()
        {
            base.Add();
        }

        private void bbiTimekeepingBreak_Click(object sender, EventArgs e)
        {
            //xfmTimekeepingBreak _xfmTimekeepingBreak = new xfmTimekeepingBreak(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
            //_xfmTimekeepingBreak.Updated += new xfmTimekeepingBreak.UpdatedEventHander((object s, HRM_TIMEKEEPER_BREAK i) => {
            //    this.CalculateHour();
            //    this.uc_Update();
            //});
            //_xfmTimekeepingBreak.Added += new xfmTimekeepingBreak.AddedEventHander((object s, HRM_TIMEKEEPER_BREAK i) => {
            //    this.CalculateHour();
            //    this.uc_Update();
            //});
            //_xfmTimekeepingBreak.Deleted += new DeletedEventHander((object s, RowClickEventArgs i) => {
            //    this.CalculateHour();
            //    this.uc_Update();
            //});
            //_xfmTimekeepingBreak.ShowDialog();
        }

        private void bbiTimekeepingExtra_Click(object sender, EventArgs e)
        {
            //xfmTimekeepingExtra _xfmTimekeepingExtra = new xfmTimekeepingExtra(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
            //_xfmTimekeepingExtra.Updated += new xfmTimekeepingExtra.UpdatedEventHander((object s, HRM_TIMEKEEPER_EXTRA i) => {
            //    this.CalculateHour();
            //    this.uc_Update();
            //});
            //_xfmTimekeepingExtra.Added += new xfmTimekeepingExtra.AddedEventHander((object s, HRM_TIMEKEEPER_EXTRA i) => {
            //    this.CalculateHour();
            //    this.uc_Update();
            //});
            //_xfmTimekeepingExtra.Deleted += new DeletedEventHander((object s, RowClickEventArgs i) => {
            //    this.CalculateHour();
            //    this.uc_Update();
            //});
            //_xfmTimekeepingExtra.ShowDialog();
        }

        private void bbiTimekeepingPrivate_Click(object sender, EventArgs e)
        {
            //xfmTimekeepingPrivate _xfmTimekeepingPrivate = new xfmTimekeepingPrivate(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
            //_xfmTimekeepingPrivate.Updated += new xfmTimekeepingPrivate.UpdatedEventHander((object s, HRM_TIMEKEEPER_PRIVATE i) => {
            //    this.CalculateHour();
            //    this.uc_Update();
            //});
            //_xfmTimekeepingPrivate.Added += new xfmTimekeepingPrivate.AddedEventHander((object s, HRM_TIMEKEEPER_PRIVATE i) => {
            //    this.CalculateHour();
            //    this.uc_Update();
            //});
            //_xfmTimekeepingPrivate.Deleted += new DeletedEventHander((object s, RowClickEventArgs i) => {
            //    this.CalculateHour();
            //    this.uc_Update();
            //});
            //_xfmTimekeepingPrivate.ShowDialog();
        }

        private void btShiftNext_Click(object sender, EventArgs e)
        {
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            if (this.m_ShiftIndex + 1 <= this.m_ShiftTotal)
            {
                this.m_ShiftIndex++;
            }
            else
            {
                this.m_ShiftIndex = 1;
            }
            DataTable listByShift = hRMTIMEKEEPER.GetListByShift(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.dt_Shift.Rows[this.m_ShiftIndex - 1]["ShiftCode"].ToString(), this.m_Date);
            this.SetData(listByShift);
        }

        private void btShiftBack_Click(object sender, EventArgs e)
        {
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            if (this.m_ShiftIndex - 1 >= 1)
            {
                this.m_ShiftIndex--;
            }
            else
            {
                this.m_ShiftIndex = this.m_ShiftTotal;
            }
            DataTable listByShift = hRMTIMEKEEPER.GetListByShift(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.dt_Shift.Rows[this.m_ShiftIndex - 1]["ShiftCode"].ToString(), this.m_Date);
            this.SetData(listByShift);
        }

        private void CalculateHour()
        {
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            hRMTIMEKEEPER.Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Symbol, this.m_Date, Convert.ToDateTime(this.teTimeIn.EditValue.ToString()), Convert.ToDateTime(this.teTimeOut.EditValue.ToString()), this.m_Sorted, this.m_Length);
            this.calHour.EditValue = hRMTIMEKEEPER.Hour;
            this.calDayHour.EditValue = hRMTIMEKEEPER.DayHour;
            this.calNightHour.EditValue = hRMTIMEKEEPER.NightHour;
            this.calLateMinute.EditValue = hRMTIMEKEEPER.LateMinute;
            this.calEarlyMinute.EditValue = hRMTIMEKEEPER.EarlyMinute;
        }



        protected override void Init()
        {
            base.Init();
        }

        private HRM_TIMEKEEPER InitClass()
        {
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER()
            {
                TimeKeeperTableListID = this.m_TimeKeeperTableListID,
                EmployeeCode = this.m_EmployeeCode,
                ShiftCode = this.m_ShiftCode,
                Date = this.m_Date,
                Symbol = this.m_Symbol,
                TimeIn = Convert.ToDateTime(this.teTimeIn.EditValue.ToString()),
                TimeOut = Convert.ToDateTime(this.teTimeOut.EditValue.ToString()),
                Hour = Convert.ToDouble(this.calHour.EditValue.ToString()),
                DayHour = Convert.ToDouble(this.calDayHour.EditValue.ToString()),
                NightHour = Convert.ToDouble(this.calNightHour.EditValue.ToString()),
                LateMinute = Convert.ToInt32(this.calLateMinute.EditValue.ToString()),
                EarlyMinute = Convert.ToInt32(this.calEarlyMinute.EditValue.ToString()),
                IsOverTime = this.m_IsOverTime,
                IsWork = this.m_IsWork,
                Sorted = this.m_Sorted,
                Description = this.txtDescription.Text
            };
            return hRMTIMEKEEPER;
        }



        private void InitSortedButtonData(DataTable Table)
        {
            this.flowLayoutPanel1.Controls.Clear();
            int num = 1;
            foreach (DataRow row in Table.Rows)
            {
                SimpleButton simpleButton = new SimpleButton()
                {
                    Text = row["Symbol"].ToString(),
                    Height = 21,
                    Width = 32
                };
                simpleButton.Click += new EventHandler(this.spButton_Click);
                this.flowLayoutPanel1.Controls.Add(simpleButton);
                if (num == Table.Rows.Count)
                {
                    this.SetData(row);
                }
                num++;
            }
            this.m_Length = num - 1;
            this.flowLayoutPanel1.Visible = true;
            this.txtDescription.Height = 38;
            if (Table.Rows.Count == 1)
            {
                this.flowLayoutPanel1.Visible = false;
                this.txtDescription.Height = 58;
            }
        }

        private void RaiseSuccessEventHander(HRM_TIMEKEEPER item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(HRM_TIMEKEEPER item)
        {
         //   SYS_LOG.Insert("Giờ Làm Việc", "Xem", item.ShiftCode.ToString());
            this.m_TimeKeeperTableListID = item.TimeKeeperTableListID;
            this.m_EmployeeCode = item.EmployeeCode;
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(this.m_EmployeeCode);
            GroupControl groupControl = this.groupControl1;
            string[] firstName = new string[] { "Thông Tin Ra/Vào - ", hRMEMPLOYEE.FirstName, " ", hRMEMPLOYEE.LastName, " (", hRMEMPLOYEE.EmployeeCode, ") - ", item.Symbol };
            groupControl.Text = string.Concat(firstName);
            this.m_ShiftCode = item.ShiftCode;
            this.m_Date = item.Date;
            this.m_Symbol = item.Symbol;
            DIC_SHIFT dICSHIFT = new DIC_SHIFT();
            dICSHIFT.Get(this.m_ShiftCode);
            this.txtShift.Text = dICSHIFT.ShiftName;
            this.dtDate.DateTime = item.Date;
            this.txtSymbol.Text = item.Symbol;
            this.m_IsFirstLoad = true;
            this.teTimeIn.EditValue = item.TimeIn;
            this.m_IsFirstLoad = true;
            this.teTimeOut.EditValue = item.TimeOut;
            this.calHour.EditValue = item.Hour;
            this.calDayHour.EditValue = item.DayHour;
            this.calNightHour.EditValue = item.NightHour;
            this.calLateMinute.EditValue = item.LateMinute;
            this.calEarlyMinute.EditValue = item.EarlyMinute;
            this.m_IsOverTime = item.IsOverTime;
            this.m_IsWork = item.IsWork;
            this.m_Sorted = item.Sorted;
            this.txtDescription.Text = item.Description;
            HRM_TIMEKEEPER_BREAK hRMTIMEKEEPERBREAK = new HRM_TIMEKEEPER_BREAK();
            double num = hRMTIMEKEEPERBREAK.TotalBreakHour(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
            this.bbiTimekeepingBreak.Text = string.Concat("(", num.ToString(), "h)");
            if (num <= 0)
            {
                this.bbiTimekeepingBreak.ButtonStyle = BorderStyles.Simple;
            }
            else
            {
                this.bbiTimekeepingBreak.ButtonStyle = BorderStyles.Office2003;
                HRM_TIMEKEEPER_EXTRA hRMTIMEKEEPEREXTRA = new HRM_TIMEKEEPER_EXTRA();
                double num1 = hRMTIMEKEEPEREXTRA.TotalExtraHour(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
                this.bbiTimekeepingExtra.Text = string.Concat("(", num1.ToString(), "h)");
                if (num1 <= 0)
                {
                    this.bbiTimekeepingExtra.ButtonStyle = BorderStyles.Simple;
                }
                else
                {
                    this.bbiTimekeepingExtra.ButtonStyle = BorderStyles.Office2003;
                }
                HRM_TIMEKEEPER_PRIVATE hRMTIMEKEEPERPRIVATE = new HRM_TIMEKEEPER_PRIVATE();
                double num2 = hRMTIMEKEEPERPRIVATE.TotalPrivateHour(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date);
                this.bbiTimekeepingPrivate.Text = string.Concat("(", num2.ToString(), "h)");
                if (num2 <= 0)
                {
                    this.bbiTimekeepingPrivate.ButtonStyle = BorderStyles.Simple;
                }
                else
                {
                    this.bbiTimekeepingPrivate.ButtonStyle = BorderStyles.Office2003;
                }
            }
        }


        public void SetData(DataRow dr)
        {
            this.m_TimeKeeperTableListID = new Guid(dr["TimeKeeperTableListID"].ToString());
            this.m_EmployeeCode = dr["EmployeeCode"].ToString();
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(this.m_EmployeeCode);
            GroupControl groupControl = this.groupControl1;
            string[] firstName = new string[] { "Thông Tin Ra/Vào - ", hRMEMPLOYEE.FirstName, " ", hRMEMPLOYEE.LastName, " (", hRMEMPLOYEE.EmployeeCode, ") - ", dr["Symbol"].ToString() };
            groupControl.Text = string.Concat(firstName);
            this.m_ShiftCode = dr["ShiftCode"].ToString();
            this.m_Date = Convert.ToDateTime(dr["Date"].ToString());
            this.m_Symbol = dr["Symbol"].ToString();
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            hRMTIMEKEEPER.Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_Symbol);
            this.SetData(hRMTIMEKEEPER);
        }

        public void SetData(DataTable Table)
        {
            this.InitSortedButtonData(Table);
        }

        public void SetData(Guid TimeKeeperTableListID, string EmployeeCode, DateTime Date)
        {
            DataTable listByShift;
            HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
            this.dt_Shift = hRMTIMEKEEPER.GetListByDate1(EmployeeCode, Date);
            if (this.dt_Shift.Rows.Count > 1)
            {
                this.btShiftBack.Enabled = true;
                this.btShiftNext.Enabled = true;
                this.bbiTimekeepingBreak.Enabled = true;
                this.btnSave.Enabled = true;
            }
            else if (this.dt_Shift.Rows.Count != 1)
            {
                if (this.dt_Shift.Rows.Count >= 1)
                {
                    this.m_ShiftIndex = 1;
                    this.m_ShiftTotal = this.dt_Shift.Rows.Count;
                    listByShift = hRMTIMEKEEPER.GetListByShift(TimeKeeperTableListID, EmployeeCode, this.dt_Shift.Rows[this.m_ShiftIndex - 1]["ShiftCode"].ToString(), Date);
                    this.SetData(listByShift);
                    return;
                }
                this.btShiftBack.Enabled = false;
                this.btShiftNext.Enabled = false;
                this.bbiTimekeepingBreak.Enabled = false;
                this.btnSave.Enabled = false;
                this.txtShift.Text = "";
                this.dtDate.DateTime = DateTime.Now;
                this.teTimeIn.EditValue = DateTime.Now;
                this.teTimeOut.EditValue = DateTime.Now;
                this.calHour.EditValue = 0;
                this.calNightHour.EditValue = 0;
                this.calDayHour.EditValue = 0;
                this.txtSymbol.Text = "";
                this.calLateMinute.EditValue = 0;
                this.calEarlyMinute.EditValue = "";
                this.txtDescription.Text = "";
                return;
            }
            else
            {
                this.btShiftBack.Enabled = false;
                this.btShiftNext.Enabled = false;
                this.bbiTimekeepingBreak.Enabled = true;
                this.btnSave.Enabled = true;
            }
            this.m_ShiftIndex = 1;
            this.m_ShiftTotal = this.dt_Shift.Rows.Count;
            listByShift = hRMTIMEKEEPER.GetListByShift(TimeKeeperTableListID, EmployeeCode, this.dt_Shift.Rows[this.m_ShiftIndex - 1]["ShiftCode"].ToString(), Date);
            this.SetData(listByShift);
        }



        private void spButton_Click(object sender, EventArgs e)
        {
            try
            {
                HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
                hRMTIMEKEEPER.Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, (sender as SimpleButton).Text);
                this.SetData(hRMTIMEKEEPER);
            }
            catch
            {
            }
        }

        private void teTimeIn_ParseEditValue(object sender, ConvertEditValueEventArgs e)
        {
            if (this.m_IsFirstLoad)
            {
                this.m_IsFirstLoad = false;
            }
            else
            {
                this.CalculateHour();
            }
        }



        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            HRM_TIMEKEEPER hRMTIMEKEEPER = this.InitClass();
            string str = hRMTIMEKEEPER.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(hRMTIMEKEEPER);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
          //  SYS_LOG.Insert("Giờ Làm Việc Làm Việc", "Thêm", "");
            long num = DateAndTime.DateDiff(DateInterval.Hour, Convert.ToDateTime(this.teTimeIn.EditValue.ToString()), Convert.ToDateTime(this.teTimeOut.EditValue.ToString()), FirstDayOfWeek.System, FirstWeekOfYear.System);
            if ((num < (long)0 ? false : num <= (long)24))
            {
                HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
                HRM_TIMEKEEPER hRMTIMEKEEPER1 = this.InitClass();
                hRMTIMEKEEPER = hRMTIMEKEEPER1;
                if (hRMTIMEKEEPER1 != null)
                {
                    base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                    string str1 = hRMTIMEKEEPER.Insert();
                    if (str1 == "OK")
                    {
                        this.RaiseSuccessEventHander(hRMTIMEKEEPER);
                        (new HRM_TIMEKEEPER_TOTAL()).Get(this.m_TimeKeeperTableListID, this.m_EmployeeCode);
                    }
                    Cursor.Current = Cursors.Default;
                    if (str1 != "OK")
                    {
                        XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.DoHide();
                    str = str1;
                }
                else
                {
                    str = "FALSE";
                }
            }
            else
            {
                XtraMessageBox.Show("Số giờ không được bé hơn 0 hoặc lớn hơn 24!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            // SYSYS_LOGS_LOG.Insert("Giờ Làm Việc", "Cập Nhật", this.m_EmployeeCode.ToString());
            long num = DateAndTime.DateDiff(DateInterval.Hour, Convert.ToDateTime(this.teTimeIn.EditValue.ToString()), Convert.ToDateTime(this.teTimeOut.EditValue.ToString()), FirstDayOfWeek.System, FirstWeekOfYear.System);
            if ((num < (long)0 ? false : num <= (long)24))
            {
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                HRM_TIMEKEEPER hRMTIMEKEEPER = new HRM_TIMEKEEPER();
                hRMTIMEKEEPER = this.InitClass();
                string str1 = hRMTIMEKEEPER.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMTIMEKEEPER);
                }
                if (str1 != "OK")
                {
                    XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.DoHide();
                str = str1;
            }
            else
            {
                XtraMessageBox.Show("Số giờ không được bé hơn 0 hoặc lớn hơn 24!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                str = "";
            }
            return str;
        }

        public event xucTimekeepingAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, HRM_TIMEKEEPER item);

        private void xucTimekeepingAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
