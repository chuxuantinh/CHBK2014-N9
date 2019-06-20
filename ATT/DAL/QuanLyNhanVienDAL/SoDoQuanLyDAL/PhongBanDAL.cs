
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL
{
 internal   class PhongBanDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable get_TenPhongBanByMaPhongBan(PhongBanDTO _phongBanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhongBan", _phongBanDTO.MaPhongBan)
            };
            return base.executeNonQuerya("PhongBan_getTenPhongBanByMaPhongBan", sqlParams);
        }

        public DataTable getAllPhongBan_TenPhongBan()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("PhongBan_getAllTenPhongBan", sqlParams);
        }

        public DataTable GETPHONGBANTREEVIEW(PhongBanDTO _phongBanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKhuVuc", _phongBanDTO.MaKhuVuc)
            };
            return base.executeNonQuerya("PHONGBAN_getKHUVUC", sqlParams);
        }

        public void Insert_PhongBan(PhongBanDTO _phongBanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhongBan", _phongBanDTO.MaPhongBan),
                new SqlParameter("@MaCongTy", _phongBanDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _phongBanDTO.MaKhuVuc),
                new SqlParameter("@TenPhongBan", _phongBanDTO.TenPhongBan),
                new SqlParameter("@SoTienSanLuong", _phongBanDTO.SoTienSanLuong)
            };
            base.Procedure("PHONGBAN_add", sqlParams);
        }

        public DataTable LoadPhongBan()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("PHONGBAN_getall", sqlParams);
        }

        public void PhongBan_Delete(PhongBanDTO _phongBanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhongBan", _phongBanDTO.MaPhongBan)
            };
            base.Procedure("PhongBan_delete", sqlParams);
        }

        public DataTable PhongBan_getKhuVuc(PhongBanDTO _phongBanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKhuVuc", _phongBanDTO.MaKhuVuc)
            };
            return base.executeNonQuerya("PHONGBAN_getKHUVUC", sqlParams);
        }

        public DataTable PhongBan_getTreeview(PhongBanDTO _phongBanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@TenPhongBan", _phongBanDTO.TenPhongBan)
            };
            return base.executeNonQuerya("PhongBan_getTreeView", sqlParams);
        }

        public ArrayList SelectAllPhongBan(string _tenPhongBan)
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("PHONGBAN_getAll_1 N'%" + _tenPhongBan.Replace("'", "''") + "%'");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                PhongBanDTO ndto = new PhongBanDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                list.Add(ndto);
            }
            reader.Close();
            return list;
        }

        public ArrayList SelectAllPhongBan_1()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("PHONGBAN_getall");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                PhongBanDTO ndto = new PhongBanDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                list.Add(ndto);
            }
            reader.Close();
            return list;
        }

        public int SuaPhongBan(PhongBanDTO _phongBanDTO)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaPhongBan", SqlDbType.NChar)
            {
                Value = _phongBanDTO.MaPhongBan.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaCongTy", SqlDbType.NChar)
            {
                Value = _phongBanDTO.MaCongTy.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaKhuVuc", SqlDbType.NChar)
            {
                Value = _phongBanDTO.MaKhuVuc.Replace("'", "'")
            };
            paramlist.Add(item);
            item = new SqlParameter("@TenPhongBan", SqlDbType.NVarChar)
            {
                Value = _phongBanDTO.TenPhongBan.Replace("'", "'")
            };
            paramlist.Add(item);
            return this.dbHelper.ExecuteNonQuery("PHONGBAN_update", paramlist);
        }

        public int ThemPhongBan(PhongBanDTO _phongBanDTO)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaPhongBan", SqlDbType.NChar)
            {
                Value = _phongBanDTO.MaPhongBan.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaCongTy", SqlDbType.NChar)
            {
                Value = _phongBanDTO.MaCongTy.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MaKhuVuc", SqlDbType.NChar)
            {
                Value = _phongBanDTO.MaKhuVuc.Replace("'", "'")
            };
            paramlist.Add(item);
            item = new SqlParameter("@TenPhongBan", SqlDbType.NVarChar)
            {
                Value = _phongBanDTO.TenPhongBan.Replace("'", "'")
            };
            paramlist.Add(item);
            return this.dbHelper.ExecuteNonQuery("PHONGBAN_add", paramlist);
        }

        public void Update_PhongBan(PhongBanDTO _phongBanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhongBan", _phongBanDTO.MaPhongBan),
                new SqlParameter("@MaCongTy", _phongBanDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _phongBanDTO.MaKhuVuc),
                new SqlParameter("@TenPhongBan", _phongBanDTO.TenPhongBan),
                new SqlParameter("@SoTienSanLuong", _phongBanDTO.SoTienSanLuong)
            };
            base.Procedure("PHONGBAN_update", sqlParams);
        }
    }
}
