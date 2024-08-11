﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlakDukkaniYoneticiModulu.DAL;

#nullable disable

namespace MaratonUygulama.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240630114455_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MaratonUygulama.DATA.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("AddedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Kullanıcı Adı");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Şifre");

                    b.Property<string>("SifreKontrol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Yöneticiler", (string)null);
                });

            modelBuilder.Entity("MaratonUygulama.DATA.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("AddedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("AlbumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Albüm Adı");

                    b.Property<DateTime>("CikisTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("Çıkış Tarihi Adı");

                    b.Property<decimal>("Fiyati")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Fiyatı");

                    b.Property<int?>("IndirimOrani")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sanatci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SatisDurumu")
                        .HasColumnType("int")
                        .HasColumnName("Satış Durumu");

                    b.HasKey("ID");

                    b.ToTable("Albümler", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
