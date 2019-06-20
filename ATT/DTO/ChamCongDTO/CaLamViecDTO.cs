﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DTO.ChamCongDTO
{
  internal  class CaLamViecDTO
    {

        private DateTime _BatDauRa;
        private bool _BatDauTinhDiTre;
        private bool _BatDauTinhVeSom;
        private DateTime _BatDauVao;
        private string _CaLamViec;
        private int _ChoPhepDiTre;
        private int _ChoPhepVeSom;
        private float _CongTinh;
        private DateTime _GioBatDauNghiTrua;
        private int _GioiHanTangCa1;
        private int _GioiHanTangCa2;
        private int _GioiHanTangCa3;
        private int _GioiHanTangCa4;
        private DateTime _GioKetThucLamViec;
        private DateTime _GioKetThucNghiTrua;
        private DateTime _GioVaoLamViec;
        private DateTime _KetThucRa;
        private DateTime _KetThucVao;
        private int _KhongCoGioRa;
        private int _KhongCoGioVao;
        private string _MaCaLamViec;
        private int _PhutTruTangCaSau;
        private int _PhutTruTangCaTruoc;
        private int _SoPhutTangCaSauGioLamViec;
        private int _SoPhutTangCaTruocGioLamViec;
        private int _SoPhutTongGioLamDatDen;
        private int _TangCaCuoiTuanMuc;
        private int _TangCaMuc;
        private int _TangCaNgayLeMuc;
        private bool _TangCaSauGioLamViec;
        private int _TangCaSauGioLamViecDatDen;
        private bool _TangCaTruocGioLamViec;
        private int _TangCaTruocGioLamViecDatDen;
        private bool _TinhBuTru;
        private bool _TongGioLamDatDen;
        private float _TongGioNghiTrua;
        private float _TongGioTrongCaLamViec;
        private bool _TruGioDiTre;
        private bool _TruGioVeSom;
        private bool _XemCaDem;
        private bool _XemCaNayLaTangCa;
        private bool _XemCuoiTuanLaTangCa;
        private bool _XemNgayLeLaTangCa;

        public CaLamViecDTO()
        {
        }

        public CaLamViecDTO(string _MaCaLamViec, string _CaLamViec)
        {
            this.MaCaLamViec = _MaCaLamViec;
            this.CaLamViec = _CaLamViec;
        }

        public DateTime BatDauRa
        {
            get
            {
                return this._BatDauRa;
            }
            set
            {
                this._BatDauRa = value;
            }
        }

        public bool BatDauTinhDiTre
        {
            get
            {
                return this._BatDauTinhDiTre;
            }
            set
            {
                this._BatDauTinhDiTre = value;
            }
        }

        public bool BatDauTinhVeSom
        {
            get
            {
                return this._BatDauTinhVeSom;
            }
            set
            {
                this._BatDauTinhVeSom = value;
            }
        }

        public DateTime BatDauVao
        {
            get
            {
                return this._BatDauVao;
            }
            set
            {
                this._BatDauVao = value;
            }
        }

        public string CaLamViec
        {
            get
            {
                return this._CaLamViec;
            }
            set
            {
                this._CaLamViec = value;
            }
        }

        public int ChoPhepDiTre
        {
            get
            {
                return this._ChoPhepDiTre;
            }
            set
            {
                this._ChoPhepDiTre = value;
            }
        }

        public int ChoPhepVeSom
        {
            get
            {
                return this._ChoPhepVeSom;
            }
            set
            {
                this._ChoPhepVeSom = value;
            }
        }

        public float CongTinh
        {
            get
            {
                return this._CongTinh;
            }
            set
            {
                this._CongTinh = value;
            }
        }

        public DateTime GioBatDauNghiTrua
        {
            get
            {
                return this._GioBatDauNghiTrua;
            }
            set
            {
                this._GioBatDauNghiTrua = value;
            }
        }

        public int GioiHanTangCa1
        {
            get
            {
                return this._GioiHanTangCa1;
            }
            set
            {
                this._GioiHanTangCa1 = value;
            }
        }

        public int GioiHanTangCa2
        {
            get
            {
                return this._GioiHanTangCa2;
            }
            set
            {
                this._GioiHanTangCa2 = value;
            }
        }

        public int GioiHanTangCa3
        {
            get
            {
                return this._GioiHanTangCa3;
            }
            set
            {
                this._GioiHanTangCa3 = value;
            }
        }

        public int GioiHanTangCa4
        {
            get
            {
                return this._GioiHanTangCa4;
            }
            set
            {
                this._GioiHanTangCa4 = value;
            }
        }

        public DateTime GioKetThucLamViec
        {
            get
            {
                return this._GioKetThucLamViec;
            }
            set
            {
                this._GioKetThucLamViec = value;
            }
        }

        public DateTime GioKetThucNghiTrua
        {
            get
            {
                return this._GioKetThucNghiTrua;
            }
            set
            {
                this._GioKetThucNghiTrua = value;
            }
        }

        public DateTime GioVaoLamViec
        {
            get
            {
                return this._GioVaoLamViec;
            }
            set
            {
                this._GioVaoLamViec = value;
            }
        }

        public DateTime KetThucRa
        {
            get
            {
                return this._KetThucRa;
            }
            set
            {
                this._KetThucRa = value;
            }
        }

        public DateTime KetThucVao
        {
            get
            {
                return this._KetThucVao;
            }
            set
            {
                this._KetThucVao = value;
            }
        }

        public int KhongCoGioRa
        {
            get
            {
                return this._KhongCoGioRa;
            }
            set
            {
                this._KhongCoGioRa = value;
            }
        }

        public int KhongCoGioVao
        {
            get
            {
                return this._KhongCoGioVao;
            }
            set
            {
                this._KhongCoGioVao = value;
            }
        }

        public string MaCaLamViec
        {
            get
            {
                return this._MaCaLamViec;
            }
            set
            {
                this._MaCaLamViec = value;
            }
        }

        public int PhutTruTangCaSau
        {
            get
            {
                return this._PhutTruTangCaSau;
            }
            set
            {
                this._PhutTruTangCaSau = value;
            }
        }

        public int PhutTruTangCaTruoc
        {
            get
            {
                return this._PhutTruTangCaTruoc;
            }
            set
            {
                this._PhutTruTangCaTruoc = value;
            }
        }

        public int SoPhutTangCaSauGioLamViec
        {
            get
            {
                return this._SoPhutTangCaSauGioLamViec;
            }
            set
            {
                this._SoPhutTangCaSauGioLamViec = value;
            }
        }

        public int SoPhutTangCaTruocGioLamViec
        {
            get
            {
                return this._SoPhutTangCaTruocGioLamViec;
            }
            set
            {
                this._SoPhutTangCaTruocGioLamViec = value;
            }
        }

        public int SoPhutTongGioLamDatDen
        {
            get
            {
                return this._SoPhutTongGioLamDatDen;
            }
            set
            {
                this._SoPhutTongGioLamDatDen = value;
            }
        }

        public int TangCaCuoiTuanMuc
        {
            get
            {
                return this._TangCaCuoiTuanMuc;
            }
            set
            {
                this._TangCaCuoiTuanMuc = value;
            }
        }

        public int TangCaMuc
        {
            get
            {
                return this._TangCaMuc;
            }
            set
            {
                this._TangCaMuc = value;
            }
        }

        public int TangCaNgayLeMuc
        {
            get
            {
                return this._TangCaNgayLeMuc;
            }
            set
            {
                this._TangCaNgayLeMuc = value;
            }
        }

        public bool TangCaSauGioLamViec
        {
            get
            {
                return this._TangCaSauGioLamViec;
            }
            set
            {
                this._TangCaSauGioLamViec = value;
            }
        }

        public int TangCaSauGioLamViecDatDen
        {
            get
            {
                return this._TangCaSauGioLamViecDatDen;
            }
            set
            {
                this._TangCaSauGioLamViecDatDen = value;
            }
        }

        public bool TangCaTruocGioLamViec
        {
            get
            {
                return this._TangCaTruocGioLamViec;
            }
            set
            {
                this._TangCaTruocGioLamViec = value;
            }
        }

        public int TangCaTruocGioLamViecDatDen
        {
            get
            {
                return this._TangCaTruocGioLamViecDatDen;
            }
            set
            {
                this._TangCaTruocGioLamViecDatDen = value;
            }
        }

        public bool TinhBuTru
        {
            get
            {
                return this._TinhBuTru;
            }
            set
            {
                this._TinhBuTru = value;
            }
        }

        public bool TongGioLamDatDen
        {
            get
            {
                return this._TongGioLamDatDen;
            }
            set
            {
                this._TongGioLamDatDen = value;
            }
        }

        public float TongGioNghiTrua
        {
            get
            {
                return this._TongGioNghiTrua;
            }
            set
            {
                this._TongGioNghiTrua = value;
            }
        }

        public float TongGioTrongCaLamViec
        {
            get
            {
                return this._TongGioTrongCaLamViec;
            }
            set
            {
                this._TongGioTrongCaLamViec = value;
            }
        }

        public bool TruGioDiTre
        {
            get
            {
                return this._TruGioDiTre;
            }
            set
            {
                this._TruGioDiTre = value;
            }
        }

        public bool TruGioVeSom
        {
            get
            {
                return this._TruGioVeSom;
            }
            set
            {
                this._TruGioVeSom = value;
            }
        }

        public bool XemCaDem
        {
            get
            {
                return this._XemCaDem;
            }
            set
            {
                this._XemCaDem = value;
            }
        }

        public bool XemCaNayLaTangCa
        {
            get
            {
                return this._XemCaNayLaTangCa;
            }
            set
            {
                this._XemCaNayLaTangCa = value;
            }
        }

        public bool XemCuoiTuanLaTangCa
        {
            get
            {
                return this._XemCuoiTuanLaTangCa;
            }
            set
            {
                this._XemCuoiTuanLaTangCa = value;
            }
        }

        public bool XemNgayLeLaTangCa
        {
            get
            {
                return this._XemNgayLeLaTangCa;
            }
            set
            {
                this._XemNgayLeLaTangCa = value;
            }
        }
    }
}
