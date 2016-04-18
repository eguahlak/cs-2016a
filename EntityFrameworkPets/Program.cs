using EntityFrameworkPets.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPets {
  class Program {

    private static void setup(PetClubContext db) {
      Club rabbits = new Club { Code="RBT", Name="Kaninklubben Kaj" };
      db.Clubs.Add(rabbits);
      Console.WriteLine("Kaninmedlemmer: "+rabbits.Members);
      Person kurt = new Person { FirstName="Kurt", LastName="Hansen", Age=34 };
      Person sonja = new Person { FirstName="Sonja", LastName="Hansen", Age=28 };
      rabbits.Members.Add(kurt);
      rabbits.Members.Add(sonja);
      rabbits.Chairman = sonja;
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

    private static void addPeople(PetClubContext db) {
      db.People.Add(new Person { FirstName="Ib", LastName="Svensen", Age=87 });
      db.People.Add(new Person { FirstName="Gurli", LastName="Poulse", Age=7 });
      db.People.Add(new Person { FirstName="Maj", LastName="Petersen", Age=12 });
      db.People.Add(new Person { FirstName="Mickael", LastName="Peterson", Age=14 });
      db.SaveChanges();
      }

    static void Main(string[] args) {
      using (var db = new PetClubContext()) {
        //setup(db);
        //addPeople(db);
        Console.WriteLine("Så langt så godt");
        string esql = "SELECT VALUE p FROM People AS p WHERE p.Age < 20";
        var context = (db as IObjectContextAdapter).ObjectContext;
        var youngsters = context.CreateQuery<Person>(esql);
        foreach (Person youngster in youngsters)
            Console.WriteLine("Young name: "+youngster.FirstName+" "+youngster.LastName); 
        }
      Console.ReadKey();
      }
    }
  }
