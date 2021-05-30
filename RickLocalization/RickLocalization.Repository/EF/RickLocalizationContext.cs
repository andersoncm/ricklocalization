using Microsoft.EntityFrameworkCore;
using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RickLocalization.Repository.EF
{
    public class RickLocalizationContext : DbContext
    {
        public RickLocalizationContext(DbContextOptions<RickLocalizationContext> options) : base(options)
        {

        }

        public virtual DbSet<Rick> Ricks { get; set; }
        public virtual DbSet<Dimensao> Dimensoes { get; set; }
        public virtual DbSet<Viagem> Viagens { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
