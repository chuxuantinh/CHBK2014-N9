using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using Microsoft.Win32;

using System.Xml;

using System.Xml.XPath;

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;



namespace CHBK2014_N9.Common.Enviroment
{
   public static class NetworkManager
    {

        private static Dictionary<string, NetworkInfo> _mInformations;

        private static NetworkInfo _networkInfo;

        public static NetworkInfo NetworkInfo
        {
            get
            {
                return NetworkManager._networkInfo;
            }
        }

        public static void Extract()
        {
            NetworkInfo ipWan = null;
            if (NetworkManager._mInformations.Count > 0)
            {
                foreach (NetworkInfo value in NetworkManager._mInformations.Values)
                {
                    if (value.Status != NetConnectionStatus.Connected)
                    {
                        ipWan = value;
                    }
                    else
                    {
                        ipWan = value;
                        break;
                    }
                }
            }
            if (ipWan == null)
            {
                NetworkInfo networkInfo = new NetworkInfo()
                {
                    DeviceName = "",
                    MacAddress = "",
                    AdapterType = "",
                    Ip = "0.0.0.0",
                    IpWan = "0.0.0.0",
                    Mask = "0.0.0.0",
                    DefaultGateway = "0.0.0.0",
                    ConnectionID = ""
                };
                ipWan = networkInfo;
            }
            ipWan.IpWan = NetworkManager.GetIpWan();
            NetworkManager._networkInfo = ipWan;
        }

        private static string GetIpWan()
        {
            string str;
            try
            {
                WebRequest defaultCredentials = WebRequest.Create("http://checkip.dyndns.org/");
                defaultCredentials.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)defaultCredentials.GetResponse();
                Console.WriteLine(response.StatusDescription);
                Stream responseStream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                string end = streamReader.ReadToEnd();
                int num = end.IndexOf(":");
                end = end.Remove(0, num + 1);
                end = end.Remove(end.LastIndexOf("</body>"), 14);
                streamReader.Close();
                responseStream.Close();
                response.Close();
                str = end.Trim();
            }
            catch (Exception exception)
            {
                str = "0.0.0.0";
            }
            return str;
        }

        private static string ParseProperty(object data)
        {
            string str;
            str = (data == null ? "" : data.ToString());
            return str;
        }

        //public static void ReadSysInfo()
        //{
        //    NetworkInfo networkInfo;
        //    NetworkManager._mInformations = new Dictionary<string, NetworkInfo>();
        //    try
        //    {
        //        foreach (ManagementObject managementObject in (new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionID IS NOT NULL")).Get())
        //        {
        //            networkInfo = null;
        //            try
        //            {
        //                NetworkInfo networkInfo1 = new NetworkInfo()
        //                {
        //                    DeviceName = NetworkManager.ParseProperty(managementObject["Description"]),
        //                    AdapterType = NetworkManager.ParseProperty(managementObject["AdapterType"]),
        //                    MacAddress = NetworkManager.ParseProperty(managementObject["MACAddress"]),
        //                    ConnectionID = NetworkManager.ParseProperty(managementObject["NetConnectionID"]),
        //                    Status = (NetConnectionStatus)Convert.ToInt32(managementObject["NetConnectionStatus"])
        //                };
        //                networkInfo = networkInfo1;
        //            }
        //            catch
        //            {
        //                networkInfo = null;
        //            }
        //            if (networkInfo != null)
        //            {
        //                NetworkManager.SetIp(networkInfo);
        //                NetworkManager._mInformations.Add(networkInfo.ConnectionID, networkInfo);
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        NetworkInfo networkInfo2 = new NetworkInfo()
        //        {
        //            DeviceName = "",
        //            MacAddress = "",
        //            AdapterType = "",
        //            Ip = "0.0.0.0",
        //            IpWan = "0.0.0.0",
        //            Mask = "0.0.0.0",
        //            DefaultGateway = "0.0.0.0",
        //            ConnectionID = ""
        //        };
        //        networkInfo = networkInfo2;
        //        NetworkManager._mInformations.Add(networkInfo.ConnectionID, networkInfo);
        //    }
        //}

        //private static void SetIp(NetworkInfo info)
        //{
        //    foreach (ManagementObject instance in (new ManagementClass("Win32_NetworkAdapterConfiguration")).GetInstances())
        //    {
        //        try
        //        {
        //            if (info.Status != NetConnectionStatus.Connected)
        //            {
        //                info.Ip = "0.0.0.0";
        //                info.Mask = "0.0.0.0";
        //                info.DefaultGateway = "0.0.0.0";
        //            }
        //            if (!(bool)instance["ipEnabled"])
        //            {
        //                continue;
        //            }
        //            else if (instance["MACAddress"].ToString().Equals(info.MacAddress))
        //            {
        //                info.Ip = ((string[])instance["IPAddress"])[0];
        //                info.Mask = ((string[])instance["IPSubnet"])[0];
        //                info.DefaultGateway = ((string[])instance["DefaultIPGateway"])[0];
        //                break;
        //            }
        //        }
        //        catch (Exception exception)
        //        {
        //            Debug.WriteLine(string.Concat("[SetIP]:", exception.Message));
        //        }
        //    }
        //}

    }
}
