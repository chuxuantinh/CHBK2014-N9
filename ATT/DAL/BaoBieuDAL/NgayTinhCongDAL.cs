using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO;
using CHBK2014_N9.ATT.DAL.Common;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL
{
   internal class NgayTinhCongDAL: Provider
    {


        private DBHelper dbHelper = new DBHelper();

        public DataTable getLoadNgayTinhCong(NgayTinhCongDTO _ngayTinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _ngayTinhCongDTO.ID)
            };
            return base.executeNonQuerya("NgayTinhCong_get", sqlParams);
        }

        public DataTable getNgayTinhCong(NgayTinhCongDTO _ngayTinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NgayTinhCong_getall", sqlParams);
        }

        public void InsertNgayTinhCong(NgayTinhCongDTO _ngayTinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _ngayTinhCongDTO.ID),
                new SqlParameter("@NgayBatDau", _ngayTinhCongDTO.NgayBatDau),
                new SqlParameter("@NgayKetThuc", _ngayTinhCongDTO.NgayKetThuc)
            };
            base.Procedure("NgayTinhCong_add", sqlParams);
        }

        public void UpdateNgayTinhCong(NgayTinhCongDTO _ngayTinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _ngayTinhCongDTO.ID),
                new SqlParameter("@NgayBatDau", _ngayTinhCongDTO.NgayBatDau),
                new SqlParameter("@NgayKetThuc", _ngayTinhCongDTO.NgayKetThuc)
            };
            base.Procedure("NgayTinhCong_update", sqlParams);
        }
    }
}
