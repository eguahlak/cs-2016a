using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Inheritance.Model {

  public class Department : ITeam, IEncryptable {
    public string Code { get; private set; }
    public string Name { get; set; }
    private IList<Employee> employees = new List<Employee>();
    private OneToMany<Department, Employee> employeez;
        

    public Department(string code, string name) {
      Code = code;
      Name = name;
      employeez = new OneToMany<Department, Employee>(this, Employee.setDepartment);
      }

    public ISet<Employee> Employeez {
      get { return employeez; }
      }

    public IList<Employee> Employees {
      get {
        return new ReadOnlyCollection<Employee>(employees);
        }
      }

    internal void add(Employee employee) {
      if (new StackTrace().GetFrame(1).GetMethod().DeclaringType != employee.GetType())
          throw new AccessViolationException();
      employees.Add(employee);
      }

    internal void remove(Employee employee) {
      employees.Remove(employee);
      }

    string ITeam.Code {
      get { return "D-"+Code; }
      }
    
    string IEncryptable.Code {
      get {
        SHA256Managed crypt = new SHA256Managed();
        string hash = String.Empty;
        string text = Code+"#"+Name;
        byte[] crypto = crypt.ComputeHash(
          Encoding.UTF8.GetBytes(text),
          0, 
          Encoding.UTF8.GetByteCount(text)
          );
        foreach (byte theByte in crypto) hash += theByte.ToString("x2");
        return hash;
        }
      }

    }
  }
