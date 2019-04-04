using Catharsium.GitTools.Core.Entities.Commands.Base;

namespace Catharsium.GitTools.Core.Entities.Commands.Git.Atomic
{
    public class GitPushCommandOptions : ICommandOptions
    {
        public bool All { get; set; }
    }
}