using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL
{
 internal   class NhanVienUpdateBLL
    {
        private NhanVienUpdateDAL _nhanVienUpdateDAL = new NhanVienUpdateDAL();

        public void NhanVienUpdateDeleteAll(NhanVienUpdateDTO _nhanVienUpdateDTO)
        {
            this._nhanVienUpdateDAL.NhanVienUpdate_DeleteAll(_nhanVienUpdateDTO);
        }

        public DataTable NhanVienUpdateGetByMaChamCong(NhanVienUpdateDTO _nhanVienUpdateDTO)
        {
            return this._nhanVienUpdateDAL.NhanVienUpdate_GetByMaChamCong(_nhanVienUpdateDTO);
        }

        public void NhanVienUpdateInsert(NhanVienUpdateDTO _nhanVienUpdateDTO)
        {
            this._nhanVienUpdateDAL.NhanVienUpdate_Insert(_nhanVienUpdateDTO);
        }
    }
}
