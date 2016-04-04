using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAssignment {
  public class Employee : INotifyPropertyChanged {
    private string firstName;

    public string FirstName { 
      get { return firstName;  } 
      set { 
        firstName = value;
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs("FullName"));
        } 
      }

    public string LastName { get; set; }

    public Employee(string firstName, string lastName) {
      FirstName = firstName;
      LastName = lastName;
      }

    public string FullName {
      get { return FirstName+" "+LastName; }
      }

    public event PropertyChangedEventHandler PropertyChanged;

    }
  }
