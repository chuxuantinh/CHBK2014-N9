using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System.Data.SqlClient;
using System.Data;

namespace CHBK2014_N9.ATT.DAL.HeThongDAL
{
  internal  class NhatKyDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public int DelSystemLog(int _ID)
        {
            return this.dbHelper.ExecuteNonQuery("NhatKy_DelSystemLogByID " + _ID);
        }

        public void NhatKy_Delete(NhatKyDTO _nhatKyDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("NhatKyHeThong_deleteAll", sqlParams);
        }

        public void NhatKyHeThong_DeleteByThoiGian(NhatKyDTO _nhatKyDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ThoiGianSearch", _nhatKyDTO.ThoiGianSearch)
            };
            base.Procedure("NhatKyHeThong_deleteByThoiGian", sqlParams);
        }

        public DataTable NhatKyHeThong_getALL()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NhatKyHeThong_getall", sqlParams);
        }

        public DataTable NhatKyHeThong_Search(NhatKyDTO _nhatKyDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ThoiGianSearch", _nhatKyDTO.ThoiGianSearch)
            };
            return base.executeNonQuerya("NhatKyHeThong_Search", sqlParams);
        }

        public DataTable NhatKyHeThong_ThoiGian(NhatKyDTO _nhatKyDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@FromDate", _nhatKyDTO.FromDate),
                new SqlParameter("@ToDate", _nhatKyDTO.ToDate)
            };
            return base.executeNonQuerya("NhatKyHeThong_getallByThoiGian", sqlParams);
        }
    }
}
