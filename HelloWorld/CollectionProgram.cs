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
      //IEnumerator<double> r = rand.GetEnumerator();
      //while (r.MoveNext()) {
      //  double d = r.Current;
      //  Console.WriteLine("-->"+d);
      //  }
      foreach (double d in rand.Where(x => x < 0.5).OrderByDescending(x => x))
        Console.WriteLine("-->"+d);

      Console.WriteLine(rand.Min());

      var q = from d in rand where d > 0.5 orderby d select d;
      foreach (double v in q)
        Console.WriteLine(">>>"+v);

      }
      
    }
  }
