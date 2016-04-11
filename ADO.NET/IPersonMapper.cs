using ADO.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET {
  public interface IPersonMapper {
    IList<Person> ListPeople();
    }
  }
