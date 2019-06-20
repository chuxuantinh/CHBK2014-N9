using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
    class CacLoaiVangDAL:Provider
    {


        private DBHelper dbHelper = new DBHelper();

        public DataTable CacLoaiVang_getByMaCacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCacLoaiVang", _cacLoaiVangDTO.MaCacLoaiVang)
            };
            return base.executeNonQuerya("CacLoaiVang_get", sqlParams);
        }

        public int InsertCacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MoTa", SqlDbType.NVarChar)
            {
                Value = _cacLoaiVangDTO.MoTa.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@KyHieu", SqlDbType.NVarChar)
            {
                Value = _cacLoaiVangDTO.KyHieu.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@SuDung", SqlDbType.Bit)
            {
                Value = _cacLoaiVangDTO.SuDung
            };
            paramlist.Add(item);
            return this.dbHelper.ExecuteNonQuery("CACLOAIVANG_add", paramlist);
        }

        public DataTable LOADCACLOAIVANG()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("CACLOAIVANG_getall", sqlParams);
        }

        public ArrayList loadCacLoaiVangLenCombobox()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("CACLOAIVANG_getall");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                CacLoaiVangDTO gdto = new CacLoaiVangDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3));
                list.Add(gdto);
            }
            reader.Close();
            return list;
        }

        public void SuaCacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCacLoaiVang", _cacLoaiVangDTO.MaCacLoaiVang),
                new SqlParameter("@MoTa", _cacLoaiVangDTO.MoTa),
                new SqlParameter("@KyHieu", _cacLoaiVangDTO.KyHieu),
                new SqlParameter("@SuDung", _cacLoaiVangDTO.SuDung)
            };
            base.Procedure("CACLOAIVANG_update", sqlParams);
        }

        public void ThemCacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCacLoaiVang", _cacLoaiVangDTO.MaCacLoaiVang),
                new SqlParameter("@MoTa", _cacLoaiVangDTO.MoTa),
                new SqlParameter("@KyHieu", _cacLoaiVangDTO.KyHieu),
                new SqlParameter("@SuDung", _cacLoaiVangDTO.SuDung)
            };
            base.Procedure("CACLOAIVANG_add", sqlParams);
        }

        public int UpdateCacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaCacLoaiVang", SqlDbType.Int)
            {
                Value = _cacLoaiVangDTO.MaCacLoaiVang
            };
            paramlist.Add(item);
            item = new SqlParameter("@MoTa", SqlDbType.NVarChar)
            {
                Value = _cacLoaiVangDTO.MoTa.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@KyHieu", SqlDbType.NVarChar)
            {
                Value = _cacLoaiVangDTO.KyHieu.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@SuDung", SqlDbType.Bit)
            {
                Value = _cacLoaiVangDTO.SuDung
            };
            paramlist.Add(item);
            return this.dbHelper.ExecuteNonQuery("CACLOAIVANG_update", paramlist);
        }

        public void XoaCacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCacLoaiVang", _cacLoaiVangDTO.MaCacLoaiVang)
            };
            base.Procedure("CACLOAIVANG_delete", sqlParams);
        }
    }
}
