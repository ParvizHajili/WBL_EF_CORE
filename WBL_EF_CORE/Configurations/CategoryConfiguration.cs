using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WBL_EF_CORE.Models;

namespace WBL_EF_CORE.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.Property(x => x.Id)
                .UseIdentityColumn(seed: 1000, increment: 1);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(x => x.Name)
                .HasDatabaseName("idx_Category_Name");

            builder.Property(x => x.IsDeleted)
               .HasDefaultValue<int>(0);


            builder.HasIndex(x => new { x.Name, x.IsDeleted })
                .IsUnique()
                .HasDatabaseName("idx_Category_Name_IsDeleted");
        }
    }
}
