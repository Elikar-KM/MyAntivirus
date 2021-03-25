using System.IO;
using System;

namespace AntiLib
{
    public class ScanObject
    {
        private string path;
        private byte[] text;
        private DateValue.Operation oper;
        private DateValue.Scan scan;

        public string Path { get => path;}
        public byte[] Text { get => text;}
        public DateValue.Operation Oper { get => oper;}
        public DateValue.Scan Scan { get => scan;}

        public ScanObject(string path,DateValue.Operation oper, DateValue.Scan scan)
        {
            this.path = path;
            this.oper = oper;
            this.scan = scan;

            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            bool txtIsFound = false;
            while (!txtIsFound)
            {
                int readByte = file.ReadByte();
                switch ((char)readByte)
                {
                    case '.': //.text
                        if ((char)file.ReadByte() == 't' &&
                            (char)file.ReadByte() == 'e' &&
                            (char)file.ReadByte() == 'x' &&
                            (char)file.ReadByte() == 't') txtIsFound = true;
                        break;
                    default:
                        break;
                }
                if (readByte == -1)
                {
                    file.Close();
                    return;
                }
            }

            file.Position += 10;

            byte[] array = new byte[4];
            file.Read(array, 0, 4);
            Array.Reverse(array, 0, array.Length);
            int rawDataSize = BitConverter.ToInt32(array, 0);

            file.Read(array, 0, 4);
            Array.Reverse(array, 0, array.Length);
            int rawDataPosition = BitConverter.ToInt32(array, 0);

            text = new byte[rawDataSize];
            file.Position = rawDataPosition;
            file.Read(text, 0, rawDataSize - 1);
            Console.WriteLine("create object");

            file.Close();
        }
    }
}
