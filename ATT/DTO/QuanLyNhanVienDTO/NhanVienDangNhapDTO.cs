using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO
{
   public class NhanVienDangNhapDTO
    {

        private string _ChucVu;
        private int _CMND;
        private string _DienThoaiLienHe;
        private string _Email;
        private bool _GioiTinh;
        private byte[] _HinhAnh;
        private string _LoaiNhanVien;
        private int _MaChamCong;
        private string _MaChucVu;
        private string _MaCongTy;
        private string _MaKhuVuc;
        private string _MaNhanVien;
        private string _MaPhongBan;
        private string _MaThe;
        private int _NgayPhep;
        private DateTime _NgaySinh;
        private DateTime _NgayVaoLamViec;
        private string _NoiSinh;
        private string _PassWord;
        private int _PhanQuyen;
        private string _TenChamCong;
        private string _TenNhanVien;
        private string _TienLuong;
        private bool _TinhTrang;
        private string _UserEnable;
        private string _UserPassWord;

        public NhanVienDangNhapDTO()
        {
        }

        public NhanVienDangNhapDTO(string _MaNhanVien, string _PassWord)
        {
            this.MaNhanVien = _MaNhanVien;
            this.PassWord = _PassWord;
        }

        public NhanVienDangNhapDTO(string _MaNhanVien, string _TenNhanVien, int _MaChamCong, string _PassWord)
        {
            this.MaNhanVien = _MaNhanVien;
            this.TenNhanVien = _TenNhanVien;
            this.MaChamCong = _MaChamCong;
            this.PassWord = _PassWord;
        }

        public string ChucVu
        {
            get
            {
                return this._ChucVu;
            }
            set
            {
                this._ChucVu = value;
            }
        }

        public int CMND
        {
            get
            {
                return this._CMND;
            }
            set
            {
                this._CMND = value;
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

        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this._Email = value;
            }
        }

        public bool GioiTinh
        {
            get
            {
                return this._GioiTinh;
            }
            set
            {
                this._GioiTinh = value;
            }
        }

        public byte[] HinhAnh
        {
            get
            {
                return this._HinhAnh;
            }
            set
            {
                this._HinhAnh = value;
            }
        }

        public string LoaiNhanVien
        {
            get
            {
                return this._LoaiNhanVien;
            }
            set
            {
                this._LoaiNhanVien = value;
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

        public string MaThe
        {
            get
            {
                return this._MaThe;
            }
            set
            {
                this._MaThe = value;
            }
        }

        public int NgayPhep
        {
            get
            {
                return this._NgayPhep;
            }
            set
            {
                this._NgayPhep = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return this._NgaySinh;
            }
            set
            {
                this._NgaySinh = value;
            }
        }

        public DateTime NgayVaoLamViec
        {
            get
            {
                return this._NgayVaoLamViec;
            }
            set
            {
                this._NgayVaoLamViec = value;
            }
        }

        public string NoiSinh
        {
            get
            {
                return this._NoiSinh;
            }
            set
            {
                this._NoiSinh = value;
            }
        }

        public string PassWord
        {
            get
            {
                return this._PassWord;
            }
            set
            {
                this._PassWord = value;
            }
        }

        public int PhanQuyen
        {
            get
            {
                return this._PhanQuyen;
            }
            set
            {
                this._PhanQuyen = value;
            }
        }

        public string TenChamCong
        {
            get
            {
                return this._TenChamCong;
            }
            set
            {
                this._TenChamCong = value;
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

        public string TienLuong
        {
            get
            {
                return this._TienLuong;
            }
            set
            {
                this._TienLuong = value;
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

        public string UserEnable
        {
            get
            {
                return this._UserEnable;
            }
            set
            {
                this._UserEnable = value;
            }
        }

        public string UserPassWord
        {
            get
            {
                return this._UserPassWord;
            }
            set
            {
                this._UserPassWord = value;
            }
        }
    }
}
