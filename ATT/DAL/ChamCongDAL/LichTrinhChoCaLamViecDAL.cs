using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
  internal class LichTrinhChoCaLamViecDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable getLichTrinhChoCaLamViecByMaLichTrinhCaLamViec(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _lichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec)
            };
            return base.executeNonQuerya("LichTrinhChoCaLamViec_getByMaLichTrinhCaLamViec", sqlParams);
        }

        public void LichTrinhChoCaLamViec_Delete(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _lichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec)
            };
            base.Procedure("LichTrinhChoCaLamViec_delete", sqlParams);
        }

        public DataTable LOADLICHTRINHCHOCALAMVIEC()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("LICHTRINHCHOCALAMVIEC_getall", sqlParams);
        }

        public ArrayList loadLichTrinhChoCaLamViecLenCombobox()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("LICHTRINHCHOCALAMVIEC_getall");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                LichTrinhChoCaLamViecDTO cdto = new LichTrinhChoCaLamViecDTO(reader.GetString(0), reader.GetString(1));
                list.Add(cdto);
            }
            reader.Close();
            return list;
        }

        public void SuaLichTrinhChoCaLamViec(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _lichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec),
                new SqlParameter("@TenLichTrinhCaLamViec", _lichTrinhChoCaLamViecDTO.TenLichTrinhCaLamViec),
                new SqlParameter("@ChuKy", _lichTrinhChoCaLamViecDTO.ChuKy)
            };
            base.Procedure("LICHTRINHCHOCALAMVIEC_update", sqlParams);
        }

        public void ThemLichTrinhChoCaLamViec(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _lichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec),
                new SqlParameter("@TenLichTrinhCaLamViec", _lichTrinhChoCaLamViecDTO.TenLichTrinhCaLamViec),
                new SqlParameter("@ChuKy", _lichTrinhChoCaLamViecDTO.ChuKy)
            };
            base.Procedure("LICHTRINHCHOCALAMVIEC_add", sqlParams);
        }

        public void XoaLichTrinhChoCaLamViec(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhCaLamViec", _lichTrinhChoCaLamViecDTO.MaLichTrinhCaLamViec)
            };
            base.Procedure("LICHTRINHCHOCALAMVIEC_delete", sqlParams);
        }

        public void XoaTatCaLichTrinhChoCaLamViec(LichTrinhChoCaLamViecDTO _lichTrinhChoCaLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("LICHTRINHCHOCALAMVIEC_deleteAll", sqlParams);
        }
    }
}
