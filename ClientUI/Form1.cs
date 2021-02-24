using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;
using System.Security.Principal;

namespace ClientUI
{
    
    public partial class Form1 : Form
    {
        private List<string> sendList = new List<string>();
        private Thread pipeReadThread;
        private StreamString streamWrite;
        private NamedPipeClientStream pipeWrite;
        public Form1()
        {
            InitializeComponent();
            pipeReadThread = new Thread(PipeReadThread);
            pipeReadThread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "N";
            str += numericUpDown1.Value + "|P" + textBox1.Text;
            if (checkBox1.Checked) str += "|Oa";
            if (checkBox2.Checked) str += "|Ob";
            if (checkBox3.Checked) str += "|Oc";
            PipeWrite(str);
        }

        public void PipeReadThread()
        {
            try
            {
                var pipeRead = new NamedPipeClientStream(".", "pipeAntivirusServiceWrite", PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.Impersonation);
                pipeRead.Connect();
                var ss = new StreamString(pipeRead);
                while (true)
                {
                    var text = ss.ReadString();
                    if (text == "error") continue;
                    label1.Invoke(new Action(() => label1.Text = text));
                }
            }
            catch (IOException e)
            {
            }
        }

        public void PipeWrite(string text)
        {
            if (pipeWrite==null)
                pipeWrite = new NamedPipeClientStream(".", "pipeAntivirusServiceRead", PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.Impersonation);
            if (!pipeWrite.IsConnected)
                pipeWrite.Connect();
            if (streamWrite==null) 
                streamWrite = new StreamString(pipeWrite);
            streamWrite.WriteString(text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pipeWrite != null)
            {            
                pipeWrite.Dispose();
            }
            pipeReadThread.Abort();
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
            try
            {
                int len = 0;

                len = ioStream.ReadByte() * 256;
                len += ioStream.ReadByte();
                byte[] inBuffer = new byte[len];
                ioStream.Read(inBuffer, 0, len);

                return streamEncoding.GetString(inBuffer);
            }
            catch (Exception ex)
            {
                return "error";
            }
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
