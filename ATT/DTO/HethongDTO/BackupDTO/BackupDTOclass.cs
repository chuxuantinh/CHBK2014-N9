using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.HethongDTO.BackupDTO
{
  internal  class BackupDTOclass
    {

        private DateTime _Gio;
        private int _ID;
        private int _IDSaoLuu;
        private int _Ngay;
        private int _Thu;

        public DateTime Gio
        {
            get
            {
                return this._Gio;
            }
            set
            {
                this._Gio = value;
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

        public int IDSaoLuu
        {
            get
            {
                return this._IDSaoLuu;
            }
            set
            {
                this._IDSaoLuu = value;
            }
        }

        public int Ngay
        {
            get
            {
                return this._Ngay;
            }
            set
            {
                this._Ngay = value;
            }
        }

        public int Thu
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
