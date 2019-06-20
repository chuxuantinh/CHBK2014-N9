using CHBK2014_N9.ATT.DAL.ChamCongDAL;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.ChamCongBLL
{
  internal  class NgayCuoiTuanBLL
    {

        private NgayCuoiTuanDAL _ngayCuoiTuanDAL = new NgayCuoiTuanDAL();

        public void DeleteNgayCuoiTuan(NgayCuoiTuanDTO _ngayCuoiTuanDTO)
        {
            this._ngayCuoiTuanDAL.Delete_NgayCuoiTuan(_ngayCuoiTuanDTO);
        }

        public void Insert_NgayCuoiTuan(NgayCuoiTuanDTO _ngayCuoiTuanDTO)
        {
            this._ngayCuoiTuanDAL.InsertNgayCuoiTuan(_ngayCuoiTuanDTO);
        }

        public DataTable showLoadNgayCuoiTuan(NgayCuoiTuanDTO _ngayCuoiTuanDTO)
        {
            return this._ngayCuoiTuanDAL.getLoadNgayCuoiTuan(_ngayCuoiTuanDTO);
        }

        public DataTable showNgayCuoiTuan()
        {
            return this._ngayCuoiTuanDAL.getNgayCuoiTuan();
        }
    }
}
