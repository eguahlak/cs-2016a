using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Model {
  
  public class Person {
    public long Id { get; private set; }
    public string Name { get; set; }

    public Person(long id, string name) {
      Id = id;
      Name = name;
      }

    }

  }
