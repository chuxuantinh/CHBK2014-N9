using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
 internal   class CacLoaiVangBLL
    {

        private CacLoaiVangDAL _cacLoaiVangDAL = new CacLoaiVangDAL();

        public DataTable CacLoaiVangGetByMaCacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            return this._cacLoaiVangDAL.CacLoaiVang_getByMaCacLoaiVang(_cacLoaiVangDTO);
        }

        public bool InsertCacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            return (this._cacLoaiVangDAL.InsertCacLoaiVang(_cacLoaiVangDTO) > 0);
        }

        public DataTable Load_CacLoaiVang()
        {
            return this._cacLoaiVangDAL.LOADCACLOAIVANG();
        }

        public ArrayList load_CacLoaiVangLenCombobox()
        {
            ArrayList list = new ArrayList();
            return this._cacLoaiVangDAL.loadCacLoaiVangLenCombobox();
        }

        public void Sua_CacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            this._cacLoaiVangDAL.SuaCacLoaiVang(_cacLoaiVangDTO);
        }

        public void Them_CacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            this._cacLoaiVangDAL.ThemCacLoaiVang(_cacLoaiVangDTO);
        }

        public bool UpdateCacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            return (this._cacLoaiVangDAL.UpdateCacLoaiVang(_cacLoaiVangDTO) > 0);
        }

        public void Xoa_CacLoaiVang(CacLoaiVangDTO _cacLoaiVangDTO)
        {
            this._cacLoaiVangDAL.XoaCacLoaiVang(_cacLoaiVangDTO);
        }
    }
}
