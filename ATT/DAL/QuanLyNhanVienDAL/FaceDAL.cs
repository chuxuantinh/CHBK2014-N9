using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL
{
  internal  class FaceDAL:Provider
    {


        public DataTable Face_GetByMaChamCong(FaceDTO _faceDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _faceDTO.MaChamCong)
            };
            return base.executeNonQuerya("NHANVIEN_getFaceByMaChamCong", sqlParams);
        }

        public void Insert_Face(FaceDTO _faceDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _faceDTO.MaChamCong),
                new SqlParameter("@FaceID", _faceDTO.FaceID),
                new SqlParameter("@FaceTemplate", _faceDTO.FaceTemplate),
                new SqlParameter("@ChieuDai", _faceDTO.ChieuDai)
            };
            base.Procedure("Face_add", sqlParams);
        }
    }
}
