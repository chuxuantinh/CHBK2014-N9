using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.DanhMucDTO;


namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.DanhMucDAL
{
  internal  class DanTocDAL: Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public void Insert_DanToc(DanTocDTO _danTocDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaDanToc", _danTocDTO.MaDanToc),
                new SqlParameter("@DanToc", _danTocDTO.DanToc)
            };
            base.Procedure("DanToc_add", sqlParams);
        }

        public DataTable Load_DanToc()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("DanToc_getall", sqlParams);
        }

        public void Update_DanToc(DanTocDTO _danTocDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaDanToc", _danTocDTO.MaDanToc),
                new SqlParameter("@DanToc", _danTocDTO.DanToc)
            };
            base.Procedure("DanToc_update", sqlParams);
        }
    }
}
