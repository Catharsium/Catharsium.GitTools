using System;
using System.Collections.Generic;
using Catharsium.GitTools.Core.Entities.Interfaces;

namespace Catharsium.GitTools.Core.Entities.Commands
{
    public class AddCommand : BaseCommand<AddCommandOptions>, IGitCommand<AddCommandOptions>
    {
        private readonly AddCommandOptions options;


        public AddCommand(AddCommandOptions options) : base(options)
        {
            this.options = options;
        }


        public List<string> GetCommands()
        {
            var result = new List<string>();

            foreach (var file in this.Options.Files)
            {
                result.Add("git add " + file);
            }

            return result;
        }
    }
}