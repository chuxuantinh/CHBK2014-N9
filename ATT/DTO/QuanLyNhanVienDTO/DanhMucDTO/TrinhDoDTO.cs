using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.DanhMucDTO
{
   internal class TrinhDoDTO
    {

        private string _MaTrinhDo;
        private string _TrinhDo;

        public string MaTrinhDo
        {
            get
            {
                return this._MaTrinhDo;
            }
            set
            {
                this._MaTrinhDo = value;
            }
        }

        public string TrinhDo
        {
            get
            {
                return this._TrinhDo;
            }
            set
            {
                this._TrinhDo = value;
            }
        }
    }
}
