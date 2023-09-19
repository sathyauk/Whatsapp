using Microsoft.EntityFrameworkCore;

namespace Whatsapp.Modal
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() { }

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options){}

        
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Message;TrustServerCertificate=True;Trusted_Connection=True", builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}
