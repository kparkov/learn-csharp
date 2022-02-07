using System;
using Xunit;
using Xunit.Abstractions;

namespace KVP.LearnCSharp.Strings;

public class Tests
{
    private ITestOutputHelper Output { get; }

    public Tests(Xunit.Abstractions.ITestOutputHelper output)
    {
        Output = output;
    }
    
    [Fact]
    public void Some()
    {
        WriteObject(true == false);
        WriteObject("Æble".Equals("æble", StringComparison.CurrentCulture));
        Assert.Equal(1, 1);
    }

    private void WriteObject(object o)
    {
        Output.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(o));
    }
}