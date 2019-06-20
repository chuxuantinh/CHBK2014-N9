using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
  internal class MucLuongToiThieuDALL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable getLoadMucLuongYoiThieu(MucLuongToiThieuDTO _mucLuongToiThieuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLuongToiThieu", _mucLuongToiThieuDTO.MaLuongToiThieu)
            };
            return base.executeNonQuerya("MUCLUONGTOITHIEU_get", sqlParams);
        }

        public DataTable getMucLuongYoiThieu(MucLuongToiThieuDTO _mucLuongToiThieuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("MUCLUONGTOITHIEU_getall", sqlParams);
        }

        public void SuaMucLuongYoiThieu(MucLuongToiThieuDTO _mucLuongToiThieuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLuongToiThieu", _mucLuongToiThieuDTO.MaLuongToiThieu),
                new SqlParameter("@SoTien", _mucLuongToiThieuDTO.SoTien),
                new SqlParameter("@SoQuyetDinh", _mucLuongToiThieuDTO.SoQuyetDinh),
                new SqlParameter("@NgayApDung", _mucLuongToiThieuDTO.NgayApDung),
                new SqlParameter("@NguoiRaQuyetDinh", _mucLuongToiThieuDTO.NguoiRaQuyetDinh)
            };
            base.Procedure("MUCLUONGTOITHIEU_update", sqlParams);
        }

        public void ThemMucLuongYoiThieu(MucLuongToiThieuDTO _mucLuongToiThieuDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLuongToiThieu", _mucLuongToiThieuDTO.MaLuongToiThieu),
                new SqlParameter("@SoTien", _mucLuongToiThieuDTO.SoTien),
                new SqlParameter("@SoQuyetDinh", _mucLuongToiThieuDTO.SoQuyetDinh),
                new SqlParameter("@NgayApDung", _mucLuongToiThieuDTO.NgayApDung),
                new SqlParameter("@NguoiRaQuyetDinh", _mucLuongToiThieuDTO.NguoiRaQuyetDinh)
            };
            base.Procedure("MUCLUONGTOITHIEU_add", sqlParams);
        }
    }
}
