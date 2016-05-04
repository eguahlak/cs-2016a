using System;
using System.Collections.Generic;
using PetService.Model;
using System.ServiceModel.Web;
using System.Net;

namespace PetService {
  public class PetWebService : IPetWebService {
    private static IDictionary<int, Pet> pets;

    public PetWebService() {
      if (pets != null) return;
      pets = new Dictionary<int, Pet>();
      pets[7] = new Pet(7, "Ninus", 1);
      pets[9] = new Pet(9, "Felix", 6);
      pets[13] = new Pet(13, "Rufus", 3);
      }
 
    public Pet CreatePet(string name) {
      return new Pet(7, name, 1);
      }

    public Pet DeletePet(string idText) {
      Console.WriteLine("- Deleting pet with id = "+idText);
      int id = int.Parse(idText);
      Pet pet = pets[id];
      bool success = pets.Remove(id);
      Console.WriteLine("  "+(success ? "OK" : "Hovsa"));
      Console.WriteLine("  "+pets.Count+" pets left");
      return pet;
      }

    public Pet GetPet(string idText) {
      Console.WriteLine("- Getting pet with id = "+idText);
      try {
        int id = int.Parse(idText);
        return pets[id];
        }
      catch (FormatException) {
        throw new WebFaultException<string>(
            idText+" is not an integer",
            HttpStatusCode.PreconditionFailed
            );
        }
      catch (KeyNotFoundException) {
        throw new WebFaultException<string>(
            "There is no pet with id: "+idText,
            HttpStatusCode.NotFound
            );
        }
      }

    public ICollection<Pet> GetPets() {
      Console.WriteLine("- Getting all pets");
      return pets.Values;
      }

    public void PostPet(Pet pet) {
      Console.WriteLine("- Posting pet");
      pets[pet.Id] = pet;
      }

    public string SayHello(string name) {
      return "Hallo "+name;
      }


    }
  }
