using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace AntiLib
{
    public static class ScanFile
    {

        static ScanFile()
        {
            ThreadPool.SetMaxThreads(3, 3);
        }

        internal static void AddTask(ScanObject obj)
        {
            
            if (obj==null) return;
            if (ThreadPool.QueueUserWorkItem(ThreadProc, new object[] { obj.Path, obj.Text, obj.Oper, obj.Scan }))
                Console.WriteLine("Thread create");
        }

        internal static void ThreadProc(Object state)
        {
            Console.WriteLine("Thread start");
            bool isFound = false;
            object[] array = state as object[];
            var path = Convert.ToString(array[0]);
            byte[] text = array[1] as byte[];
            DateValue.Operation oper = (DateValue.Operation)(int)array[2];
            DateValue.Scan scan = (DateValue.Scan)(int)array[3];
            Console.WriteLine("if");
            if (text == null)
            {
                Console.WriteLine(".text null");
                if (scan.Equals(DateValue.Scan.SearchFile))
                    DateValue.countCheckFile++;
                return;
            }

            Console.WriteLine("thread for "+text.Length);
            for (int i = 0; i < text.Length - 4 && !isFound; i++)
            {

                //Console.WriteLine("thread: "+i);
                if (!DateValue.isScaning && scan.Equals(DateValue.Scan.SearchFile)) return;
                string searchSign = GetStringOfBytes(text, i, 4);
                List<string> signaturs = DBManager.SearchSignature(searchSign, i);
                foreach (var sign in signaturs)
                {
                    
                    if (CheckSignatureFullMatch(sign, text, i))
                    {

                        if (oper.Equals(DateValue.Operation.Quarantine))
                        {
                            QuarantineFile(path);
                            DBManager.AddQuarantine(DateTime.Now.ToString("MM/dd/yyyy H:mm"), path, DBManager.GetTypeSignature(sign));
                        }
                        else DeleteFile(path);


                        if (scan.Equals(DateValue.Scan.SearchFile))
                        {
                            DateValue.countVirusFile++;
                            DBManager.AddFile(DateValue.idReport, path, oper, DBManager.GetTypeSignature(sign));
                        }
                        Console.WriteLine("GOOOOOD");
                        isFound = true;
                        break;
                    }
                }
            }

            if (scan.Equals(DateValue.Scan.SearchFile))
            {
                DateValue.countCheckFile++;
                if (!DateValue.isSearchFile && DateValue.countCheckFile == DateValue.countFile)
                {
                    DateValue.isScaning = false;
                    DBManager.AddReport(DateValue.idReport,DateValue.dateStart, DateTime.Now.ToString("MM.dd.yyyy H:mm"), DateValue.path, DateValue.countFile, DateValue.countVirusFile);
                }
            }
            Console.WriteLine("End scan: "+path);
        }

        private static string GetStringOfBytes(byte[] array, int index, int length)
        {
            return BitConverter.ToString(array, index, length).Replace("-", "");
        }

        private static bool CheckSignatureFullMatch(string sign, byte[] text, int offset)
        {
            string signature = GetStringOfBytes(text, offset, sign.Length/2);
            if (signature.Equals(sign)) return true;
            return false;
        }

        private static void DeleteFile(string path)
        {
            if(File.Exists(path))
                File.Delete(path);
        }

        private static void QuarantineFile(string path)
        {
            if (File.Exists(path))
            {
                using (var stream = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
                {
                    stream.Position = 0;
                    stream.WriteByte(0x51);
                    stream.Close();
                }
            }
        }
    }
}
