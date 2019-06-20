using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL
{
  internal  class ChucVuDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void ChucVu_Delete(ChucVuDTO _chucVuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChucVu", _chucVuDTO.MaChucVu)
            };
            base.Procedure("ChucVu_delete", sqlParams);
        }

        public DataTable ChucVu_getPhongBan(ChucVuDTO _chucVuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhongBan", _chucVuDTO.MaPhongBan)
            };
            return base.executeNonQuerya("CHUCVU_getPHONGBAN", sqlParams);
        }

        public DataTable ChucVu_getTenChucVuByMaChucVu(ChucVuDTO _chucVuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChucVu", _chucVuDTO.MaChucVu)
            };
            return base.executeNonQuerya("ChucVu_getTenChucVuByMaChucVu", sqlParams);
        }

        public DataTable ChucVu_getTreeView(ChucVuDTO _chucVuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@TenChucVu", _chucVuDTO.TenChucVu)
            };
            return base.executeNonQuerya("ChucVu_getTreeView", sqlParams);
        }

        public DataTable GETCHUCVUTREEVIEW(ChucVuDTO _chucVuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhongBan", _chucVuDTO.MaPhongBan)
            };
            return base.executeNonQuerya("CHUCVU_getPHONGBAN", sqlParams);
        }

        public void Insert_ChucVu(ChucVuDTO _chucVuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChucVu", _chucVuDTO.MaChucVu),
                new SqlParameter("@MaCongTy", _chucVuDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _chucVuDTO.MaKhuVuc),
                new SqlParameter("@MaPhongBan", _chucVuDTO.MaPhongBan),
                new SqlParameter("@TenChucVu", _chucVuDTO.TenChucVu)
            };
            base.Procedure("CHUCVU_add", sqlParams);
        }

        public DataTable LoadChucVu()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("CHUCVU_getall", sqlParams);
        }

        public ArrayList SelectAllChucVu(string _tenChucVu)
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("CHUCVU_getAll_1 N'%" + _tenChucVu.Replace("'", "''") + "%'");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                ChucVuDTO udto = new ChucVuDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                list.Add(udto);
            }
            reader.Close();
            return list;
        }

        public int SuaChucVu(ChucVuDTO _chucVuDTO)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaChucVu", SqlDbType.NChar)
            {
                Value = _chucVuDTO.MaChucVu.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaCongTy", SqlDbType.NChar)
            {
                Value = _chucVuDTO.MaCongTy.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaKhuVuc", SqlDbType.NChar)
            {
                Value = _chucVuDTO.MaKhuVuc.Replace("'", "'")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaPhongBan", SqlDbType.NChar)
            {
                Value = _chucVuDTO.MaPhongBan.Replace("'", "'")
            };
            paramlist.Add(item);
            item = new SqlParameter("@TenChucVu", SqlDbType.NVarChar)
            {
                Value = _chucVuDTO.TenChucVu.Replace("'", "'")
            };
            paramlist.Add(item);
            return this.dbHelper.ExecuteNonQuery("CHUCVU_update", paramlist);
        }

        public int ThemChucVu(ChucVuDTO _chucVuDTO)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaChucVu", SqlDbType.NChar)
            {
                Value = _chucVuDTO.MaChucVu.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaCongTy", SqlDbType.NChar)
            {
                Value = _chucVuDTO.MaCongTy.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaKhuVuc", SqlDbType.NChar)
            {
                Value = _chucVuDTO.MaKhuVuc.Replace("'", "'")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaPhongBan", SqlDbType.NChar)
            {
                Value = _chucVuDTO.MaPhongBan.Replace("'", "'")
            };
            paramlist.Add(item);
            item = new SqlParameter("@TenChucVu", SqlDbType.NVarChar)
            {
                Value = _chucVuDTO.TenChucVu.Replace("'", "'")
            };
            paramlist.Add(item);
            return this.dbHelper.ExecuteNonQuery("CHUCVU_add", paramlist);
        }
    }
}
