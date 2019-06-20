using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
   internal class KhaiBaoVangChoNhanVienDAL:Provider
    {


        private DBHelper dbHelper = new DBHelper();

        public DataTable CacLoaiVang_getTinhCong(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _khaiBaoVangChoNhanVienDTO.MaChamCong),
                new SqlParameter("@NgayThang", _khaiBaoVangChoNhanVienDTO.NgayThang)
            };
            return base.executeNonQuerya("CacLoaiVang_getTinhCong", sqlParams);
        }

        public void Delete_KhaiBaoVangChoNhanVien(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _khaiBaoVangChoNhanVienDTO.ID)
            };
            base.Procedure("KhaiBaoVangChoNhanVien_delete", sqlParams);
        }

        public void Delete_KhaiBaoVangChoNhanVienByMaChamCong(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _khaiBaoVangChoNhanVienDTO.MaChamCong)
            };
            base.Procedure("NHANVIEN_DeleteKhaiBaoVangChoNhanVienByMaChamCong", sqlParams);
        }

        public void DeleteAll_KhaiBaoVangChoNhanVien(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _khaiBaoVangChoNhanVienDTO.MaChamCong)
            };
            base.Procedure("KhaiBaoVangChoNhanVien_deleteAll", sqlParams);
        }

        public DataTable getKhaiBaoBaoVangChoNhanVien(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _khaiBaoVangChoNhanVienDTO.MaChamCong),
                new SqlParameter("@Nam", _khaiBaoVangChoNhanVienDTO.Nam),
                new SqlParameter("@Thang", _khaiBaoVangChoNhanVienDTO.Thang)
            };
            return base.executeNonQuerya("KhaiBaoVangChoNhanVien_get", sqlParams);
        }

        public void Insert_KhaiBaoVangChoNhanVien(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _khaiBaoVangChoNhanVienDTO.MaChamCong),
                new SqlParameter("@Nam", _khaiBaoVangChoNhanVienDTO.Nam),
                new SqlParameter("@Thang", _khaiBaoVangChoNhanVienDTO.Thang),
                new SqlParameter("@NgayThang", _khaiBaoVangChoNhanVienDTO.NgayThang),
                new SqlParameter("@MaCacLoaiVang", _khaiBaoVangChoNhanVienDTO.MaCacLoaiVang),
                new SqlParameter("@ApDung", _khaiBaoVangChoNhanVienDTO.ApDung),
                new SqlParameter("@TongPhut", _khaiBaoVangChoNhanVienDTO.TongPhut),
                new SqlParameter("@NgayCong", _khaiBaoVangChoNhanVienDTO.NgayCong),
                new SqlParameter("@GhiChu", _khaiBaoVangChoNhanVienDTO.GhiChu),
                new SqlParameter("@DuocHuongLuong", _khaiBaoVangChoNhanVienDTO.DuocHuongLuong)
            };
            base.Procedure("KhaiBaoVangChoNhanVien_add", sqlParams);
        }
    }
}
