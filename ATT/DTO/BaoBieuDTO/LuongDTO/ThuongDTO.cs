using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO
{
  internal  class ThuongDTO
    {


        private int _IDThuong;
        private int _MaChamCong;
        private DateTime _NgayThuong;
        private string _Thuong;
        private string _TienThuong;

        public int IDThuong
        {
            get
            {
                return this._IDThuong;
            }
            set
            {
                this._IDThuong = value;
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

        public DateTime NgayThuong
        {
            get
            {
                return this._NgayThuong;
            }
            set
            {
                this._NgayThuong = value;
            }
        }

        public string Thuong
        {
            get
            {
                return this._Thuong;
            }
            set
            {
                this._Thuong = value;
            }
        }

        public string TienThuong
        {
            get
            {
                return this._TienThuong;
            }
            set
            {
                this._TienThuong = value;
            }
        }
    }
}
