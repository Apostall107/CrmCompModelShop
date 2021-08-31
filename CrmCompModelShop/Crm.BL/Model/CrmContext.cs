using System.Data.Entity;

namespace Crm.BL.Model
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("ConnectionStringCrmShopTest")
        {
        }

        public DbSet<Selling> Sellings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}