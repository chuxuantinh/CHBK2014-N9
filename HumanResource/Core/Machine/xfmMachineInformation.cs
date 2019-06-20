using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraTab;
//using CHBK2014_N9.Service.Class;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zkemkeeper;
namespace CHBK2014_N9.HumanResource.Core.Machine
{
    public partial class xfmMachineInformation : XtraForm
    {

        private CZKEMClass axCZKEM;

        private int m_MachineNumber;
        public xfmMachineInformation()
        {
            InitializeComponent();
        }

        public xfmMachineInformation(CZKEMClass czkemClass, string MachineName, string IP, int MachineNumber)
        {
            this.InitializeComponent();
            this.Text = string.Concat("Thông Tin Thiết Bị - ", MachineName);
            this.txtDeviceIP.Text = IP;
            this.m_MachineNumber = MachineNumber;
            this.axCZKEM = czkemClass;
            this.GetInformation();
        }

        private void btGetDeviceTime_Click(object sender, EventArgs e)
        {
            int num = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            this.Cursor = Cursors.WaitCursor;
            if (!this.axCZKEM.GetDeviceTime(this.m_MachineNumber, ref num1, ref num2, ref num3, ref num4, ref num5, ref num6))
            {
                this.axCZKEM.GetLastError(ref num);
                MessageBox.Show(string.Concat("Operation failed,ErrorCode=", num.ToString()), "Error");
            }
            else
            {
                TextEdit textEdit = this.txtGetDeviceTime;
                string[] str = new string[] { num1.ToString(), "-", num2.ToString(), "-", num3.ToString(), " ", num4.ToString(), ":", num5.ToString(), ":", num6.ToString() };
                textEdit.Text = string.Concat(str);
            }
            this.Cursor = Cursors.Default;
        }

        private void btPowerOff_Click(object sender, EventArgs e)
        {
          //  if (this.IsLicense())
           // {
                this.Cursor = Cursors.WaitCursor;
                if (this.axCZKEM.PowerOffDevice(this.m_MachineNumber))
                {
                    MessageBox.Show("Thiết bị sẽ bị tắt!", "Thông Báo");
                }
                this.RaisePowerOffDeiceEventHander();
                this.Cursor = Cursors.Default;
                base.Close();
           // }
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
           // if (this.IsLicense())
          //  {
                this.Cursor = Cursors.WaitCursor;
                if (this.axCZKEM.RestartDevice(this.m_MachineNumber))
                {
                    MessageBox.Show("Thiết bị sẽ được khởi động lại!", "Thông Báo");
                }
                this.RaiseRestartDeviceEventHander();
                this.Cursor = Cursors.Default;
                base.Close();
          //  }
        }

        private void btSetDeviceTime_Click(object sender, EventArgs e)
        {
            int num = 0;
            int year = this.dtSetDeviceTime.DateTime.Year;
            int month = this.dtSetDeviceTime.DateTime.Month;
            int day = this.dtSetDeviceTime.DateTime.Day;
            int hour = this.dtSetDeviceTime.DateTime.Hour;
            int minute = this.dtSetDeviceTime.DateTime.Minute;
            int second = this.dtSetDeviceTime.DateTime.Second;
            this.Cursor = Cursors.WaitCursor;
            if (!this.axCZKEM.SetDeviceTime2(this.m_MachineNumber, year, month, day, hour, minute, second))
            {
                this.axCZKEM.GetLastError(ref num);
                MessageBox.Show(string.Concat("Operation failed,ErrorCode=", num.ToString()), "Error");
            }
            else
            {
                this.axCZKEM.RefreshData(this.m_MachineNumber);
                MessageBox.Show("Successfully set the time of the machine as you have set!", "Error");
            }
            this.Cursor = Cursors.Default;
        }


        private void GetInformation()
        {
            this.dtSetDeviceTime.DateTime = DateTime.Now;
            if (!this.axCZKEM.IsTFTMachine(this.m_MachineNumber))
            {
                this.txtIsTFTMachine.Text = "No";
            }
            else
            {
                this.txtIsTFTMachine.Text = "Yes";
            }
            int num = 1;
            string str = "";
            if (!this.axCZKEM.GetDeviceStrInfo(this.m_MachineNumber, num, out str))
            {
                this.txtDeviceInfo.Text = "";
            }
            else
            {
                this.txtDeviceInfo.Text = str;
            }
            string str1 = "~PIN2Width";
            str = "";
            if (!this.axCZKEM.GetSysOption(this.m_MachineNumber, str1, out str))
            {
                this.txtSysOption.Text = "";
            }
            else
            {
                this.txtSysOption.Text = str;
            }
            str = "";
            if (!this.axCZKEM.GetDeviceMAC(this.m_MachineNumber, ref str))
            {
                this.txtDeviceMAC.Text = "";
            }
            else
            {
                this.txtDeviceMAC.Text = str;
            }
            str = "";
            if (!this.axCZKEM.GetFirmwareVersion(this.m_MachineNumber, ref str))
            {
                this.txtFirmwareVersion.Text = "";
            }
            else
            {
                this.txtFirmwareVersion.Text = str;
            }
            str = "";
            if (!this.axCZKEM.GetProductCode(this.m_MachineNumber, out str))
            {
                this.txtProductCode.Text = "";
            }
            else
            {
                this.txtProductCode.Text = str;
            }
            str = "";
            if (!this.axCZKEM.GetPlatform(this.m_MachineNumber, ref str))
            {
                this.txtPlatform.Text = "";
            }
            else
            {
                this.txtPlatform.Text = str;
            }
            int num1 = 0;
            if (!this.axCZKEM.GetCardFun(this.m_MachineNumber, ref num1))
            {
                this.txtCardFun.Text = "";
            }
            else
            {
                this.txtCardFun.Text = num1.ToString();
            }
            str = "";
            if (!this.axCZKEM.GetSerialNumber(this.m_MachineNumber, out str))
            {
                this.txtSerialNumber.Text = "";
            }
            else
            {
                this.txtSerialNumber.Text = str;
            }
            str = "";
            if (!this.axCZKEM.GetSDKVersion(ref str))
            {
                this.txtSDKVersion.Text = "";
            }
            else
            {
                this.txtSDKVersion.Text = str;
            }
            int num2 = 0;
            if (!this.axCZKEM.QueryState(ref num2))
            {
                this.txtQueryState.Text = "";
            }
            else
            {
                this.txtQueryState.Text = num2.ToString();
            }
        }

        //private bool IsLicense()
        //{
        //    bool flag;
        //    CODE cODE = new CODE();
        //    cODE.CheckLicense();
        //    cODE.Execute();
        //    if ((CODE.TypeSoft == 0 ? false : CODE.TypeSoft != 1))
        //    {
        //        flag = true;
        //    }
        //    else
        //    {
        //        XtraMessageBox.Show("Vui lòng nhập mã đăng ký phần mềm để thực hiện chức năng này!", "Thông Báo");
        //        flag = false;
        //    }
        //    return flag;
        //}

        private void RaisePowerOffDeiceEventHander()
        {
            if (this.PowerOffDevice != null)
            {
                this.PowerOffDevice(this);
            }
        }

        private void RaiseRestartDeviceEventHander()
        {
            if (this.RestartDevice != null)
            {
                this.RestartDevice(this);
            }
        }

        private void xfmMachineInformation_Load(object sender, EventArgs e)
        {
        }

        public event xfmMachineInformation.PowerOffDeviceEventHander PowerOffDevice;

        public event xfmMachineInformation.RestartDeviceEventHander RestartDevice;

        public delegate void PowerOffDeviceEventHander(object sender);

        public delegate void RestartDeviceEventHander(object sender);
    }
}
