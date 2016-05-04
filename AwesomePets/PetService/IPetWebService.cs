using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using static System.ServiceModel.Web.WebMessageFormat;
using System.Text;
using PetService.Model;

namespace PetService {
  [ServiceContract]
  public interface IPetWebService {
    [OperationContract]
    [WebGet(ResponseFormat = Json)]
    string SayHello(string name);

    [OperationContract]
    [WebGet(ResponseFormat = Json, UriTemplate = "CreatePet?name={name}")]
    Pet CreatePet(string name);

    [OperationContract]
    [WebGet(ResponseFormat = Json, UriTemplate = "pets/{id}")]
    Pet GetPet(string id);

    [OperationContract]
    [WebGet(
        //Method = "GET",
        UriTemplate = "pets",
        ResponseFormat = Json
        )]
    ICollection<Pet> GetPets();

    [OperationContract]
    [WebInvoke(
        Method = "POST",
        UriTemplate = "pets",
        RequestFormat = Json,
        BodyStyle = WebMessageBodyStyle.Bare
        )]
    void PostPet(Pet pet);

    [OperationContract]
    [WebInvoke(
        Method = "DELETE",
        UriTemplate = "pets/{id}",
        RequestFormat = Json,
        ResponseFormat = Json,
        BodyStyle = WebMessageBodyStyle.Bare
        )]
    Pet DeletePet(string id);
    }
  }
