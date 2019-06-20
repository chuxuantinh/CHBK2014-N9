using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL
{
   internal class KhuVucDAL :Provider    {

        private DBHelper dbHelper = new DBHelper();

        public void DELELEKHUVUC(KhuVucDTO _khuVucDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKhuVuc", _khuVucDTO.MaKhuVuc)
            };
            base.Procedure("KHUVUC_delete", sqlParams);
        }

        public DataTable get_TenKhuVucByMaKhuVuc(KhuVucDTO _khuVucDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKhuVuc", _khuVucDTO.MaKhuVuc)
            };
            return base.executeNonQuerya("PhongBan_getTenKhuVucByMaKhuVuc", sqlParams);
        }

        public DataTable getAllKhuVuc_TenKhuVuc()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("KhuVuc_getAllTenKhuVuc", sqlParams);
        }

        public DataTable GETKHUVUCTREEVIEW(KhuVucDTO _khuVucDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCongTy", _khuVucDTO.MaCongTy)
            };
            return base.executeNonQuerya("KHUVUC_getCONGTY", sqlParams);
        }

        public void KhuVuc_Delete(KhuVucDTO _khuVucDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKhuVuc", _khuVucDTO.MaKhuVuc)
            };
            base.Procedure("KhuVuc_delete", sqlParams);
        }

        public DataTable KhuVuc_getTenKhuVucByMaKhuVuc(KhuVucDTO _khuVucDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKhuVuc", _khuVucDTO.MaKhuVuc)
            };
            return base.executeNonQuerya("KhuVuc_getTenKhuVucByMaKhuVuc", sqlParams);
        }

        public DataTable KhuVuc_getTreeView(KhuVucDTO _khuVucDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@TenKhuVuc", _khuVucDTO.TenKhuVuc)
            };
            return base.executeNonQuerya("KhuVuc_getTreeView", sqlParams);
        }

        public DataTable LoadKhuVuc()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("KHUVUC_getall", sqlParams);
        }

        public ArrayList SelectAllKhuVuc()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("KHUVUC_getall");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                KhuVucDTO cdto = new KhuVucDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                list.Add(cdto);
            }
            reader.Close();
            return list;
        }

        public void SuaKhuVuc(KhuVucDTO _khuVucDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKhuVuc", _khuVucDTO.MaKhuVuc),
                new SqlParameter("@MaCongTy", _khuVucDTO.MaCongTy),
                new SqlParameter("@TenKhuVuc", _khuVucDTO.TenKhuVuc),
                new SqlParameter("@DiaChiKhuVuc", _khuVucDTO.DiaChiKhuVuc),
                new SqlParameter("@NguoiLienHe", _khuVucDTO.NguoiLienHe),
                new SqlParameter("@DienThoaiLienHe", _khuVucDTO.DienThoaiLienHe)
            };
            base.Procedure("KHUVUC_update", sqlParams);
        }

        public void ThemKhuVuc(KhuVucDTO _khuVucDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKhuVuc", _khuVucDTO.MaKhuVuc),
                new SqlParameter("@MaCongTy", _khuVucDTO.MaCongTy),
                new SqlParameter("@TenKhuVuc", _khuVucDTO.TenKhuVuc),
                new SqlParameter("@DiaChiKhuVuc", _khuVucDTO.DiaChiKhuVuc),
                new SqlParameter("@NguoiLienHe", _khuVucDTO.NguoiLienHe),
                new SqlParameter("@DienThoaiLienHe", _khuVucDTO.DienThoaiLienHe)
            };
            base.Procedure("KHUVUC_add", sqlParams);
        }
    }
}
