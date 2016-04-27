using AprilRestService.Model;
using System.ServiceModel;
using System.ServiceModel.Web;
using static System.ServiceModel.Web.WebMessageFormat;
using static System.ServiceModel.Web.WebMessageBodyStyle;

namespace AprilRestService {
  [ServiceContract]
  public interface IPersonService {
  
    [OperationContract]
    [WebGet(ResponseFormat = Json)]
    string SayHello(string name);

    [OperationContract]
    [WebInvoke(BodyStyle = Bare, ResponseFormat = Json, RequestFormat = Json)]
    Person HaveBirthday(Person who);
    }
  }
