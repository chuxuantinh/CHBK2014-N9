using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO
{
   internal class NguoiGioiThieuDTO
    {
        private int _MaChamCong;
        private string _MaNguoiGioiThieu;
        private string _MaNhanVien;

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

        public string MaNguoiGioiThieu
        {
            get
            {
                return this._MaNguoiGioiThieu;
            }
            set
            {
                this._MaNguoiGioiThieu = value;
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
    }
}
