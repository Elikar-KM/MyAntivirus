using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleTestLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\NWAntivirus\AntiDB.db");
            Console.WriteLine(@"C:\Users\MyPC\AppData\Local\NWAntivirus\AntiDB.db");
            //var mcf = new AntiLib.MCF();
            //mcf.StartScaning(@"D:\tasm\test", 0);
            //mcf.AddTime("12:12", "sadasd", (AntiLib.DateValue.Operation)1);
            //mcf.MoveBackQuarantine(@"D:\tasm\test\Zoom.exe");
            //var a=AntiLib.DateValue.isScaning;
            //mcf.CreateObserver("D:\\tasm\\test", AntiLib.DateValue.Operation.Quarantine);
            //mcf.ReloadObserver();
            //var obs = new AntiLib.FileObserver(@"D:\tasm\test", AntiLib.DateValue.Operation.Quarantine);
            //mcf.StartScaning(@"D:\tasm\test", AntiLib.DateValue.Operation.Quarantine);
            /*
            while (true)
            {
                Thread.Sleep(250);
                Console.WriteLine(AntiLib.DateValue.countCheckFile);
            }*/
            Console.Read();
        }
    }
}
