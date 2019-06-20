using DevExpress.Utils;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CHBK2014_N9.Common.Class
{
    public class ClsOption
    {

        private static WaitDialogForm _dlg;

        public ClsOption()
        {
        }

        public static void CreateWaitDialog()
        {
            if (ClsOption._dlg == null)
            {
                ClsOption._dlg = new WaitDialogForm("Đang nạp dữ liệu ...", "Vui lòng đợi trong giây lát...");
            }
        }

        private static void dlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClsOption._dlg = null;
        }

        public static void DoHide()
        {
            if (ClsOption._dlg != null)
            {
                ClsOption._dlg.FormClosing += new FormClosingEventHandler(ClsOption.dlg_FormClosing);
                ClsOption._dlg.Close();
            }
        }

        ~ClsOption()
        {
            if (ClsOption._dlg != null)
            {
                ClsOption._dlg.FormClosing += new FormClosingEventHandler(ClsOption.dlg_FormClosing);
                ClsOption._dlg.Close();
            }
        }

        public static void SetWaitDialogCaption(string fCaption)
        {
            if (ClsOption._dlg == null)
            {
                ClsOption._dlg = new WaitDialogForm(fCaption, "Vui lòng đợi trong giây lát...");
            }
            else
            {
                ClsOption._dlg.Caption = fCaption;
            }
        }

        public class DateTime
        {
            private static string _mDateSaparator;

            private static string _mFormatDate;

            private static int _mDayLength;

            private static int _mMonthLength;

            private static int _mYearLength;

            private static ClsOption.FormatType _mDateFormatType;

            public static int DayLength
            {
                get
                {
                    return ClsOption.DateTime._mDayLength;
                }
                set
                {
                    ClsOption.DateTime._mDayLength = value;
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
                    switch (ClsOption.DateTime._mDateFormatType)
                    {
                        case ClsOption.FormatType.Dmy:
                            {
                                day = ClsOption.DateTime.GetDay(true);
                                month = ClsOption.DateTime.GetMonth(true);
                                year = ClsOption.DateTime.GetYear(false);
                                ClsOption.DateTime._mFormatDate = (day.Length == 1 ? "" : string.Concat(day, (month.Length == 1 ? "" : month), year));
                                if (ClsOption.DateTime._mFormatDate.Trim() == string.Empty)
                                {
                                    ClsOption.DateTime._mFormatDate = "dd/MM/yyyy";
                                }
                                str = ClsOption.DateTime._mFormatDate;
                                break;
                            }
                        case ClsOption.FormatType.Mdy:
                            {
                                day = ClsOption.DateTime.GetDay(true);
                                month = ClsOption.DateTime.GetMonth(true);
                                year = ClsOption.DateTime.GetYear(false);
                                ClsOption.DateTime._mFormatDate = (month.Length == 1 ? "" : string.Concat(month, (day.Length == 1 ? "" : day), year));
                                if (ClsOption.DateTime._mFormatDate.Trim() == string.Empty)
                                {
                                    ClsOption.DateTime._mFormatDate = "MM/dd/yyyy";
                                }
                                str = ClsOption.DateTime._mFormatDate;
                                break;
                            }
                        case ClsOption.FormatType.Ymd:
                            {
                                day = ClsOption.DateTime.GetDay(false);
                                month = ClsOption.DateTime.GetMonth(true);
                                year = ClsOption.DateTime.GetYear(true);
                                ClsOption.DateTime._mFormatDate = (year.Length == 1 ? "" : string.Concat(year, (month.Length == 1 ? "" : month), day));
                                if (ClsOption.DateTime._mFormatDate.Trim() == string.Empty)
                                {
                                    ClsOption.DateTime._mFormatDate = "yyyy/MM/dd";
                                }
                                str = ClsOption.DateTime._mFormatDate;
                                break;
                            }
                        default:
                            {
                                str = ClsOption.DateTime._mFormatDate;
                                break;
                            }
                    }
                    return str;
                }
                set
                {
                    ClsOption.DateTime._mDateFormatType = ClsOption.FormatType.Custom;
                    ClsOption.DateTime._mFormatDate = value;
                }
            }

            public static string FormatString
            {
                get
                {
                    return string.Concat("{0:", ClsOption.DateTime.Format, "}");
                }
            }

            public static ClsOption.FormatType FormatType
            {
                get
                {
                    return ClsOption.DateTime._mDateFormatType;
                }
                set
                {
                    ClsOption.DateTime._mDateFormatType = value;
                }
            }

            public static int MonthLength
            {
                get
                {
                    return ClsOption.DateTime._mMonthLength;
                }
                set
                {
                    ClsOption.DateTime._mMonthLength = value;
                }
            }

            public static string Saparator
            {
                get
                {
                    return ClsOption.DateTime._mDateSaparator;
                }
                set
                {
                    ClsOption.DateTime._mDateSaparator = value;
                }
            }

            public static int YearLength
            {
                get
                {
                    return ClsOption.DateTime._mYearLength;
                }
                set
                {
                    ClsOption.DateTime._mYearLength = value;
                }
            }

            static DateTime()
            {
                ClsOption.DateTime._mDateSaparator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
                ClsOption.DateTime._mFormatDate = "dd/MM/yyyy";
                ClsOption.DateTime._mDayLength = 2;
                ClsOption.DateTime._mMonthLength = 2;
                ClsOption.DateTime._mYearLength = 4;
                ClsOption.DateTime._mDateFormatType = ClsOption.FormatType.Custom;
            }

            public DateTime()
            {
            }

            private static string GetDay(bool dateSaparator)
            {
                string str = "";
                for (int i = 0; i < ClsOption.DateTime._mDayLength; i++)
                {
                    str = string.Concat(str, "d");
                }
                if (dateSaparator)
                {
                    str = string.Concat(str, ClsOption.DateTime._mDateSaparator);
                }
                return str;
            }

            private static string GetMonth(bool dateSaparator)
            {
                string str = "";
                for (int i = 0; i < ClsOption.DateTime._mMonthLength; i++)
                {
                    str = string.Concat(str, "M");
                }
                if (dateSaparator)
                {
                    str = string.Concat(str, ClsOption.DateTime._mDateSaparator);
                }
                return str;
            }

            private static string GetYear(bool dateSaparator)
            {
                string str = "";
                for (int i = 0; i < ClsOption.DateTime._mYearLength; i++)
                {
                    str = string.Concat(str, "y");
                }
                if (dateSaparator)
                {
                    str = string.Concat(str, ClsOption.DateTime._mDateSaparator);
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

            public static int Decimals
            {
                get
                {
                    return ClsOption.Number._mDecimals;
                }
                set
                {
                    ClsOption.Number._mDecimals = value;
                }
            }

            public static string DecimalSymbol
            {
                get
                {
                    return ClsOption.Number._mDecimalSymbol;
                }
                set
                {
                    ClsOption.Number._mDecimalSymbol = value;
                }
            }

            public static string DigitGroupSymbol
            {
                get
                {
                    return ClsOption.Number._mDigitGroupSymbol;
                }
                set
                {
                    ClsOption.Number._mDigitGroupSymbol = value;
                }
            }

            private static string Format
            {
                get
                {
                    string str = "##,##0.";
                    for (int i = 0; i < ClsOption.Number._mDecimals; i++)
                    {
                        str = string.Concat(str, "#");
                    }
                    ClsOption.Number._mFormatNumber = string.Concat(ClsOption.Number._mFrefixSymbol, str, ClsOption.Number._mSuffixSymbol);
                    return ClsOption.Number._mFormatNumber;
                }
                set
                {
                    ClsOption.Number._mFormatNumber = value;
                }
            }

            public static string FormatString
            {
                get
                {
                    return string.Concat("{0:", ClsOption.Number.Format, "}");
                }
            }

            public static string FrefixSymbol
            {
                get
                {
                    return ClsOption.Number._mFrefixSymbol;
                }
                set
                {
                    ClsOption.Number._mFrefixSymbol = value;
                }
            }

            public static string PercentFormatString
            {
                get
                {
                    return string.Concat("{0:", ClsOption.Number.Format, "} %");
                }
            }

            public static string SuffixSymbol
            {
                get
                {
                    return ClsOption.Number._mSuffixSymbol;
                }
                set
                {
                    ClsOption.Number._mSuffixSymbol = value;
                }
            }

            static Number()
            {
                ClsOption.Number._mDecimalSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                ClsOption.Number._mDigitGroupSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
                ClsOption.Number._mDecimals = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalDigits;
                ClsOption.Number._mFrefixSymbol = "";
                ClsOption.Number._mSuffixSymbol = "";
                ClsOption.Number._mFormatNumber = "##,##0.###";
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
                    return ClsOption.Parameter._mManager;
                }
                set
                {
                    ClsOption.Parameter._mManager = value;
                }
            }

            static Parameter()
            {
                ClsOption.Parameter._mManager = "Giám đốc";
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

            private static ClsOption.FormatType _mDateFormatType;

            private static string _mFormatNumber;

            public static ClsOption.FormatType DateFormatType
            {
                get
                {
                    return ClsOption.Regional._mDateFormatType;
                }
                set
                {
                    ClsOption.Regional._mDateFormatType = value;
                }
            }

            public static string DateSaparator
            {
                get
                {
                    return ClsOption.Regional._mDateSaparator;
                }
                set
                {
                    ClsOption.Regional._mDateSaparator = value;
                }
            }

            public static int Decimals
            {
                get
                {
                    return ClsOption.Regional._mDecimals;
                }
                set
                {
                    ClsOption.Regional._mDecimals = value;
                }
            }

            public static string DecimalSymbol
            {
                get
                {
                    return ClsOption.Regional._mDecimalSymbol;
                }
                set
                {
                    ClsOption.Regional._mDecimalSymbol = value;
                }
            }

            public static string DigitGroupSymbol
            {
                get
                {
                    return ClsOption.Regional._mDigitGroupSymbol;
                }
                set
                {
                    ClsOption.Regional._mDigitGroupSymbol = value;
                }
            }

            public static string FormatDate
            {
                get
                {
                    string str;
                    switch (ClsOption.Regional._mDateFormatType)
                    {
                        case ClsOption.FormatType.Dmy:
                            {
                                ClsOption.Regional._mFormatDate = ClsOption.FormatType.Dmy.ToString().Replace("/", ClsOption.Regional._mDateSaparator);
                                str = ClsOption.Regional._mFormatDate;
                                break;
                            }
                        case ClsOption.FormatType.Mdy:
                            {
                                ClsOption.Regional._mFormatDate = ClsOption.FormatType.Mdy.ToString().Replace("/", ClsOption.Regional._mDateSaparator);
                                str = ClsOption.Regional._mFormatDate;
                                break;
                            }
                        case ClsOption.FormatType.Ymd:
                            {
                                ClsOption.Regional._mFormatDate = ClsOption.FormatType.Ymd.ToString().Replace("/", ClsOption.Regional._mDateSaparator);
                                str = ClsOption.Regional._mFormatDate;
                                break;
                            }
                        default:
                            {
                                str = ClsOption.Regional._mFormatDate;
                                break;
                            }
                    }
                    return str;
                }
                set
                {
                    ClsOption.Regional._mDateFormatType = ClsOption.FormatType.Custom;
                    ClsOption.Regional._mFormatDate = value;
                }
            }

            public static string FormatNumber
            {
                get
                {
                    string str = "##,##0.";
                    for (int i = 0; i < ClsOption.Regional._mDecimals; i++)
                    {
                        str = string.Concat(str, "#");
                    }
                    ClsOption.Regional._mFormatNumber = str;
                    return str;
                }
                set
                {
                    ClsOption.Regional._mFormatNumber = value;
                }
            }

            public static bool IsMsgBoxResult
            {
                get
                {
                    return ClsOption.Regional._mIsMsgBoxResult;
                }
                set
                {
                    ClsOption.Regional._mIsMsgBoxResult = value;
                }
            }

            public static bool IsQuestion
            {
                get
                {
                    return ClsOption.Regional._mIsQuestion;
                }
                set
                {
                    ClsOption.Regional._mIsQuestion = value;
                }
            }

            public static string StringFormat
            {
                get
                {
                    return string.Concat("{0:", ClsOption.Regional.FormatNumber, "}");
                }
            }

            static Regional()
            {
                ClsOption.Regional._mIsQuestion = true;
                ClsOption.Regional._mDecimalSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                ClsOption.Regional._mIsMsgBoxResult = true;
                ClsOption.Regional._mDigitGroupSymbol = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
                ClsOption.Regional._mDecimals = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalDigits;
                ClsOption.Regional._mDateSaparator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
                ClsOption.Regional._mFormatDate = "dd/MM/yyyy";
                ClsOption.Regional._mDateFormatType = ClsOption.FormatType.Custom;
                ClsOption.Regional._mFormatNumber = "##,##0.###";
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
                    return ClsOption.System2._mIsMsgBoxError;
                }
                set
                {
                    ClsOption.System2._mIsMsgBoxError = value;
                }
            }

            public static bool IsMsgBoxResult
            {
                get
                {
                    return ClsOption.System2._mIsMsgBoxResult;
                }
                set
                {
                    ClsOption.System2._mIsMsgBoxResult = value;
                }
            }

            public static bool IsQuestion
            {
                get
                {
                    return ClsOption.System2._mIsQuestion;
                }
                set
                {
                    ClsOption.System2._mIsQuestion = value;
                }
            }

            static System2()
            {
                ClsOption.System2._mIsQuestion = true;
                ClsOption.System2._mIsMsgBoxResult = true;
                ClsOption.System2._mIsMsgBoxError = true;
            }

            public System2()
            {
            }

        }
    }
}
