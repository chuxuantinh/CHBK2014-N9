using CHBK2014_N9.ATT.DAL.QuanLyNhanVienDAL.SoDoQuanLyDAL;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO.SoDoQuanLyDTO;
using System;
using System.Collections;
using System.Data;
namespace CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL.SoDoQuanLyBLL
{
 internal   class PhongBanBLL
    {
        private PhongBanDAL _phongBanDAL = new PhongBanDAL();

        public DataTable GetAll_PhongBan_TenPhongBan()
        {
            return this._phongBanDAL.getAllPhongBan_TenPhongBan();
        }

        public ArrayList GetAllComboBoxPhongBan()
        {
            ArrayList list = new ArrayList();
            list = this._phongBanDAL.SelectAllPhongBan_1();
            if (list.Count != 0)
            {
                return list;
            }
            return null;
        }

        public ArrayList GetAllPhongBan(string _tenPhongBan)
        {
            ArrayList list = new ArrayList();
            list = this._phongBanDAL.SelectAllPhongBan(_tenPhongBan);
            if (list.Count != 0)
            {
                return list;
            }
            return null;
        }

        public DataTable GETPHONGBANTREEVIEW(PhongBanDTO _phongBanDTO)
        {
            return this._phongBanDAL.GETPHONGBANTREEVIEW(_phongBanDTO);
        }

        public DataTable getTenPhongBanByMaPhongBan(PhongBanDTO _phongBanDTO)
        {
            return this._phongBanDAL.get_TenPhongBanByMaPhongBan(_phongBanDTO);
        }

        public void InsertPhongBan(PhongBanDTO _phongBanDTO)
        {
            this._phongBanDAL.Insert_PhongBan(_phongBanDTO);
        }

        public DataTable LOADKHUVUC()
        {
            return this._phongBanDAL.LoadPhongBan();
        }

        public DataTable PhongBan_getKhuVuc(PhongBanDTO _phongBanDTO)
        {
            return this._phongBanDAL.PhongBan_getKhuVuc(_phongBanDTO);
        }

        public void PhongBanDelete(PhongBanDTO _phongBanDTO)
        {
            this._phongBanDAL.PhongBan_Delete(_phongBanDTO);
        }

        public DataTable PhongBanGetTreeView(PhongBanDTO _phongBanDTO)
        {
            return this._phongBanDAL.PhongBan_getTreeview(_phongBanDTO);
        }

        public bool SUAPHONGBAN(PhongBanDTO _phongBanDTO)
        {
            return (this._phongBanDAL.SuaPhongBan(_phongBanDTO) > 0);
        }

        public bool THEMPHONGBAN(PhongBanDTO _phongBanDTO)
        {
            return (this._phongBanDAL.ThemPhongBan(_phongBanDTO) > 0);
        }

        public void UpdatePhongBan(PhongBanDTO _phongBanDTO)
        {
            this._phongBanDAL.Update_PhongBan(_phongBanDTO);
        }
    }
}
