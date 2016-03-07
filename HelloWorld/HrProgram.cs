using Inheritance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World {
  class HrProgram {
    static void Main() {
      Console.WriteLine("Welcome to the awesome HR program");
      Person kurt = new Person(7, "Kurt", new DateTime(1989,12,24));
      Person ida = new Person(8, "Lille Ida", new DateTime(2009, 7, 14));
      Person tom = new Person(9, "Store Tom", new DateTime(2012, 7, 14));
      Console.WriteLine(kurt);
      Console.WriteLine(ida);
      Employee sonja = new Employee(
          17, 
          "Sonja", 
          new DateTime(1970, 6, 12), 
          40000.56M, 
          DateTime.Now - new TimeSpan(1, 0, 0, 0)
          );
      Console.WriteLine(sonja);
      Console.WriteLine(sonja.Age);
      sonja.Relatives.Add(ida);
      sonja.Relatives.Add(tom);
      foreach (Person person in sonja.Relatives) {
        Console.WriteLine("Sonjas yngel: "+person);
        }
      for (int i = 0; i < sonja.Relatives.Count; i++) {
        Console.WriteLine("Sonjas barn #{0} er {1}", i, sonja.Relatives[i]);
        }
      IEnumerator<Person> e = sonja.Relatives.GetEnumerator();
      while (e.MoveNext()) {
        Console.WriteLine("Sonjas "+e.Current.Name);
        }


      Console.WriteLine(kurt.Status());
      Console.WriteLine(sonja.Status());
      if (sonja is Person) {
        Console.WriteLine(((Person)sonja).Status());
        Console.WriteLine((sonja as Person).Status());
        }

      
      ITeam e1 = sonja;
      Department adm = new Department("ADM", "Administration");
      Console.WriteLine(adm.Code);
      ITeam d1 = adm;

      Console.WriteLine(e1.Code);
      Console.WriteLine(d1.Code);
      Console.WriteLine((adm as IEncryptable).Code);

      // sonja.Department = adm;
      // adm.Add(sonja);
      Console.WriteLine(sonja.Department);
      adm.Employeez.Add(sonja);
      Console.WriteLine(sonja.Department.Name);
      Console.WriteLine(adm.Employeez.Count);

      }
    }
  }
