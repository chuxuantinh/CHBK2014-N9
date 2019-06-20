using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System.Data.SqlClient;
using System.Data;

namespace CHBK2014_N9.ATT.DAL.HeThongDAL
{
   internal class UserNhanVienDAL:Provider
    {

        private DBHelper dbHelper;

        public DataTable logInNhanVien(UserNhanVienDTO _userNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _userNhanVienDTO.MaNhanVien),
                new SqlParameter("@PassWord", _userNhanVienDTO.PassWord)
            };
            DataTable table = new DataTable();
            return base.executeNonQuerya("NhanVien_DangNhap", sqlParams);
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
            reader = this.dbHelper.ExecuteQuery("GetUser", paramlist);
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
