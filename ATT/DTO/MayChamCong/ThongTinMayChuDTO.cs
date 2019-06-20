using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.MayChamCong
{
    internal class ThongTinMayChuDTO
    {

        private int _Cong;
        private string _DiaChiIP;
        private string _ID;
        private string _TenMayChu;

        public int Cong
        {
            get
            {
                return this._Cong;
            }
            set
            {
                this._Cong = value;
            }
        }

        public string DiaChiIP
        {
            get
            {
                return this._DiaChiIP;
            }
            set
            {
                this._DiaChiIP = value;
            }
        }

        public string ID
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

        public string TenMayChu
        {
            get
            {
                return this._TenMayChu;
            }
            set
            {
                this._TenMayChu = value;
            }
        }

    }
}
