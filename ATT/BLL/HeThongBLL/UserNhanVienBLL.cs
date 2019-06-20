using CHBK2014_N9.ATT.DAL.HeThongDAL;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System;
using System.Data;
namespace CHBK2014_N9.ATT.BLL.HeThongBLL
{
   internal class UserNhanVienBLL
    {

        private UserNhanVienDAL _userNhanVienDAL = new UserNhanVienDAL();

        public DataTable testLoginNhanVien(UserNhanVienDTO _userNhanVienDTO)
        {
            return this._userNhanVienDAL.logInNhanVien(_userNhanVienDTO);
        }
    }
}
