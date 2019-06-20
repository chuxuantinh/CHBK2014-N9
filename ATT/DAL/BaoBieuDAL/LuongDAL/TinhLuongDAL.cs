using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
   internal class TinhLuongDAL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void TinhLuong_Delete(TinhLuongDTO _tinhLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("TinhLuong_delete", sqlParams);
        }

        public void TinhLuong_Insert(TinhLuongDTO _tinhLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _tinhLuongDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _tinhLuongDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _tinhLuongDTO.MaChamCong),
                new SqlParameter("@LuongCoBanBaoHiem", _tinhLuongDTO.LuongCoBanBaoHiem),
                new SqlParameter("@LuongHopDong", _tinhLuongDTO.LuongHopDong),
                new SqlParameter("@NgayCongTinh", _tinhLuongDTO.NgayCongTinh),
                new SqlParameter("@NgayCongLamDuoc", _tinhLuongDTO.NgayCongLamDuoc),
                new SqlParameter("@SoGioTangCa", _tinhLuongDTO.SoGioTangCa),
                new SqlParameter("@LuongNgayCongLamDuoc", _tinhLuongDTO.LuongNgayCongLamDuoc),
                new SqlParameter("@TienTangCa", _tinhLuongDTO.TienTangCa),
                new SqlParameter("@PhuCapTienCom", _tinhLuongDTO.PhuCapTienCom),
                new SqlParameter("@PhuCapTienComTheoNgayCong", _tinhLuongDTO.PhuCapTienComTheoNgayCong),
                new SqlParameter("@PhuCapKhac", _tinhLuongDTO.PhuCapKhac),
                new SqlParameter("@Thuong", _tinhLuongDTO.Thuong),
                new SqlParameter("@TongLuong", _tinhLuongDTO.TongLuong),
                new SqlParameter("@BHXH", _tinhLuongDTO.BHXH),
                new SqlParameter("@BHYT", _tinhLuongDTO.BHYT),
                new SqlParameter("@BHTN", _tinhLuongDTO.BHTN),
                new SqlParameter("@TamUng", _tinhLuongDTO.TamUng),
                new SqlParameter("@ViPham", _tinhLuongDTO.ViPham),
                new SqlParameter("@TongTienTruVaoLuong", _tinhLuongDTO.TongTienTruVaoLuong),
                new SqlParameter("@LuongThucLanh", _tinhLuongDTO.LuongThucLanh)
            };
            base.Procedure("TinhLuong_add", sqlParams);
        }

        public DataTable TinhLuong_SelectAll(TinhLuongDTO _tinhLuongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            return base.executeNonQuerya("TinhLuong_getall", sqlParams);
        }
    }
}
