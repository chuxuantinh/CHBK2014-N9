using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.MayChamCong;
using CHBK2014_N9.ATT.DTO.MayChamCong;
using System.Data;
using System.Collections;

namespace CHBK2014_N9.ATT.BLL.MayChamCong
{
   internal class ThongTinMayChuBLL
    {
        private ThongTinMayChuDAL _thongTinMayChuDAL = new ThongTinMayChuDAL();

        public DataTable getLoadThongTinMayChu(ThongTinMayChuDTO _thongTinMayChuDTO)
        {
            return this._thongTinMayChuDAL.get_LoadThongTinMayChu(_thongTinMayChuDTO);
        }

        public DataTable getThongTinMayChu(ThongTinMayChuDTO _thongTinMayChuDTO)
        {
            return this._thongTinMayChuDAL.get_ThongTinMayChu(_thongTinMayChuDTO);
        }

        public void InsertThongTinMayChu(ThongTinMayChuDTO _thongTinMayChuDTO)
        {
            this._thongTinMayChuDAL.Insert_ThongTinMayChu(_thongTinMayChuDTO);
        }

        public void UpdateThongTinMayChu(ThongTinMayChuDTO _thongTinMayChuDTO)
        {
            this._thongTinMayChuDAL.Update_ThongTinMayChu(_thongTinMayChuDTO);
        }
    }
}
