using System.Collections.Generic;
using System.Linq;
using Catharsium.GitTools.Core.Entities.Commands;
using Catharsium.Util.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catharsium.GitTools.Core.Entities.Tests.Commands
{
    [TestClass]
    public class AddCommandTests : TestFixture<AddCommand>
    {
        [TestMethod]
        public void GetCommands_ListOfFiles()
        {
            var options = new AddCommandOptions
            {
                Files = new List<string> { "My file 1", "My file 2" }
            };
            this.SetDependency(options);

            var actual = this.Target.GetCommands();
            Assert.AreEqual(options.Files.Count(), actual.Count);
            foreach (var file in options.Files)
            {
                actual.Contains("git add " + file);
            }
        }
    }
}