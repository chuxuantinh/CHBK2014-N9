using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;

namespace CHBK2014_N9.ATT.DAL.MayChamCong.DuLieuMayChamCongDAL
{
   internal class TaiNhanVienDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public void ThemNhanVienTuMay(NhanVienDTO _nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaNhanVien", _nhanVienDTO.MaNhanVien),
                new SqlParameter("@TenNhanVien", _nhanVienDTO.TenNhanVien),
                new SqlParameter("@MaChamCong", _nhanVienDTO.MaChamCong),
                new SqlParameter("@TenChamCong", _nhanVienDTO.TenChamCong),
                new SqlParameter("@MaThe", _nhanVienDTO.MaThe),
                new SqlParameter("@UserPassWord", _nhanVienDTO.UserPassWord),
                new SqlParameter("@PhanQuyen", _nhanVienDTO.PhanQuyen),
                new SqlParameter("@UserEnable", _nhanVienDTO.UserEnable),
                new SqlParameter("@GioiTinh", _nhanVienDTO.GioiTinh),
                new SqlParameter("@NgayVaoLamViec", _nhanVienDTO.NgayVaoLamViec),
                new SqlParameter("@ChucVu", _nhanVienDTO.ChucVu),
                new SqlParameter("@NgaySinh", _nhanVienDTO.NgaySinh),
                new SqlParameter("@NoiSinh", _nhanVienDTO.NoiSinh),
                new SqlParameter("@LoaiNhanVien", _nhanVienDTO.LoaiNhanVien),
                new SqlParameter("@CMND", _nhanVienDTO.CMND),
                new SqlParameter("@DienThoaiLienHe", _nhanVienDTO.DienThoaiLienHe),
                new SqlParameter("@Email", _nhanVienDTO.Email),
                new SqlParameter("@TinhTrang", _nhanVienDTO.TinhTrang)
            };
            base.Procedure("NHANVIEN_add_TuMayChamCong", sqlParams);
        }
    }
}
