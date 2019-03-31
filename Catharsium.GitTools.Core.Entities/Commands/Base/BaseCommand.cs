namespace Catharsium.GitTools.Core.Entities.Commands.Base
{
    public abstract class BaseCommand<T> where T : ICommandOptions
    {
        protected T Options { get; }


        protected BaseCommand(T options)
        {
            this.Options = options;
        }
    }
}