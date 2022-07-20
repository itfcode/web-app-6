using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ITFCodeWA.Domain.DataContext
{
    internal class DataContextFactory
    {
        /// <summary>
        /// The ContextFactory class using only 
        /// Microsoft EntityFramework Tools
        /// for execute developers database migration commands
        /// </summary>
        public class EBaseAccountantDocsContextFactory : IDesignTimeDbContextFactory<DataContext>
        {
            public DataContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

                // Get config from appsettings.json
                ConfigurationBuilder builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json");
                IConfigurationRoot config = builder.Build();

                // Get connection string from appsettings.json
                string connectionString = config.GetConnectionString("EBaseAccountantDocsConnection");
                optionsBuilder.UseSqlServer(connectionString, opts =>
                {
                    opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds);

                });

                return new DataContext(optionsBuilder.Options);
            }
        }
    }
}
