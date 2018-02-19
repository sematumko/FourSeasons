using FourSeasons.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSeasons.dbContexts
{
    public class FourSeasonsContext : DbContext
    {
        public FourSeasonsContext(DbContextOptions<FourSeasonsContext> options)
            : base(options)
        { }

        public DbSet<News> NewsSet { get; set; }
        public DbSet<GalleryPhoto> GallerySet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().ToTable("News");
            modelBuilder.Entity<GalleryPhoto>().ToTable("GalleryPhoto");
        }

    }

}
