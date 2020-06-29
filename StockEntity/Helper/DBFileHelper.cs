using System;
using System.IO;
using System.Runtime.InteropServices;

namespace StockEntity.Helper
{
    public class DBFileHelper
    {
        static string DBFileName = "StockDB.sqlite"; // same as in app.config file
        public static bool IsDBFileAvailable(string folderPath)
        {
            return File.Exists(Path.Combine(folderPath, DBFileName));
        }

        public static bool BackupDBFile(string dbDirPath, string destDirPath)
        {
            // Backup DB file once everyday
            try
            {
                if (!Directory.Exists(destDirPath))
                {
                    Directory.CreateDirectory(destDirPath);
                }

                string sourceFilePath = Path.Combine(dbDirPath, DBFileName);
                if (File.Exists(sourceFilePath))
                {
                    string destFilePath = DateHelper.GetTodayDateString() + "_" + DBFileName;
                    destFilePath = Path.Combine(destDirPath, destFilePath.Replace(':', '_'));
                    File.Copy(sourceFilePath, destFilePath);
                    if (File.Exists(destFilePath))
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            { }
            return false;
        }

        public static void DeleteOldBackupFiles(string destDirPath)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(destDirPath);
                foreach (FileInfo fileInfo in dirInfo.GetFiles())
                {
                    try
                    {
                        if (fileInfo.Exists)
                        {
                            string datePart = fileInfo.Name.Substring(0, fileInfo.Name.IndexOf("_"));
                            datePart = datePart.Replace('_', ':');
                            DateTime fileBackupDate = DateHelper.GetDateObject(datePart);
                            DateTime todaysDate = DateHelper.GetTodayDateObject();
                            if ((todaysDate - fileBackupDate).TotalDays > 31)
                            {

                                File.Delete(fileInfo.FullName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
