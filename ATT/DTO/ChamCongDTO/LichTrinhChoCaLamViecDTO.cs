using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
   internal class LichTrinhChoCaLamViecDTO
    {

        private int _ChuKy;
        private string _MaLichTrinhCaLamViec;
        private string _TenLichTrinhCaLamViec;

        public LichTrinhChoCaLamViecDTO()
        {
        }

        public LichTrinhChoCaLamViecDTO(string _MaLichTrinhCaLamViec, string _TenLichTrinhCaLamViec)
        {
            this.MaLichTrinhCaLamViec = _MaLichTrinhCaLamViec;
            this.TenLichTrinhCaLamViec = _TenLichTrinhCaLamViec;
        }

        public int ChuKy
        {
            get
            {
                return this._ChuKy;
            }
            set
            {
                this._ChuKy = value;
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

        public string TenLichTrinhCaLamViec
        {
            get
            {
                return this._TenLichTrinhCaLamViec;
            }
            set
            {
                this._TenLichTrinhCaLamViec = value;
            }
        }
    }
}
