using AprilRestService;
using System;
using System.ServiceModel.Web;
using static System.ServiceModel.CommunicationState;
using System.ServiceProcess;

namespace AprilRestWindowsServiceApplication {
  public partial class AprilWindowsService : ServiceBase {
    private WebServiceHost host;
    
    public AprilWindowsService() {
      InitializeComponent();
      }

    protected override void OnStart(string[] args) {
      if (host == null) {
        Uri url = new Uri("http://localhost:4712/People");
        host = new WebServiceHost(typeof(PersonService), url);
        }
      if (host.State != Opened) host.Open();
      }

    protected override void OnStop() {
      if (host == null) return;
      if (host.State == Opened) host.Close();
      host = null;
      }
    }
  }
