using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
   internal class LichTrinhVaoRaDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable getLichTrinhVaoRaByMaLichTrinhVaoRa(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhVaoRa", _lichTrinhVaoRaDTO.MaLichTrinhVaoRa)
            };
            return base.executeNonQuerya("LichTrinhVaoRa_getByMaLichTrinhVaoRa", sqlParams);
        }

        public DataTable LOADLICHTRINHVAORA()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("LICHTRINHVAORA_getall", sqlParams);
        }

        public ArrayList loadLichTrinhVaoRaLenComboBox()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("LICHTRINHVAORA_getall");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                LichTrinhVaoRaDTO adto = new LichTrinhVaoRaDTO(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetBoolean(3), reader.GetBoolean(4), reader.GetDateTime(5), reader.GetDateTime(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9));
                list.Add(adto);
            }
            reader.Close();
            return list;
        }

        public void SuaLichTrinhVaoRa(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhVaoRa", _lichTrinhVaoRaDTO.MaLichTrinhVaoRa),
                new SqlParameter("@TenLichTrinhVaoRa", _lichTrinhVaoRaDTO.TenLichTrinhVaoRa),
                new SqlParameter("@ChonLichTrinhVaoRa", _lichTrinhVaoRaDTO.ChonLichTrinhVaoRa),
                new SqlParameter("@MotLanChamCong", _lichTrinhVaoRaDTO.MotLanChamCong),
                new SqlParameter("@LoaiBoGio", _lichTrinhVaoRaDTO.LoaiBoGio),
                new SqlParameter("@TuGio", _lichTrinhVaoRaDTO.TuGio),
                new SqlParameter("@DenGio", _lichTrinhVaoRaDTO.DenGio),
                new SqlParameter("@ThoiGianNhoNhat", _lichTrinhVaoRaDTO.ThoiGianNhoNhat),
                new SqlParameter("@ThoiGianLonNhat", _lichTrinhVaoRaDTO.ThoiGianLonNhat),
                new SqlParameter("@KhoangCachGiuaHaiCapVaoRa", _lichTrinhVaoRaDTO.KhoangCachGiuaHaiCapVaoRa)
            };
            base.Procedure("LICHTRINHVAORA_update", sqlParams);
        }

        public void ThemLichTrinhVaoRa(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhVaoRa", _lichTrinhVaoRaDTO.MaLichTrinhVaoRa),
                new SqlParameter("@TenLichTrinhVaoRa", _lichTrinhVaoRaDTO.TenLichTrinhVaoRa),
                new SqlParameter("@ChonLichTrinhVaoRa", _lichTrinhVaoRaDTO.ChonLichTrinhVaoRa),
                new SqlParameter("@MotLanChamCong", _lichTrinhVaoRaDTO.MotLanChamCong),
                new SqlParameter("@LoaiBoGio", _lichTrinhVaoRaDTO.LoaiBoGio),
                new SqlParameter("@TuGio", _lichTrinhVaoRaDTO.TuGio),
                new SqlParameter("@DenGio", _lichTrinhVaoRaDTO.DenGio),
                new SqlParameter("@ThoiGianNhoNhat", _lichTrinhVaoRaDTO.ThoiGianNhoNhat),
                new SqlParameter("@ThoiGianLonNhat", _lichTrinhVaoRaDTO.ThoiGianLonNhat),
                new SqlParameter("@KhoangCachGiuaHaiCapVaoRa", _lichTrinhVaoRaDTO.KhoangCachGiuaHaiCapVaoRa)
            };
            base.Procedure("LICHTRINHVAORA_add", sqlParams);
        }

        public void XoaLichTrinhVaoRa(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaLichTrinhVaoRa", _lichTrinhVaoRaDTO.MaLichTrinhVaoRa)
            };
            base.Procedure("LICHTRINHVAORA_delete", sqlParams);
        }

        public void XoaTatCaLichTrinhVaoRa(LichTrinhVaoRaDTO _lichTrinhVaoRaDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("LICHTRINHVAORA_deleteAll", sqlParams);
        }
    }
}
