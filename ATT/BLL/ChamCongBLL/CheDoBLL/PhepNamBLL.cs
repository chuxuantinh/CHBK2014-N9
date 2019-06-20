using System;
using System.Data;
using CHBK2014_N9.ATT.DAL.ChamCongDAL.CheDoDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO.CheDoDTO;


namespace CHBK2014_N9.ATT.BLL.ChamCongBLL.CheDoBLL
{
   internal class PhepNamBLL
    {

        private PhepNamDAL _phepNamDAL = new PhepNamDAL();

        public void DeleteAllPhepNamByMaChamCong(PhepNamDTO _phepNamDTO)
        {
            this._phepNamDAL.DeleteAll_PhepNamByMaChamCong(_phepNamDTO);
        }

        public void DeletePhepNamByID(PhepNamDTO _phepNamDTO)
        {
            this._phepNamDAL.Delete_PhepNamByID(_phepNamDTO);
        }

        public void DeletePhepNamByMaChamCong(PhepNamDTO _phepNamDTO)
        {
            this._phepNamDAL.Delete_PhepNamByMaChamCong(_phepNamDTO);
        }

        public DataTable load_PhepNam()
        {
            return this._phepNamDAL.LoadPhepNam();
        }

        public DataTable PhepNamGetTinhCong(PhepNamDTO _phepNamDTO)
        {
            return this._phepNamDAL.PhepNam_getTinhCong(_phepNamDTO);
        }

        public DataTable SelectPhepNamByMaChamCong(PhepNamDTO _phepNamDTO)
        {
            return this._phepNamDAL.Select_PhepNamByMaChamCong(_phepNamDTO);
        }

        public void Them_PhepNam(PhepNamDTO _phepNamDTO)
        {
            this._phepNamDAL.ThemPhepNam(_phepNamDTO);
        }

        public void Xoa_PhepNam(PhepNamDTO _phepNamDTO)
        {
            this._phepNamDAL.XoaPhepNam(_phepNamDTO);
        }

        public void Xoa_TatCaPhepNam(PhepNamDTO _phepNamDTO)
        {
            this._phepNamDAL.XoaTatCaPhepNam(_phepNamDTO);
        }
    }
}
