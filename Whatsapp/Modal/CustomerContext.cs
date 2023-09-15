using System.Data.Entity;

namespace Whatsapp.Modal
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("Customer")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
