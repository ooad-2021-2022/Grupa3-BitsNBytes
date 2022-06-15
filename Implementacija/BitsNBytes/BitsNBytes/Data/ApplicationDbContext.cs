using BitsNBytes.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitsNBytes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artikal> Artikal { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Komentar> Komentar { get; set; }

        public DbSet<Kategorija> Kategorija { get; set; }
        public DbSet<Pošiljka> Pošiljka { get; set; }
        public DbSet<Notifikacija> Notifikacija { get; set; }

        public DbSet<SpašeniArtikal> SpašeniArtikal { get; set; }

        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikal>().ToTable("Artikal");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Komentar>().ToTable("Komentar");
            modelBuilder.Entity<Kategorija>().ToTable("Kategorija");
            modelBuilder.Entity<Pošiljka>().ToTable("Pošiljka");
            modelBuilder.Entity<Notifikacija>().ToTable("Notifikacija");
            modelBuilder.Entity<SpašeniArtikal>().ToTable("SpašeniArtikal");
            modelBuilder.Entity<Status>().ToTable("Status");
            base.OnModelCreating(modelBuilder);
        }


    }
}
