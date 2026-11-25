using NurseryAppDemo.Samples;
using Xunit;

namespace NurseryAppDemo.EntityFrameworkCore.Domains;

[Collection(NurseryAppDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<NurseryAppDemoEntityFrameworkCoreTestModule>
{

}
