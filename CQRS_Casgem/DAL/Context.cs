using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Casgem.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MONSTER\\SQLEXPRESS; initial catalog=CasgemmCQRSDb;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
