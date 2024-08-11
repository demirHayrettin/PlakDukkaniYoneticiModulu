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
    internal class AdminMapping : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Yöneticiler");
            builder.Property(x => x.KullaniciAdi).IsRequired().HasColumnName("Kullanıcı Adı");
            builder.Property(x => x.Sifre).IsRequired().HasColumnName("Şifre");

        }
    }
}
