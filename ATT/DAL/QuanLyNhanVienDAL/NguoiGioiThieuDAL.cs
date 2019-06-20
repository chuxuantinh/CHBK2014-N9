using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL
{
    class NguoiGioiThieuDAL:Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public void NguoiGioiThieu_Insert(NguoiGioiThieuDTO _nguoiGioiThieuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nguoiGioiThieuDTO.MaNhanVien),
                new SqlParameter("@MaChamCong", _nguoiGioiThieuDTO.MaChamCong),
                new SqlParameter("@MaNguoiGioiThieu", _nguoiGioiThieuDTO.MaNguoiGioiThieu)
            };
            base.Procedure("ChiTietNguoiGioiThieu_add", sqlParams);
        }
    }
}
