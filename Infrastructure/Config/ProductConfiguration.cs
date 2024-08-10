using System.Security.Cryptography.X509Certificates;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(40);
            builder.Property(x => x.Description)
                .HasMaxLength(60);
            builder.Property(x => x.PictureUrl)
                .HasMaxLength(255);
            builder.Property(x => x.Type)
                .HasMaxLength(35);
            builder.Property(x => x.Brand)
               .HasMaxLength(35);
        }
    }
}