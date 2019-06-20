using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO
{
   internal class BacLuongTNCN_DTO
    {

        private int _Bac;
        private string _Den;
        private int _IDBacLuong;
        private float _ThueSuat;
        private string _TienTru;
        private string _Tu;

        public int Bac
        {
            get
            {
                return this._Bac;
            }
            set
            {
                this._Bac = value;
            }
        }

        public string Den
        {
            get
            {
                return this._Den;
            }
            set
            {
                this._Den = value;
            }
        }

        public int IDBacLuong
        {
            get
            {
                return this._IDBacLuong;
            }
            set
            {
                this._IDBacLuong = value;
            }
        }

        public float ThueSuat
        {
            get
            {
                return this._ThueSuat;
            }
            set
            {
                this._ThueSuat = value;
            }
        }

        public string TienTru
        {
            get
            {
                return this._TienTru;
            }
            set
            {
                this._TienTru = value;
            }
        }

        public string Tu
        {
            get
            {
                return this._Tu;
            }
            set
            {
                this._Tu = value;
            }
        }
    }
}
