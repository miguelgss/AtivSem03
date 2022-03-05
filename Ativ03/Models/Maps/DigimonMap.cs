using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Ativ03.Models.Maps
{
    public class DigimonMap : EntityTypeConfiguration<Digimon>
    {
        public DigimonMap()
        {
            this.ToTable("Digimon");
            this.HasKey(x => x.Id);
            this.Property(x => x.Name).IsRequired().HasColumnName("Name").HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.Stage).IsRequired().HasColumnName("Stage").HasColumnType("varchar").HasMaxLength(20);
            this.Property(x => x.Type).IsRequired().HasColumnName("Type").HasColumnType("varchar").HasMaxLength(30);
        }
    }
}