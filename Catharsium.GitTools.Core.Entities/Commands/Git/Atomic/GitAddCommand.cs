using System.Collections.Generic;
using System.Linq;
using Catharsium.GitTools.Core.Entities.Commands.Base;

namespace Catharsium.GitTools.Core.Entities.Commands.Git.Atomic
{
    public class GitAddCommand : BaseCommand<GitAddCommandOptions>, ICommand<GitAddCommandOptions>
    {
        public GitAddCommand(GitAddCommandOptions options) : base(options)
        {
        }


        public List<string> GetCommands()
        {
            var result = new List<string>();
            var force = this.Options.Force ? " -f" : "";

            if (this.Options.Files != null && this.Options.Files.Any())
            {
                foreach (var file in this.Options.Files)
                {
                    result.Add($"git add \"{file}\"{force}");
                }
            }
            else
            {
                result.Add("git add *");
            }

            return result;
        }
    }
}