using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace CHBK2014_N9.Class
{
    class RegistryWriter
    {

        public bool WriteKey(string key, string value)
        {
            try
            {
                RegistryKey rekey = Registry.CurrentUser.CreateSubKey("nhansu");
                if (rekey == null)
                {
                    return false;
                }
                else
                {
                    rekey.SetValue(key, value);

                }
                rekey.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string valuekey(string key)
        {
            try
            {
                RegistryKey rekey = Registry.CurrentUser.CreateSubKey("nhansu");
                if (rekey == null)
                {
                    return "Blue";
                }
                else
                {
                    string _key = rekey.GetValue(key).ToString();
                    rekey.Close();
                    return _key;
                }
            }
            catch { return "Blue"; }
        }
          
    }
}
