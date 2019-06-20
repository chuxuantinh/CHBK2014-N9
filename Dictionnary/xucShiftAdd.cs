using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using Microsoft.VisualBasic;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace CHBK2014_N9.Dictionnary
{
    public partial class xucShiftAdd : xucBaseAdd
    {
       
        public xucShiftAdd()
        {
            InitializeComponent();
        }

        protected override void Add()
        {
            base.Add();
            DIC_SHIFT dICSHIFT = new DIC_SHIFT();
            this.txtID.Text = dICSHIFT.NewID();
            this.txtNAME.Focus();
        }

        private void CalculatorMinute()
        {
            //DateTime dateTime = Convert.ToDateTime(this.teBeginTime.EditValue.ToString());
            //DateTime dateTime1 = Convert.ToDateTime(this.teEndTime.EditValue.ToString());
            //if (this.cheIsOvernight.Checked)
            //{
            //    dateTime1 = DateAndTime.DateAdd(DateInterval.Day, 1, dateTime1);
            //}
            //double num = MyDateTime.NumberHour(dateTime, dateTime1);
            //int num1 = MyDateTime.NumberMinute(dateTime, dateTime1);
            //if (this.cheIsBreak.Checked)
            //{
            //    DateTime dateTime2 = Convert.ToDateTime(this.teBreakBeginTime.EditValue.ToString());
            //    DateTime dateTime3 = Convert.ToDateTime(this.teBreakEndTime.EditValue.ToString());
            //    if (this.cheIsBreakOvernight.Checked)
            //    {
            //        dateTime3 = DateAndTime.DateAdd(DateInterval.Day, 1, dateTime2);
            //    }
            //    double num2 = MyDateTime.NumberHour(dateTime2, dateTime3);
            //    int num3 = MyDateTime.NumberMinute(dateTime2, dateTime3);
            //    num -= num2;
            //    num1 -= num3;
            //}
            //this.calTotalHour.EditValue = num;
            //this.calTotalMinute.EditValue = num1;
        }

        private void cboMethodCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboMethodCheck.SelectedIndex == 0)
            {
                this.gbBOT.Enabled = true;
                this.gbAOT.Enabled = false;
            }
            else if (this.cboMethodCheck.SelectedIndex != 1)
            {
                this.gbBOT.Enabled = true;
                this.gbAOT.Enabled = true;
            }
            else
            {
                this.gbBOT.Enabled = false;
                this.gbAOT.Enabled = true;
            }
        }

        private void cheIsAOT_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.cheIsAOT.Checked)
            {
                this.calMinimumMinuteAOT.Enabled = false;
                this.calMaximumMinuteAOT.Enabled = false;
                this.calDistanceMinuteAOT.Enabled = false;
            }
            else
            {
                this.calMinimumMinuteAOT.Enabled = true;
                this.calMaximumMinuteAOT.Enabled = true;
                this.calDistanceMinuteAOT.Enabled = true;
            }
        }

        private void cheIsBOT_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.cheIsBOT.Checked)
            {
                this.calMinimumMinuteBOT.Enabled = false;
                this.calMaximumMinuteBOT.Enabled = false;
                this.calDistanceMinuteBOT.Enabled = false;
            }
            else
            {
                this.calMinimumMinuteBOT.Enabled = true;
                this.calMaximumMinuteBOT.Enabled = true;
                this.calDistanceMinuteBOT.Enabled = true;
            }
        }

        private void cheIsBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.cheIsBreak.Checked)
            {
                this.cheIsBreakOvernight.Enabled = false;
                this.teBreakBeginTime.Enabled = false;
                this.teBreakEndTime.Enabled = false;
            }
            else
            {
                this.cheIsBreakOvernight.Enabled = true;
                this.teBreakBeginTime.Enabled = true;
                this.teBreakEndTime.Enabled = true;
            }
            this.CalculatorMinute();
        }

        private void cheIsBreakOvernight_CheckedChanged(object sender, EventArgs e)
        {
            this.CalculatorMinute();
        }

        private void cheIsNightDay_EditValueChanged(object sender, EventArgs e)
        {
            if (!this.cheIsNightDutyDay.Checked)
            {
                this.txtNAME.Enabled = true;
                this.gbBOT.Enabled = true;
                this.gbAOT.Text = "Tính tăng ca sau giờ làm việc";
                this.lbMinimumMinuteAOT.Text = "Đủ bao nhiêu phút thì tính tăng ca?";
                this.lbMaximumMinuteAOT.Text = "Số phút tăng ca tối đa là bao nhiêu?";
                this.lbDistanceMinuteAOT.Text = "Cách giờ kết thúc ca bao nhiêu phút?";
            }
            else if (!(new DIC_SHIFT()).ExistNightDay(this.txtID.Text))
            {
                this.txtNAME.Text = "Trực đêm";
                this.txtNAME.Enabled = false;
                this.cheIsOvernight.Checked = true;
                this.gbBOT.Enabled = false;
                this.gbAOT.Text = "Tính tăng cường sau giờ trực đêm";
                this.lbMinimumMinuteAOT.Text = "Đủ bao nhiêu phút tính tăng cường?";
                this.lbMaximumMinuteAOT.Text = "Số phút tăng cường tối đa bao nhiêu?";
                this.lbDistanceMinuteAOT.Text = "Cách giờ kết thúc ca bao nhiêu phút?";
            }
            else
            {
                this.cheIsNightDutyDay.Checked = false;
                XtraMessageBox.Show("Đã tồn tại ca trực đêm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtDescription.Text = "";
        }

      

        protected override void Init()
        {
        }


        private void RaiseSuccessEventHander(DIC_SHIFT item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_SHIFT item)
        {
            this.txtID.Text = item.ShiftCode;
         //   SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.ShiftName;
            this.teBeginTime.Time = item.BeginTime;
            this.teEndTime.Time = item.EndTime;
            this.cheIsOvernight.Checked = item.IsOvernight;
            this.teBeginTime1.Time = item.BeginTime1;
            this.teBeginTime2.Time = item.BeginTime2;
            this.teEndTime1.Time = item.EndTime1;
            this.teEndTime2.Time = item.EndTime2;
            this.calLateMinute.EditValue = item.LateMinute;
            this.calEarlyMinute.EditValue = item.EarlyMinute;
            this.cheIsBreak.Checked = item.IsBreak;
            this.cheIsBreakOvernight.Checked = item.IsBreakOvernight;
            this.teBreakBeginTime.Time = item.BreakBeginTime;
            this.teBreakEndTime.Time = item.BreakEndTime;
            this.calTotalMinute.EditValue = item.TotalMinute;
            this.calTotalHour.EditValue = item.TotalHour;
            this.calWorkMinute.EditValue = item.WorkMinute;
            this.calHalfWorkMinute.EditValue = item.HalfWorkMinute;
            this.cboWorkDay.EditValue = item.WorkDay;
            this.cboMethodCheck.SelectedIndex = item.MethodCheck;
            this.cheIsBOT.Checked = item.IsBOT;
            this.cheIsAOT.Checked = item.IsAOT;
            this.calMinimumMinuteBOT.EditValue = item.MinimumMinuteBOT;
            this.calMaximumMinuteBOT.EditValue = item.MaximumMinuteBOT;
            this.calDistanceMinuteBOT.EditValue = item.DistanceMinuteBOT;
            this.calMinimumMinuteAOT.EditValue = item.MinimumMinuteAOT;
            this.calMaximumMinuteAOT.EditValue = item.MaximumMinuteAOT;
            this.calDistanceMinuteAOT.EditValue = item.DistanceMinuteAOT;
            this.cheIsNightDutyDay.EditValue = item.IsNightDutyDay;
            this.txtDescription.Text = item.Description;
        }

        private void teBeginTime_EditValueChanged(object sender, EventArgs e)
        {
            this.teBeginTime1.EditValue = DateAndTime.DateAdd(DateInterval.Hour, -1, DateTime.Parse(this.teBeginTime.EditValue.ToString()));
            this.teEndTime1.EditValue = DateTime.Parse(this.teBeginTime.EditValue.ToString());
            this.CalculatorMinute();
        }

        private void teBreakBeginTime_EditValueChanged(object sender, EventArgs e)
        {
            this.CalculatorMinute();
        }

        private void teEndTime_EditValueChanged(object sender, EventArgs e)
        {
            this.teBeginTime2.EditValue = DateTime.Parse(this.teEndTime.EditValue.ToString());
            this.teEndTime2.EditValue = DateAndTime.DateAdd(DateInterval.Hour, 1, DateTime.Parse(this.teEndTime.EditValue.ToString()));
            this.CalculatorMinute();
        }

       

        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_SHIFT dICSHIFT = new DIC_SHIFT();
                if (this.m_Status == Actions.Add)
                {
                    if (dICSHIFT.Exist(textEdit.Text))
                    {
                        this.Err.SetError(textEdit, "Mã đã tồn tại.");
                        textEdit.Focus();
                    }
                }
            }
        }

        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            DIC_SHIFT dICSHIFT = new DIC_SHIFT()
            {
                ShiftCode = this.txtID.Text
            };
            string str = dICSHIFT.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICSHIFT);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiShift") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
               // SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_SHIFT dICSHIFT = new DIC_SHIFT(this.txtID.Text, this.txtNAME.Text, Convert.ToDateTime(this.teBeginTime.Time), Convert.ToDateTime(this.teEndTime.Time), this.cheIsOvernight.Checked, Convert.ToDateTime(this.teBeginTime1.Time), Convert.ToDateTime(this.teBeginTime2.Time), Convert.ToDateTime(this.teEndTime1.Time), Convert.ToDateTime(this.teEndTime2.Time), Convert.ToInt32(this.calLateMinute.EditValue.ToString()), Convert.ToInt32(this.calEarlyMinute.EditValue.ToString()), this.cheIsBreak.Checked, this.cheIsBreakOvernight.Checked, Convert.ToDateTime(this.teBreakBeginTime.Time), Convert.ToDateTime(this.teBreakEndTime.Time), Convert.ToInt32(this.calTotalMinute.EditValue.ToString()), Convert.ToDouble(this.calTotalHour.EditValue.ToString()), Convert.ToInt32(this.calHalfWorkMinute.EditValue.ToString()), Convert.ToInt32(this.calWorkMinute.EditValue.ToString()), Convert.ToDouble(this.cboWorkDay.EditValue.ToString()), this.cboMethodCheck.SelectedIndex, this.cheIsBOT.Checked, this.cheIsAOT.Checked, Convert.ToInt32(this.calMinimumMinuteBOT.EditValue.ToString()), Convert.ToInt32(this.calMaximumMinuteBOT.EditValue.ToString()), Convert.ToInt32(this.calDistanceMinuteBOT.EditValue.ToString()), Convert.ToInt32(this.calMinimumMinuteAOT.EditValue.ToString()), Convert.ToInt32(this.calMaximumMinuteAOT.EditValue.ToString()), Convert.ToInt32(this.calDistanceMinuteAOT.EditValue.ToString()), this.cheIsNightDutyDay.Checked, this.txtDescription.Text);
                string str1 = dICSHIFT.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICSHIFT);
                }
                Cursor.Current = Cursors.Default;
                this.DoHide();
                if (str1 != "OK")
                {
                    XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                str = str1;
            }
            else
            {
                MyRule.Notify();
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiShift") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
               // SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_SHIFT dICSHIFT = new DIC_SHIFT(this.txtID.Text, this.txtNAME.Text, Convert.ToDateTime(this.teBeginTime.Time), Convert.ToDateTime(this.teEndTime.Time), this.cheIsOvernight.Checked, Convert.ToDateTime(this.teBeginTime1.Time), Convert.ToDateTime(this.teBeginTime2.Time), Convert.ToDateTime(this.teEndTime1.Time), Convert.ToDateTime(this.teEndTime2.Time), Convert.ToInt32(this.calLateMinute.EditValue.ToString()), Convert.ToInt32(this.calEarlyMinute.EditValue.ToString()), this.cheIsBreak.Checked, this.cheIsBreakOvernight.Checked, Convert.ToDateTime(this.teBreakBeginTime.Time), Convert.ToDateTime(this.teBreakEndTime.Time), Convert.ToInt32(this.calTotalMinute.EditValue.ToString()), Convert.ToDouble(this.calTotalHour.EditValue.ToString()), Convert.ToInt32(this.calHalfWorkMinute.EditValue.ToString()), Convert.ToInt32(this.calWorkMinute.EditValue.ToString()), Convert.ToDouble(this.cboWorkDay.EditValue.ToString()), this.cboMethodCheck.SelectedIndex, this.cheIsBOT.Checked, this.cheIsAOT.Checked, Convert.ToInt32(this.calMinimumMinuteBOT.EditValue.ToString()), Convert.ToInt32(this.calMaximumMinuteBOT.EditValue.ToString()), Convert.ToInt32(this.calDistanceMinuteBOT.EditValue.ToString()), Convert.ToInt32(this.calMinimumMinuteAOT.EditValue.ToString()), Convert.ToInt32(this.calMaximumMinuteAOT.EditValue.ToString()), Convert.ToInt32(this.calDistanceMinuteAOT.EditValue.ToString()), this.cheIsNightDutyDay.Checked, this.txtDescription.Text);
                string str1 = dICSHIFT.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICSHIFT);
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
                MyRule.Notify();
                str = "";
            }
            return str;
        }

        public event xucShiftAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_SHIFT item);

        private void cheIsAOT_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!this.cheIsAOT.Checked)
            {
                this.calMinimumMinuteAOT.Enabled = false;
                this.calMaximumMinuteAOT.Enabled = false;
                this.calDistanceMinuteAOT.Enabled = false;
            }
            else
            {
                this.calMinimumMinuteAOT.Enabled = true;
                this.calMaximumMinuteAOT.Enabled = true;
                this.calDistanceMinuteAOT.Enabled = true;
            }
        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {

            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_SHIFT()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }

        }
    }
}
