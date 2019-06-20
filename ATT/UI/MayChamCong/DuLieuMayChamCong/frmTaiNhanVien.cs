using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using zkemkeeper;
using System.Net;
using System.Configuration;
using System.IO;

using CHBK2014_N9.ATT.BLL.CommonBLL;
using CHBK2014_N9.ATT.BLL.MayChamCong;
using CHBK2014_N9.ATT.BLL.MayChamCong.DuLieuTuMayChamCongBLL;
using CHBK2014_N9.ATT.BLL.QuanLyNhanVienBLL;
using CHBK2014_N9.ATT.DTO.CommonDTO;
using CHBK2014_N9.ATT.DTO.MayChamCong;
using CHBK2014_N9.ATT.DTO.QuanLyNhanVienDTO;
using CHBK2014_N9.ATT.UI.MayChamCong;


namespace CHBK2014_N9.ATT.UI.MayChamCong.DuLieuMayChamCong
{
    public partial class frmTaiNhanVien : Form
    {
        private int iSoDuLieu;
        private int c;
        private string _a;
        private string _b;
        public bool _bIsConnected;
        private string _c;
        private CHBK2014_N9.ATT.BLL.CommonBLL.CommonBLL _commonBLL = new CHBK2014_N9.ATT.BLL.CommonBLL.CommonBLL();
        private CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO _commonDTO = new CHBK2014_N9.ATT.DTO.CommonDTO.CommonDTO();
        public string _DiaChiIP;
        public string _DiaChiWeb;
        public int _iMachineNumber = 1;
        private int _ketQua;
        private int _kiemTraManHinh = 0;
        public string _KieuKetNoi;
        private string _loaiManHinh;
        private MayChamCongBLL _mayChamCongBLL = new MayChamCongBLL();
        private MayChamCongDTO _mayChamCongDTO = new MayChamCongDTO();
        // private System.Configuration.Configuration _ngonNgu = ConfigurationManager.OpenExeConfiguration("MitaAttendance.exe");
        private NhanVienBLL _nhanVienBLL = new NhanVienBLL();
        private NhanVienDTO _nhanVienDTO = new NhanVienDTO();
        private NhanVienUpdateBLL _nhanVienUpdateBLL = new NhanVienUpdateBLL();
        private NhanVienUpdateDTO _nhanVienUpdateDTO = new NhanVienUpdateDTO();
        private string _phienBanVanTay = "";
        public string _Port;
        public string _Serial;
        public string _SoDangKy;
        public string _SuDungWeb;
        private TaiNhanVienBLL _taiNhanVienBLL = new TaiNhanVienBLL();
        private TemplateBLL _templateBLL = new TemplateBLL();
        private TemplateCapNhatVanTayBLL _templateCapNhatVanTayBLL = new TemplateCapNhatVanTayBLL();
        private TemplateCapNhatVanTayDTO _templateCapNhatVanTayDTO = new TemplateCapNhatVanTayDTO();
        private TemplateDTO _templateDTO = new TemplateDTO();
        public string _TenMay;
        private int _value = 0;
        private int a;
        //public CZKEM axCZKEM1 = new CZKEM();
        //public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
       // public CZKEMClass axCZKEM1; // bo cho nay

      //  public CHBK2014_N9.ATT.Utilities.ZkemClient axCZKEM1;
        //  public CZKEMClass axCZKEM1;
        private int b;
        public CZKEMClass axCZKEM1 = new CZKEMClass();

        private string sDiaChiIP;
        private string sDiaChiWeb;
        private string sdwSerialNumber;
        private string sIDMCC;
        private string sKieuKetNoi;
        private string sMaMCC;
        private string sMaNhanVien_CapNhatNhanVien;
        private string sMaNhanVien_NhanVienMoi;
        private string sMaThe_CapNhatNhanVien;
        private string sMaThe_NhanVienMoi;
        private int soVanTay;
        private string sPort;
        private string sSerial;
        private string sSoDangKy;
        private string sSuDungWeb;
        private string sTenMay;
        private string sTrangThai;
        private string vtFingerID;
        private string vtFingerTemplate;
        private string vtFingerVersion;
        private string vtMaChamCong;
        private string vtMaNhanVien;

        public frmTaiNhanVien()
        {
            InitializeComponent();
        }


      //  CHBK2014_N9.ATT.Utilities.DeviceManipulator manipulator = new CHBK2014_N9.ATT.Utilities.DeviceManipulator();
     //   public CHBK2014_N9.ATT.Utilities.ZkemClient objZkeeper;
    
        private bool isDeviceConnected = false;

        public bool IsDeviceConnected
        {
            get { return isDeviceConnected; }
            set
            {
                isDeviceConnected = value;
                if (isDeviceConnected)
                {
                    ShowStatusBar("The device is connected !!", true);
                    button_DuyetNVtuMCC.Text = "Disconnect";
                    //     ToggleControls(true);
                }
                else
                {
                    ShowStatusBar("The device is diconnected !!", true);
                    axCZKEM1.Disconnect();
                    button_DuyetNVtuMCC.Text = "Connect";
                    // ToggleControls(false);
                }
            }
        }

        public void ShowStatusBar(string message, bool type)
        {
            if (message.Trim() == string.Empty)
            {
                lblStatus.Visible = false;
                return;
            }

            lblStatus.Visible = true;
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.White;

            if (type)
                lblStatus.BackColor = Color.FromArgb(79, 208, 154);
            else
                lblStatus.BackColor = Color.FromArgb(230, 112, 134);
        }


        private void RaiseDeviceEvent(object sender, string actionType)
        {
            switch (actionType)
            {
                case CHBK2014_N9.ATT.Utilities.UniversalStatic.acx_Disconnect:
                    {
                        ShowStatusBar("The device is switched off", true);
                        //  DisplayEmpty();
                        button_DuyetNVtuMCC.Text = "Connect";
                        //   ToggleControls(false);
                        break;
                    }

                default:
                    break;
            }

        }

        private void button_DuyetNVtuMCC_Click(object sender, EventArgs e)
        {
            this._commonBLL.DeleteALLTemplateVirtual(this._commonDTO);
            this._templateCapNhatVanTayBLL.TemplateCapNhatVanTayDeleteAll(this._templateCapNhatVanTayDTO);
            this._nhanVienUpdateBLL.NhanVienUpdateDeleteAll(this._nhanVienUpdateDTO);
            if (this.comboBox_Chonmay.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn m\x00e1y chấm c\x00f4ng", "Th\x00f4ng b\x00e1o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (this.sKieuKetNoi == "TCP/IP")
                {
                    frmDangKyMayChamCong cong;
                    if (this.sSuDungWeb == "False")
                    {
                        //this.Cursor = Cursors.WaitCursor;
                        //this._bIsConnected = this.axCZKEM1.Connect_Net(this.sDiaChiIP, Convert.ToInt32(this.sPort));
                        //if (!this._bIsConnected)
                        //{
                        //    MessageBox.Show("Kh\x00f4ng kết nối được với " + this.sTenMay);
                        //    this.Cursor = Cursors.Default;
                        //    return;
                        //}


                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                               ShowStatusBar(string.Empty, true);

                            if (IsDeviceConnected)
                            {
                                IsDeviceConnected = false;
                                this.Cursor = Cursors.Default;

                                return;
                            }

                                               
                         
                         
                            IsDeviceConnected = axCZKEM1.Connect_Net(sDiaChiIP, Convert.ToInt32(sPort));

                            if (IsDeviceConnected)
                            {





                                this.axCZKEM1.RegEvent(this._iMachineNumber, 65535);
                                this.sdwSerialNumber = "";
                                this.axCZKEM1.GetSerialNumber(this._iMachineNumber, out this.sdwSerialNumber);


                                if (this.axCZKEM1.GetDeviceStatus(1, 2, ref this._value))
                                {
                                    this.iSoDuLieu = this._value;
                                }
                                this.kiemTraLoaiMay();
                                this.phienBanVanTay();
                                if (this.radioNhanVienMoi.Checked)
                                {
                                    this.duyetNhanVienTuMayChamCong_NhanVienMoi();
                                }
                                if (this.radioToanBoNhanVien.Checked)
                                {
                                    this.duyetNhanVienTuMayChamCong_ToanBoNhanVien();
                                }
                                this.button_Chontatca2_Click(sender, e);
                                this.axCZKEM1.Disconnect();
                                this.Cursor = Cursors.Default;

                             

                            }
                        }
                        catch (Exception ex)
                        {
                            ShowStatusBar(ex.Message, false);
                        }
                        this.Cursor = Cursors.Default;

                        this.DGVNhanVienDaCoTrenMay.DataSource = this._nhanVienBLL.getNhanVienCoTrongCSDL();
                        this.demNhanVien();



                        //this.ActiveKey();
                        //if ((this.sSoDangKy.Trim() == "") || (this.sSoDangKy.Trim() == ""))
                        //{
                        //    MessageBox.Show("M\x00e1y chấm c\x00f4ng n\x00e0y chưa được đăng k\x00fd, xin vui l\x00f2ng li\x00ean hệ với nh\x00e0 cung cấp", "Th\x00f4ng b\x00e1o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        //    this.axCZKEM1.Disconnect();
                        //    this.Cursor = Cursors.Default;
                        //    base.Close();
                        //    cong = new frmDangKyMayChamCong();
                        //    cong.ShowDialog();
                        //    return;
                        //}
                        //if ((this.sSerial.Trim() != "") && (this.sSoDangKy.Trim() != ""))
                        //{
                        //    if (this.sSerial.Trim() != this.sdwSerialNumber)
                        //    {
                        //        MessageBox.Show("M\x00e1y chấm c\x00f4ng n\x00e0y chưa được đăng k\x00fd, xin vui l\x00f2ng li\x00ean hệ với nh\x00e0 cung cấp", "Th\x00f4ng b\x00e1o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        //        this.axCZKEM1.Disconnect();
                        //        this.Cursor = Cursors.Default;
                        //        base.Close();
                        //        cong = new frmDangKyMayChamCong();
                        //        cong.ShowDialog();
                        //        return;
                        //    }
                        //    if (this.sSoDangKy.Trim() != this._ketQua.ToString())
                        //    {
                        //        MessageBox.Show("M\x00e1y chấm c\x00f4ng n\x00e0y chưa được đăng k\x00fd, xin vui l\x00f2ng li\x00ean hệ với nh\x00e0 cung cấp", "Th\x00f4ng b\x00e1o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        //        this.axCZKEM1.Disconnect();
                        //        this.Cursor = Cursors.Default;
                        //        base.Close();
                        //        cong = new frmDangKyMayChamCong();
                        //        cong.ShowDialog();
                        //        return;
                        //    }
                        //}
                        //if (this.sTrangThai == "False")
                        //{
                        //    MessageBox.Show("M\x00e1y chấm c\x00f4ng n\x00e0y chưa cho ph\x00e9p sử dụng");
                        //    this.Cursor = Cursors.Default;
                        //    this.axCZKEM1.Disconnect();
                        //    return;
                        //}


                    }


                    // bo vong elese -> khong su dung vong elease nay nua 

                    //else
                    //{
                    //    string iPAdd = Dns.GetHostByName(this.sDiaChiWeb).AddressList[0].ToString();
                    //    this.Cursor = Cursors.WaitCursor;
                    //    this._bIsConnected = this.axCZKEM1.Connect_Net(iPAdd, Convert.ToInt32(this.sPort));
                    //    this.axCZKEM1.RegEvent(this._iMachineNumber, 0xffff);
                    //    this.sdwSerialNumber = "";
                    //    this.axCZKEM1.GetSerialNumber(this._iMachineNumber, out this.sdwSerialNumber);
                    //    this.ActiveKey();
                    //    if ((this.sSoDangKy.Trim() == "") || (this.sSoDangKy.Trim() == ""))
                    //    {
                    //        MessageBox.Show("M\x00e1y chấm c\x00f4ng n\x00e0y chưa được đăng k\x00fd, xin vui l\x00f2ng li\x00ean hệ với nh\x00e0 cung cấp", "Th\x00f4ng b\x00e1o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    //        this.axCZKEM1.Disconnect();
                    //        this.Cursor = Cursors.Default;
                    //        base.Close();
                    //        cong = new frmDangKyMayChamCong();
                    //        cong.ShowDialog();
                    //        return;
                    //    }
                    //    if ((this.sSerial.Trim() != "") && (this.sSoDangKy.Trim() != ""))
                    //    {
                    //        if (this.sSerial.Trim() != this.sdwSerialNumber)
                    //        {
                    //            MessageBox.Show("M\x00e1y chấm c\x00f4ng n\x00e0y chưa được đăng k\x00fd, xin vui l\x00f2ng li\x00ean hệ với nh\x00e0 cung cấp", "Th\x00f4ng b\x00e1o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    //            this.axCZKEM1.Disconnect();
                    //            this.Cursor = Cursors.Default;
                    //            base.Close();
                    //            cong = new frmDangKyMayChamCong();
                    //            cong.ShowDialog();
                    //            return;
                    //        }
                    //        if (this.sSoDangKy.Trim() != this._ketQua.ToString())
                    //        {
                    //            MessageBox.Show("M\x00e1y chấm c\x00f4ng n\x00e0y chưa được đăng k\x00fd, xin vui l\x00f2ng li\x00ean hệ với nh\x00e0 cung cấp", "Th\x00f4ng b\x00e1o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    //            this.axCZKEM1.Disconnect();
                    //            this.Cursor = Cursors.Default;
                    //            base.Close();
                    //            new frmDangKyMayChamCong().ShowDialog();
                    //            return;
                    //        }
                    //    }
                    //    if (this.sTrangThai == "False")
                    //    {
                    //        MessageBox.Show("M\x00e1y chấm c\x00f4ng n\x00e0y chưa cho ph\x00e9p sử dụng");
                    //        this.Cursor = Cursors.Default;
                    //        this.axCZKEM1.Disconnect();
                    //        return;
                    //    }
                    //    if (!this._bIsConnected)
                    //    {
                    //        MessageBox.Show("Kh\x00f4ng kết nối được với " + this.sTenMay);
                    //        this.Cursor = Cursors.Default;
                    //        return;
                    //    }
                    //    if (this.axCZKEM1.GetDeviceStatus(1, 2, ref this._value))
                    //    {
                    //        this.iSoDuLieu = this._value;
                    //    }
                    //    this.kiemTraLoaiMay();
                    //    this.phienBanVanTay();
                    //    if (this.radioNhanVienMoi.Checked)
                    //    {
                    //        this.duyetNhanVienTuMayChamCong_NhanVienMoi();
                    //    }
                    //    if (this.radioToanBoNhanVien.Checked)
                    //    {
                    //        this.duyetNhanVienTuMayChamCong_ToanBoNhanVien();
                    //    }
                    //    this.button_Chontatca2_Click(sender, e);
                    //    this.axCZKEM1.Disconnect();
                    //    this.Cursor = Cursors.Default;
                    //}

                    ///// toi day co a
                }
                //if (this.sKieuKetNoi == "RS232/484")
                //{
                //    MessageBox.Show("Chưa ph\x00e1t triển cổng COM");
                //}
                //if (this.sKieuKetNoi == "USB")
                //{
                //    this._iMachineNumber = 1;
                //    this.Cursor = Cursors.WaitCursor;
                //    this._bIsConnected = this.axCZKEM1.Connect_USB(this._iMachineNumber);
                //    if (!this._bIsConnected)
                //    {
                //        MessageBox.Show("Kh\x00f4ng kết nối được với " + this.sTenMay);
                //        this.Cursor = Cursors.Default;
                //        return;
                //    }
                //    this.axCZKEM1.RegEvent(this._iMachineNumber, 0xffff);
                //    if (this.axCZKEM1.GetDeviceStatus(1, 2, ref this._value))
                //    {
                //        this.iSoDuLieu = this._value;
                //    }
                //    this.kiemTraLoaiMay();
                //    this.phienBanVanTay();
                //    this.button_Chontatca2_Click(sender, e);
                //    this.axCZKEM1.Disconnect();
                //    this.Cursor = Cursors.Default;
                //}
              

            }
        }



        private void duyetNhanVienTuMayChamCong_ToanBoNhanVien()
        {
            string str;
            int num4;
            string str3;
            string str4;
            int num6;
            bool flag;
            string str5;
            DataTable table;
            int num7;
            int num = -1;
            int iSoDuLieu = this.iSoDuLieu;
            if (this._loaiManHinh == "0")
            {
                str = "";
                num4 = 0;
                int num5 = 0;
                this.DGVNhanVienMoi.Rows.Clear();
                string dwEnrollNumber = "";
                str3 = "";
                str4 = "";
                num6 = 0;
                flag = false;
                str5 = "";
                this.axCZKEM1.EnableDevice(this._iMachineNumber, false);
                this.axCZKEM1.ReadAllUserID(this._iMachineNumber);
                this.axCZKEM1.ReadAllTemplate(this._iMachineNumber);
                while (this.axCZKEM1.SSR_GetAllUserInfo(this._iMachineNumber, out dwEnrollNumber, out str3, out str4, out num6, out flag))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (this.axCZKEM1.GetUserTmpExStr(this._iMachineNumber, dwEnrollNumber, i, out num5, out str, out num4))
                        {
                            this._templateCapNhatVanTayDTO.MaChamCong = Convert.ToInt32(dwEnrollNumber);
                            this._templateCapNhatVanTayDTO.FingerIDCapNhatVanTay = i;
                            this._templateCapNhatVanTayDTO.FlagCapNhatVanTay = num5;
                            this._templateCapNhatVanTayDTO.FingerTemplateCapNhatVanTay = str;
                            this._templateCapNhatVanTayDTO.FingerVersionCapNhatVanTay = this._phienBanVanTay;
                            this._templateCapNhatVanTayBLL.TemplateCapNhatVanTayInsert(this._templateCapNhatVanTayDTO);
                        }
                    }
                    if (this.axCZKEM1.GetStrCardNumber(out str5))
                    {
                        this._nhanVienUpdateDTO.MaChamCong = Convert.ToInt32(dwEnrollNumber);
                        this._nhanVienUpdateDTO.MaThe = str5;
                        this._nhanVienUpdateDTO.UserPassWord = str4;
                        this._nhanVienUpdateDTO.PhanQuyen = num6;
                        this._nhanVienUpdateBLL.NhanVienUpdateInsert(this._nhanVienUpdateDTO);
                    }
                    table = new DataTable();
                    this._nhanVienDTO.MaChamCong = dwEnrollNumber;
                    if (this._nhanVienBLL.NhanVienGetByMaChamCong(this._nhanVienDTO).Rows.Count == 0)
                    {
                        num7 = this.DGVNhanVienMoi.Rows.Add();
                        if (dwEnrollNumber.Length == 0)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "00000";
                        }
                        if (dwEnrollNumber.Length == 1)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "0000" + dwEnrollNumber;
                        }
                        if (dwEnrollNumber.Length == 2)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "000" + dwEnrollNumber;
                        }
                        if (dwEnrollNumber.Length == 3)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "00" + dwEnrollNumber;
                        }
                        if (dwEnrollNumber.Length == 4)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "0" + dwEnrollNumber;
                        }
                        if (dwEnrollNumber.Length > 4)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = dwEnrollNumber;
                        }
                        this.DGVNhanVienMoi.Rows[num7].Cells[1].Value = this.sMaNhanVien_CapNhatNhanVien;
                        this.DGVNhanVienMoi.Rows[num7].Cells[3].Value = dwEnrollNumber;
                        if ((str3 == null) || (str3 == ""))
                        {
                            this.DGVNhanVienMoi.Rows[num7].Cells[2].Value = dwEnrollNumber;
                            this.DGVNhanVienMoi.Rows[num7].Cells[4].Value = dwEnrollNumber;
                        }
                        else
                        {
                            this.DGVNhanVienMoi.Rows[num7].Cells[2].Value = str3;
                            this.DGVNhanVienMoi.Rows[num7].Cells[4].Value = str3;
                        }
                        if (this.axCZKEM1.GetStrCardNumber(out str5))
                        {
                            if (str5 == "0")
                            {
                                this.sMaThe_CapNhatNhanVien = "0000000000";
                            }
                            if (str5.Length == 0)
                            {
                                this.sMaThe_CapNhatNhanVien = "0000000000";
                            }
                            if (str5.Length == 1)
                            {
                                this.sMaThe_CapNhatNhanVien = "000000000" + str5;
                            }
                            if (str5.Length == 2)
                            {
                                this.sMaThe_CapNhatNhanVien = "00000000" + str5;
                            }
                            if (str5.Length == 3)
                            {
                                this.sMaThe_CapNhatNhanVien = "0000000" + str5;
                            }
                            if (str5.Length == 4)
                            {
                                this.sMaThe_CapNhatNhanVien = "000000" + str5;
                            }
                            if (str5.Length == 5)
                            {
                                this.sMaThe_CapNhatNhanVien = "00000" + str5;
                            }
                            if (str5.Length == 6)
                            {
                                this.sMaThe_CapNhatNhanVien = "0000" + str5;
                            }
                            if (str5.Length == 7)
                            {
                                this.sMaThe_CapNhatNhanVien = "000" + str5;
                            }
                            if (str5.Length == 8)
                            {
                                this.sMaThe_CapNhatNhanVien = "00" + str5;
                            }
                            if (str5.Length == 9)
                            {
                                this.sMaThe_CapNhatNhanVien = "0" + str5;
                            }
                            if (str5.Length == 10)
                            {
                                this.sMaThe_CapNhatNhanVien = str5;
                            }
                        }
                        if (str5 == "")
                        {
                            this.sMaThe_CapNhatNhanVien = "0000000000";
                        }
                        this.DGVNhanVienMoi.Rows[num7].Cells[5].Value = this.sMaThe_CapNhatNhanVien;
                        this.DGVNhanVienMoi.Rows[num7].Cells[6].Value = str4;
                        this.DGVNhanVienMoi.Rows[num7].Cells[7].Value = num6;
                        this.DGVNhanVienMoi.Rows[num7].Cells[8].Value = flag;
                        this.progressBarChay.Maximum = this.iSoDuLieu;
                        iSoDuLieu--;
                        num++;
                        int num13 = ((num + 1) * 100) / this.iSoDuLieu;
                        this.progressBarChay.Text = num13.ToString() + "%";
                        Application.DoEvents();
                        if (this.iSoDuLieu < 0)
                        {
                        }
                        if (this.iSoDuLieu >= 0)
                        {
                            this.progressBarChay.Value = this.iSoDuLieu - iSoDuLieu;
                        }
                    }
                }
                this.axCZKEM1.EnableDevice(this._iMachineNumber, true);
            }
            else
            {
                this.DGVNhanVienMoi.Rows.Clear();
                int num8 = 0;
                str3 = "";
                str4 = "";
                num6 = 0;
                flag = false;
                str5 = "";
                str = "";
                num4 = 0;
                this.Cursor = Cursors.WaitCursor;
                this.axCZKEM1.EnableDevice(this._iMachineNumber, false);
                this.axCZKEM1.ReadAllUserID(this._iMachineNumber);
                while (this.axCZKEM1.GetAllUserInfo(this._iMachineNumber, ref num8, ref str3, ref str4, ref num6, ref flag))
                {
                    if (this.axCZKEM1.GetStrCardNumber(out str5))
                    {
                        this._nhanVienUpdateDTO.MaChamCong = num8;
                        this._nhanVienUpdateDTO.MaThe = str5;
                        this._nhanVienUpdateDTO.UserPassWord = str4;
                        this._nhanVienUpdateDTO.PhanQuyen = num6;
                        this._nhanVienUpdateBLL.NhanVienUpdateInsert(this._nhanVienUpdateDTO);
                    }
                    table = new DataTable();
                    this._nhanVienDTO.MaChamCong = num8.ToString();
                    if (this._nhanVienBLL.NhanVienGetByMaChamCong(this._nhanVienDTO).Rows.Count == 0)
                    {
                        num7 = this.DGVNhanVienMoi.Rows.Add();
                        if (num8.ToString().Length == 0)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "00000";
                        }
                        if (num8.ToString().Length == 1)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "0000" + num8.ToString();
                        }
                        if (num8.ToString().Length == 2)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "000" + num8.ToString();
                        }
                        if (num8.ToString().Length == 3)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "00" + num8.ToString();
                        }
                        if (num8.ToString().Length == 4)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = "0" + num8.ToString();
                        }
                        if (num8.ToString().Length > 4)
                        {
                            this.sMaNhanVien_CapNhatNhanVien = num8.ToString();
                        }
                        this.DGVNhanVienMoi.Rows[num7].Cells[1].Value = this.sMaNhanVien_CapNhatNhanVien;
                        this.DGVNhanVienMoi.Rows[num7].Cells[3].Value = num8;
                        if ((str3 == null) || (str3 == ""))
                        {
                            this.DGVNhanVienMoi.Rows[num7].Cells[2].Value = num8;
                            this.DGVNhanVienMoi.Rows[num7].Cells[4].Value = num8;
                        }
                        else
                        {
                            this.DGVNhanVienMoi.Rows[num7].Cells[2].Value = str3;
                            this.DGVNhanVienMoi.Rows[num7].Cells[4].Value = str3;
                        }
                        if (this.axCZKEM1.GetStrCardNumber(out str5))
                        {
                            if (str5 == "0")
                            {
                                this.sMaThe_CapNhatNhanVien = "0000000000";
                            }
                            if (str5.Length == 0)
                            {
                                this.sMaThe_CapNhatNhanVien = "0000000000";
                            }
                            if (str5.Length == 1)
                            {
                                this.sMaThe_CapNhatNhanVien = "000000000" + str5;
                            }
                            if (str5.Length == 2)
                            {
                                this.sMaThe_CapNhatNhanVien = "00000000" + str5;
                            }
                            if (str5.Length == 3)
                            {
                                this.sMaThe_CapNhatNhanVien = "0000000" + str5;
                            }
                            if (str5.Length == 4)
                            {
                                this.sMaThe_CapNhatNhanVien = "000000" + str5;
                            }
                            if (str5.Length == 5)
                            {
                                this.sMaThe_CapNhatNhanVien = "00000" + str5;
                            }
                            if (str5.Length == 6)
                            {
                                this.sMaThe_CapNhatNhanVien = "0000" + str5;
                            }
                            if (str5.Length == 7)
                            {
                                this.sMaThe_CapNhatNhanVien = "000" + str5;
                            }
                            if (str5.Length == 8)
                            {
                                this.sMaThe_CapNhatNhanVien = "00" + str5;
                            }
                            if (str5.Length == 9)
                            {
                                this.sMaThe_CapNhatNhanVien = "0" + str5;
                            }
                            if (str5.Length == 10)
                            {
                                this.sMaThe_CapNhatNhanVien = str5;
                            }
                        }
                        if (str5 == "")
                        {
                            this.sMaThe_CapNhatNhanVien = "0000000000";
                        }
                        this.DGVNhanVienMoi.Rows[num7].Cells[5].Value = this.sMaThe_CapNhatNhanVien;
                        this.DGVNhanVienMoi.Rows[num7].Cells[6].Value = str4;
                        this.DGVNhanVienMoi.Rows[num7].Cells[7].Value = num6;
                        this.DGVNhanVienMoi.Rows[num7].Cells[8].Value = flag;
                        this.progressBarChay.Maximum = this.iSoDuLieu;
                        iSoDuLieu--;
                        num++;
                        this.progressBarChay.Text = ((((num + 1) * 100) / this.iSoDuLieu)).ToString() + "%";
                        Application.DoEvents();
                        if (this.iSoDuLieu < 0)
                        {
                        }
                        if (this.iSoDuLieu >= 0)
                        {
                            this.progressBarChay.Value = this.iSoDuLieu - iSoDuLieu;
                        }
                    }
                }
                this.axCZKEM1.EnableDevice(this._iMachineNumber, true);
                this.Cursor = Cursors.Default;
            }
        }



        private void duyetNhanVienTuMayChamCong_NhanVienMoi()
        {
            int num3;
            string str;
            int num4;
            int num5;
            string str2;
            string str3;
            string str4;
            int num6;
            bool flag;
            string str5;
            DataTable table;
            int num8;
            string str6;
            int num = -1;
            int iSoDuLieu = this.iSoDuLieu;
            if (this._loaiManHinh == "0")
            {
                str = "";
                num4 = 0;
                num5 = 0;
                this.DGVNhanVienMoi.Rows.Clear();
                str2 = "";
                str3 = "";
                str4 = "";
                num6 = 0;
                flag = false;
                str5 = "";
                this.axCZKEM1.EnableDevice(this._iMachineNumber, false);
                this.axCZKEM1.ReadAllUserID(this._iMachineNumber);
                this.axCZKEM1.ReadAllTemplate(this._iMachineNumber);
                while (this.axCZKEM1.SSR_GetAllUserInfo(this._iMachineNumber, out str2, out str3, out str4, out num6, out flag))
                {
                    table = new DataTable();
                    this._nhanVienDTO.MaChamCong = str2;
                    if (this._nhanVienBLL.NhanVienGetByMaChamCong(this._nhanVienDTO).Rows.Count == 0)
                    {
                        num8 = this.DGVNhanVienMoi.Rows.Add();
                        if (str2.Length == 0)
                        {
                            this.sMaNhanVien_NhanVienMoi = "00000";
                        }
                        if (str2.Length == 1)
                        {
                            this.sMaNhanVien_NhanVienMoi = "0000" + str2;
                        }
                        if (str2.Length == 2)
                        {
                            this.sMaNhanVien_NhanVienMoi = "000" + str2;
                        }
                        if (str2.Length == 3)
                        {
                            this.sMaNhanVien_NhanVienMoi = "00" + str2;
                        }
                        if (str2.Length == 4)
                        {
                            this.sMaNhanVien_NhanVienMoi = "0" + str2;
                        }
                        if (str2.Length > 4)
                        {
                            this.sMaNhanVien_NhanVienMoi = str2;
                        }
                        this.DGVNhanVienMoi.Rows[num8].Cells[1].Value = this.sMaNhanVien_NhanVienMoi;
                        this.DGVNhanVienMoi.Rows[num8].Cells[3].Value = str2;
                        if ((str3 == null) || (str3 == ""))
                        {
                            this.DGVNhanVienMoi.Rows[num8].Cells[2].Value = str2;
                            this.DGVNhanVienMoi.Rows[num8].Cells[4].Value = str2;
                        }
                        else
                        {
                            this.DGVNhanVienMoi.Rows[num8].Cells[2].Value = str3;
                            this.DGVNhanVienMoi.Rows[num8].Cells[4].Value = str3;
                        }
                        if (this.axCZKEM1.GetStrCardNumber(out str5))
                        {
                            if (str5 == "0")
                            {
                                this.sMaThe_NhanVienMoi = "0000000000";
                            }
                            if (str5.Length == 0)
                            {
                                this.sMaThe_NhanVienMoi = "0000000000";
                            }
                            if (str5.Length == 1)
                            {
                                this.sMaThe_NhanVienMoi = "000000000" + str5;
                            }
                            if (str5.Length == 2)
                            {
                                this.sMaThe_NhanVienMoi = "00000000" + str5;
                            }
                            if (str5.Length == 3)
                            {
                                this.sMaThe_NhanVienMoi = "0000000" + str5;
                            }
                            if (str5.Length == 4)
                            {
                                this.sMaThe_NhanVienMoi = "000000" + str5;
                            }
                            if (str5.Length == 5)
                            {
                                this.sMaThe_NhanVienMoi = "00000" + str5;
                            }
                            if (str5.Length == 6)
                            {
                                this.sMaThe_NhanVienMoi = "0000" + str5;
                            }
                            if (str5.Length == 7)
                            {
                                this.sMaThe_NhanVienMoi = "000" + str5;
                            }
                            if (str5.Length == 8)
                            {
                                this.sMaThe_NhanVienMoi = "00" + str5;
                            }
                            if (str5.Length == 9)
                            {
                                this.sMaThe_NhanVienMoi = "0" + str5;
                            }
                            if (str5.Length == 10)
                            {
                                this.sMaThe_NhanVienMoi = str5;
                            }
                            if (str5.Trim() == "")
                            {
                                this.sMaThe_NhanVienMoi = "0000000000";
                            }
                            this.DGVNhanVienMoi.Rows[num8].Cells[5].Value = str5;
                            this.DGVNhanVienMoi.Rows[num8].Cells[6].Value = str4;
                            this.DGVNhanVienMoi.Rows[num8].Cells[7].Value = num6;
                            this.DGVNhanVienMoi.Rows[num8].Cells[8].Value = flag;
                        }
                        if (str5 == "")
                        {
                            this.sMaThe_NhanVienMoi = "0000000000";
                        }
                        str6 = this.sMaThe_NhanVienMoi;
                        this.DGVNhanVienMoi.Rows[num8].Cells[5].Value = str6;
                        this.DGVNhanVienMoi.Rows[num8].Cells[6].Value = str4;
                        this.DGVNhanVienMoi.Rows[num8].Cells[7].Value = num6;
                        this.DGVNhanVienMoi.Rows[num8].Cells[8].Value = flag;
                        if (this.checkBoxTaiVanTay.Checked)
                        {
                            num3 = 0;
                            while (num3 < 10)
                            {
                                if (this.axCZKEM1.GetUserTmpExStr(this._iMachineNumber, str2, num3, out num5, out str, out num4))
                                {
                                    this._commonDTO.MaChamCong = Convert.ToInt32(str2);
                                    this._commonDTO.FingerIDVirtual = num3;
                                    this._commonDTO.FlagVirtual = num5;
                                    this._commonDTO.FingerTemplateVirtual = str;
                                    this._commonDTO.FingerVersionVirtual = this._phienBanVanTay;
                                    this._commonBLL.InsertTemplateVirtual(this._commonDTO);
                                }
                                num3++;
                            }
                        }
                        this.progressBarChay.Maximum = this.iSoDuLieu;
                        iSoDuLieu--;
                        num++;
                        int num13 = ((num + 1) * 100) / this.iSoDuLieu;
                        this.progressBarChay.Text = num13.ToString() + "%";
                        Application.DoEvents();
                        if (this.iSoDuLieu < 0)
                        {
                        }
                        if (this.iSoDuLieu >= 0)
                        {
                            this.progressBarChay.Value = this.iSoDuLieu - iSoDuLieu;
                        }
                    }
                }
                this.axCZKEM1.EnableDevice(this._iMachineNumber, true);
            }
            else
            {
                this.DGVNhanVienMoi.Rows.Clear();
                str2 = "";
                num5 = 1;
                int dwEnrollNumber = 0;
                str3 = "";
                str4 = "";
                num6 = 0;
                flag = false;
                str = "";
                num4 = 0;
                str5 = "";
                this.Cursor = Cursors.WaitCursor;
                this.axCZKEM1.EnableDevice(this._iMachineNumber, false);
                this.axCZKEM1.ReadAllUserID(this._iMachineNumber);
                while (this.axCZKEM1.GetAllUserInfo(this._iMachineNumber, ref dwEnrollNumber, ref str3, ref str4, ref num6, ref flag))
                {
                    table = new DataTable();
                    this._nhanVienDTO.MaChamCong = dwEnrollNumber.ToString();
                    if (this._nhanVienBLL.NhanVienGetByMaChamCong(this._nhanVienDTO).Rows.Count == 0)
                    {
                        num8 = this.DGVNhanVienMoi.Rows.Add();
                        if (dwEnrollNumber.ToString().Length == 0)
                        {
                            this.sMaNhanVien_NhanVienMoi = "00000";
                        }
                        if (dwEnrollNumber.ToString().Length == 1)
                        {
                            this.sMaNhanVien_NhanVienMoi = "0000" + dwEnrollNumber.ToString();
                        }
                        if (dwEnrollNumber.ToString().Length == 2)
                        {
                            this.sMaNhanVien_NhanVienMoi = "000" + dwEnrollNumber.ToString();
                        }
                        if (dwEnrollNumber.ToString().Length == 3)
                        {
                            this.sMaNhanVien_NhanVienMoi = "00" + dwEnrollNumber.ToString();
                        }
                        if (dwEnrollNumber.ToString().Length == 4)
                        {
                            this.sMaNhanVien_NhanVienMoi = "0" + dwEnrollNumber.ToString();
                        }
                        if (dwEnrollNumber.ToString().Length > 4)
                        {
                            this.sMaNhanVien_NhanVienMoi = dwEnrollNumber.ToString();
                        }
                        this.DGVNhanVienMoi.Rows[num8].Cells[1].Value = this.sMaNhanVien_NhanVienMoi;
                        this.DGVNhanVienMoi.Rows[num8].Cells[3].Value = dwEnrollNumber;
                        if (this.axCZKEM1.GetStrCardNumber(out str5))
                        {
                            if (str5 == "0")
                            {
                                this.sMaThe_NhanVienMoi = "0000000000";
                            }
                            if (str5.Length == 0)
                            {
                                this.sMaThe_NhanVienMoi = "0000000000";
                            }
                            if (str5.Length == 1)
                            {
                                this.sMaThe_NhanVienMoi = "000000000" + str5;
                            }
                            if (str5.Length == 2)
                            {
                                this.sMaThe_NhanVienMoi = "00000000" + str5;
                            }
                            if (str5.Length == 3)
                            {
                                this.sMaThe_NhanVienMoi = "0000000" + str5;
                            }
                            if (str5.Length == 4)
                            {
                                this.sMaThe_NhanVienMoi = "000000" + str5;
                            }
                            if (str5.Length == 5)
                            {
                                this.sMaThe_NhanVienMoi = "00000" + str5;
                            }
                            if (str5.Length == 6)
                            {
                                this.sMaThe_NhanVienMoi = "0000" + str5;
                            }
                            if (str5.Length == 7)
                            {
                                this.sMaThe_NhanVienMoi = "000" + str5;
                            }
                            if (str5.Length == 8)
                            {
                                this.sMaThe_NhanVienMoi = "00" + str5;
                            }
                            if (str5.Length == 9)
                            {
                                this.sMaThe_NhanVienMoi = "0" + str5;
                            }
                            if (str5.Length == 10)
                            {
                                this.sMaThe_NhanVienMoi = str5;
                            }
                            if (str5 == "")
                            {
                                this.sMaThe_NhanVienMoi = "0000000000";
                            }
                        }
                        if (str5 == "")
                        {
                            this.sMaThe_NhanVienMoi = "0000000000";
                        }
                        if ((str3 == null) || (str3 == ""))
                        {
                            this.DGVNhanVienMoi.Rows[num8].Cells[2].Value = dwEnrollNumber;
                            this.DGVNhanVienMoi.Rows[num8].Cells[4].Value = dwEnrollNumber;
                        }
                        else
                        {
                            this.DGVNhanVienMoi.Rows[num8].Cells[2].Value = str3;
                            this.DGVNhanVienMoi.Rows[num8].Cells[4].Value = str3;
                        }
                        str6 = this.sMaThe_NhanVienMoi;
                        this.DGVNhanVienMoi.Rows[num8].Cells[5].Value = str6;
                        this.DGVNhanVienMoi.Rows[num8].Cells[6].Value = str4;
                        this.DGVNhanVienMoi.Rows[num8].Cells[7].Value = num6;
                        this.DGVNhanVienMoi.Rows[num8].Cells[8].Value = flag;
                        str2 = dwEnrollNumber.ToString();
                        for (num3 = 0; num3 < 10; num3++)
                        {
                            if (this.axCZKEM1.GetUserTmpExStr(this._iMachineNumber, str2, num3, out num5, out str, out num4))
                            {
                                this._commonDTO.MaChamCong = Convert.ToInt32(str2);
                                this._commonDTO.FingerIDVirtual = num3;
                                this._commonDTO.FlagVirtual = num5;
                                this._commonDTO.FingerTemplateVirtual = str;
                                this._commonDTO.FingerVersionVirtual = this._phienBanVanTay;
                                this._commonBLL.InsertTemplateVirtual(this._commonDTO);
                            }
                        }
                        this.progressBarChay.Maximum = this.iSoDuLieu;
                        iSoDuLieu--;
                        num++;
                        this.progressBarChay.Text = ((((num + 1) * 100) / this.iSoDuLieu)).ToString() + "%";
                        Application.DoEvents();
                        if (this.iSoDuLieu < 0)
                        {
                        }
                        if (this.iSoDuLieu >= 0)
                        {
                            this.progressBarChay.Value = this.iSoDuLieu - iSoDuLieu;
                        }
                    }
                }
                this.axCZKEM1.EnableDevice(this._iMachineNumber, true);
                this.Cursor = Cursors.Default;
            }
        }



        private void demNhanVien()
        {
            int num = 0;
            int num2 = 0;
            for (int i = 1; i <= this.DGVNhanVienDaCoTrenMay.Rows.Count; i++)
            {
                num++;
            }
            this.label2.Text = "Nh\x00e2n vi\x00ean đ\x00e3 c\x00f3 tr\x00ean m\x00e1y t\x00ednh: " + num.ToString() + " nh\x00e2n vi\x00ean";
            for (int j = 1; j <= this.DGVNhanVienMoi.Rows.Count; j++)
            {
                num2++;
            }
            this.label3.Text = "Nh\x00e2n vi\x00ean mới: " + num2.ToString() + " nh\x00e2n vi\x00ean";
        }

 


            private void phienBanVanTay()
        {
            if (this.axCZKEM1.GetSysOption(1, "~ZKFPVersion", out this._phienBanVanTay))
            {
            }
        }



        private void frmTaiNhanVien_Load(object sender, EventArgs e)
        {
            this.radioNhanVienMoi.Checked = true;
            this.DGVNhanVienDaCoTrenMay.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            this.DGVNhanVienMoi.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            this.DGVNhanVienMoi.Columns[0].Width = 30;
            this.DGVNhanVienDaCoTrenMay.Columns[0].Width = 30;
            this.radioXoaNhanVien.Checked = true;
            this.checkBoxTaiVanTay.Checked = true;
            DataTable table = new DataTable();
            table = this._mayChamCongBLL.GETDANHSACHMCC();
            //  this.comboBox_Chonmay.DataSource = this._mayChamCongBLL.GetAllMCC();
            this.comboBox_Chonmay.DataSource = this._mayChamCongBLL.GETDANHSACHMCC();
            if (table.Rows.Count > 0)
            {
                this.comboBox_Chonmay.DisplayMember = "TenMCC";
                this.comboBox_Chonmay.ValueMember = "MaMCC";
            }
        }

        private void kiemTraLoaiMay()
        {
            if (this.axCZKEM1.IsTFTMachine(this._kiemTraManHinh))
            {
                this._loaiManHinh = this._kiemTraManHinh.ToString();
            }
            else
            {
                this._loaiManHinh = "1";
            }
        }

        private void comboBox_Chonmay_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            this._mayChamCongDTO.TenMCC = this.comboBox_Chonmay.Text;
            table = this._mayChamCongBLL.MayChamCongGetAllByTenMCC(this._mayChamCongDTO);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.sTenMay = this.comboBox_Chonmay.Text;
                this.sKieuKetNoi = table.Rows[i]["KieuKetNoi"].ToString();
                this.sDiaChiIP = table.Rows[i]["DiaChiIP"].ToString();
                this.sPort = table.Rows[i]["Port"].ToString();
                this.sDiaChiWeb = table.Rows[i]["DiaChiWeb"].ToString();
                this.sSuDungWeb = table.Rows[i]["SuDungWeb"].ToString();
                this.sSerial = table.Rows[i]["Serial"].ToString();
                this.sSoDangKy = table.Rows[i]["SoDangKy"].ToString();
                this.sTrangThai = table.Rows[i]["TrangThai"].ToString();

            }
        }

        private void button_Bochon2_Click(object sender, EventArgs e)
        {
            bool flag = true;
            flag = !flag;
            if (!flag)
            {
                for (int i = 0; i < this.DGVNhanVienMoi.Rows.Count; i++)
                {
                    this.DGVNhanVienMoi.Rows[i].Cells[0].Value = flag;
                }
            }
        }

        private void button_Bochon1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            flag = !flag;
            if (!flag)
            {
                for (int i = 0; i < this.DGVNhanVienDaCoTrenMay.Rows.Count; i++)
                {
                    this.DGVNhanVienDaCoTrenMay.Rows[i].Cells[0].Value = flag;
                }
            }

        }

        private void button_Chontatca1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            flag = !flag;
            if (flag)
            {
                for (int i = 0; i < this.DGVNhanVienDaCoTrenMay.Rows.Count; i++)
                {
                    this.DGVNhanVienDaCoTrenMay.Rows[i].Cells[0].Value = flag;
                }
            }

        }

        private void button_Chontatca2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            flag = !flag;
            if (flag)
            {
                for (int i = 0; i < this.DGVNhanVienMoi.Rows.Count; i++)
                {
                    this.DGVNhanVienMoi.Rows[i].Cells[0].Value = flag;
                }
            }

        }


        private void ActiveKey()
        {
            this._a = this.sdwSerialNumber.Substring(0, 2);
            int startIndex = this.sdwSerialNumber.Length - 4;
            this._b = this.sdwSerialNumber.Substring(startIndex);
            int num2 = this.sdwSerialNumber.Length - 2;
            this._c = this.sdwSerialNumber.Substring(num2);
            this.a = Convert.ToInt32(this._a);
            this.b = Convert.ToInt32(this._b);
            this.c = Convert.ToInt32(this._c);
            this._ketQua = (((this.a + this.b) + this.c) + 0x3ac95) - this.c;
        }

        private void button_taive_Click(object sender, EventArgs e)
        {
            if (this.radioNhanVienMoi.Checked)
            {
                this.luuNhanVienMoi();
            }
            if (this.radioToanBoNhanVien.Checked)
            {
                this.CapNhatChoNhanVienDaCoTrenPhanMem();
                this.listBoxThongTin.Items.Add("Đ\x00e3 cập nhật v\x00e2n tay xong");
            }

        }


        private void CapNhatChoNhanVienDaCoTrenPhanMem()
        {
            for (int i = 0; i < this.DGVNhanVienDaCoTrenMay.Rows.Count; i++)
            {
                if (Convert.ToBoolean(this.DGVNhanVienDaCoTrenMay[0, i].Value))
                {
                    int num2 = Convert.ToInt32(this.DGVNhanVienDaCoTrenMay.Rows[i].Cells[3].Value.ToString());
                    DataTable table = new DataTable();
                    this._templateCapNhatVanTayDTO.MaChamCong = num2;
                    table = this._templateCapNhatVanTayBLL.TemplateCapNhatVanTayGetByMaChamCong(this._templateCapNhatVanTayDTO);
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        this._templateDTO.MaChamCong = Convert.ToInt32(table.Rows[j]["MaChamCong"].ToString());
                        this._templateDTO.FingerID = Convert.ToInt32(table.Rows[j]["FingerIDCapNhatVanTay"].ToString());
                        this._templateDTO.Flag = Convert.ToInt32(table.Rows[j]["FlagCapNhatVanTay"].ToString());
                        this._templateDTO.FingerTemplate = table.Rows[j]["FingerTemplateCapNhatVanTay"].ToString();
                        this._templateDTO.FingerVersion = table.Rows[j]["FingerVersionCapNhatVanTay"].ToString();
                        this._templateBLL.ThemTemplate(this._templateDTO);
                    }
                    DataTable table2 = new DataTable();
                    this._nhanVienUpdateDTO.MaChamCong = num2;
                    table2 = this._nhanVienUpdateBLL.NhanVienUpdateGetByMaChamCong(this._nhanVienUpdateDTO);
                    for (int k = 0; k < table2.Rows.Count; k++)
                    {
                        this._nhanVienDTO.MaChamCong = table2.Rows[k]["MaChamCong"].ToString();
                        string str = table2.Rows[k]["MaThe"].ToString();
                        if (str == "")
                        {
                            this._nhanVienDTO.MaThe = "0000000000";
                        }
                        if (str.Trim().Length == 1)
                        {
                            this._nhanVienDTO.MaThe = "000000000" + str;
                        }
                        if (str.Trim().Length == 2)
                        {
                            this._nhanVienDTO.MaThe = "00000000" + str;
                        }
                        if (str.Trim().Length == 3)
                        {
                            this._nhanVienDTO.MaThe = "0000000" + str;
                        }
                        if (str.Trim().Length == 4)
                        {
                            this._nhanVienDTO.MaThe = "000000" + str;
                        }
                        if (str.Trim().Length == 5)
                        {
                            this._nhanVienDTO.MaThe = "00000" + str;
                        }
                        if (str.Trim().Length == 6)
                        {
                            this._nhanVienDTO.MaThe = "0000" + str;
                        }
                        if (str.Trim().Length == 7)
                        {
                            this._nhanVienDTO.MaThe = "000" + str;
                        }
                        if (str.Trim().Length == 8)
                        {
                            this._nhanVienDTO.MaThe = "00" + str;
                        }
                        if (str.Trim().Length == 9)
                        {
                            this._nhanVienDTO.MaThe = "0" + str;
                        }
                        if (str.Trim().Length == 10)
                        {
                            this._nhanVienDTO.MaThe = str;
                        }
                        this._nhanVienDTO.UserPassWord = table2.Rows[k]["UserPassWord"].ToString();
                        this._nhanVienDTO.PhanQuyen = Convert.ToInt32(table2.Rows[k]["PhanQuyen"].ToString());
                        this._nhanVienBLL.NhanVienUpdateToanBoNhanVien(this._nhanVienDTO);
                    }
                }
            }
        }



        private void luuNhanVienMoi()
        {
            int num = 0;
            int num2 = 0;
            bool flag = true;
            for (int i = 0; i < this.DGVNhanVienMoi.Rows.Count; i++)
            {
                if (Convert.ToBoolean(this.DGVNhanVienMoi[0, i].Value))
                {
                    string str = i.ToString();
                    string str2 = this.DGVNhanVienMoi.Rows[i].Cells[1].Value.ToString(); // ma nhan vien
                    string str3 = this.DGVNhanVienMoi.Rows[i].Cells[2].Value.ToString(); // ten nhan vien
                    string str4 = this.DGVNhanVienMoi.Rows[i].Cells[3].Value.ToString(); //ma chamcong
                    string str5 = this.DGVNhanVienMoi.Rows[i].Cells[4].Value.ToString(); // ten cham cong
                    string str6="000000";
                    //if (DGVNhanVienMoi.Rows[i].Cells[5].Value.ToString() != null)
                    //{
                    //    str6 = this.DGVNhanVienMoi.Rows[i].Cells[5].Value.ToString();

                    //}
                    //else
                    //{
                    //    str6 = "000000";
                    //}
                   //ma thẻ
                    string str9 = this.DGVNhanVienMoi.Rows[i].Cells[6].Value.ToString(); //password
                    string str8 = this.DGVNhanVienMoi.Rows[i].Cells[7].Value.ToString(); // phan quyen
                    string str10 = this.DGVNhanVienMoi.Rows[i].Cells[8].Value.ToString(); //UserEnable
                    this._nhanVienDTO.MaNhanVien = str2;
                    this._nhanVienDTO.TenNhanVien = str3;
                    this._nhanVienDTO.MaChamCong = str4;
                    this._nhanVienDTO.TenChamCong = str5;
                    if (str6.Length == 0)
                    {
                        this._nhanVienDTO.MaThe = "0000000000";
                    }
                    if (str6.Length == 1)
                    {
                        this._nhanVienDTO.MaThe = "000000000" + str6;
                    }
                    if (str6.Length == 2)
                    {
                        this._nhanVienDTO.MaThe = "00000000" + str6;
                    }
                    if (str6.Length == 3)
                    {
                        this._nhanVienDTO.MaThe = "0000000" + str6;
                    }
                    if (str6.Length == 4)
                    {
                        this._nhanVienDTO.MaThe = "000000" + str6;
                    }
                    if (str6.Length == 5)
                    {
                        this._nhanVienDTO.MaThe = "00000" + str6;
                    }
                    if (str6.Length == 6)
                    {
                        this._nhanVienDTO.MaThe = "0000" + str6;
                    }
                    if (str6.Length == 7)
                    {
                        this._nhanVienDTO.MaThe = "000" + str6;
                    }
                    if (str6.Length == 8)
                    {
                        this._nhanVienDTO.MaThe = "00" + str6;
                    }
                    if (str6.Length == 9)
                    {
                        this._nhanVienDTO.MaThe = "0" + str6;
                    }
                    if (str6.Length == 10)
                    {
                        this._nhanVienDTO.MaThe = str6;
                    }
                    this._nhanVienDTO.UserPassWord = str9;
                    this._nhanVienDTO.PhanQuyen = Convert.ToInt32(str8);
                    this._nhanVienDTO.UserEnable = str10;
                    this._nhanVienDTO.GioiTinh = Convert.ToBoolean(flag);
                    this._nhanVienDTO.NgayVaoLamViec = DateTime.Now;
                    this._nhanVienDTO.ChucVu = "";
                    this._nhanVienDTO.NgaySinh = DateTime.Now;
                    this._nhanVienDTO.NoiSinh = "";
                    this._nhanVienDTO.ThoiHanHopDong = 0;
                    this._nhanVienDTO.LoaiNhanVien = "";
                    this._nhanVienDTO.CMND = 0;
                    this._nhanVienDTO.DienThoaiLienHe = "";
                    this._nhanVienDTO.Email = "";
                    this._nhanVienDTO.NgayPhep = 12;
                    this._nhanVienDTO.TienLuong = "";
                    this._nhanVienDTO.LuongHopDong = "";
                    this._nhanVienDTO.DanToc = "";
                    this._nhanVienDTO.QuocTich = "";
                    this._nhanVienDTO.Skype = "";
                    this._nhanVienDTO.Yahoo = "";
                    this._nhanVienDTO.Facebook = "";
                    this._nhanVienDTO.PassWord = "";
                    this._nhanVienDTO.NhanVienMoi = true;
                    this._nhanVienBLL.InsertNhanVienFromDevice(this._nhanVienDTO);
                    if (this.checkBoxTaiVanTay.Checked)
                    {
                        DataTable table = new DataTable();
                        this._commonDTO.MaChamCong = Convert.ToInt32(str4);
                        table = this._commonBLL.SelectTemplateVirtualByMaChamCong(this._commonDTO);
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            this._templateDTO.MaChamCong = Convert.ToInt32(table.Rows[j]["MaChamCong"].ToString());
                            this._templateDTO.FingerID = Convert.ToInt32(table.Rows[j]["FingerIDVirtual"].ToString());
                            this._templateDTO.Flag = Convert.ToInt32(table.Rows[j]["FlagVirtual"].ToString());
                            this._templateDTO.FingerTemplate = table.Rows[j]["FingerTemplateVirtual"].ToString();
                            this._templateDTO.FingerVersion = table.Rows[j]["FingerVersionVirtual"].ToString();
                            this._templateBLL.ThemTemplate(this._templateDTO);
                            num2++;
                        }
                    }
                    if (this.checkBoxTaiKhuonMat.Checked)
                    {
                    }
                    num++;
                    this.button_taive.Text = "Tải về: " + num;
                    Application.DoEvents();
                }
            }
            this.listBoxThongTin.Items.Add("Số nhân viên vừa tải: " + num);
            this.listBoxThongTin.Items.Add("Số vân tay: " + num2);
            this._commonBLL.DeleteALLTemplateVirtual(this._commonDTO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _value = "H-0156";
            string _name = "CHU XUÂN TÌNH";
            Class.App._manv = _value;
            Class.App._hotennv = _name;
            frmEmployee_Update frm = new frmEmployee_Update(false, "Cập nhật nhân viên: " + _name + "(" + _value + ")", "NV", _value, "frmDanhSachNhanVien");
            frm.Owner = this;
            frm.ShowDialog();
            this.Activate();

        }
    }
}
