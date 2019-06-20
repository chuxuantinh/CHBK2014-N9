using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
   internal class TuyChonDAL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable getLoadTuyChon(TuyChonDTO _tuyChonDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaTuyChinh", _tuyChonDTO.MaTuyChinh)
            };
            return base.executeNonQuerya("TUYCHON_get", sqlParams);
        }

        public DataTable getTuyChon(TuyChonDTO _tuyChonDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("TUYCHON_getall", sqlParams);
        }

        public void SuaTuyChon(TuyChonDTO _tuyChonDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaTuyChinh", _tuyChonDTO.MaTuyChinh),
                new SqlParameter("@ChuNhatHeSo", _tuyChonDTO.ChuNhatHeSo),
                new SqlParameter("@ThuBayHeSo", _tuyChonDTO.ThuBayHeSo),
                new SqlParameter("@NgayLeHeSo", _tuyChonDTO.NgayLeHeSo),
                new SqlParameter("@CaDemHeSo", _tuyChonDTO.CaDemHeSo),
                new SqlParameter("@TC1HeSo", _tuyChonDTO.TC1HeSo),
                new SqlParameter("@TC2HeSo", _tuyChonDTO.TC2HeSo),
                new SqlParameter("@TC3HeSo", _tuyChonDTO.TC3HeSo),
                new SqlParameter("@TC4HeSo", _tuyChonDTO.TC4HeSo),
                new SqlParameter("@GiamDoc", _tuyChonDTO.GiamDoc),
                new SqlParameter("@KeToanTruong", _tuyChonDTO.KeToanTruong),
                new SqlParameter("@ThuQuy", _tuyChonDTO.ThuQuy),
                new SqlParameter("@NguoiLapPhieu", _tuyChonDTO.NguoiLapPhieu),
                new SqlParameter("@SoTien", _tuyChonDTO.SoTien),
                new SqlParameter("@SoQuyetDinh", _tuyChonDTO.SoQuyetDinh),
                new SqlParameter("@NgayApDung", _tuyChonDTO.NgayApDung),
                new SqlParameter("@NguoiRaQuyetDinh", _tuyChonDTO.NguoiRaQuyetDinh),
                new SqlParameter("@LTTuA", _tuyChonDTO.LTTuA),
                new SqlParameter("@LTDenA", _tuyChonDTO.LTDenA),
                new SqlParameter("@LTA", _tuyChonDTO.LTA),
                new SqlParameter("@LTTuB", _tuyChonDTO.LTTuB),
                new SqlParameter("@LTDenB", _tuyChonDTO.LTDenB),
                new SqlParameter("@LTB", _tuyChonDTO.LTB),
                new SqlParameter("@LTTuC", _tuyChonDTO.LTTuC),
                new SqlParameter("@LTDenC", _tuyChonDTO.LTDenC),
                new SqlParameter("@LTC", _tuyChonDTO.LTC),
                new SqlParameter("@LTTuD", _tuyChonDTO.LTTuD),
                new SqlParameter("@LTDenD", _tuyChonDTO.LTDenD),
                new SqlParameter("@LTD", _tuyChonDTO.LTD),
                new SqlParameter("@LamTronCong", _tuyChonDTO.LamTronCong),
                new SqlParameter("@LamTronGio", _tuyChonDTO.LamTronGio),
                new SqlParameter("@BaoHiemXaHoi", _tuyChonDTO.BaoHiemXaHoi),
                new SqlParameter("@BaoHiemYTe", _tuyChonDTO.BaoHiemYTe),
                new SqlParameter("@BaoHiemThatNghiep", _tuyChonDTO.BaoHiemThatNghiep),
                new SqlParameter("@LuaChonKhaiBaoLuong", _tuyChonDTO.LuaChonKhaiBaoLuong),
                new SqlParameter("@SoTienKhaiBao", _tuyChonDTO.SoTienKhaiBao),
                new SqlParameter("@TienTangCa", _tuyChonDTO.TienTangCa),
                new SqlParameter("@TienTheoNgayCong", _tuyChonDTO.TienTheoNgayCong),
                new SqlParameter("@TienTheoSanLuong", _tuyChonDTO.TienTheoSanLuong),
                new SqlParameter("@TienSanLuong", _tuyChonDTO.TienSanLuong),
                new SqlParameter("@TienCongDoan", _tuyChonDTO.TienCongDoan),
                new SqlParameter("@DinhDangThoiGian", _tuyChonDTO.DinhDangThoiGian),
                new SqlParameter("@ThongBaoHetHanHopDong", _tuyChonDTO.ThongBaoHetHanHopDong),
                new SqlParameter("@DinhDangThoiGianHeThong", _tuyChonDTO.DinhDangThoiGianHeThong)
            };
            base.Procedure("TUYCHON_update", sqlParams);
        }

        public void ThemTuyChon(TuyChonDTO _tuyChonDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaTuyChinh", _tuyChonDTO.MaTuyChinh),
                new SqlParameter("@ChuNhatHeSo", _tuyChonDTO.ChuNhatHeSo),
                new SqlParameter("@ThuBayHeSo", _tuyChonDTO.ThuBayHeSo),
                new SqlParameter("@NgayLeHeSo", _tuyChonDTO.NgayLeHeSo),
                new SqlParameter("@CaDemHeSo", _tuyChonDTO.CaDemHeSo),
                new SqlParameter("@TC1HeSo", _tuyChonDTO.TC1HeSo),
                new SqlParameter("@TC2HeSo", _tuyChonDTO.TC2HeSo),
                new SqlParameter("@TC3HeSo", _tuyChonDTO.TC3HeSo),
                new SqlParameter("@TC4HeSo", _tuyChonDTO.TC4HeSo),
                new SqlParameter("@GiamDoc", _tuyChonDTO.GiamDoc),
                new SqlParameter("@KeToanTruong", _tuyChonDTO.KeToanTruong),
                new SqlParameter("@ThuQuy", _tuyChonDTO.ThuQuy),
                new SqlParameter("@NguoiLapPhieu", _tuyChonDTO.NguoiLapPhieu),
                new SqlParameter("@SoTien", _tuyChonDTO.SoTien),
                new SqlParameter("@SoQuyetDinh", _tuyChonDTO.SoQuyetDinh),
                new SqlParameter("@NgayApDung", _tuyChonDTO.NgayApDung),
                new SqlParameter("@NguoiRaQuyetDinh", _tuyChonDTO.NguoiRaQuyetDinh),
                new SqlParameter("@LTTuA", _tuyChonDTO.LTTuA),
                new SqlParameter("@LTDenA", _tuyChonDTO.LTDenA),
                new SqlParameter("@LTA", _tuyChonDTO.LTA),
                new SqlParameter("@LTTuB", _tuyChonDTO.LTTuB),
                new SqlParameter("@LTDenB", _tuyChonDTO.LTDenB),
                new SqlParameter("@LTB", _tuyChonDTO.LTB),
                new SqlParameter("@LTTuC", _tuyChonDTO.LTTuC),
                new SqlParameter("@LTDenC", _tuyChonDTO.LTDenC),
                new SqlParameter("@LTC", _tuyChonDTO.LTC),
                new SqlParameter("@LTTuD", _tuyChonDTO.LTTuD),
                new SqlParameter("@LTDenD", _tuyChonDTO.LTDenD),
                new SqlParameter("@LTD", _tuyChonDTO.LTD),
                new SqlParameter("@LamTronCong", _tuyChonDTO.LamTronCong),
                new SqlParameter("@LamTronGio", _tuyChonDTO.LamTronGio),
                new SqlParameter("@BaoHiemXaHoi", _tuyChonDTO.BaoHiemXaHoi),
                new SqlParameter("@BaoHiemYTe", _tuyChonDTO.BaoHiemYTe),
                new SqlParameter("@BaoHiemThatNghiep", _tuyChonDTO.BaoHiemThatNghiep),
                new SqlParameter("@LuaChonKhaiBaoLuong", _tuyChonDTO.LuaChonKhaiBaoLuong),
                new SqlParameter("@SoTienKhaiBao", _tuyChonDTO.SoTienKhaiBao),
                new SqlParameter("@TienTangCa", _tuyChonDTO.TienTangCa),
                new SqlParameter("@TienTheoNgayCong", _tuyChonDTO.TienTheoNgayCong),
                new SqlParameter("@TienTheoSanLuong", _tuyChonDTO.TienTheoSanLuong),
                new SqlParameter("@TienSanLuong", _tuyChonDTO.TienSanLuong),
                new SqlParameter("@TienCongDoan", _tuyChonDTO.TienCongDoan),
                new SqlParameter("@DinhDangThoiGian", _tuyChonDTO.DinhDangThoiGian),
                new SqlParameter("@ThongBaoHetHanHopDong", _tuyChonDTO.ThongBaoHetHanHopDong),
                new SqlParameter("@DinhDangThoiGianHeThong", _tuyChonDTO.DinhDangThoiGianHeThong)
            };
            base.Procedure("TUYCHON_add", sqlParams);
        }
    }
}
