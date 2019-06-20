using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHBK2014_N9.ATT.BLL.MayChamCong;
using CHBK2014_N9.ATT.DTO.MayChamCong;
using System.Net;
using zkemkeeper;
using System.IO;
using System.Threading;


namespace CHBK2014_N9.ATT.UI
{
    public partial class frmQuanLyMayChamCong : Form
    {

        public bool _bIsConnected;
        private string _c;
        public string _DiaChiIP;
        public string _DiaChiWeb;
        public int _iMachineNumber;
        private int _ketQua;
        public string _KieuKetNoi;
        //  CZKEM axCZKEM1 = new CZKEM();
        //   public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        //     zkemkeeper.CZKEMClass axczkem1 = new zkemkeeper.CZKEMClass();
        public CZKEMClass axCZKEM1 = new CZKEMClass();
        private MayChamCongBLL _mayChamCongBLL = new MayChamCongBLL();
        private MayChamCongDTO _mayChamCongDTO = new MayChamCongDTO();
        private string sCongCOM;
        private string sDiaChiIP;
        private string sDiaChiWeb;
        private string sIDMCC;
        private string sKieuKetNoi;
        private string sMaMCC;
        private string sPort;
        private string sSerial;
        private string sSoDangKy;
        private string sSuDungWeb;
        private string sTenMCC;
        private string sTinhTrang;
        private string sTocDoTruyen;
        private string sTrangThai;
        //private TabControl tabControl1;
        //private TabPage tabPage1;
        //private TabPage tabPage2;
       // private TextBox txtThoiGian;


        public frmQuanLyMayChamCong()
        {
            InitializeComponent();
        }

        private void frmQuanLyMayChamCong_Load(object sender, EventArgs e)
        {

            dataGridView_MayChamCong.DataSource = this._mayChamCongBLL.GETDANHSACHMCC();

        }

        private void dataGridView_MayChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaMay.Text = this.dataGridView_MayChamCong.CurrentRow.Cells[0].Value.ToString();
            textBox_TenMay.Text = this.dataGridView_MayChamCong.CurrentRow.Cells[1].Value.ToString();
            textBox_IDMay.Text = this.dataGridView_MayChamCong.CurrentRow.Cells[2].Value.ToString();
            comboBox_Kieuketnoi.Text = this.dataGridView_MayChamCong.CurrentRow.Cells[3].Value.ToString();
            lbDiaChiIPThongTin.Text = this.dataGridView_MayChamCong.CurrentRow.Cells[4].Value.ToString();
            textBox_Port.Text = this.dataGridView_MayChamCong.CurrentRow.Cells[5].Value.ToString();
            comboBox_Com.Text = this.dataGridView_MayChamCong.CurrentRow.Cells[6].Value.ToString();
            comboBox_Tocdotruyen.Text = this.dataGridView_MayChamCong.CurrentRow.Cells[7].Value.ToString();
           this.sDiaChiWeb = this.dataGridView_MayChamCong.CurrentRow.Cells[8].Value.ToString();
           this.sSuDungWeb = this.dataGridView_MayChamCong.CurrentRow.Cells[10].Value.ToString();
            lbSerialThongTin.Text = this.dataGridView_MayChamCong.CurrentRow.Cells[11].Value.ToString();

        }

        private bool isDeviceConnected = false;
        public bool IsDeviceConnected
        {
            get { return isDeviceConnected; }
            set
            {
                isDeviceConnected = value;
                if (isDeviceConnected)
                {
                   // ShowStatusBar("The device is connected !!", true);
                    button1.Text = "Disconnect";
                    //     ToggleControls(true);
                }
                else
                {
                  //  ShowStatusBar("The device is diconnected !!", true);
                    axCZKEM1.Disconnect();
                    button1.Text = "Connect";
                    // ToggleControls(false);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (this.sKieuKetNoi == "TCP/IP")
            // {

            //if (IsDeviceConnected)
            //{
            //    IsDeviceConnected = false;
            //    this.Cursor = Cursors.Default;

            //    return;
            //}

            sDiaChiIP = lbDiaChiIPThongTin.Text;
            sPort = textBox_Port.Text;

            //if (sDiaChiIP == string.Empty || sPort == string.Empty)
            //    throw new Exception("The Device IP Address and Port is mandotory !!");

          
            //if (!int.TryParse(sPort, out portNumber))
            //    throw new Exception("Not a valid port number");

            
                    this.Cursor = Cursors.WaitCursor;
                    this._bIsConnected = this.axCZKEM1.Connect_Net(this.sDiaChiIP, Convert.ToInt32(this.sPort));
                    this.thongTinMCC();
                    this.Cursor = Cursors.Default;
               
           // }
           
        }

     
    
        public void thongTinMCC()
        {
            string iPAddr = "";
            int dwValue = 0;
            string dwSerialNumber = "";
            if (this.axCZKEM1.GetSerialNumber(this._iMachineNumber, out dwSerialNumber))
            {
                this.lbSerialThongTin.Text = dwSerialNumber;
            }
            if (this.axCZKEM1.GetDeviceIP(this._iMachineNumber, ref iPAddr))
            {
                this.lbDiaChiIPThongTin.Text = iPAddr;
            }
            else
            {
                this.lbDiaChiIPThongTin.Text = "N/A";
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 1, ref dwValue))
            {
                lbNhanVienQuanLyThongTin.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 2, ref dwValue))
            {
                lbTongSoNhanVienThongTin.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 3, ref dwValue))
            {
                this.lbVanTayThongTin.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 4, ref dwValue))
            {
                this.lbMatMaThongTin.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 5, ref dwValue))
            {
                this.lbRecordQuanLyThongTin.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 6, ref dwValue))
            {
                this.lbDuLieuChamCongThongTin.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 7, ref dwValue))
            {
                this.lbVanTayBoNhoToiDa.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 8, ref dwValue))
            {
                this.lbNhanVienBoNhoToiDa.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 9, ref dwValue))
            {
                this.lbDuLieuChamCongBoNhoToiDa.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 0x15, ref dwValue))
            {
                this.lbKhuonMat.Text = dwValue.ToString();
            }
            if (this.axCZKEM1.GetDeviceStatus(1, 0x16, ref dwValue))
            {
                this.lbTongSoKhuonMat.Text = dwValue.ToString();
            }
            int dwYear = 0;
            int dwMonth = 0;
            int dwDay = 0;
            int dwHour = 0;
            int dwMinute = 0;
            int dwSecond = 0;
            if (this.axCZKEM1.GetDeviceTime(this._iMachineNumber, ref dwYear, ref dwMonth, ref dwDay, ref dwHour, ref dwMinute, ref dwSecond))
            {
               this.txtThoiGian.Text = dwYear.ToString() + "-" + dwMonth.ToString() + "-" + dwDay.ToString() + " " + dwHour.ToString() + ":" + dwMinute.ToString() + ":" + dwSecond.ToString();
            }
        }


    }
}
