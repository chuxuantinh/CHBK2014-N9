using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
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
    public partial class xfmShiftOption : XtraForm
    {

        private int m_Month = 0;

        private int m_Year = 0;

        private HRM_TIMEKEEPER_TABLELIST l_TimeKeeperTableList = new HRM_TIMEKEEPER_TABLELIST();

        private bool m_IsClosing = true;
        public xfmShiftOption()
        {
            this.InitializeComponent();
            this.LoadTimeKeeperShiftList();
        }

        public xfmShiftOption(int Month, int Year)
        {
            this.InitializeComponent();
            this.LoadTimeKeeperShiftList();
            this.m_Month = Month;
            this.m_Year = Year;
            this.Text = string.Concat("Tùy chọn tạo bảng xếp ca, bảng chấm công cho tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString());
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (this.radioGroup1.SelectedIndex != 0)
            {
                string str = (this.lbTimeKeeperShiftList.SelectedItem as ImageListBoxItem).Value.ToString();
                char[] chrArray = new char[] { ' ', '-' };
                string[] strArrays = str.Split(chrArray);
                int num = Convert.ToInt32(strArrays[1].ToString());
                int num1 = Convert.ToInt32(strArrays[2].ToString());
                this.RaiseCreateOldDataChangedHander(num, num1);
            }
            else
            {
                this.RaiseCreateNewDataChangedHander();
            }
            this.m_IsClosing = false;
            base.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.m_IsClosing = true;
            this.CancelThis();
        }

        private void LoadTimeKeeperShiftList()
        {
            DataTable list = this.l_TimeKeeperTableList.GetList();
            if (list.Rows.Count == 0)
            {
                this.radioGroup1.Enabled = false;
            }
            foreach (DataRow row in list.Rows)
            {
                this.lbTimeKeeperShiftList.Items.Add(row["TimeKeeperTableListName"].ToString());
            }
        }

        private void RaiseClosedHandler()
        {
            if (this.Closed != null)
            {
                this.Closed(this);
            }
        }

        private void RaiseCreateNewDataChangedHander()
        {
            if (this.CreateNewDataChanged != null)
            {
                this.CreateNewDataChanged(this);
            }
        }

        private void RaiseCreateOldDataChangedHander(int Month, int Year)
        {
            if (this.CreateOldDataChanged != null)
            {
                this.CreateOldDataChanged(this, Month, Year);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.radioGroup1.SelectedIndex != 0)
            {
                this.lbTimeKeeperShiftList.Enabled = true;
            }
            else
            {
                this.lbTimeKeeperShiftList.Enabled = false;
            }
        }

        private void xfmShiftOption_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.m_IsClosing)
            {
                this.m_IsClosing = true;
            }
            else
            {
                this.m_IsClosing = false;
            }
            this.CancelThis();
        }

        private void CancelThis()
        {
            if (this.m_IsClosing)
            {
                this.RaiseClosedHandler();
            }
            base.Close();
        }

        public event xfmShiftOption.ClosedHandler Closed;

        public event xfmShiftOption.CreateNewDataChangedHander CreateNewDataChanged;

        public event xfmShiftOption.CreateOldDataChangedHandler CreateOldDataChanged;

        public delegate void ClosedHandler(object sender);

        public delegate void CreateNewDataChangedHander(object sender);

        public delegate void CreateOldDataChangedHandler(object sender, int Month, int Year);
    }
}
