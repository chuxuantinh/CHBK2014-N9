using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL
{
    internal class TemplateDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void Delete_AllFinger(TemplateDTO _templateDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("Template_deleteAll", sqlParams);
        }

        public void Delete_FingerByMaChamCong(TemplateDTO _templateDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _templateDTO.MaChamCong)
            };
            base.Procedure("NHANVIEN_deleteFingerByMaChamCongNew", sqlParams);
        }

        public DataTable Select_TemplateByMaChamCongUpToDevice(TemplateDTO _templateDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _templateDTO.MaChamCong)
            };
            return base.executeNonQuerya("NHANVIEN_selectTemplateUpToDevice", sqlParams);
        }

        public DataTable selectAllTemplate()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("TEMPLATE_getall", sqlParams);
        }

        public void Them_Template(TemplateDTO _templateDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _templateDTO.MaChamCong),
                new SqlParameter("@FingerID", _templateDTO.FingerID),
                new SqlParameter("@Flag", _templateDTO.Flag),
                new SqlParameter("@FingerTemplate", _templateDTO.FingerTemplate),
                new SqlParameter("@FingerVersion", _templateDTO.FingerVersion)
            };
            base.Procedure("TEMPLATE_add", sqlParams);
        }

        public void Xoa_NhanVien_getFinger(TemplateDTO _templateDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _templateDTO.MaChamCong)
            };
            base.Procedure("NHANVIEN_deleteFinger", sqlParams);
        }
    }
}
