using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;

using AntiLib;
using System.ServiceModel;
using System.ServiceModel.Description;

using ServiceReference1;
using ServiceReference1.AntiLib;



namespace AntivirusService
{

   
    public partial class Service1 : ServiceBase
    {
        private ServiceHost service_host = null;
        public static MCFClient client = null;

        public Service1()
        {
            InitializeComponent();
        }

        private void Create_New_Client()
        {
            if (client == null) Try_To_Create_New_Client();
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
                client = null;
            }
        }

        protected override void OnStart(string[] args)
        {
            if (service_host != null) service_host.Close();

            string address_HTTP = "http://localhost:9001/AntivirusService";
            string address_TCP = "net.tcp://localhost:9002/AntivirusService";

            Uri[] address_base = { new Uri(address_HTTP), new Uri(address_TCP) };
            service_host = new ServiceHost(typeof(AntiLib.MCF), address_base);

            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            service_host.Description.Behaviors.Add(behavior);

            BasicHttpBinding binding_http = new BasicHttpBinding();
            service_host.AddServiceEndpoint(typeof(AntiLib.IMCF), binding_http, address_HTTP);
            service_host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            NetTcpBinding binding_tcp = new NetTcpBinding();
            binding_tcp.Security.Mode = SecurityMode.Transport;
            binding_tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            binding_tcp.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
            binding_tcp.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            service_host.AddServiceEndpoint(typeof(AntiLib.IMCF), binding_tcp, address_TCP);
            service_host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");

            service_host.Open();

            Create_New_Client();
            client.ReloadObserver();
            client.StartTimer();
            client.Close();

        }

        protected override void OnStop()
        {
            if (service_host != null)
            {
                service_host.Close();
                service_host = null;
            }
        }
    }
}
