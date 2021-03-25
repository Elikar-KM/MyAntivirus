using System.IO;
using System.IO.Compression;
using System;

namespace AntiLib
{
    public static class SearchFile
    {
        public static void SearchFileDirectory(Object state)
        {
            object[] array = state as object[];
            var path = Convert.ToString(array[0]);
            DateValue.Operation oper = (DateValue.Operation)(int)array[1];

            if (File.Exists(path))
            {  
                if (GetTypeFile(path) == 1)
                {
                    DateValue.countFile = 1;
                    DateValue.isSearchFile = false;
                    ScanFile.AddTask(new ScanObject(path, oper, DateValue.Scan.SearchFile));
                }
                else
                {
                    DateValue.isScaning = false;
                }

                return;
            }

            int count = DateValue.countFile;
            string[] dirs = Directory.GetDirectories(path);
            foreach (string pathDir in dirs)
            {
                if (!DateValue.isScaning) return;
                SearchFileDirectory(new object[] { pathDir, oper});
            }
            string[] files = Directory.GetFiles(path);
            foreach (string pathFile in files)
            {
                if (!DateValue.isScaning) return;
                byte flag = GetTypeFile(pathFile);
                switch (flag)
                {
                    case 0: //other file
                        break;
                    case 1: //exe
                        DateValue.countFile++;
                        Console.WriteLine(pathFile);
                        ScanFile.AddTask(new ScanObject(pathFile, oper, DateValue.Scan.SearchFile));
                        break;
                    case 2: //zip
                        break;
                }
            }
            if (count == 0)
            {
                DateValue.isSearchFile = false;
                if (DateValue.countCheckFile == DateValue.countFile)
                {
                    DateValue.isScaning = false;
                    DBManager.AddReport(DateValue.idReport,DateValue.dateStart, DateTime.Now.ToString("MM.dd.yyyy H:mm"), DateValue.path, DateValue.countFile, DateValue.countVirusFile);
                }
            }
        }


        public static byte GetTypeFile(string path)
        {
            try
            {
                var file = new FileStream(path, FileMode.Open, FileAccess.Read,FileShare.ReadWrite);
                int temp = file.ReadByte();
                byte flag = 0;
                switch (temp)
                {
                    case 77: //M  exe
                        if (file.ReadByte() == 90) flag = 1; //Z
                        break;
                    case 80: //P  zip
                        if (file.ReadByte() == 75) flag = 2; //K
                        break;
                }
                file.Close();
                return flag;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
