using PetService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace PetHostApplication {
  class Program {
    static void Main(string[] args) {
      Uri url = new Uri("http://localhost:4711/Pets");
      using (WebServiceHost host = new WebServiceHost(typeof(PetWebService), url)) {
        host.Open();
        Console.WriteLine("Press any key to close host...");
        Console.ReadKey();
        }
      }
    }
  }
