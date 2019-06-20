using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.DanhMucDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.DanhMucDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL.DanhMucBLL
{
    internal class TrinhDoBLL
    {
        private TrinhDoDAL _trinhDoDAL = new TrinhDoDAL();

        public DataTable TrinhDoGetall()
        {
            return this._trinhDoDAL.Load_TrinhDo();
        }

        public void TrinhDoInsert(TrinhDoDTO _trinhDoDTO)
        {
            this._trinhDoDAL.TrinhDo_Insert(_trinhDoDTO);
        }

        public void TrinhDoUpdate(TrinhDoDTO _trinhDoDTO)
        {
            this._trinhDoDAL.TrinhDo_Update(_trinhDoDTO);
        }
    }
}
