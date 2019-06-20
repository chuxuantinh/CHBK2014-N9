using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.MayChamCong;

namespace CHBK2014_N9.ATT.DAL.MayChamCong
{
   internal class ABCDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void ThemABC(ABCDTO _aBCDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNV", _aBCDTO.MaNV),
                new SqlParameter("@ThoiGian", _aBCDTO.ThoiGian),
                new SqlParameter("@DeviceID", _aBCDTO.DeviceID),
                new SqlParameter("@Status", _aBCDTO.Status),
                new SqlParameter("@Verified", _aBCDTO.Verified),
                new SqlParameter("@Workcode", _aBCDTO.Workcode)
            };
            base.Procedure("ABC_add", sqlParams);
        }
    }
}
