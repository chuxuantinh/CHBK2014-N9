using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.HeThongDAL
{
   internal class BookDAL:Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public void Insert_Book(BookDTO _bookDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@BookID", _bookDTO.BookID),
                new SqlParameter("@Name", _bookDTO.Name),
                new SqlParameter("@Author", _bookDTO.Author)
            };
            base.Procedure("Book_add", sqlParams);
        }
    }
}
