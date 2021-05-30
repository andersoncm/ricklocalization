using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Repository.EF.Configurations
{
    public class RickConfiguration : IEntityTypeConfiguration<Rick>
    {
        public void Configure(EntityTypeBuilder<Rick> builder)
        {
            builder
                .ToTable("Rick", "dbo")
                .HasKey(e => e.RickId);
        }
    }
}
