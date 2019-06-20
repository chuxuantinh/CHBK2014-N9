using System;
using System.Runtime.CompilerServices;

namespace CHBK2014_N9.Common.Enviroment
{
  public  class NetworkInfo
    {


        private NetConnectionStatus _mStatus;

        public string AdapterType
        {
            get;
            set;
        }

        public string ConnectionID
        {
            get;
            set;
        }

        public string DefaultGateway
        {
            get;
            set;
        }

        public string DeviceName
        {
            get;
            set;
        }

        public string Ip
        {
            get;
            set;
        }

        public string IpWan
        {
            get;
            set;
        }

        public string MacAddress
        {
            get;
            set;
        }

        public string Mask
        {
            get;
            set;
        }

        public NetConnectionStatus Status
        {
            get
            {
                return this._mStatus;
            }
            set
            {
                this._mStatus = value;
            }
        }

        public NetworkInfo()
        {
        }

        public string GetHelp()
        {
            string str;
            if (this._mStatus == NetConnectionStatus.Connected)
            {
                str = "Connect succeed.";
            }
            else if (this._mStatus == NetConnectionStatus.Disconnected)
            {
                str = "Your connection was disable, please check Network Setting in Console.";
            }
            else if (this._mStatus != NetConnectionStatus.MediaDisconnected)
            {
                str = (this._mStatus != NetConnectionStatus.InvalidAddress ? string.Format("NetConnectionStatus is {0}", this._mStatus) : "IP address is Invalid, please check DHCP/Router or IP setting.");
            }
            else
            {
                str = "Cable had bad contact with Network Card! Please check it.";
            }
            return str;
        }
    }
}
