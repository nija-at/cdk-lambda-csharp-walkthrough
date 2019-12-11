using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaCdkCsharp
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new LambdaCdkCsharpStack(app, "LambdaCdkCsharpStack");
            app.Synth();
        }
    }
}
