using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NewsSystem.Data.DataContext;
using System.IO;

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
            var builder = new DbContextOptionsBuilder<NewsContext>();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseMySql(connectionString);
            return new NewsContext(builder.Options);
        }
    }
}