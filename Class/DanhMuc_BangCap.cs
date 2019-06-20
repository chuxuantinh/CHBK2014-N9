using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CHBK2014_N9.Class
{
public class DanhMuc_BangCap
    {

        #region  khai bao
        private string _DegreeCode;

        public string DegreeCode
        {
            get { return _DegreeCode; }
            set { _DegreeCode = value; }
        }
        private string _DegreeName;

        public string DegreeName
        {
            get { return _DegreeName; }
            set { _DegreeName = value; }
        }
        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private bool _Active;

        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
        #endregion

        public DataTable Loadbangcap()
        {

            string procedname = "CT_DEGREE_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procedname);
            
        }

        public string GetNewCode()
        {

            string Procedname = "";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            DataTable dt = db.ExecuteDataTable(Procedname);
            if (dt.Rows.Count >0)
            {

                string strcode = dt.Rows[dt.Rows.Count - 1][0].ToString();
                strcode = strcode.Substring(2, strcode.Length - 2);
                int nextid = int.Parse(strcode + 1);

                switch (nextid.ToString().Length)
                {
                    case 1:
                        return "BC00000" + nextid.ToString();
                    case 2:
                        return "BC0000" + nextid.ToString();
                    case 3:
                        return "BC000" + nextid.ToString();
                    case 4:
                        return "BC00" + nextid.ToString();
                    case 5:
                        return "BC0" + nextid.ToString();
                    case 6:
                        return "BC" + nextid.ToString();

                }
            }
            return "BC00001";

        }


        public DataTable GetDegreeByCode(string strCode)
        {
            string procname = "CT_DEGREE_Get";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@DegreeCode", strCode);
            return db.ExecuteDataTable(procname);
        }

        public bool Insert()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();
            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@DegreeCode", DegreeCode);
                db.AddParameter("@DegreeName", DegreeName);
                db.AddParameter("@Description", Description);
                db.AddParameter("@Active", Active);
                db.ExecuteNonQueryWithTransaction("CT_DEGREE_Insert");
                db.CommitTransaction();
                Class.S_Log.Insert("Bằng Cấp", "Thêm bằng cấp: " + DegreeName);
                return true;
            }
            catch (Exception ex)
            {
                db.RollbackTransaction();
                Class.App.Log_Write(ex.Message);
                return false;
            }
        }

        public bool Update()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();
            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@DegreeCode", DegreeCode);
                db.AddParameter("@DegreeName", DegreeName);
                db.AddParameter("@Description", Description);
                db.AddParameter("@Active", Active);
                db.ExecuteNonQueryWithTransaction("CT_DEGREE_Update");
                db.CommitTransaction();
                Class.S_Log.Insert("Bằng Cấp", "Cập nhật bằng cấp: " + DegreeName);
                return true;
            }
            catch (Exception ex)
            {
                db.RollbackTransaction();
                Class.App.Log_Write(ex.Message);
                return false;
            }
        }

        public bool Delete()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();
            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@DegreeCode", DegreeCode);
                db.ExecuteNonQueryWithTransaction("CT_DEGREE_Delete");
                db.CommitTransaction();
                Class.S_Log.Insert("Bằng Cấp", "Xóa bằng cấp: " + DegreeCode);
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
