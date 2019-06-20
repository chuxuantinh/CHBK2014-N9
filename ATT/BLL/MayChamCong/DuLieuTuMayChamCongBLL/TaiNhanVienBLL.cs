using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CHBK2014_N9.ATT.DAL.MayChamCong.DuLieuMayChamCongDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;



namespace CHBK2014_N9.ATT.BLL.MayChamCong.DuLieuTuMayChamCongBLL
{
   internal class TaiNhanVienBLL
    {
        private TaiNhanVienDAL _taiNhanVienDAL = new TaiNhanVienDAL();

        public void Them_NhanVienTuMay(NhanVienDTO _nhanVienDTO)
        {
            this._taiNhanVienDAL.ThemNhanVienTuMay(_nhanVienDTO);
        }


    }
}
