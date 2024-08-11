using PlakDukkaniYoneticiModulu.DAL.Mappings;
using Microsoft.EntityFrameworkCore;
using PlakDukkaniYoneticiModulu.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Album> Albumler { get; set; }
        public DbSet<Admin> Adminler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=E;Initial Catalog=HS15-MaratonDB;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AlbumMapping().Configure(modelBuilder.Entity<Album>());
            new AdminMapping().Configure(modelBuilder.Entity<Admin>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
