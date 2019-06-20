using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.MayChamCong.DuLieuMayChamCongDTO;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.MayChamCong.DuLieuMayChamCongDAL
{
   internal class CheckInOutDAL: Provider

        {

        private DBHelper dbHelper = new DBHelper();

        public void CheckInOut_deleteByMaChamCong(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong)
            };
            base.Procedure("CheckInOut_deleteByMaChamCong", sqlParams);
        }

        public void CheckInOut_deleteByMaChamCongAndNgayCham(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong),
                new SqlParameter("@NgayCham", _checkInOutDTO.NgayCham)
            };
            base.Procedure("CheckInOut_deleteByMaChamCongAndNgayCham", sqlParams);
        }

        public void CheckInOut_DeleteGioCham(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _checkInOutDTO.ID)
            };
            base.Procedure("CheckInOut_deleteGioCham", sqlParams);
        }

        public DataTable CheckInOut_getGioChamByMaChamCong(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong)
            };
            return base.executeNonQuerya("CheckInOut_getGioChamByMaChamCong", sqlParams);
        }

        public DataTable CheckInOut_getMax(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong),
                new SqlParameter("@NgayCham", _checkInOutDTO.NgayCham)
            };
            return base.executeNonQuerya("CheckInOut_getMax", sqlParams);
        }

        public DataTable CheckInOut_getMin(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong),
                new SqlParameter("@NgayCham", _checkInOutDTO.NgayCham)
            };
            return base.executeNonQuerya("CheckInOut_getMin", sqlParams);
        }

        public void CheckInOut_ThemGio(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong),
                new SqlParameter("@NgayCham", _checkInOutDTO.NgayCham),
                new SqlParameter("@GioCham", _checkInOutDTO.GioCham),
                new SqlParameter("@KieuCham", _checkInOutDTO.KieuCham),
                new SqlParameter("@NguonCham", _checkInOutDTO.NguonCham),
                new SqlParameter("@MaSoMay", _checkInOutDTO.MaSoMay),
                new SqlParameter("@TenMay", _checkInOutDTO.TenMay)
            };
            base.Procedure("CheckInOut_ThemGio", sqlParams);
        }

        public void CheckInOut_updateGioCham(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@ID", _checkInOutDTO.ID),
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong),
                new SqlParameter("@GioCham", _checkInOutDTO.GioCham),
                new SqlParameter("@KieuCham", _checkInOutDTO.KieuCham),
                new SqlParameter("@MaSoMay", _checkInOutDTO.MaSoMay)
            };
            base.Procedure("CheckInOut_updateGioCham", sqlParams);
        }

        public void Delete_NhanVienByCheckInOut(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong)
            };
            base.Procedure("NHANVIEN_deleteCheckInOut", sqlParams);
        }

        public void DeleteAll_NhanVienByCheckInOut(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            base.Procedure("CheckInOut_deleteAll", sqlParams);
        }

        public DataTable get_CheckInOutByMaChamCong(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong),
                new SqlParameter("@NgayCham", _checkInOutDTO.NgayCham)
            };
            return base.executeNonQuerya("NhanVien_getACLog", sqlParams);
        }

        public DataTable get_CheckInOutByMaChamCongAndNgayCham(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong),
                new SqlParameter("@NgayCham", _checkInOutDTO.NgayCham)
            };
            return base.executeNonQuerya("NhanVien_getNhanVienByMaChamCongAndDatetime", sqlParams);
        }

        public void InsertCheckInOut(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong),
                new SqlParameter("@NgayCham", _checkInOutDTO.NgayCham),
                new SqlParameter("@GioCham", _checkInOutDTO.GioCham),
                new SqlParameter("@KieuCham", _checkInOutDTO.KieuCham),
                new SqlParameter("@NguonCham", _checkInOutDTO.NguonCham),
                new SqlParameter("@MaSoMay", _checkInOutDTO.MaSoMay),
                new SqlParameter("@TenMay", _checkInOutDTO.TenMay)
            };
            base.Procedure("CheckInOut_add", sqlParams);
        }

        public DataTable NhanVien_GetGioRaVao(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaChamCong", _checkInOutDTO.MaChamCong),
                new SqlParameter("@NgayCham", _checkInOutDTO.NgayCham)
            };
            return base.executeNonQuerya("NhanVien_getGioRaVao", sqlParams);
        }

        public DataTable SelectAll_CheckInOut(CheckInOutDTO _checkInOutDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            return base.executeNonQuerya("CheckInOut_getall", sqlParams);
        }
    }
}
