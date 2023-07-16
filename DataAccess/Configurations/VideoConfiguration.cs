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
    public class VideoConfiguration : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Thumbnail).IsRequired();
            builder.Property(x => x.NumOfLike).HasDefaultValue(0);
            builder.Property(x => x.NumOfDisLike).HasDefaultValue(0);
            builder.Property(x => x.NumOfView).HasDefaultValue(0);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).IsRequired();
        }
    }
}
