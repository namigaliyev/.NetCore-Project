using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NewsSystem.Data.Models;

namespace NewsSystem.Data.DataContext
{
    public class NewsContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }
    }
}
