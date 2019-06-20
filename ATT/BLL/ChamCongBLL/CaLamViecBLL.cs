using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
   internal class CaLamViecBLL
    {

        private CaLamViecDAL _caLamViecDAL = new CaLamViecDAL();

        public DataTable CaLamViecGetByMaCaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            return this._caLamViecDAL.CaLamViec_getByMaCaLamViec(_caLamViecDTO);
        }

        public DataTable CaLamViecgetDataGirdView(CaLamViecDTO _caLamViecDTO)
        {
            return this._caLamViecDAL.CaLamViec_getDataGirdView(_caLamViecDTO);
        }

        public DataTable CaLamViecSelectTenCa()
        {
            return this._caLamViecDAL.CaLamViec_SelectTenCa();
        }

        public void DeleteCaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            this._caLamViecDAL.Delete_CaLamViec(_caLamViecDTO);
        }

        public ArrayList GetAllloadComboBox()
        {
            ArrayList list = new ArrayList();
            return this._caLamViecDAL.SelectAllComboBox();
        }

        public DataTable getCaLamViec()
        {
            return this._caLamViecDAL.get_CaLamViec();
        }

        public DataTable getCaLamViecByMaCaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            return this._caLamViecDAL.get_CaLamViecByMaCaLamViec(_caLamViecDTO);
        }

        public DataTable GETDANHSACHCALAMVIEC()
        {
            return this._caLamViecDAL.LOADCALAMVIEC();
        }

        public DataTable getMaByTenCaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            return this._caLamViecDAL.get_MaByTenCaLamViec(_caLamViecDTO);
        }

        public ArrayList GetTenCaLamViec()
        {
            ArrayList list = new ArrayList();
            return this._caLamViecDAL.SelectTenCaLamViec();
        }

        public void InsertCaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            this._caLamViecDAL.Insert_CaLamViec(_caLamViecDTO);
        }

        public void UpdateCaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            this._caLamViecDAL.Update_CaLamViec(_caLamViecDTO);
        }
    }
}
