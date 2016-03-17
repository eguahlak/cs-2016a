using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities{
  public class Trie<T> : IEnumerable<T> {
    private static int alphabetSize = 256;
    private Branch<T> root = new Branch<T>();
    public static Updater Update { get; set; }
    public delegate T Updater(T data, T input);

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

    public IEnumerator<T> GetEnumerator() {
      return root.GetEnumerator();
      }

    IEnumerator IEnumerable.GetEnumerator() {
      return GetEnumerator();
      }

    private class Branch<T> : IEnumerable<T> {
      private Branch<T>[] branches = new Branch<T>[alphabetSize];
      private bool hasData = false;
      private T data;

      public void Set(byte[] key, int index, T data) {
        if (key.Length == index) {
          //this.data = data;
          if (Update == null)
            this.data = data;
          else
            this.data = Trie<T>.Update(this.data, data);
          hasData = true;
          }
        else {
          if (branches[key[index]] == null)
            branches[key[index]] = new Branch<T>();
          branches[key[index]].Set(key, index + 1, data);
          }
        }
      
      public T Get(byte[] key, int index) {
        if (key.Length == index) {
          // if (data.Equals(default(T))) ; 
          if (hasData) return data;
          throw new KeyNotFoundException();
          }
        if (branches[key[index]] == null)
            throw new KeyNotFoundException();
        return branches[key[index]].Get(key, index + 1);
        }

      public IEnumerator<T> GetEnumerator() {
        if (hasData) yield return data;
        for (int i = 0; i < alphabetSize; i++) {
          if (branches[i] == null) continue;
          foreach (T t in branches[i]) yield return t;
          }
        }

      IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
        }
      }
    }

  struct Word {
    public string Text { get; set; }
    public int Count { get; set; }
    public Word(string text, int count) {
      Text = text;
      Count = count;
      }
    }

  class TrieTester {
    static void simpleTest() {
      Trie<string> trie = new Trie<string>();
      trie["anders"] = "Anders";
      trie["and"] = "And";
      trie["anna"] = "Anna";

      Console.WriteLine("{0} -> {1}", "anders", trie["anders"]);
      Console.WriteLine("{0} -> {1}", "anna", trie["anna"]);
      Console.WriteLine("{0} -> {1}", "and", trie["and"]);
      Console.WriteLine("--------");
      foreach (string data in trie) Console.WriteLine(data);
      }
    
    private static Word update(Word data, Word input) {
      return new Word(input.Text, data.Count + 1);
      }
    private static void kingJamesTest() {
      Trie<Word> words = new Trie<Word>();
      Trie<Word>.Update = update;
      using (StreamReader file = new StreamReader(@"C:\Development\king james bible.txt")) {
        do {
          string line = file.ReadLine();
          if (line == null) break;
          string[] texts = line.Split(' ', ',', '.', ';', '\'');
          foreach (string text in texts) {
            Word word = new Word(text, 1);
            words[text] = word;
            }
          }
        while (true);
        }
      foreach (Word word in words)
          Console.WriteLine("{0} -> {1}", word.Text, word.Count);
      Console.ReadKey();
      }

    static void Main() {
      //simpleTest();
      kingJamesTest();
      } 
    }
}
