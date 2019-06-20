using CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Data;
using System.Collections;

namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL.LuongBLL
{
   internal class ThuongBLL
    {

        private ThuongDAL _thuongDAL = new ThuongDAL();

        public void ThuongDeleteByIDThuong(ThuongDTO _thuongDTO)
        {
            this._thuongDAL.Thuong_DeleteByIDThuong(_thuongDTO);
        }

        public void ThuongDeleteByMaChamCong(ThuongDTO _thuongDTO)
        {
            this._thuongDAL.Thuong_DeleteByMaChamCong(_thuongDTO);
        }

        public DataTable ThuongGetByMaChamCong(ThuongDTO _thuongDTO)
        {
            return this._thuongDAL.Thuong_GetByMaChamCong(_thuongDTO);
        }

        public DataTable ThuongGetByMaChamCongAndNgayThuong(ThuongDTO _thuongDTO)
        {
            return this._thuongDAL.Thuong_GetByMaChamCongAndNgayThuong(_thuongDTO);
        }

        public void ThuongInsert(ThuongDTO _thuongDTO)
        {
            this._thuongDAL.Thuong_Insert(_thuongDTO);
        }
    }
}
