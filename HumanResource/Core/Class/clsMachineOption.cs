using System;
using System.Data;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Class
{
  public  class clsMachineOption
    {

        private bool m_IsShowMessageInOut;

        private bool m_IsAutomaticJoinDataImport;

        public bool IsAutomaticJoinDataImport
        {
            get
            {
                return this.m_IsAutomaticJoinDataImport;
            }
            set
            {
                this.m_IsAutomaticJoinDataImport = value;
            }
        }

        public bool IsShowMessageInOut
        {
            get
            {
                return this.m_IsShowMessageInOut;
            }
            set
            {
                this.m_IsShowMessageInOut = value;
            }
        }

        public clsMachineOption()
        {
            try
            {
                this.m_IsShowMessageInOut = bool.Parse(clsMachineOption.CheckOption("IsShowMessageInOut"));
            }
            catch
            {
                this.m_IsShowMessageInOut = false;
            }
            try
            {
                this.m_IsAutomaticJoinDataImport = bool.Parse(clsMachineOption.CheckOption("IsAutomaticJoinDataImport"));
            }
            catch
            {
                this.m_IsAutomaticJoinDataImport = false;
            }
        }

        public static string CheckOption(string FieldName)
        {
            string str;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\machineOption.xml"));
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
                dataTable.Columns.Add("IsShowMessageInOut", typeof(string));
                dataTable.Columns.Add("IsAutomaticJoinDataImport", typeof(string));
                object[] str = new object[] { this.m_IsShowMessageInOut.ToString(), this.m_IsAutomaticJoinDataImport.ToString() };
                object[] objArray = str;
                dataTable.Rows.Add(new object[0]);
                dataTable.Rows[0][0] = objArray[0];
                dataTable.Rows[0][1] = objArray[1];
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\machineOption.xml"));
            }
            catch
            {
            }
        }

        public static void SaveOption(bool IsShowMessageInOut, bool IsAutomaticJoinDataImport)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("IsShowMessageInOut", typeof(string));
                dataTable.Columns.Add("IsAutomaticJoinDataImport", typeof(string));
                object[] str = new object[] { IsShowMessageInOut.ToString(), IsAutomaticJoinDataImport.ToString() };
                object[] objArray = str;
                dataTable.Rows.Add(new object[0]);
                dataTable.Rows[0][0] = objArray[0];
                dataTable.Rows[0][1] = objArray[1];
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\machineOption.xml"));
            }
            catch
            {
            }
        }
    }
}
