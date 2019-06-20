using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CHBK2014_N9.Class
{
 public   class Danhmuc_Chucvu
    {

        private string _PositionCode;

        public string PositionCode
        {
            get { return _PositionCode; }
            set { _PositionCode = value; }
        }
        private string _PositionName;

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }
        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private bool _IsManager;

        public bool IsManager
        {
            get { return _IsManager; }
            set { _IsManager = value; }
        }
        private bool _Active;
        
        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
        }

        public DataTable GetAlllist_Position()
        {
            string Procname = "CT_POSITION_GetList";
            DbAccess db = new DbAccess() ;
            db.CreateNewSqlCommand();
        return    db.ExecuteDataTable(Procname);



        }

        public string GetNewCode()
        {
            string procname = "CT_POSITION_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            DataTable dt = db.ExecuteDataTable(procname);
            if (dt.Rows.Count > 0)
            {
                string _strCode = dt.Rows[dt.Rows.Count - 1][0].ToString();
                _strCode = _strCode.Substring(2, _strCode.Length - 2);
                int next_id = int.Parse(_strCode) + 1;
                switch (next_id.ToString().Length)
                {
                    case 1:
                        return "CV00000" + next_id.ToString();
                    case 2:
                        return "CV0000" + next_id.ToString();
                    case 3:
                        return "CV000" + next_id.ToString();
                    case 4:
                        return "CV00" + next_id.ToString();
                    case 5:
                        return "CV0" + next_id.ToString();
                    case 6:
                        return "CV" + next_id.ToString();
                }
            }
            return "CV000001";

        }

        public DataTable GetPositionByCode(string strCode)
        {
            string procname = "CT_POSITION_Get";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@PositionCode", strCode);
            return db.ExecuteDataTable(procname);
        }

        public bool Insert()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();

            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@PositionCode", PositionCode);
                db.AddParameter("@PositionName", PositionName);
                db.AddParameter("@IsManager", IsManager);
                db.AddParameter("@Description", Description);
                db.AddParameter("@Active", Active);
                db.ExecuteNonQueryWithTransaction("CT_POSITION_Insert");
                db.CommitTransaction();
                Class.S_Log.Insert("Chức vụ", "Thêm Chức vụ " + PositionName);
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
                db.AddParameter("@PositionCode", PositionCode);
                db.AddParameter("@PositionName", PositionName);
                db.AddParameter("@IsManager", IsManager);
                db.AddParameter("@Description", Description);
                db.AddParameter("@Active", Active);
                db.ExecuteNonQueryWithTransaction("CT_POSITION_Update");
                db.CommitTransaction();
                Class.S_Log.Insert("Chức vụ", "Cập nhật Chức vụ " + PositionName);
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
                db.AddParameter("@PositionCode", PositionCode);
                db.ExecuteNonQueryWithTransaction("CT_POSITION_Delete");
                db.CommitTransaction();
                Class.S_Log.Insert("Chức vụ", "Xóa Chức vụ " + PositionCode);
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
