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

            builder
             .Property(a => a.Descricao)
             .HasColumnType("varchar").HasMaxLength(50).IsRequired();

            builder
              .Property(a => a.DataInclusao)
              .HasColumnType("datetime");

            builder
              .Property(a => a.DataOperacao)
              .HasColumnType("datetime").IsRequired();

            builder
             .Property(a => a.NaturezaOperacao)
             .HasColumnType("char")
             .HasMaxLength(1).IsRequired();


        }
    }
}
