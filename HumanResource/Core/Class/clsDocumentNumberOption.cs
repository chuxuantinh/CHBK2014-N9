using Microsoft.VisualBasic;
using CHBK2014_N9.Data.Helper;
using System;
using System.Data;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Class
{
 public   class clsDocumentNumberOption
    {
        private string m_Prefix;

        private int m_Length;

        private string m_Suffix;

        public int Length
        {
            get
            {
                return this.m_Length;
            }
            set
            {
                this.m_Length = value;
            }
        }

        public string Prefix
        {
            get
            {
                return this.m_Prefix;
            }
            set
            {
                this.m_Prefix = value;
            }
        }

        public string Suffix
        {
            get
            {
                return this.m_Suffix;
            }
            set
            {
                this.m_Suffix = value;
            }
        }

        public clsDocumentNumberOption(string Code, string PrefixDefault, string SuffixDefault)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\documentNumberOption.xml"));
                this.m_Prefix = clsDocumentNumberOption.CheckOption(dataSet, Code, "Prefix");
                this.m_Length = int.Parse(clsDocumentNumberOption.CheckOption(dataSet, Code, "Length"));
                this.m_Suffix = clsDocumentNumberOption.CheckOption(dataSet, Code, "Suffix");
            }
            catch
            {
                this.m_Prefix = PrefixDefault;
                this.m_Length = 6;
                this.m_Suffix = SuffixDefault;
            }
        }

        public static string CheckOption(DataSet ds, string Code, string FieldName)
        {
            string str;
            string str1 = "";
            string code = Code;
            if (code != null)
            {
                if (code == "CandidateCode")
                {
                    str1 = ds.Tables[0].Rows[0][FieldName].ToString();
                    str = str1;
                    return str;
                }
                else if (code == "EmployeeCode")
                {
                    str1 = ds.Tables[0].Rows[1][FieldName].ToString();
                    str = str1;
                    return str;
                }
                else
                {
                    if (code != "ContractCode")
                    {
                        str1 = ds.Tables[0].Rows[0][FieldName].ToString();
                        str = str1;
                        return str;
                    }
                    str1 = ds.Tables[0].Rows[2][FieldName].ToString();
                    str = str1;
                    return str;
                }
            }
            str1 = ds.Tables[0].Rows[0][FieldName].ToString();
            str = str1;
            return str;
        }

        public string GenCode(string tableName, string columnName)
        {
            object obj;
            string[] strArrays;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            string str = "";
            if ((this.m_Prefix != "" ? false : !(this.m_Suffix != "")))
            {
                strArrays = new string[] { "select max([", columnName, "]) from [", tableName, "] where [", columnName, "] like N'0%' or [", columnName, "] like N'1%' or [", columnName, "] like N'2%' or [", columnName, "] like N'3%' or [", columnName, "] like N'4%' or [", columnName, "] like N'5%' or [", columnName, "] like N'6%' or [", columnName, "] like N'7%' or [", columnName, "] like N'8%' or [", columnName, "] like N'9%'" };
                obj = sqlHelper.ExecuteScalar(string.Concat(strArrays));
            }
            else
            {
                strArrays = new string[] { "select max([", columnName, "]) from [", tableName, "] where [", columnName, "] like N'", this.m_Prefix, "%", this.m_Suffix, "'" };
                obj = sqlHelper.ExecuteScalar(string.Concat(strArrays));
            }
            str = (obj == null ? "0" : obj.ToString());
            if (this.m_Prefix.Length != 0)
            {
                str = str.Replace(this.m_Prefix, "").Trim();
            }
            if (this.m_Suffix.Length != 0)
            {
                str = str.Replace(this.m_Suffix, "").Trim();
            }
            int num = 0;
            if (Information.IsNumeric(str))
            {
                num = (int)Conversion.Val(str);
            }
            num++;
            string str1 = num.ToString();
            while (str1.Length < this.m_Length)
            {
                str1 = string.Concat("0", str1);
            }
            return string.Concat(this.m_Prefix, str1, this.m_Suffix);
        }

        public static void SaveOption(DataTable Table)
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(Table);
            try
            {
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\documentNumberOption.xml"));
            }
            catch
            {
            }
        }
    }
}
