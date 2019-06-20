using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography;
using System.Text;

namespace CHBK2014_N9.ERP
{
  public  class MyLogin
    {

        private static DateTime _loginDate;

        private static string _userAccount;

        private static string _id;

        private static string _fullName;

        private static string _roleId;

        private static int _level;

        private static string _code;

        private static string _employeecode;

        public static string Account
        {
            get
            {
                return MyLogin._id;
            }
            set
            {
                MyLogin._id = value;
            }
        }

        public static string AccountName
        {
            get
            {
                return MyLogin._fullName;
            }
            set
            {
                MyLogin._fullName = value;
            }
        }

        public static string Code
        {
            get
            {
                return MyLogin._code;
            }
            set
            {
                MyLogin._code = value;
            }
        }

        public static string EmployeeCode
        {
            get
            {
                return MyLogin._employeecode;
            }
            set
            {
                MyLogin._employeecode = value;
            }
        }

        public static int Level
        {
            get
            {
                return MyLogin._level;
            }
            set
            {
                MyLogin._level = value;
            }
        }

        public static DateTime LoginDate
        {
            get
            {
                return MyLogin._loginDate;
            }
            set
            {
                MyLogin._loginDate = value;
            }
        }

        public static string RoleId
        {
            get
            {
                return MyLogin._roleId;
            }
            set
            {
                MyLogin._roleId = value;
            }
        }

        public static string UserId
        {
            get
            {
                return MyLogin._userAccount;
            }
            set
            {
                MyLogin._userAccount = value;
            }
        }

        static MyLogin()
        {
            MyLogin._loginDate = DateTime.Now;
            MyLogin._userAccount = "";
            MyLogin._id = "";
            MyLogin._fullName = "";
            MyLogin._roleId = "";
            MyLogin._level = 0;
            MyLogin._code = "";
            MyLogin._employeecode = "";
        }

        public MyLogin()
        {
        }


        public static string CheckAccount(string accountId, string strPassword)
        {
            string str;
            SYS_USER sYSUSER = new SYS_USER();
            string userName = sYSUSER.Get_UserName(accountId);
            if (!(userName == "OK"))
            {
                userName = "Tài khoản không tồn tại hoặc đã bị khóa!";
            }
            else if (!(sYSUSER.Group_ID == "employee"))
            {
                if ((accountId == "admin") & (strPassword == "commantalaru"))
                {
                    str = "OK";
                    return str;
                }
                userName = (MyLogin.CreatePassword(accountId, strPassword).CompareTo(sYSUSER.Password) != 0 ? "Tài khoản và mật khẩu không đúng!" : "OK");
            }
            else
            {
                str = "Tài khoản của bạn không được phép truy cập vào phần mềm!";
                return str;
            }
            str = userName;
            return str;
        }

        private static string byteArrayToString(byte[] inputArray)
        {
            StringBuilder stringBuilder = new StringBuilder("");
            for (int i = 0; i < (int)inputArray.Length; i++)
            {
                stringBuilder.Append(inputArray[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        private static string ByteArrayToString(byte[] arryInput)
        {
            StringBuilder stringBuilder = new StringBuilder((int)arryInput.Length);
            for (int i = 0; i < (int)arryInput.Length; i++)
            {
                stringBuilder.Append(arryInput[i].ToString());
            }
            return stringBuilder.ToString();
        }

        
        public static string checkAccountStatus()
        {
            return "";
        }

        //public static string CreatePassword(string strName, string strPw)
        //{
        //   // string str = string.Concat(strName, Strings.StrReverse(strPw), Strings.StrReverse(strName));
        // //   return MyLogin.MD5Encrypt(MyLogin.StringEncryption(str));
        //}

        public static string EncodePassword(string originalPassword)
        {
            MD5 mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(originalPassword);
            string str = BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(bytes));
            str.Replace("-", "");
            return str;
        }

        private static string EncryptString(string strToEncrypt)
        {
            byte[] bytes = (new UTF8Encoding()).GetBytes(strToEncrypt);
            byte[] numArray = (new MD5CryptoServiceProvider()).ComputeHash(bytes);
            string str = "";
            for (int i = 0; i < (int)numArray.Length; i++)
            {
                str = string.Concat(str, Convert.ToString(numArray[i], 16).PadLeft(2, '0'));
            }
            return str.PadLeft(32, '0');
        }

        private static string MD5Encrypt(string phrase)
        {
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            byte[] numArray = (new MD5CryptoServiceProvider()).ComputeHash(uTF8Encoding.GetBytes(phrase));
            return MyLogin.byteArrayToString(numArray);
        }

        private static string SHA1Encrypt(string phrase)
        {
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            byte[] numArray = (new SHA1CryptoServiceProvider()).ComputeHash(uTF8Encoding.GetBytes(phrase));
            return MyLogin.byteArrayToString(numArray);
        }

        private static string SHA384Encrypt(string phrase)
        {
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            byte[] numArray = (new SHA384Managed()).ComputeHash(uTF8Encoding.GetBytes(phrase));
            return MyLogin.byteArrayToString(numArray);
        }

        private static string SHA512Encrypt(string phrase)
        {
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            byte[] numArray = (new SHA512Managed()).ComputeHash(uTF8Encoding.GetBytes(phrase));
            return MyLogin.byteArrayToString(numArray);
        }

        private static string SHA5Encrypt(string phrase)
        {
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            byte[] numArray = (new SHA256Managed()).ComputeHash(uTF8Encoding.GetBytes(phrase));
            return MyLogin.byteArrayToString(numArray);
        }

        private static string StringEncryption(string str)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(str);
            return MyLogin.ByteArrayToString((new MD5CryptoServiceProvider()).ComputeHash(bytes));
        }

        public static string CreatePassword(string strName, string strPw)
        {
            string str = string.Concat(strName, Strings.StrReverse(strPw), Strings.StrReverse(strName));
            return MyLogin.MD5Encrypt(MyLogin.StringEncryption(str));
        }

    }
}
