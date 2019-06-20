using System;
using System.Data;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Class
{
   public class clsContractOption
    {


        private string m_Signer;

        private string m_SignerNationality;

        private string m_SignerPosition;

        private string m_FilePath0;

        private string m_FilePath1;

        private string m_FilePath2;

        private string m_FilePath3;

        private int m_NumberDayWarning;

        public string FilePath0
        {
            get
            {
                return this.m_FilePath0;
            }
            set
            {
                this.m_FilePath0 = value;
            }
        }

        public string FilePath1
        {
            get
            {
                return this.m_FilePath1;
            }
            set
            {
                this.m_FilePath1 = value;
            }
        }

        public string FilePath2
        {
            get
            {
                return this.m_FilePath2;
            }
            set
            {
                this.m_FilePath2 = value;
            }
        }

        public string FilePath3
        {
            get
            {
                return this.m_FilePath3;
            }
            set
            {
                this.m_FilePath3 = value;
            }
        }

        public int NumberDayWarning
        {
            get
            {
                return this.m_NumberDayWarning;
            }
            set
            {
                this.m_NumberDayWarning = value;
            }
        }

        public string Signer
        {
            get
            {
                return this.m_Signer;
            }
            set
            {
                this.m_SignerPosition = value;
            }
        }

        public string SignerNationality
        {
            get
            {
                return this.m_SignerNationality;
            }
            set
            {
                this.m_SignerNationality = value;
            }
        }

        public string SignerPosition
        {
            get
            {
                return this.m_SignerPosition;
            }
            set
            {
                this.m_SignerPosition = value;
            }
        }

        public clsContractOption()
        {
            try
            {
                this.m_Signer = clsContractOption.CheckOption("Signer");
            }
            catch
            {
                this.m_Signer = "";
            }
            try
            {
                this.m_SignerNationality = clsContractOption.CheckOption("SignerNationality");
            }
            catch
            {
                this.m_SignerNationality = "";
            }
            try
            {
                this.m_SignerPosition = clsContractOption.CheckOption("SignerPosition");
            }
            catch
            {
                this.m_SignerPosition = "";
            }
            try
            {
                this.m_FilePath0 = clsContractOption.CheckOption("FilePath0");
            }
            catch
            {
                this.m_FilePath0 = "";
            }
            try
            {
                this.m_FilePath1 = clsContractOption.CheckOption("FilePath1");
            }
            catch
            {
                this.m_FilePath1 = "";
            }
            try
            {
                this.m_FilePath2 = clsContractOption.CheckOption("FilePath2");
            }
            catch
            {
                this.m_FilePath2 = "";
            }
            try
            {
                this.m_FilePath3 = clsContractOption.CheckOption("FilePath3");
            }
            catch
            {
                this.m_FilePath3 = "";
            }
            try
            {
                this.m_NumberDayWarning = int.Parse(clsContractOption.CheckOption("NumberDayWarning"));
            }
            catch
            {
                this.m_NumberDayWarning = 10;
            }
        }

        public static string CheckOption(string FieldName)
        {
            string str;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\contractOption.xml"));
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
                dataTable.Columns.Add("Signer", typeof(string));
                dataTable.Columns.Add("SignerNationality", typeof(string));
                dataTable.Columns.Add("SignerPosition", typeof(string));
                dataTable.Columns.Add("FilePath0", typeof(string));
                dataTable.Columns.Add("FilePath1", typeof(string));
                dataTable.Columns.Add("FilePath2", typeof(string));
                dataTable.Columns.Add("FilePath3", typeof(string));
                dataTable.Columns.Add("NumberDayWarning", typeof(string));
                object[] str = new object[] { this.m_Signer.ToString(), this.m_SignerNationality.ToString(), this.m_SignerPosition.ToString(), this.m_FilePath0.ToString(), this.m_FilePath1.ToString(), this.m_FilePath2.ToString(), this.m_FilePath3.ToString(), this.m_NumberDayWarning.ToString() };
                object[] objArray = str;
                dataTable.Rows.Add(new object[0]);
                dataTable.Rows[0][0] = objArray[0];
                dataTable.Rows[0][1] = objArray[1];
                dataTable.Rows[0][2] = objArray[2];
                dataTable.Rows[0][3] = objArray[3];
                dataTable.Rows[0][4] = objArray[4];
                dataTable.Rows[0][5] = objArray[5];
                dataTable.Rows[0][6] = objArray[6];
                dataTable.Rows[0][7] = objArray[7];
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\contractOption.xml"));
            }
            catch
            {
            }
        }

        public static void SaveOption(string Signer, string SignerNationality, string SignerPosition, string FilePath0, string FilePath1, string FilePath2, string FilePath3, int NumberDayWarning)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("Signer", typeof(string));
                dataTable.Columns.Add("SignerNationality", typeof(string));
                dataTable.Columns.Add("SignerPosition", typeof(string));
                dataTable.Columns.Add("FilePath0", typeof(string));
                dataTable.Columns.Add("FilePath1", typeof(string));
                dataTable.Columns.Add("FilePath2", typeof(string));
                dataTable.Columns.Add("FilePath3", typeof(string));
                dataTable.Columns.Add("NumberDayWarning", typeof(string));
                object[] str = new object[] { Signer.ToString(), SignerNationality.ToString(), SignerPosition.ToString(), FilePath0.ToString(), FilePath1.ToString(), FilePath2.ToString(), FilePath3.ToString(), NumberDayWarning.ToString() };
                object[] objArray = str;
                dataTable.Rows.Add(new object[0]);
                dataTable.Rows[0][0] = objArray[0];
                dataTable.Rows[0][1] = objArray[1];
                dataTable.Rows[0][2] = objArray[2];
                dataTable.Rows[0][3] = objArray[3];
                dataTable.Rows[0][4] = objArray[4];
                dataTable.Rows[0][5] = objArray[5];
                dataTable.Rows[0][6] = objArray[6];
                dataTable.Rows[0][7] = objArray[7];
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\contractOption.xml"));
            }
            catch
            {
            }
        }
    }
}
