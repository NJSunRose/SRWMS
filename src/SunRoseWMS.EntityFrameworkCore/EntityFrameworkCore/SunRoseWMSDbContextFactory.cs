using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SunRoseWMS.Configuration;
using SunRoseWMS.Web;

namespace SunRoseWMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SunRoseWMSDbContextFactory : IDesignTimeDbContextFactory<SunRoseWMSDbContext>
    {
        public SunRoseWMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SunRoseWMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SunRoseWMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SunRoseWMSConsts.ConnectionStringName));

            return new SunRoseWMSDbContext(builder.Options);
        }
    }
}
