using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.DanhMucDTO;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.DanhMucDAL
{
  internal  class TrinhDoDAL :Provider    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable Load_TrinhDo()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("TrinhDo_getall", sqlParams);
        }

        public void TrinhDo_Insert(TrinhDoDTO _trinhDoDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaTrinhDo", _trinhDoDTO.MaTrinhDo),
                new SqlParameter("@TrinhDo", _trinhDoDTO.TrinhDo)
            };
            base.Procedure("TrinhDo_add", sqlParams);
        }

        public void TrinhDo_Update(TrinhDoDTO _trinhDoDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaTrinhDo", _trinhDoDTO.MaTrinhDo),
                new SqlParameter("@TrinhDo", _trinhDoDTO.TrinhDo)
            };
            base.Procedure("TrinhDo_update", sqlParams);
        }
    }
}
