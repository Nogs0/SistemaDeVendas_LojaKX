using Microsoft.EntityFrameworkCore;
using Sistema_lojaKX.Data.Map;
using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Data
{
    public class PurchaseSystemDBcontext : DbContext
    {
        public PurchaseSystemDBcontext(DbContextOptions<PurchaseSystemDBcontext> options) : base(options)
        {
        }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<PurchaseModel> Purchases { get; set; }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new PurchaseMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
