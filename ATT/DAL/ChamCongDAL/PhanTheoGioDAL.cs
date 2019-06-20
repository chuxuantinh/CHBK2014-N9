using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
   internal class PhanTheoGioDAL :Provider

    {

        private DBHelper dbHelper = new DBHelper();

        public void PhanTheoGio_Delete(PhanTheoGioDTO _phanTheoGioDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _phanTheoGioDTO.ID)
            };
            base.Procedure("PhanTheoGio_delete", sqlParams);
        }

        public DataTable PhanTheoGio_getAll()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("PhanTheoGio_getall", sqlParams);
        }

        public DataTable PhanTheoGio_getMaLichTrinhVaoRa(PhanTheoGioDTO _phanTheoGioDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhVaoRa", _phanTheoGioDTO.MaLichTrinhVaoRa)
            };
            return base.executeNonQuerya("PhanTheoGio_get", sqlParams);
        }

        public void PhanTheoGio_Insert(PhanTheoGioDTO _phanTheoGioDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhVaoRa", _phanTheoGioDTO.MaLichTrinhVaoRa),
                new SqlParameter("@TenLichTrinhVaoRa", _phanTheoGioDTO.TenLichTrinhVaoRa),
                new SqlParameter("@BatDauVao", _phanTheoGioDTO.BatDauVao),
                new SqlParameter("@KetThucVao", _phanTheoGioDTO.KetThucVao),
                new SqlParameter("@BatDauRa", _phanTheoGioDTO.BatDauRa),
                new SqlParameter("@KetThucRa", _phanTheoGioDTO.KetThucRa)
            };
            base.Procedure("PhanTheoGio_add", sqlParams);
        }
    }
}
