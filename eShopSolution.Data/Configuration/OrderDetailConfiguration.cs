using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");

            builder.HasKey(x => new { x.OrderId, x.ProductId });

            builder.HasOne(x => x.Order).WithMany(od => od.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            builder.HasOne(x => x.Order).WithMany(od => od.OrderDetails)
              .HasForeignKey(od => od.ProductId);
        }
    }
}
