using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL
{
   internal class ChucVuNhanVienDAL:Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public DataTable LoadChucVuNhanVien()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("CHUCVUNHANVIEN_getall", sqlParams);
        }

        public ArrayList loadComBoBox()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("CHUCVUNHANVIEN_getall");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                ChucVuNhanVienDTO ndto = new ChucVuNhanVienDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3));
                list.Add(ndto);
            }
            reader.Close();
            return list;
        }

        public void SuaChucVuNhanVien(ChucVuNhanVienDTO _chucVuNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChucVuNhanVien", _chucVuNhanVienDTO.MaChucVuNhanVien),
                new SqlParameter("@TenChucVuNhanVien", _chucVuNhanVienDTO.TenChucVuNhanVien),
                new SqlParameter("@GhiChu", _chucVuNhanVienDTO.GhiChu),
                new SqlParameter("@TinhTrang", _chucVuNhanVienDTO.TinhTrang)
            };
            base.Procedure("CHUCVUNHANVIEN_update", sqlParams);
        }

        public void ThemChucVuNhanVien(ChucVuNhanVienDTO _chucVuNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChucVuNhanVien", _chucVuNhanVienDTO.MaChucVuNhanVien),
                new SqlParameter("@TenChucVuNhanVien", _chucVuNhanVienDTO.TenChucVuNhanVien),
                new SqlParameter("@GhiChu", _chucVuNhanVienDTO.GhiChu),
                new SqlParameter("@TinhTrang", _chucVuNhanVienDTO.TinhTrang)
            };
            base.Procedure("CHUCVUNHANVIEN_add", sqlParams);
        }

        public void XoaChucVuNhanVien(ChucVuNhanVienDTO _chucVuNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChucVuNhanVien", _chucVuNhanVienDTO.MaChucVuNhanVien)
            };
            base.Procedure("CHUCVUNHANVIEN_delete", sqlParams);
        }
    }
}
