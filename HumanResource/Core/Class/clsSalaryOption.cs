using System;
using System.Data;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Class
{
 public   class clsSalaryOption
    {

        private bool m_IsAllowanceReCreate;

        public bool IsAllowanceReCreate
        {
            get
            {
                return this.m_IsAllowanceReCreate;
            }
            set
            {
                this.m_IsAllowanceReCreate = value;
            }
        }

        public clsSalaryOption()
        {
            try
            {
                this.m_IsAllowanceReCreate = bool.Parse(clsSalaryOption.CheckOption("IsAllowanceReCreate"));
            }
            catch
            {
                this.m_IsAllowanceReCreate = false;
            }
        }

        public static string CheckOption(string FieldName)
        {
            string str;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\salaryOption.xml"));
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
                dataTable.Columns.Add("IsAllowanceReCreate", typeof(string));
                object[] str = new object[] { this.m_IsAllowanceReCreate.ToString() };
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\salaryOption.xml"));
            }
            catch
            {
            }
        }

        public static void SaveOption(bool IsAllowanceReCreate)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("IsAllowanceReCreate", typeof(string));
                object[] str = new object[] { IsAllowanceReCreate.ToString() };
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\salaryOption.xml"));
            }
            catch
            {
            }
        }
    }
}
