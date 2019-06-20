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
   internal class QuocTichDAL :Provider    {

        private DBHelper dbHelper = new DBHelper();

        public void Insert_QuocTich(QuocTichDTO _QuocTichDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaQuocTich", _QuocTichDTO.MaQuocTich),
                new SqlParameter("@QuocTich", _QuocTichDTO.QuocTich)
            };
            base.Procedure("QuocTich_add", sqlParams);
        }

        public DataTable Load_QuocTich()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("QuocTich_getall", sqlParams);
        }

        public void Update_QuocTich(QuocTichDTO _quocTichDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaQuocTich", _quocTichDTO.MaQuocTich),
                new SqlParameter("@QuocTich", _quocTichDTO.QuocTich)
            };
            base.Procedure("QuocTich_update", sqlParams);
        }
    }
}
