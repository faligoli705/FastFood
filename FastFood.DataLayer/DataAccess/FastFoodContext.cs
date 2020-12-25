using FastFood.DomainClass.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastFood.DataLayer.DataAccess
{
    public class FastFoodContext : DbContext
    {
        public FastFoodContext(DbContextOptions<FastFoodContext> options):base(options)
        {

        }
        #region Table
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<StoreInvoicing> StoreInvoicings { get; set; }
        public DbSet<StoreInvoicingDetails> StoreInvoicingDetails { get; set; }
        #endregion
    }
}
