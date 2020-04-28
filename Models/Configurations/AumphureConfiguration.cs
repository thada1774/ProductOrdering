using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.Configurations
{
    public class AumphureConfiguration : IEntityTypeConfiguration<Aumphure>
    {
        public void Configure(EntityTypeBuilder<Aumphure> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasOne(d => d.Province)
                .WithMany(d => d.Aumphures)
                .HasForeignKey(d => d.Province_id);
        }
    }
}
