using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL.SoDoQuanLyBLL
{
  internal  class ChucVuBLL
    {
        private ChucVuDAL _chucVuDAL = new ChucVuDAL();

        public DataTable ChucVu_getPhongBan(ChucVuDTO _chucVuDTO)
        {
            return this._chucVuDAL.ChucVu_getPhongBan(_chucVuDTO);
        }

        public void ChucVuDelete(ChucVuDTO _chucVuDTO)
        {
            this._chucVuDAL.ChucVu_Delete(_chucVuDTO);
        }

        public DataTable ChucVuGetTenChucVuByMaChucVu(ChucVuDTO _chucVuDTO)
        {
            return this._chucVuDAL.ChucVu_getTenChucVuByMaChucVu(_chucVuDTO);
        }

        public DataTable ChucVugetTreeView(ChucVuDTO _chucVuDTO)
        {
            return this._chucVuDAL.ChucVu_getTreeView(_chucVuDTO);
        }

        public ArrayList GetAllChucVu(string _tenChucVu)
        {
            ArrayList list = new ArrayList();
            list = this._chucVuDAL.SelectAllChucVu(_tenChucVu);
            if (list.Count != 0)
            {
                return list;
            }
            return null;
        }

        public DataTable GETCHUCVUTREEVIEW(ChucVuDTO _chucVuDTO)
        {
            return this._chucVuDAL.GETCHUCVUTREEVIEW(_chucVuDTO);
        }

        public void InsertChucVu(ChucVuDTO _chucVuDTO)
        {
            this._chucVuDAL.Insert_ChucVu(_chucVuDTO);
        }

        public DataTable loadChucVu()
        {
            return this._chucVuDAL.LoadChucVu();
        }

        public bool SUACHUCVU(ChucVuDTO _chucVuDTO)
        {
            return (this._chucVuDAL.SuaChucVu(_chucVuDTO) > 0);
        }

        public bool THEMCHUCVU(ChucVuDTO _chucVuDTO)
        {
            return (this._chucVuDAL.ThemChucVu(_chucVuDTO) > 0);
        }
    }
}
