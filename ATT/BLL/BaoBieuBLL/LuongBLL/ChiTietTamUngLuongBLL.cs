using CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Data;


namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL.LuongBLL
{
    internal class ChiTietTamUngLuongBLL
    {

        private ChiTietTamUngLuongDAL _chiTietTamUngLuongDAL = new ChiTietTamUngLuongDAL();

        public void ChiTietTamUngLuongDelete(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            this._chiTietTamUngLuongDAL.ChiTietTamUngLuong_Delete(_chiTietTamUngLuongDTO);
        }

        public DataTable ChiTietTamUngLuongGetMaChamCongAndNgayTamUng(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            return this._chiTietTamUngLuongDAL.ChiTietTamUngLuong_getMaChamCongAndNgayTamUng(_chiTietTamUngLuongDTO);
        }

        public void ChiTietTamUngLuongUpdate(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            this._chiTietTamUngLuongDAL.ChiTietTamUngLuong_Update(_chiTietTamUngLuongDTO);
        }

        public void DeleteChiTietTamUngLuong(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            this._chiTietTamUngLuongDAL.Delete_ChiTietTamUngLuongByMaChamCong(_chiTietTamUngLuongDTO);
        }

        public void Insert_ChiTietTamUngLuong(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            this._chiTietTamUngLuongDAL.InsertChiTietTamUngLuong(_chiTietTamUngLuongDTO);
        }

        public DataTable loadChiTietTamUngLuongByMaChamCong(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            return this._chiTietTamUngLuongDAL.load_ChiTietTamUngLuongByMaChamCong(_chiTietTamUngLuongDTO);
        }

        public DataTable SelectChiTietTamUngLuongByMaChamCongThangNam(ChiTietTamUngLuongDTO _chiTietTamUngLuongDTO)
        {
            return this._chiTietTamUngLuongDAL.Select_ChiTietTamUngLuongByMaChamCongThangNam(_chiTietTamUngLuongDTO);
        }
    }
}
