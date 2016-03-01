using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model {
  
  public class Department : ITeam, IEncryptable {
    public string Code { get; private set; }
    public string Name { get; set; }

    public Department(string code, string name) {
      Code = code;
      Name = name;
      }
    
    string ITeam.Code {
      get { return "D-"+Code; }
      }
    
    string IEncryptable.Code {
      get {
        SHA256Managed crypt = new SHA256Managed();
        string hash = String.Empty;
        string text = Code+"#"+Name;
        byte[] crypto = crypt.ComputeHash(
          Encoding.UTF8.GetBytes(text),
          0, 
          Encoding.UTF8.GetByteCount(text)
          );
        foreach (byte theByte in crypto) hash += theByte.ToString("x2");
        return hash;
        }
      }

    }
  }
