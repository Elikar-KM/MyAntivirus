using System.IO;
using System.IO.Compression;

namespace ConsoleService
{
    class FileSearch
    {
        public void GetFiles(string path)
        {
            GetFiles(path, false);
        }
        protected void GetFiles(string path, bool destroy)
        {
            //Directory.Exists("D:\\tasm\\");

            string[] dirs = Directory.GetDirectories(path);
            foreach (string s in dirs)
            {
                GetFiles(s,destroy);
            }
            string[] files = Directory.GetFiles(path);
            foreach (string s in files)
            {
                byte flag = CheckFile(s);
                switch (flag)
                {
                    case 0: //other file
                        if (destroy) File.Delete(s);
                        break; 
                    case 1: //exe
                        break; 
                    case 2: //zip
                        string folderZipPath = path + "\\" + Path.GetFileName(s) + ".temp\\";
                        ZipFile.ExtractToDirectory(s, folderZipPath);
                        if (destroy) File.Delete(s);
                        GetFiles(folderZipPath, true);
                        //File.Delete(path);
                        break; 
                    case 3: //elf
                        break; 
                }
            }
            if (destroy)
                if (Directory.GetDirectories(path).Length == 0 && Directory.GetFiles(path).Length==0) Directory.Delete(path);
        }

        protected byte CheckFile(string path)
        {
            var file = new FileStream(path,FileMode.Open, FileAccess.Read);
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
                case 127:// ELF
                    if (file.ReadByte() == 69 && file.ReadByte() == 76 && file.ReadByte() == 70) flag = 3; //ELF
                    break;
            }
            file.Close();
            return flag;
        }
    }
}
