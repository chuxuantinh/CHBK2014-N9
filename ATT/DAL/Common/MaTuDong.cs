using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.Common
{
   internal class MaTuDong :Provider


    {





        private int Maxa = 1;
        private SqlConnection sqlMaTuDong = Provider.get_Connect();

        public string sTuDongDienCacLoaiVang(string sCacLoaiVang)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaCacLoaiVang from CACLOAIVANG", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sCacLoaiVang = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sCacLoaiVang.ToString().Trim().Substring(1, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sCacLoaiVang = "V" + "0000" + Maxa;
            }
            if (this.Maxa >= 10)
            {
                sCacLoaiVang = "V" + "000" + Maxa;
            }
            if (this.Maxa >= 100)
            {
                sCacLoaiVang = "V" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sCacLoaiVang = "V" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sCacLoaiVang = Convert.ToString(this.Maxa);
            }
            return sCacLoaiVang;
        }

        public string sTuDongDienCaLamViec(string sCaLamViec)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaCaLamViec from CaLamViecNew", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sCaLamViec = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sCaLamViec.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sCaLamViec = "CA" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sCaLamViec = "CA" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sCaLamViec = "CA" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sCaLamViec = "CA" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sCaLamViec = Convert.ToString(this.Maxa);
            }
            return sCaLamViec;
        }

        public string sTuDongDienChucVu(string sChucVu)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaChucVu from CHUCVU", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sChucVu = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sChucVu.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sChucVu = "CV" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sChucVu = "CV" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sChucVu = "CV" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sChucVu = "CV" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sChucVu = Convert.ToString(this.Maxa);
            }
            return sChucVu;
        }

        public string sTuDongDienChucVuNhanVien(string sChucVuNhanVien)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaChucVuNhanVien from CHUCVUNHANVIEN", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sChucVuNhanVien = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sChucVuNhanVien.ToString().Trim().Substring(4, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sChucVuNhanVien = "CVNV" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sChucVuNhanVien = "CVNV" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sChucVuNhanVien = "CVNV" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sChucVuNhanVien = "CVNV" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sChucVuNhanVien = Convert.ToString(this.Maxa);
            }
            return sChucVuNhanVien;
        }

        public string sTuDongDienCongTy(string sCT)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaCongTy from CONGTY", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sCT = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sCT.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sCT = "CT" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sCT = "CT" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sCT = "CT" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sCT = "CT" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sCT = Convert.ToString(this.Maxa);
            }
            return sCT;
        }

        public string sTuDongDienDanToc(string sDanToc)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaDanToc from DanToc", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sDanToc = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sDanToc.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sDanToc = "DT" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sDanToc = "DT" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sDanToc = "DT" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sDanToc = "DT" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sDanToc = Convert.ToString(this.Maxa);
            }
            return sDanToc;
        }

        public string sTuDongDienKhuVuc(string sKhuVuc)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaKhuVuc from KHUVUC", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sKhuVuc = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sKhuVuc.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sKhuVuc = "KV" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sKhuVuc = "KV" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sKhuVuc = "KV" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sKhuVuc = "KV" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sKhuVuc = Convert.ToString(this.Maxa);
            }
            return sKhuVuc;
        }

        public string sTuDongDienKyHieu(string sKyHieu)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaKyHieu from KYHIEUCHAMCONG", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sKyHieu = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sKyHieu.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sKyHieu = "KH" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sKyHieu = "KH" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sKyHieu = "KH" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sKyHieu = "KH" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sKyHieu = Convert.ToString(this.Maxa);
            }
            return sKyHieu;
        }

        public string sTuDongDienLichTrinhChoCaLamViec(string sLichTrinhChoCaLamViec)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaLichTrinhCaLamViec from LICHTRINHCHOCALAMVIEC", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sLichTrinhChoCaLamViec = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sLichTrinhChoCaLamViec.ToString().Trim().Substring(5, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sLichTrinhChoCaLamViec = "LTCLV" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sLichTrinhChoCaLamViec = "LTCLV" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sLichTrinhChoCaLamViec = "LTCLV" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sLichTrinhChoCaLamViec = "LTCLV" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sLichTrinhChoCaLamViec = Convert.ToString(this.Maxa);
            }
            return sLichTrinhChoCaLamViec;
        }

        public string sTuDongDienLichTrinhVaoRa(string sLichTrinhVaoRa)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaLichTrinhVaoRa from LICHTRINHVAORA", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sLichTrinhVaoRa = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sLichTrinhVaoRa.ToString().Trim().Substring(4, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sLichTrinhVaoRa = "LTVR" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sLichTrinhVaoRa = "LTVR" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sLichTrinhVaoRa = "LTVR" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sLichTrinhVaoRa = "LTVR" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sLichTrinhVaoRa = Convert.ToString(this.Maxa);
            }
            return sLichTrinhVaoRa;
        }

        public string sTuDongDienMayChu(string sMayChu)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select ID from Maychu", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sMayChu = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sMayChu.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sMayChu = "MC" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sMayChu = "MC" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sMayChu = "MC" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sMayChu = "MC" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sMayChu = Convert.ToString(this.Maxa);
            }
            return sMayChu;
        }

        public string sTuDongDienMCC(string sMCC)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaMCC from MAYCHAMCONG", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sMCC = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sMCC.ToString().Trim().Substring(3, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sMCC = "MCC" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sMCC = "MCC" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sMCC = "MCC" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sMCC = "MCC" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sMCC = Convert.ToString(this.Maxa);
            }
            return sMCC;
        }

        public string sTuDongDienMucLuongToiThieu(string sMucLuongToiThieu)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaLuongToiThieu from MUCLUONGTOITHIEU", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sMucLuongToiThieu = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sMucLuongToiThieu.ToString().Trim().Substring(3, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sMucLuongToiThieu = "LTT" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sMucLuongToiThieu = "LTT" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sMucLuongToiThieu = "LTT" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sMucLuongToiThieu = "LTT" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sMucLuongToiThieu = Convert.ToString(this.Maxa);
            }
            return sMucLuongToiThieu;
        }

        public string sTuDongDienNgayLe(string sNgayLe)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaNgayLe from NGAYLE", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sNgayLe = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sNgayLe.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sNgayLe = "NL" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sNgayLe = "NL" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sNgayLe = "NL" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sNgayLe = "NL" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sNgayLe = Convert.ToString(this.Maxa);
            }
            return sNgayLe;
        }

        public string sTuDongDienNguoiDung(string sND)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaNguoiDung from NGUOIDUNG", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sND = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sND.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sND = "ND" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sND = "ND" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sND = "ND" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sND = "ND" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sND = Convert.ToString(this.Maxa);
            }
            return sND;
        }

        public string sTuDongDienPhongBan(string sPhongBan)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaPhongBan from PHONGBAN", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sPhongBan = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sPhongBan.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sPhongBan = "PB" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sPhongBan = "PB" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sPhongBan = "PB" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sPhongBan = "PB" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sPhongBan = Convert.ToString(this.Maxa);
            }
            return sPhongBan;
        }

        public string sTuDongDienPhuCap(string sPhuCap)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaPhuCap from PHUCAP", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sPhuCap = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sPhuCap.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sPhuCap = "PC" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sPhuCap = "PC" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sPhuCap = "PC" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sPhuCap = "PC" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sPhuCap = Convert.ToString(this.Maxa);
            }
            return sPhuCap;
        }

        public string sTuDongDienQuocTich(string sQuocTich)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaQuocTich from QuocTich", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sQuocTich = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sQuocTich.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sQuocTich = "QT" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sQuocTich = "QT" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sQuocTich = "QT" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sQuocTich = "QT" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sQuocTich = Convert.ToString(this.Maxa);
            }
            return sQuocTich;
        }

        public string sTuDongDienTinhThanh(string sTinhThanh)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaTinhThanh from TINHTHANH", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sTinhThanh = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sTinhThanh.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sTinhThanh = "TT" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sTinhThanh = "TT" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sTinhThanh = "TT" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sTinhThanh = "TT" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sTinhThanh = Convert.ToString(this.Maxa);
            }
            return sTinhThanh;
        }

        public string sTuDongDienTrinhDo(string sTrinhDo)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaTrinhDo from TrinhDo", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sTrinhDo = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sTrinhDo.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sTrinhDo = "TD" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sTrinhDo = "TD" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sTrinhDo = "TD" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sTrinhDo = "TD" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sTrinhDo = Convert.ToString(this.Maxa);
            }
            return sTrinhDo;
        }

        public string sTuDongDienTuyChon(string sTuyChon)
        {
            int num = 1;
            SqlDataReader reader = new SqlCommand("Select MaTuyChinh from TUYCHON", this.sqlMaTuDong).ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.GetValue(0).ToString().Length; i++)
                {
                    sTuyChon = reader.GetValue(0).ToString().Trim();
                    int num3 = int.Parse(sTuyChon.ToString().Trim().Substring(2, 5));
                    if (num == num3)
                    {
                        num++;
                    }
                    if (num != num3)
                    {
                        this.Maxa = num;
                    }
                }
            }
            reader.Close();
            if (this.Maxa < 10)
            {
                sTuyChon = "TC" + "0000" + this.Maxa;
            }
            if (this.Maxa >= 10)
            {
                sTuyChon = "TC" + "000" + this.Maxa;
            }
            if (this.Maxa >= 100)
            {
                sTuyChon = "TC" + "00" + this.Maxa;
            }
            if (this.Maxa >= 0x3e8)
            {
                sTuyChon = "TC" + "0" + this.Maxa;
            }
            if (this.Maxa >= 0x2710)
            {
                sTuyChon = Convert.ToString(this.Maxa);
            }
            return sTuyChon;
        }
    }
}
