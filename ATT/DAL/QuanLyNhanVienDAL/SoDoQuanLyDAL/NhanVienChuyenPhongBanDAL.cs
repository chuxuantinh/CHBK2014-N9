
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL
{
   internal class NhanVienChuyenPhongBanDAL:Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public void NhanVienChuyenPhongBan_Delete(NhanVienChuyenPhongBanDTO _nhanVienChuyenPhongBanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("NhanVienChuyenPhongBan_deleteAll", sqlParams);
        }

        public void NhanVienChuyenPhongBan_Insert(NhanVienChuyenPhongBanDTO _nhanVienChuyenPhongBanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienChuyenPhongBanDTO.MaChamCong),
                new SqlParameter("@TenNhanVien", _nhanVienChuyenPhongBanDTO.TenNhanVien)
            };
            base.Procedure("NhanVienChuyenPhongBan_add", sqlParams);
        }

        public DataTable NhanVienChuyenPhongBan_SelectAll()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            return base.executeNonQuerya("NhanVienChuyenPhongBan_getall", sqlParams);
        }
    }
}
