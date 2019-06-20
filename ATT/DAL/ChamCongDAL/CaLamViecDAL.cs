using CHBK2014_N9.ATT.DAL.Common;
using CHBK2014_N9.ATT.DTO.ChamCongDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.ChamCongDAL
{
   internal class CaLamViecDAL:Provider
    {

        private DBHelper dbHelper = new DBHelper();

        public DataTable CaLamViec_getByMaCaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCaLamViec", _caLamViecDTO.MaCaLamViec)
            };
            return base.executeNonQuerya("CaLamViecNew_getByMaCaLamViec", sqlParams);
        }

        public DataTable CaLamViec_getDataGirdView(CaLamViecDTO _caLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCaLamViec", _caLamViecDTO.MaCaLamViec)
            };
            return base.executeNonQuerya("CaLamViec_getDataGirdView", sqlParams);
        }

        public DataTable CaLamViec_SelectTenCa()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("CaLamViec_getTenCa", sqlParams);
        }

        public void Delete_CaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCaLamViec", _caLamViecDTO.MaCaLamViec)
            };
            base.Procedure("CALAMVIEC_delete", sqlParams);
        }

        public DataTable get_CaLamViec()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("CaLamViec_get", sqlParams);
        }

        public DataTable get_CaLamViecByMaCaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCaLamViec", _caLamViecDTO.MaCaLamViec)
            };
            return base.executeNonQuerya("CaLamViec_getTenByMaCaLamViec", sqlParams);
        }

        public DataTable get_MaByTenCaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@CaLamViec", _caLamViecDTO.CaLamViec)
            };
            return base.executeNonQuerya("CaLamViecNew_getMaByTenCa", sqlParams);
        }

        public void Insert_CaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCaLamViec", _caLamViecDTO.MaCaLamViec),
                new SqlParameter("@CaLamViec", _caLamViecDTO.CaLamViec),
                new SqlParameter("@GioVaoLamViec", _caLamViecDTO.GioVaoLamViec),
                new SqlParameter("@GioKetThucLamViec", _caLamViecDTO.GioKetThucLamViec),
                new SqlParameter("@GioBatDauNghiTrua", _caLamViecDTO.GioBatDauNghiTrua),
                new SqlParameter("@GioKetThucNghiTrua", _caLamViecDTO.GioKetThucNghiTrua),
                new SqlParameter("@TongGioNghiTrua", _caLamViecDTO.TongGioNghiTrua),
                new SqlParameter("@TongGioTrongCaLamViec", _caLamViecDTO.TongGioTrongCaLamViec),
                new SqlParameter("@CongTinh", _caLamViecDTO.CongTinh),
                new SqlParameter("@BatDauVao", _caLamViecDTO.BatDauVao),
                new SqlParameter("@KetThucVao", _caLamViecDTO.KetThucVao),
                new SqlParameter("@BatDauRa", _caLamViecDTO.BatDauRa),
                new SqlParameter("@KetThucRa", _caLamViecDTO.KetThucRa),
                new SqlParameter("@KhongCoGioRa", _caLamViecDTO.KhongCoGioRa),
                new SqlParameter("@KhongCoGioVao", _caLamViecDTO.KhongCoGioVao),
                new SqlParameter("@XemCaDem", _caLamViecDTO.XemCaDem),
                new SqlParameter("@TinhBuTru", _caLamViecDTO.TinhBuTru),
                new SqlParameter("@TruGioDiTre", _caLamViecDTO.TruGioDiTre),
                new SqlParameter("@TruGioVeSom", _caLamViecDTO.TruGioVeSom),
                new SqlParameter("@ChoPhepDiTre", _caLamViecDTO.ChoPhepDiTre),
                new SqlParameter("@BatDauTinhDiTre", _caLamViecDTO.BatDauTinhDiTre),
                new SqlParameter("@ChoPhepVeSom", _caLamViecDTO.ChoPhepVeSom),
                new SqlParameter("@BatDauTinhVeSom", _caLamViecDTO.BatDauTinhVeSom),
                new SqlParameter("@XemCaNayLaTangCa", _caLamViecDTO.XemCaNayLaTangCa),
                new SqlParameter("@TangCaMuc", _caLamViecDTO.TangCaMuc),
                new SqlParameter("@XemCuoiTuanLaTangCa", _caLamViecDTO.XemCuoiTuanLaTangCa),
                new SqlParameter("@TangCaCuoiTuanMuc", _caLamViecDTO.TangCaCuoiTuanMuc),
                new SqlParameter("@XemNgayLeLaTangCa", _caLamViecDTO.XemNgayLeLaTangCa),
                new SqlParameter("@TangCaNgayLeMuc", _caLamViecDTO.TangCaNgayLeMuc),
                new SqlParameter("@TangCaTruocGioLamViec", _caLamViecDTO.TangCaTruocGioLamViec),
                new SqlParameter("@SoPhutTangCaTruocGioLamViec", _caLamViecDTO.SoPhutTangCaTruocGioLamViec),
                new SqlParameter("@TangCaSauGioLamViec", _caLamViecDTO.TangCaSauGioLamViec),
                new SqlParameter("@SoPhutTangCaSauGioLamViec", _caLamViecDTO.SoPhutTangCaSauGioLamViec),
                new SqlParameter("@TongGioLamDatDen", _caLamViecDTO.TongGioLamDatDen),
                new SqlParameter("@SoPhutTongGioLamDatDen", _caLamViecDTO.SoPhutTongGioLamDatDen),
                new SqlParameter("@TangCaTruocGioLamViecDatDen", _caLamViecDTO.TangCaTruocGioLamViecDatDen),
                new SqlParameter("@PhutTruTangCaTruoc", _caLamViecDTO.PhutTruTangCaTruoc),
                new SqlParameter("@TangCaSauGioLamViecDatDen", _caLamViecDTO.TangCaSauGioLamViecDatDen),
                new SqlParameter("@PhutTruTangCaSau", _caLamViecDTO.PhutTruTangCaSau),
                new SqlParameter("@GioiHanTangCa1", _caLamViecDTO.GioiHanTangCa1),
                new SqlParameter("@GioiHanTangCa2", _caLamViecDTO.GioiHanTangCa2),
                new SqlParameter("@GioiHanTangCa3", _caLamViecDTO.GioiHanTangCa3),
                new SqlParameter("@GioiHanTangCa4", _caLamViecDTO.GioiHanTangCa4)
            };
            base.Procedure("CALAMVIEC_add", sqlParams);
        }

        public DataTable LOADCALAMVIEC()
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable table = new DataTable();
            return base.executeNonQuerya("CALAMVIEC_getall", sqlParams);
        }

        public ArrayList SelectAllComboBox()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("CALAMVIEC_LoadComboBox");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                CaLamViecDTO cdto = new CaLamViecDTO(reader.GetString(0), reader.GetString(1));
                list.Add(cdto);
            }
            reader.Close();
            return list;
        }

        public ArrayList SelectTenCaLamViec()
        {
            SqlDataReader reader = this.dbHelper.ExecuteQuery("CALAMVIEC_get_TenMay");
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                CaLamViecDTO cdto = new CaLamViecDTO(reader.GetString(0), reader.GetString(1));
                list.Add(cdto);
            }
            reader.Close();
            return list;
        }

        public void Update_CaLamViec(CaLamViecDTO _caLamViecDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter> {
                new SqlParameter("@MaCaLamViec", _caLamViecDTO.MaCaLamViec),
                new SqlParameter("@CaLamViec", _caLamViecDTO.CaLamViec),
                new SqlParameter("@GioVaoLamViec", _caLamViecDTO.GioVaoLamViec),
                new SqlParameter("@GioKetThucLamViec", _caLamViecDTO.GioKetThucLamViec),
                new SqlParameter("@GioBatDauNghiTrua", _caLamViecDTO.GioBatDauNghiTrua),
                new SqlParameter("@GioKetThucNghiTrua", _caLamViecDTO.GioKetThucNghiTrua),
                new SqlParameter("@TongGioNghiTrua", _caLamViecDTO.TongGioNghiTrua),
                new SqlParameter("@TongGioTrongCaLamViec", _caLamViecDTO.TongGioTrongCaLamViec),
                new SqlParameter("@CongTinh", _caLamViecDTO.CongTinh),
                new SqlParameter("@BatDauVao", _caLamViecDTO.BatDauVao),
                new SqlParameter("@KetThucVao", _caLamViecDTO.KetThucVao),
                new SqlParameter("@BatDauRa", _caLamViecDTO.BatDauRa),
                new SqlParameter("@KetThucRa", _caLamViecDTO.KetThucRa),
                new SqlParameter("@KhongCoGioRa", _caLamViecDTO.KhongCoGioRa),
                new SqlParameter("@KhongCoGioVao", _caLamViecDTO.KhongCoGioVao),
                new SqlParameter("@XemCaDem", _caLamViecDTO.XemCaDem),
                new SqlParameter("@TinhBuTru", _caLamViecDTO.TinhBuTru),
                new SqlParameter("@TruGioDiTre", _caLamViecDTO.TruGioDiTre),
                new SqlParameter("@TruGioVeSom", _caLamViecDTO.TruGioVeSom),
                new SqlParameter("@ChoPhepDiTre", _caLamViecDTO.ChoPhepDiTre),
                new SqlParameter("@BatDauTinhDiTre", _caLamViecDTO.BatDauTinhDiTre),
                new SqlParameter("@ChoPhepVeSom", _caLamViecDTO.ChoPhepVeSom),
                new SqlParameter("@BatDauTinhVeSom", _caLamViecDTO.BatDauTinhVeSom),
                new SqlParameter("@XemCaNayLaTangCa", _caLamViecDTO.XemCaNayLaTangCa),
                new SqlParameter("@TangCaMuc", _caLamViecDTO.TangCaMuc),
                new SqlParameter("@XemCuoiTuanLaTangCa", _caLamViecDTO.XemCuoiTuanLaTangCa),
                new SqlParameter("@TangCaCuoiTuanMuc", _caLamViecDTO.TangCaCuoiTuanMuc),
                new SqlParameter("@XemNgayLeLaTangCa", _caLamViecDTO.XemNgayLeLaTangCa),
                new SqlParameter("@TangCaNgayLeMuc", _caLamViecDTO.TangCaNgayLeMuc),
                new SqlParameter("@TangCaTruocGioLamViec", _caLamViecDTO.TangCaTruocGioLamViec),
                new SqlParameter("@SoPhutTangCaTruocGioLamViec", _caLamViecDTO.SoPhutTangCaTruocGioLamViec),
                new SqlParameter("@TangCaSauGioLamViec", _caLamViecDTO.TangCaSauGioLamViec),
                new SqlParameter("@SoPhutTangCaSauGioLamViec", _caLamViecDTO.SoPhutTangCaSauGioLamViec),
                new SqlParameter("@TongGioLamDatDen", _caLamViecDTO.TongGioLamDatDen),
                new SqlParameter("@SoPhutTongGioLamDatDen", _caLamViecDTO.SoPhutTongGioLamDatDen),
                new SqlParameter("@TangCaTruocGioLamViecDatDen", _caLamViecDTO.TangCaTruocGioLamViecDatDen),
                new SqlParameter("@PhutTruTangCaTruoc", _caLamViecDTO.PhutTruTangCaTruoc),
                new SqlParameter("@TangCaSauGioLamViecDatDen", _caLamViecDTO.TangCaSauGioLamViecDatDen),
                new SqlParameter("@PhutTruTangCaSau", _caLamViecDTO.PhutTruTangCaSau),
                new SqlParameter("@GioiHanTangCa1", _caLamViecDTO.GioiHanTangCa1),
                new SqlParameter("@GioiHanTangCa2", _caLamViecDTO.GioiHanTangCa2),
                new SqlParameter("@GioiHanTangCa3", _caLamViecDTO.GioiHanTangCa3),
                new SqlParameter("@GioiHanTangCa4", _caLamViecDTO.GioiHanTangCa4)
            };
            base.Procedure("CALAMVIEC_update", sqlParams);
        }
    }
}
