using ADO.NET.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET {
  public class SqlPersonMapper : IPersonMapper {

    public IList<Person> ListPeople() {
      IList<Person> people = new List<Person>();
      string conn = @"Data Source=(localdb)\mssqllocaldb;Integrated Security=True";
      using (SqlConnection connection = new SqlConnection(conn)) {
        connection.Open();
        string sql = "SELECT ID, NAME FROM PEOPLE;";
        SqlCommand command = new SqlCommand(sql, connection);
        using (SqlDataReader reader = command.ExecuteReader()) {
          if (reader.HasRows) {
            while (reader.Read()) {
              int id = (int)reader["ID"];
              string name = (string)reader["NAME"];
              Person person = new Person(id, name);
              people.Add(person);
              }
            }
          }
        }
      return people;
      }

    }
  }
