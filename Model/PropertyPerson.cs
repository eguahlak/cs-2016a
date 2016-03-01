using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
  public class PropertyPerson {
    public int Id { get; private set; }
    public string FirstName { get; set; }
    private string lastName;
    private long value;
    private string pets = "Ninus";

    public override string ToString() {
      return ""+Id+") "+Name+" "+pets;
      }

    public string this[int index] {
      get { return pets.Split(' ')[index]; }
      set {
        string[] parts = pets.Split(' ');
        if (index < parts.Length) {
          parts[index] = value;
          pets = string.Join(" ", parts);
          }
        else {
          pets += " "+value;
          }
        }
      }

    public string LastName {
      get { return lastName; }
      set {
        if (value == null) value = "Unknown";
        if (value.Length < 2)
            throw new ArgumentOutOfRangeException();
        lastName = value;
        }
      }

    public decimal Value {
      get { return value/100m; }
      set { this.value = (long)(100*value); }
      }

    public PropertyPerson(int id, string firstName, string lastName) {
      Id = id;
      FirstName = firstName;
      // this.lastName = lastName;
      LastName = lastName;
      }

    public string Name {
      get { return FirstName+" "+LastName; }
      set {
        string[] parts = value.Split(' ');
        if (parts.Length < 2) return;
        FirstName = parts[0];
        LastName = parts[1];
        }
      }
    
    }
  }
