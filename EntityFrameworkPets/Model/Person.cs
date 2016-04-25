using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPets.Model {
  
  public class Person {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public IList<Pet> Pets { get; set; } = new List<Pet>();
    [InverseProperty("Members")]
    public IList<Club> Clubs { get; set; } = new List<Club>();
    [InverseProperty("Chairman")]
    public IList<Club> ClubsLeaded { get; set; } = new List<Club>();
    public override string ToString() {
      return string.Format("{0} {1} is {2} years", FirstName, LastName, Age);
      }
    }
  }
