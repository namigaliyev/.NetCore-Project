using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NewsSystem.Data.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;

namespace NewsSystem.Data.DataContext
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions < NewsContext > options): base(options) {}
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<Image> Images { get; set; }

    }
}
