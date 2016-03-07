using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model {

  public class Person {

    public int Age {
      get { return (int)((DateTime.Now - Birth).Days/365.25); }
      }
  
    public virtual decimal NextGiftPrice() {
      if (Age < 13) return 150.00M;
      return 0M;
      }
    #region More ...
    public int Id { get; private set; }
    public string Name { get; set; }
    public DateTime Birth { get; set; }

    #region construction
    public Person(int id) {
      Id = id;
      }

    public Person(int id, string name, DateTime birth) : this(id) {
      Name = name;
      Birth = birth;
      }

    public override string ToString() {
      return string.Format("{0}) [{3}] {1} born {2}", Id, Name, Birth, NextGiftPrice());
      }
    #endregion

    
    
    public string Status() { return "Civilian"; }
    #endregion
    }

  // A C# code file can have several classes
  // The name of the file does not have to correspond to the class name 
  
  public class Employee : Person, ITeam {
    public decimal Salary { get; set; }
    public DateTime Since { get; set; }
    public IList<Person> Relatives { get; private set; }
    private Department department;

    public static void setDepartment(Department department, Employee target) {
      target.department = department;
      }

    public Employee(int id) : base(id) {
      // super(id); Java syntax
      Since = new DateTime();
      Relatives = new List<Person>();
      }
    
    public string Code {
      get { return "E-"+Id; }
      }

    public override decimal NextGiftPrice() {
      return 500.00M;
      }

    public Employee(
        int id, 
        string name, 
        DateTime birth, 
        decimal salary, 
        DateTime since
        ) : base(id, name, birth) {
      Salary = salary;
      Since = since;
      Relatives = new List<Person>();
      }

    public override string ToString() {
      return base.ToString()+" earns "+Salary;
      }

    public Department Department {
      set {
        if (department != null) department.remove(this);
        department = value;
        if (department != null) department.add(this);
        }
      get {
        return department;
        }
      }

    public new string Status() { return "Internal"; }

    }

  }
