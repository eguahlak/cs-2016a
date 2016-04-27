using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AprilCalculatorService {
  [ServiceContract]
  public interface ICalculatorService {

    [OperationContract]
    int Add(int a, int b);

    [OperationContract]
    int Subtract(int a, int b);
    }

  }
