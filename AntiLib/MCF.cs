using System;
using System.IO;
using System.Threading;

namespace AntiLib
{
    public class MCF : IMCF
    {
        public bool CreateObserver(string path, DateValue.Operation oper)
        {
            if (DBManager.IsObserver(path) == "") return false;
            DateValue.listObserver.Add(new FileObserver(path, oper));
            DBManager.AddObserver(path, oper);
            return true;
        }
        static void Main(string[] args)
        {
            var a=DateValue.isScaning;
        }

        public void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
                DBManager.DeleteQuarantine(path);
            }
            catch (Exception e) { }
        }

        public void DeleteQuarantine(string path)
        {
            DBManager.DeleteQuarantine(path);
        }

        public void DestroyObserver(string path)
        {
            foreach(var observer in DateValue.listObserver)
            {
                if (observer.Path == path)
                {
                    observer.Destroy();
                    DBManager.DeleteObserver(path);
                }
            }
        }

        public string[] GetObserver()
        {
            return DBManager.GetObserver();
        }

        public float GetProgress()
        {
            if (!DateValue.isScaning) return 0;
            if (DateValue.isSearchFile) return 0;
            else return (float)DateValue.countCheckFile / (float)DateValue.countFile;
        }

        public string[] GetQuarantine()
        {
            return DBManager.GetQuarantine();
        }

        public bool GetStatus()
        {
            return DateValue.isScaning;
        }

        public void MoveBackQuarantine(string path)
        {
            try
            {
                using (var stream = File.Open(path, FileMode.Open))
                {
                    stream.Position = 0;
                    stream.WriteByte(0x4d);
                    stream.Close();
                }
                DBManager.DeleteQuarantine(path);
            }
            catch(Exception e){}
        }

        public bool StartScaning(string path, DateValue.Operation oper)
        {
            if (DateValue.isScaning) return false;
            else
            {
                DateValue.countCheckFile = 0;
                DateValue.countFile = 0;
                DateValue.countVirusFile = 0;
                DateValue.isScaning = true;
                DateValue.isSearchFile = true;
                DateValue.path = path;
                DateValue.dateStart = DateTime.Now.ToString("MM.dd.yyyy H:mm");
                DateValue.idReport = DBManager.GetNextIdReport();
                new Thread(SearchFile.SearchFileDirectory).Start(new object[] { path , oper});
                return true;
            }
        }

        public bool StopScaning()
        {
            if (!DateValue.isScaning) return false;
            else
            {
                DBManager.AddReport(DateValue.idReport,DateValue.dateStart, DateTime.Now.ToString("MM.dd.yyyy H:mm"), DateValue.path, DateValue.countFile, DateValue.countVirusFile);
                DateValue.isScaning = false;
                DateValue.isSearchFile = false;
                return true;
            }
        }

        public void ReloadObserver()
        {
            foreach (var obs in DateValue.listObserver)
            {
                obs.Destroy();
            }
            DateValue.listObserver.Clear();

            foreach (var obs in DBManager.GetObserver())
            {
                var strObs = obs.Split('|');
                Console.WriteLine(strObs[0]);
                DateValue.listObserver.Add(new FileObserver(strObs[0], (DateValue.Operation)int.Parse(strObs[1])));
            }
        }

        public string[] GetTime()
        {
            return DBManager.GetTime();
        }

        public void DeleteTime(string time, string path)
        {
            DBManager.DeleteTime(time, path);
        }

        public bool AddTime(string time, string path, DateValue.Operation oper)
        {
            foreach (var elem in DBManager.IsTime(time))
            {
                var aTime = elem.Split('|');
                if (aTime[1] == path) return false;
            }
            DBManager.AddTime(time, path, oper);
            return true;
        }

        public string[] GetReport()
        {
            return DBManager.GetReport();
        }

        public string[] GetFile(int idReport)
        {
            return DBManager.GetFile(idReport);
        }

        public void StartTimer()
        {
            if (DateValue.aTimer==null)
                DateValue.StartTimer();
        }
    }
}

