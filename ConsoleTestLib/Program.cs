using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using Ionic.Zip;


namespace ConsoleTestLib
{
    class Program
    {


        static void Main(string[] args)
        {





            //Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\NWAntivirus\AntiDB.db");
            //Console.WriteLine(@"C:\Users\MyPC\AppData\Local\NWAntivirus\AntiDB.db");



            /*
            var mcf = new AntiLib.MCF();
            var a = new AntiLib.ScanObject(@"D:\tasm\test\Zoom.exe",AntiLib.DateValue.Operation.Quarantine, AntiLib.DateValue.Scan.Monitoring).Text;
            byte[] b;
            using (ZipFile zip = ZipFile.Read(@"D:\tasm\test\Zoom1.zip"))
            {
                foreach (var entry in zip.Entries)
                {
                    var mstream = new MemoryStream();
                    entry.Extract(mstream);
                    mstream.Position = 0;
                    b = new AntiLib.ScanObject(mstream, @"D:\tasm\test\Zoom1.rar", AntiLib.DateValue.Operation.Quarantine, AntiLib.DateValue.Scan.Monitoring).Text;
                }
            }*/

            var mcf = new AntiLib.MCF();

            //var b = new AntiLib.ScanObject(new MemoryStream(@"D:\tasm\test\Zoom.exe"), @"D:\tasm\test\Zoom.exe", AntiLib.DateValue.Operation.Quarantine, AntiLib.DateValue.Scan.Monitoring).Text;
            mcf.StartScaning(@"D:\tasm\test", 0);
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
