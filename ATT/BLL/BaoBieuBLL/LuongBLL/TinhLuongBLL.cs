using CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Data;
using System.Collections;

namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL.LuongBLL
{
   internal class TinhLuongBLL
    {

        private TinhLuongDAL _tinhLuongDAL = new TinhLuongDAL();

        public void TinhLuongDelete(TinhLuongDTO _tinhLuongDTO)
        {
            this._tinhLuongDAL.TinhLuong_Delete(_tinhLuongDTO);
        }

        public void TinhLuongInsert(TinhLuongDTO _tinhLuongDTO)
        {
            this._tinhLuongDAL.TinhLuong_Insert(_tinhLuongDTO);
        }

        public DataTable TinhLuongSelectAll(TinhLuongDTO _tinhLuongDTO)
        {
            return this._tinhLuongDAL.TinhLuong_SelectAll(_tinhLuongDTO);
        }
    }
}
