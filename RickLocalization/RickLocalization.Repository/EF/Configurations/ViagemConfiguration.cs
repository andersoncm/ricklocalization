using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Repository.EF.Configurations
{
    public class ViagemConfiguration : IEntityTypeConfiguration<Viagem>
    {
        public void Configure(EntityTypeBuilder<Viagem> builder)
        {
            builder
               .ToTable("Viagem", "dbo")
               .HasKey(e => e.ViagemId);

            builder
             .Property(a => a.Motivo)
             .HasColumnType("varchar").HasMaxLength(50);

            builder
             .Property(a => a.DataViagem)
             .HasColumnType("datetime").IsRequired();

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



            builder
            .HasOne(e => e.Rick)
            .WithMany(c => c.Viagens)
      .HasForeignKey(a => a.RickId).OnDelete(DeleteBehavior.NoAction);


            builder
                  .HasOne(e => e.Dimensao)
                  .WithMany(c => c.Viagens)
            .HasForeignKey(a => a.DimensaoId).OnDelete(DeleteBehavior.NoAction);


      

        }
    }
}
