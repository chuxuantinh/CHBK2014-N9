using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab;
using CHBK2014_N9.Common;
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
    public partial class xfmSalaryTableListOption :xfmBaseWizard
    {

        private int m_Month = 0;

        private int m_Year = 0;

        private HRM_SALARY_TABLELIST l_SalaryTableList = new HRM_SALARY_TABLELIST();

        private clsAllOption clsAllOption = new clsAllOption();
        public xfmSalaryTableListOption()
        {
            InitializeComponent();

          
            this.dtYear.EditValue = this.clsAllOption.MonthDefault;
            this.LoadSalaryTableList();
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void btCreate_Click()
        {
            this.GetMonthYear(0);
            xfmSalaryTableListAdd _xfmSalaryTableListAdd = new xfmSalaryTableListAdd(this.m_Month, this.m_Year);
            _xfmSalaryTableListAdd.Created += new xfmSalaryTableListAdd.CreateSuccess((object s) => this.RaiseCreatedHandler());
            _xfmSalaryTableListAdd.Size = base.Size;
            _xfmSalaryTableListAdd.ShowDialog();
        }

        private void btDelete_Click()
        {
            this.GetMonthYear(1);
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

        private void Delete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?\n\nDữ liệu bị xóa bao gồm:\n\n\t- Dữ liệu tính lương, lương tăng ca trong tháng.\n\t- Dữ liệu thanh toán lương, phụ cấp lương.\n\t- Các khoản thu nhập và khấu trừ khác.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                if (!(this.l_SalaryTableList.Delete(this.m_Month, this.m_Year) == "OK"))
                {
                    XtraMessageBox.Show("Dữ liệu này không thể xóa được!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Đã hoàn tất việc xóa dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.RaiseDeletedHandler();
                    base.Close();
                }
            }
        }

        private void dtYear_EditValueChanged(object sender, EventArgs e)
        {
            this.LoadSalaryTableList();
        }

        private void GetMonthYear(int Type)
        {
            string str = "";
            str = (Type != 0 ? (this.lbSalaryTableList.SelectedItem as ImageListBoxItem).Value.ToString() : (this.lbNoSalaryTableList.SelectedItem as ImageListBoxItem).Value.ToString());
            char[] chrArray = new char[] { ' ', '-' };
            string[] strArrays = str.Split(chrArray);
            this.m_Month = Convert.ToInt32(strArrays[1].ToString());
            this.m_Year = Convert.ToInt32(strArrays[2].ToString());
        }



        private void LoadSalaryTableList()
        {
            this.lbNoSalaryTableList.Items.Clear();
            this.lbSalaryTableList.Items.Clear();
            DataTable listByYear = this.l_SalaryTableList.GetListByYear(int.Parse(this.dtYear.Text));
            foreach (DataRow row in listByYear.Rows)
            {
                ImageListBoxItemCollection items = this.lbSalaryTableList.Items;
                object[] str = new object[] { "Tháng ", row["Month"].ToString(), '-', row["Year"].ToString() };
                items.Add(string.Concat(str), 2);
            }
            for (int i = 1; i <= 12; i++)
            {
                if (!this.l_SalaryTableList.Exist(i, int.Parse(this.dtYear.Text)))
                {
                    this.lbNoSalaryTableList.Items.Add(string.Concat("Tháng ", i.ToString(), "-", this.dtYear.Text), 2);
                }
            }
        }

        protected override void Next()
        {
            base.Next();
            if (this.xtraTabControl1.SelectedTabPageIndex != 0)
            {
                this.btDelete_Click();
            }
            else
            {
                this.btCreate_Click();
            }
        }

        private void RaiseCreatedHandler()
        {
            if (this.Created != null)
            {
                this.Created(this);
            }
        }

        private void RaiseDeletedHandler()
        {
            if (this.Deleted != null)
            {
                this.Deleted(this);
            }
        }

        private void xtraTabControl1_Selected(object sender, TabPageEventArgs e)
        {
            if (e.PageIndex == 0)
            {
                this.btLock.Enabled = false;
                this.btOpen.Enabled = false;
                this.btFinish.Enabled = false;
                if (this.lbNoSalaryTableList.Items.Count <= 0)
                {
                    this.btNext.Enabled = false;
                }
                else
                {
                    this.btNext.Enabled = true;
                    this.btNext.Text = "Tạo Dữ Liệu >";
                }
            }
            else if (this.lbSalaryTableList.Items.Count <= 0)
            {
                this.btNext.Enabled = false;
                this.btLock.Enabled = false;
                this.btOpen.Enabled = false;
                this.btFinish.Enabled = false;
            }
            else
            {
                this.btNext.Enabled = true;
                this.btLock.Enabled = true;
                this.btOpen.Enabled = true;
                this.btFinish.Enabled = true;
                this.btNext.Text = "Xóa Dữ Liệu";
            }
        }

        public event xfmSalaryTableListOption.CreateSuccess Created;

        public event xfmSalaryTableListOption.DeleteSuccess Deleted;

        public delegate void CreateSuccess(object sender);

        public delegate void DeleteSuccess(object sender);

    }
}
