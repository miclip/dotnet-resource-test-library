using System;
using Xunit;
using DotnetResource.TestLibraryOne;

namespace DotnetResource.TestLibraryOne.Tests
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
