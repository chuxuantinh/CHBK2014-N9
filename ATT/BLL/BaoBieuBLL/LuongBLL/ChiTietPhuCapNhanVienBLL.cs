using CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL.LuongBLL
{
  internal  class ChiTietPhuCapNhanVienBLL
    {

        private ChiTietPhuCapNhanVienDAL _chiTietPhuCapNhanVienDAL = new ChiTietPhuCapNhanVienDAL();

        public DataTable ChiTietPhuCapNhanVienGetByMaChamCongAndNgayAndKyHieuPhuCap(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            return this._chiTietPhuCapNhanVienDAL.ChiTietPhuCapNhanVien_getByMaChamCongAndNgayAndKyHieuPhuCap(_chiTietPhuCapNhanVienDTO);
        }

        public void DeleteChiTietPhuCapNhanVien(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            this._chiTietPhuCapNhanVienDAL.Delete_ChiTietPhuCapByMaChamCong(_chiTietPhuCapNhanVienDTO);
        }

        public void Insert_ChiTietPhuCapNhanVien(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            this._chiTietPhuCapNhanVienDAL.InsertChiTietPhuCapNhanVien(_chiTietPhuCapNhanVienDTO);
        }

        public DataTable loadChiTietPhuCapByMaChamCong(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            return this._chiTietPhuCapNhanVienDAL.load_ChiTietPhuCapbyMaChamCong(_chiTietPhuCapNhanVienDTO);
        }

        public DataTable SelectChiTietPhuCapNhanVienByMaChamCongThangNam(ChiTietPhuCapNhanVienDTO _chiTietPhuCapNhanVienDTO)
        {
            return this._chiTietPhuCapNhanVienDAL.Select_ChiTietPhuCapNhanVienByMaChamCongThangNam(_chiTietPhuCapNhanVienDTO);
        }
    }
}
