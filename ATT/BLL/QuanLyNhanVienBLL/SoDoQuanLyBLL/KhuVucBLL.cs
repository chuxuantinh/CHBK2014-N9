using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL.SoDoQuanLyBLL
{
  internal  class KhuVucBLL
    {
        private KhuVucDAL _khuVucDAL = new KhuVucDAL();

        public void DELETEKHUVUC(KhuVucDTO _khuVucDTO)
        {
            this._khuVucDAL.DELELEKHUVUC(_khuVucDTO);
        }

        public DataTable GetAll_KhuVuc_TenKhuVuc()
        {
            return this._khuVucDAL.getAllKhuVuc_TenKhuVuc();
        }

        public ArrayList GetAllComboBoxKhuVuc()
        {
            ArrayList list = new ArrayList();
            list = this._khuVucDAL.SelectAllKhuVuc();
            if (list.Count != 0)
            {
                return list;
            }
            return null;
        }

        public DataTable GETKHUVUCTREEVIEW(KhuVucDTO _khuVucDTO)
        {
            return this._khuVucDAL.GETKHUVUCTREEVIEW(_khuVucDTO);
        }

        public DataTable getTenKhuVucByMaKhuVuc(KhuVucDTO _khuVucDTO)
        {
            return this._khuVucDAL.get_TenKhuVucByMaKhuVuc(_khuVucDTO);
        }

        public void KhuVucDelete(KhuVucDTO _khuVucDTO)
        {
            this._khuVucDAL.KhuVuc_Delete(_khuVucDTO);
        }

        public DataTable KhuVucGetTenKhuVucByMaKhuVuc(KhuVucDTO _khuVucDTO)
        {
            return this._khuVucDAL.KhuVuc_getTenKhuVucByMaKhuVuc(_khuVucDTO);
        }

        public DataTable KhuVucgetTreeView(KhuVucDTO _khuVucDTO)
        {
            return this._khuVucDAL.KhuVuc_getTreeView(_khuVucDTO);
        }

        public DataTable LOADKHUVUC()
        {
            return this._khuVucDAL.LoadKhuVuc();
        }

        public void SUAKHUVUC(KhuVucDTO _khuVucDTO)
        {
            this._khuVucDAL.SuaKhuVuc(_khuVucDTO);
        }

        public void THEMKHUVUC(KhuVucDTO _khuVucDTO)
        {
            this._khuVucDAL.ThemKhuVuc(_khuVucDTO);
        }
    }
}
