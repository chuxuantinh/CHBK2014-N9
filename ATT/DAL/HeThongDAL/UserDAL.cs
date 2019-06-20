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
    internal class UserDAL: Provider
    {

        private DBHelper dbHelper;

        public void InsertSystemLog(NhatKyDTO _nhatKyDTO)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaNguoiDung", SqlDbType.NChar)
            {
                Value = _nhatKyDTO.MaNguoiDung
            };
            paramlist.Add(item);
            item = new SqlParameter("@ThoiGian", SqlDbType.DateTime)
            {
                Value = DateTime.Now.ToString()
            };
            paramlist.Add(item);
            item = new SqlParameter("@ChucNang", SqlDbType.NVarChar)
            {
                Value = _nhatKyDTO.ChucNang
            };
            paramlist.Add(item);
            item = new SqlParameter("@HanhDong", SqlDbType.NVarChar)
            {
                Value = _nhatKyDTO.HanhDong
            };
            paramlist.Add(item);
            this.dbHelper.ExecuteNonQuery("NhatKy_SetDateLoginUser", paramlist);
        }

        public void InsertSystemLog(int _MaNguoiDung, string _ChucNang, string _HanhDong)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaNguoiDung", SqlDbType.NChar)
            {
                Value = _MaNguoiDung
            };
            paramlist.Add(item);
            item = new SqlParameter("@ThoiGian", SqlDbType.DateTime)
            {
                Value = DateTime.Now.ToString()
            };
            paramlist.Add(item);
            item = new SqlParameter("@ChucNang", SqlDbType.NVarChar)
            {
                Value = _ChucNang
            };
            paramlist.Add(item);
            item = new SqlParameter("@HanhDong", SqlDbType.NVarChar)
            {
                Value = _HanhDong
            };
            paramlist.Add(item);
            this.dbHelper.ExecuteNonQuery("NhatKy_SetDateLoginUser", paramlist);
        }

        public DataTable logIn(UserDTO _userDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@TenDangNhap", _userDTO.TenDangNhap),
                new SqlParameter("@MatKhau", _userDTO.MatKhau)
            };
            DataTable table = new DataTable();
            return base.executeNonQuerya("NguoiDung_DangNhap", sqlParams);
        }

        public NhatKyDTO SelectLastLoginUser(string _MaNguoiDung)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaNguoiDung", SqlDbType.NChar)
            {
                Value = _MaNguoiDung
            };
            paramlist.Add(item);
            SqlDataReader reader = null;
            reader = this.dbHelper.ExecuteQuery("NhatKy_GetLastLoginUser", paramlist);
            if (reader.Read())
            {
                NhatKyDTO ydto = new NhatKyDTO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                reader.Close();
                return ydto;
            }
            reader.Close();
            return null;
        }

        public NguoiDungDTO SelectUser(string _TenDangNhap, string _MatKhau)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar)
            {
                Value = _TenDangNhap.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MatKhau", SqlDbType.NVarChar)
            {
                Value = _MatKhau.Replace("'", "''")
            };
            paramlist.Add(item);
            SqlDataReader reader = null;
            reader = this.dbHelper.ExecuteQuery("GetUser", paramlist);
            if (reader.Read())
            {
                NguoiDungDTO gdto = new NguoiDungDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                reader.Close();
                return gdto;
            }
            reader.Close();
            return null;
        }
    }
}
