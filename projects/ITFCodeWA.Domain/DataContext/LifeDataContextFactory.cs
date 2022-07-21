using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ITFCodeWA.Domain.DataContext
{
    /// <summary>
    /// The ContextFactory class using only 
    /// Microsoft EntityFramework Tools
    /// for execute developers database migration commands
    /// </summary>
    public class LifeDataContextFactory : IDesignTimeDbContextFactory<LifeDataContext>
    {
        public LifeDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LifeDataContext>();

            // GetById config from appsettings.json
            ConfigurationBuilder builder = new();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();

            // GetById connection string from appsettings.json
            string connectionString = config.GetConnectionString("LifeDataContextConnection");
            optionsBuilder.UseSqlServer(connectionString, opts =>
            {
                opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds);

            });

            return new LifeDataContext(optionsBuilder.Options);
        }
    }
}
