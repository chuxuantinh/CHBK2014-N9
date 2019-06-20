using CHBK2014_N9.ATT.DTO.CommonDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.Common
{
   internal class CommonDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void DeleteAll_NhanVienVirtual(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("NhanVienVirtual_deleteAll", sqlParams);
        }

        public void DeleteAll_TemplateVirtual(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("TemplateVirtual_deleteAll", sqlParams);
        }

        public void Insert_NhanVienVirtual(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _commonDTO.MaChamCong)
            };
            base.Procedure("NhanVienVirtual_add", sqlParams);
        }

        public void Insert_TemplateVirtual(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _commonDTO.MaChamCong),
                new SqlParameter("@FingerIDVirtual", _commonDTO.FingerIDVirtual),
                new SqlParameter("@FlagVirtual", _commonDTO.FlagVirtual),
                new SqlParameter("@FingerTemplateVirtual", _commonDTO.FingerTemplateVirtual),
                new SqlParameter("@FingerVersionVirtual", _commonDTO.FingerVersionVirtual)
            };
            base.Procedure("TemplateVirtual_add", sqlParams);
        }

        public DataTable NhanVienVirtual_SelectAll()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            return base.executeNonQuerya("NhanVienVirtual_getall", sqlParams);
        }

        public DataTable Select_TemplateVirtualByMaCham(CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _commonDTO.MaChamCong)
            };
            return base.executeNonQuerya("NhanVienVirtual_selectTemplateByMaChamCong", sqlParams);
        }

        public DataTable TemplateVirtual_SelectAll()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            return base.executeNonQuerya("TemplateVirtual_getall", sqlParams);
        }
    }
}
