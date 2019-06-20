using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
  internal  class LichTrinhChoCaLamViecBLL
    {

        private LichTrinhChoCaLamViecDAL _lichTrinhChoCaLamViecDAL = new LichTrinhChoCaLamViecDAL();

        public DataTable GET_DANHSACH_LICHTRINHCHOCALAMVIEC()
        {
            return this._lichTrinhChoCaLamViecDAL.LOADLICHTRINHCHOCALAMVIEC();
        }

        public DataTable get_LichTrinhChoCaLamViecByMaLichTrinhCaLamViec(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            return this._lichTrinhChoCaLamViecDAL.getLichTrinhChoCaLamViecByMaLichTrinhCaLamViec(_lichTrinhChoCaLamViecDTO);
        }

        public void LichTrinhChoCaLamViecDelete(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            this._lichTrinhChoCaLamViecDAL.LichTrinhChoCaLamViec_Delete(_lichTrinhChoCaLamViecDTO);
        }

        public ArrayList load_LichTrinhChoCaLamViecLenComboBox()
        {
            ArrayList list = new ArrayList();
            return this._lichTrinhChoCaLamViecDAL.loadLichTrinhChoCaLamViecLenCombobox();
        }

        public void SUA_LICHTRINHCHOCALAMVIEC(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            this._lichTrinhChoCaLamViecDAL.SuaLichTrinhChoCaLamViec(_lichTrinhChoCaLamViecDTO);
        }

        public void THEMLICHTRINHCHOCALAMVIEC(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            this._lichTrinhChoCaLamViecDAL.ThemLichTrinhChoCaLamViec(_lichTrinhChoCaLamViecDTO);
        }

        public void XOA_LICHTRINHCHOCALAMVIEC(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            this._lichTrinhChoCaLamViecDAL.XoaLichTrinhChoCaLamViec(_lichTrinhChoCaLamViecDTO);
        }

        public void XOA_TATCA_LICHTRINHCHOCALAMVIEC(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            this._lichTrinhChoCaLamViecDAL.XoaTatCaLichTrinhChoCaLamViec(_lichTrinhChoCaLamViecDTO);
        }
    }
}
