using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using CHBK2014_N9.ATT.DTO.MayChamCong.DuLieuMayChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL
{
    internal class NhanVienDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable get_NhanVien_GioiTinh(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCongTy", _nhanVienDTO.GioiTinh)
            };
            return base.executeNonQuerya("NHANVIEN_getGioiTinh", sqlParams);
        }

        public DataTable get_NhanVien_PhongBanByMaPhongBan(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan)
            };
            return base.executeNonQuerya("NhanVien_getPhongBanByMaPhongBan", sqlParams);
        }

        public DataTable get_NhanVien_TenNhanVienByMaChamCong(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("NhanVien_getTenNhanVienByMaChamCong", sqlParams);
        }

        public DataTable get_NhanVienMoi_ByMaPhongBan(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            return base.executeNonQuerya("NhanVienMoi_getPhongBanByMaPhongBan", sqlParams);
        }

        public DataTable getAllNhanVien_PhuCapTamUng()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_getAllChiTietPhuCapTamUng", sqlParams);
        }

        public DataTable getNhanVien_DanhSachNhanVien()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_getDanhSachNhanVien", sqlParams);
        }

        public DataTable getNhanVien_MaThe()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_getMaThe", sqlParams);
        }

        public DataTable getNhanVien_NhanVienHienHanh()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_getNhanVienVienHanh", sqlParams);
        }

        public DataTable getNhanVien_TienLuong()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_getTienLuong", sqlParams);
        }

        public DataTable getNhanVien_TinhCong()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_getTinhCong", sqlParams);
        }

        public DataTable getNhanVienAutoDowload(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("NHANVIEN_getAutoDowload", sqlParams);
        }

        public DataTable getNhanVienDaCoTrongCSDL()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_getall_1", sqlParams);
        }

        public DataTable getSuaGioChamCong()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_getSuaGioChamCong", sqlParams);
        }

        public void Insert_NhanVienFromDevice(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@TenChamCong", _nhanVienDTO.TenChamCong),
                new SqlParameter("@MaThe", _nhanVienDTO.MaThe),
                new SqlParameter("@UserPassWord", _nhanVienDTO.UserPassWord),
                new SqlParameter("@PhanQuyen", _nhanVienDTO.PhanQuyen),
                new SqlParameter("@UserEnable", _nhanVienDTO.UserEnable),
                new SqlParameter("@GioiTinh", _nhanVienDTO.GioiTinh),
                new SqlParameter("@NgayVaoLamViec", _nhanVienDTO.NgayVaoLamViec),
                new SqlParameter("@ChucVu", _nhanVienDTO.ChucVu),
                new SqlParameter("@NgaySinh", _nhanVienDTO.NgaySinh),
                new SqlParameter("@NoiSinh", _nhanVienDTO.NoiSinh),
                new SqlParameter("@ThoiHanHopDong", _nhanVienDTO.ThoiHanHopDong),
                new SqlParameter("@LoaiNhanVien", _nhanVienDTO.LoaiNhanVien),
                new SqlParameter("@CMND", _nhanVienDTO.CMND),
                new SqlParameter("@DienThoaiLienHe", _nhanVienDTO.DienThoaiLienHe),
                new SqlParameter("@Email", _nhanVienDTO.Email),
                new SqlParameter("@NgayPhep", _nhanVienDTO.NgayPhep),
                new SqlParameter("@TienLuong", _nhanVienDTO.TienLuong),
                new SqlParameter("@LuongHopDong", _nhanVienDTO.LuongHopDong),
                new SqlParameter("@DanToc", _nhanVienDTO.DanToc),
                new SqlParameter("@QuocTich", _nhanVienDTO.QuocTich),
                new SqlParameter("@Skype", _nhanVienDTO.Skype),
                new SqlParameter("@Yahoo", _nhanVienDTO.Yahoo),
                new SqlParameter("@Facebook", _nhanVienDTO.Facebook),
                new SqlParameter("@PassWord", _nhanVienDTO.PassWord),
                new SqlParameter("@DangThamGiaBaoHiem", _nhanVienDTO.DangThamGiaBaoHiem),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@TinhLuongTheo", _nhanVienDTO.TinhLuongTheo),
                new SqlParameter("@SanPhamOrCongDoan", _nhanVienDTO.SanPhamOrCongDoan),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NHANVIEN_add_TuMayChamCong", sqlParams);
        }

        public void Insert_NhanVienFromExcel(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@TenChamCong", _nhanVienDTO.TenChamCong),
                new SqlParameter("@MaThe", _nhanVienDTO.MaThe),
                new SqlParameter("@UserPassWord", _nhanVienDTO.UserPassWord),
                new SqlParameter("@PhanQuyen", _nhanVienDTO.PhanQuyen),
                new SqlParameter("@UserEnable", _nhanVienDTO.UserEnable),
                new SqlParameter("@GioiTinh", _nhanVienDTO.GioiTinh),
                new SqlParameter("@NgayVaoLamViec", _nhanVienDTO.NgayVaoLamViec),
                new SqlParameter("@ChucVu", _nhanVienDTO.ChucVu),
                new SqlParameter("@NgaySinh", _nhanVienDTO.NgaySinh),
                new SqlParameter("@NoiSinh", _nhanVienDTO.NoiSinh),
                new SqlParameter("@LoaiNhanVien", _nhanVienDTO.LoaiNhanVien),
                new SqlParameter("@ThoiHanHopDong", _nhanVienDTO.ThoiHanHopDong),
                new SqlParameter("@CMND", _nhanVienDTO.CMND),
                new SqlParameter("@DienThoaiLienHe", _nhanVienDTO.DienThoaiLienHe),
                new SqlParameter("@Email", _nhanVienDTO.Email),
                new SqlParameter("@NgayPhep", _nhanVienDTO.NgayPhep),
                new SqlParameter("@TienLuong", _nhanVienDTO.TienLuong),
                new SqlParameter("@LuongHopDong", _nhanVienDTO.LuongHopDong),
                new SqlParameter("@DanToc", _nhanVienDTO.DanToc),
                new SqlParameter("@QuocTich", _nhanVienDTO.QuocTich),
                new SqlParameter("@Skype", _nhanVienDTO.Skype),
                new SqlParameter("@Yahoo", _nhanVienDTO.Yahoo),
                new SqlParameter("@Facebook", _nhanVienDTO.Facebook),
                new SqlParameter("@PassWord", _nhanVienDTO.PassWord),
                new SqlParameter("@DangThamGiaBaoHiem", _nhanVienDTO.DangThamGiaBaoHiem),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@TinhLuongTheo", _nhanVienDTO.TinhLuongTheo),
                new SqlParameter("@SanPhamOrCongDoan", _nhanVienDTO.SanPhamOrCongDoan),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NhanVien_ImportFromExcel", sqlParams);
        }

        public void Insert_NhanVienFromUSB(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@TenChamCong", _nhanVienDTO.TenChamCong),
                new SqlParameter("@MaThe", _nhanVienDTO.MaThe),
                new SqlParameter("@UserPassWord", _nhanVienDTO.UserPassWord),
                new SqlParameter("@PhanQuyen", _nhanVienDTO.PhanQuyen),
                new SqlParameter("@UserEnable", _nhanVienDTO.UserEnable),
                new SqlParameter("@GioiTinh", _nhanVienDTO.GioiTinh),
                new SqlParameter("@NgayVaoLamViec", _nhanVienDTO.NgayVaoLamViec),
                new SqlParameter("@ChucVu", _nhanVienDTO.ChucVu),
                new SqlParameter("@NgaySinh", _nhanVienDTO.NgaySinh),
                new SqlParameter("@NoiSinh", _nhanVienDTO.NoiSinh),
                new SqlParameter("@LoaiNhanVien", _nhanVienDTO.LoaiNhanVien),
                new SqlParameter("@CMND", _nhanVienDTO.CMND),
                new SqlParameter("@DienThoaiLienHe", _nhanVienDTO.DienThoaiLienHe),
                new SqlParameter("@Email", _nhanVienDTO.Email),
                new SqlParameter("@NgayPhep", _nhanVienDTO.NgayPhep),
                new SqlParameter("@TienLuong", _nhanVienDTO.TienLuong),
                new SqlParameter("@LuongHopDong", _nhanVienDTO.LuongHopDong),
                new SqlParameter("@DangThamGiaBaoHiem", _nhanVienDTO.DangThamGiaBaoHiem),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@ThoiHanHopDong", _nhanVienDTO.ThoiHanHopDong),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NHANVIEN_add_TuUSB", sqlParams);
        }

        public DataTable LoadNhanVien_PhepNam()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_PhepNam", sqlParams);
        }

        public void NhanVien_ChuyenPhongBan(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@MaCongTy", _nhanVienDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _nhanVienDTO.MaKhuVuc),
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan),
                new SqlParameter("@MaChucVu", _nhanVienDTO.MaChucVu)
            };
            base.Procedure("NHANVIEN_ChuyenPhongBan", sqlParams);
        }

        public void NhanVien_ChuyenPhongBan_ChucVu(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@MaCongTy", _nhanVienDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _nhanVienDTO.MaKhuVuc),
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan),
                new SqlParameter("@MaChucVu", _nhanVienDTO.MaChucVu),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NHANVIEN_ChuyenPhongBan_ChucVu", sqlParams);
        }

        public void NhanVien_ChuyenPhongBan_CongTy(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@MaCongTy", _nhanVienDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _nhanVienDTO.MaKhuVuc),
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan),
                new SqlParameter("@MaChucVu", _nhanVienDTO.MaChucVu),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NHANVIEN_ChuyenPhongBan_CongTy", sqlParams);
        }

        public void NhanVien_ChuyenPhongBan_KhuVuc(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@MaCongTy", _nhanVienDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _nhanVienDTO.MaKhuVuc),
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan),
                new SqlParameter("@MaChucVu", _nhanVienDTO.MaChucVu),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NHANVIEN_ChuyenPhongBan_KhuVuc", sqlParams);
        }

        public void NhanVien_ChuyenPhongBan_NhanVienMoi_NghiViecTamThoi(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@MaCongTy", _nhanVienDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _nhanVienDTO.MaKhuVuc),
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan),
                new SqlParameter("@MaChucVu", _nhanVienDTO.MaChucVu),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NHANVIEN_ChuyenPhongBan_NhanVienMoi_NghiViecTamThoi", sqlParams);
        }

        public void NhanVien_ChuyenPhongBan_PhongBan(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@MaCongTy", _nhanVienDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _nhanVienDTO.MaKhuVuc),
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan),
                new SqlParameter("@MaChucVu", _nhanVienDTO.MaChucVu),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NHANVIEN_ChuyenPhongBan_PhongBan", sqlParams);
        }

        public DataTable NhanVien_DangNhap_get(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien)
            };
            return base.executeNonQuerya("NhanVien_DangNhap_get", sqlParams);
        }

        public DataTable NhanVien_getByMaChamCong(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("NhanVien_getByMaChamCong", sqlParams);
        }

        public DataTable NhanVien_getCheckInOutNhanVienHienHanh(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong)
            };
            return base.executeNonQuerya("NHANVIEN_getCheckInOutNhanVienVienHanh", sqlParams);
        }

        public DataTable NhanVien_GetChucVu(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChucVu", _nhanVienDTO.MaChucVu)
            };
            return base.executeNonQuerya("NhanVien_getChucVuByMaChucVu", sqlParams);
        }

        public DataTable NhanVien_getControl(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("NhanVien_getControl", sqlParams);
        }

        public DataTable NhanVien_getDataGirdView(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@TenChamCong", _nhanVienDTO.TenChamCong),
                new SqlParameter("@MaThe", _nhanVienDTO.MaThe)
            };
            return base.executeNonQuerya("NHANVIEN_getDataGirdView", sqlParams);
        }

        public DataTable NhanVien_getFromTreeView(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCongTy", _nhanVienDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _nhanVienDTO.MaKhuVuc),
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan),
                new SqlParameter("@MaChucVu", _nhanVienDTO.MaChucVu)
            };
            return base.executeNonQuerya("NhanVien_getFromTreeview", sqlParams);
        }

        public DataTable NhanVien_getFromTreeviewNghiViecTamThoi(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi)
            };
            return base.executeNonQuerya("NhanVien_getFromTreeviewNghiViecTamThoi", sqlParams);
        }

        public DataTable NhanVien_getFromTreeviewNhanVienMoi(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            return base.executeNonQuerya("NhanVien_getNhanVienMoi", sqlParams);
        }

        public DataTable NhanVien_GetKhuVuc(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKhuVuc", _nhanVienDTO.MaKhuVuc)
            };
            return base.executeNonQuerya("NhanVien_getKhuVucByMaKhuVuc", sqlParams);
        }

        public DataTable NhanVien_getTemplate(TemplateDTO _templateDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _templateDTO.MaChamCong)
            };
            return base.executeNonQuerya("NHANVIEN_getTEMPLATE", sqlParams);
        }

        public DataTable NhanVien_Search(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien)
            };
            return base.executeNonQuerya("NhanVien_Search", sqlParams);
        }

        public DataTable NhanVien_SearchNhanVienTaiLenMCC(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien)
            };
            return base.executeNonQuerya("NhanVien_SearchTaiNhanVienLenMCC", sqlParams);
        }

        public DataTable NhanVien_SearchQuanLyNhanVien(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien)
            };
            return base.executeNonQuerya("NhanVien_SearchQuanLyNhanVien", sqlParams);
        }

        public DataTable NhanVien_SearchTinhCong(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien)
            };
            return base.executeNonQuerya("NhanVien_SearchTinhCong", sqlParams);
        }

        public DataTable NhanVien_SearchXemGio(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("NhanVien_SearchXemGio", sqlParams);
        }

        public DataTable NhanVien_SelectNghiViecTamThoi(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi)
            };
            return base.executeNonQuerya("NhanVien_getNhanVienNghiViecTamThoi", sqlParams);
        }

        public void NhanVien_UpdateNhanVienFromExcel(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien),
                new SqlParameter("@TenChamCong", _nhanVienDTO.TenChamCong)
            };
            base.Procedure("NHANVIEN_updateNhanVienFromExcel", sqlParams);
        }

        public void NhanVien_UpdateToanBoNhanVien(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@MaThe", _nhanVienDTO.MaThe),
                new SqlParameter("@UserPassWord", _nhanVienDTO.UserPassWord),
                new SqlParameter("@PhanQuyen", _nhanVienDTO.PhanQuyen)
            };
            base.Procedure("NHANVIEN_updateToanBoNhanVien", sqlParams);
        }

        public DataTable Select_NhanVienXuatFileDAT()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_deleteFingerByMaChamCong", sqlParams);
        }

        public DataTable SelectAllNhanVien()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_getall", sqlParams);
        }

        public DataTable Show_Picture(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("NHANVIEN_getPictureNew", sqlParams);
        }

        public DataTable Show_PictureNew(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong)
            };
            return base.executeNonQuerya("NHANVIEN_getPictureNew", sqlParams);
        }

        public void Sua_HinhAnh(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@HinhAnh", _nhanVienDTO.HinhAnh)
            };
            base.Procedure("NHANVIEN_updateHinhAnh", sqlParams);
        }

        public void Sua_NhanVien(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@TenChamCong", _nhanVienDTO.TenChamCong),
                new SqlParameter("@MaThe", _nhanVienDTO.MaThe),
                new SqlParameter("@UserPassWord", _nhanVienDTO.UserPassWord),
                new SqlParameter("@PhanQuyen", _nhanVienDTO.PhanQuyen),
                new SqlParameter("@UserEnable", _nhanVienDTO.UserEnable),
                new SqlParameter("@GioiTinh", _nhanVienDTO.GioiTinh),
                new SqlParameter("@NgayVaoLamViec", _nhanVienDTO.NgayVaoLamViec),
                new SqlParameter("@ChucVu", _nhanVienDTO.ChucVu),
                new SqlParameter("@NgaySinh", _nhanVienDTO.NgaySinh),
                new SqlParameter("@NoiSinh", _nhanVienDTO.NoiSinh),
                new SqlParameter("@LoaiNhanVien", _nhanVienDTO.LoaiNhanVien),
                new SqlParameter("@CMND", _nhanVienDTO.CMND),
                new SqlParameter("@DienThoaiLienHe", _nhanVienDTO.DienThoaiLienHe),
                new SqlParameter("@Email", _nhanVienDTO.Email),
                new SqlParameter("@NgayPhep", _nhanVienDTO.NgayPhep),
                new SqlParameter("@HinhAnh", _nhanVienDTO.HinhAnh),
                new SqlParameter("@DanToc", _nhanVienDTO.DanToc),
                new SqlParameter("@QuocTich", _nhanVienDTO.QuocTich),
                new SqlParameter("@Skype", _nhanVienDTO.Skype),
                new SqlParameter("@Yahoo", _nhanVienDTO.Yahoo),
                new SqlParameter("@Facebook", _nhanVienDTO.Facebook),
                new SqlParameter("@DangThamGiaBaoHiem", _nhanVienDTO.DangThamGiaBaoHiem),
                new SqlParameter("@NgayCap", _nhanVienDTO.NgayCap),
                new SqlParameter("@NoiCap", _nhanVienDTO.NoiCap),
                new SqlParameter("@NgayKyHopDong", _nhanVienDTO.NgayKyHopDong),
                new SqlParameter("@ThoiHanHopDong", _nhanVienDTO.ThoiHanHopDong),
                new SqlParameter("@TrinhDo", _nhanVienDTO.TrinhDo),
                new SqlParameter("@GhiChu", _nhanVienDTO.GhiChu)
            };
            base.Procedure("NHANVIEN_update", sqlParams);
        }

        public DataTable TaiNhanVienLenMayChamCong()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NHANVIEN_TaiLenMayChamCong", sqlParams);
        }

        public void Them_NhanVien(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@TenChamCong", _nhanVienDTO.TenChamCong),
                new SqlParameter("@MaThe", _nhanVienDTO.MaThe),
                new SqlParameter("@UserPassWord", _nhanVienDTO.UserPassWord),
                new SqlParameter("@PhanQuyen", _nhanVienDTO.PhanQuyen),
                new SqlParameter("@UserEnable", _nhanVienDTO.UserEnable),
                new SqlParameter("@GioiTinh", _nhanVienDTO.GioiTinh),
                new SqlParameter("@NgayVaoLamViec", _nhanVienDTO.NgayVaoLamViec),
                new SqlParameter("@ChucVu", _nhanVienDTO.ChucVu),
                new SqlParameter("@NgaySinh", _nhanVienDTO.NgaySinh),
                new SqlParameter("@NoiSinh", _nhanVienDTO.NoiSinh),
                new SqlParameter("@LoaiNhanVien", _nhanVienDTO.LoaiNhanVien),
                new SqlParameter("@CMND", _nhanVienDTO.CMND),
                new SqlParameter("@DienThoaiLienHe", _nhanVienDTO.DienThoaiLienHe),
                new SqlParameter("@Email", _nhanVienDTO.Email),
                new SqlParameter("@NgayPhep", _nhanVienDTO.NgayPhep),
                new SqlParameter("@HinhAnh", _nhanVienDTO.HinhAnh),
                new SqlParameter("@TienLuong", _nhanVienDTO.TienLuong),
                new SqlParameter("@LuongHopDong", _nhanVienDTO.LuongHopDong),
                new SqlParameter("@DanToc", _nhanVienDTO.DanToc),
                new SqlParameter("@QuocTich", _nhanVienDTO.QuocTich),
                new SqlParameter("@Skype", _nhanVienDTO.Skype),
                new SqlParameter("@Yahoo", _nhanVienDTO.Yahoo),
                new SqlParameter("@Facebook", _nhanVienDTO.Facebook),
                new SqlParameter("@PassWord", _nhanVienDTO.PassWord),
                new SqlParameter("@DangThamGiaBaoHiem", _nhanVienDTO.DangThamGiaBaoHiem),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@TinhLuongTheo", _nhanVienDTO.TinhLuongTheo),
                new SqlParameter("@SanPhamOrCongDoan", _nhanVienDTO.SanPhamOrCongDoan),
                new SqlParameter("@NgayCap", _nhanVienDTO.NgayCap),
                new SqlParameter("@NoiCap", _nhanVienDTO.NoiCap),
                new SqlParameter("@NgayKyHopDong", _nhanVienDTO.NgayKyHopDong),
                new SqlParameter("@ThoiHanHopDong", _nhanVienDTO.ThoiHanHopDong),
                new SqlParameter("@TrinhDo", _nhanVienDTO.TrinhDo),
                new SqlParameter("@GhiChu", _nhanVienDTO.GhiChu),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NHANVIEN_add", sqlParams);
        }

        public void Update_BoPhan(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@MaCongTy", _nhanVienDTO.MaCongTy),
                new SqlParameter("@MaKhuVuc", _nhanVienDTO.MaKhuVuc),
                new SqlParameter("@MaPhongBan", _nhanVienDTO.MaPhongBan),
                new SqlParameter("@MaChucVu", _nhanVienDTO.MaChucVu)
            };
            base.Procedure("NHANVIEN_updateBoPhan", sqlParams);
        }

        public void Update_MaTheByNhanVien(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("MaThe", _nhanVienDTO.MaThe)
            };
            base.Procedure("NHANVIEN_updateMaThe", sqlParams);
        }

        public void Update_NhanVien_TienLuong(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@TienLuong", _nhanVienDTO.TienLuong),
                new SqlParameter("@LuongHopDong", _nhanVienDTO.LuongHopDong),
                new SqlParameter("@TinhLuongTheo", _nhanVienDTO.TinhLuongTheo),
                new SqlParameter("@SanPhamOrCongDoan", _nhanVienDTO.SanPhamOrCongDoan)
            };
            base.Procedure("NHANVIEN_updateTienLuong", sqlParams);
        }

        public void Update_NhanVienLamViecTroLai(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi)
            };
            base.Procedure("NhanVien_updateLamViecTroLai", sqlParams);
        }

        public void Update_NhanVienNghiViecTamThoi(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@NghiViecTamThoi", _nhanVienDTO.NghiViecTamThoi),
                new SqlParameter("@NhanVienMoi", _nhanVienDTO.NhanVienMoi)
            };
            base.Procedure("NHANVIEN_updateNhanVienNghiViecTamThoi", sqlParams);
        }

        public void XoaNhanVien(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong)
            };
            base.Procedure("NHANVIEN_delete", sqlParams);
        }

        public void XoaTatCaNhanVien(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("NHANVIEN_deleteAll", sqlParams);
        }
    }
}
