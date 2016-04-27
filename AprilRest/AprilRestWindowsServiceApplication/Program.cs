using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AprilRestWindowsServiceApplication {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    static void Main() {
      ServiceBase[] ServicesToRun;
      ServicesToRun = new ServiceBase[]
      {
                new AprilWindowsService()
      };
      ServiceBase.Run(ServicesToRun);
      }
    }
  }
