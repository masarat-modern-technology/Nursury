using NurseryAppDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NurseryAppDemo.Permissions;

public class NurseryAppDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NurseryAppDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NurseryAppDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NurseryAppDemoResource>(name);
    }
}
