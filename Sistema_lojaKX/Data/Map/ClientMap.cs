using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Data.Map
{
    public class ClientMap : IEntityTypeConfiguration<ClientModel>
    {
        public void Configure(EntityTypeBuilder<ClientModel> builder)
        {
            builder.HasKey(x => x.Id_Client);
            builder.Property(x => x.Cpf).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Name_Client).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(20);
        }
    }
}
