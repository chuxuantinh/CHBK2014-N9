using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.CommonDTO
{
  internal  class CommonDTO
    {

        private int _FingerIDVirtual;
        private string _FingerTemplateVirtual;
        private string _FingerVersionVirtual;
        private int _FlagVirtual;
        private int _MaChamCong;
        private string _MaNhanVien;

        public int FingerIDVirtual
        {
            get
            {
                return this._FingerIDVirtual;
            }
            set
            {
                this._FingerIDVirtual = value;
            }
        }

        public string FingerTemplateVirtual
        {
            get
            {
                return this._FingerTemplateVirtual;
            }
            set
            {
                this._FingerTemplateVirtual = value;
            }
        }

        public string FingerVersionVirtual
        {
            get
            {
                return this._FingerVersionVirtual;
            }
            set
            {
                this._FingerVersionVirtual = value;
            }
        }

        public int FlagVirtual
        {
            get
            {
                return this._FlagVirtual;
            }
            set
            {
                this._FlagVirtual = value;
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
    }
}
