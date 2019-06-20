//using DevComponents.Editors;
using CHBK2014_N9.ATT.BLL.MayChamCong;
using CHBK2014_N9.ATT.BLL.MayChamCong.DuLieuTuMayChamCongBLL;
using CHBK2014_N9.ATT.DTO.MayChamCong;
using CHBK2014_N9.ATT.DTO.MayChamCong.DuLieuMayChamCongDTO;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using zkemkeeper;

using System.IO;

using System.Globalization;
namespace CHBK2014_N9.ATT.UI.MayChamCong.DuLieuMayChamCong
{
    public partial class frmTaiDuLieuChamCong : Form
    {

        public bool _bIsConnected;
        private CheckInOutBLL _checkInOutBLL = new CheckInOutBLL();
        private CheckInOutDTO _checkInOutDTO = new CheckInOutDTO();
        public string _DiaChiIP;
        public string _DiaChiWeb;
        public string _IDMay;
        public int _iMachineNumber;
        private int _kiemTraManHinh = 0;
        public string _KieuKetNoi;
        private string _loaiManHinh;
        private MayChamCongBLL _mayChamCongBLL = new MayChamCongBLL();
        private MayChamCongDTO _mayChamCongDTO = new MayChamCongDTO();
        public string _Port;
        public string _Serial;
        public string _SoDangKy;
        public string _SuDungWeb;
        public string _TenMay;
        private int _value = 0;
        private ArrayList arrMCC = new ArrayList();
        // public CZKEM axCZKEM1 = new CZKEM();
        public CZKEMClass axCZKEM1 = new CZKEMClass();
        private string dNgay;
        private string dNgayGio;
        private int iSoDuLieu;
       
        private string sDiaChiIP;
        private string sDiaChiWeb;
        private string sIDMCC;
        private string sKieuKetNoi;
        private string sMaMCC;
        private string sPort;
        private string sSerial;
        private string sSoDangKy;
        private string sSuDungWeb;
        private string sTenMay ;
        private string sTrangThai;
        private string sTrangThaiMay;
        private int iMachineNumber;
        public CHBK2014_N9.ATT.Utilities.ZkemClient axCZKEM2;
        public frmTaiDuLieuChamCong()
        {
            InitializeComponent();
            //   this.comboBoxLuaChonTai.ComboWidth = 150;
            //this.comboBoxLuaChonTai.DropDownHeight = 0x6a;
            //this.comboBoxLuaChonTai.ItemHeight = 0x10;
            //this.comboBoxLuaChonTai.Items.AddRange(new object[] { this.comboItem1, this.comboItem2 });
            //this.comboBoxLuaChonTai.Name = "comboBoxLuaChonTai";
            //this.comboBoxLuaChonTai.SelectedIndexChanged += new EventHandler(this.comboBoxLuaChonTai_SelectedIndexChanged);


            this._kiemTraManHinh = 0;
            this._checkInOutDTO = new CheckInOutDTO();
            this._checkInOutBLL = new CheckInOutBLL();
            this._value = 0;
            this._mayChamCongBLL = new MayChamCongBLL();
            this.arrMCC = new ArrayList();

            this.DGVDuLieuVaoRa.AllowUserToAddRows = false;


       //     this.DGVDuLieuVaoRa.BackgroundColor = Color.GhostWhite;
          //  this.DGVDuLieuVaoRa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
       //   this.DGVDuLieuVaoRa.Columns.AddRange(new DataGridViewColumn[] { this.ColMaChamCong, this.ColNgay, this.ColGio, this.Column4, this.Column5, this.Column6, this.ColTenMay });

            //this.DGVDuLieuVaoRa.Dock = DockStyle.Fill;
            //this.DGVDuLieuVaoRa.GridColor = Color.FromArgb(0xd0, 0xd7, 0xe5);
            //this.DGVDuLieuVaoRa.Location = new Point(0, 0);
            //this.DGVDuLieuVaoRa.Name = "DGVDuLieuVaoRa";
            //this.DGVDuLieuVaoRa.Size = new Size(0x2e7, 0x233);
            //this.DGVDuLieuVaoRa.TabIndex = 2;
            //this.ColMaChamCong.HeaderText = "M\x00e3 Chấm C\x00f4ng";
            //this.ColMaChamCong.Name = "ColMaChamCong";
            //this.ColNgay.HeaderText = "Ng\x00e0y";
            //this.ColNgay.Name = "ColNgay";
            //this.ColGio.HeaderText = "Giờ";
            //this.ColGio.Name = "ColGio";
            //this.Column4.HeaderText = "Kiểu Chấm";
            //this.Column4.Name = "Column4";
            //this.Column5.HeaderText = "Nguồn Chấm";
            //this.Column5.Name = "Column5";
            //this.Column6.HeaderText = "M\x00e3 Số M\x00e1y";
            //this.Column6.Name = "Column6";
            //this.ColTenMay.HeaderText = "T\x00ean M\x00e1y";
            //this.ColTenMay.Name = "ColTenMay";


        }

        private void frmTaiDuLieuChamCong_Load(object sender, EventArgs e)
        {
           this.comboBoxLuaChonTai.SelectedIndex = 0;
         //  this.panel1.Hide();
         //  this._loadMCCLenListView();
            comboBox_MCCVL.DataSource = _mayChamCongBLL.GETDANHSACHMCC();
            comboBox_MCCVL.DisplayMember = "TenMCC";
            comboBox_MCCVL.ValueMember = "MaMCC";
            
        }



        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (this.components != null))
        //    {
        //        this.components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //this.DGVDuLieuVaoRa.AllowUserToAddRows = false;






        private void kiemTraLoaiMay()
        {
            if (this.axCZKEM1.IsTFTMachine(this._kiemTraManHinh))
            {
                this._loaiManHinh = this._kiemTraManHinh.ToString();
            }
            else
            {
                this._loaiManHinh = "N/A";
            }
        }
        private void taiDuLieuVaoRa()
        {
            int num3;
            int num4;
            int num5;
            int num6;
            int num7;
            int num8;
            int num9;
            int num10;
            int num12;
            DataTable dataSource;
            DataGridViewRow row;
            int num15;
            int num = -1;
            int iSoDuLieu = this.iSoDuLieu;
            if (this._loaiManHinh == "0")
            {
               string dwEnrollNumber = "";
               string str2 = "";
                num3 = 0;
                num4 = 0;
                num5 = 0;
                num6 = 0;
                num7 = 0;
                num8 = 0;
                num9 = 0;
                num10 = 0;
                int dwWorkCode = 0;
                num12 = 0;
               iMachineNumber = 4;
                this.axCZKEM1.EnableDevice(this._iMachineNumber, false);
                if (this.comboBoxLuaChonTai.SelectedIndex == 0)
                {
                    if (this.axCZKEM1.ReadGeneralLogData(this._iMachineNumber))
                    {
                        while (this.axCZKEM1.SSR_GetGeneralLogData(this._iMachineNumber, out dwEnrollNumber, out num3, out num4, out num5, out num6, out num7, out num8, out num9, out num10, ref dwWorkCode))
                        {
                            dataSource = new DataTable();
                            dataSource = (DataTable)this.DGVDuLieuVaoRa.DataSource;
                            //   DateTime   str22 = Convert.ToDateTime(num7.ToString() + "/" + num6.ToString() + "/" + num5.ToString());
                            //  str2 = string.Format("dd/MM/yyyy", str22);

                            str2 = num7.ToString() + "/" + num6.ToString() + "/" + num5.ToString();

                            int num13 = 0;
                            row = new DataGridViewRow();
                            string str3 = dwEnrollNumber.ToString();
                           //   DateTime str44 = Convert.ToDateTime(num7.ToString() + "/" + num6.ToString() + "/" + num5.ToString());

                          string  str4 = num7.ToString() + "/" + num6.ToString() + "/" + num5.ToString();
                            //  string str4 = string.Format("dd/MM/yyyy", str44);

                         //   DateTime time = Convert.ToDateTime(num7.ToString() + "/" + num6.ToString() + "/" + num5.ToString() + " " + num8.ToString() + ":" + num9.ToString() + ":" + num10.ToString());
                           // string str5 = string.Format("{0:G}", time);

                           string str5 = num7.ToString() + "/" + num6.ToString() + "/" + num5.ToString() + " " + num8.ToString() + ":" + num9.ToString() + ":" + num10.ToString();
                            DataTable table2 = new DataTable();
                            table2 = this._checkInOutBLL.SelectAllCheckInOut(this._checkInOutDTO);
                            for (int i = 0; i < table2.Rows.Count; i++)
                            {
                                if (table2.Rows[i]["GioCham"].ToString() == str5)
                                {
                                    num13++;
                                }
                            }
                            if (num13 == 0)
                            {
                                num15 = this.DGVDuLieuVaoRa.Rows.Add();
                                this.DGVDuLieuVaoRa.Rows[num15].Cells[0].Value = dwEnrollNumber.ToString();
                                this.DGVDuLieuVaoRa.Rows[num15].Cells[1].Value = num7.ToString() + "/" + num6.ToString() + "/" + num5.ToString();
                                this.DGVDuLieuVaoRa.Rows[num15].Cells[2].Value = num7.ToString() + "/" + num6.ToString() + "/" + num5.ToString() + " " + num8.ToString() + ":" + num9.ToString() + ":" + num10.ToString();
                                this.DGVDuLieuVaoRa.Rows[num15].Cells[3].Value = num4.ToString();
                                this.DGVDuLieuVaoRa.Rows[num15].Cells[4].Value = num3.ToString();
                                this.DGVDuLieuVaoRa.Rows[num15].Cells[5].Value = this.sTrangThaiMay;
                               this.DGVDuLieuVaoRa.Rows[num15].Cells[6].Value = this.sTenMay;
                                this._checkInOutDTO.MaChamCong = Convert.ToInt32(this.DGVDuLieuVaoRa.Rows[num15].Cells[0].Value.ToString());
                             this._checkInOutDTO.NgayCham = DateTime.Parse(this.DGVDuLieuVaoRa.Rows[num15].Cells[1].Value.ToString());
                         //     this._checkInOutDTO.NgayCham = Convert.ToDateTime(this.DGVDuLieuVaoRa.Rows[num15].Cells[1].Value.ToString());

                                this._checkInOutDTO.GioCham = Convert.ToDateTime(this.DGVDuLieuVaoRa.Rows[num15].Cells[2].Value.ToString());
                                this._checkInOutDTO.KieuCham = this.DGVDuLieuVaoRa.Rows[num15].Cells[3].Value.ToString();
                                this._checkInOutDTO.NguonCham = this.DGVDuLieuVaoRa.Rows[num15].Cells[4].Value.ToString();

                          //      int mamay = 4;
                             this._checkInOutDTO.MaSoMay = Convert.ToInt32(this.DGVDuLieuVaoRa.Rows[num15].Cells[5].Value.ToString());

                              this._checkInOutDTO.TenMay = this.DGVDuLieuVaoRa.Rows[num15].Cells[6].Value.ToString();
                                this._checkInOutBLL.Insert_CheckinOut(this._checkInOutDTO);
                                object[] objArray = new object[4];
                                objArray[0] = "Đang lưu: ";
                                int num22 = num15 + 1;
                                objArray[1] = num22.ToString();
                                objArray[2] = "/";
                                objArray[3] = this.iSoDuLieu;
                                this.lbSoRecord.Text = string.Concat(objArray);
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
                                switch (num4)
                                {
                                    case 0:
                                        this.DGVDuLieuVaoRa.Rows[num15].Cells[3].Value = "IN";
                                        break;

                                    case 1:
                                        this.DGVDuLieuVaoRa.Rows[num15].Cells[3].Value = "OUT";
                                        break;

                                    case 4:
                                        this.DGVDuLieuVaoRa.Rows[num15].Cells[3].Value = "IN_OT";
                                        break;

                                    case 5:
                                        this.DGVDuLieuVaoRa.Rows[num15].Cells[3].Value = "OUT_OT";
                                        break;
                                }
                                if (num3 == 1)
                                {
                                    this.DGVDuLieuVaoRa.Rows[num15].Cells[4].Value = "FP";
                                }
                                if (num3 == 4)
                                {
                                    this.DGVDuLieuVaoRa.Rows[num15].Cells[4].Value = "RF";
                                }
                                if (num3 == 3)
                                {
                                    this.DGVDuLieuVaoRa.Rows[num15].Cells[4].Value = "PW";
                                }
                            }
                        }
                        int dwValue = 0;
                        if (this.axCZKEM1.GetDeviceStatus(this._iMachineNumber, 6, ref dwValue))
                        {
                            this.panel1.Hide();
                        }
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        this.axCZKEM1.GetLastError(ref num12);
                        if (num12 != 0)
                        {
                            MessageBox.Show("Reading data from terminal failed,ErrorCode: " + num12.ToString(), "Error");
                        }
                        else
                        {
                            MessageBox.Show("Kh\x00f4ng c\x00f3 dữ liệu tr\x00ean m\x00e1y chấm c\x00f4ng", "Th\x00f4ng b\x00e1o", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                if (this.comboBoxLuaChonTai.SelectedIndex == 1)
                {
                }
                this.axCZKEM1.EnableDevice(this._iMachineNumber, true);
            }
            else
            {
                int dwTMachineNumber = 0;
                int num18 = 0;
                int dwEMachineNumber = 0;
                num3 = 0;
                num4 = 0;
                num5 = 0;
                num6 = 0;
                num7 = 0;
                num8 = 0;
                num9 = 0;
                num10 = 0;
                num12 = 0;
                this.Cursor = Cursors.WaitCursor;
                this.DGVDuLieuVaoRa.Rows.Clear();
                this.axCZKEM1.EnableDevice(this._iMachineNumber, false);
                if (this.axCZKEM1.ReadGeneralLogData(this._iMachineNumber))
                {
                    while (this.axCZKEM1.GetGeneralLogData(this._iMachineNumber, ref dwTMachineNumber, ref num18, ref dwEMachineNumber, ref num3, ref num4, ref num5, ref num6, ref num7, ref num8, ref num9))
                    {
                        dataSource = new DataTable();
                        dataSource = (DataTable)this.DGVDuLieuVaoRa.DataSource;
                        row = new DataGridViewRow();
                        num15 = this.DGVDuLieuVaoRa.Rows.Add();
                        this.DGVDuLieuVaoRa.Rows[num15].Cells[0].Value = num18.ToString();
                        this.DGVDuLieuVaoRa.Rows[num15].Cells[1].Value = num6.ToString() + "/" + num7.ToString() + "/" + num5.ToString();
                        this.DGVDuLieuVaoRa.Rows[num15].Cells[2].Value = num6.ToString() + "/" + num7.ToString() + "/" + num5.ToString() + " " + num8.ToString() + ":" + num9.ToString() + ":" + num10.ToString();
                        this.DGVDuLieuVaoRa.Rows[num15].Cells[3].Value = num4.ToString();
                        this.DGVDuLieuVaoRa.Rows[num15].Cells[4].Value = num3.ToString();
                        this.DGVDuLieuVaoRa.Rows[num15].Cells[5].Value = num18.ToString();
                    }
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    this.axCZKEM1.GetLastError(ref num12);
                    if (num12 != 0)
                    {
                        MessageBox.Show("Reading data from terminal failed,ErrorCode: " + num12.ToString(), "Error");
                    }
                    else
                    {
                        MessageBox.Show("No data from terminal returns!", "Error");
                    }
                }
                this.axCZKEM1.EnableDevice(this._iMachineNumber, true);
                this.Cursor = Cursors.Default;
            }
        }



        private void _loadMCCLenListView()
        {
            this.arrMCC = this._mayChamCongBLL.GetAllMCC();
            if (this.arrMCC != null)
            {
                this.listViewMayChamCong.Items.Clear();
                foreach (MayChamCongDTO gdto in this.arrMCC)
                {
                    ListViewItem item = new ListViewItem(gdto.TenMCC.ToString(), 0);
                    item.SubItems.Add(gdto.KieuKetNoi.ToString());
                    item.SubItems.Add(gdto.DiaChiIP.ToString());
                    item.SubItems.Add(gdto.Port.ToString());
                    item.SubItems.Add(gdto.DiaChiWeb.ToString());
                    item.SubItems.Add(gdto.SuDungWeb.ToString());
                    item.SubItems.Add(gdto.Serial.ToString());
                    item.SubItems.Add(gdto.SoDangKy.ToString());
                    item.SubItems.Add(gdto.TrangThai.ToString());
                    item.SubItems.Add(gdto.MaMCC.ToString());
                    item.SubItems.Add(gdto.IDMCC.ToString());
                    item.SubItems.Add(gdto.TrangThaiMay.ToString());
                    this.listViewMayChamCong.Items.Add(item);
                }
            }
            else
            {
                this.listViewMayChamCong.Items.Clear();
            }
        }

        private void btnTaiVeMayTinh_Click(object sender, EventArgs e)
        {
            this.DGVDuLieuVaoRa.Rows.Clear();

           // foreach (ListViewItem item in this.listViewMayChamCong.CheckedItems)
           //{
           //     this.sTenMay = item.SubItems[0].Text;
           //     this.sKieuKetNoi = item.SubItems[1].Text;
           //     this.sDiaChiIP = item.SubItems[2].Text;
           //     this.sPort = item.SubItems[3].Text;
           //     this.sDiaChiWeb = item.SubItems[4].Text;
           //     this.sSuDungWeb = item.SubItems[5].Text;
           //     this.sSerial = item.SubItems[6].Text;
           //     this.sTrangThaiMay = item.SubItems[11].Text;


            //   this.sTenMay = "Máy 1";

           //   this.sTrangThaiMay = "1";

            //    Application.DoEvents();


            //  string str;

            if (comboBox_MCCVL.SelectedIndex > -1)
            {
                DataTable dt = new DataTable();
                _mayChamCongDTO.TenMCC = comboBox_MCCVL.Text;
                dt = _mayChamCongBLL.MayChamCongGetAllByTenMCC(this._mayChamCongDTO);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.sMaMCC = dt.Rows[i]["MaMCC"].ToString();
                    this.sTrangThaiMay = dt.Rows[i]["Trangthaimay"].ToString();
                    this.sTenMay = dt.Rows[i]["TenMCC"].ToString();
                    //  sTenMay = sMaMCC;

                }

            }

            Application.DoEvents();
                if (this.comboBoxLuaChonTai.SelectedIndex == 0)
                {

                    if (IsDeviceConnected)
                    {
                        IsDeviceConnected = false;
                        this.Cursor = Cursors.Default;

                        return;
                    }
                    string ipAddress = tbxDeviceIP.Text.Trim();
                    string port = tbxPort.Text.Trim();
                    if (ipAddress == string.Empty || port == string.Empty)
                        throw new Exception("The Device IP Address and Port is mandotory !!");

                    int portNumber = 4372;
                    if (!int.TryParse(port, out portNumber))
                        throw new Exception("Not a valid port number");

                    //this.Cursor = Cursors.WaitCursor;
                    IsDeviceConnected = this.axCZKEM1.Connect_Net(ipAddress, portNumber);

               //    this.iMachineNumber = 4;
                    //this.axCZKEM1.RegEvent(this.iMachineNumber, 65535);
                    //this.Cursor = Cursors.WaitCursor;
                    //if (this.axCZKEM1.GetSerialNumber(this.iMachineNumber, out str))
                    //{
                    //    this.txtSerial.Text = str;
                    //}
                    //this.Cursor = Cursors.Default;



                    if (IsDeviceConnected)
                    {

                        {
                            MessageBox.Show("OK");
                        }
                    }



                if (this.axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref this._value)) // 1
                {
                    this.iSoDuLieu = this._value;
                }
                this.kiemTraLoaiMay();
                this.taiDuLieuVaoRa();
                this.Cursor = Cursors.Default;


            }



            if (this.comboBoxLuaChonTai.SelectedIndex == 1)
                {
                    MessageBox.Show("Chọn ng\x00e0y");
                }




            

        }

        private void comboBoxLuaChonTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxLuaChonTai.SelectedIndex == 0)
            {
                this.dateTimeTuNgay.Enabled = false;
                this.dateTimeDenNgay.Enabled = false;
            } 
            if (this.comboBoxLuaChonTai.SelectedIndex == 1)
            {
                this.dateTimeTuNgay.Enabled = true;
                this.dateTimeDenNgay.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            flag = !flag;
            if (flag)
            {
                for (int i = 0; i < this.listViewMayChamCong.Items.Count; i++)
                {
                    this.listViewMayChamCong.Items[i].Checked = flag;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = true;
            flag = !flag;
            if (!flag)
            {
                for (int i = 0; i < this.listViewMayChamCong.Items.Count; i++)
                {
                    this.listViewMayChamCong.Items[i].Checked = flag;
                }
            }
        }


       // CHBK2014_N9.ATT.Utilities.DeviceManipulator manipulator = new CHBK2014_N9.ATT.Utilities.DeviceManipulator();
      //  public CHBK2014_N9.ATT.Utilities.ZkemClient objZkeeper;
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
                    button1.Text = "Disconnect";
                    //     ToggleControls(true);
                }
                else
                {
                    ShowStatusBar("The device is diconnected !!", true);
                    axCZKEM1.Disconnect();
                    button1.Text = "Connect";
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
                        button1.Text = "Connect";
                        //   ToggleControls(false);
                        break;
                    }

                default:
                    break;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {

            this.DGVDuLieuVaoRa.Rows.Clear();

            if (this.comboBoxLuaChonTai.SelectedIndex == 0)
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

                    string ipAddress = tbxDeviceIP.Text.Trim();
                    string port = tbxPort.Text.Trim();
                    if (ipAddress == string.Empty || port == string.Empty)
                        throw new Exception("The Device IP Address and Port is mandotory !!");

                    int portNumber = 4370;
                    if (!int.TryParse(port, out portNumber))
                        throw new Exception("Not a valid port number");

                    bool isValidIpA = CHBK2014_N9.ATT.Utilities.UniversalStatic.ValidateIP(ipAddress);
                    if (!isValidIpA)
                        throw new Exception("The Device IP is invalid !!");

                    isValidIpA = CHBK2014_N9.ATT.Utilities.UniversalStatic.PingTheDevice(ipAddress);
                    if (!isValidIpA)
                        throw new Exception("The device at " + ipAddress + ":" + port + " did not respond!!");

                    axCZKEM2 = new CHBK2014_N9.ATT.Utilities.ZkemClient(RaiseDeviceEvent);
                    //  IsDeviceConnected = objZkeeper.Connect_Net(ipAddress, portNumber);
                    IsDeviceConnected = axCZKEM1.Connect_Net(ipAddress, portNumber);


                  
                 


             
             
           

                     if (this.axCZKEM1.GetDeviceStatus(1, 6, ref this._value))
                        {
                            this.iSoDuLieu = this._value;
                        }
                        this.kiemTraLoaiMay();
                        this.taiDuLieuVaoRa();
                        this.Cursor = Cursors.Default;



            

            if (this.comboBoxLuaChonTai.SelectedIndex == 1)
            {
                MessageBox.Show("Chọn ng\x00e0y");
            }



            }
            catch (Exception ex)
            {
                
            }
            this.Cursor = Cursors.Default;




                }
          

               
               
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void comboBox_MCCVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            _mayChamCongDTO.TenMCC = comboBox_MCCVL.Text;
            dt = _mayChamCongBLL.MayChamCongGetAllByTenMCC(this._mayChamCongDTO);

            for (int i =0; i <dt.Rows.Count; i++)
            {
                this.sMaMCC = dt.Rows[i]["MaMCC"].ToString();

            }
        }
    }
}
