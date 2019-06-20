using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
  internal  class NgayLeDTO
    {
        private float _CongTinh;
        private string _GhiChu;
        private float _Gio;
        private float _HeSo;
        private string _MaNgayLe;
        private int _Nam;
        private DateTime _Ngay;
        private string _TenNgayLe;
        private int _Thang;
        private bool _XacNhan;

        public float CongTinh
        {
            get
            {
                return this._CongTinh;
            }
            set
            {
                this._CongTinh = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return this._GhiChu;
            }
            set
            {
                this._GhiChu = value;
            }
        }

        public float Gio
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

        public float HeSo
        {
            get
            {
                return this._HeSo;
            }
            set
            {
                this._HeSo = value;
            }
        }

        public string MaNgayLe
        {
            get
            {
                return this._MaNgayLe;
            }
            set
            {
                this._MaNgayLe = value;
            }
        }

        public int Nam
        {
            get
            {
                return this._Nam;
            }
            set
            {
                this._Nam = value;
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

        public string TenNgayLe
        {
            get
            {
                return this._TenNgayLe;
            }
            set
            {
                this._TenNgayLe = value;
            }
        }

        public int Thang
        {
            get
            {
                return this._Thang;
            }
            set
            {
                this._Thang = value;
            }
        }

        public bool XacNhan
        {
            get
            {
                return this._XacNhan;
            }
            set
            {
                this._XacNhan = value;
            }
        }
    }
}
