using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Data;


namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL
{
   internal class TemplateBLL
    {
        private TemplateDAL _templateDAL = new TemplateDAL();

        public void DeleteAllFinger(TemplateDTO _templateDTO)
        {
            this._templateDAL.Delete_AllFinger(_templateDTO);
        }

        public void DeleteFingerByMaChamCong(TemplateDTO _templateDTO)
        {
            this._templateDAL.Delete_FingerByMaChamCong(_templateDTO);
        }

        public DataTable SelectALL_Template()
        {
            return this._templateDAL.selectAllTemplate();
        }

        public DataTable SelectTemplateByMaChamCongUpToDevice(TemplateDTO _templateDTO)
        {
            return this._templateDAL.Select_TemplateByMaChamCongUpToDevice(_templateDTO);
        }

        public void ThemTemplate(TemplateDTO _templateDTO)
        {
            this._templateDAL.Them_Template(_templateDTO);
        }

        public void Xoa_Finger(TemplateDTO _templateDTO)
        {
            this._templateDAL.Xoa_NhanVien_getFinger(_templateDTO);
        }
    }
}
