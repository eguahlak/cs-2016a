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
      }
    }
  }
