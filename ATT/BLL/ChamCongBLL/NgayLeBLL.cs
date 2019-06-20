using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
   internal class NgayLeBLL
    {

        private NgayLeDAL _ngayLeDAL = new NgayLeDAL();

        public void DELETEALLNGAYLE(NgayLeDTO _ngayLeDTO)
        {
            this._ngayLeDAL.XoaTatCaNgayLe(_ngayLeDTO);
        }

        public void DELETENGAYLE(NgayLeDTO _ngayLeDTO)
        {
            this._ngayLeDAL.XoaNgayLe(_ngayLeDTO);
        }

        public DataTable GETDANHSACHNGAYLE()
        {
            return this._ngayLeDAL.LOADNGAYLE();
        }

        public DataTable NgayLeGet(NgayLeDTO _ngayLeDTO)
        {
            return this._ngayLeDAL.NgayLe_get(_ngayLeDTO);
        }

        public DataTable NgayLeGetTinhCong(NgayLeDTO _ngayLeDTO)
        {
            return this._ngayLeDAL.NgayLe_getTinhCong(_ngayLeDTO);
        }

        public void SUANGAYLE(NgayLeDTO _ngayLeDTO)
        {
            this._ngayLeDAL.SuaNgayLe(_ngayLeDTO);
        }

        public void THEMNGAYLE(NgayLeDTO _ngayLeDTO)
        {
            this._ngayLeDAL.ThemNgayLe(_ngayLeDTO);
        }
    }
}
