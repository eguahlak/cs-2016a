using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesNStuff {

  class Forex {
    public delegate void Change(string stock, double delta);
    private Random random = new Random();
    // private Change changeDelegate;

    public event Change ChangeDelegate;// {
      //add {
      //  changeDelegate += value;
      //  }
      //remove {
      //  changeDelegate -= value;
      //  }
      //}

    public void Run(int count) {
      for (int c = 0; c < count; c++) {
        Thread.Sleep(1000);
        double delta = random.NextDouble();
        int stockNo = random.Next(5);
        string stock = "Stock #"+stockNo;
        //if (changeDelegate != null) changeDelegate(stock, delta);
        if (ChangeDelegate != null) ChangeDelegate(stock, delta);
        //ChangeDelegate(stock, delta);
        }
      }
    }
  
  class YetAnotherProgram {
    private static double deltaSum = 0.0; 

    public static void RegisterStock(string stock, double delta) {
      Console.WriteLine("Stock "+stock+" has changed "+delta);
      }
    
    public static void RegisterDeltas(string stock, double delta) {
      deltaSum += delta;
      Console.WriteLine("Total delta until now: "+deltaSum);
      }

    public static void Haha(string a, double b) {
      Console.WriteLine("Got you!");
      }

    static void Main() {
      Forex forex = new Forex();
      //forex.Run(10);
      forex.ChangeDelegate += RegisterStock;
      forex.ChangeDelegate += RegisterDeltas;
      forex.ChangeDelegate += Haha;
      forex.Run(10);
      }
    
    }
  }
