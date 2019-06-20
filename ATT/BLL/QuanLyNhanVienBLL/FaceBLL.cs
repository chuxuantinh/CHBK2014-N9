using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Data;


namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL
{
   internal class FaceBLL
    {
        private FaceDAL _faceDAL = new FaceDAL();

        public DataTable FaceGetByMaChamCong(FaceDTO _faceDTO)
        {
            return this._faceDAL.Face_GetByMaChamCong(_faceDTO);
        }

        public void InsertFace(FaceDTO _faceDTO)
        {
            this._faceDAL.Insert_Face(_faceDTO);
        }
    }
}
