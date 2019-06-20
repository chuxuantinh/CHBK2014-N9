using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
  internal  class SapXepLichTrinhChoNhanVienDAL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void Delete_SapXepLichTrinhChoNhanVien(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _sapXepLichTrinhChoNhanVienDTO.MaChamCong)
            };
            base.Procedure("SapXepLichTrinhChoNhanVien_delete", sqlParams);
        }

        public void Delete_SapXepLichTrinhChoNhanVienByMaChamCong(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _sapXepLichTrinhChoNhanVienDTO.MaChamCong)
            };
            base.Procedure("NHANVIEN_deleteSapXepLichTrinhChoNhanVienByMaChamCong", sqlParams);
        }

        public void DeleteAll_SapXepLichTrinhChoNhanVien(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("SapXepLichTrinhChoNhanVien_deleteAll", sqlParams);
        }

        public DataTable getSapXepLichTrinhChoNhanVienByMaChamCong(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _sapXepLichTrinhChoNhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("SapXepLichTrinhChoNhanVien_getByMaChamCong", sqlParams);
        }

        public void InsertSapXepLichTrinhChoNhanVien(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _sapXepLichTrinhChoNhanVienDTO.MaChamCong),
                new SqlParameter("@MaLichTrinhVaoRa", _sapXepLichTrinhChoNhanVienDTO.MaLichTrinhVaoRa),
                new SqlParameter("@MaLichTrinhCaLamViec", _sapXepLichTrinhChoNhanVienDTO.MaLichTrinhCaLamViec)
            };
            base.Procedure("ChiTietLichTrinhChoCaLamViec_NhanVien_add", sqlParams);
        }

        public DataTable SapSepLichTrinhChoNhanVien_GetLichTrinhVaoRa(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhVaoRa", _sapXepLichTrinhChoNhanVienDTO.MaLichTrinhVaoRa)
            };
            return base.executeNonQuerya("SapXepLichTrinhChoCaLamViec_GetLichTrinhVaoRa", sqlParams);
        }

        public DataTable SapXepLichTrinhChoNhanVien_GetLichTrinhCaLamViec(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _sapXepLichTrinhChoNhanVienDTO.MaLichTrinhCaLamViec)
            };
            return base.executeNonQuerya("SapXepLichTrinhChoCaLamViec_GetLichTrinhCaLamViec", sqlParams);
        }
    }
}
