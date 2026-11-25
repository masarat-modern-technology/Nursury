using Volo.Abp.Settings;

namespace NurseryAppDemo.Settings;

public class NurseryAppDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NurseryAppDemoSettings.MySetting1));
    }
}
