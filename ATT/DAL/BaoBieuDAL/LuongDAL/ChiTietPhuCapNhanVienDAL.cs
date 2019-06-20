using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
 internal   class ChiTietPhuCapNhanVienDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable ChiTietPhuCapNhanVien_getByMaChamCongAndNgayAndKyHieuPhuCap(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietPhuCapNhanVienDTO.MaChamCong),
                new SqlParameter("@Ngay", _chiTietPhuCapNhanVienDTO.Ngay),
                new SqlParameter("@KyHieuPhuCap", _chiTietPhuCapNhanVienDTO.KyHieuPhuCap)
            };
            return base.executeNonQuerya("ChiTietPhuCapNhanVien_getByMaChamCongAndNgayAndKyHieuPhuCap", sqlParams);
        }

        public void Delete_ChiTietPhuCapByMaChamCong(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@IDChiTietPhuCap", _chiTietPhuCapNhanVienDTO.IDChiTietPhuCap)
            };
            base.Procedure("NHANVIEN_deleteChiTietPhuCapByMaChamCong", sqlParams);
        }

        public void InsertChiTietPhuCapNhanVien(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietPhuCapNhanVienDTO.MaChamCong),
                new SqlParameter("@MaPhuCap", _chiTietPhuCapNhanVienDTO.MaPhuCap),
                new SqlParameter("@TenPhuCap", _chiTietPhuCapNhanVienDTO.TenPhuCap),
                new SqlParameter("@SoTien", _chiTietPhuCapNhanVienDTO.SoTien),
                new SqlParameter("@Ngay", _chiTietPhuCapNhanVienDTO.Ngay),
                new SqlParameter("@KyHieuPhuCap", _chiTietPhuCapNhanVienDTO.KyHieuPhuCap)
            };
            base.Procedure("CHITIETPHUCAPNHANVIEN_add", sqlParams);
        }

        public DataTable load_ChiTietPhuCapbyMaChamCong(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietPhuCapNhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("CHITIETPHUCAPNHANVIEN_SelectbyMaChamCong", sqlParams);
        }

        public DataTable Select_ChiTietPhuCapNhanVienByMaChamCongThangNam(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietPhuCapNhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("CHITIETPHUCAPNHANVIEN_SelectbyMaChamCongThangNam", sqlParams);
        }
    }
}
