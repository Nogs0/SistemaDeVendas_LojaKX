using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Map
{
    public class PurchaseMap: IEntityTypeConfiguration<PurchaseModel>
    {
        public void Configure(EntityTypeBuilder<PurchaseModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(15);            
            builder.Property(x => x.Value).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Product).HasMaxLength(100);
        }
    }
}
