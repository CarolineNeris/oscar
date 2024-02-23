using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }
        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
        public DbSet<MvcMovie.Models.User> User {get; set; } = default!;

        public DbSet<MvcMovie.Models.Studio> Studio {get; set; } = default!;

        public DbSet<MvcMovie.Models.Artist> Artist {get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasMany(m => m.Artists).WithMany(a => a.Movies);
            modelBuilder.Entity<Movie>().HasOne<Studio>(m => m.Studio).WithMany(a => a.Movies).HasForeignKey(m => m.StudioId);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MvcMovieContext).Assembly);
        }
    }
}
