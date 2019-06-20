using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.DanhMucDTO
{
   internal class QuocTichDTO
    {
        private string _MaQuocTich;
        private string _QuocTich;

        public string MaQuocTich
        {
            get
            {
                return this._MaQuocTich;
            }
            set
            {
                this._MaQuocTich = value;
            }
        }

        public string QuocTich
        {
            get
            {
                return this._QuocTich;
            }
            set
            {
                this._QuocTich = value;
            }
        }
    }
}
