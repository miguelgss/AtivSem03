using Ativ03.Models.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ativ03.Models
{
    public class DigiContext : DbContext
    {
        public DigiContext() : base("connectionDB") { }
        public DbSet <Digimon> Digimons { get; set; }
        public DbSet <Tamer> Tamers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DigiContext>(null);
            modelBuilder.Configurations.Add(new DigimonMap());
            modelBuilder.Configurations.Add(new TamerMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}