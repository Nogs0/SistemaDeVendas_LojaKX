using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Data.Map
{
    public class ProductMap : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.HasKey(x => x.Id_Product);
            builder.Property(x => x.Name_Product);
            builder.Property(x => x.Value_Product);
        }
    }
}
