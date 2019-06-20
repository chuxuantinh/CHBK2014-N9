using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.MayChamCong.DuLieuMayChamCongDTO
{
   internal class CheckInOutDTO
    {

        private DateTime _GioCham;
        private int _ID;
        private string _KieuCham;
        private int _MaChamCong;
        private int _MaSoMay;
        private DateTime _NgayCham;
        private string _NguonCham;
        private string _TenMay;

        public DateTime GioCham
        {
            get
            {
                return this._GioCham;
            }
            set
            {
                this._GioCham = value;
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

        public string KieuCham
        {
            get
            {
                return this._KieuCham;
            }
            set
            {
                this._KieuCham = value;
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

        public int MaSoMay
        {
            get
            {
                return this._MaSoMay;
            }
            set
            {
                this._MaSoMay = value;
            }
        }

        public DateTime NgayCham
        {
            get
            {
                return this._NgayCham;
            }
            set
            {
                this._NgayCham = value;
            }
        }

        public string NguonCham
        {
            get
            {
                return this._NguonCham;
            }
            set
            {
                this._NguonCham = value;
            }
        }

        public string TenMay
        {
            get
            {
                return this._TenMay;
            }
            set
            {
                this._TenMay = value;
            }
        }

    }
}
