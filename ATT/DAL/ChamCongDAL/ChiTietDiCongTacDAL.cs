using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
   internal class ChiTietDiCongTacDAL:Provider
    {


        private DBHelper dbHelper = new DBHelper();

        public DataTable ChiTietDiCongTac_getTinhCong(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietDiCongTacDTO.MaChamCong),
                new SqlParameter("@Ngay", _chiTietDiCongTacDTO.Ngay)
            };
            return base.executeNonQuerya("ChiTietDiCongTac_getTinhCong", sqlParams);
        }

        public void Delete_ChiTietDiCongTac(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _chiTietDiCongTacDTO.ID)
            };
            base.Procedure("ChiTietDiCongTac_delete", sqlParams);
        }

        public void Delete_ChiTietDiCongTacByMaChamCong(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietDiCongTacDTO.MaChamCong)
            };
            base.Procedure("ChiTietDiCongTac_DeleteByMaChamCong", sqlParams);
        }

        public DataTable get_ChiTietDiCongTac(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietDiCongTacDTO.MaChamCong)
            };
            return base.executeNonQuerya("ChiTietDiCongTac_get", sqlParams);
        }

        public void Insert_ChiTietDiCongTac(ChiTietDiCongTacDTO _chiTietDiCongTacDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _chiTietDiCongTacDTO.MaChamCong),
                new SqlParameter("@Ngay", _chiTietDiCongTacDTO.Ngay),
                new SqlParameter("@GioDi", _chiTietDiCongTacDTO.GioDi),
                new SqlParameter("@GioVe", _chiTietDiCongTacDTO.GioVe),
                new SqlParameter("@TongGioCongTac", _chiTietDiCongTacDTO.TongGioCongTac),
                new SqlParameter("@CongTinhCongTac", _chiTietDiCongTacDTO.CongTinhCongTac),
                new SqlParameter("@LyDo", _chiTietDiCongTacDTO.LyDo)
            };
            base.Procedure("ChiTietDiCongTac_add", sqlParams);
        }
    }
}
