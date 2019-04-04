using System.Collections.Generic;
using Catharsium.GitTools.Core.Entities.Commands.Git.Atomic;
using Catharsium.Util.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catharsium.GitTools.Core.Entities.Tests.Commands.Git.Atomic
{
    [TestClass]
    public class GitAddCommandTests : TestFixture<GitAddCommand>
    {
        [TestMethod]
        public void GetCommands_NoFiles_ReturnsAddCommandWithWildcard()
        {
            var options = new GitAddCommandOptions();
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("git add *", actual[0]);
        }


        [TestMethod]
        public void GetCommands_SingleFile_ReturnsCorrectAddCommand()
        {
            var options = new GitAddCommandOptions
            {
                Files = new List<string> { "My file" }
            };
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual($"git add \"{options.Files[0]}\"", actual[0]);
        }


        [TestMethod]
        public void GetCommands_ListOfFiles_ReturnsAddCommandForEachFile()
        {
            var options = new GitAddCommandOptions
            {
                Files = new List<string> { "My file 1", "My file 2" }
            };
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(options.Files.Count, actual.Count);
            foreach (var file in options.Files)
            {
                Assert.IsTrue(actual.Contains($"git add \"{file}\""));
            }
        }


        [TestMethod]
        public void GetCommands_ForceIsTrue_ReturnsCommandContainingForceFlag()
        {
            var options = new GitAddCommandOptions
            {
                Files = new List<string> { "My file" },
                Force = true
            };
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(1, actual.Count);
            Assert.IsTrue(actual[0].Contains(" -f"));
        }
    }
}