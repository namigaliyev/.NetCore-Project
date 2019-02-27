<<<<<<< HEAD
=======
using System.IO;
>>>>>>> 8c2dd74f6bf7b628cc081114ca58de1060e0108d
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NewsSystem.Data.DataContext;
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> 8c2dd74f6bf7b628cc081114ca58de1060e0108d

namespace NewsSystem.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<NewsContext>
    {
        public NewsContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
<<<<<<< HEAD
            var builder = new DbContextOptionsBuilder<NewsContext>();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseMySql(connectionString);
=======

            var builder = new DbContextOptionsBuilder<NewsContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

>>>>>>> 8c2dd74f6bf7b628cc081114ca58de1060e0108d
            return new NewsContext(builder.Options);
        }
    }
}