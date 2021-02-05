using Microsoft.EntityFrameworkCore;
using Stellvia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stellvia.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
             : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTags> PostTags { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagCategory> TagCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserConnect> UserConnects { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<UserStat> UserStats { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
