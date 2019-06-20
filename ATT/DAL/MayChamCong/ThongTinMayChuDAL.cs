using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.MayChamCong;
using System.Data.SqlClient;
using System.Data;

namespace CHBK2014_N9.ATT.DAL.MayChamCong
{
   internal class ThongTinMayChuDAL:Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public DataTable get_LoadThongTinMayChu(ThongTinMayChuDTO _thongTinMayChuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _thongTinMayChuDTO.ID)
            };
            return base.executeNonQuerya("MayChu_get", sqlParams);
        }

        public DataTable get_ThongTinMayChu(ThongTinMayChuDTO _thongTinMayChuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("MayChu_getall", sqlParams);
        }

        public void Insert_ThongTinMayChu(ThongTinMayChuDTO _thongTinMayChuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _thongTinMayChuDTO.ID),
                new SqlParameter("@Cong", _thongTinMayChuDTO.Cong),
                new SqlParameter("@DiaChiIP", _thongTinMayChuDTO.DiaChiIP),
                new SqlParameter("@TenMayChu", _thongTinMayChuDTO.TenMayChu)
            };
            base.Procedure("MayChu_add", sqlParams);
        }

        public void Update_ThongTinMayChu(ThongTinMayChuDTO _thongTinMayChuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _thongTinMayChuDTO.ID),
                new SqlParameter("@Cong", _thongTinMayChuDTO.Cong),
                new SqlParameter("@DiaChiIP", _thongTinMayChuDTO.DiaChiIP),
                new SqlParameter("@TenMayChu", _thongTinMayChuDTO.TenMayChu)
            };
            base.Procedure("MayChu_update", sqlParams);
        }

    }
}
