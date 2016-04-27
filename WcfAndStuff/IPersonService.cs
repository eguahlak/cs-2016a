using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfAndStuff {
  
  [ServiceContract(Namespace = "http://service.cphbusiness.dk")]
  public interface IPersonService {
    [OperationContract]
    string SayHello(String name);
    }
  }
