using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
  internal  class ChiTietDiCongTacBLL
    {

        private ChiTietDiCongTacDAL _chiTietDiCongTacDAL = new ChiTietDiCongTacDAL();

        public DataTable ChiTietDiCongTacGetTinhCong(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            return this._chiTietDiCongTacDAL.ChiTietDiCongTac_getTinhCong(_chiTietDiCongTacDTO);
        }

        public void DeleteChiTietDiCongTac(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            this._chiTietDiCongTacDAL.Delete_ChiTietDiCongTac(_chiTietDiCongTacDTO);
        }

        public void DeleteChiTietDiCongTacByMaChamCong(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            this._chiTietDiCongTacDAL.Delete_ChiTietDiCongTacByMaChamCong(_chiTietDiCongTacDTO);
        }

        public DataTable getChiTietDiCongTac(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            return this._chiTietDiCongTacDAL.get_ChiTietDiCongTac(_chiTietDiCongTacDTO);
        }

        public void InsertChiTietDiCongTac(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            this._chiTietDiCongTacDAL.Insert_ChiTietDiCongTac(_chiTietDiCongTacDTO);
        }
    }
}
