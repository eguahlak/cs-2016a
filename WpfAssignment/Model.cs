using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAssignment {
  public class Model {
    private ICollection<Employee> employeeList = new List<Employee>();
    
    public ObservableCollection<Employee> Employees { get; set; }
    
    public Employee Kurt { get; set; } = new Employee("Den Anden", "Kurt");
    
    public Model() {
      employeeList.Add(new Employee("Kurt", "Hansen"));
      employeeList.Add(new Employee("Sonja", "Jensen"));
      employeeList.Add(new Employee("Ib", "Olsen"));
      Employees = new ObservableCollection<Employee>(employeeList);
      }

    }
  }
