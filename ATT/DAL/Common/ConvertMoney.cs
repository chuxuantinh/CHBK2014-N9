using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DAL.Common
{
   internal class ConvertMoney
    {
        public string BoKhoangTrang(string Chuoi)
        {
            Chuoi = Chuoi.Replace(" ", "");
            return Chuoi;
        }

        public string chendau(string so)
        {
            for (int i = so.Length - 3; i >= 0; i -= 3)
            {
                so = so.Insert(i, ",");
            }
            if (so.Substring(0, 1) == ",")
            {
                so = so.Remove(0, 1);
            }
            return so;
        }

        private string doc1so(string so)
        {
            string[] strArray = new string[] { "kh\x00f4ng ", "một ", "hai ", "ba ", "bốn ", "năm ", "s\x00e1u ", "bảy ", "t\x00e1m ", "ch\x00edn " };
            return strArray[int.Parse(so)];
        }

        private string doc3so(string so)
        {
            string str = null;
            if (so.Length == 1)
            {
                str = this.doc1so(so);
            }
            if (so.Length == 2)
            {
                string str3 = so.Substring(0, 1);
                if (str3 == null)
                {
                    goto Label_00F4;
                }
                if (!(str3 == "0"))
                {
                    if (str3 == "1")
                    {
                        if (so.Substring(so.Length - 1, 1) == "0")
                        {
                            str = "mười ";
                        }
                        else
                        {
                            str = "mười " + this.doc1so(so.Substring(so.Length - 1, 1));
                        }
                        goto Label_0160;
                    }
                    goto Label_00F4;
                }
                if (so.Substring(so.Length - 1, 1) != "0")
                {
                    str = "Lẻ " + this.doc1so(so.Substring(so.Length - 1, 1));
                }
                else
                {
                    str = "";
                }
            }
            goto Label_0160;
        Label_00F4:
            if (so.Substring(so.Length - 1, 1) != "0")
            {
                str = this.doc1so(so.Substring(0, 1)) + "mươi " + this.doc1so(so.Substring(so.Length - 1, 1));
            }
            else
            {
                str = this.doc1so(so.Substring(0, 1)) + "mươi ";
            }
        Label_0160:
            if (so.Length != 3)
            {
                return str;
            }
            if (so == "000")
            {
                return "";
            }
            return (this.doc1so(so.Substring(0, 1)) + "trăm " + this.doc3so(so.Substring(so.Length - 2, 2)));
        }

        public string docso(string so)
        {
            int index = 0;
            int num2 = 0;
            string str = null;
            string[] strArray = new string[] { "", "ng\x00e0n ", "triệu ", "tỷ " };
            for (int i = so.Length - 3; i >= -2; i -= 3)
            {
                if (index == 4)
                {
                    index = 1;
                }
                if (i >= 0)
                {
                    if (this.doc3so(so.Substring(i, 3)) != "")
                    {
                        str = this.doc3so(so.Substring(i, 3)) + strArray[index] + str;
                    }
                    else if (index == 3)
                    {
                        str = "tỷ " + str;
                    }
                }
                else
                {
                    str = this.doc3so(so.Substring(0, so.Length - (3 * num2))) + strArray[index] + str;
                }
                index++;
                num2++;
            }
            return str.Replace("mươi một", "mươi mốt");
        }

        public string loaidau(string chuoi)
        {
            chuoi = chuoi.Replace(",", "");
            return chuoi;
        }
    }
}
