using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO.CheDoDTO
{
   internal class PhepNamDTO
    {
        private string _DemCong;
        private int _DemGio;
        private int _ID;
        private int _MaChamCong;
        private string _MaNhanVien;
        private DateTime _Ngay;
        private float _Nghi;
        private string _TenNhanVien;

        public string DemCong
        {
            get
            {
                return this._DemCong;
            }
            set
            {
                this._DemCong = value;
            }
        }

        public int DemGio
        {
            get
            {
                return this._DemGio;
            }
            set
            {
                this._DemGio = value;
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

        public float Nghi
        {
            get
            {
                return this._Nghi;
            }
            set
            {
                this._Nghi = value;
            }
        }

        public string TenNhanVien
        {
            get
            {
                return this._TenNhanVien;
            }
            set
            {
                this._TenNhanVien = value;
            }
        }
    }
}
