using FluentApiConfiguringRelations.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace FluentApiConfiguringRelations.Core.Repository
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
       public DbSet<EmployeeDetails> EmployeesDetails { get; set; }
    }
}
