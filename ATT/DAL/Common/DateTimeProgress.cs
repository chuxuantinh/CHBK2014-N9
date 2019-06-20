using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHBK2014_N9.ATT.DAL.Common
{
 internal   class DateTimeProgress
    {

        public static string NhanCaTheoTuan(int _nhanCaTheoTuan)
        {
            switch (_nhanCaTheoTuan)
            {
                case 0:
                    return "0";

                case 1:
                    return "1";

                case 2:
                    return "2";

                case 3:
                    return "3";

                case 4:
                    return "4";

                case 5:
                    return "5";

                case 6:
                    return "6";
            }
            return "Kh\x00f4ng x\x00e1c định được";
        }

        public static string Test(int test)
        {
            switch (test)
            {
                case 0:
                    return "0";

                case 1:
                    return "1";

                case 2:
                    return "2";

                case 3:
                    return "3";

                case 4:
                    return "4";

                case 5:
                    return "5";

                case 6:
                    return "6";
            }
            return "Kh\x00f4ng x\x00e1c định được";
        }

        public static string XuatIDThu(int IDthu)
        {
            switch (IDthu)
            {
                case 0:
                    return "0";

                case 1:
                    return "1";

                case 2:
                    return "2";

                case 3:
                    return "3";

                case 4:
                    return "4";

                case 5:
                    return "5";

                case 6:
                    return "6";
            }
            return "Kh\x00f4ng x\x00e1c định được";
        }

        public static string XuatThangEnglish(int iXuatThangEnglish)
        {
            switch (iXuatThangEnglish)
            {
                case 1:
                    return "January";

                case 2:
                    return "February";

                case 3:
                    return "March";

                case 4:
                    return "April";

                case 5:
                    return "May";

                case 6:
                    return "June";

                case 7:
                    return "July";

                case 8:
                    return "August";

                case 9:
                    return "September";

                case 10:
                    return "October";

                case 11:
                    return "November";

                case 12:
                    return "December";
            }
            return "Kh\x00f4ng x\x00e1c định";
        }

        public static string XuatThu(int thu)
        {
            switch (thu)
            {
                case 0:
                    return "Chủ nhật";

                case 1:
                    return "Thứ hai";

                case 2:
                    return "Thứ ba";

                case 3:
                    return "Thứ tư";

                case 4:
                    return "Thứ năm";

                case 5:
                    return "Thứ s\x00e1u";

                case 6:
                    return "Thứ bảy";
            }
            return "Kh\x00f4ng x\x00e1c định được";
        }

        public static string XuatThuChinese(int thuChinese)
        {
            switch (thuChinese)
            {
                case 0:
                    return "星期日";

                case 1:
                    return "第二";

                case 2:
                    return "星期二";

                case 3:
                    return "星期三";

                case 4:
                    return "星期四";

                case 5:
                    return "星期五";

                case 6:
                    return "星期六";
            }
            return "未知";
        }

        public static string XuatThuEnglish(int thuEnglish)
        {
            switch (thuEnglish)
            {
                case 0:
                    return "Sunday";

                case 1:
                    return "Monday";

                case 2:
                    return "Tuesday";

                case 3:
                    return "Wednesday";

                case 4:
                    return "Thursday";

                case 5:
                    return "Friday";

                case 6:
                    return "Saturday";
            }
            return "Unknow";
        }

        public static string XuatThuJapan(int thuJapan)
        {
            switch (thuJapan)
            {
                case 0:
                    return "日曜日";

                case 1:
                    return "月曜日";

                case 2:
                    return "火曜日";

                case 3:
                    return "水曜日";

                case 4:
                    return "木曜日";

                case 5:
                    return "金曜日";

                case 6:
                    return "土曜日";
            }
            return "不明";
        }

        public static string XuatThuKorea(int thuKorea)
        {
            switch (thuKorea)
            {
                case 0:
                    return "일요일";

                case 1:
                    return "월요일";

                case 2:
                    return "화요일";

                case 3:
                    return "수요일";

                case 4:
                    return "목요일";

                case 5:
                    return "금요일";

                case 6:
                    return "토요일";
            }
            return "Kh\x00f4ng x\x00e1c định được";
        }

        public static string XuatThuQuaDem(int thuQuaDem)
        {
            switch (thuQuaDem)
            {
                case 0:
                    return "Thứ bảy";

                case 1:
                    return "Chủ nhật";

                case 2:
                    return "Thứ hai";

                case 3:
                    return "Thứ ba";

                case 4:
                    return "Thứ tư";

                case 5:
                    return "Thứ năm";

                case 6:
                    return "Thứ s\x00e1u";
            }
            return "Kh\x00f4ng x\x00e1c định được";
        }

        public static string XuatThuReport(int iXuatThuReport)
        {
            switch (iXuatThuReport)
            {
                case 0:
                    return "CN";

                case 1:
                    return "T.2";

                case 2:
                    return "T.3";

                case 3:
                    return "T.4";

                case 4:
                    return "T.5";

                case 5:
                    return "T.6";

                case 6:
                    return "T.7";
            }
            return "Kh\x00f4ng x\x00e1c định";
        }

        public static string XuatThuTinhCong(int thuTinhCong)
        {
            switch (thuTinhCong)
            {
                case 0:
                    return "CN";

                case 1:
                    return "Hai";

                case 2:
                    return "Ba";

                case 3:
                    return "Tư";

                case 4:
                    return "Năm";

                case 5:
                    return "Sáu";

                case 6:
                    return "Bảy";
            }
            return "Không xác định";
        }
    }
}
