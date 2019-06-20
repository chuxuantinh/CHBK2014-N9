using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO
{
    internal class ViPhamDTO
    {

        private int _IDViPham;
        private int _MaChamCong;
        private int _Nam;
        private int _Ngay;
        private DateTime _NgayThang;
        private int _Thang;
        private string _TienPhat;
        private string _ViPham;

        public int IDViPham
        {
            get
            {
                return this._IDViPham;
            }
            set
            {
                this._IDViPham = value;
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

        public DateTime NgayThang
        {
            get
            {
                return this._NgayThang;
            }
            set
            {
                this._NgayThang = value;
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

        public string TienPhat
        {
            get
            {
                return this._TienPhat;
            }
            set
            {
                this._TienPhat = value;
            }
        }

        public string ViPham
        {
            get
            {
                return this._ViPham;
            }
            set
            {
                this._ViPham = value;
            }
        }
    }
}
