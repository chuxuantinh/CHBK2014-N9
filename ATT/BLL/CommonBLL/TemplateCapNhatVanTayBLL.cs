using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.CommonDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.CommonBLL
{
  internal class TemplateCapNhatVanTayBLL
    {


        private TemplateCapNhatVanTayDAL _templateCapNhatVanTayDAL = new TemplateCapNhatVanTayDAL();

        public void TemplateCapNhatVanTayDeleteAll(TemplateCapNhatVanTayDTO _templateCapNhatVanTayDTO)
        {
            this._templateCapNhatVanTayDAL.TemplateCapNhatVanTay_DeleteAll(_templateCapNhatVanTayDTO);
        }

        public DataTable TemplateCapNhatVanTayGetByMaChamCong(TemplateCapNhatVanTayDTO _templateCapNhatVanTayDTO)
        {
            return this._templateCapNhatVanTayDAL.TemplateCapNhatVanTay_GetByMaChamCong(_templateCapNhatVanTayDTO);
        }

        public void TemplateCapNhatVanTayInsert(TemplateCapNhatVanTayDTO _templateCapNhatVanTayDTO)
        {
            this._templateCapNhatVanTayDAL.TemplateCapNhatVanTay_Insert(_templateCapNhatVanTayDTO);
        }
    }
}
