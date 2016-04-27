using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using AprilCalculatorService;

namespace AprilCalculatorHostApplication {
  class Program {
    static void Main(string[] args) {
      Uri url = new Uri("http://localhost:4711/Calculator");
      using (ServiceHost host = new ServiceHost(
          typeof(CalculatorService),
          url
          )) {
        host.Description.Behaviors.Add(new ServiceMetadataBehavior {
            HttpGetEnabled = true
            });
        host.Open();
        Console.WriteLine("Host is running press any key to stop");
        Console.ReadKey();
        }
      }
    }
  }
