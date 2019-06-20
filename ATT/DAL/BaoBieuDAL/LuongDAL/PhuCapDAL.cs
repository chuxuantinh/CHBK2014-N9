using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL
{
    internal class PhuCapDAL: Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void Delete_PhuCap(PhuCapDTO _phuCapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhuCap", _phuCapDTO.MaPhuCap)
            };
            base.Procedure("PHUCAP_delete", sqlParams);
        }

        public void DeleteALL_PhuCap(PhuCapDTO _phuCapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("PHUCAP_deleteAll", sqlParams);
        }

        public DataTable get_LoadControlPhuCap(PhuCapDTO _phuCapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhuCap", _phuCapDTO.MaPhuCap)
            };
            return base.executeNonQuerya("PHUCAP_loadConTrol", sqlParams);
        }

        public void InsertPhuCap(PhuCapDTO _phuCapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhuCap", _phuCapDTO.MaPhuCap),
                new SqlParameter("@TenPhuCap", _phuCapDTO.TenPhuCap),
                new SqlParameter("@SoTienPhuCap", _phuCapDTO.SoTienPhuCap),
                new SqlParameter("@GhiChu", _phuCapDTO.GhiChu),
                new SqlParameter("@SuDung", _phuCapDTO.SuDung),
                new SqlParameter("@KyHieuPhuCap", _phuCapDTO.KyHieuPhuCap)
            };
            base.Procedure("PHUCAP_add", sqlParams);
        }

        public DataTable loadPhuCap()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("PHUCAP_getall", sqlParams);
        }

        public ArrayList loadPhuCapLenCombobox()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("PHUCAP_getall");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                PhuCapDTO pdto = new PhuCapDTO(reader.GetString(0), reader.GetString(1));
                list.Add(pdto);
            }
            reader.Close();
            return list;
        }

        public void UpdatePhuCap(PhuCapDTO _phuCapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaPhuCap", _phuCapDTO.MaPhuCap),
                new SqlParameter("@TenPhuCap", _phuCapDTO.TenPhuCap),
                new SqlParameter("@SoTienPhuCap", _phuCapDTO.SoTienPhuCap),
                new SqlParameter("@GhiChu", _phuCapDTO.GhiChu),
                new SqlParameter("@SuDung", _phuCapDTO.SuDung),
                new SqlParameter("@KyHieuPhuCap", _phuCapDTO.KyHieuPhuCap)
            };
            base.Procedure("PHUCAP_update", sqlParams);
        }
    }
}
