namespace Catharsium.GitTools.Core.Entities.Interfaces
{
    public interface IGitCommand<T> where T : IGitCommandOptions
    {
        void Execute();
    }
}