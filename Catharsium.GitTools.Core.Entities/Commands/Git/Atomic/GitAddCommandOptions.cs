using System.Collections.Generic;
using Catharsium.GitTools.Core.Entities.Commands.Base;

namespace Catharsium.GitTools.Core.Entities.Commands.Git.Atomic
{
    public class GitAddCommandOptions : ICommandOptions
    {
        public List<string> Files { get; set; }
        public bool Force { get; set; }
    }
}