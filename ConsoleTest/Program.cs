using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Pipes;
using System.IO;
using System.Security.Principal;


namespace ConsoleTest
{
    class Program
    {
        private static StreamString streamWrite;
        private static NamedPipeServerStream pipeWrite;

        static void Main(string[] args)
        {
            Thread thread = new Thread(PipeReadThread);
            thread.Start();
            while (true){
                PipeWrite(Console.ReadLine());
            }
        }
        public static void PipeReadThread()
        {
            NamedPipeServerStream pipeServiceRead = new NamedPipeServerStream("pipeAntivirusServiceRead", PipeDirection.InOut, 1);

            try
            {
                StreamString ss = new StreamString(pipeServiceRead);
                while (true)
                {
                    if (!pipeServiceRead.IsConnected) pipeServiceRead.WaitForConnection();
                    var text = ss.ReadString();
                    Console.WriteLine(text);
                    Command command = new Command(text);
                    Console.WriteLine(command.ToString());
                }

            }
            catch (IOException e)
            { 
            }
            pipeServiceRead.Close();
        }

        public static void PipeWrite(string text)
        {
            if (pipeWrite == null)
                pipeWrite = new NamedPipeServerStream("pipeAntivirusServiceWrite", PipeDirection.InOut, 1);
            if (!pipeWrite.IsConnected)
                pipeWrite.WaitForConnection();
            if (streamWrite == null)
                streamWrite = new StreamString(pipeWrite);
            streamWrite.WriteString(text);
        }
    }

    public class Command
    {
        byte numberCommand;
        List<string> paths = new List<string>();
        Option option = new Option();

        public Command(string text)
        {
            var array = text.Split('|');
            foreach(var str in array)
            {
                switch (str[0]){
                    case 'N':
                        byte.TryParse(str.Substring(1, str.Length-1), out numberCommand);
                        break;
                    case 'P':
                        paths.Add(str.Substring(1, str.Length-1));
                        break;
                    case 'O':
                        switch (str[1])
                        {
                            case 'a': option.a = true; break;
                        }
                        break;
                }
            }
        }

        public override string ToString()
        {
            string str;
            str = "NumberCommand " + numberCommand+"\r\n";
            foreach(var path in paths)
            {
                str += path + "\r\n";
            }
            str += option.ToString();
            return str;
        }

        public struct Option
        {
            public bool a;

            public override string ToString()
            {
                string str = "Option:";
                if (a) str += "a";
                return str;
            }
        }
    }

    public class StreamString
    {
        private Stream ioStream;
        private UnicodeEncoding streamEncoding;

        public StreamString(Stream ioStream)
        {
            this.ioStream = ioStream;
            streamEncoding = new UnicodeEncoding();
        }

        public string ReadString()
        {
            int len = 0;

            len = ioStream.ReadByte() * 256;
            len += ioStream.ReadByte();
            byte[] inBuffer = new byte[len];
            ioStream.Read(inBuffer, 0, len);

            return streamEncoding.GetString(inBuffer);
        }

        public int WriteString(string outString)
        {
            byte[] outBuffer = streamEncoding.GetBytes(outString);
            int len = outBuffer.Length;
            if (len > UInt16.MaxValue)
            {
                len = (int)UInt16.MaxValue;
            }
            ioStream.WriteByte((byte)(len / 256));
            ioStream.WriteByte((byte)(len & 255));
            ioStream.Write(outBuffer, 0, len);
            ioStream.Flush();

            return outBuffer.Length + 2;
        }
    }
}
