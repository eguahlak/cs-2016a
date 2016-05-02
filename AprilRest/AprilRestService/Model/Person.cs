using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AprilRestService.Model {
  
  [DataContract]
  public class Person {
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public int Age { get; set; }
    [DataMember]
    public Address Address { get; set; }
    }

  [CollectionDataContract]
  public class People : List<Person> {
    public People() { }
    public People(ICollection<Person> people) : base(people) { }
    }

  }
