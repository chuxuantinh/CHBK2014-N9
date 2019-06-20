using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmInsertSymbol : XtraForm
    {

        private int m_Month = 0;

        private int m_Year = 0;
        public xfmInsertSymbol()
        {
            InitializeComponent();
            this.InitData();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }


        public xfmInsertSymbol(int Month, int Year)
        {
            this.InitializeComponent();
            this.m_Month = Month;
            this.m_Year = Year;
            this.InitData();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (this.glkSymbol.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn ký hiệu chấm công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (!(int.Parse(this.calFromRow.Text) < 1 ? false : int.Parse(this.calToRow.Text) >= 1))
            {
                XtraMessageBox.Show("Số dòng không được nhỏ hơn 1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (int.Parse(this.calFromRow.Text) > int.Parse(this.calToRow.Text))
            {
                XtraMessageBox.Show("Số dòng đến không được nhỏ hơn số dòng đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (int.Parse(this.teFromDate.Text) <= int.Parse(this.teToDate.Text))
            {
                this.RaiseUnShiftDataHandler(this.glkSymbol.EditValue.ToString(), int.Parse(this.teFromDate.Text), int.Parse(this.teToDate.Text), int.Parse(this.calFromRow.Text), int.Parse(this.calToRow.Text), this.cheAll.Checked);
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

        private void InitData()
        {
            this.teFromDate.EditValue = new DateTime(this.m_Year, this.m_Month, 1);
            this.teToDate.EditValue = new DateTime(this.m_Year, this.m_Month, 1);
            this.calFromRow.EditValue = 1;
            this.calToRow.EditValue = 1;
            (new DIC_SYMBOL()).AddGridLookupEdit(this.glkSymbol);
        }


        private void RaiseUnShiftDataHandler(string Symbol, int FromDate, int ToDate, int FromRow, int ToRow, bool IsCheckAll)
        {
            if (this.UnShiftData != null)
            {
                this.UnShiftData(this, Symbol, FromDate, ToDate, FromRow, ToRow, IsCheckAll);
            }
        }

        public event xfmInsertSymbol.UnShiftDataHandler UnShiftData;

        public delegate void UnShiftDataHandler(object sender, string Symbol, int FromDate, int ToDate, int FromRow, int ToRow, bool IsCheckAll);

    }
}
