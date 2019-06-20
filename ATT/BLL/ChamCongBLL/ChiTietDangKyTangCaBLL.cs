using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
   internal class ChiTietDangKyTangCaBLL
    {

        private ChiTietDangKyTangCaDAL _chiTietDangKyTangCaDAL = new ChiTietDangKyTangCaDAL();

        public void ChiTietDangKyTangCaDelete(ChiTietDangKyTangCaDTO _chiTietDangKyTangCaDTO)
        {
            this._chiTietDangKyTangCaDAL.ChiTietDangKyTangCa_Delete(_chiTietDangKyTangCaDTO);
        }

        public DataTable ChiTietDangKyTangCaGetByMaChamCong(ChiTietDangKyTangCaDTO _chiTietDangKyTangCaDTO)
        {
            return this._chiTietDangKyTangCaDAL.ChiTietDangKyTangCa_GetByMaChamCong(_chiTietDangKyTangCaDTO);
        }

        public void DeleteChiTietDangKyTangCaByMaChamCong(ChiTietDangKyTangCaDTO _chiTietDangKyTangCaDTO)
        {
            this._chiTietDangKyTangCaDAL.Delete_ChiTietDangKyTangCaByMaChamCong(_chiTietDangKyTangCaDTO);
        }

        public void InsertChiTietDangKyTangCa(ChiTietDangKyTangCaDTO _chiTietDangKyTangCaDTO)
        {
            this._chiTietDangKyTangCaDAL.Insert_ChiTietDangKyTangCa(_chiTietDangKyTangCaDTO);
        }
    }
}
