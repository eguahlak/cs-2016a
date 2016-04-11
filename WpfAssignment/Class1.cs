using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAssignment {
  public class Department {
    public string Code { get; private set; }
    public string Name { get; set; }
    public ICollection<Employee> Employees { get; private set; }

    public Department(string code, string name) {
      Code = code;
      Name = name;
      Employees = new List<Employee>();
      }

    }
  }
