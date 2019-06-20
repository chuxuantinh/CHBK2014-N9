using CHBK2014_N9.ATT.DAL.HeThongDAL;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.HeThongBLL
{
  internal  class UserBLL
    {
        private UserDAL _userDAL = new UserDAL();

        public NhatKyDTO GetLastLoginUser(string _MaNguoiDung)
        {
            return this._userDAL.SelectLastLoginUser(_MaNguoiDung);
        }

        public NguoiDungDTO GetUser(string _TenDangNhap, string _MatKhau)
        {
            return this._userDAL.SelectUser(_TenDangNhap, _MatKhau);
        }

        public void SetSystemLog(NhatKyDTO _nhatKyDTO)
        {
            this._userDAL.InsertSystemLog(_nhatKyDTO);
        }

        public DataTable testLogin(UserDTO _userDTO)
        {
            return this._userDAL.logIn(_userDTO);
        }
    }
}
