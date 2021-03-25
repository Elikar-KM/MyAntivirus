using System;
using System.IO;
using System.Threading;

namespace AntiLib
{
    public class FileObserver
    {
        private string path;
        private DateValue.Operation oper = new DateValue.Operation();
        private FileSystemWatcher watcher;
        public FileObserver(string path, DateValue.Operation oper)
        {
            this.path = path;
            this.oper = oper;

            watcher = new FileSystemWatcher(path);

            watcher.NotifyFilter = NotifyFilters.LastWrite;

            watcher.Changed += OnChanged;
            //watcher.Created += OnCreated;
            //watcher.Deleted += OnDeleted;
            //watcher.Renamed += OnRenamed;

            //watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }

        public void Destroy()
        {
            watcher.Changed -= OnChanged;
        }

        public string Path { get => path;}
        public DateValue.Operation Oper { get => oper; }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            if (SearchFile.GetTypeFile(e.FullPath)==1)
                new Thread(ThreadScan).Start(new object[] { e.FullPath , oper});
            Console.WriteLine($"Changed: {e.FullPath}");
        }

        internal static void ThreadScan(Object obj)
        {
            object[] array = obj as object[];
            var path = Convert.ToString(array[0]);
            DateValue.Operation oper = (DateValue.Operation)(int)array[1];

            ScanFile.AddTask(new ScanObject(path,oper,DateValue.Scan.Monitoring));
        }
        /*
        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);
        }*/
    }
}
