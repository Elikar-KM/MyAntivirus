using System.IO;
using System;
using Ionic.Zip;

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
                        Console.WriteLine(pathFile);
                        OpenZip(pathFile,oper);
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
                var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
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

        public static byte GetTypeFile(MemoryStream file)
        {
            try
            {
                //var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
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
                //file.Close();
                return flag;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static void OpenZip(string zipPath, DateValue.Operation oper)
        {
            using (ZipFile zip = ZipFile.Read(zipPath))
            {
                foreach (var entry in zip.Entries)
                {
                    using (var reader = entry.ExtractToMemoryStream())
                    {
                        byte flag = GetTypeFile(reader);
                        Console.WriteLine("zip flag" + flag.ToString());
                        switch (flag)
                        {
                            case 0: //other file
                                Console.WriteLine("zip"+entry.FileName);
                                break;
                            case 1: //exe
                                DateValue.countFile++;
                                Console.WriteLine("zip" + entry.FileName);
                                reader.Position = 0;
                                ScanFile.AddTask(new ScanObject(reader,zipPath+'\\'+entry.FileName, oper, DateValue.Scan.SearchFile));
                                break;
                            case 2: //zip
                                OpenZipZip(entry, oper, zipPath + '\\' + entry.FileName);
                                break;
                        }
                    }
                }
            }
        }

        public static void OpenZipZip(ZipEntry zipEntry, DateValue.Operation oper, string path)
        {
            using (ZipFile zip = ZipFile.Read(zipEntry.ExtractToMemoryStream()))
            {
                foreach (var entry in zip.Entries)
                {
                    using (var reader = entry.ExtractToMemoryStream())
                    {
                        byte flag = GetTypeFile(reader);
                        switch (flag)
                        {
                            case 0: //other file
                                break;
                            case 1: //exe
                                DateValue.countFile++;
                                Console.WriteLine(entry.FileName);
                                reader.Position = 0;
                                ScanFile.AddTask(new ScanObject(reader, path + '\\' + entry.FileName, oper, DateValue.Scan.SearchFile));
                                break;
                            case 2: //zip
                                OpenZipZip(entry, oper, path+'\\'+ entry.FileName);
                                break;
                        }
                    }
                }
            }
        }
    }
    static class IonicExtensions
    {
        public static MemoryStream ExtractToMemoryStream(this ZipEntry zipEntry)
        {
            var mstream = new MemoryStream();
            zipEntry.Extract(mstream);
            mstream.Position = 0;
            return mstream;
        }
    }
}
