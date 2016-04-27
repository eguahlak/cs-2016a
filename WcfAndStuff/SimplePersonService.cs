using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfAndStuff {
  class SimplePersonService : IPersonService {
    public string SayHello(string name) {
      return "Hello "+name+" from Simple Person Service";
      }
    }
  }
