using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace CHBK2014_N9.Common.Base
{
    public partial class xucDateEdit : UserControl
    {

        private int m_Day = 1;

        private int m_Month = 1;

        private int m_Year = DateTime.Now.Year;

        private bool m_ReadOnly = false;

        public int Day
        {
            get
            {
                return this.m_Day;
            }
            set
            {
                this.m_Day = value;
            }
        }

        public int Month
        {
            get
            {
                return this.m_Month;
            }
            set
            {
                this.m_Month = value;
                this.cboMonth.Text = this.m_Month.ToString();
                this.CreateDayItems(this.m_Month, this.m_Year);
            }
        }

        public bool ReadOnly
        {
            get
            {
                return this.m_ReadOnly;
            }
            set
            {
                this.m_ReadOnly = value;
                this.cboDay.Properties.ReadOnly = this.m_ReadOnly;
                this.cboMonth.Properties.ReadOnly = this.m_ReadOnly;
                this.cboYear.Properties.ReadOnly = this.m_ReadOnly;
            }
        }

        public int Year
        {
            get
            {
                return this.m_Year;
            }
            set
            {
                this.m_Year = value;
                this.cboYear.Text = this.m_Year.ToString();
                this.CreateDayItems(this.m_Month, this.m_Year);
            }
        }

        public xucDateEdit()
        {
            this.InitializeComponent();
            this.CreateYearItems();
            this.CreateMonthItems();
            this.CreateDayItems(this.m_Month, this.m_Year);
        }

       

        private void xucDateEdit_Load(object sender, EventArgs e)
        {

        }

      

        private void cboMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            this.m_Month = Convert.ToInt32(this.cboMonth.Text);
            this.CreateDayItems(this.m_Month, this.m_Year);
        }

        private void cboYear_SelectedValueChanged(object sender, EventArgs e)
        {
            this.m_Year = Convert.ToInt32(this.cboYear.Text);
            this.CreateDayItems(this.m_Month, this.m_Year);
        }


        private void CreateDayItems(int Month, int Year)
        {
            if (Month != 0)
            {
                int num = DateTime.DaysInMonth(Year, Month);
                if (num + 1 != this.cboDay.Properties.Items.Count)
                {
                    this.cboDay.Properties.Items.Clear();
                    for (int i = 0; i <= num; i++)
                    {
                        this.cboDay.Properties.Items.Add(i.ToString());
                    }
                    this.cboDay.Text = this.m_Day.ToString();
                    if (!(num != 28 ? true : this.m_Day <= 28))
                    {
                        this.cboDay.Text = "28";
                    }
                    else if (!(num != 29 ? true : this.m_Day <= 29))
                    {
                        this.cboDay.Text = "29";
                    }
                    else if ((num != 30 ? false : this.m_Day > 30))
                    {
                        this.cboDay.Text = "30";
                    }
                }
                this.cboDay.Text = this.m_Day.ToString();
            }
            else
            {
                this.cboDay.Properties.Items.Clear();
                this.cboDay.Properties.Items.AddRange(new object[] { "0" });
                this.cboDay.Text = "0";
            }
        }

        private void CreateMonthItems()
        {
            this.cboMonth.Properties.Items.Clear();
            for (int i = 0; i <= 12; i++)
            {
                this.cboMonth.Properties.Items.Add(i.ToString());
            }
            this.cboMonth.Text = this.m_Month.ToString();
        }

        private void CreateYearItems()
        {
            this.cboYear.Properties.Items.Clear();
            for (int i = 1940; i <= 2099; i++)
            {
                this.cboYear.Properties.Items.Add(i.ToString());
            }
            this.cboYear.Text = this.m_Year.ToString();
        }

        private void cboDay_SelectedValueChanged(object sender, EventArgs e)
        {
            this.m_Day = Convert.ToInt32(this.cboDay.Text);
        }
    }
}
