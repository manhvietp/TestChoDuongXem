using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestChoDuongXem.Configuration;
using TestChoDuongXem.Entity;

namespace TestChoDuongXem.MyDBContext
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
          
        }
        public DbSet<User> users { get; set; }
    }
}
