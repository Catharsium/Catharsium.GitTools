using Catharsium.GitTools.Core.Entities.Commands.Base;

namespace Catharsium.GitTools.Core.Entities.Commands.System
{
    public class ChangeDirectoryCommandOptions : ICommandOptions
    {
        public string Directory { get; set; }
    }
}