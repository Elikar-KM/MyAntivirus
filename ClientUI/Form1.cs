using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;
using System.Security.Principal;
using ServiceReference1;
using System.ServiceModel;
using ServiceReference1.AntiLib;


namespace ClientUI
{
    
    public partial class Form1 : Form
    {
        private List<string> sendList = new List<string>();
        private List<Panel> allPanels;
        public static MCFClient client = null;
        public Form1()
        {
            InitializeComponent();
            allPanels = new List<Panel>() { pSearch,pUpdate,pQuarantine,pReport,pMonitoring};

            Create_New_Client();

            foreach (var q in client.GetObserver())
            {
                var str = q.Split('|');
                MonitoringElementFactory.EditElement(flowPanelMonitoring, str[0], int.Parse(str[1]));
            }

            foreach (var q in client.GetTime())
            {
                var str = q.Split('|');
                UpdateElementFactory.AddElement(flowUpdatePanel, str[0],str[1], int.Parse(str[2]));
            }

        }


        private void Create_New_Client()
        {
            if (client == null) Try_To_Create_New_Client();
            else MessageBox.Show("Cannot create a new client. The current Client is active.");
        }

        private void Try_To_Create_New_Client()
        {
            try
            {

                NetTcpBinding binding = new NetTcpBinding(SecurityMode.Transport);

                binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
                binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
                binding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;

                string uri = "net.tcp://localhost:9002/AntivirusService";

                EndpointAddress endpoint = new EndpointAddress(new Uri(uri));

                client = new MCFClient(binding, endpoint);


            }
            catch (Exception)
            {
                MessageBox.Show("Error while creating new client (server might be stopped).");
                client = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach(var panel in allPanels)
            {
                panel.Visible = false;
            }
            pSearch.Visible = true;
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            foreach (var panel in allPanels)
            {
                panel.Visible = false;
            }
            pMonitoring.Visible = true;
        }

        private void btnQuarantine_Click(object sender, EventArgs e)
        {
            QuarantineElementFactory.RemoveAllElement(flowQuarantinePanel);
            foreach (var q in client.GetQuarantine())
            {
                var str = q.Split('|');
                QuarantineElementFactory.AddElement(flowQuarantinePanel, str[0], str[1], str[2]);
            }
            foreach (var panel in allPanels)
            {
                panel.Visible = false;
            }
            pQuarantine.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportElementFactory.RemoveAllElement(flowReportPanel);
            foreach (var q in client.GetReport())
            {
                var str = q.Split('|');
                ReportElementFactory.AddElement(flowReportPanel,flowFilePanel, str[0], str[1], str[2],str[3],str[4], str[5]);
            }
            foreach (var panel in allPanels)
            {
                panel.Visible = false;
            }
            pReport.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (var panel in allPanels)
            {
                panel.Visible = false;
            }
            pUpdate.Visible = true;
        }

        private void addMonitoring_Click(object sender, EventArgs e)
        {
            pEditAddMon.Visible = true;
            rqEditAddMon.Checked = true;
        }

        private void removeMonitoring_Click(object sender, EventArgs e)
        {
            foreach (var path in MonitoringElementFactory.RemoveElement(flowPanelMonitoring))
            {
                client.DestroyObserver(path);
            }
        }

        private void selectAllElementMonitoring_Click(object sender, EventArgs e)
        {
            MonitoringElementFactory.SelectAllCheckBox();
        }

        private void editMonitoring_Click(object sender, EventArgs e)
        {
            int rb = 0;
            string path = MonitoringElementFactory.SelectUpdateElement(ref rb);
            if (path != "")
            {
                pEditAddMon.Visible = true;
                tEditAddMon.Text = path;
                if (rb == 0) rqEditAddMon.Checked = true;
                else rdEditAddMon.Checked = true;
            }
        }

        private void bCloseEditAddMon_Click(object sender, EventArgs e)
        {
            pEditAddMon.Visible = false;
            tEditAddMon.Text = "";
            rqEditAddMon.Checked = false;
            rdEditAddMon.Checked = false;
            MonitoringElementFactory.editLine = -1;
        }

        private void bSaveEditAddMon_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tEditAddMon.Text) && Directory.Exists(tEditAddMon.Text))
            {
                int rb = 0;
                if (rdEditAddMon.Checked) rb = 1;
                var str = MonitoringElementFactory.EditElement(flowPanelMonitoring, tEditAddMon.Text, rb);

                var arrStr = str.Split('|');
                if (arrStr.Length == 3) {
                    client.DestroyObserver(arrStr[0]);
                    client.CreateObserver(arrStr[1], (DateValueOperation)int.Parse(arrStr[2]));
                }
                else
                {
                    client.CreateObserver(arrStr[0], (DateValueOperation)int.Parse(arrStr[1]));
                }

                pEditAddMon.Visible = false;
                tEditAddMon.Text = "";
                rqEditAddMon.Checked = false;
                rdEditAddMon.Checked = false;
            }
        }

        private void lDropSearch_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            tSearchPath.Text = s[0];
        }

        private void lDropSearch_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void bOpenFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tSearchPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void bQRecavery_Click(object sender, EventArgs e)
        {
            foreach(var path in QuarantineElementFactory.RemoveElement(flowQuarantinePanel))
            {
                client.MoveBackQuarantine(path);
            }
        }

        private void bQRemove_Click(object sender, EventArgs e)
        {
            foreach (var path in QuarantineElementFactory.RemoveElement(flowQuarantinePanel))
            {
                client.DeleteFile(path);
            }
        }

        private void bScanStart_Click(object sender, EventArgs e)
        {
            if (File.Exists(tSearchPath.Text) || Directory.Exists(tSearchPath.Text))
            {
                int rb = 0;
                if (rdSearch.Checked == true) rb = 1;
                client.StartScaning(tSearchPath.Text, (DateValueOperation)rb);
                pProgressScan.Visible = true;
            } 
        }

        private void bScanStop_Click(object sender, EventArgs e)
        {
            client.StopScaning();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pProgressScan.Visible = client.GetStatus();
            if (client.GetStatus())
            {
                progressScan.Value = (int)(client.GetProgress()*progressScan.Maximum);
                Console.WriteLine(client.GetProgress());
            }
        }

        private void bUpdateAdd_Click(object sender, EventArgs e)
        {
            int rb = 0;
            if (rdUpdate.Checked) rb = 1;
            UpdateElementFactory.AddElement(flowUpdatePanel, ncUpdate.Value+":"+nmUpdate.Value, tUpdate.Text,rb);
            client.AddTime(ncUpdate.Value + ":" + nmUpdate.Value, tUpdate.Text, (DateValueOperation)rb);
        }

        private void bUpdateDelete_Click(object sender, EventArgs e)
        {
            var arr=UpdateElementFactory.RemoveElement(flowUpdatePanel);
            foreach(var t in arr)
            {
                var str = t.Split('|');
                client.DeleteTime(str[0], str[1]);
            }
        }

        private void bUpdateOpenDialog_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tUpdate.Text = fbd.SelectedPath;
                }
            }
        }

        private void pReport_Click(object sender, EventArgs e)
        {
            flowFilePanel.Visible = false;
        }
    }
}
