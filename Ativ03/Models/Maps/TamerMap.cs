using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Ativ03.Models.Maps
{
    public class TamerMap : EntityTypeConfiguration<Tamer>
    {
        public TamerMap()
        {
            this.ToTable("Tamer");
            this.HasKey(x => x.Id);
            this.Property(x => x.Name).IsRequired().HasColumnName("Name").HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.Age).IsRequired().HasColumnName("Age").HasColumnType("int");
            this.Property(x => x.Nationality).IsRequired().HasColumnName("Nationality").HasColumnType("varchar").HasMaxLength(30);
        }
    }
}