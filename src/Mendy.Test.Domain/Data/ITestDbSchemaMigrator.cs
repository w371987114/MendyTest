using System.Threading.Tasks;

namespace Mendy.Test.Data
{
    public interface ITestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
