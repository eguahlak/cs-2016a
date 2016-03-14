using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionNStuff {
  public class RandomEnumerable : IEnumerable<double> {
    private Random randomizer = new Random(8);

    public class Enumerator : IEnumerator<double> {
      private double current;
      private Random rand;

      public Enumerator(Random rand) { this.rand = rand; }

      public double Current {
        get {
          return current;
          }
        }

      public bool MoveNext() {
        current = rand.NextDouble();
        if (current < 0.1) return false;
        return true;
        }

      #region ...

      object IEnumerator.Current {
        get { return Current; }
        }

      public void Dispose() { }

      public void Reset() {
        throw new NotImplementedException();
        }

      #endregion
      }

    public IEnumerator<double> GetEnumerator() {
      return new Enumerator(randomizer);
      }

    IEnumerator IEnumerable.GetEnumerator() {
      return GetEnumerator();
      }

    }

  }
