using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using Microsoft.VisualBasic;
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
    public partial class xfmShiftCheckOption : XtraForm
    {

        private int m_Month = 0;

        private int m_Year = 0;
        public xfmShiftCheckOption()
        {
            InitializeComponent();
            InitData();
        }


        public xfmShiftCheckOption(int Month, int Year)
        {
            this.InitializeComponent();
            this.m_Month = Month;
            this.m_Year = Year;
            this.InitData();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (!(int.Parse(this.calFromRow.Text) < 1 ? false : int.Parse(this.calToRow.Text) >= 1))
            {
                XtraMessageBox.Show("Số dòng không được nhỏ hơn 1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (int.Parse(this.calFromRow.Text) > int.Parse(this.calToRow.Text))
            {
                XtraMessageBox.Show("Số dòng đến không được nhỏ hơn số dòng đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (int.Parse(this.teFromDate.Text) <= int.Parse(this.teToDate.Text))
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
                this.RaiseUnShiftDataHandler(flag, int.Parse(this.teFromDate.Text), int.Parse(this.teToDate.Text), int.Parse(this.calFromRow.Text), int.Parse(this.calToRow.Text), this.cheAll.Checked, this.cheIsFilterByShift.Checked, dataTable, this.cheIsNotSaturday.Checked, this.cheIsNotSunday.Checked, this.cheIsNotHoliday.Checked);
                base.Close();
            }
            else
            {
                XtraMessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void cheAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.cheAll.Checked)
            {
                this.calFromRow.Enabled = true;
                this.calToRow.Enabled = true;
            }
            else
            {
                this.calFromRow.Enabled = false;
                this.calToRow.Enabled = false;
            }
        }

        private void cheIsFilterByShift_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.cheIsFilterByShift.Checked)
            {
                this.clbShift.Enabled = false;
            }
            else
            {
                this.clbShift.Enabled = true;
            }
        }


        private void InitData()
        {
            DateTime dateTime = new DateTime(this.m_Year, this.m_Month, 1);
            this.teFromDate.EditValue = dateTime;
            this.teToDate.EditValue = DateAndTime.DateAdd(DateInterval.Day, -1, DateAndTime.DateAdd(DateInterval.Month, 1, dateTime));
            this.calFromRow.EditValue = 1;
            this.calToRow.EditValue = 1;
            this.clbShift.Items.Clear();
            (new DIC_SHIFT()).AddCheckedListBox(this.clbShift);
        }


        private void RaiseUnShiftDataHandler(bool IsCheck, int FromDate, int ToDate, int FromRow, int ToRow, bool IsCheckAll, bool IsFilterByShift, DataTable ShiftTable, bool IsNotSaturday, bool IsNotSunday, bool IsNotHoliday)
        {
            if (this.UnShiftData != null)
            {
                this.UnShiftData(this, IsCheck, FromDate, ToDate, FromRow, ToRow, IsCheckAll, IsFilterByShift, ShiftTable, IsNotSaturday, IsNotSunday, IsNotHoliday);
            }
        }

        private void rdOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rdOption.SelectedIndex != 0)
            {
                this.btCreate.Text = "Bỏ Chọn (<<)";
            }
            else
            {
                this.btCreate.Text = "Chọn (>>)";
            }
        }

        public event xfmShiftCheckOption.UnShiftDataHandler UnShiftData;

        public delegate void UnShiftDataHandler(object sender, bool IsCheck, int FromDate, int ToDate, int FromRow, int ToRow, bool IsCheckAll, bool IsFilterByShift, DataTable ShiftTable, bool IsNotSaturday, bool IsNotSunday, bool IsNotHoliday);

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
