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
        public DbSet<Customers> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Types { get; set; }
        public DbSet<StoreInvoicing> Factors { get; set; }
        #endregion
    }
}
