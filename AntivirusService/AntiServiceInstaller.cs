using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace AntivirusService
{
    [RunInstaller(true)]
    public partial class AntiServiceInstaller : System.Configuration.Install.Installer
    {
        public AntiServiceInstaller()
        {
            serviceProcessInstaller1 = new ServiceProcessInstaller();
            serviceProcessInstaller1.Account = ServiceAccount.LocalSystem;
            serviceInstaller1 = new ServiceInstaller();
            serviceInstaller1.ServiceName = "WindowsServiceHostForMyService";
            serviceInstaller1.DisplayName = "WindowsServiceHostForMyService";
            serviceInstaller1.Description = "WCF Service Hosted by Windows NT Service";
            serviceInstaller1.StartType = ServiceStartMode.Automatic;
            Installers.Add(serviceProcessInstaller1);
            Installers.Add(serviceInstaller1);
            //InitializeComponent();
        }
    }
}
