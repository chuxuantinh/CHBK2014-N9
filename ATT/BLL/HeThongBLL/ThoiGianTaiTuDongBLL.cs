using CHBK2014_N9.ATT.DAL.HeThongDAL;
using CHBK2014_N9.ATT.DTO.HethongDTO;
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.HeThongBLL
{
   internal class ThoiGianTaiTuDongBLL
    {
        private ThoiGianTaiTuDongDAL _thoiGianTaiTuDongDAL = new ThoiGianTaiTuDongDAL();

        public void DeleteHenGioTaiTuDong(ThoiGianTaiTuDongDTO _thoiGianTaiTuDongDTO)
        {
            this._thoiGianTaiTuDongDAL.Delete_HenGioTaiTuDong(_thoiGianTaiTuDongDTO);
        }

        public void Insert_CaiDatThoiGian(ThoiGianTaiTuDongDTO _thoiGianTaiTuDongDTO)
        {
            this._thoiGianTaiTuDongDAL.Insert_HenGioTaiTuDong(_thoiGianTaiTuDongDTO);
        }

        public DataTable showThoiGianTaiTuDong(ThoiGianTaiTuDongDTO _thoiGianTaiTuDongDTO)
        {
            return this._thoiGianTaiTuDongDAL.getThoiGianTaiTuDong(_thoiGianTaiTuDongDTO);
        }

        public void Update_CaiDatThoiGian(ThoiGianTaiTuDongDTO _thoiGianTaiTuDongDTO)
        {
            this._thoiGianTaiTuDongDAL.Update_HenGioTaiTuDong(_thoiGianTaiTuDongDTO);
        }
    }
}
