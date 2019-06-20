using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL.SoDoQuanLyBLL
{
internal  class CongTyBLL
    {
        private CongTyDAL _congTyDAL = new CongTyDAL();

        public void CAPNHATCONGTY(CongTyDTO _congTyDTO)
        {
            this._congTyDAL.SuaCongTy(_congTyDTO);
        }

        public DataTable CongTygetTreeView(CongTyDTO _congTyDTO)
        {
            return this._congTyDAL.CongTy_getTreeView(_congTyDTO);
        }

        public DataTable showLoadCongTy(CongTyDTO _congTyDTO)
        {
            return this._congTyDAL.getLoadCongTy(_congTyDTO);
        }

        public DataTable showThongTinCongTy(CongTyDTO _congTyDTO)
        {
            return this._congTyDAL.getCongTy(_congTyDTO);
        }

        public void THEMCONGTY(CongTyDTO _congTyDTO)
        {
            this._congTyDAL.ThemCongTy(_congTyDTO);
        }
    }
}
