using CHBK2014_N9;
using CHBK2014_N9.ATT.BLL.HeThongBLL;
using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using CHBK2014_N9.ATT.DTO.HethongDTO; 
using System;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
   internal class TuyChonBLL
    {

        private NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();
        private NguoiDungDTO _nguoiDungDTO = new NguoiDungDTO();
        private NhatKyDTO _nhatKyDTO = new NhatKyDTO();
        private TuyChonDAL _tuyChonDAL = new TuyChonDAL();

        public void CAPNHATTUYCHON(TuyChonDTO _tuyChonDTO)
        {
            this._tuyChonDAL.SuaTuyChon(_tuyChonDTO);
        //    NhatKyDTO ydto = new NhatKyDTO(frmClassico.MaNguoiDung, DateTime.Now.ToString(), "T\x00f9y chọn", "Cập nhật", DateTime.Now.ToString());
          //  this._nguoiDungBLL.SetSystemLog(ydto);
        }

        public DataTable showLoadTuyChon(TuyChonDTO _tuyChonDTO)
        {
        //    NhatKyDTO ydto = new NhatKyDTO(frmClassico.MaNguoiDung, DateTime.Now.ToString(), "T\x00f9y chọn", "Xem", DateTime.Now.ToString());
          //  this._nguoiDungBLL.SetSystemLog(ydto);
            return this._tuyChonDAL.getLoadTuyChon(_tuyChonDTO);
        }

        public DataTable showThongTinTuyChon(TuyChonDTO _tuyChonDTO)
        {
            return this._tuyChonDAL.getTuyChon(_tuyChonDTO);
        }

        public void THEMTUYCHON(TuyChonDTO _tuyChonDTO)
        {
            this._tuyChonDAL.ThemTuyChon(_tuyChonDTO);
        }
    }
}
