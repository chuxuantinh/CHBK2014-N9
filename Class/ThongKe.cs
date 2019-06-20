using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Globalization;

namespace CHBK2014_N9.Class
{
    public class ThongKe
    {
        public string OptionType { get; set; }
        public string OptionName { get; set; }

        public DataTable CT_EMPLOYEE_GetSex()
        {
            string procname = "CT_EMPLOYEE_GetSex";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_EMPLOYEE_GetAllSex()
        {
            string procname = "CT_EMPLOYEE_GetAllSex";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_EMPLOYEE_GetAge()
        {
            string procname = "CT_EMPLOYEE_GetAge";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_EMPLOYEE_GetPosition()
        {
            string procname = "CT_EMPLOYEE_GetPosition";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_EMPLOYEE_GetEducation()
        {
            string procname = "CT_EMPLOYEE_GetEducation";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        public DataTable CT_EMPLOYEE_GetNationality()
        {
            string procname = "CT_EMPLOYEE_GetNationality";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        public DataTable CT_EMPLOYEE_GetReligion()
        {
            string procname = "CT_EMPLOYEE_GetReligion";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_EMPLOYEE_GetMarriage()
        {
            string procname = "CT_EMPLOYEE_GetMarriage";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        public DataTable CT_EMPLOYEE_GetEthnic()
        {
            string procname = "CT_EMPLOYEE_GetEthnic";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_EMPLOYEE_GetStatistical()
        {
            string procname = "CT_EMPLOYEE_GetStatistical";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_EMPLOYEE_GetListBirthdayByMonth(int _Month)
        {
            string procname = "CT_EMPLOYEE_GetListBirthdayByMonth";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@Month", _Month);
            DataTable dt = db.ExecuteDataTable(procname);
            dt.Columns.Add("Day", Type.GetType("System.String"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string txt = ((DateTime)dt.Rows[i]["BirthDay"]).Day.ToString();
                if (txt.Length == 1)
                {
                    txt = "0" + txt;
                }
                dt.Rows[i]["Day"] = txt;

            }
            DataView dv = dt.DefaultView;
            dv.Sort = "Day ASC";
            dt = dv.ToTable();
            return dt;
        }
        public DataTable CT_EMPLOYEE_GetListBirthday()
        {
            string procname = "CT_EMPLOYEE_GetListBirthday";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_EMPLOYEE_GetRate()
        {
            string procname = "CT_EMPLOYEE_GetRate";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@FromYear", 2005);
            db.AddParameter("@ToYear", DateTime.Now.Year);
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_OPTION_LATEOFWORK_GetbyEmployee()
        {
            string procname = "CT_OPTION_LATEOFWORK_GetbyEmployee";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        public DataTable CT_OPTION_LATEOFWORK_GetbyDepartmentName()
        {
            string procname = "CT_OPTION_LATEOFWORK_GetbyDepartmentName";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public DataTable CT_OPTION_LATEOFWORK_GetListEmployee()
        {
            string procname = "CT_OPTION_LATEOFWORK_GetListEmployee";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }

        public bool CT_OPTION_LATEOFWORK_Insert()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();
            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@OptionType", OptionType);
                db.AddParameter("@OptionName", OptionName);
                db.ExecuteNonQueryWithTransaction("CT_OPTION_LATEOFWORK_Insert");
                db.CommitTransaction();
                return true;
            }
            catch (Exception ex)
            {
                db.RollbackTransaction();
                Class.App.Log_Write(ex.Message);
                return false;
            }
        }

        public bool CT_OPTION_LATEOFWORK_Delete()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();
            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@OptionType", OptionType);
                db.AddParameter("@OptionName", OptionName);
                db.ExecuteNonQueryWithTransaction("CT_OPTION_LATEOFWORK_Delete");
                db.CommitTransaction();
                return true;
            }
            catch (Exception ex)
            {
                db.RollbackTransaction();
                Class.App.Log_Write(ex.Message);
                return false;
            }
        }

    }
}
