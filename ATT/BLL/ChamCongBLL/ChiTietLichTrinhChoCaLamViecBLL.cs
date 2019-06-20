using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
   internal class ChiTietLichTrinhChoCaLamViecBLL
    {

        private ChiTietLichTrinhChoCaLamViecDAL _chiTietLichTrinhChoCaLamViecDAL = new ChiTietLichTrinhChoCaLamViecDAL();

        public DataTable ChiTietLichTrinhChoCaLamViecgetByMaLichTrinhCalamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            return this._chiTietLichTrinhChoCaLamViecDAL.ChiTietLichTrinhCaLamViec_getByMaLichTrinhCaLamViec(_chiTietLichTrinhChoCaLamViecDTO);
        }

        public DataTable ChiTietLichTrinhChoCaLamViecGetID(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            return this._chiTietLichTrinhChoCaLamViecDAL.ChiTietLichTrinhCaLamViec_getByID(_chiTietLichTrinhChoCaLamViecDTO);
        }

        public DataTable ChiTietLichTrinhChoCaLamViecNhanCa(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            return this._chiTietLichTrinhChoCaLamViecDAL.ChiTietLichTrinhCaLamViec_NhanCa(_chiTietLichTrinhChoCaLamViecDTO);
        }

        public void DeleteChiTietLichTrinhChoCaLamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            this._chiTietLichTrinhChoCaLamViecDAL.Delete_ChiTietLichTrinhCaLamViec(_chiTietLichTrinhChoCaLamViecDTO);
        }

        public DataTable getChiTietLichTrinhChoCaLamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            return this._chiTietLichTrinhChoCaLamViecDAL.get_ChiTietLichTrinhChoCaLamViec(_chiTietLichTrinhChoCaLamViecDTO);
        }

        public void InsertChiTietLichTrinhChoCaLamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            this._chiTietLichTrinhChoCaLamViecDAL.Insert_ChiTietLichTrinhChoCaLamViec(_chiTietLichTrinhChoCaLamViecDTO);
        }

        public void UpdateChiTietLichTrinhChoCaLamViec(ChiTietLichTrinhChoCaLamViecDTO _chiTietLichTrinhChoCaLamViecDTO)
        {
            this._chiTietLichTrinhChoCaLamViecDAL.Update_ChiTietLichTrinhChoCaLamViec(_chiTietLichTrinhChoCaLamViecDTO);
        }
    }
}

