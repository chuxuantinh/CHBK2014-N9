using CHBK2014_N9.ATT.DAL.MayChamCong;
using CHBK2014_N9.ATT.DTO.MayChamCong;
using System;

namespace CHBK2014_N9.ATT.BLL.MayChamCong
{
  internal  class ABCBLL
    {
        private ABCDAL _aBCDAL = new ABCDAL();

        public void THEMABC(ABCDTO _aBCDTO)
        {
            this._aBCDAL.ThemABC(_aBCDTO);
        }
    }
}
