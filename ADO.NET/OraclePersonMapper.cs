using ADO.NET.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET {
  public class OraclePersonMapper : IPersonMapper {
    
    public IList<Person> ListPeople() {
      IList<Person> people = new List<Person>();
      string conn = "DATA SOURCE=datdb.cphbusiness.dk/DAT;USER ID=AKA;PASSWORD=aka"; 
      using (OracleConnection connection = new OracleConnection(conn)) {
        connection.Open();
        string sql = "SELECT ID, NAME FROM PEOPLE";
        OracleCommand command = new OracleCommand(sql, connection);
        //OracleCommand command = connection.CreateCommand();
        //command.CommandText = sql;
        using (OracleDataReader reader = command.ExecuteReader()) {
          if (reader.HasRows) {
            while (reader.Read()) {
              long id = (long)reader["ID"];
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
