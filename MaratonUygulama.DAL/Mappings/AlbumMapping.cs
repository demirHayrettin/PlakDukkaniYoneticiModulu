using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDukkaniYoneticiModulu.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu.DAL.Mappings
{
    internal class AlbumMapping : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {


            builder.ToTable("Albümler");

            builder.Property(x => x.AlbumAdi).IsRequired().HasColumnName("Albüm Adı");
            builder.Property(x => x.CikisTarihi).IsRequired().HasColumnName("Çıkış Tarihi Adı");
            builder.Property(x => x.Fiyati).IsRequired().HasColumnName("Fiyatı");
            builder.Property(x => x.SatisDurumu).IsRequired().HasColumnName("Satış Durumu");

        }
    }
}
