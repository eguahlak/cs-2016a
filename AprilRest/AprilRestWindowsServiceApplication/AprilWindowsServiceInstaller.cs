using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace AprilRestWindowsServiceApplication {
  [RunInstaller(true)]
  public partial class AprilWindowsServiceInstaller : System.Configuration.Install.Installer {
    private ServiceProcessInstaller process;
    private ServiceInstaller service;
    public AprilWindowsServiceInstaller() {
      InitializeComponent();
      process = new ServiceProcessInstaller {
        Account = ServiceAccount.LocalSystem
        };
      service = new ServiceInstaller {
        ServiceName = "April1Service",
        DisplayName = "April1Service",
        Description = "April first service Inc.",
        StartType = ServiceStartMode.Automatic
        };
      Installers.Add(process);
      Installers.Add(service);
      }
    }
  }
