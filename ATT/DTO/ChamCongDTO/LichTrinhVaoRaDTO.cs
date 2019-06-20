using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
    internal class LichTrinhVaoRaDTO
    {

        private int _ChonLichTrinhVaoRa;
        private DateTime _DenGio;
        private int _KhoangCachGiuaHaiCapVaoRa;
        private bool _LoaiBoGio;
        private string _MaLichTrinhVaoRa;
        private bool _MotLanChamCong;
        private string _TenLichTrinhVaoRa;
        private int _ThoiGianLonNhat;
        private int _ThoiGianNhoNhat;
        private DateTime _TuGio;

        public LichTrinhVaoRaDTO()
        {
        }

        public LichTrinhVaoRaDTO(string _MaLichTrinhVaoRa, string _TenLichTrinhVaoRa, int _ChonLichTrinhVaoRa, bool _MotLanChamCong, bool _LoaiBoGio, DateTime _TuGio, DateTime _DenGio, int _ThoiGianNhoNhat, int _ThoiGianLonNhat, int _KhoangCachGiuaHaiCapVaoRa)
        {
            this.MaLichTrinhVaoRa = _MaLichTrinhVaoRa;
            this.TenLichTrinhVaoRa = _TenLichTrinhVaoRa;
            this.ChonLichTrinhVaoRa = _ChonLichTrinhVaoRa;
            this.MotLanChamCong = _MotLanChamCong;
            this.LoaiBoGio = _LoaiBoGio;
            this.TuGio = _TuGio;
            this.DenGio = _DenGio;
            this.ThoiGianNhoNhat = _ThoiGianNhoNhat;
            this.ThoiGianLonNhat = _ThoiGianLonNhat;
            this.KhoangCachGiuaHaiCapVaoRa = _KhoangCachGiuaHaiCapVaoRa;
        }

        public int ChonLichTrinhVaoRa
        {
            get
            {
                return this._ChonLichTrinhVaoRa;
            }
            set
            {
                this._ChonLichTrinhVaoRa = value;
            }
        }

        public DateTime DenGio
        {
            get
            {
                return this._DenGio;
            }
            set
            {
                this._DenGio = value;
            }
        }

        public int KhoangCachGiuaHaiCapVaoRa
        {
            get
            {
                return this._KhoangCachGiuaHaiCapVaoRa;
            }
            set
            {
                this._KhoangCachGiuaHaiCapVaoRa = value;
            }
        }

        public bool LoaiBoGio
        {
            get
            {
                return this._LoaiBoGio;
            }
            set
            {
                this._LoaiBoGio = value;
            }
        }

        public string MaLichTrinhVaoRa
        {
            get
            {
                return this._MaLichTrinhVaoRa;
            }
            set
            {
                this._MaLichTrinhVaoRa = value;
            }
        }

        public bool MotLanChamCong
        {
            get
            {
                return this._MotLanChamCong;
            }
            set
            {
                this._MotLanChamCong = value;
            }
        }

        public string TenLichTrinhVaoRa
        {
            get
            {
                return this._TenLichTrinhVaoRa;
            }
            set
            {
                this._TenLichTrinhVaoRa = value;
            }
        }

        public int ThoiGianLonNhat
        {
            get
            {
                return this._ThoiGianLonNhat;
            }
            set
            {
                this._ThoiGianLonNhat = value;
            }
        }

        public int ThoiGianNhoNhat
        {
            get
            {
                return this._ThoiGianNhoNhat;
            }
            set
            {
                this._ThoiGianNhoNhat = value;
            }
        }

        public DateTime TuGio
        {
            get
            {
                return this._TuGio;
            }
            set
            {
                this._TuGio = value;
            }
        }
    }
}
