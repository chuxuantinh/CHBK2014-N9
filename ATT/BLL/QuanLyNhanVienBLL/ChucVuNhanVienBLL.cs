using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL
{
  internal  class ChucVuNhanVienBLL
    {
        private ChucVuNhanVienDAL _chucVuNhanVienDAL = new ChucVuNhanVienDAL();

        public ArrayList GetAllComboBoxChucVuNhanVien()
        {
            ArrayList list = new ArrayList();
            list = this._chucVuNhanVienDAL.loadComBoBox();
            if (list.Count != 0)
            {
                return list;
            }
            return null;
        }

        public DataTable Load_DanhSachChucVuNhanVien()
        {
            return this._chucVuNhanVienDAL.LoadChucVuNhanVien();
        }

        public void Sua_ChucVuNhanVien(ChucVuNhanVienDTO _chucVuNhanVienDTO)
        {
            this._chucVuNhanVienDAL.SuaChucVuNhanVien(_chucVuNhanVienDTO);
        }

        public void Them_ChucVuNhanVien(ChucVuNhanVienDTO _chucVuNhanVienDTO)
        {
            this._chucVuNhanVienDAL.ThemChucVuNhanVien(_chucVuNhanVienDTO);
        }

        public void Xoa_ChucVuNhanVien(ChucVuNhanVienDTO _chucVuNhanVienDTO)
        {
            this._chucVuNhanVienDAL.XoaChucVuNhanVien(_chucVuNhanVienDTO);
        }
    }
}
