using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
   internal class ChiTietCongTruLuongDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void ChiTietCongTruLuong_Delete(ChiTietCongTruLuongDTO _chiTietCongTruLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("ChiTietCongTruLuong_delete", sqlParams);
        }

        public DataTable ChiTietCongTruLuong_getByMaChamCong(ChiTietCongTruLuongDTO _chiTietCongTruLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietCongTruLuongDTO.MaChamCong)
            };
            return base.executeNonQuerya("ChiTietCongTruLuong_getByMaChamCong", sqlParams);
        }

        public void ChiTietCongTruLuong_Insert(ChiTietCongTruLuongDTO _chiTietCongTruLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietCongTruLuongDTO.MaChamCong),
                new SqlParameter("@ChiTietPhuCapCom", _chiTietCongTruLuongDTO.ChiTietPhuCapCom),
                new SqlParameter("@ChiTietPhuCapKhac", _chiTietCongTruLuongDTO.ChiTietPhuCapKhac),
                new SqlParameter("@ChiTietTamUngLuong", _chiTietCongTruLuongDTO.ChiTietTamUngLuong),
                new SqlParameter("@ChiTietViPham", _chiTietCongTruLuongDTO.ChiTietViPham),
                new SqlParameter("@ChiTietThuong", _chiTietCongTruLuongDTO.ChiTietThuong)
            };
            base.Procedure("ChiTietCongTruLuong_add", sqlParams);
        }
    }
}
