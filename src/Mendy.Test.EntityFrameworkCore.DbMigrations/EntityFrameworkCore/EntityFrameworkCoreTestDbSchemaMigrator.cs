using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mendy.Test.Data;
using Volo.Abp.DependencyInjection;

namespace Mendy.Test.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreTestDbSchemaMigrator 
        : ITestDbSchemaMigrator, ITransientDependency
    {
        private readonly TestMigrationsDbContext _dbContext;

        public EntityFrameworkCoreTestDbSchemaMigrator(TestMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}