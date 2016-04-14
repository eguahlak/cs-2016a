using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetNStuff {
  
  class Program {
    private static string SQL_CONN = 
        @"Data Source=(localdb)\mssqllocaldb;Integrated Security=True";
    private static string ORACLE_CONN = 
        @"DATA SOURCE=datdb.cphbusiness.dk:1521/DAT;USER ID=AKA;PASSWORD=aka";
    
    private static void runClassicSelect(DbConnection connection, DbProviderFactory factory) {
      connection.Open();
      string sql = "SELECT id, name FROM People";
      DbCommand command = factory.CreateCommand();
      command.CommandText = sql;
      command.Connection = connection;
      using (DbDataReader reader = command.ExecuteReader()) {
        if (reader.HasRows) {
          while (reader.Read()) 
              Console.WriteLine("{0,4}: {1}", reader["id"], reader["name"]);
          }
        }
      }

    private static void print(DataTable table) {
      Console.WriteLine(table.TableName);
      Console.WriteLine("---------------------------------------");
      foreach (DataColumn column in table.Columns)
          Console.Write("{0,10}", column.ColumnName);
      Console.WriteLine();
      foreach (DataRow row in table.Rows) {
        if (row.RowState != DataRowState.Deleted) foreach (DataColumn column in table.Columns)
            Console.Write("{0,10}", row[column]);
        Console.WriteLine();
        }
      }
        
    static void Main(string[] args) {
      //DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OracleClient");
      DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
      DbConnection connection = factory.CreateConnection();
      connection.ConnectionString = SQL_CONN;
      using (connection) {
        //runClassicSelect(connection, factory);
        string sql = "SELECT id, name FROM People";
        DbCommand command = connection.CreateCommand();
        command.CommandText = sql;

        DbDataAdapter adapter = factory.CreateDataAdapter();
        adapter.SelectCommand = command;

        DbCommandBuilder builder = factory.CreateCommandBuilder();
        builder.DataAdapter = adapter;

        adapter.InsertCommand = builder.GetInsertCommand();
        adapter.UpdateCommand = builder.GetUpdateCommand();
        adapter.DeleteCommand = builder.GetDeleteCommand();
        
        DataTable people = new DataTable("People");
        adapter.Fill(people);
        print(people);

        people.Rows.Add(23, "Albert");
        print(people);
        Console.ReadKey();
        adapter.Update(people);

        foreach (DataRow row in people.Select("id = 23")) row.Delete();
        print(people);
        Console.ReadKey();
        adapter.Update(people);

        }
      Console.ReadKey();
      }
    
    }
  
  }
