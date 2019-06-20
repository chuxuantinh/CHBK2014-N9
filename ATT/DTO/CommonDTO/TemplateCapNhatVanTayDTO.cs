using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.CommonDTO
{
  internal  class TemplateCapNhatVanTayDTO
    {

        private int _FingerIDCapNhatVanTay;
        private string _FingerTemplateCapNhatVanTay;
        private string _FingerVersionCapNhatVanTay;
        private int _FlagCapNhatVanTay;
        private int _MaChamCong;

        public int FingerIDCapNhatVanTay
        {
            get
            {
                return this._FingerIDCapNhatVanTay;
            }
            set
            {
                this._FingerIDCapNhatVanTay = value;
            }
        }

        public string FingerTemplateCapNhatVanTay
        {
            get
            {
                return this._FingerTemplateCapNhatVanTay;
            }
            set
            {
                this._FingerTemplateCapNhatVanTay = value;
            }
        }

        public string FingerVersionCapNhatVanTay
        {
            get
            {
                return this._FingerVersionCapNhatVanTay;
            }
            set
            {
                this._FingerVersionCapNhatVanTay = value;
            }
        }

        public int FlagCapNhatVanTay
        {
            get
            {
                return this._FlagCapNhatVanTay;
            }
            set
            {
                this._FlagCapNhatVanTay = value;
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

    }
}
