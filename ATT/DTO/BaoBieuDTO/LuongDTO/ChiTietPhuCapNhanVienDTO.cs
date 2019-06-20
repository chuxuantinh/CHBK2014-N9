using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO
{
  internal  class ChiTietPhuCapNhanVienDTO
    {


        private int _IDChiTietPhuCap;
        private string _KyHieuPhuCap;
        private int _MaChamCong;
        private string _MaPhuCap;
        private DateTime _Ngay;
        private string _SoTien;
        private string _TenPhuCap;

        public int IDChiTietPhuCap
        {
            get
            {
                return this._IDChiTietPhuCap;
            }
            set
            {
                this._IDChiTietPhuCap = value;
            }
        }

        public string KyHieuPhuCap
        {
            get
            {
                return this._KyHieuPhuCap;
            }
            set
            {
                this._KyHieuPhuCap = value;
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

        public string MaPhuCap
        {
            get
            {
                return this._MaPhuCap;
            }
            set
            {
                this._MaPhuCap = value;
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

        public string SoTien
        {
            get
            {
                return this._SoTien;
            }
            set
            {
                this._SoTien = value;
            }
        }

        public string TenPhuCap
        {
            get
            {
                return this._TenPhuCap;
            }
            set
            {
                this._TenPhuCap = value;
            }
        }
    }
}
