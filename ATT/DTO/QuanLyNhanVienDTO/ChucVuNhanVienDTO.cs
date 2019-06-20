using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO
{
   internal class ChucVuNhanVienDTO
    {

        private string _GhiChu;
        private string _MaChucVuNhanVien;
        private string _TenChucVuNhanVien;
        private bool _TinhTrang;

        public ChucVuNhanVienDTO()
        {
        }

        public ChucVuNhanVienDTO(string _MaChucVuNhanVien, string _TenChucVuNhanVien, string _GhiChu, bool _TinhTrang)
        {
            this.MaChucVuNhanVien = _MaChucVuNhanVien;
            this.TenChucVuNhanVien = _TenChucVuNhanVien;
            this.GhiChu = _GhiChu;
            this.TinhTrang = _TinhTrang;
        }

        public string GhiChu
        {
            get
            {
                return this._GhiChu;
            }
            set
            {
                this._GhiChu = value;
            }
        }

        public string MaChucVuNhanVien
        {
            get
            {
                return this._MaChucVuNhanVien;
            }
            set
            {
                this._MaChucVuNhanVien = value;
            }
        }

        public string TenChucVuNhanVien
        {
            get
            {
                return this._TenChucVuNhanVien;
            }
            set
            {
                this._TenChucVuNhanVien = value;
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
