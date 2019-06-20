using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
   internal class KhaiBaoVangChoNhanVienDTO
    {
        private string _ApDung;
        private bool _DuocHuongLuong;
        private string _GhiChu;
        private int _ID;
        private string _MaCacLoaiVang;
        private int _MaChamCong;
        private int _Nam;
        private string _NgayCong;
        private DateTime _NgayThang;
        private int _Thang;
        private int _TongPhut;

        public string ApDung
        {
            get
            {
                return this._ApDung;
            }
            set
            {
                this._ApDung = value;
            }
        }

        public bool DuocHuongLuong
        {
            get
            {
                return this._DuocHuongLuong;
            }
            set
            {
                this._DuocHuongLuong = value;
            }
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

        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this._ID = value;
            }
        }

        public string MaCacLoaiVang
        {
            get
            {
                return this._MaCacLoaiVang;
            }
            set
            {
                this._MaCacLoaiVang = value;
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

        public int Nam
        {
            get
            {
                return this._Nam;
            }
            set
            {
                this._Nam = value;
            }
        }

        public string NgayCong
        {
            get
            {
                return this._NgayCong;
            }
            set
            {
                this._NgayCong = value;
            }
        }

        public DateTime NgayThang
        {
            get
            {
                return this._NgayThang;
            }
            set
            {
                this._NgayThang = value;
            }
        }

        public int Thang
        {
            get
            {
                return this._Thang;
            }
            set
            {
                this._Thang = value;
            }
        }

        public int TongPhut
        {
            get
            {
                return this._TongPhut;
            }
            set
            {
                this._TongPhut = value;
            }
        }
    }
}
