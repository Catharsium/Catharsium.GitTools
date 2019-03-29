using System;
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


        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}