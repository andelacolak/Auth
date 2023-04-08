using Auth.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Auth.API
{
    //Identity - lib that will handle all auth related db tables such as users, roles, tokens and such
    public class Context: IdentityDbContext<User>
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        //EF does not support multiple contexts at the time
        //IdentityDbContext needs a default empty constructor 
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        //Idenitity needs this. Don't know why cause con str is already defined in program.cs
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(
            "Server=DESKTOP-J7KV9IS\\SQLEXPRESS;Database=Test;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
