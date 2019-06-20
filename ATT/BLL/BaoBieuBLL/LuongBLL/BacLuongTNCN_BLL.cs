using CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL.LuongBLL
{
   internal class BacLuongTNCN_BLL
    {

        private BacLuongTNCN_DAL _bacLuongTNCN_DAL = new BacLuongTNCN_DAL();

        public void BacLuongTNCNInsert(BacLuongTNCN_DTO _bacLuongTNCN_DTO)
        {
            this._bacLuongTNCN_DAL.BacLuongTNCN_Insert(_bacLuongTNCN_DTO);
        }

        public DataTable BacLuongTNCNSelect()
        {
            return this._bacLuongTNCN_DAL.BacLuongTNCN_Select();
        }

        public void BacLuongTNCNUpdate(BacLuongTNCN_DTO _bacLuongTNCN_DTO)
        {
            this._bacLuongTNCN_DAL.BacLuongTNCN_Update(_bacLuongTNCN_DTO);
        }
    }
}
