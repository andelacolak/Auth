using Auth.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Net;

namespace Auth.API
{
    public class Context: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
    }
}
