using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Data;


namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL
{
  internal  class NguoiGioiThieuBLL
    {
        private NguoiGioiThieuDAL _nguoiGioiThieuDAL = new NguoiGioiThieuDAL();

        public void NguoiGioiThieuInsert(NguoiGioiThieuDTO _nguoiGioiThieuDTO)
        {
            this._nguoiGioiThieuDAL.NguoiGioiThieu_Insert(_nguoiGioiThieuDTO);
        }
    }
}
