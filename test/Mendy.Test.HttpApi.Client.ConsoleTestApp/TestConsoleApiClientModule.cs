using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Mendy.Test.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(TestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class TestConsoleApiClientModule : AbpModule
    {
        
    }
}
