using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
  internal  class ChiTietTamUngLuongDAL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void ChiTietTamUngLuong_Delete(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@IDTamUngLuong", _chiTietTamUngLuongDTO.IDTamUngLuong)
            };
            base.Procedure("ChiTietTamUngLuong_delete", sqlParams);
        }

        public DataTable ChiTietTamUngLuong_getMaChamCongAndNgayTamUng(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietTamUngLuongDTO.MaChamCong),
                new SqlParameter("@NgayTamUng", _chiTietTamUngLuongDTO.NgayTamUng)
            };
            return base.executeNonQuerya("ChiTietTamUngLuong_getMaChamCongAndNgayTamUng", sqlParams);
        }

        public void ChiTietTamUngLuong_Update(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietTamUngLuongDTO.MaChamCong),
                new SqlParameter("@SoTien", _chiTietTamUngLuongDTO.SoTien),
                new SqlParameter("@LyDo", _chiTietTamUngLuongDTO.LyDo),
                new SqlParameter("@NgayTamUng", _chiTietTamUngLuongDTO.NgayTamUng)
            };
            base.Procedure("ChiTietTamUngLuong_update", sqlParams);
        }

        public void Delete_ChiTietTamUngLuongByMaChamCong(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietTamUngLuongDTO.MaChamCong)
            };
            base.Procedure("NHANVIEN_deleteChiTietTamUngLuongByMaChamCong", sqlParams);
        }

        public void InsertChiTietTamUngLuong(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietTamUngLuongDTO.MaChamCong),
                new SqlParameter("@SoTien", _chiTietTamUngLuongDTO.SoTien),
                new SqlParameter("@LyDo", _chiTietTamUngLuongDTO.LyDo),
                new SqlParameter("@NgayTamUng", _chiTietTamUngLuongDTO.NgayTamUng)
            };
            base.Procedure("CHITIETTAMUNGLUONG_add", sqlParams);
        }

        public DataTable load_ChiTietTamUngLuongByMaChamCong(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietTamUngLuongDTO.MaChamCong)
            };
            return base.executeNonQuerya("CHITIETTAMUNGLUONG_SelectbyMaChamCong", sqlParams);
        }

        public DataTable Select_ChiTietTamUngLuongByMaChamCongThangNam(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietTamUngLuongDTO.MaChamCong)
            };
            return base.executeNonQuerya("CHITIETTAMUNGLUONG_SelectbyMaChamCongThangNam", sqlParams);
        }
    }
}
