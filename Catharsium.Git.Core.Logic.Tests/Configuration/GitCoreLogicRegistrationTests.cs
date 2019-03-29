using Catharsium.Git.Core.Logic.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Catharsium.Git.Core.Logic.Tests.Configuration
{
    [TestClass]
    public class GitCoreLogicRegistrationTests
    {
        [TestMethod]
        public void AddTestingUtilities_RegistersDependencies()
        {
            var serviceCollection = Substitute.For<IServiceCollection>();
            var config = Substitute.For<IConfiguration>();

            serviceCollection.AddGitCoreLogic(config);
        }
    }
}