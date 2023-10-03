using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Whatsapp.Modal
{
    public class CustomerContext : DbContext
    {

        private readonly IConfiguration _configuration;
        public CustomerContext() { }

        public CustomerContext(DbContextOptions<CustomerContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=localhost;Database=Message;TrustServerCertificate=True;Trusted_Connection=True", builder =>
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"), builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}
