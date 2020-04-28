using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.Configurations
{
    public class ReceiverConfiguration : IEntityTypeConfiguration<Receiver>
    {
        public void Configure(EntityTypeBuilder<Receiver> builder)
        {
            builder.HasKey(r => r.ReceiverId);
            builder
                .HasOne(r => r.District)
                .WithMany(r => r.Receivers)
                .HasForeignKey(r => r.District_id);
            builder
                .HasOne(r => r.Aumphure)
                .WithMany(r => r.Receivers)
                .HasForeignKey(r => r.Aumphure_id);
            builder
                .HasOne(r => r.Province)
                .WithMany(r => r.Receivers)
                .HasForeignKey(r => r.Province_id);
        }
    }
}
