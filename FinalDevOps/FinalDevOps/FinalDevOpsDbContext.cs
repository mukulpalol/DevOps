using FinalDevOps.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalDevOps
{
    public class FinalDevOpsDbContext : DbContext
    {
        public FinalDevOpsDbContext(DbContextOptions<FinalDevOpsDbContext> options) : base(options)
        {            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
