using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zkemkeeper;

namespace CHBK2014_N9.HumanResource.Core.Machine
{
    public partial class xucMachineItem : xucBase
    {
        private string m_MachineCode;

        private string m_MachineName;

        private int m_MachineNumber;

        private bool m_IsConnected;

        private string m_IP;

        private string m_Port;

        private int m_Password;

        public CZKEMClass axCZKEM;

        private bool m_IsRegister;

        public string IP
        {
            get
            {
                return this.m_IP;
            }
            set
            {
                this.m_IP = value;
            }
        }

        public bool IsConnected
        {
            get
            {
                return this.m_IsConnected;
            }
            set
            {
                this.m_IsConnected = value;
            }
        }

        public string MachineCode
        {
            get
            {
                return this.m_MachineCode;
            }
            set
            {
                this.m_MachineCode = value;
            }
        }

        public string MachineName
        {
            get
            {
                return this.m_MachineName;
            }
            set
            {
                this.m_MachineName = value;
            }
        }

        public int MachineNumber
        {
            get
            {
                return this.m_MachineNumber;
            }
            set
            {
                this.m_MachineNumber = this.MachineNumber;
            }
        }

        public int Password
        {
            get
            {
                return this.m_Password;
            }
            set
            {
                this.m_Password = value;
            }
        }

        public string Port
        {
            get
            {
                return this.m_Port;
            }
            set
            {
                this.m_Port = value;
            }
        }

        public xucMachineItem()
        {
            this.InitializeComponent();
            this.m_MachineCode = "";
            this.m_MachineName = "";
            this.m_IsConnected = false;
            this.m_IP = "";
            this.m_Port = "";
            this.m_MachineNumber = 1;
            this.m_Password = 0;
            this.RegisterLibrary();
            this.LoadInterface(true);
        }

        public xucMachineItem(string MachineCode, string MachineName, string IP, string Port, int Password)
        {
            this.InitializeComponent();
            this.m_MachineCode = MachineCode;
            this.m_MachineName = MachineName;
            this.m_IsConnected = false;
            this.m_IP = IP;
            this.m_Port = Port;
            this.m_MachineNumber = 1;
            this.m_Password = Password;
            this.RegisterLibrary();
            this.LoadInterface(true);
        }

        private void axCZKEM_OnAttTransaction(int EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second)
        {
            object[] year = new object[] { Year, "/", Month, "/", Day };
            DateTime dateTime = Convert.ToDateTime(string.Concat(year));
            DateTime date = dateTime.Date;
            year = new object[] { Day, "/", Month, "/", Year, " ", Hour, ":", Minute, ":", Second };
            DateTime dateTime1 = Convert.ToDateTime(string.Concat(year));
            (new HRM_EMPLOYEE()).GetByEnroll(EnrollNumber.ToString());
            this.RaiseOnTransactionEventHandler(EnrollNumber.ToString(), date, dateTime1, AttState, this.m_MachineNumber);
        }

        private void bbiConnect_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Connect();
        }

        private void bbiDeleteAllData_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.m_IsConnected)
            {
                int num = 0;
                this.axCZKEM.EnableDevice(this.m_MachineNumber, false);
                if (XtraMessageBox.Show("Bạn có chắc xóa hết dữ liệu chấm công trong thiết bị không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!this.axCZKEM.ClearGLog(this.m_MachineNumber))
                    {
                        this.axCZKEM.GetLastError(ref num);
                        XtraMessageBox.Show(string.Concat("Lỗi thực thi,ErrorCode=", num.ToString()), "Thông Báo");
                    }
                    else
                    {
                        this.axCZKEM.RefreshData(this.m_MachineNumber);
                        XtraMessageBox.Show("Tất cả dữ liệu trên máy đã được xóa!", "Thông Báo");
                    }
                    this.axCZKEM.EnableDevice(this.m_MachineNumber, true);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng kết nối với thiết bị trước", "Thông Báo");
            }
        }

        private void bbiDisConnect_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DisConnect();
        }

        private void bbiProperty_ItemClick(object sender, ItemClickEventArgs e)
        {
            xfmMachineInformation _xfmMachineInformation = new xfmMachineInformation(this.axCZKEM, this.m_MachineName, this.m_IP, this.m_MachineNumber);
            _xfmMachineInformation.RestartDevice += new xfmMachineInformation.RestartDeviceEventHander((object s) => this.DisConnect());
            _xfmMachineInformation.PowerOffDevice += new xfmMachineInformation.PowerOffDeviceEventHander((object s) => this.DisConnect());
            _xfmMachineInformation.ShowDialog();
        }

        private void bbiSignUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.m_IsConnected)
            {
                (new xfmReg(this.axCZKEM)).ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng kết nối với thiết bị trước", "Thông Báo");
            }
        }

        public void Connect()
        {
            if (!this.m_IsRegister)
            {
                XtraMessageBox.Show("Chưa đăng ký thư viện chấm công!", "Thông Báo");
            }
            else if ((this.m_IP == "" ? false : !(this.m_Port == "")))
            {
                try
                {
                    base.SetWaitDialogCaption(string.Concat("Đang kết nối đến máy...", this.m_IP));
                    if (this.m_Password != 0)
                    {
                        this.axCZKEM.SetCommPassword(this.m_Password);
                    }
                    this.m_IsConnected = this.axCZKEM.Connect_Net(this.m_IP, int.Parse(this.m_Port));
                }
                catch
                {
                    this.m_IsConnected = false;
                }
                if (!this.m_IsConnected)
                {
                    this.DoHide();
                    string[] mMachineName = new string[] { "Không thể kết nối với ", this.m_MachineName, " (địa chỉ ip: ", this.m_IP, ")" };
                    this.RaiseConnectErrorEventHander(string.Concat(mMachineName));
                }
                else
                {
                    this.DoHide();
                    this.RaiseConnectCompleteEventHander();
                    if (!this.axCZKEM.RegEvent(this.m_MachineNumber, 65535))
                    {
                        XtraMessageBox.Show("Lỗi kết nối thời gian thực với thiết bị!", "Thông Báo");
                    }
                    else
                    {
                        this.axCZKEM.OnAttTransaction += new _IZKEMEvents_OnAttTransactionEventHandler(this.axCZKEM_OnAttTransaction);
                    }
                    this.axCZKEM.EnableDevice(this.m_MachineNumber, true);
                }
                this.LoadInterface(false);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn thiết bị kết nối hoặc kiểm tra lại các thông số của thiết bị!", "Lỗi");
            }
        }


        private void Control_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
        }

        public int Count()
        {
            int num;
            int num1 = 0;
            this.axCZKEM.EnableDevice(this.m_MachineNumber, false);
            num = (!this.axCZKEM.GetDeviceStatus(this.m_MachineNumber, 6, ref num1) ? num1 : num1);
            return num;
        }

        public void DisConnect()
        {
            try
            {
                this.axCZKEM.Disconnect();
                this.m_IsConnected = false;
            }
            catch
            {
                this.m_IsConnected = false;
            }
            this.LoadInterface(false);
            this.RaiseDisConnectCompleteEventHander();
        }


        public void GetGeneralLogData(bool FilterByDay, DateTime FromDate, DateTime ToDate)
        {
            DateTime dateTime;
            DateTime dateTime1;
            object[] objArray;
            int num = 0;
            int num1 = 0;
            string str = "";
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            int num10 = 0;
            int num11 = 0;
            int num12 = 0;
            this.Cursor = Cursors.WaitCursor;
            Options.SetWaitDialogCaption(string.Concat("Đang đọc dữ liệu từ ", this.m_MachineName));
            Options.SetWaitDialogCaption(string.Concat("Đang đọc dữ liệu từ ", this.m_MachineName));
            if (this.axCZKEM.ReadGeneralLogData(this.m_MachineNumber))
            {
                Options.SetWaitDialogCaption(string.Concat("Đang tải dữ liệu từ ", this.m_MachineName));
                if (!this.axCZKEM.IsTFTMachine(this.m_MachineNumber))
                {
                    while (this.axCZKEM.GetGeneralLogData(this.m_MachineNumber, ref num, ref num1, ref num2, ref num3, ref num4, ref num5, ref num6, ref num7, ref num8, ref num9))
                    {
                        num12++;
                        objArray = new object[] { num5, "/", num6, "/", num7 };
                        dateTime = Convert.ToDateTime(string.Concat(objArray));
                        objArray = new object[] { num5, "/", num6, "/", num7, " ", num8, ":", num9 };
                        dateTime1 = Convert.ToDateTime(string.Concat(objArray));
                        if (!FilterByDay)
                        {
                            this.RaiseAddRowEventHandler(num1.ToString(), dateTime, dateTime1, num4, this.m_MachineNumber);
                        }
                        else if ((dateTime < FromDate.Date ? false : dateTime <= ToDate.Date))
                        {
                            this.RaiseAddRowEventHandler(num1.ToString(), dateTime, dateTime1, num4, this.m_MachineNumber);
                        }
                    }
                }
                else
                {
                    while (this.axCZKEM.SSR_GetGeneralLogData(this.m_MachineNumber, out str, out num3, out num4, out num5, out num6, out num7, out num8, out num9, out num10, ref num11))
                    {
                        num12++;
                        objArray = new object[] { num5, "/", num6, "/", num7 };
                        dateTime = Convert.ToDateTime(string.Concat(objArray));
                        objArray = new object[] { num5, "/", num6, "/", num7, " ", num8, ":", num9 };
                        dateTime1 = Convert.ToDateTime(string.Concat(objArray));
                        if (!FilterByDay)
                        {
                            this.RaiseAddRowEventHandler(str, dateTime, dateTime1, num4, this.m_MachineNumber);
                        }
                        else if ((dateTime < FromDate.Date ? false : dateTime <= ToDate.Date))
                        {
                            this.RaiseAddRowEventHandler(str, dateTime, dateTime1, num4, this.m_MachineNumber);
                        }
                    }
                }
            }
            this.axCZKEM.EnableDevice(this.m_MachineNumber, true);
            Options.HideDialog();
            this.Cursor = Cursors.Default;
        }


        public void LoadInterface(bool IsInit)
        {
            string[] mMachineName;
            if (!this.m_IsConnected)
            {
                this.bbiConnect.Enabled = true;
                this.bbiDisConnect.Enabled = false;
                this.bbiDeleteAllData.Enabled = false;
                this.bbiSignUp.Enabled = false;
                this.bbiProperty.Enabled = false;
                if (!IsInit)
                {
                    LabelControl labelControl = this.lbMachineName;
                    mMachineName = new string[] { "<b>", this.m_MachineName, " (Đã ngắt kết nối)</b>", Environment.NewLine, this.m_IP, "/", this.m_Port };
                    labelControl.Text = string.Concat(mMachineName);
                }
                else
                {
                    LabelControl labelControl1 = this.lbMachineName;
                    mMachineName = new string[] { "<b>", this.m_MachineName, " (Chưa kết nối)</b>", Environment.NewLine, this.m_IP, "/", this.m_Port };
                    labelControl1.Text = string.Concat(mMachineName);
                }
                this.lbMachineName.ForeColor = Color.Red;
                this.lbMachineName.Refresh();
                this.ptIcon.BackColor = Color.MistyRose;
                this.ptIcon.Refresh();
            }
            else
            {
                this.bbiConnect.Enabled = false;
                this.bbiDisConnect.Enabled = true;
                this.bbiDeleteAllData.Enabled = true;
                this.bbiSignUp.Enabled = true;
                this.bbiProperty.Enabled = true;
                this.lbMachineName.ForeColor = Color.Green;
                LabelControl labelControl2 = this.lbMachineName;
                mMachineName = new string[] { "<b>", this.m_MachineName, " (Đã kết nối)</b>", Environment.NewLine, this.m_IP, "/", this.m_Port };
                labelControl2.Text = string.Concat(mMachineName);
                this.lbMachineName.Refresh();
                this.ptIcon.BackColor = Color.GreenYellow;
                this.ptIcon.Refresh();
            }
        }

        private void panelControl1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panelControl1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void RaiseAddRowEventHandler(string EnrollNumber, DateTime Date, DateTime Hour, int StateInOut, int MachineID)
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.GetByEnroll(EnrollNumber.ToString());
            if (this.AddRowEvent != null)
            {
                this.AddRowEvent(this, EnrollNumber, hRMEMPLOYEE.EmployeeCode, string.Concat(hRMEMPLOYEE.FirstName, " ", hRMEMPLOYEE.LastName), Date, Hour, StateInOut, MachineID);
            }
        }

        private void RaiseConnectCompleteEventHander()
        {
            if (this.ConnectComplete != null)
            {
                this.ConnectComplete(this);
            }
        }

        private void RaiseConnectErrorEventHander(string Message)
        {
            if (this.ConnectError != null)
            {
                this.ConnectError(this, Message);
            }
        }

        private void RaiseConnectProcessEventHander(string Message)
        {
            if (this.ConnectProcess != null)
            {
                this.ConnectProcess(this, Message);
            }
        }

        private void RaiseDisConnectCompleteEventHander()
        {
            if (this.DisConnectComplete != null)
            {
                this.DisConnectComplete(this);
            }
        }

        private void RaiseDisConnectErrorEventHander(string Message)
        {
            if (this.DisConnectError != null)
            {
                this.DisConnectError(this, Message);
            }
        }

        private void RaiseDisConnectProcessEventHander(string Message)
        {
            if (this.DisConnectProcess != null)
            {
                this.DisConnectProcess(this, Message);
            }
        }

        private void RaiseOnTransactionEventHandler(string EnrollNumber, DateTime Date, DateTime Hour, int StateInOut, int MachineID)
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.GetByEnroll(EnrollNumber.ToString());
            if (this.OnTransactionEvent != null)
            {
                this.OnTransactionEvent(this, EnrollNumber, hRMEMPLOYEE.EmployeeCode, string.Concat(hRMEMPLOYEE.FirstName, " ", hRMEMPLOYEE.LastName), Date, Hour, StateInOut, MachineID);
            }
        }

        private void RegisterLibrary()
        {
            this.m_IsRegister = false;
            try
            {
                this.axCZKEM = new CZKEMClass();
                this.m_IsRegister = true;
            }
            catch
            {
                this.m_IsRegister = false;
            }
        }

        private void xucMachineItem_Click(object sender, EventArgs e)
        {
            this.ppMenu.ShowPopup(Control.MousePosition);
        }

        private void xucMachineItem_MouseEnter(object sender, EventArgs e)
        {
        }

        private void xucMachineItem_MouseLeave(object sender, EventArgs e)
        {
        }

        public event xucMachineItem.AddRowEventHandler AddRowEvent;

        public event xucMachineItem.ConnectCompleteEventHander ConnectComplete;

        public event xucMachineItem.ConnectErrorEventHander ConnectError;

        public event xucMachineItem.ConnectProcessEventHander ConnectProcess;

        public event xucMachineItem.DisConnectCompleteEventHander DisConnectComplete;

        public event xucMachineItem.DisConnectErrorEventHander DisConnectError;

        public event xucMachineItem.DisConnectProcessEventHander DisConnectProcess;

        public event xucMachineItem.OnTransactionEventHandler OnTransactionEvent;

        public delegate void AddRowEventHandler(object sender, string EnrollNumber, string EmployeeCode, string EmployeeName, DateTime Date, DateTime Hour, int StateInOut, int MachineID);

        public delegate void ConnectCompleteEventHander(object sender);

        public delegate void ConnectErrorEventHander(object sender, string Message);

        public delegate void ConnectProcessEventHander(object sender, string Message);

        public delegate void DisConnectCompleteEventHander(object sender);

        public delegate void DisConnectErrorEventHander(object sender, string Message);

        public delegate void DisConnectProcessEventHander(object sender, string Message);

        public delegate void OnTransactionEventHandler(object sender, string EnrollNumber, string EmployeeCode, string EmployeeName, DateTime Date, DateTime Hour, int StateInOut, int MachineID);
    }
}
