using System.IO;

namespace StockEntity.Helper
{
    public class DBValidator
    {
        static string DBFileName = "StockDB.sqlite"; // same as in app.config file
        public static bool IsDBFileAvailable(string folderPath)
        {
            return File.Exists(Path.Combine(folderPath, DBFileName));
        }
    }
}
