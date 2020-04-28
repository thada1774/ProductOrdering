using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.Configurations
{
    public class OrderingConfiguration : IEntityTypeConfiguration<Ordering>
    {
        public void Configure(EntityTypeBuilder<Ordering> builder)
        {
            builder.HasKey(o => o.OrderingId);
            builder.HasOne(o => o.Product)
                .WithMany(o => o.Orderings)
                .HasForeignKey(o => o.ProductId);
            builder.HasOne(o => o.ApplicationUser)
                .WithMany(o => o.Orderings)
                .HasForeignKey(o => o.UserId);
            builder.HasOne(o => o.Receiver)
                .WithOne(o => o.Ordering)
                .HasForeignKey<Receiver>(o => o.OrderingId);

        }
    }
}
