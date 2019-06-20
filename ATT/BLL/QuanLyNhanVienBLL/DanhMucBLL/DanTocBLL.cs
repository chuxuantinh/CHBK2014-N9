using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.DanhMucDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.DanhMucDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL.DanhMucBLL
{
    class DanTocBLL
    {

        private DanTocDAL _danTocDAL = new DanTocDAL();

        public void InsertDanToc(DanTocDTO _danTocDTO)
        {
            this._danTocDAL.Insert_DanToc(_danTocDTO);
        }

        public DataTable loadDanToc()
        {
            return this._danTocDAL.Load_DanToc();
        }

        public void UpdateDanToc(DanTocDTO _danTocDTO)
        {
            this._danTocDAL.Update_DanToc(_danTocDTO);
        }
    }
}
