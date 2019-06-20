using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL
{
    internal class NhanVienUpdateDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void NhanVienUpdate_DeleteAll(NhanVienUpdateDTO _nhanVienUpdateDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("NhanVienUpdate_deleteAll", sqlParams);
        }

        public DataTable NhanVienUpdate_GetByMaChamCong(NhanVienUpdateDTO _nhanVienUpdateDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienUpdateDTO.MaChamCong)
            };
            return base.executeNonQuerya("NhanVienUpdate_getByMaChamCong", sqlParams);
        }

        public void NhanVienUpdate_Insert(NhanVienUpdateDTO _nhanVienUpdateDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _nhanVienUpdateDTO.MaChamCong),
                new SqlParameter("@MaThe", _nhanVienUpdateDTO.MaThe),
                new SqlParameter("@UserPassWord", _nhanVienUpdateDTO.UserPassWord),
                new SqlParameter("@PhanQuyen", _nhanVienUpdateDTO.PhanQuyen)
            };
            base.Procedure("NhanVienUpdate_add", sqlParams);
        }
    }
}
