using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using AprilCalculatorClientApplication.CalculatorService;

namespace AprilCalculatorClientApplication {
  using CalculatorService;

  class Program {
    static void Main(string[] args) {
      using (CalculatorServiceClient client =
          new CalculatorServiceClient()) {
        Console.WriteLine("8 + 9 = "+client.Add(8, 9));
        Console.WriteLine("4723 - 12 = "+client.Subtract(4723, 12));
        }
      Console.ReadKey();
      }
    }
  }
