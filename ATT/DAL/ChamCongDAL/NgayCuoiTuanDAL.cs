using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
  internal  class NgayCuoiTuanDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void Delete_NgayCuoiTuan(NgayCuoiTuanDTO _ngayCuoiTuanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("NgayCuoiTuan_deleteAll", sqlParams);
        }

        public DataTable getLoadNgayCuoiTuan(NgayCuoiTuanDTO _ngayCuoiTuanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _ngayCuoiTuanDTO.ID)
            };
            return base.executeNonQuerya("NGAYCUOITUAN_get", sqlParams);
        }

        public DataTable getNgayCuoiTuan()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("NGAYCUOITUAN_getall", sqlParams);
        }

        public void InsertNgayCuoiTuan(NgayCuoiTuanDTO _ngayCuoiTuanDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@Thu", _ngayCuoiTuanDTO.Thu),
                new SqlParameter("@ID", _ngayCuoiTuanDTO.ID),
                new SqlParameter("@Chon", _ngayCuoiTuanDTO.Chon)
            };
            base.Procedure("NGAYCUOITUAN_add", sqlParams);
        }
    }
}
