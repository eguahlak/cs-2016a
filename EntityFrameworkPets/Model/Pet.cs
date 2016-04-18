using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPets.Model {
  
  public class Pet {
    public int Id { get; set; }
    public string Name { get; set; }
    public Person Owner { get; set; }
    }

  [Table("Cats")]
  public class Cat : Pet {
    public int LiveCount { get; set; }
    }

  [Table("Dogs")]
  public class Dog : Pet {
    public string BarkPitch { get; set; }
    }

  }
