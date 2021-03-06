﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model {
  public class OneToMany<S, T> : ISet<T> {
    private S source;
    private ISet<T> targets = new HashSet<T>();
    private Setter setter;

    public delegate void Setter(S source, T target);

    public OneToMany(S source, Setter setter) {
      this.source = source;
      this.setter = setter;
      }

    public int Count { get { return targets.Count; } }

    public bool IsReadOnly { get { return targets.IsReadOnly; } }

    public bool Add(T target) {
      if (targets.Contains(target))
        return false;
      setter(source, target);
      return targets.Add(target);
      }

    public void UnionWith(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    public void IntersectWith(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    public void ExceptWith(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    public void SymmetricExceptWith(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    public bool IsSubsetOf(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    public bool IsSupersetOf(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    public bool IsProperSupersetOf(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    public bool IsProperSubsetOf(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    public bool Overlaps(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    public bool SetEquals(IEnumerable<T> other) {
      throw new NotImplementedException();
      }

    void ICollection<T>.Add(T item) {
      throw new NotImplementedException();
      }

    public void Clear() {
      throw new NotImplementedException();
      }

    public bool Contains(T item) {
      throw new NotImplementedException();
      }

    public void CopyTo(T[] array, int arrayIndex) {
      throw new NotImplementedException();
      }

    public bool Remove(T item) {
      throw new NotImplementedException();
      }

    public IEnumerator<T> GetEnumerator() {
      throw new NotImplementedException();
      }

    IEnumerator IEnumerable.GetEnumerator() {
      throw new NotImplementedException();
      }
    }
  }
