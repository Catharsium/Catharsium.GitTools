using System.Collections.Generic;
using Catharsium.GitTools.Core.Entities.Commands.Base;

namespace Catharsium.GitTools.Core.Entities.Commands.System
{
    public class ChangeDirectoryCommand : BaseCommand<ChangeDirectoryCommandOptions>, ICommand<ChangeDirectoryCommandOptions>
    {
        public ChangeDirectoryCommand(ChangeDirectoryCommandOptions options) : base(options)
        {
        }


        public List<string> GetCommands()
        {
            return new List<string> {
                $"cd \"{this.Options.Directory}\""
            };
        }
    }
}