using System;
using System.IO;

namespace ConsoleService
{
    class FileObserver
    {
        public FileObserver(string path)
        {
            var watcher = new FileSystemWatcher(path);

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            //watcher.Deleted += OnDeleted;
            //watcher.Renamed += OnRenamed;

            //watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Console.WriteLine($"Changed: {e.FullPath}");
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);
        }

        //private static void OnDeleted(object sender, FileSystemEventArgs e) =>
        //    Console.WriteLine($"Deleted: {e.FullPath}");

        //private static void OnRenamed(object sender, RenamedEventArgs e)
        //{
        //    Console.WriteLine($"Renamed:");
        //    Console.WriteLine($"    Old: {e.OldFullPath}");
        //    Console.WriteLine($"    New: {e.FullPath}");
        //}
    }
}
