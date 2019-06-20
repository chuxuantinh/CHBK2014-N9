using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO
{
   internal class KhuVucDTO
    {

        private string _DiaChiKhuVuc;
        private string _DienThoaiLienHe;
        private string _MaCongTy;
        private string _MaKhuVuc;
        private string _NguoiLienHe;
        private string _TenKhuVuc;

        public KhuVucDTO()
        {
        }

        public KhuVucDTO(string _MaKhuVuc, string _MaCongTy, string _TenKhuVuc, string _DiaChiKhuVuc, string _NguoiLienHe, string _DienThoaiLienHe)
        {
            this.MaKhuVuc = _MaKhuVuc;
            this.MaCongTy = _MaCongTy;
            this.TenKhuVuc = _TenKhuVuc;
            this.DiaChiKhuVuc = _DiaChiKhuVuc;
            this.NguoiLienHe = _NguoiLienHe;
            this.DienThoaiLienHe = _DienThoaiLienHe;
        }

        public string DiaChiKhuVuc
        {
            get
            {
                return this._DiaChiKhuVuc;
            }
            set
            {
                this._DiaChiKhuVuc = value;
            }
        }

        public string DienThoaiLienHe
        {
            get
            {
                return this._DienThoaiLienHe;
            }
            set
            {
                this._DienThoaiLienHe = value;
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

        public string NguoiLienHe
        {
            get
            {
                return this._NguoiLienHe;
            }
            set
            {
                this._NguoiLienHe = value;
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
    }
}
