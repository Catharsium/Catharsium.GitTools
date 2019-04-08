using Catharsium.GitTools.Core.Entities.Commands.Base;

namespace Catharsium.GitTools.Core.Entities.Commands.Git.Atomic
{
    public class GitCommitCommandOptions : ICommandOptions 
    {
        public bool Stage { get; set; }
        public string Message { get; set; }
    }
}