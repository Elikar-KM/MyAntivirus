using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;


namespace ConsoleService
{
    class Program
    {
        static void Main(string[] args)
        {
            //new FileSearch().GetFiles("D:\\tasm");  //рекурсивный проход по файлам
            DBwork db = new DBwork();
            db.Connect("D:\\Учеба\\3 курс 2 семестр\\ЗИВПО\\",DBwork.DB.OptDB);
            foreach (string path in db.getObserver())
            {
                new FileObserver(path);
            }
            


            //DBwork db = new DBwork();
            //db.Connect("D:\\Учеба\\3 курс 2 семестр\\ЗИВПО\\");
            //db.getSign();
            //var b = Convert.ToInt32("3D", 16);
            //db.Disconnect();
            Console.Read();
            
        }
    }
}
