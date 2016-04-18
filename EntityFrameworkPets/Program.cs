using EntityFrameworkPets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPets {
  class Program {
    static void Main(string[] args) {
      using (var db = new PetClubContext()) {
        Club rabbits = new Club { Code="RBT", Name="Kaninklubben Kaj" };
        db.Clubs.Add(rabbits);
        Console.WriteLine("Kaninmedlemmer: "+rabbits.Members);
        Person kurt = new Person { FirstName="Kurt", LastName="Hansen", Age=34 };
        Person sonja = new Person { FirstName="Sonja", LastName="Hansen", Age=28 };
        rabbits.Members.Add(kurt);
        rabbits.Members.Add(sonja);
        Cat felix = new Cat { Name="Felix", LiveCount=5, Owner=kurt };
        Dog rufus = new Dog { Name="Rufus", BarkPitch="C2", Owner=kurt };
        Pet ninus = new Pet { Name="Ninus" };
        sonja.Pets.Add(ninus);
        db.Pets.Add(felix);
        db.Pets.Add(rufus);
        db.SaveChanges();
        foreach (Pet pet in kurt.Pets)
            Console.WriteLine(pet.Name);
        }
      Console.ReadKey();
      }
    }
  }
