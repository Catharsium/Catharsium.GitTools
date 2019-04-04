using Catharsium.GitTools.Core.Entities.Commands.Git.Atomic;
using Catharsium.Util.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catharsium.GitTools.Core.Entities.Tests.Commands.Git.Atomic
{
    [TestClass]
    public class GitPushCommandTests : TestFixture<GitPushCommand>
    {
        [TestMethod]
        public void GetCommands_NoParameters_ReturnsPushCommandWithoutArguments()
        {
            var options = new GitPushCommandOptions();
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("git push", actual[0]);
        }


        [TestMethod]
        public void GetCommands_AllFlag_IncludesAllArgument()
        {
            var options = new GitPushCommandOptions {All = true};
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("git push --all", actual[0]);
        }


        [TestMethod]
        public void GetCommands_RemoteName_IncludesRemoteArgument()
        {
            var options = new GitPushCommandOptions { Remote = "MyRemoteName" };
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual($"git push {options.Remote}", actual[0]);
        }
    }
}