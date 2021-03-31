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
            
            
            var mcf = new AntiLib.MCF();
            mcf.ReloadObserver();


            //var a = new AntiLib.ScanObject(@"D:\tasm\test\Visual_Paradigm_CE_16_2_20200904_Win64.exe", AntiLib.DateValue.Operation.Quarantine, AntiLib.DateValue.Scan.Monitoring).Text;
            

          
            mcf.StartScaning(@"D:\tasm\test", 0);
            Console.Read();
        }

        
    }


}
