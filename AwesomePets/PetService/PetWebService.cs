using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PetService.Model;

namespace PetService {
  public class PetWebService : IPetWebService {
    private IDictionary<int, Pet> pets =
        new Dictionary<int, Pet>();

    public PetWebService() {
      pets[7] = new Pet(7, "Ninus", 1);
      pets[9] = new Pet(9, "Felix", 6);
      pets[13] = new Pet(13, "Rufus", 3);
      }
 
    public Pet CreatePet(string name) {
      return new Pet(7, name, 1);
      }

    public Pet GetPet(string idText) {
      Console.WriteLine("- Getting pet with id = "+idText);
      int id = int.Parse(idText);
      return pets[id];
      }

    public string SayHello(string name) {
      return "Hallo "+name;
      }


    }
  }
