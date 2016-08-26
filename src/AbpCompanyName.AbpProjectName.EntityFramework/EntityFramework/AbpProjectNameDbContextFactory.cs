using AbpCompanyName.AbpProjectName.Configuration;
using AbpCompanyName.AbpProjectName.Web;
using Microsoft.Extensions.Configuration;
using System.Data.Entity.Infrastructure;

namespace AbpCompanyName.AbpProjectName.EntityFramework
{
    /* This class is needed to run "EntityFramework\Enable-Migrations ..." commands from command line on development. Not used anywhere else */
    public class AbpProjectNameDbContextFactory : IDbContextFactory<AbpProjectNameDbContext>
    {
        public AbpProjectNameDbContext Create()
        {
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());
            var connectionString = configuration.GetConnectionString(AbpProjectNameConsts.ConnectionStringName);

            return new AbpProjectNameDbContext(connectionString);
        }
    }
}