using ADO.NET.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET {
  public class SqlPersonMapper {

    public ISet<Person> listPeople() {
      string conn = "";
      using (SqlConnection connection = new SqlConnection(conn)) {
        connection.Open();
        string sql = "SELECT ID, NAME FROM PEOPLE;";
        SqlCommand command = new SqlCommand(sql, connection);

        }
      throw new NotImplementedException();
      }

    }
  }
