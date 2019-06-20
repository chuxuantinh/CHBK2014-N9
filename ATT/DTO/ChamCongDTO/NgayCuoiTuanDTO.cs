using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
   internal class NgayCuoiTuanDTO
    {
        private bool _Chon;
        private int _ID;
        private string _Thu;

        public bool Chon
        {
            get
            {
                return this._Chon;
            }
            set
            {
                this._Chon = value;
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

        public string Thu
        {
            get
            {
                return this._Thu;
            }
            set
            {
                this._Thu = value;
            }
        }
    }
}
