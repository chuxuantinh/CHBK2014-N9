using CHBK2014_N9.ATT.DAL.HeThongDAL;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.HeThongBLL
{
   internal class NhatKyBLL
    {

        private NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();
        private NguoiDungDAL _nguoiDungDAL = new NguoiDungDAL();
        private NhatKyDAL _nhatKyDAL = new NhatKyDAL();

        public int DelSystemLog(int _ID)
        {
            return this._nhatKyDAL.DelSystemLog(_ID);
        }

        public void NhatKyDelete(NhatKyDTO _nhatKyDTO)
        {
            this._nhatKyDAL.NhatKy_Delete(_nhatKyDTO);
        }

        public void NhatKyHeThongDeleteByThoiGian(NhatKyDTO _nhatKyDTO)
        {
            this._nhatKyDAL.NhatKyHeThong_DeleteByThoiGian(_nhatKyDTO);
        }

        public DataTable NhatKyHeThongGetAll()
        {
            return this._nhatKyDAL.NhatKyHeThong_getALL();
        }

        public DataTable NhatKyHeThongSearch(NhatKyDTO _nhatKyDTO)
        {
            return this._nhatKyDAL.NhatKyHeThong_Search(_nhatKyDTO);
        }

        public DataTable NhatKyHeThongThoiGian(NhatKyDTO _nhatKyDTO)
        {
            return this._nhatKyDAL.NhatKyHeThong_ThoiGian(_nhatKyDTO);
        }
    }
}
