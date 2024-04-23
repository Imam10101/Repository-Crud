using Microsoft.EntityFrameworkCore;

namespace RepositoryCrud.Models
{
    public class DbEmployee:DbContext
    {
        public DbEmployee(DbContextOptions<DbEmployee> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
