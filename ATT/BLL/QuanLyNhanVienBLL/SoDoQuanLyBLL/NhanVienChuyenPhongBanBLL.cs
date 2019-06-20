using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections;
using System.Data;


namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL.SoDoQuanLyBLL
{
  internal  class NhanVienChuyenPhongBanBLL
    {
        private NhanVienChuyenPhongBanDAL _nhanVienChuyenPhongBanDAL = new NhanVienChuyenPhongBanDAL();

        public void NhanVienChuyenPhongBanDelete(NhanVienChuyenPhongBanDTO _nhanVienChuyenPhongBanDTO)
        {
            this._nhanVienChuyenPhongBanDAL.NhanVienChuyenPhongBan_Delete(_nhanVienChuyenPhongBanDTO);
        }

        public void NhanVienChuyenPhongBanInsert(NhanVienChuyenPhongBanDTO _nhanVienChuyenPhongBanDTO)
        {
            this._nhanVienChuyenPhongBanDAL.NhanVienChuyenPhongBan_Insert(_nhanVienChuyenPhongBanDTO);
        }

        public DataTable NhanVienChuyenPhongBanSelectAll()
        {
            return this._nhanVienChuyenPhongBanDAL.NhanVienChuyenPhongBan_SelectAll();
        }
    }
}
