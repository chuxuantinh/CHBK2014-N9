using DevExpress.Utils;
using DevExpress.XtraEditors;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmSalaryTableListAdd : xfmBaseWizard
    {

        private int m_Month = DateTime.Now.Month;

        private int m_Year = DateTime.Now.Year;
        public xfmSalaryTableListAdd()
        {
            InitializeComponent();
        }

        public xfmSalaryTableListAdd(int Month, int Year)
        {
            this.InitializeComponent();
            this.m_Month = Month;
            this.m_Year = Year;
            this.lblTitle.Text = string.Concat("Tạo dữ liệu tính lương cho tháng ", Month.ToString(), "/", Year.ToString());
        }

        private void bbiSalaryFormula_Click(object sender, EventArgs e)
        {
          // (new xfmAllOption("tabSalary")).ShowDialog();
        }

        private void btMinimumSalary_Click(object sender, EventArgs e)
        {
           // (new xfmAllOption("tabMinimumSalary")).ShowDialog();
        }
        private void CreateSalaryTabelList()
        {
            Options.SetWaitDialogCaption("Đang khởi tạo dữ liệu...");
            if ((new HRM_TIMEKEEPER_TABLELIST()).Exist(this.m_Month, this.m_Year))
            {
                HRM_SALARY_TABLELIST hRMSALARYTABLELIST = new HRM_SALARY_TABLELIST();
                DIC_SALARY_FORMULA dICSALARYFORMULA = new DIC_SALARY_FORMULA();
                dICSALARYFORMULA.Get();
                if (!hRMSALARYTABLELIST.Exist(this.m_Month, this.m_Year))
                {
                    Guid guid = Guid.NewGuid();
                    if (hRMSALARYTABLELIST.Insert(guid.ToString(), string.Concat("Tháng ", this.m_Month.ToString(), " - ", this.m_Year.ToString()), this.m_Month, this.m_Year, dICSALARYFORMULA.SocialInsurance, dICSALARYFORMULA.HealthInsurance, dICSALARYFORMULA.UnemploymentInsurance, dICSALARYFORMULA.SocialInsurance1, dICSALARYFORMULA.HealthInsurance1, dICSALARYFORMULA.UnemploymentInsurance1, dICSALARYFORMULA.OvertimeSaturdayType, false, false) == "OK")
                    {
                        HRM_SALARY_ALLOWANCE.Create(guid.ToString(), true);
                        HRM_SALARY_INCOME.Create(guid.ToString());
                        HRM_SALARY.Create(0, "", guid.ToString(), string.Concat("Tháng ", this.m_Month.ToString(), " - ", this.m_Year.ToString()), this.m_Month, this.m_Year);
                    }
                    this.RaiseCreatedHandler();
                }
                Options.HideDialog();
            }
            else
            {
                MessageBox.Show("Bảng chấm công tháng này chưa được khởi tạo! Vui lòng tạo bảng chấm công trước khi thực hiện tính lương!");
                Options.HideDialog();
            }
        }



        protected override void Next()
        {
            base.Next();
            this.CreateSalaryTabelList();
        }

        private void RaiseCreatedHandler()
        {
            if (this.Created != null)
            {
                this.Created(this);
            }
        }

        public event xfmSalaryTableListAdd.CreateSuccess Created;

        public delegate void CreateSuccess(object sender);
    }
}
