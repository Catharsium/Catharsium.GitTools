using Catharsium.GitTools.Core.Entities.Commands.Git.Atomic;
using Catharsium.Util.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catharsium.GitTools.Core.Entities.Tests.Commands.Git.Atomic
{
    [TestClass]
    public class GitCommitCommandTests : TestFixture<GitCommitCommand>
    {
        [TestMethod]
        public void GetCommands_NoParameters_ReturnsPushCommandWithoutArguments()
        {
            var options = new GitCommitCommandOptions();
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("git commit", actual[0]);
        }


        [TestMethod]
        public void GetCommands_StageFlag_IncludesAllArgument()
        {
            var options = new GitCommitCommandOptions { Stage = true };
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("git commit --all", actual[0]);
        }


        [TestMethod]
        public void GetCommands_Message_IncludesMessageArgument()
        {
            var options = new GitCommitCommandOptions { Message = "My message" };
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual($"git commit -m \"{options.Message}\"", actual[0]);
        }
    }
}