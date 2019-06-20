using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
  internal  class BacLuongTNCN_DAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void BacLuongTNCN_Insert(BacLuongTNCN_DTO _bacLuongTNCN_DTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@Bac", _bacLuongTNCN_DTO.Bac),
                new SqlParameter("@Tu", _bacLuongTNCN_DTO.Tu),
                new SqlParameter("@Den", _bacLuongTNCN_DTO.Den),
                new SqlParameter("@ThueSuat", _bacLuongTNCN_DTO.ThueSuat),
                new SqlParameter("@TienTru", _bacLuongTNCN_DTO.TienTru)
            };
            base.Procedure("BacLuongTNCN_add", sqlParams);
        }

        public DataTable BacLuongTNCN_Select()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            return base.executeNonQuerya("BacLuongTNCN_getall", sqlParams);
        }

        public void BacLuongTNCN_Update(BacLuongTNCN_DTO _bacLuongTNCN_DTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@Bac", _bacLuongTNCN_DTO.Bac),
                new SqlParameter("@Tu", _bacLuongTNCN_DTO.Tu),
                new SqlParameter("@Den", _bacLuongTNCN_DTO.Den),
                new SqlParameter("@ThueSuat", _bacLuongTNCN_DTO.ThueSuat),
                new SqlParameter("@TienTru", _bacLuongTNCN_DTO.TienTru)
            };
            base.Procedure("BacLuongTNCN_update", sqlParams);
        }
    }
}
