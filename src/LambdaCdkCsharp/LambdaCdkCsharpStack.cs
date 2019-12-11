using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;

namespace LambdaCdkCsharp
{
    public class LambdaCdkCsharpStack : Stack
    {
        internal LambdaCdkCsharpStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            Function fn = new Function(this, "myfunction", new FunctionProps
            {
                Runtime = Runtime.DOTNET_CORE_2_1,
                Code = Code.FromAsset("./HelloFunction/src/HelloFunction/bin/Release/netcoreapp2.1/publish"),
                Handler = "HelloFunction::HelloFunction.Function::FunctionHandler"
            });
        }
    }
}
