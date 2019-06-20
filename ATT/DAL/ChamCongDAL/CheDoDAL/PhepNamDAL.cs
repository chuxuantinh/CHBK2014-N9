using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO.CheDoDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL.CheDoDAL
{
  internal class PhepNamDAL:Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public void Delete_PhepNamByID(PhepNamDTO _phepNamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _phepNamDTO.ID)
            };
            base.Procedure("PhepNam_deleteByID", sqlParams);
        }

        public void Delete_PhepNamByMaChamCong(PhepNamDTO _phepNamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _phepNamDTO.MaChamCong)
            };
            base.Procedure("NHANVIEN_deletePhepNamByMaChamCong", sqlParams);
        }

        public void DeleteAll_PhepNamByMaChamCong(PhepNamDTO _phepNamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _phepNamDTO.MaChamCong)
            };
            base.Procedure("PhepNam_deleteByMaChamCong", sqlParams);
        }

        public DataTable LoadPhepNam()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("PHEPNAM_getall", sqlParams);
        }

        public DataTable PhepNam_getTinhCong(PhepNamDTO _phepNamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _phepNamDTO.MaChamCong),
                new SqlParameter("@Ngay", _phepNamDTO.Ngay)
            };
            return base.executeNonQuerya("PhepNam_getTinhCong", sqlParams);
        }

        public DataTable Select_PhepNamByMaChamCong(PhepNamDTO _phepNamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _phepNamDTO.MaChamCong)
            };
            return base.executeNonQuerya("PhepNam_SelectByMaChamCong", sqlParams);
        }

        public void ThemPhepNam(PhepNamDTO _phepNamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _phepNamDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _phepNamDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _phepNamDTO.MaChamCong),
                new SqlParameter("@Ngay", _phepNamDTO.Ngay),
                new SqlParameter("@DemCong", _phepNamDTO.DemCong),
                new SqlParameter("@DemGio", _phepNamDTO.DemGio),
                new SqlParameter("@Nghi", _phepNamDTO.Nghi)
            };
            base.Procedure("PHEPNAM_add", sqlParams);
        }

        public void XoaPhepNam(PhepNamDTO _phepNamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _phepNamDTO.MaChamCong)
            };
            base.Procedure("PHEPNAM_delete", sqlParams);
        }

        public void XoaTatCaPhepNam(PhepNamDTO _phepNamDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("PHEPNAM_deleteAll", sqlParams);
        }
    }
}
