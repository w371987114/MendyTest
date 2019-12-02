using Volo.Abp.Modularity;

namespace Mendy.Test
{
    [DependsOn(
        typeof(TestApplicationModule),
        typeof(TestDomainTestModule)
        )]
    public class TestApplicationTestModule : AbpModule
    {

    }
}