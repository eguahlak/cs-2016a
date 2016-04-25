using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPets.Model {
  public interface IOldPerson {
    string FirstName { get; }
    string LastName { get; }
    int Age { get; }
    int HaveBirthday();
    }
  }
