using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionNStuff {
  public class SmartList<T> : IList<T> {
    private T[] items = new T[1];
    private int count = 0;

    public T this[int index] {
      get {
        if (index >= count) throw new IndexOutOfRangeException();
        return items[index];
        }
      set {
        if (index > count) throw new IndexOutOfRangeException();
        if (index == count) Add(value);
        items[index] = value;
        }
      }

    public int Count {
      get { return count; }
      }

    public void Add(T item) {
      if (count < items.Length) items[count++] = item;

      }

    public void Clear() {
      throw new NotImplementedException();
      }

    public IEnumerator<T> GetEnumerator() {
      throw new NotImplementedException();
      }

    public bool IsReadOnly {
      get {
        throw new NotImplementedException();
        }
      }

    public bool Contains(T item) {
      throw new NotImplementedException();
      }

    public void CopyTo(T[] array, int arrayIndex) {
      throw new NotImplementedException();
      }

    public int IndexOf(T item) {
      throw new NotImplementedException();
      }

    public void Insert(int index, T item) {
      throw new NotImplementedException();
      }

    public bool Remove(T item) {
      throw new NotImplementedException();
      }

    public void RemoveAt(int index) {
      throw new NotImplementedException();
      }

    IEnumerator IEnumerable.GetEnumerator() {
      throw new NotImplementedException();
      }
    }
  }
