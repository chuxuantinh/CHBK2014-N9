using CHBK2014_N9.ATT.DAL.HeThongDAL;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.HeThongBLL
{
  internal  class NguoiDungBLL
    {
        private NguoiDungDAL _nguoiDungDAL = new NguoiDungDAL();

        public void DoiMatKhau(NguoiDungDTO _nguoiDungDTO)
        {
            this._nguoiDungDAL.DoiMatKhau(_nguoiDungDTO);
        }

        public DataTable GETDANHSACHNGUOIDUNG()
        {
            return this._nguoiDungDAL.LOADNGUOIDUNG();
        }

        public NhatKyDTO GetLastLoginUser(string _MaNguoiDung)
        {
            return this._nguoiDungDAL.SelectLastLoginUser(_MaNguoiDung);
        }

        public DataTable getNguoiDung()
        {
            return this._nguoiDungDAL.get_NguoiDung();
        }

        public DataTable getNguoiDungByMaNguoiDung(NguoiDungDTO _nguoiDungDTO)
        {
            return this._nguoiDungDAL.get_nguoiDungByMaNguoiDung(_nguoiDungDTO);
        }

        public NguoiDungDTO GetUser(string _TenDangNhap, string _MatKhau)
        {
            return this._nguoiDungDAL.SelectUser(_TenDangNhap, _MatKhau);
        }

        public DataTable KiemTraPass(NguoiDungDTO _nguoiDungDTO)
        {
            return this._nguoiDungDAL.KiemTraMatKhau(_nguoiDungDTO);
        }

        public DataTable NguoiDungDelete(NguoiDungDTO _nguoiDungDTO)
        {
            return this._nguoiDungDAL.NguoiDung_Delete(_nguoiDungDTO);
        }

        public DataTable NguoiDungDeleteAll(NguoiDungDTO _nguoiDungDTO)
        {
            return this._nguoiDungDAL.NguoiDung_DeleteAll(_nguoiDungDTO);
        }

        public void SetSystemLog(NhatKyDTO _nhatKyDTO)
        {
            this._nguoiDungDAL.InsertSystemLog(_nhatKyDTO);
        }

        public void SUANGUOIDUNG(NguoiDungDTO _nguoiDungDTO)
        {
            this._nguoiDungDAL.SuaNguoiDung(_nguoiDungDTO);
        }

        public DataTable testLogin(NguoiDungDTO _nguoiDungDTO)
        {
            return this._nguoiDungDAL.logIn(_nguoiDungDTO);
        }

        public void THEMNGUOIDUNG(NguoiDungDTO _nguoiDungDTO)
        {
            this._nguoiDungDAL.ThemNguoiDung(_nguoiDungDTO);
        }

        public void Xoa_NguoiDungTatCa(NguoiDungDTO _nguoiDungDTO)
        {
            this._nguoiDungDAL.Xoa_TatCaNguoiDung(_nguoiDungDTO);
        }
    }
}
