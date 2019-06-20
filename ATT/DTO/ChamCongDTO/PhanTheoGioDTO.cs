using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
 internal   class PhanTheoGioDTO
    {
        private DateTime _BatDauRa;
        private DateTime _BatDauVao;
        private int _ID;
        private DateTime _KetThucRa;
        private DateTime _KetThucVao;
        private string _MaLichTrinhVaoRa;
        private string _TenLichTrinhVaoRa;

        public DateTime BatDauRa
        {
            get
            {
                return this._BatDauRa;
            }
            set
            {
                this._BatDauRa = value;
            }
        }

        public DateTime BatDauVao
        {
            get
            {
                return this._BatDauVao;
            }
            set
            {
                this._BatDauVao = value;
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

        public DateTime KetThucRa
        {
            get
            {
                return this._KetThucRa;
            }
            set
            {
                this._KetThucRa = value;
            }
        }

        public DateTime KetThucVao
        {
            get
            {
                return this._KetThucVao;
            }
            set
            {
                this._KetThucVao = value;
            }
        }

        public string MaLichTrinhVaoRa
        {
            get
            {
                return this._MaLichTrinhVaoRa;
            }
            set
            {
                this._MaLichTrinhVaoRa = value;
            }
        }

        public string TenLichTrinhVaoRa
        {
            get
            {
                return this._TenLichTrinhVaoRa;
            }
            set
            {
                this._TenLichTrinhVaoRa = value;
            }
        }
    }
}
