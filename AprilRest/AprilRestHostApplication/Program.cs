using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using AprilRestService;

namespace AprilRestHostApplication {
  class Program {
    static void Main(string[] args) {
      Uri url = new Uri("http://localhost:4712/People");
      using (WebServiceHost host =
          new WebServiceHost(typeof(PersonService), url)
          ) {
        host.Open();
        Console.WriteLine("Press any key to quit");
        Console.ReadKey();
        }
      }
    }
  }
