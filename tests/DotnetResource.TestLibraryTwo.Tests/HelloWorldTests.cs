using System;
using Xunit;
using DotnetResource.TestLibraryTwo;

namespace DotnetResource.TestLibraryTwo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void HelloRespondsWithName()
        {
            var helloWorld = new HelloWorld();
            Assert.Contains("Mike", helloWorld.Hello("Mike"));
        }
    }
}
