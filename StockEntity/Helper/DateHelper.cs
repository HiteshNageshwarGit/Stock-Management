using System;

namespace StockEntity.Helper
{
    public class DateHelper
    {
       public static string DATE_FORMAT = "yyyy-MM-dd HH:mm:ss";
        public static DateTime GetDateObject(string yyyy_MM_dd_HH_mm_ss)
        {
            return DateTime.ParseExact(yyyy_MM_dd_HH_mm_ss, DATE_FORMAT, null);
        }

        public static string GetDateString(DateTime date)
        {
            return date.ToString(DATE_FORMAT);
        }

        public static DateTime GetTodayDateObject()
        {
            return DateTime.Now;
        }

        public static string GetTodayDateString()
        {
            return DateTime.Now.ToString(DATE_FORMAT);
        }

        public static string GetTodayDateString_yyyyMMddHHmmss()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public static DateTime GetDateObject_yyyyMMddHHmmss(string yyyyMMddHHmmss)
        {
            return DateTime.ParseExact(yyyyMMddHHmmss, "yyyyMMddHHmmss", null);
        }
    }
}
