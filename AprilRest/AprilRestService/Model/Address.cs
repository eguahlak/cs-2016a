using System;
using System.Runtime.Serialization;

namespace AprilRestService.Model {
  [DataContract]
  public class Address {
    [DataMember]
    public string Street { get; set; }
    [DataMember]
    public int ZipCode { get; set; }
    
    public Address() { }
    public Address(string street, int zipCode) {
      Street = street;
      ZipCode = zipCode;
      }

    }
  }
