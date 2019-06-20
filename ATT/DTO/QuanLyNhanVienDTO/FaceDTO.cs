using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO
{
  internal  class FaceDTO
    {
        private int _ChieuDai;
        private int _FaceID;
        private string _FaceTemplate;
        private int _MaChamCong;

        public int ChieuDai
        {
            get
            {
                return this._ChieuDai;
            }
            set
            {
                this._ChieuDai = value;
            }
        }

        public int FaceID
        {
            get
            {
                return this._FaceID;
            }
            set
            {
                this._FaceID = value;
            }
        }

        public string FaceTemplate
        {
            get
            {
                return this._FaceTemplate;
            }
            set
            {
                this._FaceTemplate = value;
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
