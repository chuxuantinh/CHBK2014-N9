using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO
{
    internal class PhongBanDTO
    {

        private string _MaCongTy;
        private string _MaKhuVuc;
        private string _MaPhongBan;
        private string _SoTienSanLuong;
        private string _TenKhuVuc;
        private string _TenPhongBan;

        public PhongBanDTO()
        {
        }

        public PhongBanDTO(string _MaPhongBan, string _MaCongTy, string _MaKhuVuc, string _TenPhongBan)
        {
            this.MaPhongBan = _MaPhongBan;
            this._MaCongTy = _MaCongTy;
            this.MaKhuVuc = _MaKhuVuc;
            this.TenPhongBan = _TenPhongBan;
        }

        public PhongBanDTO(string _MaPhongBan, string _MaCongTy, string _TenKhuVuc, string _TenPhongBan, string _MaKhuVuc)
        {
            this.MaPhongBan = _MaPhongBan;
            this.MaCongTy = _MaCongTy;
            this.TenKhuVuc = _TenKhuVuc;
            this.TenPhongBan = _TenPhongBan;
            this.MaKhuVuc = _MaKhuVuc;
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

        public string SoTienSanLuong
        {
            get
            {
                return this._SoTienSanLuong;
            }
            set
            {
                this._SoTienSanLuong = value;
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
