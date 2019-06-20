using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.BLL.BaoBieuBLL;
using CHBK2014_N9.ATT.DTO.BaoBieuDTO;
using System.Data;
using System.Data.SqlClient;
using CHBK2014_N9.ATT.DAL.Common;


namespace CHBK2014_N9.ATT.DAL.BaoBieuDAL 
{
    internal class TinhCongDAL: Provider
    {
        private DBHelper dbHelper = new DBHelper();

        public void TinhCong_Delete(TinhCongDTO _tinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("TinhCong_delete", sqlParams);
        }

        public DataTable TinhCong_GetAll(TinhCongDTO _tinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            return base.executeNonQuerya("TinhCong_getall", sqlParams);
        }

        public DataTable TinhCong_GetByMaChamCong(TinhCongDTO _tinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _tinhCongDTO.MaChamCong)
            };
            return base.executeNonQuerya("TinhCong_getByMaChamCong", sqlParams);
        }

        public DataTable TinhCong_GetByMaChamCongAndKyHieuPhu(TinhCongDTO _tinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _tinhCongDTO.MaChamCong),
                new SqlParameter("@KyHieuPhu", _tinhCongDTO.KyHieuPhu)
            };
            return base.executeNonQuerya("TinhCong_getByMaChamCongAndKyHieuPhu", sqlParams);
        }

        public DataTable TinhCong_GetByMaChamCongAndLe(TinhCongDTO _tinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _tinhCongDTO.MaChamCong),
                new SqlParameter("@KyHieu", _tinhCongDTO.KyHieu)
            };
            return base.executeNonQuerya("TinhCong_getByMaChamCongAndLe", sqlParams);
        }

        public DataTable TinhCong_GetMaChamCongAndNgay(TinhCongDTO _tinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _tinhCongDTO.MaChamCong),
                new SqlParameter("@Ngay", _tinhCongDTO.Ngay)
            };
            return base.executeNonQuerya("TinhCong_getByMaChamCongAndNgay", sqlParams);
        }

        public DataTable TinhCong_GetNgay(TinhCongDTO _tinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@Ngay", _tinhCongDTO.Ngay)
            };
            return base.executeNonQuerya("TinhCong_getByNgay", sqlParams);
        }

        public DataTable TinhCong_GetNgayAndPhongBan(TinhCongDTO _tinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@Ngay", _tinhCongDTO.Ngay),
                new SqlParameter("@PhongBan", _tinhCongDTO.PhongBan)
            };
            return base.executeNonQuerya("TinhCong_getByNgayAndPhongBan", sqlParams);
        }

        public void TinhCong_Insert(TinhCongDTO _tinhCongDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _tinhCongDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _tinhCongDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _tinhCongDTO.MaChamCong),
                new SqlParameter("@Ngay", _tinhCongDTO.Ngay),
                new SqlParameter("@Thu", _tinhCongDTO.Thu),
                new SqlParameter("@Ca", _tinhCongDTO.Ca),
                new SqlParameter("@GioVao", _tinhCongDTO.GioVao),
                new SqlParameter("@GioRa", _tinhCongDTO.GioRa),
                new SqlParameter("@Cong", _tinhCongDTO.Cong),
                new SqlParameter("@Gio", _tinhCongDTO.Gio),
                new SqlParameter("@Tre", _tinhCongDTO.Tre),
                new SqlParameter("@VeSom", _tinhCongDTO.VeSom),
                new SqlParameter("@VeTre", _tinhCongDTO.VeTre),
                new SqlParameter("@TC1", _tinhCongDTO.TC1),
                new SqlParameter("@TC2", _tinhCongDTO.TC2),
                new SqlParameter("@TC3", _tinhCongDTO.TC3),
                new SqlParameter("@TC4", _tinhCongDTO.TC4),
                new SqlParameter("@TongGio", _tinhCongDTO.TongGio),
                new SqlParameter("@DemCong", _tinhCongDTO.DemCong),
                new SqlParameter("@KyHieu", _tinhCongDTO.KyHieu),
                new SqlParameter("@KyHieuPhu", _tinhCongDTO.KyHieuPhu),
                new SqlParameter("@PhongBan", _tinhCongDTO.PhongBan)
            };
            base.Procedure("TinhCong_add", sqlParams);
        }

    }
}
