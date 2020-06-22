using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEntity.Helper
{
    public class DateHelper
    {
        public static DateTime GetDateObject(string yyyy_MM_dd)
        {
            return DateTime.ParseExact(yyyy_MM_dd, "yyyy-MM-dd", null);
        }

        public static string GetDateString(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static DateTime GetTodayDateObject()
        {
            return DateTime.Today;
        }

        public static string GetTodayDateString()
        {
            return DateTime.Today.ToString("yyyy-MM-dd");
        }
    }
}
