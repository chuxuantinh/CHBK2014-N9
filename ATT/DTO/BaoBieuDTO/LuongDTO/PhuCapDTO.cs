using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO
{
  internal  class PhuCapDTO
    {
        private string _GhiChu;
        private string _KyHieuPhuCap;
        private string _MaPhuCap;
        private string _SoTienPhuCap;
        private bool _SuDung;
        private string _TenPhuCap;

        public PhuCapDTO()
        {
        }

        public PhuCapDTO(string _MaPhuCap, string _TenPhuCap)
        {
            this.MaPhuCap = _MaPhuCap;
            this.TenPhuCap = _TenPhuCap;
        }

        public PhuCapDTO(string _MaPhuCap, string _TenPhuCap, string _SoTienPhuCap, string _GhiChu, bool _SuDung)
        {
            this.MaPhuCap = _MaPhuCap;
            this.TenPhuCap = _TenPhuCap;
            this.SoTienPhuCap = _SoTienPhuCap;
            this.GhiChu = _GhiChu;
            this.SuDung = _SuDung;
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

        public string KyHieuPhuCap
        {
            get
            {
                return this._KyHieuPhuCap;
            }
            set
            {
                this._KyHieuPhuCap = value;
            }
        }

        public string MaPhuCap
        {
            get
            {
                return this._MaPhuCap;
            }
            set
            {
                this._MaPhuCap = value;
            }
        }

        public string SoTienPhuCap
        {
            get
            {
                return this._SoTienPhuCap;
            }
            set
            {
                this._SoTienPhuCap = value;
            }
        }

        public bool SuDung
        {
            get
            {
                return this._SuDung;
            }
            set
            {
                this._SuDung = value;
            }
        }

        public string TenPhuCap
        {
            get
            {
                return this._TenPhuCap;
            }
            set
            {
                this._TenPhuCap = value;
            }
        }

    }
}
