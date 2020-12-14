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
        public DbSet<UsersEnt> Users { get; set; }
        public DbSet<ProductsEnt> Products { get; set; }
        public DbSet<TypesEnt> Types { get; set; }
        public DbSet<FactorsEnt> Factors { get; set; }
        #endregion
    }
}
