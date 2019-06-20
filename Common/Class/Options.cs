using DevExpress.Utils;
using DevExpress.XtraEditors;
using CHBK2014_N9.Common;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace CHBK2014_N9.Common.Class
{
  public  class Options
    {

        private static XLoadingForm _LoadingForm;

        private static WaitDialogForm _mDlg;

        private static string _mFTitle;

        private static string _mCaption;

        public static string Caption
        {
            get
            {
                return Options._mCaption;
            }
            set
            {
                Options._mCaption = value;
            }
        }

        public static XLoadingForm FormLoading
        {
            get
            {
                return Options._LoadingForm;
            }
            set
            {
                Options._LoadingForm = value;
            }
        }

        public static string SoftId
        {
            get;
            set;
        }

        public static string Title
        {
            get
            {
                return Options._mFTitle;
            }
            set
            {
                Options._mFTitle = value;
            }
        }

        public static int TypeSoft
        {
            get;
            set;
        }

        static Options()
        {
            Options._LoadingForm = new XLoadingForm();
            Options._mFTitle = "Vui lòng đợi trong giây lát...";
            Options._mCaption = "Đang nạp dữ liệu ...";
            Options.SoftId = "QLNS";
            Options.TypeSoft = 0;
        }

        public Options()
        {
        }

        public static void Close()
        {
            Options.CloseDialog();
        }

        public static void CloseDialog()
        {
            if (Options._mDlg != null)
            {
                Options._mDlg.FormClosing += new FormClosingEventHandler(Options.dlg_FormClosing);
                Options._mDlg.Close();
            }
        }

        public static void CreateWaitDialog()
        {
            Options.CreateWaitDialog(Options.Caption);
        }

        public static void CreateWaitDialog(string fCaption)
        {
            Options.CreateWaitDialog(fCaption, Options.Title);
        }

        public static void CreateWaitDialog(string fCaption, string fTitle)
        {
            Options.Title = fTitle;
            if (Options._mDlg == null)
            {
                Options._mDlg = new WaitDialogForm(fCaption, fTitle);
            }
            Options._mDlg.AllowFormSkin = true;
        }

        private static void dlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Options._mDlg = null;
        }

        ~Options()
        {
            if (Options._mDlg != null)
            {
                Options._mDlg.FormClosing += new FormClosingEventHandler(Options.dlg_FormClosing);
                Options._mDlg.Close();
            }
        }

        public static void HideDialog()
        {
            if (Options._mDlg != null)
            {
                Options._mDlg.Hide();
            }
        }

        public static void SetWaitDialogCaption()
        {
            Options.SetWaitDialogCaption(Options.Caption);
        }

        public static void SetWaitDialogCaption(string fCaption)
        {
            Options.Caption = fCaption;
            if (Options._mDlg == null)
            {
                Options.CreateWaitDialog();
            }
            else
            {
                Options._mDlg.Visible = true;
                Options._mDlg.Caption = fCaption;
            }
        }

        public static void Show(string fCaption)
        {
            Options.SetWaitDialogCaption(fCaption);
        }

        public static void Show()
        {
            Options.SetWaitDialogCaption();
        }

        public class DateTime
        {
            private static string _mDateSaparator;

            private static string _mFormatDate;

            private static int _mDayLength;

            private static int _mMonthLength;

            private static int _mYearLength;

            private static Options.FormatType _mDateFormatType;

            public static int DayLength
            {
                get
                {
                    return Options.DateTime._mDayLength;
                }
                set
                {
                    Options.DateTime._mDayLength = value;
                }
            }

            public static string Format
            {
                get
                {
                    string day;
                    string month;
                    string year;
                    string str;
                    switch (Options.DateTime._mDateFormatType)
                    {
                        case Options.FormatType.Dmy:
                            {
                                day = Options.DateTime.GetDay(true);
                                month = Options.DateTime.GetMonth(true);
                                year = Options.DateTime.GetYear(false);
                                Options.DateTime._mFormatDate = (day.Length == 1 ? "" : string.Concat(day, (month.Length == 1 ? "" : month), year));
                                if (Options.DateTime._mFormatDate.Trim() == string.Empty)
                                {
                                    Options.DateTime._mFormatDate = "dd/MM/yyyy";
                                }
                                str = Options.DateTime._mFormatDate;
                                break;
                            }
                        case Options.FormatType.Mdy:
                            {
                                day = Options.DateTime.GetDay(true);
                                month = Options.DateTime.GetMonth(true);
                                year = Options.DateTime.GetYear(false);
                                Options.DateTime._mFormatDate = (month.Length == 1 ? "" : string.Concat(month, (day.Length == 1 ? "" : day), year));
                                if (Options.DateTime._mFormatDate.Trim() == string.Empty)
                                {
                                    Options.DateTime._mFormatDate = "MM/dd/yyyy";
                                }
                                str = Options.DateTime._mFormatDate;
                                break;
                            }
                        case Options.FormatType.Ymd:
                            {
                                day = Options.DateTime.GetDay(false);
                                month = Options.DateTime.GetMonth(true);
                                year = Options.DateTime.GetYear(true);
                                Options.DateTime._mFormatDate = (year.Length == 1 ? "" : string.Concat(year, (month.Length == 1 ? "" : month), day));
                                if (Options.DateTime._mFormatDate.Trim() == string.Empty)
                                {
                                    Options.DateTime._mFormatDate = "yyyy/MM/dd";
                                }
                                str = Options.DateTime._mFormatDate;
                                break;
                            }
                        default:
                            {
                                str = Options.DateTime._mFormatDate;
                                break;
                            }
                    }
                    return str;
                }
                set
                {
                    Options.DateTime._mDateFormatType = Options.FormatType.Custom;
                    Options.DateTime._mFormatDate = value;
                }
            }

            public static string FormatString
            {
                get
                {
                    return string.Concat("{0:", Options.DateTime.Format, "}");
                }
            }

            public static Options.FormatType FormatType
            {
                get
                {
                    return Options.DateTime._mDateFormatType;
                }
                set
                {
                    Options.DateTime._mDateFormatType = value;
                }
            }

            public static int MonthLength
            {
                get
                {
                    return Options.DateTime._mMonthLength;
                }
                set
                {
                    Options.DateTime._mMonthLength = value;
                }
            }

            public static string Saparator
            {
                get
                {
                    return Options.DateTime._mDateSaparator;
                }
                set
                {
                    Options.DateTime._mDateSaparator = value;
                }
            }

            public static int YearLength
            {
                get
                {
                    return Options.DateTime._mYearLength;
                }
                set
                {
                    Options.DateTime._mYearLength = value;
                }
            }

            static DateTime()
            {
                Options.DateTime._mDateSaparator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
                Options.DateTime._mFormatDate = "dd/MM/yyyy";
                Options.DateTime._mDayLength = 2;
                Options.DateTime._mMonthLength = 2;
                Options.DateTime._mYearLength = 4;
                Options.DateTime._mDateFormatType = Options.FormatType.Custom;
            }

            public DateTime()
            {
            }

            private static string GetDay(bool dateSaparator)
            {
                string str = "";
                for (int i = 0; i < Options.DateTime._mDayLength; i++)
                {
                    str = string.Concat(str, "d");
                }
                if (dateSaparator)
                {
                    str = string.Concat(str, Options.DateTime._mDateSaparator);
                }
                return str;
            }

            private static string GetMonth(bool dateSaparator)
            {
                string str = "";
                for (int i = 0; i < Options.DateTime._mMonthLength; i++)
                {
                    str = string.Concat(str, "M");
                }
                if (dateSaparator)
                {
                    str = string.Concat(str, Options.DateTime._mDateSaparator);
                }
                return str;
            }

            private static string GetYear(bool dateSaparator)
            {
                string str = "";
                for (int i = 0; i < Options.DateTime._mYearLength; i++)
                {
                    str = string.Concat(str, "y");
                }
                if (dateSaparator)
                {
                    str = string.Concat(str, Options.DateTime._mDateSaparator);
                }
                return str;
            }
        }

        public enum FormatType
        {
            Custom = 0,
            Dmy = 1,
            Mdy = 2,
            Ymd = 3
        }

        public class Number
        {
            private static string _mDecimalSymbol;

            private static string _mDigitGroupSymbol;

            private static int _mDecimals;

            private static string _mFrefixSymbol;

            private static string _mSuffixSymbol;

            private static string _mFormatNumber;

            private static bool _mAutoRound;

            public static bool AutoRound
            {
                get
                {
                    return Options.Number._mAutoRound;
                }
                set
                {
                    Options.Number._mAutoRound = value;
                }
            }

            public static int Decimals
            {
                get
                {
                    return Options.Number._mDecimals;
                }
                set
                {
                    Options.Number._mDecimals = value;
                }
            }

            public static string DecimalSymbol
            {
                get
                {
                    return Options.Number._mDecimalSymbol;
                }
                set
                {
                    Options.Number._mDecimalSymbol = value;
                }
            }

            public static string DigitGroupSymbol
            {
                get
                {
                    return Options.Number._mDigitGroupSymbol;
                }
                set
                {
                    Options.Number._mDigitGroupSymbol = value;
                }
            }

            public static string Format
            {
                get
                {
                    string str = "##,##0.";
                    for (int i = 0; i < Options.Number._mDecimals; i++)
                    {
                        str = string.Concat(str, (Options.Number._mAutoRound ? "#" : "0"));
                    }
                    Options.Number._mFormatNumber = string.Concat(Options.Number._mFrefixSymbol, str, Options.Number._mSuffixSymbol);
                    return Options.Number._mFormatNumber;
                }
                set
                {
                    Options.Number._mFormatNumber = value;
                }
            }

            public static string FormatString
            {
                get
                {
                    return string.Concat("{0:", Options.Number.Format, "}");
                }
            }

            public static string FrefixSymbol
            {
                get
                {
                    return Options.Number._mFrefixSymbol;
                }
                set
                {
                    Options.Number._mFrefixSymbol = value;
                }
            }

            public static string SuffixSymbol
            {
                get
                {
                    return Options.Number._mSuffixSymbol;
                }
                set
                {
                    Options.Number._mSuffixSymbol = value;
                }
            }

            static Number()
            {
                Options.Number._mDecimalSymbol = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                Options.Number._mDigitGroupSymbol = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator;
                Options.Number._mDecimals = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalDigits;
                Options.Number._mFrefixSymbol = "";
                Options.Number._mSuffixSymbol = "";
                Options.Number._mFormatNumber = "##,##0.###";
                Options.Number._mAutoRound = true;
            }

            public Number()
            {
            }
        }

        public class Parameter
        {
            private static string _mManager;

            public static string Manager
            {
                get
                {
                    return Options.Parameter._mManager;
                }
                set
                {
                    Options.Parameter._mManager = value;
                }
            }

            static Parameter()
            {
                Options.Parameter._mManager = "Giám đốc";
            }

            public Parameter()
            {
            }
        }

        public class Regional
        {
            private static bool _mIsQuestion;

            private static string _mDecimalSymbol;

            private static bool _mIsMsgBoxResult;

            private static string _mDigitGroupSymbol;

            private static int _mDecimals;

            private static string _mDateSaparator;

            private static string _mFormatDate;

            private static Options.FormatType _mDateFormatType;

            private static string _mFormatNumber;

            private static int _mNumberDecimalDigits;

            public static Options.FormatType DateFormatType
            {
                get
                {
                    return Options.Regional._mDateFormatType;
                }
                set
                {
                    Options.Regional._mDateFormatType = value;
                }
            }

            public static string DateSaparator
            {
                get
                {
                    return Options.Regional._mDateSaparator;
                }
                set
                {
                    Options.Regional._mDateSaparator = value;
                }
            }

            public static int Decimals
            {
                get
                {
                    return Options.Regional._mDecimals;
                }
                set
                {
                    Options.Regional._mDecimals = value;
                }
            }

            public static string DecimalSymbol
            {
                get
                {
                    return Options.Regional._mDecimalSymbol;
                }
                set
                {
                    Options.Regional._mDecimalSymbol = value;
                }
            }

            public static string DigitGroupSymbol
            {
                get
                {
                    return Options.Regional._mDigitGroupSymbol;
                }
                set
                {
                    Options.Regional._mDigitGroupSymbol = value;
                }
            }

            public static string FormatDate
            {
                get
                {
                    string str;
                    switch (Options.Regional._mDateFormatType)
                    {
                        case Options.FormatType.Dmy:
                            {
                                Options.Regional._mFormatDate = Options.FormatType.Dmy.ToString().Replace("/", Options.Regional._mDateSaparator);
                                str = Options.Regional._mFormatDate;
                                break;
                            }
                        case Options.FormatType.Mdy:
                            {
                                Options.Regional._mFormatDate = Options.FormatType.Mdy.ToString().Replace("/", Options.Regional._mDateSaparator);
                                str = Options.Regional._mFormatDate;
                                break;
                            }
                        case Options.FormatType.Ymd:
                            {
                                Options.Regional._mFormatDate = Options.FormatType.Ymd.ToString().Replace("/", Options.Regional._mDateSaparator);
                                str = Options.Regional._mFormatDate;
                                break;
                            }
                        default:
                            {
                                str = Options.Regional._mFormatDate;
                                break;
                            }
                    }
                    return str;
                }
                set
                {
                    Options.Regional._mDateFormatType = Options.FormatType.Custom;
                    Options.Regional._mFormatDate = value;
                }
            }

            public static string FormatNumber
            {
                get
                {
                    string str = "##,##0.";
                    for (int i = 0; i < Options.Regional._mDecimals; i++)
                    {
                        str = string.Concat(str, "#");
                    }
                    Options.Regional._mFormatNumber = str;
                    return str;
                }
                set
                {
                    Options.Regional._mFormatNumber = value;
                }
            }

            public static bool IsMsgBoxResult
            {
                get
                {
                    return Options.Regional._mIsMsgBoxResult;
                }
                set
                {
                    Options.Regional._mIsMsgBoxResult = value;
                }
            }

            public static bool IsQuestion
            {
                get
                {
                    return Options.Regional._mIsQuestion;
                }
                set
                {
                    Options.Regional._mIsQuestion = value;
                }
            }

            public static int NumberDecimalDigits
            {
                get
                {
                    return Options.Regional._mNumberDecimalDigits;
                }
                set
                {
                    Options.Regional._mNumberDecimalDigits = value;
                }
            }

            public static string StringFormat
            {
                get
                {
                    return string.Concat("{0:", Options.Regional.FormatNumber, "}");
                }
            }

            static Regional()
            {
                Options.Regional._mIsQuestion = true;
                Options.Regional._mDecimalSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                Options.Regional._mIsMsgBoxResult = true;
                Options.Regional._mDigitGroupSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
                Options.Regional._mDecimals = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalDigits;
                Options.Regional._mDateSaparator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
                Options.Regional._mFormatDate = "dd/MM/yyyy";
                Options.Regional._mDateFormatType = Options.FormatType.Custom;
                Options.Regional._mFormatNumber = "##,##0.###";
                Options.Regional._mNumberDecimalDigits = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalDigits;
            }

            public Regional()
            {
            }
        }

        public class System2
        {
            private static bool _mIsQuestion;

            private static bool _mIsMsgBoxResult;

            private static bool _mIsMsgBoxError;

            public static bool IsMsgBoxError
            {
                get
                {
                    return Options.System2._mIsMsgBoxError;
                }
                set
                {
                    Options.System2._mIsMsgBoxError = value;
                }
            }

            public static bool IsMsgBoxResult
            {
                get
                {
                    return Options.System2._mIsMsgBoxResult;
                }
                set
                {
                    Options.System2._mIsMsgBoxResult = value;
                }
            }

            public static bool IsQuestion
            {
                get
                {
                    return Options.System2._mIsQuestion;
                }
                set
                {
                    Options.System2._mIsQuestion = value;
                }
            }

            static System2()
            {
                Options.System2._mIsQuestion = true;
                Options.System2._mIsMsgBoxResult = true;
                Options.System2._mIsMsgBoxError = true;
            }

            public System2()
            {
            }
        }

    }
}
