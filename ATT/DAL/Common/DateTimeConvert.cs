using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DAL.Common
{
  internal  class DateTimeConvert
    {
        public static string FormatVN(DateTime dateTime)
        {
            return Convert.ToDateTime(dateTime.ToString().Replace("N/A", "00/00/0000").Trim()).ToString("dd/MM/yyyy");
        }

        public static string FormatVN(string dateTime)
        {
            string str = dateTime;
            return Convert.ToDateTime(str.Replace("N/A", "00/00/0000 00:00:00").Trim()).ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static string FormatVN(DateTime dateTime, string Format)
        {
            return Convert.ToDateTime(dateTime.ToString().Replace("N/A", "00/00/0000").Trim()).ToString(Format);
        }
    }
}
