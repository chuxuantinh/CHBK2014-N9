using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL
{
  internal  class TinhThanhDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public ArrayList loadComBoBox()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("TINHTHANH_getall");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                TinhThanhDTO hdto = new TinhThanhDTO(reader.GetString(0), reader.GetString(1), reader.GetBoolean(2));
                list.Add(hdto);
            }
            reader.Close();
            return list;
        }

        public DataTable LoadTinhThanh()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("TINHTHANH_getall", sqlParams);
        }

        public void SuaTinhThanh(TinhThanhDTO _tinhThanhDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaTinhThanh", _tinhThanhDTO.MaTinhThanh),
                new SqlParameter("@TenTinhThanh", _tinhThanhDTO.TenTinhThanh),
                new SqlParameter("@TinhTrang", _tinhThanhDTO.TinhTrang)
            };
            base.Procedure("TINHTHANH_update", sqlParams);
        }

        public void ThemTinhThanh(TinhThanhDTO _tinhThanhDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaTinhThanh", _tinhThanhDTO.MaTinhThanh),
                new SqlParameter("@TenTinhThanh", _tinhThanhDTO.TenTinhThanh),
                new SqlParameter("@TinhTrang", _tinhThanhDTO.TinhTrang)
            };
            base.Procedure("TINHTHANH_add", sqlParams);
        }

        public void XoaTinhThanh(TinhThanhDTO _tinhThanhDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaTinhThanh", _tinhThanhDTO.MaTinhThanh)
            };
            base.Procedure("TINHTHANH_delete", sqlParams);
        }
    }
}
