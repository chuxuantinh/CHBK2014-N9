using CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL.LuongBLL
{
  internal   class ChiTietCongTruLuongBLL
    {

        private ChiTietCongTruLuongDAL _chiTietCongTruLuongDAL = new ChiTietCongTruLuongDAL();

        public void ChiTietCongTruLuongDelete(ChiTietCongTruLuongDTO _chiTietCongTruLuongDTO)
        {
            this._chiTietCongTruLuongDAL.ChiTietCongTruLuong_Delete(_chiTietCongTruLuongDTO);
        }

        public DataTable ChiTietCongTruLuongGetByMaChamCong(ChiTietCongTruLuongDTO _chiTietCongTruLuongDTO)
        {
            return this._chiTietCongTruLuongDAL.ChiTietCongTruLuong_getByMaChamCong(_chiTietCongTruLuongDTO);
        }

        public void ChiTietCongTruLuongInsert(ChiTietCongTruLuongDTO _chiTietCongTruLuongDTO)
        {
            this._chiTietCongTruLuongDAL.ChiTietCongTruLuong_Insert(_chiTietCongTruLuongDTO);
        }
    }
}
