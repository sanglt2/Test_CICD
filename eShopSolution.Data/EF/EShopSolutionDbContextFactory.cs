using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace eShopSolution.Data
{
    public class EShopSolutionDbContextFactory : IDesignTimeDbContextFactory<EShopDBContext>
    {
        public EShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionstring = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<EShopDBContext>();
            optionsBuilder.UseSqlServer(connectionstring);

            return new EShopDBContext(optionsBuilder.Options);
        }
    }
}
