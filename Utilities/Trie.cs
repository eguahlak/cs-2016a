using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities{
  public class Trie<T> {
    private static int alphabetSize = 256;
    private Branch<T> root = new Branch<T>();

    public T this[string text] {
      get {
        byte[] key = toKey(text);
        return root.Get(key, 0);
        }
      set {
        byte[] key = toKey(text);
        root.Set(key, 0, value);
        }
      }

    private static byte[] toKey(string text) {
      return Encoding.UTF8.GetBytes(text);
      }

    private class Branch<T> {
      private Branch<T>[] branches = new Branch<T>[alphabetSize];
      private T data;

      public void Set(byte[] key, int index, T data) {
        if (key.Length == index) this.data = data;
        else {
          if (branches[key[index]] == null)
              branches[key[index]] = new Branch<T>();
          branches[key[index]].Set(key, index + 1, data);
          }
        }
      
      public T Get(byte[] key, int index) {
        if (key.Length == index) return data;
        if (branches[key[index]] == null)
            throw new KeyNotFoundException();
        return branches[key[index]].Get(key, index + 1);
        }

      }
    }

  class TrieTester {
    static void Main() {
      Trie<string> trie = new Trie<string>();
      trie["anders"] = "Anders";
      trie["and"] = "And";
      trie["anna"] = "Anna";

      Console.WriteLine("{0} -> {1}", "anders", trie["anders"]);
      Console.WriteLine("{0} -> {1}", "anna", trie["anna"]);
      Console.WriteLine("{0} -> {1}", "and", trie["and"]);

      } 
    }
}
