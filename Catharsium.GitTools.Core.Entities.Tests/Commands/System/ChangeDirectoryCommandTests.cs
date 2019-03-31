using Catharsium.GitTools.Core.Entities.Commands.System;
using Catharsium.Util.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catharsium.GitTools.Core.Entities.Tests.Commands.System
{
    [TestClass]
    public class ChangeDirectoryCommandTests : TestFixture<ChangeDirectoryCommand>
    {
        [TestMethod]
        public void GetCommands_SpecifiedDirectory_ReturnsCorrectCommand()
        {
            var options = new ChangeDirectoryCommandOptions
            {
                Directory = "My directory"
            };
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual($"cd \"{options.Directory}\"", actual[0]);
        }
    }
}