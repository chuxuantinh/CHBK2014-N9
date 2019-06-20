using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Class
{
   public class clsTimeKeeperOption
    {

        private int m_TimeKeeperTableDefault;

        private bool m_ShowAssignmentDialog;

        private bool m_ShowPetitionDialog;

        private bool m_AutoAssignment;

        private bool m_AutoPetition;

        private Color m_MondayColor;

        private Color m_TuesdayColor;

        private Color m_WednesdayColor;

        private Color m_ThursdayColor;

        private Color m_FridayColor;

        private Color m_SaturdayColor;

        private Color m_SundayColor;

        private Color m_HolidayColor;

        public bool AutoAssignment
        {
            get
            {
                return this.m_AutoAssignment;
            }
            set
            {
                this.m_AutoAssignment = value;
            }
        }

        public bool AutoPetition
        {
            get
            {
                return this.m_AutoPetition;
            }
            set
            {
                this.m_AutoPetition = value;
            }
        }

        public Color FridayColor
        {
            get
            {
                return this.m_FridayColor;
            }
            set
            {
                this.m_FridayColor = value;
            }
        }

        public Color HolidayColor
        {
            get
            {
                return this.m_HolidayColor;
            }
            set
            {
                this.m_HolidayColor = value;
            }
        }

        public Color MondayColor
        {
            get
            {
                return this.m_MondayColor;
            }
            set
            {
                this.m_MondayColor = value;
            }
        }

        public Color SaturdayColor
        {
            get
            {
                return this.m_SaturdayColor;
            }
            set
            {
                this.m_SaturdayColor = value;
            }
        }

        public bool ShowAssignmentDialog
        {
            get
            {
                return this.m_ShowAssignmentDialog;
            }
            set
            {
                this.m_ShowAssignmentDialog = value;
            }
        }

        public bool ShowPetitionDialog
        {
            get
            {
                return this.m_ShowPetitionDialog;
            }
            set
            {
                this.m_ShowPetitionDialog = value;
            }
        }

        public Color SundayColor
        {
            get
            {
                return this.m_SundayColor;
            }
            set
            {
                this.m_SundayColor = value;
            }
        }

        public Color ThursdayColor
        {
            get
            {
                return this.m_ThursdayColor;
            }
            set
            {
                this.m_ThursdayColor = value;
            }
        }

        public int TimeKeeperTableDefault
        {
            get
            {
                return this.m_TimeKeeperTableDefault;
            }
            set
            {
                this.m_TimeKeeperTableDefault = value;
            }
        }

        public Color TuesdayColor
        {
            get
            {
                return this.m_TuesdayColor;
            }
            set
            {
                this.m_TuesdayColor = value;
            }
        }

        public Color WednesdayColor
        {
            get
            {
                return this.m_WednesdayColor;
            }
            set
            {
                this.m_WednesdayColor = value;
            }
        }

        public clsTimeKeeperOption()
        {
            try
            {
                this.m_TimeKeeperTableDefault = int.Parse(clsTimeKeeperOption.CheckOption("TimeKeeperTableDefault"));
                this.m_ShowAssignmentDialog = bool.Parse(clsTimeKeeperOption.CheckOption("ShowAssignmentDialog"));
                this.m_ShowPetitionDialog = bool.Parse(clsTimeKeeperOption.CheckOption("ShowPetitionDialog"));
                this.m_AutoAssignment = bool.Parse(clsTimeKeeperOption.CheckOption("AutoAssignment"));
                this.m_AutoPetition = bool.Parse(clsTimeKeeperOption.CheckOption("AutoPetition"));
                this.m_MondayColor = Color.FromArgb(int.Parse(clsTimeKeeperOption.CheckOption("MondayColor").ToString()));
                this.m_TuesdayColor = Color.FromArgb(int.Parse(clsTimeKeeperOption.CheckOption("TuesdayColor").ToString()));
                this.m_WednesdayColor = Color.FromArgb(int.Parse(clsTimeKeeperOption.CheckOption("WednesdayColor").ToString()));
                this.m_ThursdayColor = Color.FromArgb(int.Parse(clsTimeKeeperOption.CheckOption("ThursdayColor").ToString()));
                this.m_FridayColor = Color.FromArgb(int.Parse(clsTimeKeeperOption.CheckOption("FridayColor").ToString()));
                this.m_SaturdayColor = Color.FromArgb(int.Parse(clsTimeKeeperOption.CheckOption("SaturdayColor").ToString()));
                this.m_SundayColor = Color.FromArgb(int.Parse(clsTimeKeeperOption.CheckOption("SundayColor").ToString()));
                this.m_HolidayColor = Color.FromArgb(int.Parse(clsTimeKeeperOption.CheckOption("HolidayColor").ToString()));
            }
            catch
            {
                this.m_TimeKeeperTableDefault = 0;
                this.m_ShowAssignmentDialog = true;
                this.m_ShowPetitionDialog = true;
                this.m_AutoAssignment = true;
                this.m_AutoPetition = true;
                this.m_MondayColor = SystemColors.Info;
                this.m_TuesdayColor = Color.SeaShell;
                this.m_WednesdayColor = SystemColors.Info;
                this.m_ThursdayColor = Color.SeaShell;
                this.m_FridayColor = SystemColors.Info;
                this.m_SaturdayColor = Color.SeaShell;
                this.m_SundayColor = Color.Azure;
                this.m_HolidayColor = Color.FromArgb(192, 255, 192);
            }
        }

        public static string CheckOption(string FieldName)
        {
            string str;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\Layout\\timeKeeperOption.xml"));
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
                dataTable.Columns.Add("TimeKeeperTableDefault", typeof(string));
                dataTable.Columns.Add("ShowAssignmentDialog", typeof(string));
                dataTable.Columns.Add("ShowPetitionDialog", typeof(string));
                dataTable.Columns.Add("AutoAssignment", typeof(string));
                dataTable.Columns.Add("AutoPetition", typeof(string));
                dataTable.Columns.Add("MondayColor", typeof(string));
                dataTable.Columns.Add("TuesdayColor", typeof(string));
                dataTable.Columns.Add("WednesdayColor", typeof(string));
                dataTable.Columns.Add("ThursdayColor", typeof(string));
                dataTable.Columns.Add("FridayColor", typeof(string));
                dataTable.Columns.Add("SaturdayColor", typeof(string));
                dataTable.Columns.Add("SundayColor", typeof(string));
                dataTable.Columns.Add("HolidayColor", typeof(string));
                object[] str = new object[] { this.m_TimeKeeperTableDefault.ToString(), this.m_ShowAssignmentDialog.ToString(), this.m_ShowPetitionDialog.ToString(), this.m_AutoAssignment.ToString(), this.m_AutoPetition.ToString(), null, null, null, null, null, null, null, null };
                int argb = this.m_MondayColor.ToArgb();
                str[5] = argb.ToString();
                argb = this.m_TuesdayColor.ToArgb();
                str[6] = argb.ToString();
                argb = this.m_WednesdayColor.ToArgb();
                str[7] = argb.ToString();
                argb = this.m_ThursdayColor.ToArgb();
                str[8] = argb.ToString();
                argb = this.m_FridayColor.ToArgb();
                str[9] = argb.ToString();
                argb = this.m_SaturdayColor.ToArgb();
                str[10] = argb.ToString();
                argb = this.m_SundayColor.ToArgb();
                str[11] = argb.ToString();
                argb = this.m_HolidayColor.ToArgb();
                str[12] = argb.ToString();
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\timeKeeperOption.xml"));
            }
            catch
            {
            }
        }

        public static void SaveOption(int TimeKeeperTableDefault, bool ShowAssignmentDialog, bool ShowPetitionDialog, bool AutoAssignment, bool AutoPetition, Color MondayColor, Color TuesdayColor, Color WednesdayColor, Color ThursdayColor, Color FridayColor, Color SaturdayColor, Color SundayColor, Color HolidayColor)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("TimeKeeperTableDefault", typeof(string));
                dataTable.Columns.Add("ShowAssignmentDialog", typeof(string));
                dataTable.Columns.Add("ShowPetitionDialog", typeof(string));
                dataTable.Columns.Add("AutoAssignment", typeof(string));
                dataTable.Columns.Add("AutoPetition", typeof(string));
                dataTable.Columns.Add("MondayColor", typeof(string));
                dataTable.Columns.Add("TuesdayColor", typeof(string));
                dataTable.Columns.Add("WednesdayColor", typeof(string));
                dataTable.Columns.Add("ThursdayColor", typeof(string));
                dataTable.Columns.Add("FridayColor", typeof(string));
                dataTable.Columns.Add("SaturdayColor", typeof(string));
                dataTable.Columns.Add("SundayColor", typeof(string));
                dataTable.Columns.Add("HolidayColor", typeof(string));
                object[] str = new object[] { TimeKeeperTableDefault.ToString(), ShowAssignmentDialog.ToString(), ShowPetitionDialog.ToString(), AutoAssignment.ToString(), AutoPetition.ToString(), null, null, null, null, null, null, null, null };
                int argb = MondayColor.ToArgb();
                str[5] = argb.ToString();
                argb = TuesdayColor.ToArgb();
                str[6] = argb.ToString();
                argb = WednesdayColor.ToArgb();
                str[7] = argb.ToString();
                argb = ThursdayColor.ToArgb();
                str[8] = argb.ToString();
                argb = FridayColor.ToArgb();
                str[9] = argb.ToString();
                argb = SaturdayColor.ToArgb();
                str[10] = argb.ToString();
                argb = SundayColor.ToArgb();
                str[11] = argb.ToString();
                argb = HolidayColor.ToArgb();
                str[12] = argb.ToString();
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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\Layout\\timeKeeperOption.xml"));
            }
            catch
            {
            }
        }

    }
}
