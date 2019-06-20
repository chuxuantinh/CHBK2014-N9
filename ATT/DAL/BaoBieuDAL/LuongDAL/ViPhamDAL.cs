using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
   internal class ViPhamDAL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void Insert_ViPham(ViPhamDTO _viPhamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _viPhamDTO.MaChamCong),
                new SqlParameter("@ViPham", _viPhamDTO.ViPham),
                new SqlParameter("@TienPhat", _viPhamDTO.TienPhat),
                new SqlParameter("@NgayThang", _viPhamDTO.NgayThang)
            };
            base.Procedure("ViPham_add", sqlParams);
        }

        public DataTable load_ViPhamByMaChamCong(ViPhamDTO _viPhamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _viPhamDTO.MaChamCong)
            };
            return base.executeNonQuerya("ViPham_SelectbyMaChamCong", sqlParams);
        }

        public DataTable Select_ViPhamByMaChamCongThangNam(ViPhamDTO _viPhamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _viPhamDTO.MaChamCong),
                new SqlParameter("@Thang", _viPhamDTO.Thang),
                new SqlParameter("@Nam", _viPhamDTO.Nam)
            };
            return base.executeNonQuerya("ViPham_SelectbyMaChamCongThangNam", sqlParams);
        }

        public void ViPham_Delete(ViPhamDTO _viPhamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@IDViPham", _viPhamDTO.IDViPham)
            };
            base.Procedure("ViPham_Delete", sqlParams);
        }

        public void ViPham_DeleteByMaChamCong(ViPhamDTO _viPhamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _viPhamDTO.MaChamCong)
            };
            base.Procedure("ViPham_DeleteByMaChamCong", sqlParams);
        }

        public DataTable ViPham_getMaChamCongAndNgayThang(ViPhamDTO _viPhamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _viPhamDTO.MaChamCong),
                new SqlParameter("@NgayThang", _viPhamDTO.NgayThang)
            };
            return base.executeNonQuerya("ViPham_getMaChamCongAndNgayThang", sqlParams);
        }
    }
}
