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
    internal class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Biography)
                  .HasMaxLength(100);

            builder.Property(p => p.Website)
                  .HasMaxLength(250);

            builder.Property(p => p.Logo)
                  .HasMaxLength(250);


        }
    }
}
