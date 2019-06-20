using CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Data;
using System.Collections;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
  internal  class PhuCapBLL
    {

        private PhuCapDAL _phuCapDAL = new PhuCapDAL();

        public void DeleteAllPhuCap(PhuCapDTO _phuCapDTO)
        {
            this._phuCapDAL.DeleteALL_PhuCap(_phuCapDTO);
        }

        public void DeletePhuCap(PhuCapDTO _phuCapDTO)
        {
            this._phuCapDAL.Delete_PhuCap(_phuCapDTO);
        }

        public DataTable getLoadControlPhuCap(PhuCapDTO _phuCapDTO)
        {
            return this._phuCapDAL.get_LoadControlPhuCap(_phuCapDTO);
        }

        public void Insert_PhuCap(PhuCapDTO _phuCapDTO)
        {
            this._phuCapDAL.InsertPhuCap(_phuCapDTO);
        }

        public DataTable Load_PhuCap()
        {
            return this._phuCapDAL.loadPhuCap();
        }

        public ArrayList load_PhuCapLenCombobox()
        {
            ArrayList list = new ArrayList();
            return this._phuCapDAL.loadPhuCapLenCombobox();
        }

        public void Update_PhuCap(PhuCapDTO _phuCapDTO)
        {
            this._phuCapDAL.UpdatePhuCap(_phuCapDTO);
        }
    }
}
