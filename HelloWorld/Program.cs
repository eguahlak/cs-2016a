#if DEBUG
using System.Linq;
#endif
using System;
using Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
  namespace World {
    class Program {
      static int x;
      static Int32 y;
      static void Main(string[] args) {
        PropertyPerson sonja = new PropertyPerson(7, "Sonja", "Olsen");
        Console.WriteLine("ID: "+sonja.Id);
        Console.WriteLine("FN: "+sonja.FirstName);
        Console.WriteLine("LN: "+sonja.LastName);
        Console.WriteLine(sonja);
        sonja[1] = "Rufus";
        Console.WriteLine(sonja);
        sonja[100] = "Felix";
        Console.WriteLine(sonja);
        sonja[0] = "Lotte";
        Console.WriteLine(sonja);


        // sonja.Id = 8;
        sonja.LastName = null;
        Console.WriteLine("LN: "+sonja.LastName);
        try {
          sonja.LastName = "F";
          Console.WriteLine("LN: "+sonja.LastName);
          }
        catch (ArgumentOutOfRangeException) {
        //catch (ArgumentOutOfRangeException ex) {
          Console.WriteLine("-- arg exp --");
          }
        catch {
          Console.WriteLine("-- hovsa --");
          }
        Console.WriteLine();
        Console.WriteLine("Hello 4th semester");
        //Console.ReadKey();
        }
      }
    }
  }
