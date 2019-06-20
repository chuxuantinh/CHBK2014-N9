using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL
{
  internal  class NhanVienDangNhapDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable KiemTraNhanVien_MatKhau(NhanVienDangNhapDTO _nhanVienDangNhapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDangNhapDTO.MaNhanVien),
                new SqlParameter("@PassWord", _nhanVienDangNhapDTO.PassWord)
            };
            return base.executeNonQuerya("NhanVien_DangNhap_KiemTraPass", sqlParams);
        }

        public DataTable logInNhanVien(NhanVienDangNhapDTO _nhanVienDangNhapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDangNhapDTO.MaNhanVien),
                new SqlParameter("@PassWord", _nhanVienDangNhapDTO.PassWord)
            };
            DataTable table = new DataTable();
            return base.executeNonQuerya("NhanVien_DangNhap", sqlParams);
        }

        public void NhanVienDangNhap_DoiMatKhau(NhanVienDangNhapDTO _nhanVienDangNhapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDangNhapDTO.MaNhanVien),
                new SqlParameter("@PassWord", _nhanVienDangNhapDTO.PassWord)
            };
            base.Procedure("NhanVien_DangNhap_DoiMatKhau", sqlParams);
        }

        public NhanVienDangNhapDTO SelectUserNhanVien(string _MaNhanVien, string _PassWord)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaNhanVien", SqlDbType.NVarChar)
            {
                Value = _MaNhanVien.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@PassWord", SqlDbType.NVarChar)
            {
                Value = _PassWord.Replace("'", "''")
            };
            paramlist.Add(item);
            SqlDataReader reader = null;
            reader = this.dbHelper.ExecuteQuery("getNhanVien", paramlist);
            if (reader.Read())
            {
                NhanVienDangNhapDTO pdto = new NhanVienDangNhapDTO(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                reader.Close();
                return pdto;
            }
            reader.Close();
            return null;
        }
    }
}
