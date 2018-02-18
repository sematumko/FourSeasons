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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().ToTable("News");
        }

        /*public List<News> getAll()
        {
            List<News> nl = new List<News>();

            foreach (News element in NewsSet)
                nl.Add(element);

            return nl;
        }
        */

    }

}
