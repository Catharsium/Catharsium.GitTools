using System.Collections.Generic;
using Catharsium.GitTools.Core.Entities.Commands.Base;

namespace Catharsium.GitTools.Core.Entities.Commands.Git.Atomic
{
    public class GitPushCommand : BaseCommand<GitPushCommandOptions>, ICommand<GitPushCommandOptions>
    {
        public GitPushCommand(GitPushCommandOptions options) : base(options) { }


        public List<string> GetCommands()
        {
            var result = new List<string>();

            var all = this.Options.All ? " --all" : string.Empty;
            var remote = string.IsNullOrWhiteSpace(this.Options.Remote) ? string.Empty : $" {this.Options.Remote}";
            result.Add($"git push{all}{remote}");

            return result;
        }
    }
}