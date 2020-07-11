using System;

namespace StockEntity.Helper
{
    public class DateHelper
    {
        public static string DATE_FORMAT = "yyyy-MM-dd HH:mm:ss";
        public static string DATE_FORMAT_SORTABLE = "yyyyMMddhhmmssfff";
        public static DateTime GetDateObject(string yyyy_MM_dd_HH_mm_ss)
        {
            return DateTime.ParseExact(yyyy_MM_dd_HH_mm_ss, DATE_FORMAT, null);
        }

        public static string GetDateString(DateTime date)
        {
            return date.ToString(DATE_FORMAT);
        }

        public static string GetTodayDateString()
        {
            return DateTime.Now.ToString(DATE_FORMAT);
        }

        public static DateTime GetDateNowObject()
        {
            return DateTime.Now;
        }

        public static string GetDateNowString_Sortable()
        {
            return DateTime.Now.ToString("yyyyMMddhhmmssfff");
        }

        public static DateTime GetDateObject_Sortable(string yyyyMMddhhmmssfff)
        {
            return DateTime.ParseExact(yyyyMMddhhmmssfff, "yyyyMMddhhmmssfff", null);
        }
    }
}
