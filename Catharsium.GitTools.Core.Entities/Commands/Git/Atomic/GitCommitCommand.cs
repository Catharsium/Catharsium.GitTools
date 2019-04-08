using System.Collections.Generic;
using Catharsium.GitTools.Core.Entities.Commands.Base;

namespace Catharsium.GitTools.Core.Entities.Commands.Git.Atomic
{
    public class GitCommitCommand : BaseCommand<GitCommitCommandOptions>, ICommand<GitCommitCommandOptions>
    {
        public GitCommitCommand(GitCommitCommandOptions options) : base(options) { }


        public List<string> GetCommands()
        {
            var result = new List<string>();

            var all = this.Options.Stage ? " --all" : string.Empty;
            var message = string.IsNullOrWhiteSpace(this.Options.Message) ? string.Empty : $" -m \"{this.Options.Message}\"";
            result.Add($"git commit{all}{message}");

            return result;
        }
    }
}