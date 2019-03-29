using Catharsium.GitTools.Core.Entities.Interfaces;

namespace Catharsium.GitTools.Core.Entities.Commands
{
    public abstract class BaseCommand<T> where T : IGitCommandOptions
    {
        protected T Options { get; }


        protected BaseCommand(T options)
        {
            this.Options = options;
        }
    }
}