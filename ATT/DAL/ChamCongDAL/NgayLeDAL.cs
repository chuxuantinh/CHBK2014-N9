using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
  internal  class NgayLeDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable LOADNGAYLE()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NGAYLE_getall", sqlParams);
        }

        public DataTable NgayLe_get(NgayLeDTO _ngayLeDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNgayLe", _ngayLeDTO.MaNgayLe)
            };
            return base.executeNonQuerya("NgayLe_get", sqlParams);
        }

        public DataTable NgayLe_getTinhCong(NgayLeDTO _ngayLeDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@Ngay", _ngayLeDTO.Ngay)
            };
            return base.executeNonQuerya("NgayLe_getTinhCong", sqlParams);
        }

        public void SuaNgayLe(NgayLeDTO _ngayLeDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNgayLe", _ngayLeDTO.MaNgayLe),
                new SqlParameter("@Thang", _ngayLeDTO.Thang),
                new SqlParameter("@Nam", _ngayLeDTO.Nam),
                new SqlParameter("@Ngay", _ngayLeDTO.Ngay),
                new SqlParameter("@TenNgayLe", _ngayLeDTO.TenNgayLe),
                new SqlParameter("@CongTinh", _ngayLeDTO.CongTinh),
                new SqlParameter("@Gio", _ngayLeDTO.Gio),
                new SqlParameter("@GhiChu", _ngayLeDTO.GhiChu),
                new SqlParameter("@HeSo", _ngayLeDTO.HeSo),
                new SqlParameter("@XacNhan", _ngayLeDTO.XacNhan)
            };
            base.Procedure("NGAYLE_update", sqlParams);
        }

        public void ThemNgayLe(NgayLeDTO _ngayLeDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNgayLe", _ngayLeDTO.MaNgayLe),
                new SqlParameter("@Thang", _ngayLeDTO.Thang),
                new SqlParameter("@Nam", _ngayLeDTO.Nam),
                new SqlParameter("@Ngay", _ngayLeDTO.Ngay),
                new SqlParameter("@TenNgayLe", _ngayLeDTO.TenNgayLe),
                new SqlParameter("@CongTinh", _ngayLeDTO.CongTinh),
                new SqlParameter("@Gio", _ngayLeDTO.Gio),
                new SqlParameter("@GhiChu", _ngayLeDTO.GhiChu),
                new SqlParameter("@HeSo", _ngayLeDTO.HeSo),
                new SqlParameter("@XacNhan", _ngayLeDTO.XacNhan)
            };
            base.Procedure("NGAYLE_add", sqlParams);
        }

        public void XoaNgayLe(NgayLeDTO _ngayLeDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNgayLe", _ngayLeDTO.MaNgayLe)
            };
            base.Procedure("NGAYLE_delete", sqlParams);
        }

        public void XoaTatCaNgayLe(NgayLeDTO _ngayLeDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("NGAYLE_deleteAll", sqlParams);
        }
    }
}
