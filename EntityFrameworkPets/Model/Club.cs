using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPets.Model {
  public class Club {
    [Key]
    public string Code { get; set; }
    public string Name { get; set; }
    public IList<Person> Members { get; set; } = new List<Person>();
    public Person Chairman { get; set; }
    }
  }
