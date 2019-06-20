using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.BaoBieuDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL
{
    internal class TinhCongBLL
      {

        private TinhCongDAL _tinhCongDAL = new TinhCongDAL();

        public void TinhCongDelete(TinhCongDTO _tinhCongDTO)
        {
            this._tinhCongDAL.TinhCong_Delete(_tinhCongDTO);
        }

        public DataTable TinhCongGetAll(TinhCongDTO _tinhCongDTO)
        {
            return this._tinhCongDAL.TinhCong_GetAll(_tinhCongDTO);
        }

        public DataTable TinhCongGetByMaChamCong(TinhCongDTO _tinhCongDTO)
        {
            return this._tinhCongDAL.TinhCong_GetByMaChamCong(_tinhCongDTO);
        }

        public DataTable TinhCongGetByMaChamCongAndKyHieuPhu(TinhCongDTO _tinhCongDTO)
        {
            return this._tinhCongDAL.TinhCong_GetByMaChamCongAndKyHieuPhu(_tinhCongDTO);
        }

        public DataTable TinhCongGetByMaChamCongAndLe(TinhCongDTO _tinhCongDTO)
        {
            return this._tinhCongDAL.TinhCong_GetByMaChamCongAndLe(_tinhCongDTO);
        }

        public DataTable TinhCongGetMaChamCongAndNgay(TinhCongDTO _tinhCongDTO)
        {
            return this._tinhCongDAL.TinhCong_GetMaChamCongAndNgay(_tinhCongDTO);
        }

        public DataTable TinhCongGetNgay(TinhCongDTO _tinhCongDTO)
        {
            return this._tinhCongDAL.TinhCong_GetNgay(_tinhCongDTO);
        }

        public DataTable TinhCongGetNgayAndPhongBan(TinhCongDTO _tinhCongDTO)
        {
            return this._tinhCongDAL.TinhCong_GetNgayAndPhongBan(_tinhCongDTO);
        }

        public void TinhCongInsert(TinhCongDTO _tinhCongDTO)
        {
            this._tinhCongDAL.TinhCong_Insert(_tinhCongDTO);
        }
    }
}
