using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesNStuff {

  public delegate void Printer(string text, int count);
    
  public class FirstDelegates {
    public string Name { get; set; }
    public FirstDelegates(string name) {
      Name = name;
      }
    public static void Hello(string text, int count) {
      Console.WriteLine("printing {0} {1} times!", text, count);
      }
    public void Greet(string text, int count) {
      Console.WriteLine("{0} says {1} {2} times", Name, text, count);
      }
    }

  public class DelegateProgram {
    private static void doSomething(Printer p, string text) {
      p(text, 500);
      }

    public static void Main() {
      Printer p1 = new Printer(FirstDelegates.Hello);
      p1.Invoke("Kurt", 3);

      FirstDelegates fd1 = new FirstDelegates("Ib");
      Printer p2 = fd1.Greet;
      p2("Hello", 1000);

      CustomPrinter cp = new CustomPrinter(fd1);
      cp.Invoke("Hello", 2000);

      doSomething(p1, "Sonja");
      doSomething(p2, " hejsa");

      p1 += p2;
      p1("killroy was here", 7);

      }
    }

  }
