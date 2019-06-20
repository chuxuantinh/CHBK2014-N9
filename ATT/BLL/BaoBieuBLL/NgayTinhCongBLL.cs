using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.BaoBieuDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL
{
    internal class NgayTinhCongBLL
    {

        private NgayTinhCongDAL _ngayTinhCongDAL = new NgayTinhCongDAL();

        public void Insert_NgayTinhCong(NgayTinhCongDTO _ngayTinhCongDTO)
        {
            this._ngayTinhCongDAL.InsertNgayTinhCong(_ngayTinhCongDTO);
        }

        public DataTable showLoadNgayTinhCong(NgayTinhCongDTO _ngayTinhCongDTO)
        {
            return this._ngayTinhCongDAL.getLoadNgayTinhCong(_ngayTinhCongDTO);
        }

        public DataTable showThongTinNgayTinhCong(NgayTinhCongDTO _ngayTinhCongDTO)
        {
            return this._ngayTinhCongDAL.getNgayTinhCong(_ngayTinhCongDTO);
        }

        public void Update_NgayTinhCong(NgayTinhCongDTO _ngayTinhCongDTO)
        {
            this._ngayTinhCongDAL.UpdateNgayTinhCong(_ngayTinhCongDTO);
        }
    }
}
