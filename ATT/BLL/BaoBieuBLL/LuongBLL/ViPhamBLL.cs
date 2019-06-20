using CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Data;
using System.Collections;

namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL.LuongBLL
{
  internal  class ViPhamBLL
    {

        private ViPhamDAL _viPhamDAL = new ViPhamDAL();

        public void InsertViPham(ViPhamDTO _viPhamDTO)
        {
            this._viPhamDAL.Insert_ViPham(_viPhamDTO);
        }

        public DataTable loadViPhamByMaChamCong(ViPhamDTO _viPhamDTO)
        {
            return this._viPhamDAL.load_ViPhamByMaChamCong(_viPhamDTO);
        }

        public DataTable SelectViPhamByMaChamCongThangNam(ViPhamDTO _viPhamDTO)
        {
            return this._viPhamDAL.Select_ViPhamByMaChamCongThangNam(_viPhamDTO);
        }

        public void ViPhamDelete(ViPhamDTO _viPhamDTO)
        {
            this._viPhamDAL.ViPham_Delete(_viPhamDTO);
        }

        public void ViPhamDeleteByMaChamCong(ViPhamDTO _viPhamDTO)
        {
            this._viPhamDAL.ViPham_DeleteByMaChamCong(_viPhamDTO);
        }

        public DataTable ViPhamGetMaChamCongAndNgayThang(ViPhamDTO _viPhamDTO)
        {
            return this._viPhamDAL.ViPham_getMaChamCongAndNgayThang(_viPhamDTO);
        }
    }
}
