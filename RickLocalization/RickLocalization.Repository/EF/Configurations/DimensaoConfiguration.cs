using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Repository.EF.Configurations
{
    public class DimensaoConfiguration : IEntityTypeConfiguration<Dimensao>
    {
        public void Configure(EntityTypeBuilder<Dimensao> builder)
        {
            builder
               .ToTable("Dimensao", "dbo")
               .HasKey(e => e.DimensaoId);
        }
    }
}
