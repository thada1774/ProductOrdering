using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.Configurations
{
    public class UserDetailConfiguration : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.HasKey(ud => ud.UserDetailId);
            builder
                .HasOne(ud => ud.District)
                .WithMany(ud => ud.UserDetails)
                .HasForeignKey(ud => ud.District_id);
            builder
                .HasOne(ud => ud.Aumphure)
                .WithMany(ud => ud.UserDetails)
                .HasForeignKey(ud => ud.Aumphure_id);
            builder
                .HasOne(ud => ud.Province)
                .WithMany(ud => ud.UserDetails)
                .HasForeignKey(ud => ud.Province_id);
            builder.HasOne(ud => ud.ApplicationUser)
                .WithOne(ud => ud.UserDetail)
                .HasForeignKey<UserDetail>(ud => ud.UserId);

        }
    }
}
