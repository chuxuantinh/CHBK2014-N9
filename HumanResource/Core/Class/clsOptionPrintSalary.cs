using System;
using System.Data;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Class
{
  public  class clsOptionPrintSalary
    {


        private int m_Theme;

        public int Theme
        {
            get
            {
                return this.m_Theme;
            }
            set
            {
                this.m_Theme = value;
            }
        }

        public clsOptionPrintSalary()
        {
            try
            {
                this.m_Theme = int.Parse(clsOptionPrintSalary.CheckOption("Theme"));
            }
            catch
            {
                this.m_Theme = 0;
            }
        }

        public static string CheckOption(string FieldName)
        {
            string str;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucOptionPrintSalary.xml"));
                str = dataSet.Tables[0].Rows[0][FieldName].ToString();
            }
            catch
            {
                str = "";
            }
            return str;
        }

        public void SaveOption()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("Theme", typeof(int));
                object[] str = new object[] { this.m_Theme.ToString() };
                dataTable.Rows.Add(new object[0]);
                dataTable.Rows[0][0] = str[0];
                dataSet.Tables.Add(dataTable);
            }
            finally
            {
                if (dataTable != null)
                {
                    ((IDisposable)dataTable).Dispose();
                }
            }
            try
            {
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucOptionPrintSalary.xml"));
            }
            catch
            {
            }
        }

        public static void SaveOption(int Theme, bool IsShowNightDutyDay, bool IsShowExtraHour, bool IsShowPrivateHour)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("Theme", typeof(int));
                object[] str = new object[] { Theme.ToString() };
                dataTable.Rows.Add(new object[0]);
                dataTable.Rows[0][0] = str[0];
                dataSet.Tables.Add(dataTable);
            }
            finally
            {
                if (dataTable != null)
                {
                    ((IDisposable)dataTable).Dispose();
                }
            }
            try
            {
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucOptionPrintSalary.xml"));
            }
            catch
            {
            }
        }
    }
}
