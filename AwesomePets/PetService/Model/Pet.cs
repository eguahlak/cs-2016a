using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetService.Model {
  public class Pet {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Pet() { }

    public Pet(int id, string name, int age) {
      Id = id;
      Name = name;
      Age = age;
      }

    }
  }
