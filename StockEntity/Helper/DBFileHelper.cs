﻿using System;
using System.IO;

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
                    string destFilePath = DateHelper.GetTodayDateString_yyyyMMddHHmmss() + "_" + DBFileName;
                    destFilePath = Path.Combine(destDirPath, destFilePath);
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
                if (dirInfo.GetFiles().Length > 30) // if no backup in last 30 days then keep minimum 300 files in the folder, date doesn't matter
                {
                    foreach (FileInfo fileInfo in dirInfo.GetFiles())
                    {
                        try
                        {
                            if (fileInfo.Exists)
                            {
                                string datePart = fileInfo.Name.Substring(0, fileInfo.Name.IndexOf("_"));
                                DateTime fileBackupDate = DateHelper.GetDateObject_yyyyMMddHHmmss(datePart);
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
            }
            catch (Exception ex)
            {
            }
        }
    }
}
