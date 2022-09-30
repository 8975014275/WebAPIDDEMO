using Microsoft.EntityFrameworkCore;
using WebAPIDDEMO.Models;

namespace WebAPIDDEMO.Entities
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
