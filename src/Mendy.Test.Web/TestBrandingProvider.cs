using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Mendy.Test.Web
{
    [Dependency(ReplaceServices = true)]
    public class TestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Test";
    }
}
