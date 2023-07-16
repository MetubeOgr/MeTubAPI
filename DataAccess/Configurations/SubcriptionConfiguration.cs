using MeTubApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeTubApi.Data.Configurations
{
    public class SubcriptionConfiguration : IEntityTypeConfiguration<Subcription>
    {
        public void Configure(EntityTypeBuilder<Subcription> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ChannelId).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.Notification).HasDefaultValue(true);
        }
    }
}
