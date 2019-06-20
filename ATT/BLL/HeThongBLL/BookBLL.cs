using CHBK2014_N9.ATT.DAL.HeThongDAL;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.HeThongBLL
{
  internal  class BookBLL
    {
        private BookDAL _bookDAL = new BookDAL();

        public void InsertBook(BookDTO _bookDTO)
        {
            this._bookDAL.Insert_Book(_bookDTO);
        }
    }
}
