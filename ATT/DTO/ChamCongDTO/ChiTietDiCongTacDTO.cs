using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
   internal class ChiTietDiCongTacDTO
    {

        private decimal _CongTinhCongTac;
        private DateTime _GioDi;
        private DateTime _GioVe;
        private int _ID;
        private string _LyDo;
        private int _MaChamCong;
        private string _MaNhanVien;
        private DateTime _Ngay;
        private decimal _TongGioCongTac;

        public decimal CongTinhCongTac
        {
            get
            {
                return this._CongTinhCongTac;
            }
            set
            {
                this._CongTinhCongTac = value;
            }
        }

        public DateTime GioDi
        {
            get
            {
                return this._GioDi;
            }
            set
            {
                this._GioDi = value;
            }
        }

        public DateTime GioVe
        {
            get
            {
                return this._GioVe;
            }
            set
            {
                this._GioVe = value;
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

        public string LyDo
        {
            get
            {
                return this._LyDo;
            }
            set
            {
                this._LyDo = value;
            }
        }

        public int MaChamCong
        {
            get
            {
                return this._MaChamCong;
            }
            set
            {
                this._MaChamCong = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return this._MaNhanVien;
            }
            set
            {
                this._MaNhanVien = value;
            }
        }

        public DateTime Ngay
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

        public decimal TongGioCongTac
        {
            get
            {
                return this._TongGioCongTac;
            }
            set
            {
                this._TongGioCongTac = value;
            }
        }
    }
}
