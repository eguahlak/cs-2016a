using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPets.Model {
  
  public class PetClubContext : DbContext {
    public static string CONN =
    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PETSDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";    
    //@"Data Source=(localdb)\mssqllocaldb;Integrated Security=True";  

    public PetClubContext() : base(CONN) {

      }  

    public DbSet<Pet> Pets { get; set; }
    public DbSet<Club> Clubs { get; set; }
    }

  }
