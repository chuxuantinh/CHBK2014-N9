using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CHBK2014_N9.ATT.DTO.CommonDTO;

namespace CHBK2014_N9.ATT.DAL.Common
{
   internal class TemplateCapNhatVanTayDAL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void TemplateCapNhatVanTay_DeleteAll(TemplateCapNhatVanTayDTO _templateCapNhatVanTayDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("TemplateCapNhatVanTay_deleteAll", sqlParams);
        }

        public DataTable TemplateCapNhatVanTay_GetByMaChamCong(TemplateCapNhatVanTayDTO _templateCapNhatVanTayDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _templateCapNhatVanTayDTO.MaChamCong)
            };
            return base.executeNonQuerya("TemplateCapNhatVanTay_getByMaChamCong", sqlParams);
        }

        public void TemplateCapNhatVanTay_Insert(TemplateCapNhatVanTayDTO _templateCapNhatVanTayDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _templateCapNhatVanTayDTO.MaChamCong),
                new SqlParameter("@FingerIDCapNhatVanTay", _templateCapNhatVanTayDTO.FingerIDCapNhatVanTay),
                new SqlParameter("@FlagCapNhatVanTay", _templateCapNhatVanTayDTO.FlagCapNhatVanTay),
                new SqlParameter("@FingerTemplateCapNhatVanTay", _templateCapNhatVanTayDTO.FingerTemplateCapNhatVanTay),
                new SqlParameter("@FingerVersionCapNhatVanTay", _templateCapNhatVanTayDTO.FingerVersionCapNhatVanTay)
            };
            base.Procedure("TemplateCapNhatVanTay_add", sqlParams);
        }
    }
}
