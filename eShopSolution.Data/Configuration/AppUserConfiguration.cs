using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUser");

            builder.Property(x => x.FirstName)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.LastName)
             .HasMaxLength(200)
             .IsRequired();

            builder.Property(x => x.Dob)
                .IsRequired();
        }
    }
}
