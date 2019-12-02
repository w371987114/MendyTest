using Mendy.Test.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Mendy.Test
{
    [DependsOn(
        typeof(TestEntityFrameworkCoreTestModule)
        )]
    public class TestDomainTestModule : AbpModule
    {

    }
}