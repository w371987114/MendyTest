using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mendy.Test.Data
{
    /* This is used if database provider does't define
     * ITestDbSchemaMigrator implementation.
     */
    public class NullTestDbSchemaMigrator : ITestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}