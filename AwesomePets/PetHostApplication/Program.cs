using PetService;
using System;
using System.ServiceModel.Web;

namespace PetHostApplication {
  class Program {
    static void Main(string[] args) {
      Uri url = new Uri("http://localhost:4711/Pets");
      using (WebServiceHost host = new WebServiceHost(typeof(PetWebService), url)) {
        //host.
        host.Open();
        Console.WriteLine("Press any key to close host...");
        Console.ReadKey();
        }
      }
    }
  }
