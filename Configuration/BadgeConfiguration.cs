using EFCoreAssignment02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment02.Configuration
{
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.BadgeNumber)
                .HasMaxLength(20)
                .IsRequired(true);

            builder.Property(e => e.IssueDate)
                .IsRequired(true);

            builder.Property(e => e.Tier)
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsRequired(true);


        }
    }
}
