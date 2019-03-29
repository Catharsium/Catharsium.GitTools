using Catharsium.Util.Configuration.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catharsium.Git.Core.Logic.Configuration
{
    public static class GitCoreLogicRegistration
    {
        public static IServiceCollection AddGitCoreLogic(this IServiceCollection services, IConfiguration config)
        {
            var configuration = config.Load<GitCoreLogicConfiguration>();

            return services;
        }
    }
}