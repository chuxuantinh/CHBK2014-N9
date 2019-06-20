using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.HethongDTO
{
   internal class ThoiGianTaiTuDongDTO
    {


        private DateTime _GioHen;
        private int _ID;

        public DateTime GioHen
        {
            get
            {
                return this._GioHen;
            }
            set
            {
                this._GioHen = value;
            }
        }

        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this._ID = value;
            }
        }
    }
}
