using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
   internal class LichTrinhVaoRaBLL
    {


        private LichTrinhVaoRaDAL _lichTrinhVaoRaDAL = new LichTrinhVaoRaDAL();

        public void DELETE_LICHTRINHVAORA(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            this._lichTrinhVaoRaDAL.XoaLichTrinhVaoRa(_lichTrinhVaoRaDTO);
        }

        public void DELETEALL_LICHTRINHVAORA(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            this._lichTrinhVaoRaDAL.XoaTatCaLichTrinhVaoRa(_lichTrinhVaoRaDTO);
        }

        public DataTable get_LichTrinhVaoRaByMaLichTrinhVaoRa(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            return this._lichTrinhVaoRaDAL.getLichTrinhVaoRaByMaLichTrinhVaoRa(_lichTrinhVaoRaDTO);
        }

        public DataTable GETDANHSACH_LICHTRINHVAORA()
        {
            return this._lichTrinhVaoRaDAL.LOADLICHTRINHVAORA();
        }

        public ArrayList load_LichTrinhVaoRaLenComboBox()
        {
            ArrayList list = new ArrayList();
            return this._lichTrinhVaoRaDAL.loadLichTrinhVaoRaLenComboBox();
        }

        public void SUA_LICHTRINHVAORA(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            this._lichTrinhVaoRaDAL.SuaLichTrinhVaoRa(_lichTrinhVaoRaDTO);
        }

        public void THEM_LICHTRINHVAORA(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            this._lichTrinhVaoRaDAL.ThemLichTrinhVaoRa(_lichTrinhVaoRaDTO);
        }
    }
}
