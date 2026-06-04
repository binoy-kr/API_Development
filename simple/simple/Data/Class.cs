using Microsoft.EntityFrameworkCore;
using simple.Entityes;

namespace simple.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<user> AccountUser { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
