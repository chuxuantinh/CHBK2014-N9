using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO
{
  internal  class TemplateDTO
    {
        private int _FingerID;
        private string _FingerTemplate;
        private string _FingerVersion;
        private int _Flag;
        private int _MaChamCong;

        public int FingerID
        {
            get
            {
                return this._FingerID;
            }
            set
            {
                this._FingerID = value;
            }
        }

        public string FingerTemplate
        {
            get
            {
                return this._FingerTemplate;
            }
            set
            {
                this._FingerTemplate = value;
            }
        }

        public string FingerVersion
        {
            get
            {
                return this._FingerVersion;
            }
            set
            {
                this._FingerVersion = value;
            }
        }

        public int Flag
        {
            get
            {
                return this._Flag;
            }
            set
            {
                this._Flag = value;
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
