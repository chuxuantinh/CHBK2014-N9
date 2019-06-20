using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
   internal class CacLoaiVangDTO
    {
        private string _KyHieu;
        private string _MaCacLoaiVang;
        private string _MoTa;
        private bool _SuDung;

        public CacLoaiVangDTO()
        {
        }

        public CacLoaiVangDTO(string _MaCacLoaiVang, string _MoTa, string _KyHieu, bool _SuDung)
        {
            this.MaCacLoaiVang = _MaCacLoaiVang;
            this.MoTa = _MoTa;
            this.KyHieu = _KyHieu;
            this.SuDung = _SuDung;
        }

        public string KyHieu
        {
            get
            {
                return this._KyHieu;
            }
            set
            {
                this._KyHieu = value;
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

        public string MoTa
        {
            get
            {
                return this._MoTa;
            }
            set
            {
                this._MoTa = value;
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
    }
}
