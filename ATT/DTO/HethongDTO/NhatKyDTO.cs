using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.HethongDTO
{
  internal  class NhatKyDTO
    {

        private string _ChucNang;
        private string _FromDate;
        private string _HanhDong;
        private int _ID;
        private string _MaNguoiDung;
        private string _TenDangNhap;
        private string _ThoiGian;
        private string _ThoiGianSearch;
        private string _ToDate;

        public NhatKyDTO()
        {
        }

        public NhatKyDTO(string _MaNguoiDung, string _ThoiGian, string _ChucNang, string _HanhDong, string _ThoiGianSearch)
        {
            this.MaNguoiDung = _MaNguoiDung;
            this.ThoiGian = _ThoiGian;
            this.ChucNang = _ChucNang;
            this.HanhDong = _HanhDong;
            this.ThoiGianSearch = _ThoiGianSearch;
        }

        public NhatKyDTO(int _ID, string _MaNguoiDung, string _ThoiGian, string _ChucNang, string _HanhDong, string _ThoiGianSearch)
        {
            this.ID = _ID;
            this.MaNguoiDung = _MaNguoiDung;
            this.ThoiGian = _ThoiGian;
            this.ChucNang = _ChucNang;
            this.HanhDong = _HanhDong;
            this.ThoiGianSearch = _ThoiGianSearch;
        }

        public NhatKyDTO(int _ID, string _MaNguoiDung, string _TenDangNhap, string _ThoiGian, string _ChucNang, string _HanhDong, string _ThoiGianSearch)
        {
            this.ID = _ID;
            this.MaNguoiDung = _MaNguoiDung;
            this.TenDangNhap = _TenDangNhap;
            this.ThoiGian = _ThoiGian;
            this.ChucNang = _ChucNang;
            this.HanhDong = _HanhDong;
            this.ThoiGianSearch = _ThoiGianSearch;
        }

        public string ChucNang
        {
            get
            {
                return this._ChucNang;
            }
            set
            {
                this._ChucNang = value;
            }
        }

        public string FromDate
        {
            get
            {
                return this._FromDate;
            }
            set
            {
                this._FromDate = value;
            }
        }

        public string HanhDong
        {
            get
            {
                return this._HanhDong;
            }
            set
            {
                this._HanhDong = value;
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

        public string MaNguoiDung
        {
            get
            {
                return this._MaNguoiDung;
            }
            set
            {
                this._MaNguoiDung = value;
            }
        }

        public string TenDangNhap
        {
            get
            {
                return this._TenDangNhap;
            }
            set
            {
                this._TenDangNhap = value;
            }
        }

        public string ThoiGian
        {
            get
            {
                return this._ThoiGian;
            }
            set
            {
                this._ThoiGian = value;
            }
        }

        public string ThoiGianSearch
        {
            get
            {
                return this._ThoiGianSearch;
            }
            set
            {
                this._ThoiGianSearch = value;
            }
        }

        public string ToDate
        {
            get
            {
                return this._ToDate;
            }
            set
            {
                this._ToDate = value;
            }
        }
    }
}
