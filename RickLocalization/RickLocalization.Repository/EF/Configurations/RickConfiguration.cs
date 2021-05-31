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

            builder
                .Property(a => a.Nome)
                .HasColumnType("varchar").HasMaxLength(50).IsRequired();

            builder
               .Property(a => a.Foto)
               .HasColumnType("varchar(MAX)").IsRequired();


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
       .HasOne(e => e.Dimensao)
       .WithMany(c => c.Rickis)
       .HasForeignKey(a => a.DimensaoId).OnDelete(DeleteBehavior.NoAction)


       ;



        }
    }
}
