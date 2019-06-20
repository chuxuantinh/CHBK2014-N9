using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO
{
  internal  class MucLuongToiThieuDTO
    {


        private string _MaLuongToiThieu;
        private DateTime _NgayApDung;
        private string _NguoiRaQuyetDinh;
        private string _SoQuyetDinh;
        private string _SoTien;

        public string MaLuongToiThieu
        {
            get
            {
                return this._MaLuongToiThieu;
            }
            set
            {
                this._MaLuongToiThieu = value;
            }
        }

        public DateTime NgayApDung
        {
            get
            {
                return this._NgayApDung;
            }
            set
            {
                this._NgayApDung = value;
            }
        }

        public string NguoiRaQuyetDinh
        {
            get
            {
                return this._NguoiRaQuyetDinh;
            }
            set
            {
                this._NguoiRaQuyetDinh = value;
            }
        }

        public string SoQuyetDinh
        {
            get
            {
                return this._SoQuyetDinh;
            }
            set
            {
                this._SoQuyetDinh = value;
            }
        }

        public string SoTien
        {
            get
            {
                return this._SoTien;
            }
            set
            {
                this._SoTien = value;
            }
        }
    }
}
