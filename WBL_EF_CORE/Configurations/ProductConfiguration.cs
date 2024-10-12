using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WBL_EF_CORE.Models;

namespace WBL_EF_CORE.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.Property(x => x.Id)
                .UseIdentityColumn(seed: 1000, increment: 1);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue<int>(0);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId)
                .HasConstraintName("fk_Product_CategoryId");

            builder.HasIndex(x => x.Name)
                .HasDatabaseName("idx_Product_Name");

            builder.HasIndex(x => new { x.Name, x.IsDeleted })
                .IsUnique()
                .HasDatabaseName("idx_Product_Name_IsDeleted");
        }
    }
}
