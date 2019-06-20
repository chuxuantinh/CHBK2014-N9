using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
   internal class SapXepLichTrinhChoNhanVienBLL
    {

        private SapXepLichTrinhChoNhanVienDAL _sapXepLichTrinhChoNhanVienDAL = new SapXepLichTrinhChoNhanVienDAL();

        public void DeleteAllSapXepLichTrinhChoNhanVien(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            this._sapXepLichTrinhChoNhanVienDAL.DeleteAll_SapXepLichTrinhChoNhanVien(_sapXepLichTrinhChoNhanVienDTO);
        }

        public void DeleteSapXepLichTrinhChoNhanVien(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            this._sapXepLichTrinhChoNhanVienDAL.Delete_SapXepLichTrinhChoNhanVien(_sapXepLichTrinhChoNhanVienDTO);
        }

        public void DeleteSapXepLichTrinhChoNhanVienByMaChamCong(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            this._sapXepLichTrinhChoNhanVienDAL.Delete_SapXepLichTrinhChoNhanVienByMaChamCong(_sapXepLichTrinhChoNhanVienDTO);
        }

        public DataTable get_SapXepLichTrinhChoNhanVienByMaChamCong(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            return this._sapXepLichTrinhChoNhanVienDAL.getSapXepLichTrinhChoNhanVienByMaChamCong(_sapXepLichTrinhChoNhanVienDTO);
        }

        public void Insert_SapXepLichTrinhChoNhanVien(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            this._sapXepLichTrinhChoNhanVienDAL.InsertSapXepLichTrinhChoNhanVien(_sapXepLichTrinhChoNhanVienDTO);
        }

        public DataTable SapXepLichTrinhChoNhanVienGetLichTrinhCaLamViec(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            return this._sapXepLichTrinhChoNhanVienDAL.SapXepLichTrinhChoNhanVien_GetLichTrinhCaLamViec(_sapXepLichTrinhChoNhanVienDTO);
        }

        public DataTable SapXepLichTrinhChoNhanVienGetLichTrinhVaoRa(SapXepLichTrinhChoNhanVienDTO _sapXepLichTrinhChoNhanVienDTO)
        {
            return this._sapXepLichTrinhChoNhanVienDAL.SapSepLichTrinhChoNhanVien_GetLichTrinhVaoRa(_sapXepLichTrinhChoNhanVienDTO);
        }
    }
}
