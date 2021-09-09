using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");

            builder.HasKey(x => new { x.ProductId, x.CategoryId });

            builder.HasOne(x => x.Product).WithMany(pc => pc.ListProductInCategories)
                .HasForeignKey(pc => pc.ProductId);

            builder.HasOne(x => x.Category).WithMany(pc => pc.ListProductInCategories)
              .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
