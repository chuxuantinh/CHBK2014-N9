using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO
{
  internal  class TinhThanhDTO
    {
        private string _MaTinhThanh;
        private string _TenTinhThanh;
        private bool _TinhTrang;

        public TinhThanhDTO()
        {
        }

        public TinhThanhDTO(string _MaTinhThanh, string _TenTinhThanh, bool _TinhTrang)
        {
            this.MaTinhThanh = _MaTinhThanh;
            this.TenTinhThanh = _TenTinhThanh;
            this.TinhTrang = _TinhTrang;
        }

        public string MaTinhThanh
        {
            get
            {
                return this._MaTinhThanh;
            }
            set
            {
                this._MaTinhThanh = value;
            }
        }

        public string TenTinhThanh
        {
            get
            {
                return this._TenTinhThanh;
            }
            set
            {
                this._TenTinhThanh = value;
            }
        }

        public bool TinhTrang
        {
            get
            {
                return this._TinhTrang;
            }
            set
            {
                this._TinhTrang = value;
            }
        }
    }
}
