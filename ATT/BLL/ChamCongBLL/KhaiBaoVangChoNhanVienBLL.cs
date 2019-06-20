using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
  internal  class KhaiBaoVangChoNhanVienBLL
    {

        private KhaiBaoVangChoNhanVienDAL _khaiBaoVangChoNhanVienDAL = new KhaiBaoVangChoNhanVienDAL();

        public DataTable CacLoaiVangGetTinhCong(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            return this._khaiBaoVangChoNhanVienDAL.CacLoaiVang_getTinhCong(_khaiBaoVangChoNhanVienDTO);
        }

        public void DeleteKhaiBaoVangChoNhanVien(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            this._khaiBaoVangChoNhanVienDAL.Delete_KhaiBaoVangChoNhanVien(_khaiBaoVangChoNhanVienDTO);
        }

        public void DeleteKhaiBaoVangChoNhanVienByMaChamCong(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            this._khaiBaoVangChoNhanVienDAL.Delete_KhaiBaoVangChoNhanVienByMaChamCong(_khaiBaoVangChoNhanVienDTO);
        }

        public DataTable get_KhaiBaoVangChoNhanVien(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            return this._khaiBaoVangChoNhanVienDAL.getKhaiBaoBaoVangChoNhanVien(_khaiBaoVangChoNhanVienDTO);
        }

        public void InsertKhaiBaoVangChoNhanVien(KhaiBaoVangChoNhanVienDTO _khaiBaoVangChoNhanVienDTO)
        {
            this._khaiBaoVangChoNhanVienDAL.Insert_KhaiBaoVangChoNhanVien(_khaiBaoVangChoNhanVienDTO);
        }
    }
}
