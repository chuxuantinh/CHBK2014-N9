using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using System;
using System.Collections;
using System.Data;

namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL
{
   internal class TinhThanhBLL
    {
        private TinhThanhDAL _tinhThanhDAL = new TinhThanhDAL();

        public ArrayList GetAllComboBoxTinhThanh()
        {
            ArrayList list = new ArrayList();
            list = this._tinhThanhDAL.loadComBoBox();
            if (list.Count != 0)
            {
                return list;
            }
            return null;
        }

        public DataTable Load_TinhThanh()
        {
            return this._tinhThanhDAL.LoadTinhThanh();
        }

        public void Sua_TinhThanh(TinhThanhDTO _tinhThanhDTO)
        {
            this._tinhThanhDAL.SuaTinhThanh(_tinhThanhDTO);
        }

        public void Them_TinhThanh(TinhThanhDTO _tinhThanhDTO)
        {
            this._tinhThanhDAL.ThemTinhThanh(_tinhThanhDTO);
        }

        public void Xoa_TinhThanh(TinhThanhDTO _tinhThanhDTO)
        {
            this._tinhThanhDAL.XoaTinhThanh(_tinhThanhDTO);
        }
    }
}
