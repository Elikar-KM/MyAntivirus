using System.Collections.Generic;
using System;
using System.Timers;
using System.Threading;

namespace AntiLib
{
    static public class DateValue
    {
        public static volatile bool isScaning = false;
        public static volatile bool isSearchFile = false;
        public static volatile int countCheckFile = 0;
        public static volatile int countFile = 0;
        public static volatile int countVirusFile = 0;
        public static volatile int idReport=0;
        public static volatile string dateStart;
        public static volatile string path;
        public enum Operation { Quarantine, Delete };
        public enum Scan { SearchFile, Monitoring };
        public static List<FileObserver> listObserver = new List<FileObserver>();
        public static System.Timers.Timer aTimer;


        public static void StartTimer()
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 60000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}|{1}|", e.SignalTime, e.SignalTime.Hour + ":" + e.SignalTime.Minute);
            
            var time = DBManager.IsTime(e.SignalTime.Hour + ":" + e.SignalTime.Minute);
            if (time != "")
            {
                Console.WriteLine("Start");
                var arrTime = time.Split('|');
                if (DateValue.isScaning) return;
                else
                {
                    DateValue.countCheckFile = 0;
                    DateValue.countFile = 0;
                    DateValue.countVirusFile = 0;
                    DateValue.isScaning = true;
                    DateValue.isSearchFile = true;
                    DateValue.path = arrTime[1];
                    DateValue.dateStart = DateTime.Now.ToString("MM.dd.yyyy H:mm");
                    DateValue.idReport = DBManager.GetNextIdReport();
                    new Thread(SearchFile.SearchFileDirectory).Start(new object[] { arrTime[1], (Operation)int.Parse(arrTime[2]) });
                }
            }
        }
    }
}
