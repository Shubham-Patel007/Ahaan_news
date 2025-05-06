using System;
using AhaanNews.Models;
using Microsoft.EntityFrameworkCore;

namespace AhaanNews.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Video> Vidoes { get; set; }
        public DbSet<UserLikedNews> UserLikedNews { get; set; }
        public DbSet<UserBookmarkedNews> UserBookmarkedNews { get; set; }
        public DbSet<NewsVideo> NewsVideos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserLikedNews>().HasKey(x => new { x.UId, x.NewsId });
            modelBuilder.Entity<UserBookmarkedNews>().HasKey(x => new { x.UId, x.NewsId });
            modelBuilder.Entity<NewsVideo>().HasKey(x => new { x.NewsId, x.VideoId });

            modelBuilder.Entity<User>().HasIndex(u => u.PhoneNumber).IsUnique();
        }
    }
}
