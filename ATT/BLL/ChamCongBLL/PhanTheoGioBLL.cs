using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
   internal class PhanTheoGioBLL
    {

        private PhanTheoGioDAL _phanTheoGioDAL = new PhanTheoGioDAL();

        public void PhanTheoGioDelete(PhanTheoGioDTO _phanTheoGioDTO)
        {
            this._phanTheoGioDAL.PhanTheoGio_Delete(_phanTheoGioDTO);
        }

        public DataTable PhanTheoGiogetAll()
        {
            return this._phanTheoGioDAL.PhanTheoGio_getAll();
        }

        public DataTable PhanTheoGioGetMaLichTrinhVaoRa(PhanTheoGioDTO _phanTheoGioDTO)
        {
            return this._phanTheoGioDAL.PhanTheoGio_getMaLichTrinhVaoRa(_phanTheoGioDTO);
        }

        public void PhanTheoGioInsert(PhanTheoGioDTO _phanTheoGioDTO)
        {
            this._phanTheoGioDAL.PhanTheoGio_Insert(_phanTheoGioDTO);
        }
    }
}
