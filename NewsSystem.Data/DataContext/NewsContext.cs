using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NewsSystem.Data.Models;

namespace NewsSystem.Data.DataContext
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions < NewsContext > options): base(options) {}
        public DbSet<User> Users { get; set;}

        public DbSet<Role> Roles { get; set;}
    }
}
