using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab;
using CHBK2014_N9.Common.Class;
//using CHBK2014_N9.Data.Extra.Forms;
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

    public partial class xfmShiftAdd : Form
    {

        private int m_Month = 0;

        private int m_Year = 0;
        private HRM_TIMEKEEPER_TABLELIST l_TimeKeeperTableList = new HRM_TIMEKEEPER_TABLELIST();

        private clsAllOption clsAllOption = new clsAllOption();

        public xfmShiftAdd()
        {
            InitializeComponent();
            this.dtYear.EditValue = this.clsAllOption.MonthDefault;
            this.LoadTimeKeeperShiftList();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string str = (this.lbTimeKeeperShiftList.SelectedItem as ImageListBoxItem).Value.ToString();
            char[] chrArray = new char[] { ' ', '-' };
            string[] strArrays = str.Split(chrArray);
            this.m_Month = Convert.ToInt32(strArrays[1].ToString());
            this.m_Year = Convert.ToInt32(strArrays[2].ToString());
            if (XtraMessageBox.Show("Bạn có muốn sao lưu dữ liệu lại trước khi thực hiện chức năng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                this.Delete();
            }
            else
            {
                //XfmBackupDatabase xfmBackupDatabase = new XfmBackupDatabase();
                //xfmBackupDatabase.Closed += new XfmBackupDatabase.ClosedHandler((object s) => this.Delete());
                //xfmBackupDatabase.ShowDialog();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btCreat_Click(object sender, EventArgs e)
        {
            string str = (this.lbNoTimeKeeperShiftList.SelectedItem as ImageListBoxItem).Value.ToString();
            char[] chrArray = new char[] { ' ', '-' };
            string[] strArrays = str.Split(chrArray);
            this.m_Month = Convert.ToInt32(strArrays[1].ToString());
            this.m_Year = Convert.ToInt32(strArrays[2].ToString());
            this.RaiseUnShiftDataHandler(this.m_Month, this.m_Year);
            base.Close();
        }


        private void Delete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?\n\nDữ liệu bị xóa bao gồm:\n\n\t- Dữ liệu tính lương, lương tăng ca trong tháng.\n\t- Dữ liệu chấm công tăng ca.\n\t- Dữ liệu chấm công chi tiết theo ngày, chấm công tháng.\n\t- Dữ liệu xếp ca chi tiết của tháng được chọn.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                if (!(this.l_TimeKeeperTableList.Delete(this.m_Month, this.m_Year) == "OK"))
                {
                    XtraMessageBox.Show("Dữ liệu này không thể xóa được!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Đã hoàn tất việc xóa dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.RaiseTimekeeperTableDeletedHander();
                    base.Close();
                }
            }
        }

        private void dtYear_EditValueChanged(object sender, EventArgs e)
        {
            this.LoadTimeKeeperShiftList();
        }


        private void LoadTimeKeeperShiftList()
        {
            this.lbNoTimeKeeperShiftList.Items.Clear();
            this.lbTimeKeeperShiftList.Items.Clear();
            DataTable listByYear = this.l_TimeKeeperTableList.GetListByYear(int.Parse(this.dtYear.Text));
            foreach (DataRow row in listByYear.Rows)
            {
                this.lbTimeKeeperShiftList.Items.Add(row["TimeKeeperTableListName"].ToString(), 2);
            }
            for (int i = 1; i <= 12; i++)
            {
                if (!this.l_TimeKeeperTableList.Exist(i, int.Parse(this.dtYear.Text)))
                {
                    this.lbNoTimeKeeperShiftList.Items.Add(string.Concat("Tháng ", i.ToString(), "-", this.dtYear.Text), 2);
                }


                
            }
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

        private void RaiseUnShiftDataHandler(int Month, int Year)
        {
            if (this.UnShiftData != null)
            {
                this.UnShiftData(this, Month, Year);
            }
        }

        private void xtraTabControl1_Selected(object sender, TabPageEventArgs e)
        {
            if (e.PageIndex != 0)
            {
                if (this.lbTimeKeeperShiftList.Items.Count <= 0)
                {
                    this.btDelete.Enabled = false;
                }
                else
                {
                    this.btDelete.Enabled = true;
                }
                this.btCreate.Enabled = false;
            }
            else
            {
                if (this.lbNoTimeKeeperShiftList.Items.Count <= 0)
                {
                    this.btCreate.Enabled = false;
                }
                else
                {
                    this.btCreate.Enabled = true;
                }
                this.btDelete.Enabled = false;
            }
        }

        public event xfmShiftAdd.ClosedHandler Closed;

        public event xfmShiftAdd.TimekeeperTableDeletedHandler TimekeeperTableDeleted;

        public event xfmShiftAdd.TimekeeperTableInsertedHandler TimekeeperTableInserted;

        public event xfmShiftAdd.UnShiftDataHandler UnShiftData;

        public delegate void ClosedHandler(object sender);

        public delegate void TimekeeperTableDeletedHandler(object sender);

        public delegate void TimekeeperTableInsertedHandler(object sender);

        public delegate void UnShiftDataHandler(object sender, int Month, int Year);
    }
}
