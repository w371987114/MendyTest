using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mendy.Test.Pages
{
    public class Index_Tests : TestWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
