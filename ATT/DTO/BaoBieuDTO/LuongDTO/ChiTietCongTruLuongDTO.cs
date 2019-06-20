using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO
{
  internal  class ChiTietCongTruLuongDTO
    {

        private string _ChiTietPhuCapCom;
        private string _ChiTietPhuCapKhac;
        private string _ChiTietTamUngLuong;
        private string _ChiTietThuong;
        private string _ChiTietViPham;
        private int _MaChamCong;

        public string ChiTietPhuCapCom
        {
            get
            {
                return this._ChiTietPhuCapCom;
            }
            set
            {
                this._ChiTietPhuCapCom = value;
            }
        }

        public string ChiTietPhuCapKhac
        {
            get
            {
                return this._ChiTietPhuCapKhac;
            }
            set
            {
                this._ChiTietPhuCapKhac = value;
            }
        }

        public string ChiTietTamUngLuong
        {
            get
            {
                return this._ChiTietTamUngLuong;
            }
            set
            {
                this._ChiTietTamUngLuong = value;
            }
        }

        public string ChiTietThuong
        {
            get
            {
                return this._ChiTietThuong;
            }
            set
            {
                this._ChiTietThuong = value;
            }
        }

        public string ChiTietViPham
        {
            get
            {
                return this._ChiTietViPham;
            }
            set
            {
                this._ChiTietViPham = value;
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
    }
}
