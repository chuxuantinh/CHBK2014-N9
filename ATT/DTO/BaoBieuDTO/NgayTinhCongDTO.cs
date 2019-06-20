using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.BaoBieuDTO
{
   internal class NgayTinhCongDTO
    {

        private int _ID;
        private DateTime _NgayBatDau;
        private DateTime _NgayKetThuc;

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

        public DateTime NgayBatDau
        {
            get
            {
                return this._NgayBatDau;
            }
            set
            {
                this._NgayBatDau = value;
            }
        }

        public DateTime NgayKetThuc
        {
            get
            {
                return this._NgayKetThuc;
            }
            set
            {
                this._NgayKetThuc = value;
            }
        }
    }
}
