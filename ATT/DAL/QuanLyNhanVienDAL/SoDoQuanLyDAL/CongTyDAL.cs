using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL
{
  internal  class CongTyDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable CongTy_getTreeView(CongTyDTO _congTyDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@TenCongTy", _congTyDTO.TenCongTy)
            };
            return base.executeNonQuerya("CongTy_getTreeView", sqlParams);
        }

        public DataTable getCongTy(CongTyDTO _congTyDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("CONGTY_getall", sqlParams);
        }

        public DataTable getLoadCongTy(CongTyDTO _congTyDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCongTy", _congTyDTO.MaCongTy)
            };
            return base.executeNonQuerya("CONGTY_get", sqlParams);
        }

        public void SuaCongTy(CongTyDTO _congTyDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCongTy", _congTyDTO.MaCongTy),
                new SqlParameter("@TenCongTy", _congTyDTO.TenCongTy),
                new SqlParameter("@DiaChi", _congTyDTO.DiaChi),
                new SqlParameter("@DienThoai", _congTyDTO.DienThoai),
                new SqlParameter("@Fax", _congTyDTO.Fax),
                new SqlParameter("@MaSoThue", _congTyDTO.MaSoThue),
                new SqlParameter("@Website", _congTyDTO.Website),
                new SqlParameter("@Email", _congTyDTO.Email),
                new SqlParameter("@Logo", _congTyDTO.Logo)
            };
            base.Procedure("CONGTY_update", sqlParams);
        }

        public void ThemCongTy(CongTyDTO _congTyDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCongTy", _congTyDTO.MaCongTy),
                new SqlParameter("@TenCongTy", _congTyDTO.TenCongTy),
                new SqlParameter("@DiaChi", _congTyDTO.DiaChi),
                new SqlParameter("@DienThoai", _congTyDTO.DienThoai),
                new SqlParameter("@Fax", _congTyDTO.Fax),
                new SqlParameter("@MaSoThue", _congTyDTO.MaSoThue),
                new SqlParameter("@Website", _congTyDTO.Website),
                new SqlParameter("@Email", _congTyDTO.Email),
                new SqlParameter("@Logo", _congTyDTO.Logo)
            };
            base.Procedure("CONGTY_add", sqlParams);
        }
    }
}
