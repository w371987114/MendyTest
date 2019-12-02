using Mendy.Test.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Mendy.Test.Permissions
{
    public class TestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(TestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TestResource>(name);
        }
    }
}
