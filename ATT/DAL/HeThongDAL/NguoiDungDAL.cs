using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System.Data.SqlClient;
using System.Data;

namespace CHBK2014_N9.ATT.DAL.HeThongDAL
{
   internal class NguoiDungDAL:Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public void DoiMatKhau(NguoiDungDTO _nguoiDungDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNguoiDung", _nguoiDungDTO.MaNguoiDung),
                new SqlParameter("@MatKhau", _nguoiDungDTO.MatKhau)
            };
            base.Procedure("NGUOIDUNG_DoiMatKhau", sqlParams);
        }

        public DataTable get_NguoiDung()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NguoiDung_get", sqlParams);
        }

        public DataTable get_nguoiDungByMaNguoiDung(NguoiDungDTO _nguoiDungDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNguoiDung", _nguoiDungDTO.MaNguoiDung)
            };
            return base.executeNonQuerya("NguoiDung_getByMaNguoiDung", sqlParams);
        }

        public void InsertSystemLog(NhatKyDTO _nhatKyDTO)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaNguoiDung", SqlDbType.NChar)
            {
                Value = _nhatKyDTO.MaNguoiDung
            };
            paramlist.Add(item);
            item = new SqlParameter("@ThoiGian", SqlDbType.DateTime)
            {
                Value = _nhatKyDTO.ThoiGian
            };
            paramlist.Add(item);
            item = new SqlParameter("@ChucNang", SqlDbType.NVarChar)
            {
                Value = _nhatKyDTO.ChucNang
            };
            paramlist.Add(item);
            item = new SqlParameter("@HanhDong", SqlDbType.NVarChar)
            {
                Value = _nhatKyDTO.HanhDong
            };
            paramlist.Add(item);
            item = new SqlParameter("@ThoiGianSearch", SqlDbType.NVarChar)
            {
                Value = _nhatKyDTO.ThoiGianSearch
            };
            paramlist.Add(item);
            this.dbHelper.ExecuteNonQuery("NhatKy_SetDateLoginUser", paramlist);
        }

        public void InsertSystemLog(int _MaNguoiDung, string _ChucNang, string _HanhDong, string _ThoiGianSearch)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaNguoiDung", SqlDbType.NChar)
            {
                Value = _MaNguoiDung
            };
            paramlist.Add(item);
            item = new SqlParameter("@ThoiGian", SqlDbType.DateTime)
            {
                Value = DateTime.Now.ToString()
            };
            paramlist.Add(item);
            item = new SqlParameter("@ChucNang", SqlDbType.NVarChar)
            {
                Value = _ChucNang
            };
            paramlist.Add(item);
            item = new SqlParameter("@HanhDong", SqlDbType.NVarChar)
            {
                Value = _HanhDong
            };
            paramlist.Add(item);
            item = new SqlParameter("@HanhDong", SqlDbType.NVarChar)
            {
                Value = _ThoiGianSearch
            };
            paramlist.Add(item);
            this.dbHelper.ExecuteNonQuery("NhatKy_SetDateLoginUser", paramlist);
        }

        public DataTable KiemTraMatKhau(NguoiDungDTO _nguoiDungDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNguoiDung", _nguoiDungDTO.MaNguoiDung),
                new SqlParameter("@MatKhau", _nguoiDungDTO.MatKhau)
            };
            return base.executeNonQuerya("NGUOIDUNG_KiemTraPass", sqlParams);
        }

        public DataTable LOADNGUOIDUNG()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NGUOIDUNG_getall", sqlParams);
        }

        public DataTable logIn(NguoiDungDTO _nguoiDungDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@TenDangNhap", _nguoiDungDTO.TenDangNhap),
                new SqlParameter("@MatKhau", _nguoiDungDTO.MatKhau)
            };
            DataTable table = new DataTable();
            return base.executeNonQuerya("NguoiDung_DangNhap", sqlParams);
        }

        public DataTable NguoiDung_Delete(NguoiDungDTO _nguoiDungDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNguoiDung", _nguoiDungDTO.MaNguoiDung)
            };
            return base.executeNonQuerya("NguoiDung_delete", sqlParams);
        }

        public DataTable NguoiDung_DeleteAll(NguoiDungDTO _nguoiDungDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            return base.executeNonQuerya("NGUOIDUNG_deleteAll", sqlParams);
        }

        public NhatKyDTO SelectLastLoginUser(string _MaNguoiDung)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@MaNguoiDung", SqlDbType.NChar)
            {
                Value = _MaNguoiDung
            };
            paramlist.Add(item);
            SqlDataReader reader = null;
            reader = this.dbHelper.ExecuteQuery("NhatKy_GetLastLoginUser", paramlist);
            if (reader.Read())
            {
                NhatKyDTO ydto = new NhatKyDTO(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2).ToString(), reader.GetString(3), reader.GetString(4), DateTime.Now.ToString());
                reader.Close();
                return ydto;
            }
            reader.Close();
            return null;
        }

        public NguoiDungDTO SelectUser(string _TenDangNhap, string _MatKhau)
        {
            List<SqlParameter> paramlist = new List<SqlParameter>();
            SqlParameter item = new SqlParameter();
            item = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar)
            {
                Value = _TenDangNhap.Replace("'", "''")
            };
            paramlist.Add(item);
            item = new SqlParameter("@MatKhau", SqlDbType.NVarChar)
            {
                Value = _MatKhau.Replace("'", "''")
            };
            paramlist.Add(item);
            SqlDataReader reader = null;
            reader = this.dbHelper.ExecuteQuery("GETNGUOIDUNG", paramlist);
            if (reader.Read())
            {
                NguoiDungDTO gdto = new NguoiDungDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                reader.Close();
                return gdto;
            }
            reader.Close();
            return null;
        }

        public void SuaNguoiDung(NguoiDungDTO _nguoiDungDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNguoiDung", _nguoiDungDTO.MaNguoiDung),
                new SqlParameter("@TenDangNhap", _nguoiDungDTO.TenDangNhap),
                new SqlParameter("@MatKhau", _nguoiDungDTO.MatKhau),
                new SqlParameter("@TenDayDu", _nguoiDungDTO.TenDayDu),
                new SqlParameter("@XacNhan", _nguoiDungDTO.XacNhan),
                new SqlParameter("@BanLamViecMenu", _nguoiDungDTO.BanLamViecMenu),
                new SqlParameter("@ChonDuLieuMenu", _nguoiDungDTO.ChonDuLieuMenu),
                new SqlParameter("@NhatKySuDungMenu", _nguoiDungDTO.NhatKySuDungMenu),
                new SqlParameter("@ThayDoiNguoiDungMenu", _nguoiDungDTO.ThayDoiNguoiDungMenu),
                new SqlParameter("@PhanQuyenMenu", _nguoiDungDTO.PhanQuyenMenu),
                new SqlParameter("@DoiMatKhauMenu", _nguoiDungDTO.DoiMatKhauMenu),
                new SqlParameter("@TuyChonMenu", _nguoiDungDTO.TuyChonMenu),
                new SqlParameter("@CaiDatThoiGianTaiDuLieuTuDongMenu", _nguoiDungDTO.CaiDatThoiGianTaiDuLieuTuDongMenu),
                new SqlParameter("@ChayNenMenu", _nguoiDungDTO.ChayNenMenu),
                new SqlParameter("@XoaDuLieuChamCongMenu", _nguoiDungDTO.XoaDuLieuChamCongMenu),
                new SqlParameter("@DuLieuMenu", _nguoiDungDTO.DuLieuMenu),
                new SqlParameter("@NgonNguMenu", _nguoiDungDTO.NgonNguMenu),
                new SqlParameter("@SoDoQuanLyMenu", _nguoiDungDTO.SoDoQuanLyMenu),
                new SqlParameter("@QuanLyNhanVienMenu", _nguoiDungDTO.QuanLyNhanVienMenu),
                new SqlParameter("@DanhSachNhanVienMenu", _nguoiDungDTO.DanhSachNhanVienMenu),
                new SqlParameter("@ChuyenNhanVienVaoPhongBanMenu", _nguoiDungDTO.ChuyenNhanVienVaoPhongBanMenu),
                new SqlParameter("@CapNhatNhanVienTuExcelMenu", _nguoiDungDTO.CapNhatNhanVienTuExcelMenu),
                new SqlParameter("@DangKyMenu", _nguoiDungDTO.DangKyMenu),
                new SqlParameter("@DanhMucMenu", _nguoiDungDTO.DanhMucMenu),
                new SqlParameter("@KhaiBaoMenu", _nguoiDungDTO.KhaiBaoMenu),
                new SqlParameter("@SapXepLichTrinhChoNhanVienMenu", _nguoiDungDTO.SapXepLichTrinhChoNhanVienMenu),
                new SqlParameter("@PhepNamMenu", _nguoiDungDTO.PhepNamMenu),
                new SqlParameter("@NghiCheDoMenu", _nguoiDungDTO.NghiCheDoMenu),
                new SqlParameter("@DiCongTacMenu", _nguoiDungDTO.DiCongTacMenu),
                new SqlParameter("@DangKyTangCaChoNhanVienMenu", _nguoiDungDTO.DangKyTangCaChoNhanVienMenu),
                new SqlParameter("@ChonNgayCuoiTuanMenu", _nguoiDungDTO.ChonNgayCuoiTuanMenu),
                new SqlParameter("@XuatFileTextMenu", _nguoiDungDTO.XuatFileTextMenu),
                new SqlParameter("@SuaGioGocMenu", _nguoiDungDTO.SuaGioGocMenu),
                new SqlParameter("@ThemGioMenu", _nguoiDungDTO.ThemGioMenu),
                new SqlParameter("@KhaiBaoCacLoaiNghiVaKyHieuMenu", _nguoiDungDTO.KhaiBaoCacLoaiNghiVaKyHieuMenu),
                new SqlParameter("@KhaiBaoVangChoNhanVienMenu", _nguoiDungDTO.KhaiBaoVangChoNhanVienMenu),
                new SqlParameter("@LuongCoBanMenu", _nguoiDungDTO.LuongCoBanMenu),
                new SqlParameter("@PhuCapMenu", _nguoiDungDTO.PhuCapMenu),
                new SqlParameter("@KhaiBaoPhuCapTamUngLuongChoNhanVienMenu", _nguoiDungDTO.KhaiBaoPhuCapTamUngLuongChoNhanVienMenu),
                new SqlParameter("@GioChamCongMenu", _nguoiDungDTO.GioChamCongMenu),
                new SqlParameter("@ACLogMenu", _nguoiDungDTO.ACLogMenu),
                new SqlParameter("@NhanVienHienHanhMenu", _nguoiDungDTO.NhanVienHienHanhMenu),
                new SqlParameter("@TinhCongVaLuongMenu", _nguoiDungDTO.TinhCongVaLuongMenu),
                new SqlParameter("@TaiDuLieuMenu", _nguoiDungDTO.TaiDuLieuMenu),
                new SqlParameter("@TaiNhanVienVeMayTinhMenu", _nguoiDungDTO.TaiNhanVienVeMayTinhMenu),
                new SqlParameter("@TaiDuLieuChamCongMenu", _nguoiDungDTO.TaiDuLieuChamCongMenu),
                new SqlParameter("@TaiNhanVienLenMayChamCongMenu", _nguoiDungDTO.TaiNhanVienLenMayChamCongMenu),
                new SqlParameter("@KhaiBaoMayChamCongMenu", _nguoiDungDTO.KhaiBaoMayChamCongMenu),
                new SqlParameter("@DangKyMayChamCongMenu", _nguoiDungDTO.DangKyMayChamCongMenu),
                new SqlParameter("@KetNoiNhieuMayMenu", _nguoiDungDTO.KetNoiNhieuMayMenu),
                new SqlParameter("@DuLieuChamCongTuHDDMenu", _nguoiDungDTO.DuLieuChamCongTuHDDMenu),
                new SqlParameter("@LuuDuLieuTuDongKhiChamCongMenu", _nguoiDungDTO.LuuDuLieuTuDongKhiChamCongMenu),
                new SqlParameter("@ThongTinMayChuMenu", _nguoiDungDTO.ThongTinMayChuMenu),
                new SqlParameter("@DocThuMenu", _nguoiDungDTO.DocThuMenu),
                new SqlParameter("@HuongDanSuDungMenu", _nguoiDungDTO.HuongDanSuDungMenu),
                new SqlParameter("@HoTroQuaInternetMenu", _nguoiDungDTO.HoTroQuaInternetMenu),
                new SqlParameter("@YKienPhanHoiMenu", _nguoiDungDTO.YKienPhanHoiMenu),
                new SqlParameter("@ThongTinPhanMemMenu", _nguoiDungDTO.ThongTinPhanMemMenu),
                new SqlParameter("@CapNhatPhanMemMenu", _nguoiDungDTO.CapNhatPhanMemMenu),
                new SqlParameter("@NhanVienTool", _nguoiDungDTO.NhanVienTool),
                new SqlParameter("@GioChamCongTool", _nguoiDungDTO.GioChamCongTool),
                new SqlParameter("@BaoCaoTool", _nguoiDungDTO.BaoCaoTool),
                new SqlParameter("@CaLamViecTool", _nguoiDungDTO.CaLamViecTool),
                new SqlParameter("@LichTrinhVaoRaTool", _nguoiDungDTO.LichTrinhVaoRaTool),
                new SqlParameter("@LichTrinhCaLamViecTool", _nguoiDungDTO.LichTrinhCaLamViecTool),
                new SqlParameter("@GanCaChoNhanVienTool", _nguoiDungDTO.GanCaChoNhanVienTool),
                new SqlParameter("@MayChamCongTool", _nguoiDungDTO.MayChamCongTool),
                new SqlParameter("@QuanLyMayChamCongTool", _nguoiDungDTO.QuanLyMayChamCongTool),
                new SqlParameter("@HoTroTool", _nguoiDungDTO.HoTroTool)
            };
            base.Procedure("NGUOIDUNG_update", sqlParams);
        }

        public void ThemNguoiDung(NguoiDungDTO _nguoiDungDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNguoiDung", _nguoiDungDTO.MaNguoiDung),
                new SqlParameter("@TenDangNhap", _nguoiDungDTO.TenDangNhap),
                new SqlParameter("@MatKhau", _nguoiDungDTO.MatKhau),
                new SqlParameter("@TenDayDu", _nguoiDungDTO.TenDayDu),
                new SqlParameter("@XacNhan", _nguoiDungDTO.XacNhan),
                new SqlParameter("@BanLamViecMenu", _nguoiDungDTO.BanLamViecMenu),
                new SqlParameter("@ChonDuLieuMenu", _nguoiDungDTO.ChonDuLieuMenu),
                new SqlParameter("@NhatKySuDungMenu", _nguoiDungDTO.NhatKySuDungMenu),
                new SqlParameter("@ThayDoiNguoiDungMenu", _nguoiDungDTO.ThayDoiNguoiDungMenu),
                new SqlParameter("@PhanQuyenMenu", _nguoiDungDTO.PhanQuyenMenu),
                new SqlParameter("@DoiMatKhauMenu", _nguoiDungDTO.DoiMatKhauMenu),
                new SqlParameter("@TuyChonMenu", _nguoiDungDTO.TuyChonMenu),
                new SqlParameter("@CaiDatThoiGianTaiDuLieuTuDongMenu", _nguoiDungDTO.CaiDatThoiGianTaiDuLieuTuDongMenu),
                new SqlParameter("@ChayNenMenu", _nguoiDungDTO.ChayNenMenu),
                new SqlParameter("@XoaDuLieuChamCongMenu", _nguoiDungDTO.XoaDuLieuChamCongMenu),
                new SqlParameter("@DuLieuMenu", _nguoiDungDTO.DuLieuMenu),
                new SqlParameter("@NgonNguMenu", _nguoiDungDTO.NgonNguMenu),
                new SqlParameter("@SoDoQuanLyMenu", _nguoiDungDTO.SoDoQuanLyMenu),
                new SqlParameter("@QuanLyNhanVienMenu", _nguoiDungDTO.QuanLyNhanVienMenu),
                new SqlParameter("@DanhSachNhanVienMenu", _nguoiDungDTO.DanhSachNhanVienMenu),
                new SqlParameter("@ChuyenNhanVienVaoPhongBanMenu", _nguoiDungDTO.ChuyenNhanVienVaoPhongBanMenu),
                new SqlParameter("@CapNhatNhanVienTuExcelMenu", _nguoiDungDTO.CapNhatNhanVienTuExcelMenu),
                new SqlParameter("@DangKyMenu", _nguoiDungDTO.DangKyMenu),
                new SqlParameter("@DanhMucMenu", _nguoiDungDTO.DanhMucMenu),
                new SqlParameter("@KhaiBaoMenu", _nguoiDungDTO.KhaiBaoMenu),
                new SqlParameter("@SapXepLichTrinhChoNhanVienMenu", _nguoiDungDTO.SapXepLichTrinhChoNhanVienMenu),
                new SqlParameter("@PhepNamMenu", _nguoiDungDTO.PhepNamMenu),
                new SqlParameter("@NghiCheDoMenu", _nguoiDungDTO.NghiCheDoMenu),
                new SqlParameter("@DiCongTacMenu", _nguoiDungDTO.DiCongTacMenu),
                new SqlParameter("@DangKyTangCaChoNhanVienMenu", _nguoiDungDTO.DangKyTangCaChoNhanVienMenu),
                new SqlParameter("@ChonNgayCuoiTuanMenu", _nguoiDungDTO.ChonNgayCuoiTuanMenu),
                new SqlParameter("@XuatFileTextMenu", _nguoiDungDTO.XuatFileTextMenu),
                new SqlParameter("@SuaGioGocMenu", _nguoiDungDTO.SuaGioGocMenu),
                new SqlParameter("@ThemGioMenu", _nguoiDungDTO.ThemGioMenu),
                new SqlParameter("@KhaiBaoCacLoaiNghiVaKyHieuMenu", _nguoiDungDTO.KhaiBaoCacLoaiNghiVaKyHieuMenu),
                new SqlParameter("@KhaiBaoVangChoNhanVienMenu", _nguoiDungDTO.KhaiBaoVangChoNhanVienMenu),
                new SqlParameter("@LuongCoBanMenu", _nguoiDungDTO.LuongCoBanMenu),
                new SqlParameter("@PhuCapMenu", _nguoiDungDTO.PhuCapMenu),
                new SqlParameter("@KhaiBaoPhuCapTamUngLuongChoNhanVienMenu", _nguoiDungDTO.KhaiBaoPhuCapTamUngLuongChoNhanVienMenu),
                new SqlParameter("@GioChamCongMenu", _nguoiDungDTO.GioChamCongMenu),
                new SqlParameter("@ACLogMenu", _nguoiDungDTO.ACLogMenu),
                new SqlParameter("@NhanVienHienHanhMenu", _nguoiDungDTO.NhanVienHienHanhMenu),
                new SqlParameter("@TinhCongVaLuongMenu", _nguoiDungDTO.TinhCongVaLuongMenu),
                new SqlParameter("@TaiDuLieuMenu", _nguoiDungDTO.TaiDuLieuMenu),
                new SqlParameter("@TaiNhanVienVeMayTinhMenu", _nguoiDungDTO.TaiNhanVienVeMayTinhMenu),
                new SqlParameter("@TaiDuLieuChamCongMenu", _nguoiDungDTO.TaiDuLieuChamCongMenu),
                new SqlParameter("@TaiNhanVienLenMayChamCongMenu", _nguoiDungDTO.TaiNhanVienLenMayChamCongMenu),
                new SqlParameter("@KhaiBaoMayChamCongMenu", _nguoiDungDTO.KhaiBaoMayChamCongMenu),
                new SqlParameter("@DangKyMayChamCongMenu", _nguoiDungDTO.DangKyMayChamCongMenu),
                new SqlParameter("@KetNoiNhieuMayMenu", _nguoiDungDTO.KetNoiNhieuMayMenu),
                new SqlParameter("@DuLieuChamCongTuHDDMenu", _nguoiDungDTO.DuLieuChamCongTuHDDMenu),
                new SqlParameter("@LuuDuLieuTuDongKhiChamCongMenu", _nguoiDungDTO.LuuDuLieuTuDongKhiChamCongMenu),
                new SqlParameter("@ThongTinMayChuMenu", _nguoiDungDTO.ThongTinMayChuMenu),
                new SqlParameter("@DocThuMenu", _nguoiDungDTO.DocThuMenu),
                new SqlParameter("@HuongDanSuDungMenu", _nguoiDungDTO.HuongDanSuDungMenu),
                new SqlParameter("@HoTroQuaInternetMenu", _nguoiDungDTO.HoTroQuaInternetMenu),
                new SqlParameter("@YKienPhanHoiMenu", _nguoiDungDTO.YKienPhanHoiMenu),
                new SqlParameter("@ThongTinPhanMemMenu", _nguoiDungDTO.ThongTinPhanMemMenu),
                new SqlParameter("@CapNhatPhanMemMenu", _nguoiDungDTO.CapNhatPhanMemMenu),
                new SqlParameter("@NhanVienTool", _nguoiDungDTO.NhanVienTool),
                new SqlParameter("@GioChamCongTool", _nguoiDungDTO.GioChamCongTool),
                new SqlParameter("@BaoCaoTool", _nguoiDungDTO.BaoCaoTool),
                new SqlParameter("@CaLamViecTool", _nguoiDungDTO.CaLamViecTool),
                new SqlParameter("@LichTrinhVaoRaTool", _nguoiDungDTO.LichTrinhVaoRaTool),
                new SqlParameter("@LichTrinhCaLamViecTool", _nguoiDungDTO.LichTrinhCaLamViecTool),
                new SqlParameter("@GanCaChoNhanVienTool", _nguoiDungDTO.GanCaChoNhanVienTool),
                new SqlParameter("@MayChamCongTool", _nguoiDungDTO.MayChamCongTool),
                new SqlParameter("@QuanLyMayChamCongTool", _nguoiDungDTO.QuanLyMayChamCongTool),
                new SqlParameter("@HoTroTool", _nguoiDungDTO.HoTroTool)
            };
            base.Procedure("NGUOIDUNG_add", sqlParams);
        }

        public void Xoa_TatCaNguoiDung(NguoiDungDTO _nguoiDungDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("NGUOIDUNG_deleteALL", sqlParams);
        }
    }
}
