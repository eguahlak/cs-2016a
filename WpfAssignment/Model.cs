using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAssignment {
  public class Model {
    private ICollection<Employee> employees = new List<Employee>();
    private ICollection<Department> departments = new List<Department>();
    
    public ObservableCollection<Employee> Employees { 
      get { return new ObservableCollection<Employee>(employees);  }
      }
    
    public ObservableCollection<Department> Departments {
      get { return new ObservableCollection<Department>(departments);  }
      } 

    public Employee Kurt { get; set; } = new Employee("Den Anden", "Kurt");
    
    private void createDepartment(string code, string name, params Employee[] employees) {
      Department department = new Department(code, name);
      foreach (Employee employee in employees) employee.Department = department;
      }

    public Model() {
      createDepartment("ADM", "Administration",
          new Employee("Kurt", "Hansen"),
          new Employee("Sonja", "Jensen"),
          new Employee("Ib", "Hansen")
          );
      createDepartment("EDP", "IT Department",
          new Employee("Maria", "Kallas"),
          new Employee("Michala", "Petri")
          );
      createDepartment("PRD", "Production");
      }

    }
  }
