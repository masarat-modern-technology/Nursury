using Xunit;

namespace NurseryAppDemo.EntityFrameworkCore;

[CollectionDefinition(NurseryAppDemoTestConsts.CollectionDefinitionName)]
public class NurseryAppDemoEntityFrameworkCoreCollection : ICollectionFixture<NurseryAppDemoEntityFrameworkCoreFixture>
{

}
