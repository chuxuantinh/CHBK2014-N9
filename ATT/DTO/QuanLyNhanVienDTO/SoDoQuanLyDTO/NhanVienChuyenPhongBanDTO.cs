using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO
{
  internal  class NhanVienChuyenPhongBanDTO
    {

        private int _MaChamCong;
        private string _TenNhanVien;

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
