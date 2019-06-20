using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
   internal class ChiTietDangKyTangCaDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void ChiTietDangKyTangCa_Delete(ChiTietDangKyTangCaDTO _chiTietDangKyTangCaDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _chiTietDangKyTangCaDTO.ID)
            };
            base.Procedure("ChiTietDangKyTangCa_delete", sqlParams);
        }

        public DataTable ChiTietDangKyTangCa_GetByMaChamCong(ChiTietDangKyTangCaDTO _chiTietDangKyTangCaDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietDangKyTangCaDTO.MaChamCong)
            };
            return base.executeNonQuerya("ChiTietDangKyTangCa_getByMaChamCong", sqlParams);
        }

        public void Delete_ChiTietDangKyTangCaByMaChamCong(ChiTietDangKyTangCaDTO _chiTietDangKyTangCaDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietDangKyTangCaDTO.MaChamCong)
            };
            base.Procedure("NHANVIEN_deleteChiTietDangKyTangCaByMaChamCong", sqlParams);
        }

        public void Insert_ChiTietDangKyTangCa(ChiTietDangKyTangCaDTO _chiTietDangKyTangCaDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietDangKyTangCaDTO.MaChamCong),
                new SqlParameter("@Ngay", _chiTietDangKyTangCaDTO.Ngay)
            };
            base.Procedure("ChiTietDangKyTangCa_add", sqlParams);
        }
    }
}
