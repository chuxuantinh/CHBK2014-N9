using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
   internal class KyHieuChamCongBLL
    {

        private KyHieuChamCongDAL _kyHieuChamCongDAL = new KyHieuChamCongDAL();

        public void Insert_KyHieuChamCong(KyHieuChamCongDTO _kyHieuChamCongDTO)
        {
            this._kyHieuChamCongDAL.InsertKyHieuChamCong(_kyHieuChamCongDTO);
        }

        public DataTable showKyHieuChamCong(KyHieuChamCongDTO _kyHieuChamCongDTO)
        {
            return this._kyHieuChamCongDAL.getKyHieuChamCong(_kyHieuChamCongDTO);
        }

        public DataTable showLoadKyHieuChamCong(KyHieuChamCongDTO _kyHieuChamCongDTO)
        {
            return this._kyHieuChamCongDAL.getLoadKyHieuChamCong(_kyHieuChamCongDTO);
        }

        public void Update_KyHieuChamCong(KyHieuChamCongDTO _kyHieuChamCongDTO)
        {
            this._kyHieuChamCongDAL.UpdateKyHieuChamCong(_kyHieuChamCongDTO);
        }
    }
}
