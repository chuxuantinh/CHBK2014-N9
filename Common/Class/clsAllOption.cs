using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace CHBK2014_N9.Common.Class
{
   public class clsAllOption
    {

        private DateTime m_MonthDefault;

        private bool m_ShowDiagram;

        private bool m_ShowWorkdesk;

        private bool m_ShowWelcome;

        private bool m_ShowHelp;

        private bool m_ShowSendMail;

        private bool m_ShowTimekeeper;

        private bool m_ShowSalary;

        private int m_Update;

        private bool m_Minimized;

        private string m_WindowState;

        private int m_SizeWidth;

        private int m_SizeHeight;

        private int m_LocationX;

        private int m_LocationY;

        public int LocationX
        {
            get
            {
                return this.m_LocationX;
            }
            set
            {
                this.m_LocationX = value;
            }
        }

        public int LocationY
        {
            get
            {
                return this.m_LocationY;
            }
            set
            {
                this.m_LocationY = value;
            }
        }

        public bool Minimized
        {
            get
            {
                return this.m_Minimized;
            }
            set
            {
                this.m_Minimized = value;
            }
        }

        public DateTime MonthDefault
        {
            get
            {
                return this.m_MonthDefault;
            }
            set
            {
                this.m_MonthDefault = value;
            }
        }

        public bool ShowDiagram
        {
            get
            {
                return this.m_ShowDiagram;
            }
            set
            {
                this.m_ShowDiagram = value;
            }
        }

        public bool ShowHelp
        {
            get
            {
                return this.m_ShowHelp;
            }
            set
            {
                this.m_ShowHelp = value;
            }
        }

        public bool ShowSalary
        {
            get
            {
                return this.m_ShowSalary;
            }
            set
            {
                this.m_ShowSalary = value;
            }
        }

        public bool ShowSendMail
        {
            get
            {
                return this.m_ShowSendMail;
            }
            set
            {
                this.m_ShowSendMail = value;
            }
        }

        public bool ShowTimekeeper
        {
            get
            {
                return this.m_ShowTimekeeper;
            }
            set
            {
                this.m_ShowTimekeeper = value;
            }
        }

        public bool ShowWelcome
        {
            get
            {
                return this.m_ShowWelcome;
            }
            set
            {
                this.m_ShowWelcome = value;
            }
        }

        public bool ShowWorkdesk
        {
            get
            {
                return this.m_ShowWorkdesk;
            }
            set
            {
                this.m_ShowWorkdesk = value;
            }
        }

        public int SizeHeight
        {
            get
            {
                return this.m_SizeHeight;
            }
            set
            {
                this.m_SizeHeight = value;
            }
        }

        public int SizeWidth
        {
            get
            {
                return this.m_SizeWidth;
            }
            set
            {
                this.m_SizeWidth = value;
            }
        }

        public int Update
        {
            get
            {
                return this.m_Update;
            }
            set
            {
                this.m_Update = value;
            }
        }

        public string WindowState
        {
            get
            {
                return this.m_WindowState;
            }
            set
            {
                this.m_WindowState = value;
            }
        }

        public clsAllOption()
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\allOption.xml"));
                this.m_MonthDefault = DateTime.Parse(clsAllOption.CheckOption("MonthDefault", dataSet));
                this.m_ShowDiagram = bool.Parse(clsAllOption.CheckOption("ShowDiagram", dataSet));
                this.m_ShowWorkdesk = bool.Parse(clsAllOption.CheckOption("ShowWorkdesk", dataSet));
                this.m_ShowWelcome = bool.Parse(clsAllOption.CheckOption("ShowWelcome", dataSet));
                this.m_ShowHelp = bool.Parse(clsAllOption.CheckOption("ShowHelp", dataSet));
                this.m_ShowSendMail = bool.Parse(clsAllOption.CheckOption("ShowSendMail", dataSet));
                this.m_ShowTimekeeper = bool.Parse(clsAllOption.CheckOption("ShowTimekeeper", dataSet));
                this.m_ShowSalary = bool.Parse(clsAllOption.CheckOption("ShowSalary", dataSet));
                this.m_Update = int.Parse(clsAllOption.CheckOption("Update", dataSet));
                this.m_Minimized = bool.Parse(clsAllOption.CheckOption("Minimized", dataSet));
                this.m_WindowState = clsAllOption.CheckOption("WindowState", dataSet);
                this.m_SizeWidth = int.Parse(clsAllOption.CheckOption("SizeWidth", dataSet));
                this.m_SizeHeight = int.Parse(clsAllOption.CheckOption("SizeHeight", dataSet));
                this.m_LocationX = int.Parse(clsAllOption.CheckOption("LocationX", dataSet));
                this.m_LocationY = int.Parse(clsAllOption.CheckOption("LocationY", dataSet));
            }
            catch
            {
                this.m_MonthDefault = DateTime.Now;
                this.m_ShowDiagram = true;
                this.m_ShowWorkdesk = true;
                this.m_ShowWelcome = false;
                this.m_ShowHelp = true;
                this.m_ShowSendMail = true;
                this.m_ShowTimekeeper = true;
                this.m_ShowSalary = true;
                this.m_Update = 1;
                this.m_Minimized = false;
                this.m_WindowState = "Maximized";
                this.m_SizeWidth = 1024;
                this.m_SizeHeight = 768;
                this.m_LocationX = 0;
                this.m_LocationY = 0;
            }
        }

        public static string CheckOption(string FieldName, DataSet ds)
        {
            string str;
            try
            {
                str = ds.Tables[0].Rows[0][FieldName].ToString();
            }
            catch
            {
                str = "";
            }
            return str;
        }

        public static string CheckOption(string FieldName)
        {
            string str;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\allOption.xml"));
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
                dataTable.Columns.Add("MonthDefault", typeof(string));
                dataTable.Columns.Add("ShowDiagram", typeof(string));
                dataTable.Columns.Add("ShowWorkdesk", typeof(string));
                dataTable.Columns.Add("ShowWelcome", typeof(string));
                dataTable.Columns.Add("ShowHelp", typeof(string));
                dataTable.Columns.Add("ShowSendMail", typeof(string));
                dataTable.Columns.Add("ShowTimekeeper", typeof(string));
                dataTable.Columns.Add("ShowSalary", typeof(string));
                dataTable.Columns.Add("Update", typeof(string));
                dataTable.Columns.Add("Minimized", typeof(string));
                dataTable.Columns.Add("WindowState", typeof(string));
                dataTable.Columns.Add("SizeWidth", typeof(string));
                dataTable.Columns.Add("SizeHeight", typeof(string));
                dataTable.Columns.Add("LocationX", typeof(string));
                dataTable.Columns.Add("LocationY", typeof(string));
                object[] str = new object[] { this.m_MonthDefault.ToString(), this.m_ShowDiagram.ToString(), this.m_ShowWorkdesk.ToString(), this.m_ShowWelcome.ToString(), this.m_ShowHelp.ToString(), this.m_ShowSendMail.ToString(), this.m_ShowTimekeeper.ToString(), this.m_ShowSalary.ToString(), this.m_Update.ToString(), this.m_Minimized.ToString(), this.m_WindowState.ToString(), this.m_SizeWidth.ToString(), this.m_SizeHeight.ToString(), this.m_LocationX.ToString(), this.m_LocationY.ToString() };
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
                dataTable.Rows[0][8] = objArray[8];
                dataTable.Rows[0][9] = objArray[9];
                dataTable.Rows[0][10] = objArray[10];
                dataTable.Rows[0][11] = objArray[11];
                dataTable.Rows[0][12] = objArray[12];
                dataTable.Rows[0][13] = objArray[13];
                dataTable.Rows[0][14] = objArray[14];
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\allOption.xml"));
            }
            catch
            {
            }
        }

        public static void SaveOption(DateTime MonthDefault, bool ShowDiagram, bool ShowWorkdesk, bool ShowWelcome, bool ShowHelp, bool ShowSendMail, bool ShowTimekeeper, bool ShowSalary, int Update, bool Minimized, string WindowState, int SizeWidth, int SizeHeight, int LocationX, int LocationY)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("MonthDefault", typeof(string));
                dataTable.Columns.Add("ShowDiagram", typeof(string));
                dataTable.Columns.Add("ShowWorkdesk", typeof(string));
                dataTable.Columns.Add("ShowWelcome", typeof(string));
                dataTable.Columns.Add("ShowHelp", typeof(string));
                dataTable.Columns.Add("ShowSendMail", typeof(string));
                dataTable.Columns.Add("ShowTimekeeper", typeof(string));
                dataTable.Columns.Add("ShowSalary", typeof(string));
                dataTable.Columns.Add("Update", typeof(string));
                dataTable.Columns.Add("Minimized", typeof(string));
                dataTable.Columns.Add("WindowState", typeof(string));
                dataTable.Columns.Add("SizeWidth", typeof(string));
                dataTable.Columns.Add("SizeHeight", typeof(string));
                dataTable.Columns.Add("LocationX", typeof(string));
                dataTable.Columns.Add("LocationY", typeof(string));
                object[] str = new object[] { MonthDefault.ToString(), ShowDiagram.ToString(), ShowWorkdesk.ToString(), ShowWelcome.ToString(), ShowHelp.ToString(), ShowSendMail.ToString(), ShowTimekeeper.ToString(), ShowSalary.ToString(), Update.ToString(), Minimized.ToString(), WindowState.ToString(), SizeWidth.ToString(), SizeHeight.ToString(), LocationX.ToString(), LocationY.ToString() };
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
                dataTable.Rows[0][8] = objArray[8];
                dataTable.Rows[0][9] = objArray[9];
                dataTable.Rows[0][10] = objArray[10];
                dataTable.Rows[0][11] = objArray[11];
                dataTable.Rows[0][12] = objArray[12];
                dataTable.Rows[0][13] = objArray[13];
                dataTable.Rows[0][14] = objArray[14];
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\allOption.xml"));
            }
            catch
            {
            }
        }
    }
}
