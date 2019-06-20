using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.DanhMucDTO
{
   internal class DanTocDTO
    {
        private string _DanToc;
        private string _MaDanToc;

        public string DanToc
        {
            get
            {
                return this._DanToc;
            }
            set
            {
                this._DanToc = value;
            }
        }

        public string MaDanToc
        {
            get
            {
                return this._MaDanToc;
            }
            set
            {
                this._MaDanToc = value;
            }
        }
    }
}
