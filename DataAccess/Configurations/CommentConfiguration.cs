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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x=>x.VideoId).IsRequired();
            builder.Property(x=>x.NumOfLike).HasDefaultValue(0);
            builder.Property(x=> x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.CreatedBy).IsRequired();
        }
    }
}
