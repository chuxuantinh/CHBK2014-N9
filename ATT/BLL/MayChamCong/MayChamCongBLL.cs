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
 internal   class MayChamCongBLL
    {
        private MayChamCongDAL _mayChamCongDAL = new MayChamCongDAL();

        public void DELETEMAYCHAMCONG(MayChamCongDTO _mayChamCongDTO)
        {
            this._mayChamCongDAL.DELELEMAYCHAMCONG(_mayChamCongDTO);
        }

        public ArrayList GetAllMCC()
        {
            ArrayList list = new ArrayList();
            return this._mayChamCongDAL.SelectAllMCC();
        }

        public DataTable GETDANHSACHMCC()
        {
            return this._mayChamCongDAL.LOADMAYCHAMCONG();
        }

        public DataTable MayChamCongGetAllByTenMCC(MayChamCongDTO _mayChamCongDTO)
        {
            return this._mayChamCongDAL.MayChamCong_getAllByTenMCC(_mayChamCongDTO);
        }

        public DataTable MayChamCongGetLoad(MayChamCongDTO _mayChamCongDTO)
        {
            return this._mayChamCongDAL.MayChamCong_getLoad(_mayChamCongDTO);
        }

        public void SUAACTIVEKEY(MayChamCongDTO _mayChamCongDTO)
        {
            this._mayChamCongDAL.CapNhatActiveKey(_mayChamCongDTO);
        }

        public void SUAMAYCHAMCONG(MayChamCongDTO _mayChamCongDTO)
        {
            this._mayChamCongDAL.SuaMayChamCong(_mayChamCongDTO);
        }

        public void THEMMAYCHAMCONG(MayChamCongDTO _mayChamCongDTO)
        {
            this._mayChamCongDAL.ThemMayChamCong(_mayChamCongDTO);
        }
    }
}
