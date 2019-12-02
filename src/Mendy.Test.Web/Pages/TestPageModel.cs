using Mendy.Test.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mendy.Test.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class TestPageModel : AbpPageModel
    {
        protected TestPageModel()
        {
            LocalizationResourceType = typeof(TestResource);
        }
    }
}