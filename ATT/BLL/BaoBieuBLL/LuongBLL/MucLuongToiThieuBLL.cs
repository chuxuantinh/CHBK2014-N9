using CHBK2014_N9.ATT.DAL.BaoBieuDAL.LuongDAL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO.LuongDTO;
using System;
using System.Data;


namespace CHBK2014_N9.ATT.BLL.BaoBieuBLL.LuongBLL
{
    internal class MucLuongToiThieuBLL
    {

        private MucLuongToiThieuDALL _mucLuongToiThieuDAL = new MucLuongToiThieuDALL();


        public void CAPNHAT_MUCLUONGTOITHIEU(MucLuongToiThieuDTO _mucLuongToiThieuDTO)
        {
            this._mucLuongToiThieuDAL.SuaMucLuongYoiThieu(_mucLuongToiThieuDTO);
        }

        public DataTable show_MUCLUONGTOITHIEU(MucLuongToiThieuDTO _mucLuongToiThieuDTO)
        {
            return this._mucLuongToiThieuDAL.getMucLuongYoiThieu(_mucLuongToiThieuDTO);
        }

        public DataTable showLoad_MUCLUONGTOITHIEU(MucLuongToiThieuDTO _mucLuongToiThieuDTO)
        {
            return this._mucLuongToiThieuDAL.getLoadMucLuongYoiThieu(_mucLuongToiThieuDTO);
        }

        public void THEM_MUCLUONGTOITHIEU(MucLuongToiThieuDTO _mucLuongToiThieuDTO)
        {
            this._mucLuongToiThieuDAL.ThemMucLuongYoiThieu(_mucLuongToiThieuDTO);
        }
    }
}
