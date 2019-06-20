using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using CHBK2014_N9.ATT.DTO.MayChamCong.DuLieuMayChamCongDTO;
using System;
using System.Collections;
using System.Data;



namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL
{
  internal  class NhanVienBLL
    {
        private NhanVienDAL _nhanVienDAL = new NhanVienDAL();

        public DataTable get_NhanVienGioiTinh(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.get_NhanVien_GioiTinh(_nhanVienDTO);
        }

        public DataTable get_NhanVienMoi_ByMaPhongBan(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.get_NhanVienMoi_ByMaPhongBan(_nhanVienDTO);
        }

        public DataTable get_NhanVienPhongBanByMaPhongBan(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.get_NhanVien_PhongBanByMaPhongBan(_nhanVienDTO);
        }

        public DataTable get_NhanVienTenNhanVienByMaChamCong(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.get_NhanVien_TenNhanVienByMaChamCong(_nhanVienDTO);
        }

        public DataTable GetAllNhanVien()
        {
            return this._nhanVienDAL.SelectAllNhanVien();
        }

        public DataTable GetAllNhanVien_NhanVienHienHanh()
        {
            return this._nhanVienDAL.getNhanVien_NhanVienHienHanh();
        }

        public DataTable GetAllNhanVien_PhuCapTamUng()
        {
            return this._nhanVienDAL.getAllNhanVien_PhuCapTamUng();
        }

        public DataTable GetALLNhanVien_TienLuong()
        {
            return this._nhanVienDAL.getNhanVien_TienLuong();
        }

        public DataTable GetAllNhanVien_TinhCong()
        {
            return this._nhanVienDAL.getNhanVien_TinhCong();
        }

        public DataTable getCheckInOutNhanVienHienHanh(CheckInOutDTO _checkInOutDTO)
        {
            return this._nhanVienDAL.NhanVien_getCheckInOutNhanVienHienHanh(_checkInOutDTO);
        }

        public DataTable GetDanhSachNhanVien()
        {
            return this._nhanVienDAL.getNhanVien_DanhSachNhanVien();
        }

        public DataTable getNhanVienCoTrongCSDL()
        {
            return this._nhanVienDAL.getNhanVienDaCoTrongCSDL();
        }

        public DataTable getNhanVienMaThe()
        {
            return this._nhanVienDAL.getNhanVien_MaThe();
        }

        public DataTable getTemplateNhanVien(TemplateDTO _templateDTO)
        {
            return this._nhanVienDAL.NhanVien_getTemplate(_templateDTO);
        }

        public void InsertNhanVienFromDevice(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Insert_NhanVienFromDevice(_nhanVienDTO);
        }

        public void InsertNhanVienFromExcel(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Insert_NhanVienFromExcel(_nhanVienDTO);
        }

        public void InsertNhanVienFromUSB(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Insert_NhanVienFromUSB(_nhanVienDTO);
        }

        public DataTable NhanVien_PhepNam()
        {
            return this._nhanVienDAL.LoadNhanVien_PhepNam();
        }

        public void NhanVienChuyenPhongBan(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.NhanVien_ChuyenPhongBan(_nhanVienDTO);
        }

        public void NhanVienChuyenPhongBan_ChucVu(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.NhanVien_ChuyenPhongBan_ChucVu(_nhanVienDTO);
        }

        public void NhanVienChuyenPhongBan_CongTy(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.NhanVien_ChuyenPhongBan_CongTy(_nhanVienDTO);
        }

        public void NhanVienChuyenPhongBan_KhuVuc(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.NhanVien_ChuyenPhongBan_KhuVuc(_nhanVienDTO);
        }

        public void NhanVienChuyenPhongBan_NhanVienMoi_NghiViecTamThoi(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.NhanVien_ChuyenPhongBan_NhanVienMoi_NghiViecTamThoi(_nhanVienDTO);
        }

        public void NhanVienChuyenPhongBan_PhongBan(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.NhanVien_ChuyenPhongBan_PhongBan(_nhanVienDTO);
        }

        public DataTable NhanVienDangNhap_get(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_DangNhap_get(_nhanVienDTO);
        }

        public DataTable NhanVienGetByMaChamCong(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_getByMaChamCong(_nhanVienDTO);
        }

        public DataTable NhanVienGetChucVu(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_GetChucVu(_nhanVienDTO);
        }

        public DataTable NhanVienGetControl(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_getControl(_nhanVienDTO);
        }

        public DataTable NhanVienGetDataGirdView(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_getDataGirdView(_nhanVienDTO);
        }

        public DataTable NhanViengetFromTreeview(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_getFromTreeView(_nhanVienDTO);
        }

        public DataTable NhanViengetFromTreeviewNhanVienMoi(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_getFromTreeviewNhanVienMoi(_nhanVienDTO);
        }

        public DataTable NhanViengetFromTreeviewNhanVienNghiViec(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_getFromTreeviewNghiViecTamThoi(_nhanVienDTO);
        }

        public DataTable NhanVienGetKhuVuc(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_GetKhuVuc(_nhanVienDTO);
        }

        public DataTable NhanVienSearch(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_Search(_nhanVienDTO);
        }

        public DataTable NhanVienSearchQuanLyNhanVien(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_SearchQuanLyNhanVien(_nhanVienDTO);
        }

        public DataTable NhanVienSearchTaiNhanVienLenMCC(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_SearchNhanVienTaiLenMCC(_nhanVienDTO);
        }

        public DataTable NhanVienSearchTinhCong(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_SearchTinhCong(_nhanVienDTO);
        }

        public DataTable NhanVienSearchXemGio(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_SearchXemGio(_nhanVienDTO);
        }

        public DataTable NhanVienSelectNghiViecTamThoi(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.NhanVien_SelectNghiViecTamThoi(_nhanVienDTO);
        }

        public void NhanVienUpdateNhanVienFromExcel(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.NhanVien_UpdateNhanVienFromExcel(_nhanVienDTO);
        }

        public void NhanVienUpdateToanBoNhanVien(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.NhanVien_UpdateToanBoNhanVien(_nhanVienDTO);
        }

        public DataTable SelectNhanVienXuatFileDAT()
        {
            return this._nhanVienDAL.Select_NhanVienXuatFileDAT();
        }

        public DataTable show_SuaGioChamCong(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.getSuaGioChamCong();
        }

        public DataTable showHinhAnh(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.Show_Picture(_nhanVienDTO);
        }

        public DataTable showHinhAnhNew(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.Show_PictureNew(_nhanVienDTO);
        }

        public DataTable showNhanVienAutoDowload(NhanVienDTO _nhanVienDTO)
        {
            return this._nhanVienDAL.getNhanVienAutoDowload(_nhanVienDTO);
        }

        public void Sua_NhanVien_TienLuong(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Update_NhanVien_TienLuong(_nhanVienDTO);
        }

        public void SuaHinhAnhNhanVien(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Sua_HinhAnh(_nhanVienDTO);
        }

        public void SuaNhanVien(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Sua_NhanVien(_nhanVienDTO);
        }

        public DataTable TaiNhanVienLenMCC()
        {
            return this._nhanVienDAL.TaiNhanVienLenMayChamCong();
        }

        public void THEMNHANVIEN(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Them_NhanVien(_nhanVienDTO);
        }

        public void UpdateBoPhan(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Update_BoPhan(_nhanVienDTO);
        }

        public void UpdateMaTheByNhanVien(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Update_MaTheByNhanVien(_nhanVienDTO);
        }

        public void UpdateNhanVienLamViecTroLai(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Update_NhanVienLamViecTroLai(_nhanVienDTO);
        }

        public void UpdateNhanVienNghiViecTamThoi(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.Update_NhanVienNghiViecTamThoi(_nhanVienDTO);
        }

        public void Xoa_NhanVien(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.XoaNhanVien(_nhanVienDTO);
        }

        public void Xoa_TatCaNhanVien(NhanVienDTO _nhanVienDTO)
        {
            this._nhanVienDAL.XoaTatCaNhanVien(_nhanVienDTO);
        }
    }
}
