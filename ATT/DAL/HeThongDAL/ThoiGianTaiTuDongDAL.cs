using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System.Data.SqlClient;
using System.Data;


namespace CHBK2014_N9.ATT.DAL.HeThongDAL
{
    internal class ThoiGianTaiTuDongDAL:Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public void Delete_HenGioTaiTuDong(ThoiGianTaiTuDongDTO _thoiGianTaiTuDongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _thoiGianTaiTuDongDTO.ID)
            };
            base.Procedure("GioHenTaiTuDong_delete", sqlParams);
        }

        public DataTable getThoiGianTaiTuDong(ThoiGianTaiTuDongDTO _thoiGianTaiTuDongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("GioHenTaiTuDong_getall", sqlParams);
        }

        public void Insert_HenGioTaiTuDong(ThoiGianTaiTuDongDTO _thoiGianTaiTuDongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@GioHen", _thoiGianTaiTuDongDTO.GioHen)
            };
            base.Procedure("GioHenTaiTuDong_add", sqlParams);
        }

        public void Update_HenGioTaiTuDong(ThoiGianTaiTuDongDTO _thoiGianTaiTuDongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@GioHen", _thoiGianTaiTuDongDTO.GioHen)
            };
            base.Procedure("GioHenTaiTuDong_update", sqlParams);
        }
    }
}
