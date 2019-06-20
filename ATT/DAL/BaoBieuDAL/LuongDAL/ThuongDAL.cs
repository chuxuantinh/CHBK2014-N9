using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
internal    class ThuongDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void Thuong_DeleteByIDThuong(ThuongDTO _thuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@IDThuong", _thuongDTO.IDThuong)
            };
            base.Procedure("ChiTietThuongNhanVien_deleteByIDThuong", sqlParams);
        }

        public void Thuong_DeleteByMaChamCong(ThuongDTO _thuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _thuongDTO.MaChamCong)
            };
            base.Procedure("ChiTietThuongNhanVien_deleteByMaChamCong", sqlParams);
        }

        public DataTable Thuong_GetByMaChamCong(ThuongDTO _thuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _thuongDTO.MaChamCong)
            };
            return base.executeNonQuerya("ChiTietThuongNhanVien_getByMaChamCong", sqlParams);
        }

        public DataTable Thuong_GetByMaChamCongAndNgayThuong(ThuongDTO _thuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _thuongDTO.MaChamCong),
                new SqlParameter("@NgayThuong", _thuongDTO.NgayThuong)
            };
            return base.executeNonQuerya("ChiTietThuongNhanVien_getMaChamCongAndNgayThuong", sqlParams);
        }

        public void Thuong_Insert(ThuongDTO _thuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _thuongDTO.MaChamCong),
                new SqlParameter("@Thuong", _thuongDTO.Thuong),
                new SqlParameter("@TienThuong", _thuongDTO.TienThuong),
                new SqlParameter("@NgayThuong", _thuongDTO.NgayThuong)
            };
            base.Procedure("ChiTietThuongNhanVien_add", sqlParams);
        }
    }
}
