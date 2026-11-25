using NurseryAppDemo.Samples;
using Xunit;

namespace NurseryAppDemo.EntityFrameworkCore.Applications;

[Collection(NurseryAppDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<NurseryAppDemoEntityFrameworkCoreTestModule>
{

}
