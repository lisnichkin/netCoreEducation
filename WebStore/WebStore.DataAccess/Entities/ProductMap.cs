using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebStore.DataAccess.Entities
{
    class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(256).IsRequired();
            builder.Property(x => x.Description).HasColumnName("Description").HasMaxLength(2000);
            builder.Property(x => x.Price).HasColumnName("Price").IsRequired();
            builder.Property(x => x.Category).HasColumnName("Category").IsRequired();
        }
    }
}
