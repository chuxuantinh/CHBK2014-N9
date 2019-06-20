using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.HethongDTO.BackupDTO;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.HeThongDAL.BackupDAL
{
   internal class BackupDALclass:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable TuDongSaoLuu_get(BackupDTOclass _backupDTOclass)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _backupDTOclass.ID)
            };
            return base.executeNonQuerya("TuDongSaoLuu_get", sqlParams);
        }

        public DataTable TuDongSaoLuu_getAll(BackupDTOclass _backupDTOclass)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("TuDongSaoLuu_getall", sqlParams);
        }

        public void TuDongSaoLuu_Insert(BackupDTOclass _backupDTOclass)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@IDSaoLuu", _backupDTOclass.IDSaoLuu),
                new SqlParameter("@Thu", _backupDTOclass.Thu),
                new SqlParameter("@Ngay", _backupDTOclass.Ngay),
                new SqlParameter("@Gio", _backupDTOclass.Gio)
            };
            base.Procedure("TuDongSaoLuu_add", sqlParams);
        }

        public void TuDongSaoLuu_Update(BackupDTOclass _backupDTOclass)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _backupDTOclass.ID),
                new SqlParameter("@IDSaoLuu", _backupDTOclass.IDSaoLuu),
                new SqlParameter("@Thu", _backupDTOclass.Thu),
                new SqlParameter("@Ngay", _backupDTOclass.Ngay),
                new SqlParameter("@Gio", _backupDTOclass.Gio)
            };
            base.Procedure("TuDongSaoLuu_update", sqlParams);
        }
    }
}
