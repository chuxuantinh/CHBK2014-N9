using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO
{
    internal class CongTyDTO
    {

        private string _DiaChi;
        private string _DienThoai;
        private string _Email;
        private string _Fax;
        private byte[] _Logo;
        private string _MaCongTy;
        private string _MaSoThue;
        private string _TenCongTy;
        private string _Website;

        public string DiaChi
        {
            get
            {
                return this._DiaChi;
            }
            set
            {
                this._DiaChi = value;
            }
        }

        public string DienThoai
        {
            get
            {
                return this._DienThoai;
            }
            set
            {
                this._DienThoai = value;
            }
        }

        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this._Email = value;
            }
        }

        public string Fax
        {
            get
            {
                return this._Fax;
            }
            set
            {
                this._Fax = value;
            }
        }

        public byte[] Logo
        {
            get
            {
                return this._Logo;
            }
            set
            {
                this._Logo = value;
            }
        }

        public string MaCongTy
        {
            get
            {
                return this._MaCongTy;
            }
            set
            {
                this._MaCongTy = value;
            }
        }

        public string MaSoThue
        {
            get
            {
                return this._MaSoThue;
            }
            set
            {
                this._MaSoThue = value;
            }
        }

        public string TenCongTy
        {
            get
            {
                return this._TenCongTy;
            }
            set
            {
                this._TenCongTy = value;
            }
        }

        public string Website
        {
            get
            {
                return this._Website;
            }
            set
            {
                this._Website = value;
            }
        }
    }
}
