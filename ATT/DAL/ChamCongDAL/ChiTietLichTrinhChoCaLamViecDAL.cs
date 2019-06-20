using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
  internal class ChiTietLichTrinhChoCaLamViecDAL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable ChiTietLichTrinhCaLamViec_getByID(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _chiTietLichTrinhChoCaLamViecDTO.ID)
            };
            return base.executeNonQuerya("ChiTietLichTrinhCaLamViec_getByID", sqlParams);
        }

        public DataTable ChiTietLichTrinhCaLamViec_getByMaLichTrinhCaLamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _chiTietLichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec)
            };
            return base.executeNonQuerya("ChiTietLichTrinhCaLamViec_getByMaLichTrinhCaLamViec", sqlParams);
        }

        public DataTable ChiTietLichTrinhCaLamViec_NhanCa(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _chiTietLichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec),
                new SqlParameter("@Thu", _chiTietLichTrinhChoCaLamViecDTO.Thu)
            };
            return base.executeNonQuerya("ChiTietLichTrinhCaLamViec_NhanCa", sqlParams);
        }

        public void Delete_ChiTietLichTrinhCaLamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _chiTietLichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec)
            };
            base.Procedure("LichTrinhCaLamViec_delete", sqlParams);
        }

        public DataTable get_ChiTietLichTrinhChoCaLamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _chiTietLichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec)
            };
            return base.executeNonQuerya("LichTrinhCaLamViec_get", sqlParams);
        }

        public void Insert_ChiTietLichTrinhChoCaLamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _chiTietLichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec),
                new SqlParameter("@Thu", _chiTietLichTrinhChoCaLamViecDTO.Thu),
                new SqlParameter("@CaThu1", _chiTietLichTrinhChoCaLamViecDTO.CaThu1),
                new SqlParameter("@CaThu2", _chiTietLichTrinhChoCaLamViecDTO.CaThu2),
                new SqlParameter("@CaThu3", _chiTietLichTrinhChoCaLamViecDTO.CaThu3),
                new SqlParameter("@CaThu4", _chiTietLichTrinhChoCaLamViecDTO.CaThu4),
                new SqlParameter("@CaThu5", _chiTietLichTrinhChoCaLamViecDTO.CaThu5),
                new SqlParameter("@CaThu6", _chiTietLichTrinhChoCaLamViecDTO.CaThu6),
                new SqlParameter("@CaThu7", _chiTietLichTrinhChoCaLamViecDTO.CaThu7),
                new SqlParameter("@CaThu8", _chiTietLichTrinhChoCaLamViecDTO.CaThu8),
                new SqlParameter("@CaThu9", _chiTietLichTrinhChoCaLamViecDTO.CaThu9),
                new SqlParameter("@CaThu10", _chiTietLichTrinhChoCaLamViecDTO.CaThu10)
            };
            base.Procedure("ChiTietLichTrinhCaLamViec_add", sqlParams);
        }

        public void Update_ChiTietLichTrinhChoCaLamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _chiTietLichTrinhChoCaLamViecDTO.ID),
                new SqlParameter("@MaLichTrinhCaLamViec", _chiTietLichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec),
                new SqlParameter("@Thu", _chiTietLichTrinhChoCaLamViecDTO.Thu),
                new SqlParameter("@CaThu1", _chiTietLichTrinhChoCaLamViecDTO.CaThu1),
                new SqlParameter("@CaThu2", _chiTietLichTrinhChoCaLamViecDTO.CaThu2),
                new SqlParameter("@CaThu3", _chiTietLichTrinhChoCaLamViecDTO.CaThu3),
                new SqlParameter("@CaThu4", _chiTietLichTrinhChoCaLamViecDTO.CaThu4),
                new SqlParameter("@CaThu5", _chiTietLichTrinhChoCaLamViecDTO.CaThu5),
                new SqlParameter("@CaThu6", _chiTietLichTrinhChoCaLamViecDTO.CaThu6),
                new SqlParameter("@CaThu7", _chiTietLichTrinhChoCaLamViecDTO.CaThu7),
                new SqlParameter("@CaThu8", _chiTietLichTrinhChoCaLamViecDTO.CaThu8),
                new SqlParameter("@CaThu9", _chiTietLichTrinhChoCaLamViecDTO.CaThu9),
                new SqlParameter("@CaThu10", _chiTietLichTrinhChoCaLamViecDTO.CaThu10)
            };
            base.Procedure("ChiTietLichTrinhCaLamViec_update", sqlParams);
        }
    }
}
