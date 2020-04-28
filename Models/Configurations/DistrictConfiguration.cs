using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.Configurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(d => d.Id);
            builder
                .HasOne(d => d.Aumphure)
                .WithMany(d => d.Districts)
                .HasForeignKey(d => d.Aumphure_id);
        }
    }
}
