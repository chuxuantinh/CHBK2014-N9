using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.DanhMucDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.DanhMucDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL.DanhMucBLL
{
   internal class QuocTichBLL
    {

        private QuocTichDAL _quocTichDAL = new QuocTichDAL();

        public void InsertQuocTich(QuocTichDTO _quocTichDTO)
        {
            this._quocTichDAL.Insert_QuocTich(_quocTichDTO);
        }

        public DataTable loadQuocTich()
        {
            return this._quocTichDAL.Load_QuocTich();
        }

        public void UpdateQuocTich(QuocTichDTO _quocTichDTO)
        {
            this._quocTichDAL.Update_QuocTich(_quocTichDTO);
        }
    }
}
