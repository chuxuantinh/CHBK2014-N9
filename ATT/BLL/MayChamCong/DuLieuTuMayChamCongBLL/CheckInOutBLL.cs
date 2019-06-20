using CHBK2014_N9;
using CHBK2014_N9.ATT.BLL.HeThongBLL;
using CHBK2014_N9.ATT.DAL.MayChamCong.DuLieuMayChamCongDAL;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using CHBK2014_N9.ATT.DTO.MayChamCong.DuLieuMayChamCongDTO;
using System;
using System.Data;
namespace CHBK2014_N9.ATT.BLL.MayChamCong.DuLieuTuMayChamCongBLL
{
    internal class CheckInOutBLL
    {

        private CheckInOutDAL _checkInOutDAL = new CheckInOutDAL();
        private NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();
        private NhatKyDTO _nhatKyDTO = new NhatKyDTO();

        public void CheckInOutDeleteByMaChamCong(CheckInOutDTO _checkInOutDTO)
        {
            this._checkInOutDAL.CheckInOut_deleteByMaChamCong(_checkInOutDTO);
        }

        public void CheckInOutDeleteByMaChamCongAndNgayCham(CheckInOutDTO _checkInOutDTO)
        {
            this._checkInOutDAL.CheckInOut_deleteByMaChamCongAndNgayCham(_checkInOutDTO);
        }

        public void CheckInOutDeleteGioCham(CheckInOutDTO _checkInOutDTO)
        {
            this._checkInOutDAL.CheckInOut_DeleteGioCham(_checkInOutDTO);
        }

        public DataTable CheckInOutgetGioChamByMaChamCong(CheckInOutDTO _checkInOutDTO)
        {
            return this._checkInOutDAL.CheckInOut_getGioChamByMaChamCong(_checkInOutDTO);
        }

        public DataTable CheckInOutGetMax(CheckInOutDTO _checkInOutDTO)
        {
            return this._checkInOutDAL.CheckInOut_getMax(_checkInOutDTO);
        }

        public DataTable CheckInOutGetMin(CheckInOutDTO _checkInOutDTO)
        {
            return this._checkInOutDAL.CheckInOut_getMin(_checkInOutDTO);
        }

        public void CheckInOutThemGio(CheckInOutDTO _checkInOutDTO)
        {
           // NhatKyDTO ydto = new NhatKyDTO(frmClassico.MaNguoiDung, DateTime.Now.ToString(), "Th\x00eam giờ", "Th\x00eam giờ", DateTime.Now.ToString());
           // this._nguoiDungBLL.SetSystemLog(ydto);
            this._checkInOutDAL.CheckInOut_ThemGio(_checkInOutDTO);
        }

        public void CheckInOutupdateGioCham(CheckInOutDTO _checkInOutDTO)
        {
            this._checkInOutDAL.CheckInOut_updateGioCham(_checkInOutDTO);
        }

        public void DeleteAllNhanVienByCheckInOut(CheckInOutDTO _checkInOutDTO)
        {
            this._checkInOutDAL.DeleteAll_NhanVienByCheckInOut(_checkInOutDTO);
        }

        public void DeleteNhanVienByCheckInOut(CheckInOutDTO _checkInOutDTO)
        {
            this._checkInOutDAL.Delete_NhanVienByCheckInOut(_checkInOutDTO);
        }

        public DataTable getCheckInOutByMaChamCong(CheckInOutDTO _checkInOutDTO)
        {
            return this._checkInOutDAL.get_CheckInOutByMaChamCong(_checkInOutDTO);
        }

        public DataTable getCheckInOutByMaChamCongAndNgayCham(CheckInOutDTO _checkInOutDTO)
        {
            return this._checkInOutDAL.get_CheckInOutByMaChamCongAndNgayCham(_checkInOutDTO);
        }

        public void Insert_CheckinOut(CheckInOutDTO _checkInOutDTO)
        {
            this._checkInOutDAL.InsertCheckInOut(_checkInOutDTO);
        }

        public DataTable NhanVienGetGioRaVao(CheckInOutDTO _checkInOutDTO)
        {
            return this._checkInOutDAL.NhanVien_GetGioRaVao(_checkInOutDTO);
        }

        public DataTable SelectAllCheckInOut(CheckInOutDTO _checkInOutDTO)
        {
            return this._checkInOutDAL.SelectAll_CheckInOut(_checkInOutDTO);
        }
    }
}
