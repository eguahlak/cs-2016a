using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAssignment {
  public class Employee : INotifyPropertyChanged {
    private string firstName;
    private string lastName;
    public int Age { get; private set; }
    private Department department;

    public string FirstName { 
      get { return firstName;  } 
      set { 
        firstName = value;
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs("FullName"));
        } 
      }

    public string LastName { 
      get { return lastName; } 
      set {
        lastName = value;
        changes("FullName");
        }
      }

    public Employee(string firstName, string lastName) {
      FirstName = firstName;
      LastName = lastName;
      }

    public string FullName {
      get { return FirstName+" "+LastName; }
      }

    public void HaveBirthDay() {
      Age = Age + 1;
      changes("Age");
      }

    public event PropertyChangedEventHandler PropertyChanged;
    
    private void changes(string name) {
      if (PropertyChanged != null)
          PropertyChanged(this, new PropertyChangedEventArgs(name));
      } 

    public Department Department {
      get { return department; }
      set {
        if (department != null) department.Employees.Remove(this);
        department = value;
        if (department != null) department.Employees.Add(this);
        }
      }

    }

  }
