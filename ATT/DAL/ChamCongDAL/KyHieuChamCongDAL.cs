using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
   internal class KyHieuChamCongDAL: Provider
    {


        private DBHelper dbHelper = new DBHelper();

        public DataTable getKyHieuChamCong(KyHieuChamCongDTO _kyHieuChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("KYHIEUCHAMCONG_getall", sqlParams);
        }

        public DataTable getLoadKyHieuChamCong(KyHieuChamCongDTO _kyHieuChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKyHieu", _kyHieuChamCongDTO.MaKyHieu)
            };
            return base.executeNonQuerya("KYHIEUCHAMCONG_get", sqlParams);
        }

        public void InsertKyHieuChamCong(KyHieuChamCongDTO _kyHieuChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKyHieu", _kyHieuChamCongDTO.MaKyHieu),
                new SqlParameter("@DiTre", _kyHieuChamCongDTO.DiTre),
                new SqlParameter("@VeSom", _kyHieuChamCongDTO.VeSom),
                new SqlParameter("@DungGio", _kyHieuChamCongDTO.DungGio),
                new SqlParameter("@TangCa", _kyHieuChamCongDTO.TangCa),
                new SqlParameter("@ThieuGioVao", _kyHieuChamCongDTO.ThieuGioVao),
                new SqlParameter("@ThieuGioRa", _kyHieuChamCongDTO.ThieuGioRa),
                new SqlParameter("@Vang", _kyHieuChamCongDTO.Vang),
                new SqlParameter("@ChuaXepCa", _kyHieuChamCongDTO.ChuaXepCa),
                new SqlParameter("@PhepNam", _kyHieuChamCongDTO.PhepNam),
                new SqlParameter("@Le", _kyHieuChamCongDTO.Le),
                new SqlParameter("@CongTac", _kyHieuChamCongDTO.CongTac),
                new SqlParameter("@VeTre", _kyHieuChamCongDTO.VeTre),
                new SqlParameter("@CuoiTuan", _kyHieuChamCongDTO.CuoiTuan)
            };
            base.Procedure("KYHIEUCHAMCONG_add", sqlParams);
        }

        public void UpdateKyHieuChamCong(KyHieuChamCongDTO _kyHieuChamCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaKyHieu", _kyHieuChamCongDTO.MaKyHieu),
                new SqlParameter("@DiTre", _kyHieuChamCongDTO.DiTre),
                new SqlParameter("@VeSom", _kyHieuChamCongDTO.VeSom),
                new SqlParameter("@DungGio", _kyHieuChamCongDTO.DungGio),
                new SqlParameter("@TangCa", _kyHieuChamCongDTO.TangCa),
                new SqlParameter("@ThieuGioVao", _kyHieuChamCongDTO.ThieuGioVao),
                new SqlParameter("@ThieuGioRa", _kyHieuChamCongDTO.ThieuGioRa),
                new SqlParameter("@Vang", _kyHieuChamCongDTO.Vang),
                new SqlParameter("@ChuaXepCa", _kyHieuChamCongDTO.ChuaXepCa),
                new SqlParameter("@PhepNam", _kyHieuChamCongDTO.PhepNam),
                new SqlParameter("@Le", _kyHieuChamCongDTO.Le),
                new SqlParameter("@CongTac", _kyHieuChamCongDTO.CongTac),
                new SqlParameter("@VeTre", _kyHieuChamCongDTO.VeTre),
                new SqlParameter("@CuoiTuan", _kyHieuChamCongDTO.CuoiTuan)
            };
            base.Procedure("KYHIEUCHAMCONG_update", sqlParams);
        }
    }
}
