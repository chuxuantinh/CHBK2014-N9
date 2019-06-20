using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
  internal  class SapXepLichTrinhChoNhanVienDTO
    {
        private int _MaChamCong;
        private string _MaLichTrinhCaLamViec;
        private string _MaLichTrinhVaoRa;

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

        public string MaLichTrinhCaLamViec
        {
            get
            {
                return this._MaLichTrinhCaLamViec;
            }
            set
            {
                this._MaLichTrinhCaLamViec = value;
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
    }
}
