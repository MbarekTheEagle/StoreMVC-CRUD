using Microsoft.EntityFrameworkCore;
using StoreMVC.Models;

namespace StoreMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        //this code defines a class that represents the application's database context,
        //allowing it to interact with the underlying database using Entity Framework Core.
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //Property that add a table in model for us it is called Product to the database
        public DbSet<Product> Products { get; set; }
    }
}
