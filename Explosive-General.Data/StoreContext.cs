using Explosive.General.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Explosive.General.Domain.Orders;


namespace Explosive.General.Data
{

    public class StoreContext : DbContext
    {
        public StoreContext(){

        }
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
            { }
        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; } 
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}
