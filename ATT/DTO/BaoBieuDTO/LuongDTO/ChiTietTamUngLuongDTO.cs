using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO
{
internal    class ChiTietTamUngLuongDTO
    {

        private int _IDTamUngLuong;
        private string _LyDo;
        private int _MaChamCong;
        private int _Nam;
        private DateTime _NgayTamUng;
        private string _SoTien;
        private int _Thang;

        public int IDTamUngLuong
        {
            get
            {
                return this._IDTamUngLuong;
            }
            set
            {
                this._IDTamUngLuong = value;
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

        public DateTime NgayTamUng
        {
            get
            {
                return this._NgayTamUng;
            }
            set
            {
                this._NgayTamUng = value;
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
    }
}
