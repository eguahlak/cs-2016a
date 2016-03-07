using CollectionNStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World {
  class CollectionProgram {

    static void Main() {
      RandomEnumerable rand = new RandomEnumerable();
      IEnumerator<double> r = rand.GetEnumerator();
      while (r.MoveNext()) {
        double d = r.Current;
        Console.WriteLine("-->"+d);
        }
      }
    }
  }
