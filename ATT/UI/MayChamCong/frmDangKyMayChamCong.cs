using CHBK2014_N9.ATT.BLL.MayChamCong;
using CHBK2014_N9.ATT.DTO.MayChamCong;
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using zkemkeeper;

namespace CHBK2014_N9.ATT.UI.MayChamCong
{
    public partial class frmDangKyMayChamCong : Form
    {


        public CZKEMClass axCZKEM1 = new CZKEMClass();
        private string _a;
        private string _b;
        private string _c;
        private int _ketQua;
        private MayChamCongBLL _mayChamCongBLL = new MayChamCongBLL();
        private MayChamCongDTO _mayChamCongDTO = new MayChamCongDTO();
        private int a;
        private ArrayList arrMayChamCong = new ArrayList();
       



        private int b;
        // private Bar bar1;
        private bool bIsConnected = false;
        private int c;
        private string sMaMayChamCong;
        private string sSuDungWeb;
        private int iMachineNumber = 1;
        private int iNgonNgu;
        public frmDangKyMayChamCong()
        {
            // this.components = null;
            //this.axCZKEM1 = new CZKEMClass();
            //   this.bIsConnected = false;
            //  this.iMachineNumber = 1;
            //   this._mayChamCongDTO = new MayChamCongDTO();
            //  this._mayChamCongBLL = new MayChamCongBLL();
            // this.arrMayChamCong = new ArrayList();
            //  this._ngonNgu = ConfigurationManager.OpenExeConfiguration("MitaAttendance.exe");

            InitializeComponent();
        }

        private void frmDangKyMayChamCong_Load(object sender, EventArgs e)
        {
            this.comboBoxMayChamcong.DataSource = this._mayChamCongBLL.GETDANHSACHMCC();
            this.comboBoxMayChamcong.DisplayMember = "TenMCC";
            this.comboBoxMayChamcong.ValueMember = "MaMCC";


            //   this.axCZKEM1 = new CZKEMClass();
            //    this.bIsConnected = false;
            //  this.iMachineNumber = 1;
            //  this._mayChamCongDTO = new MayChamCongDTO();
            //  this._mayChamCongBLL = new MayChamCongBLL();
            //  this.arrMayChamCong = new ArrayList();

        }

        private void ActiveKey()
        {
            this._a = this.txtSerial.Text.Substring(0, 2);
            int startIndex = this.txtSerial.Text.Length - 4;
            this._b = this.txtSerial.Text.Substring(startIndex);
            int num2 = this.txtSerial.Text.Length - 2;
            this._c = this.txtSerial.Text.Substring(num2);
            this.a = Convert.ToInt32(this._a);
            this.b = Convert.ToInt32(this._b);
            this.c = Convert.ToInt32(this._c);
            this._ketQua = (((this.a + this.b) + this.c) + 240789) - this.c;
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            if (this.iNgonNgu == 0)
            {
                if (this.txtSerial.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa kết nối để c\x00f3 số serial", "Th\x00f4ng b\x00e1o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    this.ActiveKey();
                    if (int.Parse(this.txtDangKy.Text) == this._ketQua)
                    {
                        MessageBox.Show("Đăng k\x00fd th\x00e0nh c\x00f4ng");
                        this.axCZKEM1.Disconnect();
                        this._mayChamCongDTO.MaMCC = this.sMaMayChamCong;
                        this._mayChamCongDTO.Serial = this.txtSerial.Text;
                        this._mayChamCongDTO.SoDangKy = this.txtDangKy.Text;
                        this._mayChamCongBLL.SUAACTIVEKEY(this._mayChamCongDTO);
                        goto Label_00F6;
                    }
                    MessageBox.Show("Sai số đăng k\x00fd");
                }
                return;
            }
        Label_00F6:
            if (this.iNgonNgu == 1)
            {
                if (this.txtSerial.Text.Trim() == "")
                {
                    MessageBox.Show("You are not connected to the serial number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    this.ActiveKey();
                    if (int.Parse(this.txtDangKy.Text) == this._ketQua)
                    {
                        MessageBox.Show("Successfully Registered");
                        this.axCZKEM1.Disconnect();
                        this._mayChamCongDTO.MaMCC = this.sMaMayChamCong;
                        this._mayChamCongDTO.Serial = this.txtSerial.Text;
                        this._mayChamCongDTO.SoDangKy = this.txtDangKy.Text;
                        this._mayChamCongBLL.SUAACTIVEKEY(this._mayChamCongDTO);
                    }
                    else
                    {
                        MessageBox.Show("False registration numbers");
                    }
                }
            }
        }

        private void Button_KetNoi_Click(object sender, EventArgs e)
        {

            string str;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //   ShowStatusBar(string.Empty, true);

                if (IsDeviceConnected)
                {
                    IsDeviceConnected = false;
                    this.Cursor = Cursors.Default;

                    return;
                }

                //string ipAddress = tbxDeviceIP.Text.Trim();
                //string port = tbxPort.Text.Trim();
                //if (ipAddress == string.Empty || port == string.Empty)
                //    throw new Exception("The Device IP Address and Port is mandotory !!");

                //int portNumber = 4370;
                //if (!int.TryParse(port, out portNumber))
                //    throw new Exception("Not a valid port number");

                //bool isValidIpA = CHBK2014_N9.ATT.Utilities.UniversalStatic.ValidateIP(ipAddress);
                //if (!isValidIpA)
                //    throw new Exception("The Device IP is invalid !!");

                //isValidIpA = CHBK2014_N9.ATT.Utilities.UniversalStatic.PingTheDevice(ipAddress);
                //if (!isValidIpA)
                //    throw new Exception("The device at " + ipAddress + ":" + port + " did not respond!!");


                string IP1;

                IP1 = lbDiaChiIPThongTin.Text;
                string sport = lbPortThongTin.Text;

                IsDeviceConnected = axCZKEM1.Connect_Net(IP1,  Convert.ToInt32(sport));

                if (IsDeviceConnected)
                {



                    str = "";

                    this.iMachineNumber = 1;
                    this.axCZKEM1.RegEvent(this.iMachineNumber, 65535);
                    this.Cursor = Cursors.WaitCursor;
                    if (this.axCZKEM1.GetSerialNumber(this.iMachineNumber, out str))
                    {
                        this.txtSerial.Text = str;
                    }
                    this.Cursor = Cursors.Default;
                }

            }
            catch (Exception ex)
            {
                ShowStatusBar(ex.Message, false);
            }
            this.Cursor = Cursors.Default;


        }









        private void comboBoxMayChamcong_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            this._mayChamCongDTO.TenMCC = this.comboBoxMayChamcong.Text;
            table = this._mayChamCongBLL.MayChamCongGetAllByTenMCC(this._mayChamCongDTO);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.sMaMayChamCong = table.Rows[i]["MaMCC"].ToString();
                this.lbIDMayThongTin.Text = table.Rows[i]["IDMCC"].ToString();
                this.lbKieuKetNoiThongTin.Text = table.Rows[i]["KieuKetNoi"].ToString();
                this.lbDiaChiIPThongTin.Text = table.Rows[i]["DiaChiIP"].ToString();
                this.lbPortThongTin.Text = table.Rows[i]["Port"].ToString();
                this.lbCongCOMThongTin.Text = table.Rows[i]["CongCOM"].ToString();
                this.lbTocDoTruyenThongTin.Text = table.Rows[i]["TocDoTruyen"].ToString();
                this.lbDiaChiWebThongTin.Text = table.Rows[i]["DiaChiWeb"].ToString();
                this.sSuDungWeb = table.Rows[i]["SuDungWeb"].ToString();
                if (this.sSuDungWeb == "True")
                {
                    this.lbKetNoiTuXaThongTin.Text = "C\x00f3";
                }
                else
                {
                    this.lbKetNoiTuXaThongTin.Text = "Kh\x00f4ng";
                }
            }
        }

        private void frmDangKyMayChamCong_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.axCZKEM1.Disconnect();
        }


        CHBK2014_N9.ATT.Utilities.DeviceManipulator manipulator = new CHBK2014_N9.ATT.Utilities.DeviceManipulator();
        public CHBK2014_N9.ATT.Utilities.ZkemClient objZkeeper;
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
                    button_DangKy.Text = "Disconnect";
                    //     ToggleControls(true);
                }
                else
                {
                    ShowStatusBar("The device is diconnected !!", true);
                    objZkeeper.Disconnect();
                    button_DangKy.Text = "Connect";
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
                        button_DangKy.Text = "Connect";
                        //   ToggleControls(false);
                        break;
                    }

                default:
                    break;
            }

        }


     

    
    }
}
