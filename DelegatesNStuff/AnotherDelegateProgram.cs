using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesNStuff {

  delegate string Worker(string text);

  class AnotherDelegateProgram {
    
    public static string WorkLongTime(string text) {
      Console.WriteLine("starting long method...");
      Thread.Sleep(2000);
      Console.WriteLine("The text "+text);
      return text+" processed";
      }

    public static string WorkLessTime(string text) {
      Console.WriteLine("starting less long method...");
      Thread.Sleep(500);
      Console.WriteLine("Less time text "+text);
      return text+" processed quickly";
      }

    public static void CallBack(IAsyncResult result) {
      Console.WriteLine("Jeg er færdiiii...");
      AsyncResult ar = (AsyncResult)result;
      Worker w = (Worker)ar.AsyncDelegate;
      string t = w.EndInvoke(result);
      Console.WriteLine("### "+t);
      } 
    
    static void Main() {
      Worker w1 = WorkLongTime;
      Worker w2 = WorkLessTime;

      IAsyncResult r1 = w1.BeginInvoke("Sonja", CallBack, null);
      IAsyncResult r2 = w2.BeginInvoke("Kurt", CallBack, null);
      Console.WriteLine("Doing something else ... ");
      for (int i = 0; i < 100; i++) {
        Thread.Sleep(50);
        Console.Write(".");
        }
      //Console.WriteLine("$$$"+w1.EndInvoke(r1));
      //Console.WriteLine("$$$"+w2.EndInvoke(r2));
      }  

    }
  }
