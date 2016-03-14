using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesNStuff {
  public class CustomPrinter {
    private CustomPrinter next = null;
    private FirstDelegates instance;

    public CustomPrinter(FirstDelegates instance) {
      this.instance = instance;
      }
    public void Invoke(string text, int count) {
      instance.Greet(text, count);
      if (next != null) next.Invoke(text, count);
      }
    }
  }
