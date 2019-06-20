using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.CommonDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.CommonBLL
{
   internal class CommonBLL
    {

        private CommonDAL _commonDAL = new CommonDAL();

        public void DeleteAllNhanVienVirtual(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            this._commonDAL.DeleteAll_NhanVienVirtual(_commonDTO);
        }

        public void DeleteALLTemplateVirtual(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            this._commonDAL.DeleteAll_TemplateVirtual(_commonDTO);
        }

        public void InsertNhanVienVirtual(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            this._commonDAL.Insert_NhanVienVirtual(_commonDTO);
        }

        public void InsertTemplateVirtual(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            this._commonDAL.Insert_TemplateVirtual(_commonDTO);
        }

        public DataTable NhanVienVirtualSelectAll()
        {
            return this._commonDAL.NhanVienVirtual_SelectAll();
        }

        public DataTable SelectTemplateVirtualByMaChamCong(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            return this._commonDAL.Select_TemplateVirtualByMaCham(_commonDTO);
        }

        public DataTable TemplateVirtualSelectAll()
        {
            return this._commonDAL.TemplateVirtual_SelectAll();
        }
    }
}
