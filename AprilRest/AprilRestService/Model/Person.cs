using System;
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
  }
