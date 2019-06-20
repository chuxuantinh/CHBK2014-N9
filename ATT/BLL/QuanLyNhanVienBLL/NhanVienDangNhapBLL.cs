using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL
{
  internal  class NhanVienDangNhapBLL
    {
        private NhanVienDangNhapDAL _nhanVienDangNhapDAL = new NhanVienDangNhapDAL();

        public NhanVienDangNhapDTO GetUserNhanVien(string _MaNhanVien, string _PassWord)
        {
            return this._nhanVienDangNhapDAL.SelectUserNhanVien(_MaNhanVien, _PassWord);
        }

        public void NhanVienDangNhapDoiMatKhau(NhanVienDangNhapDTO _nhanVienDangNhapDTO)
        {
            this._nhanVienDangNhapDAL.NhanVienDangNhap_DoiMatKhau(_nhanVienDangNhapDTO);
        }

        public DataTable NhanVienDangNhapKiemTraPass(NhanVienDangNhapDTO _nhanVienDangNhapDTO)
        {
            return this._nhanVienDangNhapDAL.KiemTraNhanVien_MatKhau(_nhanVienDangNhapDTO);
        }

        public DataTable testLoginNhanVien(NhanVienDangNhapDTO _nhanVienDangNhapDTO)
        {
            return this._nhanVienDangNhapDAL.logInNhanVien(_nhanVienDangNhapDTO);
        }
    }
}
