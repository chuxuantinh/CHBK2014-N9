using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO
{
   internal class NhanVienUpdateDTO
    {

        private int _MaChamCong;
        private string _MaThe;
        private int _PhanQuyen;
        private string _UserPassWord;

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
