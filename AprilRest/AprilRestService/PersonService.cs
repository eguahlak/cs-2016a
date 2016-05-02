using System;
using System.Collections.Generic;
using AprilRestService.Model;

namespace AprilRestService {
  public class PersonService : IPersonService {
    private IDictionary<string, Person> people = 
        new Dictionary<string, Person>();
    
    public Person HaveBirthday(Person who) {
      who.Age++;
      if (who.Age == 18)
          who.Address = new Address("Langt væk fra mor", 9000);
      return who;
      }

    public string SayHello(string name) {
      return "Hello "+name+" from April Services";
      }
    
    }
  }
