using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO
{
    internal   class ChucVuDTO
    {

        private string _MaChucVu;
        private string _MaCongTy;
        private string _MaKhuVuc;
        private string _MaPhongBan;
        private string _TenChucVu;
        private string _TenKhuVuc;
        private string _TenPhongBan;

        public ChucVuDTO()
        {
        }

        public ChucVuDTO(string _MaChucVu, string _MaCongTy, string _MaKhuVuc, string _TenKhuVuc, string _MaPhongBan, string _TenPhongBan, string _TenChucVu)
        {
            this.MaChucVu = _MaChucVu;
            this.MaCongTy = _MaCongTy;
            this.MaKhuVuc = _MaKhuVuc;
            this.TenKhuVuc = _TenKhuVuc;
            this.MaPhongBan = _MaPhongBan;
            this.TenPhongBan = _TenPhongBan;
            this.TenChucVu = _TenChucVu;
        }

        public string MaChucVu
        {
            get
            {
                return this._MaChucVu;
            }
            set
            {
                this._MaChucVu = value;
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

        public string MaKhuVuc
        {
            get
            {
                return this._MaKhuVuc;
            }
            set
            {
                this._MaKhuVuc = value;
            }
        }

        public string MaPhongBan
        {
            get
            {
                return this._MaPhongBan;
            }
            set
            {
                this._MaPhongBan = value;
            }
        }

        public string TenChucVu
        {
            get
            {
                return this._TenChucVu;
            }
            set
            {
                this._TenChucVu = value;
            }
        }

        public string TenKhuVuc
        {
            get
            {
                return this._TenKhuVuc;
            }
            set
            {
                this._TenKhuVuc = value;
            }
        }

        public string TenPhongBan
        {
            get
            {
                return this._TenPhongBan;
            }
            set
            {
                this._TenPhongBan = value;
            }
        }
    }
}
