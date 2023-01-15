using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Data.Map
{
    public class PurchaseMap : IEntityTypeConfiguration<PurchaseModel>
    {
        public void Configure(EntityTypeBuilder<PurchaseModel> builder)
        {
            builder.HasKey(x => x.Id_Purchase);
            builder.Property(x => x.Id_Product).IsRequired();
            builder.Property(x => x.Id_Client).IsRequired();
        }
    }
}
