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
        public DbSet<Comment> CommentsSet { get; set; }
        public DbSet<Contacts> ContactsSet { get; set; }
        public DbSet<Room> RoomsSet { get; set; }
        public DbSet<TotalPrice> TotalPriceSet { get; set; }
        public DbSet<Booking> BookingSet { get; set; }
        public DbSet<Comfort> ComfortsSet { get; set; }
        public DbSet<Food> FoodSet { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().ToTable("News");
            modelBuilder.Entity<GalleryPhoto>().ToTable("GalleryPhoto");
            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Contacts>().ToTable("Contacts");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<TotalPrice>().ToTable("TotalPrice");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Comfort>().ToTable("Comforts");
            modelBuilder.Entity<Food>().ToTable("Food");

        }

    }

}
